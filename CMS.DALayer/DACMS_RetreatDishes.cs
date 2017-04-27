using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

using DBUtility;
using CMS.Model;
namespace CMS.DALayer
{
	/// <summary>
	/// ���ݷ�����DACMS_RetreatDishes 
	/// </summary>
	public class DACMS_RetreatDishes:IDALayer<ModelCMS_RetreatDishes>
	{
		public DACMS_RetreatDishes()
		{}
        #region  ��Ա����
        #endregion  ��Ա����

        #region IDALayer<ModelCMS_RetreatDishes> ��Ա

        /// <summary>
        /// �����ֶ����ƺ��ֶ�ֵ���ָ�������ݣ���paramField��paramContent��Ϊ��ʱ��ʾ���ȫ������
        /// </summary>
        /// <param name="IsView">����Դ�Ǳ�����ͼ��false�Ǳ�</param>
        /// <param name="paramField">�ֶ�����</param>
        /// <param name="paramContent">�ֶ�����</param>
        /// <param name="IsFuzzy">�˲�ѯ�Ƿ���ģ��ѯ��false����</param>
        /// <returns></returns>
        /// �����ˣ������
        /// �������ڣ�2013-2-25
        public DataTable GetOrder(bool IsView, string paramField, string paramContent, bool IsFuzzy)
        {
            DataTable myDataTable = null;
            string SqlQuery = " SELECT * FROM  ";
            if (IsView == false)
                SqlQuery += " [CMS_RETREATDISHES] ";
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

        /// <summary>
        /// �����ֶ����ƺ��ֶ�ֵ���ָ�������ݣ��˷������ʱ���ѯ
        /// </summary>
        /// <param name="IsView">����Դ�Ǳ�����ͼ��false�Ǳ�</param>
        /// <param name="paramField">�ֶ�����</param>
        /// <param name="paramStart">��ʼʱ��</param>
        /// <param name="paramEnd">����ʱ��</param>
        /// <returns></returns>
        /// �����ˣ������
        /// �������ڣ�2013-2-25
        public DataTable GetOrder(bool IsView, string paramField, DateTime paramStart, DateTime paramEnd)
        {
            DataTable myDataTable = null;
            string SqlQuery = " SELECT * FROM  ";
            if (IsView == false)
                SqlQuery += " [CMS_RETREATDISHES] ";
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
        /// �����ˣ������
        /// �������ڣ�2013-2-25
        public int Update(ModelCMS_RetreatDishes model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ����һ�����ݼ�¼
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// �����ˣ������
        /// �������ڣ�2013-2-25
        public int Insert(ModelCMS_RetreatDishes model)
        {
            int returnIntValue = -5;
            string SqlQuery = "INSERT INTO [CMS_RetreatDishes] "
                + "([DishID]"
                + ",[DishNum]"
                + ",[CauseID]"
                + ",[InfoNote]"
                + ",[CreatePerson]"
                + ",[RetreatDate]"
                + " ) VALUES ( "
                + "" + model.DishID + ""
                + "," + model.DishNum + ""
                + "," + model.CauseID + ""
                + ",'" + model.InfoNote + "'"
                + ",'" + model.CreatePerson + "'"
                + ",'" + model.RetreatDate + "')";
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
        /// �������ڣ�2013-2-25
        public int Delete(string paramID)
        {
            int returnIntValue = -5;
            string SqlQuery = " DELETE FROM [CMS_RETREATDISHES] WHERE [ID] = " + paramID + " ";
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

        #region public int ClearRetreatDishes() ��������˲˼�¼
        /// <summary>
        /// ��������˲˼�¼
        /// </summary>
        public int ClearRetreatDishes()
        {
            int returnIntValue = -5;
            string SqlQuery = " delete [CMS_RETREATDISHES] ";
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

        #region public DataTable GetOrder(string paramFileName,string paramMarValue) ��ѯ(��������)�������ֶβ�ѯ
        /// <summary>
        ///  ��ѯ(��������)�������ֶβ�ѯ
        /// </summary>
        /// <param name="paramFileName"></param>
        /// <param name="paramMarValue"></param>
        /// <returns></returns>
        public DataTable GetOrder(string paramFileName, string paramMarValue)
        {
            DataTable myDataTable = new DataTable();
            string SqlQuery = @"select 
                             CMS_RetreatDishes.ID,
                             CMS_DishServer.Name as DishName,
                             CMS_RetreatDishes.DishNum ,
                             CMS_ItemDetail.Name as Cause,
                             CMS_RetreatDishes.InfoNote,
                             CMS_RetreatDishes.CreatePerson,
                             CMS_RetreatDishes.RetreatDate

                             from  CMS_RetreatDishes inner join
                             CMS_DishServer on  CMS_RetreatDishes.DishID=CMS_DishServer.ID inner join
                             CMS_ItemDetail on  CMS_RetreatDishes.CauseID=CMS_ItemDetail.ID ";

            if (paramFileName.Length != 0)
            {
                SqlQuery += " where " + paramFileName + " ='" + paramMarValue + "'";
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
        #endregion

        #region public DataTable GetOrder(DateTime paramDateStart, DateTime paramDateEn) ��ѯ(��������)(ר�Ű�ʱ���ѯ)
        /// <summary>
        ///  ��ѯ(��������)(ר�Ű�ʱ���ѯ)
        /// </summary>
        /// <param name="paramDateStart"></param>
        /// <param name="paramDateEnd"></param>
        /// <returns></returns>
        public DataTable GetOrder(DateTime paramDateStart, DateTime paramDateEnd)
        {
            DataTable myDataTable = new DataTable();
            string SqlQuery = @"select 
                             CMS_RetreatDishes.ID,
                             CMS_DishServer.Name as DishName,
                             CMS_RetreatDishes.DishNum ,
                             CMS_ItemDetail.Name as Cause,
                             CMS_RetreatDishes.InfoNote,
                             CMS_RetreatDishes.CreatePerson,
                             CMS_RetreatDishes.RetreatDate

                             from  CMS_RetreatDishes inner join
                             CMS_DishServer on  CMS_RetreatDishes.DishID=CMS_DishServer.ID inner join
                             CMS_ItemDetail on  CMS_RetreatDishes.CauseID=CMS_ItemDetail.ID 
                             where CMS_RetreatDishes.RetreatDate between '" + paramDateStart + "' and '" + paramDateEnd + "'";
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
        #endregion
    }
}

