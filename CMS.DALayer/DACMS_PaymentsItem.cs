using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

using CMS.Model;
using DBUtility;

///
namespace CMS.DALayer
{
	/// <summary>
	/// ���ݷ�����DACMS_PaymentsItem 
	/// </summary>
    public class DACMS_PaymentsItem : IDALayer<ModelCMS_PaymentsItem>
    {
        #region �������
        int returnIntValue = -5;
        #endregion

        #region IDALayer<ModelCMS_PaymentsItem> ��Ա

        public DataTable GetOrder(bool IsView, string paramField, string paramContent, bool IsFuzzy)
        {
            DataTable myDataTable = null;
            string SqlQuery = " SELECT * FROM  ";
            if (IsView == false)
                SqlQuery += " [CMS_PaymentsItem] ";
            else
                SqlQuery += string.Empty;
            if (paramField.Length != 0)
            {
                if (IsFuzzy == false)
                    SqlQuery += " WHERE " + paramField + " = '" + paramContent + "'";
                else
                    SqlQuery += " WHERE " + paramField + " LIKE '" + paramContent + "'";
            }
            try
            {
                myDataTable = DbHelperSQL.GetDataTable(SqlQuery);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return myDataTable;
        }

        public DataTable GetOrder(bool IsView, string paramField, DateTime paramStart, DateTime paramEnd)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ����һ�����ݼ�¼
        /// </summary>
        /// <param name="model">ʵ����ʵ��</param>
        /// <returns></returns>
        /// �����ˣ� �����
        /// �������ڣ�2013-02-22
        public int Update(ModelCMS_PaymentsItem model)
        {
            string sqlQuery = " UPDATE [CMS_PaymentsItem]"
                              + " SET [Type] = '" + model.Type + "',"
                              + "[Name] = '" + model.Name + "',"
                              + "[Description] = '" + model.Description + "',"
                              + "[ModifyPerson] = '" + model.ModifyPerson + "',"
                              + "[ModifyDate] = '" + model.ModifyDate + "'"
                              + "WHERE [ID]=" + model.ID;
            try
            {
                returnIntValue = DbHelperSQL.ExecuteNonQuery(sqlQuery);
                return returnIntValue;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// ����һ�����ݼ�¼
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// �����ˣ������
        /// �������ڣ�2013-02-22
        public int Insert(ModelCMS_PaymentsItem model)
        {
            string SqlQuery = " INSERT INTO [CMS_PaymentsItem] "
                + "([Type]"
                + ",[Name]"
                + ",[Description]"
                + ",[CreatePerson]"
                + ",[CreateDate]"
                + " ) VALUES ( "
                + "'" + model.Type + "'"
                + ",'" + model.Name + "'"
                + ",'" + model.Description + "'"
                + ",'" + model.CreatePerson + "'"
                + ",'" + model.CreateDate + "')";
            try
            {
                returnIntValue = DbHelperSQL.ExecuteNonQuery(SqlQuery);
                return returnIntValue;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// ɾ��(&D)һ�����ݼ�¼
        /// </summary>
        /// <param name="paramID">��¼ID</param>
        /// <returns></returns>
        /// �����ˣ������
        /// �������ڣ�2013-02-22
        public int Delete(string paramID)
        {
            string sqlQuery = " DELETE FROM [CMS_PaymentsItem] WHERE [ID]=" + paramID;
            try
            {
                returnIntValue = DbHelperSQL.ExecuteNonQuery(sqlQuery);
                return returnIntValue;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}

