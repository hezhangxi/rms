using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DBUtility;
using CMS.Model;

namespace CMS.DALayer
{
	/// <summary>
	/// ���ݷ�����DACMS_InGoods 
	/// </summary>
    public class DACMS_InGoods :IDALayer<ModelCMS_InGoods>
	{
		public DACMS_InGoods()
		{}
		#region  ��Ա����
		#endregion  ��Ա����

        #region IDALayer<ModelCMS_InGoods> ��Ա

        /// <summary>
        /// �����ֶ����ƺ��ֶ�ֵ���ָ�������ݣ���paramField��paramContent��Ϊ��ʱ��ʾ���ȫ������
        /// </summary>
        /// <param name="IsView">����Դ�Ǳ�����ͼ��false�Ǳ�</param>
        /// <param name="paramField">�ֶ�����</param>
        /// <param name="paramContent">�ֶ�����</param>
        /// <param name="IsFuzzy">�˲�ѯ�Ƿ���ģ��ѯ��false����</param>
        /// <returns></returns>
        public DataTable GetOrder(bool IsView, string paramField, string paramContent, bool IsFuzzy)
        {
            DataTable myDataTable = null;
            string SqlQuery = " SELECT * FROM ";
            if (IsView == false)
            {
                SqlQuery += " [CMS_InGoods] ";
            }
            else
            {
                SqlQuery += string.Empty;
            }
            if (paramField.Length != 0)
            {
                if (IsFuzzy == false)
                {
                    SqlQuery += " WHERE " + paramField + " = '" + paramContent + "'";
                }
                else
                {
                    SqlQuery += " WHERE " + paramField + " LIKE '" + paramContent + "'";
                }
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
        public DataTable GetOrder(bool IsView, string paramField, DateTime paramStart, DateTime paramEnd)
        {
            DataTable myDataTable = null;
            string SqlQuery = " SELECT * FROM  ";
            if (IsView == false)
                SqlQuery += " [CMS_InGoods] ";
            else
                SqlQuery += string.Empty;
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
        public int Update(ModelCMS_InGoods model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ����һ�����ݼ�¼
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Insert(ModelCMS_InGoods model)
        {
            int returnValue = 0;
            try
            {
                string SqlQuery = string.Empty;
                SqlQuery = @" INSERT INTO [CMS_InGoods]([Name],[SerialNumber],[Specifications],[Total],[Number],[Price],
                        [Supplier],[HandlesPeopleID],[InDate],[InfoNote])
                        VALUES('" + model.Name + "','" + model.SerialNumber + "','" + model.Specifications + "','" + model.Total + "','" + model.Number + "','" + model.Price + "','" + model.Supplier + "','" + model.HandlesPeopleID + "','" + model.InDate + "','" + model.InfoNote + "')";
                returnValue = DbHelperSQL.ExecuteNonQuery(SqlQuery);
                return returnValue;
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
        public int Delete(string paramID)
        {
            int returnIntValue = -5;
            string SqlQuery = " DELETE FROM [CMS_InGoods] WHERE [ID] = " + paramID + " ";
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

        public DataTable GetDateMoney(DateTime paramStartDateTime, DateTime paramEndDateTime)
        {
            DataTable myDataTable = null;
            try
            {
                string SqlQuery = @"select [Name],Number,Total,InDate from View_InGoodsStock 
                    where cast(InDate as datetime) between  '" + paramStartDateTime + "' and '" + paramEndDateTime + "'";
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

