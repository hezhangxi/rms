using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

using DBUtility;
using CMS.Model;
namespace CMS.DALayer
{
	/// <summary>
	/// 数据访问类DACMS_BuffetBooking 
	/// </summary>
	public class DACMS_BuffetBooking:IDALayer<ModelCMS_BuffetBooking>
	{
		public DACMS_BuffetBooking()
		{}
		#region  成员方法
		#endregion  成员方法

        #region IDALayer<ModelCMS_BuffetBooking> 成员

        /// <summary>
        /// 根据字段名称和字段值获得指定的数据，当paramField和paramContent都为空时表示获得全部数据
        /// </summary>
        /// <param name="IsView">数据源是表还是视图，false是表</param>
        /// <param name="paramField">字段名称</param>
        /// <param name="paramContent">字段内容</param>
        /// <param name="IsFuzzy">此查询是否是模糊询，false不是</param>
        /// <returns></returns>
        /// 创建人：桂书丛
        /// 创建日期：2013-2-28
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
        /// 根据字段名称和字段值获得指定的数据，此方法针对时间查询
        /// </summary>
        /// <param name="IsView">数据源是表还是视图，false是表</param>
        /// <param name="paramField">字段名称</param>
        /// <param name="paramStart">开始时间</param>
        /// <param name="paramEnd">结束时间</param>
        /// <returns></returns>
        /// 创建人：桂书丛
        /// 创建日期：2013-2-28
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
        /// 更新一条数据记录
        /// </summary>
        /// <param name="model">实体类实例</param>
        /// <returns></returns>
        /// 创建人：桂书丛
        /// 创建日期：2013-2-28
        public int Update(ModelCMS_BuffetBooking model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 插入一条数据记录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// 创建人：桂书丛
        /// 创建日期：2013-2-28
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
        /// 删除(&D)一条数据记录
        /// </summary>
        /// <param name="paramID">记录ID</param>
        /// <returns></returns>
        /// 创建人：桂书丛
        /// 创建日期：2013-2-28
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

