
//******************************************************************************************************
//** Copyright (C) 2010-2013 重大网络教育学院
//** 创建人：桂书丛
//** 类名称\文件名：DBOperator
//** 类功能:数据库操作
//** 描 述：数据库操作
//** 创建日期：2013-1-30
//** 修改(&U)人：桂书丛
//** 修改(&U)日期：2013-1-30
//** 整理日期：2013-1-30
//******************************************************************************************************

using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using Microsoft.Win32;

namespace DBUtility
{
    public class DbOperator
    {
        private SqlConnection connection = null;
        public string MDFPath = null;
        public string LDFPath = null;
        public string DatabaseName = null;
        public DbOperator()
        {
            connection = new SqlConnection();
            //connection.ConnectionString = PubConstant.ConnectionString.Replace("CMS","MASTER");
            connection.ConnectionString = PubConstant.ConnectionString;
        }
        /// <summary>
        /// 检查是否存在指定数据库
        /// </summary>
        public bool InspectDatabase(string paramDBName)
        {
            bool Flag = false;
            DataSet dateSet = new DataSet();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = " SELECT * FROM sysobjects WHERE NAME='" + paramDBName + "' ";
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            try
            {
                if(connection.State==ConnectionState.Closed)
                    //connection.Open();
                dataAdapter.Fill(dateSet);
                //connection.Close();
                if (dateSet.Tables[0].Rows.Count >= 0)
                { 
                    Flag = true;
                }
                return Flag;
            }
            catch (Exception ex)
            {
                connection.Close();
                throw ex;
            }
        }
        /// <summary>
        /// 检查是否安装Sql server
        /// </summary>
        public bool InspectSqlserver()
        {
            try
            {
                RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE").OpenSubKey("Microsoft");
                bool Flag = false;
                foreach (string name in key.GetSubKeyNames())
                {
                    if (name == "Microsoft SQL Server")
                    {
                        Flag = true;
                        return Flag;
                        
                    }
                }
                if (!Flag)
                {
                    Flag = false;
                }
                return Flag;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 附加数据库(sp_attach_db [ @dbname = ] 'dbname', [ @filename1 = ] 'filename_n' [ ,...16 ])
        /// 其中dbname-要附加到服务器的数据库的名称,filename_n-数据库文件的物理名称，包括路径
        /// </summary>
        public void AttachDatabase()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_attach_db";
            command.Parameters.Add(new SqlParameter(@"dbname", SqlDbType.NVarChar));
            command.Parameters[@"dbname"].Value = DatabaseName;
            command.Parameters.Add(new SqlParameter(@"filename1", SqlDbType.NVarChar));
            command.Parameters[@"filename1"].Value = MDFPath;
            command.Parameters.Add(new SqlParameter(@"filename2", SqlDbType.NVarChar));
            command.Parameters[@"filename2"].Value = LDFPath;
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                //MessageBox.Show("附加数据库成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                connection.Close();
                throw ex;
            }
        }
        /// <summary>
        /// 分离数据库
        /// </summary>
        public void DetachDatabase()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = @"sp_detach_db";
            command.Parameters.Add(new SqlParameter(@"dbname", SqlDbType.NVarChar));
            command.Parameters[@"dbname"].Value = DatabaseName;
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                //MessageBox.Show("分离数据库成功!", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                connection.Close();
                throw ex;
                //MessageBox.Show(se.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// 备份数据库
        /// </summary>
        /// <param name="paramBackUpPath"></param>
        /// <returns></returns>
        public bool DataBaseBackUp(string paramBackUpPath)
        {
            int returnIntValue = -5;
            string SqlQuery = "BACKUP DATABASE [CMS] TO DISK ='" + paramBackUpPath + "'";
            try
            {
                DbHelperSQL.ExecuteNonQuery(SqlQuery);
                return true;
            }
            catch //(Exception ex)
            {
                //throw ex;
                return false;
            }
        }

        /// <summary>
        /// 还原数据库
        /// </summary>
        /// <param name="paramRecoverPath"></param>
        /// <returns></returns>
        public static bool DataBaseRecover(string paramRecoverPath)
        {
            int returnIntValue = -7;
            string SqlQuery = "RESTORE DATABASE [CMS] FROM DISK ='" + paramRecoverPath + "'";
            try
            {
                returnIntValue = DbHelperSQL.ExecuteNonQuery(SqlQuery);
                //if (returnIntValue > 0)
                return true;
                //else

            }
            catch //(Exception ex)
            {
                //throw ex;
                return false;
            }
        }
    }
}
