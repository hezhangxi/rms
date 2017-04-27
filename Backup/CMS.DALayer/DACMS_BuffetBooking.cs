using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

using DBUtility;
using CMS.Model;
namespace CMS.DALayer
{
	/// <summary>
	/// ���ݷ�����DACMS_BuffetBooking 
	/// </summary>
	public class DACMS_BuffetBooking:IDALayer<ModelCMS_BuffetBooking>
	{
		public DACMS_BuffetBooking()
		{}
		#region  ��Ա����
		#endregion  ��Ա����

        #region IDALayer<ModelCMS_BuffetBooking> ��Ա

        /// <summary>
        /// �����ֶ����ƺ��ֶ�ֵ���ָ�������ݣ���paramField��paramContent��Ϊ��ʱ��ʾ���ȫ������
        /// </summary>
        /// <param name="IsView">����Դ�Ǳ�����ͼ��false�Ǳ�</param>
        /// <param name="paramField">�ֶ�����</param>
        /// <param name="paramContent">�ֶ�����</param>
        /// <param name="IsFuzzy">�˲�ѯ�Ƿ���ģ��ѯ��false����</param>
        /// <returns></returns>
        /// �����ˣ������
        /// �������ڣ�2013-2-28
        public DataTable GetOrder(bool IsView, string paramField, string paramContent, bool IsFuzzy)
        {
            DataTable myDataTable = null;
            string SqlQuery = " SELECT * FROM  ";
            if (IsView == false)
                SqlQuery += " [CMS_BUFFETBOOKING] ";
            else
                SqlQuery += " [VIEW_BUFFETBOOK] ";
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

        /// <summary>
        /// �����ֶ����ƺ��ֶ�ֵ���ָ�������ݣ��˷������ʱ���ѯ
        /// </summary>
        /// <param name="IsView">����Դ�Ǳ�����ͼ��false�Ǳ�</param>
        /// <param name="paramField">�ֶ�����</param>
        /// <param name="paramStart">��ʼʱ��</param>
        /// <param name="paramEnd">����ʱ��</param>
        /// <returns></returns>
        /// �����ˣ������
        /// �������ڣ�2013-2-28
        public DataTable GetOrder(bool IsView, string paramField, DateTime paramStart, DateTime paramEnd)
        {
            DataTable myDataTable = null;
            string SqlQuery = " SELECT * FROM  ";
            if (IsView == false)
                SqlQuery += " [CMS_BUFFETBOOKING] ";
            else
                SqlQuery += " [VIEW_BUFFETBOOK] ";
            if (paramField.Length != 0)
            {
                SqlQuery += "WHERE " + paramField + " BETWEEN '" + paramStart + "' AND '" + paramEnd + "'";
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

        /// <summary>
        /// ����һ�����ݼ�¼
        /// </summary>
        /// <param name="model">ʵ����ʵ��</param>
        /// <returns></returns>
        /// �����ˣ������
        /// �������ڣ�2013-2-28
        public int Update(ModelCMS_BuffetBooking model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ����һ�����ݼ�¼
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// �����ˣ������
        /// �������ڣ�2013-2-28
        public int Insert(ModelCMS_BuffetBooking model)
        {
            int returnIntValue = -5;
            string SqlQuery = " INSERT INTO [CMS_BuffetBooking] "
                + "([BuffetsID]"
                + ",[CName]"
                + ",[CTelPhone]"
                + ",[Transactor]"
                + ",[CNum]"
                + ",[BooKDate]"
                + ",[OverduTtime]"
                + ",[InfoNote]"
                + " ) VALUES ( "
                + "" + model.BuffetsID + ""
                + ",'" + model.CName + "'"
                + ",'" + model.CTelPhone + "'"
                + ",'" + model.Transactor + "'"
                + "," + model.CNum + ""
                + ",'" + model.BooKDate + "'"
                + ",'" + model.OverduTtime + "'"
                + ",'" + model.InfoNote + "')";
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
        /// �������ڣ�2013-2-28
        public int Delete(string paramID)
        {
            int returnIntValue = -5;
            string SqlQuery = " DELETE FROM [CMS_BUFFETBOOKING] WHERE [ID] = " + paramID + " ";
            try
            {
                returnIntValue = DbHelperSQL.ExecuteNonQuery(SqlQuery);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return returnIntValue;
        }

        #endregion
    }
}

