using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DBUtility;
using CMS.Model;
///
namespace CMS.DALayer
{
	/// <summary>
	/// ���ݷ�����DACMS_VIPClient 
	/// </summary>
	public class DACMS_VIPClient:IDALayer<ModelCMS_VIPClient>
	{
        DbHelper myDbHelper = new DbHelper();
		public DACMS_VIPClient()
		{}
		#region  ��Ա����
		#endregion  ��Ա����

        #region IDALayer<ModelCMS_VIPClient> ��Ա

        /// <summary>
        /// �����ֶ����ƺ��ֶ�ֵ���ָ�������ݣ���paramField��paramContent��Ϊ��ʱ��ʾ���ȫ������
        /// </summary>
        /// <param name="IsView">����Դ�Ǳ�����ͼ��false�Ǳ�</param>
        /// <param name="paramField">�ֶ�����</param>
        /// <param name="paramContent">�ֶ�����</param>
        /// <param name="IsFuzzy">�˲�ѯ�Ƿ���ģ��ѯ��false����</param>
        /// <returns></returns>
        /// <remarks></remarks>
        /// 
        public DataTable GetOrder(bool IsView, string paramField, string paramContent, bool IsFuzzy)
        {
            DataTable myDataTable = null;
            string SqlQuery = " select * from ";
            if (IsView == false)
            {
                SqlQuery += " CMS_VIPClient ";
            }
            else
                SqlQuery += string.Empty;
            if(paramField.Length!=0)
            {
                if(IsFuzzy==false)
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
        /// �������ר�Ų�ѯ�ͻ�/��Ա��Ϣ����Ϊ��������Ϣ��һ�ű���
        /// </summary>
        /// <param name="IsClient"></param>
        /// <param name="paramField"></param>
        /// <param name="paramContent"></param>
        /// <returns></returns>
        public DataTable GetOrderVIPClient(bool IsClient, string paramField, string paramContent)
        {
            DataTable myDataTable = new DataTable();
            string SqlQuery = " select * from CMS_VIPClient ";
            if (paramField.Length != 0)
            {
                if (IsClient ==false)
                {
                    SqlQuery += "where " + paramField + " ='" + paramContent + " 'and IsClient =0"  + " ";
                }
                if (IsClient ==true)
                {
                    SqlQuery += " where " + paramField + "='" + paramContent + "' and IsClient =1"  + " ";
                }
            }
            if(paramField.Length==0)
            {
                if (IsClient == false)
                {
                    SqlQuery += "where IsClient=0";
                }
                if (IsClient == true)
                {
                    SqlQuery += " where IsClient=1" ;
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
        /// ר�Ų�ѯ��Ա��Ϣ(Ҫ�õ������ѯ��Sql��䲻һ��)(������������ȫ����ѯ)
        /// </summary>
        /// <returns></returns>
        public DataTable VIPSearch(bool paramIsCondition,string paramFileName,string paramMarvalue)
        {
            DataTable myDataTable = new DataTable();
            string SqlQuery = @" SELECT 
                               A.ID,
                               A.[Name],
                               A.Sex,
                               A.VIPTYPEID,
                               A.VIPCost,
                               A.TelPhone,
                               A.DepName,
                               A.Position,
                               A.[Address],
                               A.InfoNote,
                               A.CreateDate,
                               B.[Name] as VIPTypeName,
                               B.Discount
                               from 
                                 CMS_VIPClient A left join CMS_VIPType B on A.VIPTypeID=B.ID ";
            if (paramIsCondition) //����ǰ�����������ѯ
                SqlQuery += " where A." + paramFileName + " = '" + paramMarvalue + "'";
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
        /// ר�Ų�ѯ��Ա��Ϣ(Ҫ�õ������ѯ��Sql��䲻һ��)��ʱ������
        /// </summary>
        /// <returns></returns>
        /// 
        public DataTable VIPSearch(bool paramIsCondition, DateTime paramDateStart, DateTime paramDateEnd)
        {
            DataTable myDataTable = new DataTable();
            string SqlQuery = @" select 
                               A.ID,
                               A.[Name],
                               A.Sex,
                               A.VIPCost,
                               A.TelPhone,
                               A.DepName,
                               A.Position,
                               A.[Address],
                               A.InfoNote,
                               A.CreateDate,
                               B.[Name] as VIPTypeName,
                               B.Discount
                               from 
                                CMS_VIPClient A left join CMS_VIPType B on A.VIPTypeID=B.ID 
                                where A.CreateDate between '" + paramDateStart + "' and '" + paramDateEnd +"'";
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
        /// ��ȡһ��
        /// </summary>
        /// <returns></returns>
        public DataTable GetOnlyOne(string paramFileName)
        {
            DataTable myDataTable = null;
            string SqlQuery = " select " + paramFileName + " from CMS_VIPClient ";
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
            DataTable myDataTable = null;
            string SqlQuery = " SELECT * FROM  ";
            if (IsView == false)
                SqlQuery += " [CMS_VIPClient] ";
            else
                SqlQuery += " [VIEW_VIPClient] ";
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
        ///������ʱ��������ѯ��Ա/�ͻ���Ϣ
        /// </summary>
        /// <param name="IsClient"></param>
        /// <param name="paramStart"></param>
        /// <param name="paramEnd"></param>
        /// <returns></returns>
        public DataTable GetOrderVIPClientOnDate(bool IsClient,string paramField, DateTime paramStart, DateTime paramEnd)
        {
            DataTable myDataTable = null;
            string SqlQuery = " SELECT * FROM  CMS_VIPClient";
            if (paramField.Length != 0)
            {
                //SqlQuery += "WHERE " + paramField + " BETWEEN '" + paramStart + "' AND '" + paramEnd + "' and IsClient =" + IsClient ? 1 : 0;
                if (IsClient)
                {
                    SqlQuery += " WHERE " + paramField + " BETWEEN '" + paramStart + "' AND '" + paramEnd + "' and IsClient =1";
                }
                if (!IsClient)
                {
                    SqlQuery += " WHERE " + paramField + " BETWEEN '" + paramStart + "' AND '" + paramEnd + "' and IsClient =0";
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
        /// ����һ�����ݼ�¼
        /// </summary>
        /// <param name="model">ʵ����ʵ��</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public int  Update(ModelCMS_VIPClient model)
        {
            int returnIntValue = -5;
            string SqlQuery = "UPDATE [CMS_VIPClient]"
                            + " SET [TelPhone] = 110 "
                            + " ,[VIPTypeID] = '" + model.VIPTypeID + "'"
                            + " ,[Position] = '" + model.Position + "'"
                            + " ,[DepName] = '" + model.DepName + "'"
                            + " ,[Address] = '" + model.Address + "'"
                            + " ,[VIPCost] = '" + model.VIPCost + "'"
                            + ",[InfoNote] = '" + model.InfoNote + "'"
                            + ",[ModifyPerson] = '" + model.ModifyPerson + "'"
                            + ",[ModifyDate] = '" + model.ModifyDate + "'"
                            + "WHERE ID =" + model.ID;
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
        /// <param name="model">ʵ����ʵ��</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public int Update(ModelCMS_VIPClient model,string parm)
        {
            int returnIntValue = -5;
            string SqlQuery = "UPDATE [CMS_VIPClient]"
                            + " SET [VIPCost] = '" + model.VIPCost + "'"
                            + ",[RechargeDate] = '" + model.RechargeDate + "'"
                            + "WHERE ID =" + model.ID;
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
        public int Insert(ModelCMS_VIPClient model)
        {
            int returnIntValue = -5;
            string SqlQuery = " insert into [CMS_VIPClient] "
                + "([Name] "
                + ",[Sex]"
                + ",[TelPhone]"

                + ",[VIPTypeID]"
                + ",[Position]"
                + ",[DepName]"
                + ",[Address]"
                + ",[IsClient]"

                
                + ",[VIPCost]"
                + ",[InfoNote]"
                + ",[CreatePerson]"
                + ",[CreateDate]"
            
                + ") values ("
                + "'" + model.Name + "'"
                + ",'" + model.Sex + "'"
                + ",'" + model.TelPhone + "'"

                + ",'" + model.VIPTypeID + "'"
                + ",'" + model.Position + "'"
                + ",'" + model.DepName + "'"
                + ",'" + model.Address + "'"
                + ",'" + model.IsClient + "'"

                + ",'" + model.VIPCost + "'"
                + ",'" + model.InfoNote + "'"
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
            string SqlQuery = " delete CMS_VIPClient where ID=" + paramID;
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
    }
}

