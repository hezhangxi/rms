
//******************************************************************************************************
//** Copyright (C) 2010-2013 重大网络教育学院
//** 创建人：桂书丛
//** 类名称\文件名：DAStock
//** 类功能：提供对库存信息操作的底层方法
//** 描 述：包括基本的增、删、查、改（所有关于库存信息数据库操作的方法）
//** 创建日期：2013-2-4
//** 修改(&U)人：桂书丛
//** 修改(&U)日期：2013-2-4
//** 整理日期：2013-2-4
//******************************************************************************************************

using System;
using System.Collections.Generic;
using System.Text;

using DBUtility;
using CMS.Model;
using System.Data;
namespace CMS.DALayer
{
    /// <summary>
    /// 数据访问类DACMS_Stock 
    /// </summary>
    public class DACMS_Stock:IDALayer<ModelCMS_Stock>
    {
        #region public int UpdateStock(string paramWhereField, string paramWhereContent, string paramField, string paramContent)  根据字段和相应的值更新数据信息
        /// <summary>
        /// 根据字段和相应的值更新数据信息
        /// </summary>
        /// <param name="paramIDContent">条件字段值,字段为ID</param>
        /// <param name="paramField">要更新的字段名称</param>
        /// <param name="paramContent">要更新的字段值</param>
        /// <returns></returns>
        public int UpdateStock(string paramIDContent, string paramField, string paramContent)
        {
            int returnIntValue = -5;
            string SqlQuery = " UPDATE [CMS_STOCK] SET [" + paramField + "] = '" + paramContent + "'"
            + " WHERE [ID]='" + paramIDContent + "'";
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

        #region IDALayer<ModelCMS_Stock> 成员

        /// <summary>
        /// 根据字段名称和字段值获得指定的数据，当paramField和paramContent都为空时表示获得全部数据
        /// </summary>
        /// <param name="IsView">数据源是表还是视图，false是表</param>
        /// <param name="paramField">字段名称</param>
        /// <param name="paramContent">字段内容</param>
        /// <param name="IsFuzzy">此查询是否是模糊询，false不是</param>
        /// <returns></returns>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-23
        public DataTable GetOrder(bool IsView, string paramField, string paramContent, bool IsFuzzy)
        {
            DataTable myDataTable = null;
            string SqlQuery = " SELECT * FROM ";
            if (IsView == false)
            {
                SqlQuery += " [CMS_Stock] ";
            }
            else
            {
                SqlQuery += " [VIEW_Stock] ";
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
        /// 根据字段名称和字段值获得指定的数据，此方法针对时间查询
        /// </summary>
        /// <param name="IsView">数据源是表还是视图，false是表</param>
        /// <param name="paramField">字段名称</param>
        /// <param name="paramStart">开始时间</param>
        /// <param name="paramEnd">结束时间</param>
        /// <returns></returns>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-22
        public DataTable GetOrder(bool IsView, string paramField, DateTime paramStart, DateTime paramEnd)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 更新一条数据记录
        /// </summary>
        /// <param name="model">实体类实例</param>
        /// <returns></returns>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-22
        public int Update(ModelCMS_Stock model)
        {
            int returnValue = 0;
            try
            {
                string SqlQuery = string.Empty;
                SqlQuery = @"Update [CMS_Stock] set [Supplier]='" + model.Supplier + "',[Specifications]='" + model.Specifications + "',[Price]='" + model.Price + "',[Total]='" + model.Total + "',[Number]='" + model.Number + "',[InfoNote]='" + model.InfoNote + "' where [Name]='" + model.Name + "'";
                returnValue = DbHelperSQL.ExecuteNonQuery(SqlQuery);
                return returnValue;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 插入一条数据记录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-23
        /// 整理人：桂书丛
        /// 整理日期：2013-03-01
        public int Insert(ModelCMS_Stock model)
        {
            int returnValue = 0;
            try
            {
                string SqlQuery = string.Empty;
                SqlQuery = " INSERT INTO [CMS_Stock] "
                    +" ([Name]"
                    +",[Supplier]"
                    +",[Specifications]"
                    +",[Price]"
                    +",[Number]"
                    +",[InfoNote]"
                    +" ) VALUES ( "
                    +"'" + model.Name + "'"
                    +",'" + model.Supplier + "'"
                    +",'" + model.Specifications + "'"
                    +"," + model.Price + ""
                    +"," + model.Number + ""
                    +",'" + model.InfoNote + "')";
                returnValue = DbHelperSQL.ExecuteNonQuery(SqlQuery);
                return returnValue;
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
        /// 创建日期：2013-02-22
        public int Delete(string paramID)
        {
            int returnIntValue = -5;
            string SqlQuery = " DELETE FROM [CMS_Stock] WHERE [ID] = " + paramID + " ";
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

        /// <summary>
        /// Gets the date items.
        /// </summary>
        /// <returns></returns>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-04
        public DataTable GetDateItems()
        {
            DataTable myDataTable = null;
            try
            {
                string SqlQuery = " select [Name] from CMS_Stock";
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
