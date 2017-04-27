
//******************************************************************************************************
//** Copyright (C) 2010-2013 重大网络教育学院
//** 创建人：桂书丛
//** 类名称\文件名：BaseClass
//** 类功能：提供能用到的数据库访问方法
//** 描 述：对数据库多种操作方法的封装
//** 创建日期：2013-1-14
//** 修改(&U)人：桂书丛
//** 修改(&U)日期：2013-1-14
//** 整理日期：2013-1-14
//******************************************************************************************************

using System;
using System.Collections.Generic;
using System.Text;

using System.IO;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using CMS.CommonLayer;
namespace DBUtility
{
    public class DbHelper
    {
        #region  私有字段
        private string ConString = string.Empty;
        private SqlConnection mySqlConnection;
        #endregion

        #region public DBHelper() 构造函数，初始化类实例
        /// <summary>
        /// 构造函数，初始化类实例
        /// </summary>
        public DbHelper()
        {
            try
            {
                bool tempConStringEncrypt = Convert.ToBoolean(ConfigurationManager.AppSettings["ConStringEncrypt"]);
                string tempConString = string.Empty;
                if (tempConStringEncrypt == true)
                {
                    tempConString = ConfigurationManager.AppSettings["ConCiphertextString"].ToString();
                    this.ConString = DbEncrypt.DESDecrypt(tempConString, "SIMByZMM");
                }
                else
                    this.ConString = ConfigurationManager.AppSettings["ConExpresslyString"].ToString();
                this.mySqlConnection = new SqlConnection(this.ConString);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region ============数据库执行SQL语句方法============
        #region  public int ExecuteNonQuery(string paramStrQuery) 执行SQL语句Insert,Upadate,Delete
        /// <summary>
        /// 执行Insert,Upadate,Delete类SQL语句并返回(&B)受影响的行数
        /// </summary>
        /// <param name="paramStrQuery">SQL查询语句</param>
        /// <returns>受影响的行数</returns>
        public int ExecuteNonQuery(string paramStrQuery)
        {
            int returnIntValue = 0;
            try
            {
                mySqlConnection.Open();
                SqlCommand mySqlCommand = new SqlCommand(paramStrQuery, mySqlConnection);
                returnIntValue = mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                mySqlConnection.Close();
                throw ex;
            }
            finally
            {
                mySqlConnection.Close();
            }
            return returnIntValue;
        }
        #endregion

        #region public int ExecuteSqlInsertImg(string SqlQuery, byte[] photeFileStream) 向数据库里插入图像格式的字段
        /// <summary>
        /// 向数据库里插入图像格式的字段
        /// </summary>
        /// <param name="SqlQuery">SQL语句</param>
        /// <param name="photeFileStream">图像字节,数据库的字段类型为image的情况</param>
        /// <returns>影响的记录数</returns>
        public int ExecuteSqlInsertImg(string paramSqlQuery, byte[] paramPhoteFileStream)
        {
            SqlCommand mySqlCommand = new SqlCommand(paramSqlQuery, mySqlConnection);
            SqlParameter mySqlParameter = new SqlParameter("@pFS", SqlDbType.Image);
            mySqlParameter.Value = paramPhoteFileStream;
            mySqlCommand.Parameters.Add(mySqlParameter);
            try
            {
                mySqlConnection.Open();
                int rows = mySqlCommand.ExecuteNonQuery();
                return rows;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                mySqlCommand.Dispose();
                mySqlConnection.Close();
            }
        }
        #endregion

        #region  public object ExecuteScalar(string paramstrSqlQuery) 返回(&B)第一行第一列
        /// <summary>
        /// 执行查询，并返回(&B)查询所返回(&B)的结果集中第一行的第一列。忽略其他列或行。
        /// </summary>
        /// <param name="paramstrSqlQuery">SQL查询语句</param>
        /// <returns>第一行第一列的值</returns>
        public object ExecuteScalar(string paramstrSqlQuery)
        {
            object returnObjValue = null;
            try
            {
                mySqlConnection.Open();
                SqlCommand mySqlCommand = new SqlCommand(paramstrSqlQuery, mySqlConnection);
                returnObjValue = mySqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                mySqlConnection.Close();
                throw ex;
            }
            finally
            {
                mySqlConnection.Close();
            }
            return returnObjValue;
        }
        #endregion

        #region public SqlDataReader GetDataReader(string paramSqlQuery)  通过制定的SQL查询语句返回(&B)SqlDataReader( 注意：调用该方法后，一定要对SqlDataReader进行Close )
        /// <summary>   
        /// 通过制定的SQL查询语句返回(&B)SqlDataReader( 注意：调用该方法后，一定要对SqlDataReader进行Close )
        /// </summary>
        /// <param name="paramSqlQuery">SQL语句</param>
        /// <returns>SqlDataReader</returns>
        public SqlDataReader GetDataReader(string paramSqlQuery)
        {
            SqlConnection tempSqlConnection = new SqlConnection(this.ConString);//独立使用一个数据库连接
            try
            {
                tempSqlConnection.Open();
                SqlCommand mySqlCommand = new SqlCommand(paramSqlQuery, tempSqlConnection);
                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
                return mySqlDataReader;
            }
            catch (Exception ex)
            {
                mySqlConnection.Close();
                throw ex;
            }
        }
        #endregion

        #region public SqlDataReader GetDataReader(string paramSqlQuery, params SqlParameter[] paramParameters) 通过制定的SQL查询(其中包含参数)语句返回(&B)SqlDataReader( 注意：调用该方法后，一定要对SqlDataReader进行Close )
        /// <summary>
        /// 通过制定的SQL查询(其中包含参数)语句返回(&B)SqlDataReader( 注意：调用该方法后，一定要对SqlDataReader进行Close )
        /// </summary>
        /// <param name="paramSqlQuery">含参数的SQL语句</param>
        /// <param name="paramParameters">Sql参数</param>
        /// <returnsSqlDataReader></returns>
        public SqlDataReader GetDataReader(string paramSqlQuery, params SqlParameter[] paramParameters)
        {
            SqlConnection tempSqlConnection = new SqlConnection(this.ConString);//独立使用一个数据库连接
            try
            {
                tempSqlConnection.Open();
                SqlCommand mySqlCommand = new SqlCommand(paramSqlQuery, tempSqlConnection);
                mySqlCommand.Parameters.AddRange(paramParameters);
                SqlDataReader myDataReader = mySqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
                return myDataReader;
            }
            catch (Exception ex)
            {
                mySqlConnection.Close();
                throw ex;
            }
        }
        #endregion

        #region private GetDataSet Fill(string paramsqlQuery) 返回(&B)数据集
        /// <summary>
        /// 返回(&B)数据集
        /// </summary>
        /// <param name="paramSqlQuery">SQL查询语句</param>
        /// <returns></returns>
        private DataSet GetDataSet(string paramSqlQuery)
        {
            DataSet myDataSet = new DataSet();
            try
            {
                mySqlConnection.Open();
                SqlCommand mySqlCommand = new SqlCommand(paramSqlQuery, mySqlConnection);
                SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(mySqlCommand);//获取数据
                mySqlDataAdapter.Fill(myDataSet);
            }
            catch (Exception ex)
            {
                mySqlConnection.Close();
                throw ex;
            }
            finally
            {
                mySqlConnection.Close();
            }
            return myDataSet;
        }
        #endregion

        #region public DataTable GetDataTable(string paramsqlQuery) 返回(&B)一张数据表
        /// <summary>
        /// 返回(&B)一张数据表
        /// </summary>
        /// <param name="paramSqlQuery">SQL查询语句</param>
        /// <returns>数据表</returns>
        public DataTable GetDataTable(string paramSqlQuery)
        {
            DataSet myDataSet = GetDataSet(paramSqlQuery);
            if (myDataSet.Tables.Count >= 1)
                return myDataSet.Tables[0];
            else
                return null;
        }
        #endregion
        #endregion

        #region ============数据库执行存储过程方法============
        #region public void ExecNonReturnProc(string paramStoredProcName,params SqlParameter[] paramParameters) 执行无返回(&B)的存储过程
        /// <summary> 
        /// 执行无返回(&B)的存储过程
        /// </summary>
        /// <param name="paramStoredProcName">存储过程名称</param>
        /// <param name="paramParameters">存储过程参数</param>
        public void ExecNonReturnProc(string paramStoredProcName, params SqlParameter[] paramParameters)
        {
            SqlCommand mySqlCommand = GetProcCommand(paramStoredProcName, paramParameters);
            try
            {
                mySqlConnection.Open();
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                mySqlConnection.Close();
                throw ex;
            }
            finally
            {
                mySqlConnection.Close();
            }
        }
        #endregion

        #region private SqlCommand GetProcCommand(string paramStoredProcName, params SqlParameter[] paramParameters) 构建针对存储过程的SqlCommand对象
        /// <summary>
        /// 构建针对存储过程的SqlCommand对象
        /// </summary>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <returns>SqlCommand</returns>
        private SqlCommand GetProcCommand(string paramStoredProcName, params SqlParameter[] paramParameters)
        {
            SqlCommand mySqlCommand = new SqlCommand(paramStoredProcName, mySqlConnection);
            mySqlCommand.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter parameter in paramParameters)
            {
                if (parameter != null)
                {
                    // 检查未分配值的输出参数,将其分配以DBNull.Value.
                    if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) &&
                        (parameter.Value == null))
                    {
                        parameter.Value = DBNull.Value;
                    }
                    mySqlCommand.Parameters.Add(parameter);
                }
            }
            return mySqlCommand;
        }
        #endregion

        #region public object ExecReturnSingleProc(string paramStoredProcName,params SqlParameter[] paramParameters) 执行有返回(&B)的存储过程
        /// <summary> 
        /// 执行有返回(&B)的存储过程:此方法以提供一个为@ReturnValue的输出参数
        /// </summary>
        /// <param name="paramStoredProcName">存储过程名称</param>
        /// <param name="paramParameters">存储过程参数</param>
        /// <returns>object</returns>
        public object ExecReturnSingleProc(string paramStoredProcName, params SqlParameter[] paramParameters)
        {
            SqlCommand mySqlCommand = GetProcCommand(paramStoredProcName, paramParameters);
            SqlParameter mySqlParameter = new SqlParameter("@ReturnValue", SqlDbType.NVarChar, 1000);
            mySqlParameter.Direction = ParameterDirection.Output;
            mySqlCommand.Parameters.Add(mySqlParameter);
            try
            {
                mySqlConnection.Open();
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                mySqlConnection.Close();
                throw ex;
            }
            finally
            {
                mySqlConnection.Close();
            }
            return mySqlParameter.Value;
        }
        #endregion

        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="paramStoredProcName">存储过程名</param>
        /// <param name="paramParameters">存储过程参数</param>
        /// <returns>DataSet</returns>
        public DataSet ExecGetDataSetProc(string paramStoredProcName, params SqlParameter[] paramParameters)
        {
            SqlCommand mySqlCommand = GetProcCommand(paramStoredProcName, paramParameters);
            DataSet returnDataSet = new DataSet();
            try
            {
                mySqlConnection.Open();
                SqlDataAdapter mySqlDA = new SqlDataAdapter();
                mySqlDA.SelectCommand = mySqlCommand;
                mySqlDA.Fill(returnDataSet);
            }
            catch (Exception ex)
            {
                mySqlConnection.Close();
                throw ex;
            }
            finally
            {
                mySqlConnection.Close();
            }
            return returnDataSet;
        }
        #endregion
    }
}

