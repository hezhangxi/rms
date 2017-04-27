using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DBUtility;
using CMS.Model;
namespace CMS.DALayer
{
	/// <summary>
	/// 数据访问类DACMS_DPInfo 
	/// </summary>
	public class DACMS_DPInfo:IDALayer<ModelCMS_DPInfo>
	{
        DbHelper myDbHelper = new DbHelper();
		public DACMS_DPInfo()
		{}
		#region  成员方法
		#endregion  成员方法

        #region IDALayer<ModelCMS_DPInfo> 成员

        /// <summary>
        /// 根据字段名称和字段值获得指定的数据，当paramField和paramContent都为空时表示获得全部数据
        /// </summary>
        /// <param name="IsView">数据源是表还是视图，false是表</param>
        /// <param name="paramField">字段名称</param>
        /// <param name="paramContent">字段内容</param>
        /// <param name="IsFuzzy">此查询是否是模糊询，false不是</param>
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
            throw new NotImplementedException();
        }

        /// <summary>
        /// 更新一条数据记录
        /// </summary>
        /// <param name="model">实体类实例</param>
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
        /// 插入一条数据记录
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
        /// 删除(&D)一条数据记录
        /// </summary>
        /// <param name="paramID">记录ID</param>
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

