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
	/// 数据访问类DACMS_VIPClient 
	/// </summary>
	public class DACMS_VIPClient:IDALayer<ModelCMS_VIPClient>
	{
        DbHelper myDbHelper = new DbHelper();
		public DACMS_VIPClient()
		{}
		#region  成员方法
		#endregion  成员方法

        #region IDALayer<ModelCMS_VIPClient> 成员

        /// <summary>
        /// 根据字段名称和字段值获得指定的数据，当paramField和paramContent都为空时表示获得全部数据
        /// </summary>
        /// <param name="IsView">数据源是表还是视图，false是表</param>
        /// <param name="paramField">字段名称</param>
        /// <param name="paramContent">字段内容</param>
        /// <param name="IsFuzzy">此查询是否是模糊询，false不是</param>
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
        /// 这个方法专门查询客户/会员信息。因为这两个信息在一张表中
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
        /// 专门查询会员信息(要用的连表查询，Sql语句不一样)(按其他条件或全部查询)
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
            if (paramIsCondition) //如果是按其他条件查询
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
        /// 专门查询会员信息(要用的连表查询，Sql语句不一样)按时间条件
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
        /// 获取一列
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
        /// 根据字段名称和字段值获得指定的数据，此方法针对时间查询
        /// </summary>
        /// <param name="IsView">数据源是表还是视图，false是表</param>
        /// <param name="paramField">字段名称</param>
        /// <param name="paramStart">开始时间</param>
        /// <param name="paramEnd">结束时间</param>
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
        ///用来按时间条件查询会员/客户信息
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
        /// 更新一条数据记录
        /// </summary>
        /// <param name="model">实体类实例</param>
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
        /// 更新一条数据记录
        /// </summary>
        /// <param name="model">实体类实例</param>
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
        /// 插入一条数据记录
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
        /// 删除(&D)一条数据记录
        /// </summary>
        /// <param name="paramID">记录ID</param>
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

