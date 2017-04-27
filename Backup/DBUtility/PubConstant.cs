
//*************************************************************************************************
//** Copyright (c) 2010-2013 重大网络教育学院
//** 创建人：桂书丛
//** 类名称\文件名：PubConstant
//** 类功能：获取操作常量
//** 描 述：主要是数据库连接字符串
//** 创建日期：2013-2-12
//** 修改(&U)人：桂书丛
//** 修改(&U)日期：2013-2-12
//** 整理日期：2013-2-12
//*************************************************************************************************

using System;
using System.Configuration;
namespace DBUtility
{
    public class PubConstant
    {
        private static string _connectionstring=string.Empty;
        
        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        public static string ConnectionString
        {
            get
            {
                if (_connectionstring == string.Empty)
                    _connectionstring = GetConnectionString();
                return _connectionstring;
            }
        }

        /// <summary>
        /// 获取连接字符串
        /// </summary>
        private static string GetConnectionString()
        {
            try
            {
                bool tempConStringEncrypt = Convert.ToBoolean(ConfigurationManager.AppSettings["ConStringEncrypt"]);
                string returnConString =string.Empty,tempConString = string.Empty;
                if (tempConStringEncrypt == true)
                {
                    tempConString = ConfigurationManager.AppSettings["ConCiphertextString"].ToString();
                    AssemblyAttribute tempAACall = new AssemblyAttribute();
                    string tempKey = tempAACall.AssemblyDescription + "By" + tempAACall.AssemblyCompany;
                    returnConString = DbEncrypt.DESDecrypt(tempConString, tempKey);
                }
                else
                    returnConString = ConfigurationManager.AppSettings["ConExpresslyString"].ToString();
                return returnConString;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
