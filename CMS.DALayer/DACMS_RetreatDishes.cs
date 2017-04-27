using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

using DBUtility;
using CMS.Model;
namespace CMS.DALayer
{
	/// <summary>
	/// 数据访问类DACMS_RetreatDishes 
	/// </summary>
	public class DACMS_RetreatDishes:IDALayer<ModelCMS_RetreatDishes>
	{
		public DACMS_RetreatDishes()
		{}
        #region  成员方法
        #endregion  成员方法

        #region IDALayer<ModelCMS_RetreatDishes> 成员

        /// <summary>
        /// 根据字段名称和字段值获得指定的数据，当paramField和paramContent都为空时表示获得全部数据
        /// </summary>
        /// <param name="IsView">数据源是表还是视图，false是表</param>
        /// <param name="paramField">字段名称</param>
        /// <param name="paramContent">字段内容</param>
        /// <param name="IsFuzzy">此查询是否是模糊询，false不是</param>
        /// <returns></returns>
        /// 创建人：桂书丛
        /// 创建日期：2013-2-25
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
        /// 根据字段名称和字段值获得指定的数据，此方法针对时间查询
        /// </summary>
        /// <param name="IsView">数据源是表还是视图，false是表</param>
        /// <param name="paramField">字段名称</param>
        /// <param name="paramStart">开始时间</param>
        /// <param name="paramEnd">结束时间</param>
        /// <returns></returns>
        /// 创建人：桂书丛
        /// 创建日期：2013-2-25
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
        /// 更新一条数据记录
        /// </summary>
        /// <param name="model">实体类实例</param>
        /// <returns></returns>
        /// 创建人：桂书丛
        /// 创建日期：2013-2-25
        public int Update(ModelCMS_RetreatDishes model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 插入一条数据记录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// 创建人：桂书丛
        /// 创建日期：2013-2-25
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
        /// 删除(&D)一条数据记录
        /// </summary>
        /// <param name="paramID">记录ID</param>
        /// <returns></returns>
        /// 创建人：桂书丛
        /// 创建日期：2013-2-25
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

        #region public int ClearRetreatDishes() 清空所有退菜记录
        /// <summary>
        /// 清空所有退菜记录
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

        #region public DataTable GetOrder(string paramFileName,string paramMarValue) 查询(方法重载)按其他字段查询
        /// <summary>
        ///  查询(方法重载)按其他字段查询
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

        #region public DataTable GetOrder(DateTime paramDateStart, DateTime paramDateEn) 查询(方法重载)(专门按时间查询)
        /// <summary>
        ///  查询(方法重载)(专门按时间查询)
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

