
//******************************************************************************************************
//** Copyright (C) 2010-2013 桂书丛
//** 创建人：桂书丛
//** 类名称\文件名：DbHelperSQL
//** 类功能：提供能用到的数据库访问方法
//** 描 述： 对数据库多种操作方法的封装
//** 创建日期：2013-1-14
//** 修改(&U)人：桂书丛
//** 修改(&U)日期：2013-2-12
//** 整理日期：2013-2-12
//******************************************************************************************************
using System;
using System.Collections.Generic;
using System.Text;

using System.IO;
using System.Data;
using System.Collections;
using System.Configuration;
using System.Data.SqlClient;

namespace DBUtility
{
    /// <summary>
    /// 数据访问基础类(基于OleDb)
    /// </summary>
    public class DbHelperSQL
    {
        //数据库连接字符串(app.config来配置)，可以动态更改connectionString支持多数据库.		
        private static string ConnectionString = PubConstant.ConnectionString;

        #region 数据库公用方法
        #region public static bool ColumnExists(string tableName, string columnName) 判断是否存在某表的某个字段
        /// <summary>
        /// 判断是否存在某表的某个字段
        /// </summary>
        /// <param name="tableName">表名称</param>
        /// <param name="columnName">列名称</param>
        /// <returns>是否存在</returns>
        public static bool ColumnExists(string tableName, string columnName)
        {
            string paramSqlQuery = " SELECT COUNT(1) FROM SYSCOLUMNS WHERE [ID]=OBJECT_ID('" + tableName + "') AND [NAME]='" + columnName + "'";
            object returnObjectValue = GetSingle(paramSqlQuery);
            if (returnObjectValue == null)
            {
                return false;
            }
            return Convert.ToInt32(returnObjectValue) > 0;
        }
        #endregion

        #region public static int GetMaxID(string FieldName, string TableName) 从表中获取指定列的最大值：注意目的列的类型为int
        /// <summary>
        /// 从表中获取指定列的最大值：注意目的列的类型为int
        /// </summary>
        /// <param name="FieldName">字段名称</param>
        /// <param name="TableName">表名称</param>
        /// <returns>最大值</returns>
        public static int GetMaxID(string FieldName, string TableName)
        {
            string paramSqlQuery = "SELECT MAX(" + FieldName + ")+1 FROM " + TableName;
            object returnObjectValue = GetSingle(paramSqlQuery);
            if (returnObjectValue == null)
            {
                return 1;
            }
            else
            {
                return int.Parse(returnObjectValue.ToString());
            }
        }
        #endregion

        public static bool Exists(string paramSqlQuery)
        {
            object returnObjectValue = GetSingle(paramSqlQuery);
            int cmdresult;
            if ((Object.Equals(returnObjectValue, null)) || (Object.Equals(returnObjectValue, System.DBNull.Value)))
            {
                cmdresult = 0;
            }
            else
            {
                cmdresult = int.Parse(returnObjectValue.ToString());
            }
            if (cmdresult == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        #region public static bool TabExists(string TableName) 表是否存在
        /// <summary>
        /// 表是否存在
        /// </summary>
        /// <param name="TableName">表名称</param>
        /// <returns>是否存在</returns>
        public static bool TabExists(string TableName)
        {
            string strsql = "SELECT COUNT(*) FROM SYSOBJECTS WHERE ID = OBJECT_ID(N'[" + TableName + "]') AND OBJECTPROPERTY(ID, N'ISUSERTABLE') = 1";
            object returnObjectValue = GetSingle(strsql);
            int cmdresult;
            if ((Object.Equals(returnObjectValue, null)) || (Object.Equals(returnObjectValue, System.DBNull.Value)))
            {
                cmdresult = 0;
            }
            else
            {
                cmdresult = int.Parse(returnObjectValue.ToString());
            }
            if (cmdresult == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        public static bool Exists(string paramSqlQuery, params SqlParameter[] cmdParms)
        {
            object returnObjectValue = GetSingle(paramSqlQuery, cmdParms);
            int cmdresult;
            if ((Object.Equals(returnObjectValue, null)) || (Object.Equals(returnObjectValue, System.DBNull.Value)))
            {
                cmdresult = 0;
            }
            else
            {
                cmdresult = int.Parse(returnObjectValue.ToString());
            }
            if (cmdresult == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #region 执行简单SQL语句方法

        #region  public static int ExecuteNonQuery(string paramStrQuery) 执行Insert,Upadate,Delete类SQL语句并返回(&B)受影响的行数
        /// <summary>
        /// 执行Insert,Upadate,Delete类SQL语句并返回(&B)受影响的行数
        /// </summary>
        /// <param name="paramStrQuery">SQL查询语句</param>
        /// <returns>受影响的行数</returns>
        public static int ExecuteNonQuery(string paramStrQuery)
        {
            try
            {
                return ExecuteSql(paramStrQuery);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region public static object ExecuteScalar(string paramstrSqlQuery) 执行查询，并返回(&B)查询所返回(&B)的结果集中第一行的第一列。忽略其他列或行。
        /// <summary>
        /// 执行查询，并返回(&B)查询所返回(&B)的结果集中第一行的第一列。忽略其他列或行。
        /// </summary>
        /// <param name="paramstrSqlQuery">SQL查询语句</param>
        /// <returns>第一行第一列的值</returns>
        public static object ExecuteScalar(string paramstrSqlQuery)
        {
            try
            {
                return GetSingle(paramstrSqlQuery);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region public static SqlDataReader GetDataReader(string paramSqlQuery)  通过制定的SQL查询语句返回(&B)SqlDataReader( 注意：调用该方法后，一定要对SqlDataReader进行Close )
        /// <summary>   
        /// 通过制定的SQL查询语句返回(&B)SqlDataReader( 注意：调用该方法后，一定要对SqlDataReader进行Close )
        /// </summary>
        /// <param name="paramSqlQuery">SQL语句</param>
        /// <returns>SqlDataReader</returns>
        public static SqlDataReader GetDataReader(string paramSqlQuery)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);//独立使用一个数据库连接，千万不能释放资源
            SqlCommand command = new SqlCommand(paramSqlQuery, connection);
            try
            {
                connection.Open();
                SqlDataReader myDataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
                return myDataReader;
            }
            catch (Exception ex)
            {
                connection.Close();
                throw ex;
            }
        }
        #endregion

        #region public static SqlDataReader GetDataReader(string paramSqlQuery, params SqlParameter[] paramParameters) 通过指定的SQL查询(其中包含参数)语句返回(&B)SqlDataReader( 注意：调用该方法后，一定要对SqlDataReader进行Close )
        /// <summary>
        /// 通过指定的SQL查询(其中包含参数)语句返回(&B)SqlDataReader( 注意：调用该方法后，一定要对SqlDataReader进行Close )
        /// </summary>
        /// <param name="paramSqlQuery">含参数的SQL语句</param>
        /// <param name="paramParameters">Sql参数</param>
        /// <returnsSqlDataReader></returns>
        public static SqlDataReader GetDataReader(string paramSqlQuery, params SqlParameter[] paramParameters)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);//独立使用一个数据库连接
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(paramSqlQuery, connection);
                command.Parameters.AddRange(paramParameters);
                SqlDataReader myDataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
                return myDataReader;
            }
            catch (Exception ex)
            {
                connection.Close();
                throw ex;
            }
        }
        #endregion

        #region static public DataTable GetDataTable(string paramsqlQuery) 获得一张数据表
        /// <summary>
        /// 获得一张数据表
        /// </summary>
        /// <param name="paramSqlQuery">SQL查询语句</param>
        /// <returns>数据表</returns>
        public static DataTable GetDataTable(string paramSqlQuery)
        {
            DataSet myDataSet = GetDataSet(paramSqlQuery);
            if (myDataSet.Tables.Count >= 1)
                return myDataSet.Tables[0];
            else
                return null;
        }
        #endregion

        #region private static int ExecuteSql(string SQLString) 对连接执行 Transact-SQL 语句并返回(&B)受影响的行数
        /// <summary>
        /// 对连接执行 Transact-SQL 语句并返回(&B)受影响的行数
        /// </summary>
        /// <param name="SQLString">SQL语句</param>
        /// <returns>影响的记录数</returns>
        private static int ExecuteSql(string SQLString)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(SQLString, connection))
                {
                    try
                    {
                        connection.Open();
                        int rows = command.ExecuteNonQuery();
                        return rows;
                    }
                    catch (System.Data.SqlClient.SqlException ex)
                    {
                        connection.Close();
                        throw ex;
                    }
                }
            }
        }
        #endregion

             /// <summary>
        /// 在指定的时间内执行SQL语句
        /// </summary>
        /// <param name="paramSqlQuery"></param>
        /// <param name="Times"></param>
        /// <returns></returns>
        public static int ExecuteSqlByTime(string paramSqlQuery, int Times)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(paramSqlQuery, connection))
                {
                    try
                    {
                        connection.Open();
                        command.CommandTimeout = Times;
                        int rows = command.ExecuteNonQuery();
                        return rows;
                    }
                    catch (System.Data.SqlClient.SqlException ex)
                    {
                        connection.Close();
                        throw ex;
                    }
                }
            }
        }

        //#region public static int ExecuteSqlTran(List<CommandInfo> list, List<CommandInfo> oracleCmdSqlList) 执行Sql和Oracle滴混合事务
        ///// <summary>
        ///// 执行Sql和Oracle滴混合事务
        ///// </summary>
        ///// <param name="list">SQL命令行列表</param>
        ///// <param name="oracleCmdSqlList">Oracle命令行列表</param>
        ///// <returns>执行结果 0-由于SQL造成事务失败 -1 由于Oracle造成事务失败 1-整体事务执行成功</returns>
        //public static int ExecuteSqlTran(List<CommandInfo> list, List<CommandInfo> oracleCmdSqlList)
        //{
        //    using (SqlConnection connection = new SqlConnection(ConnectionString))
        //    {
        //        connection.Open();
        //        SqlCommand command = new SqlCommand();
        //        command.Connection = connection;
        //        SqlTransaction tx = connection.BeginTransaction();
        //        command.Transaction = tx;
        //        try
        //        {
        //            foreach (CommandInfo myDE in list)
        //            {
        //                string cmdText = myDE.CommandText;
        //                SqlParameter[] cmdParms = (SqlParameter[])myDE.Parameters;
        //                PrepareCommand(command, connection, tx, cmdText, cmdParms);
        //                if (myDE.EffentNextType == EffentNextType.SolicitationEvent)
        //                {
        //                    if (myDE.CommandText.ToLower().IndexOf("count(") == -1)
        //                    {
        //                        tx.Rollback();
        //                        throw new Exception("违背要求" + myDE.CommandText + "必须符合select count(..的格式");
        //                        //return 0;
        //                    }

        //                    object returnObjectValue = command.ExecuteScalar();
        //                    bool isHave = false;
        //                    if (returnObjectValue == null && returnObjectValue == DBNull.Value)
        //                    {
        //                        isHave = false;
        //                    }
        //                    isHave = Convert.ToInt32(returnObjectValue) > 0;
        //                    if (isHave)
        //                    {
        //                        //引发事件
        //                        myDE.OnSolicitationEvent();
        //                    }
        //                }
        //                if (myDE.EffentNextType == EffentNextType.WhenHaveContine || myDE.EffentNextType == EffentNextType.WhenNoHaveContine)
        //                {
        //                    if (myDE.CommandText.ToLower().IndexOf("count(") == -1)
        //                    {
        //                        tx.Rollback();
        //                        throw new Exception("SQL:违背要求" + myDE.CommandText + "必须符合select count(..的格式");
        //                        //return 0;
        //                    }

        //                    object returnObjectValue = command.ExecuteScalar();
        //                    bool isHave = false;
        //                    if (returnObjectValue == null && returnObjectValue == DBNull.Value)
        //                    {
        //                        isHave = false;
        //                    }
        //                    isHave = Convert.ToInt32(returnObjectValue) > 0;

        //                    if (myDE.EffentNextType == EffentNextType.WhenHaveContine && !isHave)
        //                    {
        //                        tx.Rollback();
        //                        throw new Exception("SQL:违背要求" + myDE.CommandText + "返回(&B)值必须大于0");
        //                        //return 0;
        //                    }
        //                    if (myDE.EffentNextType == EffentNextType.WhenNoHaveContine && isHave)
        //                    {
        //                        tx.Rollback();
        //                        throw new Exception("SQL:违背要求" + myDE.CommandText + "返回(&B)值必须等于0");
        //                        //return 0;
        //                    }
        //                    continue;
        //                }
        //                int val = command.ExecuteNonQuery();
        //                if (myDE.EffentNextType == EffentNextType.ExcuteEffectRows && val == 0)
        //                {
        //                    tx.Rollback();
        //                    throw new Exception("SQL:违背要求" + myDE.CommandText + "必须有影响行");
        //                    //return 0;
        //                }
        //                command.Parameters.Clear();
        //            }
        //            string oraConnectionString = PubConstant.GetConnectionString("ConnectionStringPPC");
        //            bool returnObjectValue = OracleHelper.ExecuteSqlTran(oraConnectionString, oracleCmdSqlList);
        //            if (!returnObjectValue)
        //            {
        //                tx.Rollback();
        //                throw new Exception("Oracle执行失败");
        //                // return -1;
        //            }
        //            tx.Commit();
        //            return 1;
        //        }
        //        catch (System.Data.SqlClient.SqlException ex)
        //        {
        //            tx.Rollback();
        //            throw ex;
        //        }
        //        catch (Exception ex)
        //        {
        //            tx.Rollback();
        //            throw ex;
        //        }
        //    }
        //}
        //#endregion

        /// <summary>
        /// 执行多条SQL语句，实现数据库事务。
        /// </summary>
        /// <param name="SQLStringList">多条SQL语句</param>		
        public static int ExecuteSqlTran(List<String> SQLStringList)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                SqlTransaction tx = connection.BeginTransaction();
                command.Transaction = tx;
                try
                {
                    int count = 0;
                    for (int n = 0; n < SQLStringList.Count; n++)
                    {
                        string strsql = SQLStringList[n];
                        if (strsql.Trim().Length > 1)
                        {
                            command.CommandText = strsql;
                            count += command.ExecuteNonQuery();
                        }
                    }
                    tx.Commit();
                    return count;
                }
                catch
                {
                    tx.Rollback();
                    return 0;
                }
            }
        }
        /// <summary>
        /// 执行带一个存储过程参数的的SQL语句。
        /// </summary>
        /// <param name="paramSqlQuery">SQL语句</param>
        /// <param name="content">参数内容,比如一个字段是格式复杂的文章，有特殊符号，可以通过这个方式添加</param>
        /// <returns>影响的记录数</returns>
        public static int ExecuteSql(string paramSqlQuery, string content)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(paramSqlQuery, connection);
                System.Data.SqlClient.SqlParameter myParameter = new System.Data.SqlClient.SqlParameter("@content", SqlDbType.NText);
                myParameter.Value = content;
                command.Parameters.Add(myParameter);
                try
                {
                    connection.Open();
                    int rows = command.ExecuteNonQuery();
                    return rows;
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
            }
        }
        /// <summary>
        /// 执行带一个存储过程参数的的SQL语句。
        /// </summary>
        /// <param name="paramSqlQuery">SQL语句</param>
        /// <param name="content">参数内容,比如一个字段是格式复杂的文章，有特殊符号，可以通过这个方式添加</param>
        /// <returns>影响的记录数</returns>
        public static object ExecuteSqlGet(string paramSqlQuery, string content)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(paramSqlQuery, connection);
                System.Data.SqlClient.SqlParameter myParameter = new System.Data.SqlClient.SqlParameter("@content", SqlDbType.NText);
                myParameter.Value = content;
                command.Parameters.Add(myParameter);
                try
                {
                    connection.Open();
                    object returnObjectValue = command.ExecuteScalar();
                    if ((Object.Equals(returnObjectValue, null)) || (Object.Equals(returnObjectValue, System.DBNull.Value)))
                    {
                        return null;
                    }
                    else
                    {
                        return returnObjectValue;
                    }
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
            }
        }
        /// <summary>
        /// 向数据库里插入图像格式的字段(和上面情况类似的另一种实例)
        /// </summary>
        /// <param name="paramSqlQuery">SQL语句</param>
        /// <param name="fs">图像字节,数据库的字段类型为image的情况</param>
        /// <returns>影响的记录数</returns>
        public static int ExecuteSqlInsertImg(string paramSqlQuery, byte[] fs)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(paramSqlQuery, connection);
                System.Data.SqlClient.SqlParameter myParameter = new System.Data.SqlClient.SqlParameter("@fs", SqlDbType.Image);
                myParameter.Value = fs;
                command.Parameters.Add(myParameter);
                try
                {
                    connection.Open();
                    int rows = command.ExecuteNonQuery();
                    return rows;
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// 执行一条计算查询结果语句，返回(&B)查询结果（object）。
        /// </summary>
        /// <param name="paramSqlQuery">计算查询结果语句</param>
        /// <returns>查询结果（object）</returns>
        public static object GetSingle(string paramSqlQuery)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(paramSqlQuery, connection))
                {
                    try
                    {
                        connection.Open();
                        object returnObjectValue = command.ExecuteScalar();
                        if ((Object.Equals(returnObjectValue, null)) || (Object.Equals(returnObjectValue, System.DBNull.Value)))
                        {
                            return null;
                        }
                        else
                        {
                            return returnObjectValue;
                        }
                    }
                    catch (System.Data.SqlClient.SqlException ex)
                    {
                        connection.Close();
                        throw ex;
                    }
                }
            }
        }

        /// <summary>
        /// 在指定时间内获得单个查询信息
        /// </summary>
        /// <param name="paramSqlQuery"></param>
        /// <param name="Times"></param>
        /// <returns></returns>
        public static object GetSingle(string paramSqlQuery, int Times)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(paramSqlQuery, connection))
                {
                    try
                    {
                        connection.Open();
                        command.CommandTimeout = Times;
                        object returnObjectValue = command.ExecuteScalar();
                        if ((Object.Equals(returnObjectValue, null)) || (Object.Equals(returnObjectValue, System.DBNull.Value)))
                        {
                            return null;
                        }
                        else
                        {
                            return returnObjectValue;
                        }
                    }
                    catch (System.Data.SqlClient.SqlException ex)
                    {
                        connection.Close();
                        throw ex;
                    }
                }
            }
        }

        /// <summary>
        /// 获得指定数据集
        /// </summary>
        /// <param name="paramSqlQuery"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(string paramSqlQuery)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                DataSet ds = new DataSet();
                try
                {
                    connection.Open();
                    SqlDataAdapter command = new SqlDataAdapter(paramSqlQuery, connection);
                    command.Fill(ds, "ds");
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                return ds;
            }
        }

        /// <summary>
        /// 在规定时间内获得指定数据集
        /// </summary>
        /// <param name="paramSqlQuery"></param>
        /// <param name="Times"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(string paramSqlQuery, int Times)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                DataSet ds = new DataSet();
                try
                {
                    connection.Open();
                    SqlDataAdapter command = new SqlDataAdapter(paramSqlQuery, connection);
                    command.SelectCommand.CommandTimeout = Times;
                    command.Fill(ds, "ds");
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                return ds;
            }
        }
        #endregion   

        #region 执行带参数的SQL语句

        /// <summary>
        /// 执行SQL语句，返回(&B)影响的记录数
        /// </summary>
        /// <param name="SQLString">SQL语句</param>
        /// <returns>影响的记录数</returns>
        public static int ExecuteSql(string SQLString, params SqlParameter[] cmdParms)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    try
                    {
                        PrepareCommand(command, connection, null, SQLString, cmdParms);
                        int rows = command.ExecuteNonQuery();
                        command.Parameters.Clear();
                        return rows;
                    }
                    catch (System.Data.SqlClient.SqlException ex)
                    {
                        throw ex;
                    }
                }
            }
        }


        /// <summary>
        /// 执行多条SQL语句，实现数据库事务。
        /// </summary>
        /// <param name="SQLStringList">SQL语句的哈希表（key为SqlQuery语句，value是该语句的SqlParameter[]）</param>
        public static void ExecuteSqlTran(Hashtable SQLStringList)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlTransaction trans = connection.BeginTransaction())
                {
                    SqlCommand command = new SqlCommand();
                    try
                    {
                        //循环
                        foreach (DictionaryEntry myDE in SQLStringList)
                        {
                            string cmdText = myDE.Key.ToString();
                            SqlParameter[] cmdParms = (SqlParameter[])myDE.Value;
                            PrepareCommand(command, connection, trans, cmdText, cmdParms);
                            int val = command.ExecuteNonQuery();
                            command.Parameters.Clear();
                        }
                        trans.Commit();
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }
        /// <summary>
        /// 执行多条SQL语句，实现数据库事务。
        /// </summary>
        /// <param name="SQLStringList">SQL语句的哈希表（key为SqlQuery语句，value是该语句的SqlParameter[]）</param>
        public static int ExecuteSqlTran(System.Collections.Generic.List<CommandInfo> cmdList)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlTransaction trans = connection.BeginTransaction())
                {
                    SqlCommand command = new SqlCommand();
                    try
                    {
                        int count = 0;
                        //循环
                        foreach (CommandInfo myDE in cmdList)
                        {
                            string cmdText = myDE.CommandText;
                            SqlParameter[] cmdParms = (SqlParameter[])myDE.Parameters;
                            PrepareCommand(command, connection, trans, cmdText, cmdParms);

                            if (myDE.EffentNextType == EffentNextType.WhenHaveContine || myDE.EffentNextType == EffentNextType.WhenNoHaveContine)
                            {
                                if (myDE.CommandText.ToLower().IndexOf("count(") == -1)
                                {
                                    trans.Rollback();
                                    return 0;
                                }

                                object obj = command.ExecuteScalar();
                                bool isHave = false;
                                if (obj == null && obj == DBNull.Value)
                                {
                                    isHave = false;
                                }
                                isHave = Convert.ToInt32(obj) > 0;

                                if (myDE.EffentNextType == EffentNextType.WhenHaveContine && !isHave)
                                {
                                    trans.Rollback();
                                    return 0;
                                }
                                if (myDE.EffentNextType == EffentNextType.WhenNoHaveContine && isHave)
                                {
                                    trans.Rollback();
                                    return 0;
                                }
                                continue;
                            }
                            int val = command.ExecuteNonQuery();
                            count += val;
                            if (myDE.EffentNextType == EffentNextType.ExcuteEffectRows && val == 0)
                            {
                                trans.Rollback();
                                return 0;
                            }
                            command.Parameters.Clear();
                        }
                        trans.Commit();
                        return count;
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }
        /// <summary>
        /// 执行多条SQL语句，实现数据库事务。
        /// </summary>
        /// <param name="SQLStringList">SQL语句的哈希表（key为SqlQuery语句，value是该语句的SqlParameter[]）</param>
        public static void ExecuteSqlTranWithIndentity(System.Collections.Generic.List<CommandInfo> SQLStringList)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlTransaction trans = connection.BeginTransaction())
                {
                    SqlCommand command = new SqlCommand();
                    try
                    {
                        int indentity = 0;
                        //循环
                        foreach (CommandInfo myDE in SQLStringList)
                        {
                            string cmdText = myDE.CommandText;
                            SqlParameter[] cmdParms = (SqlParameter[])myDE.Parameters;
                            foreach (SqlParameter q in cmdParms)
                            {
                                if (q.Direction == ParameterDirection.InputOutput)
                                {
                                    q.Value = indentity;
                                }
                            }
                            PrepareCommand(command, connection, trans, cmdText, cmdParms);
                            int val = command.ExecuteNonQuery();
                            foreach (SqlParameter q in cmdParms)
                            {
                                if (q.Direction == ParameterDirection.Output)
                                {
                                    indentity = Convert.ToInt32(q.Value);
                                }
                            }
                            command.Parameters.Clear();
                        }
                        trans.Commit();
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }
        /// <summary>
        /// 执行多条SQL语句，实现数据库事务。
        /// </summary>
        /// <param name="SQLStringList">SQL语句的哈希表（key为SqlQuery语句，value是该语句的SqlParameter[]）</param>
        public static void ExecuteSqlTranWithIndentity(Hashtable SQLStringList)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlTransaction trans = connection.BeginTransaction())
                {
                    SqlCommand command = new SqlCommand();
                    try
                    {
                        int indentity = 0;
                        //循环
                        foreach (DictionaryEntry myDE in SQLStringList)
                        {
                            string cmdText = myDE.Key.ToString();
                            SqlParameter[] cmdParms = (SqlParameter[])myDE.Value;
                            foreach (SqlParameter q in cmdParms)
                            {
                                if (q.Direction == ParameterDirection.InputOutput)
                                {
                                    q.Value = indentity;
                                }
                            }
                            PrepareCommand(command, connection, trans, cmdText, cmdParms);
                            int val = command.ExecuteNonQuery();
                            foreach (SqlParameter q in cmdParms)
                            {
                                if (q.Direction == ParameterDirection.Output)
                                {
                                    indentity = Convert.ToInt32(q.Value);
                                }
                            }
                            command.Parameters.Clear();
                        }
                        trans.Commit();
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }
        /// <summary>
        /// 执行一条计算查询结果语句，返回(&B)查询结果（object）。
        /// </summary>
        /// <param name="SQLString">计算查询结果语句</param>
        /// <returns>查询结果（object）</returns>
        public static object GetSingle(string SQLString, params SqlParameter[] cmdParms)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    try
                    {
                        PrepareCommand(command, connection, null, SQLString, cmdParms);
                        object obj = command.ExecuteScalar();
                        command.Parameters.Clear();
                        if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                        {
                            return null;
                        }
                        else
                        {
                            return obj;
                        }
                    }
                    catch (System.Data.SqlClient.SqlException ex)
                    {
                        throw ex;
                    }
                }
            }
        }

        /// <summary>
        /// 执行查询语句，返回(&B)DataSet
        /// </summary>
        /// <param name="SQLString">查询语句</param>
        /// <returns>DataSet</returns>
        public static DataSet GetDataSet(string SQLString, params SqlParameter[] cmdParms)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand();
                PrepareCommand(command, connection, null, SQLString, cmdParms);
                using (SqlDataAdapter da = new SqlDataAdapter(command))
                {
                    DataSet ds = new DataSet();
                    try
                    {
                        da.Fill(ds, "ds");
                        command.Parameters.Clear();
                    }
                    catch (System.Data.SqlClient.SqlException ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    return ds;
                }
            }
        }

        private static void PrepareCommand(SqlCommand command, SqlConnection connection, SqlTransaction trans, string cmdText, SqlParameter[] cmdParms)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            command.Connection = connection;
            command.CommandText = cmdText;
            if (trans != null)
                command.Transaction = trans;
            command.CommandType = CommandType.Text;//cmdType;
            if (cmdParms != null)
            {


                foreach (SqlParameter parameter in cmdParms)
                {
                    if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) &&
                        (parameter.Value == null))
                    {
                        parameter.Value = DBNull.Value;
                    }
                    command.Parameters.Add(parameter);
                }
            }
        }

        #endregion

        #region 数据库执行存储过程方法

        #region public void ExecNonReturnProc(string paramStoredProcName,params SqlParameter[] paramParameters) 执行无返回(&B)的存储过程
        /// <summary> 
        /// 执行无返回(&B)的存储过程
        /// </summary>
        /// <param name="paramStoredProcName">存储过程名称</param>
        /// <param name="paramParameters">存储过程参数</param>
        public static void ExecNonReturnProc(string paramStoredProcName, params SqlParameter[] paramParameters)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = GetProcCommand(connection,paramStoredProcName, paramParameters);
                try
                {
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    command.Connection.Close();
                    throw ex;
                }
            }
        }
        #endregion

        #region public object ExecReturnSingleProc(string paramStoredProcName,params SqlParameter[] paramParameters) 执行有返回(&B)的存储过程
        /// <summary> 
        /// 执行有返回(&B)的存储过程:此方法以提供一个为@ReturnValue的输出参数
        /// </summary>
        /// <param name="paramStoredProcName">存储过程名称</param>
        /// <param name="paramParameters">存储过程参数</param>
        /// <returns>object</returns>
        public static object ExecReturnSingleProc(string paramStoredProcName, params SqlParameter[] paramParameters)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = GetProcCommand(connection, paramStoredProcName, paramParameters);
                SqlParameter paramter = new SqlParameter("@ReturnValue", SqlDbType.NVarChar, 1000);
                paramter.Direction = ParameterDirection.Output;
                command.Parameters.Add(paramter);
                try
                {
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    return paramter.Value;
                }
                catch (Exception ex)
                {
                    command.Connection.Close();
                    throw ex;
                }
            }
        }
        #endregion 

        
        /// <summary>
        /// 执行存储过程，返回(&B)SqlDataReader ( 注意：调用该方法后，一定要对SqlDataReader进行Close )
        /// </summary>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <returns>SqlDataReader</returns>
        public static SqlDataReader RunProcedure(string storedProcName, IDataParameter[] parameters)
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                SqlDataReader returnReader;
                connection.Open();
                SqlCommand command = GetProcCommand(connection, storedProcName, parameters);
                command.CommandType = CommandType.StoredProcedure;
                returnReader = command.ExecuteReader(CommandBehavior.CloseConnection);
                return returnReader;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <param name="tableName">DataSet结果中的表名</param>
        /// <returns>DataSet</returns>
        public static DataSet ExecGetDataSetProc(string storedProcName, IDataParameter[] parameters, string tableName)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                DataSet dataSet = new DataSet();
                connection.Open();
                SqlDataAdapter myDA = new SqlDataAdapter();
                myDA.SelectCommand = GetProcCommand(connection, storedProcName, parameters);
                myDA.Fill(dataSet, tableName);
                connection.Close();
                return dataSet;
            }
        }
        public static DataSet ExecGetDataSetProc(string storedProcName, IDataParameter[] parameters, string tableName, int Times)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                DataSet dataSet = new DataSet();
                connection.Open();
                SqlDataAdapter myDA = new SqlDataAdapter();
                myDA.SelectCommand = GetProcCommand(connection, storedProcName, parameters);
                myDA.SelectCommand.CommandTimeout = Times;
                myDA.Fill(dataSet, tableName);
                connection.Close();
                return dataSet;
            }
        }

        /// <summary>
        /// 构建 SqlCommand 对象(用来返回(&B)一个结果集，而不是一个整数值)
        /// </summary>
        /// <param name="connection">数据库连接</param>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <returns>SqlCommand</returns>
        private static SqlCommand GetProcCommand(SqlConnection connection, string storedProcName, IDataParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(storedProcName, connection);
            command.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter parameter in parameters)
            {
                if (parameter != null)
                {
                    // 检查未分配值的输出参数,将其分配以DBNull.Value.
                    if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) &&
                        (parameter.Value == null))
                    {
                        parameter.Value = DBNull.Value;
                    }
                    command.Parameters.Add(parameter);
                }
            }

            return command;
        }
        #endregion
    }
}
