
//*************************************************************************************************
//** Copyright (c) 2010-2013 �ش��������ѧԺ
//** �����ˣ������
//** ������\�ļ�����PubConstant
//** �๦�ܣ���ȡ��������
//** �� ������Ҫ�����ݿ������ַ���
//** �������ڣ�2013-2-12
//** �޸�(&U)�ˣ������
//** �޸�(&U)���ڣ�2013-2-12
//** �������ڣ�2013-2-12
//*************************************************************************************************

using System;
using System.Configuration;
namespace DBUtility
{
    public class PubConstant
    {
        private static string _connectionstring=string.Empty;
        
        /// <summary>
        /// ���ݿ������ַ���
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
        /// ��ȡ�����ַ���
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
