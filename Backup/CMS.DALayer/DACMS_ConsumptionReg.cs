
//******************************************************************************************************
//** Copyright (C) 2010-2013 重大网络教育学院
//** 创建人：桂书丛
//** 类名称\文件名：DAConsumptionReg
//** 类功能：提供对消费注册操作的底层方法
//** 描 述：包括基本的增、删、查、改（所有关于消费注册数据库操作的方法）
//** 创建日期：2013-1-31
//** 修改(&U)人：桂书丛
//** 修改(&U)日期：2013-1-31
//** 整理日期：2013-1-31
//******************************************************************************************************

using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using CMS.Model;
using DBUtility;
namespace CMS.DALayer
{
    /// <summary>
    /// 数据访问类DACMS_ConsumptionReg 
    /// </summary>
    public class DACMS_ConsumptionReg : IDALayer<ModelCMS_ConsumptionReg>
    {
        #region IDALayer<ModelCMS_ConsumptionReg> 成员

        /// <summary>
        /// 根据字段名称和字段值获得指定的数据，当paramField和paramContent都为空时表示获得全部数据
        /// </summary>
        /// <param name="IsView">数据源是表还是视图，false是表</param>
        /// <param name="paramField">字段名称</param>
        /// <param name="paramContent">字段内容</param>
        /// <param name="IsFuzzy">此查询是否是模糊询，false不是</param>
        /// <returns></returns>
        public DataTable GetOrder(bool IsView, string paramField, string paramContent, bool IsFuzzy)
        {
            DataTable myDataTable = null;
            string SqlQuery = " SELECT * FROM  ";
            if (IsView == false)
                SqlQuery += " [CMS_CONSUMPTIONREGREG] ";
            else
                SqlQuery += " [VIEW_CONSUMNPTIONINFO] ";
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
        /// 创建时间：2013-2-23
        public DataTable GetOrder(bool IsView, string paramField, DateTime paramStart, DateTime paramEnd)
        {
            DataTable myDataTable = null;
            string SqlQuery = " SELECT * FROM  ";
            if (IsView == false)
                SqlQuery += " [CMS_CONSUMPTIONREGREG] ";
            else
                SqlQuery += " [VIEW_CONSUMNPTIONINFO] ";
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
        public int Update(ModelCMS_ConsumptionReg model)
        {
            int returnIntValue = -5;
            string SqlQuery = "UPDATE [CMS_ConsumptionReg]"
                + "SET [CustomerNum] = " + model.CustomerNum + ""
                + ",[BuffetsID] = " + model.BuffetsID + ""
                + ",[EmployeeID] = " + model.EmployeeID + ""
                + ",[TypeID] = " + model.TypeID + ""
                + ",[IsPaied] = " + Convert.ToInt32(model.IsPaied) + ""
                + ",[TotalAmount] = " + model.TotalAmount + ""
                + ",[PayTypeID] = " + model.PayTypeID + ""
                + ",[MarkID] = '" + model.MarkID + "'"
                + ",[IsVIP] = " + Convert.ToInt32(model.IsVIP) + ""
                + ",[VIPID] = " + model.VIPID + ""
                + ",[Description] = '" + model.Description + "'"
                + ",[ModifyPerson] = '" + model.ModifyPerson + "'"
                + ",[ModifyDate] = '" + model.ModifyDate + "'"
                + "WHERE [ID]=" + model.ID + "";
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
        /// <param name="model"></param>
        /// <returns></returns>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-22
        public int Insert(ModelCMS_ConsumptionReg model)
        {
            int returnIntValue = -5;
            string SqlQuery = " INSERT INTO [CMS_ConsumptionReg]"
                + "([CustomerNum]"
                + ",[BuffetsID]"
                + ",[EmployeeID]"
                + ",[TypeID]"
                + ",[IsPaied]"
                + ",[TotalAmount]"
                + ",[PayTypeID]"
                + ",[MarkID]"
                + ",[IsVIP]"
                + ",[Description]"
                + ",[CreatePerson]"
                + ",[CreateDate]"
                + " ) VALUES ("
                + "" + model.CustomerNum + ""
                + "," + model.BuffetsID + ""
                + "," + model.EmployeeID + ""
                + "," + model.TypeID + ""
                + "," + Convert.ToInt32(model.IsPaied) + ""
                + "," + model.TotalAmount + ""
                + "," + model.PayTypeID + ""
                + ",'" + model.MarkID + "'"
                + "," + Convert.ToInt32(model.IsVIP) + ""
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
        /// 创建人：桂书丛
        /// 创建日期：2013-02-22
        public int Delete(string paramID)
        {
            int returnIntValue = -5;
            string SqlQuery = " DELETE FROM [CMS_ConsumptionReg] WHERE [ID] = " + paramID + " ";
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

        #region  public int Delete)清空
        /// <summary>
        /// 清空
        /// </summary>
        /// <param name="paramID"></param>
        /// <param name="paramIsClear"></param>
        /// <returns></returns>
        public int Delete()
        {
            int returnIntValue = -5;
            string SqlQuery = "DELETE [CMS_CONSUMPTIONREG]";
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
