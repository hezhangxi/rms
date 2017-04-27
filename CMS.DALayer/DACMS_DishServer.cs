
//******************************************************************************************************
//** Copyright (C) 2010-2013 重大网络教育学院
//** 创建人：桂书丛
//** 类名称\文件名：DADishServer
//** 类功能：提供对菜品信息操作的底层方法
//** 描 述：包括基本的增、删、查、改（所有关于菜品信息数据库操作的方法）
//** 创建日期：2013-1-28
//** 修改(&U)人：桂书丛
//** 修改(&U)日期：2013-1-30
//** 整理日期：2013-1-30
//******************************************************************************************************

using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using DBUtility;
using CMS.Model;
namespace CMS.DALayer
{
    /// <summary>
    /// 数据访问类DACMS_DishServer 
    /// </summary>
    public class DACMS_DishServer:IDALayer<ModelCMS_DishServer>
    {
        int returnIntValue = -5;

        #region public int UpdateDishServer(string paramWhereField, string paramWhereContent,string paramField, string paramContent)  根据字段和相应的值更新数据信息
        /// <summary>
        /// 根据字段和相应的值更新数据信息
        /// </summary>
        /// <param name="paramWhereField">条件字段名称</param>
        /// <param name="paramWhereContent">条件字段值</param>
        /// <param name="paramField">要更新的字段名称</param>
        /// <param name="paramContent">要更新的字段值</param>
        /// <returns></returns>
        public int UpdateDishServer(string paramWhereField, string paramWhereContent,string paramField, string paramContent)
        {
            int returnIntValue = -5;
            string SqlQuery = " UPDATE [CMS_DISHSERVER] SET [" + paramField + "] = '" + paramContent + "'"
            + " WHERE [" + paramWhereField + "]='" + paramWhereContent + "'";
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

        #region IDALayer<ModelCMS_DishServer> 成员

        /// <summary>
        /// 根据字段名称和字段值获得指定的数据，当paramField和paramContent都为空时表示获得全部数据
        /// </summary>
        /// <param name="IsView">数据源是表还是视图，false是表</param>
        /// <param name="paramField">字段名称</param>
        /// <param name="paramContent">字段内容</param>
        /// <param name="IsFuzzy">此查询是否是模糊询，false不是</param>
        /// <returns></returns>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-22
        public DataTable GetOrder(bool IsView, string paramField, string paramContent, bool IsFuzzy)
        {
            DataTable myDataTable = null;
            string SqlQuery = " SELECT * FROM  ";
            if (IsView == false)
                SqlQuery += " [CMS_DISHSERVER] ";
            else
                SqlQuery += " [View_DISHSERVER] ";
            if (paramField.Length != 0)
            {
                if (IsFuzzy == false)
                    SqlQuery += " WHERE " + paramField + " = '" + paramContent + "'";
                else
                    SqlQuery += " WHERE " + paramField + " LIKE '" + paramContent + "'+'%'";
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
        /// 创建时间：2013-2-23
        public DataTable GetOrder(bool IsView, string paramField, DateTime paramStart, DateTime paramEnd)
        {
            DataTable myDataTable = null;
            string SqlQuery = " SELECT * FROM  ";
            if (IsView == false)
                SqlQuery += " [CMS_DISHSERVER] ";
            else
                SqlQuery += " [View_DISHSERVER] ";
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
        /// 创建日期：2013-02-22
        public int Update(ModelCMS_DishServer model)
        {
            string sqlQuery = " UPDATE [CMS_DishServer]"
                              + "SET [Name] = '" + model.Name + "',"
                              + "[MnemonicSymbol] = '" + model.MnemonicSymbol + "',"
                              + "[DishTypeID] = " + model.DishTypeID
                              + ",[Cost] = " + model.Cost
                              + ",[MeasuringUnit] = '" + model.MeasuringUnit + "',"
                              + "[Price] = " + model.Cost
                              + ",[Commission] = " + model.Commission
                              + ",[StockGoodsID] = " + model.StockGoodsID
                              + ",[InfoNote] = '" + model.InfoNote + "'"
                              + ",[ModifyPerson] = '" + model.ModifyPerson + "'"
                              + ",[ModifyDate] = '" + model.ModifyDate + "'"
                              + " WHERE [ID]=" + model.ID;
            try
            {
                returnIntValue = DbHelperSQL.ExecuteNonQuery(sqlQuery);
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
        /// <param name="model"></param>
        /// <returns></returns>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-22
        public int Insert(ModelCMS_DishServer model)
        {
            string sqlQuery = "INSERT INTO [CMS_DishServer] "
                + "([Name]"
                + ",[MnemonicSymbol]"
                + ",[DishTypeID]"
                + ",[Cost]"
                + ",[MeasuringUnit]"
                + ",[Price]"
                + ",[Commission]"
                + ",[StockGoodsID]"
                + ",[InfoNote]"
                + ",[CreatePerson]"
                + ",[CreateDate]"
                + " ) VALUES ( "
                + "'" + model.Name + "'"
                + ",'" + model.MnemonicSymbol + "'"
                + "," + model.DishTypeID+ ""
                + "," + model.Cost + ""
                + ",'" + model.MeasuringUnit + "'"
                + "," + model.Price + ""
                + "," + model.Commission + ""
                + "," + model.StockGoodsID + ""
                + ",'" + model.InfoNote + "'"
                + ",'" + model.CreatePerson + "'"
                + ",'" + model.CreateDate + "')";
            try
            {
                returnIntValue = DbHelperSQL.ExecuteNonQuery(sqlQuery);
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
        /// 创建日期：2013-02-22
        public int Delete(string paramID)
        {
            string sqlQuery = " DELETE FROM [CMS_DishServer] WHERE [ID]=" + paramID;
            try
            {
                returnIntValue = DbHelperSQL.ExecuteNonQuery(sqlQuery);
                return returnIntValue;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region public DataTable GetAllColumns()  获得表中的所有字段
        /// <summary>
        /// 获得表中的所有字段
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllColumns()
        {
            DataTable returnDataTable = new DataTable();
            string SqlQuery = " SELECT [NAME] FROM [SYSCOLUMNS] WHERE [ID] = OBJECT_ID('View_DISHSERVER') ";
            try
            {
                returnDataTable = DbHelperSQL.GetDataTable(SqlQuery);
                return returnDataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region public DataTable GetOrderMemberInfo(string [] paramField,string paramCondition) 超级模糊查询
        /// <summary>
        /// 超级模糊查询
        /// </summary>
        /// <param name="paramCondition">查询条件</param>
        /// <returns></returns>
        public DataTable GetOrder(string[] paramField, string paramCondition)
        {
            DataTable myDataTable = null;
            string SqlQuery = "SELECT * FROM [View_DISHSERVER] WHERE";
            for (int Item = 0; Item < paramField.Length; Item++)
            {
                if (Item == paramField.Length - 1)
                    SqlQuery += "[" + paramField[Item] + "] LIKE '%'+'" + paramCondition + "'+'%'";
                else
                    SqlQuery += "[" + paramField[Item] + "] LIKE '%'+'" + paramCondition + "'+'%' OR ";
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
    }
}
