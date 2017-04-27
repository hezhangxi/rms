using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DBUtility;
using CMS.Model;
namespace CMS.DALayer
{
	/// <summary>
	/// ���ݷ�����DACMS_DPInfo 
	/// </summary>
	public class DACMS_DPInfo:IDALayer<ModelCMS_DPInfo>
	{
        DbHelper myDbHelper = new DbHelper();
		public DACMS_DPInfo()
		{}
		#region  ��Ա����
		#endregion  ��Ա����

        #region IDALayer<ModelCMS_DPInfo> ��Ա

        /// <summary>
        /// �����ֶ����ƺ��ֶ�ֵ���ָ�������ݣ���paramField��paramContent��Ϊ��ʱ��ʾ���ȫ������
        /// </summary>
        /// <param name="IsView">����Դ�Ǳ�����ͼ��false�Ǳ�</param>
        /// <param name="paramField">�ֶ�����</param>
        /// <param name="paramContent">�ֶ�����</param>
        /// <param name="IsFuzzy">�˲�ѯ�Ƿ���ģ��ѯ��false����</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public DataTable GetOrder(bool IsView, string paramField, string paramContent, bool IsFuzzy)
        {
            DataTable myDataTable = null;
            string SqlQuery = " select * from ";
            if (IsView == false)
            {
                SqlQuery += " CMS_DPInfo ";
            }
            else
                SqlQuery += string.Empty;
            if (paramField.Length != 0)
            {
                if (IsFuzzy == false)
                    SqlQuery += " where " + paramField + " = '" + paramContent + " '";
                else
                    SqlQuery += " where " + paramField + " like '" + paramContent + " '";
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
        /// <remarks></remarks>
        public DataTable GetOrder(bool IsView, string paramField, DateTime paramStart, DateTime paramEnd)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ����һ�����ݼ�¼
        /// </summary>
        /// <param name="model">ʵ����ʵ��</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public int Update(ModelCMS_DPInfo model)
        {
            int returnIntValue = -5;
            string SqlQuery = " UPDATE [CMS_DPInfo] "
                + "SET [Name] = '" + model.Name + "'"
                + ",[SubID] = '" + model.SubID + "'"
                + ",[Description] = '" + model.Description + "'"
                + ",[ModifyPerson] = '" + model.ModifyPerson + "'"
                + ",[ModifyDate] = '" + model.ModifyDate + "'"
                + "WHERE [ID]=" + model.ID + " ";
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
        /// ����һ�����ݼ�¼
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public int Insert(ModelCMS_DPInfo model)
        {
            int returnIntValue = -5;
            string SqlQuery = " insert into [CMS_DPInfo] "
                + "([Name] "
                + ",[SubID]"
                + ",[Description]"
                + ",[CreatePerson]"
                + ",[CreateDate]"
                + ") values ("
                + "'" + model.Name + "'"
                + ",'" + model.SubID + "'"
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
        /// <remarks></remarks>
        public int Delete(string paramID)
        {
            int returnIntValue = -5;
            string SqlQuery = " delete CMS_DPInfo where ID=" + paramID;
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

        #endregion
        public DataTable GetAllPos()
        {
            DataTable myDataTable = null;
            string SqlQuery = " SELECT POS.ID,POS.[NAME] AS PosName,DEP.[NAME] AS DepName "
                + " FROM CMS_DPINFO AS POS,CMS_DPINFO AS DEP "
                + " WHERE POS.SUBID=DEP.ID ";
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
    }
}

