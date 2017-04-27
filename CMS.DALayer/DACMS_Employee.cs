
//******************************************************************************************************
//** Copyright (C) 2010-2013 重大网络教育学院
//** 创建人：桂书丛
//** 类名称\文件名：DAEmployee
//** 类功能：提供对员工信息操作的底层方法
//** 描 述：包括基本的增、删、查、改（所有关于员工信息数据库操作的方法）
//** 创建日期：2013-1-29
//** 修改(&U)人：桂书丛
//** 修改(&U)日期：2013-1-29
//** 整理日期：2013-1-29
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
    /// 数据访问类DACMS_Employee 
    /// </summary>
    public class DACMS_Employee:IDALayer<ModelCMS_Employee>
    {
        #region IDALayer<ModelCMS_Employee> 成员

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
            string SqlQuery = " SELECT DISTINCT * FROM  ";
            if (IsView == false)
                SqlQuery += " [CMS_EMPLOYEE] ";
            else
                SqlQuery += " [VIEW_EMPLOYEE] ";
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
                SqlQuery += " [CMS_EMPLOYEE] ";
            else
                SqlQuery += " [VIEW_EMPLOYEE] ";
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
        public int Update(ModelCMS_Employee model)
        {
            int returnIntValue = -5;
            try
            {
                string SqlQuery = "UPDATE [CMS_Employee]"
                                    + "SET [Name] = '" + model.Name + "'"
                                    + ",[Sex] ='" + model.Sex + "'"
                                    + ",[Age] =" + model.Age + ""
                                    + ",[Degree] ='" + model.Degree + "'"
                                    + ",[BirthDate] = '" + model.BirthDate + "'"
                                    + ",[PosID] = '" + model.PosID + "'"
                                    + ",[EntryDate] = '" + model.EntryDate + "'"
                                    + ",[Photo] = '" + model.Photo + "'"
                                    + ",[TelPhone] = '" + model.TelPhone + "'"
                                    + ",[IDCardNum] = '" + model.IDCardNum + "'"
                                    + ",[Address] = '" + model.Address + "'"
                                    + ",[InfoNote] = '" + model.InfoNote + "'"
                                    + ",[ModifyPerson] = '" + model.ModifyPerson + "'"
                                    + ",[ModifyDate] = '" + model.ModifyDate + "'"
                                    + "WHERE [ID]=" + model.ID + "";
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
        public int Insert(ModelCMS_Employee model)
        {
            int returnIntValue = -5;
            try
            {
                string SqlQuery = "Insert into [CMS_Employee]"
                                    + "([Name]"
                                    + ",[Sex]"
                                    + ",[Age]"
                                    + ",[Degree]"
                                    + ",[BirthDate]"
                                    + ",[PosID]"
                                    + ",[EntryDate]"
                                    + ",[Photo] "
                                    + ",[TelPhone]"
                                    + ",[IDCardNum]"
                                    + ",[Address] "
                                    + ",[InfoNote] "
                                    + ",[ModifyPerson]"
                                    + ",[ModifyDate]"
                                    + ") values("
                                    + "'" + model.Name + "'"
                                    + ",'" + model.Sex + "'"
                                    + "," + model.Age + ""
                                    + ",'" + model.Degree + "'"
                                    + ",'" + model.BirthDate + "'"
                                    + ",'" + model.PosID + "'"
                                    + ",'" + model.EntryDate + "'"
                                    + ",'" + model.Photo + "'"
                                    + ",'" + model.TelPhone + "'"
                                    + ",'" + model.IDCardNum + "'"
                                    + ",'" + model.Address + "'"
                                    + ",'" + model.InfoNote + "'"
                                    + ",'" + model.ModifyPerson + "'"
                                    + ",'" + model.ModifyDate + "')";

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
            string SqlQuery = " DELETE FROM [CMS_Employee] WHERE [ID] = " + paramID + " ";
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
        /// Gets the order view.
        /// </summary>
        /// <param name="IsView">if set to <c>true</c> [is view].</param>
        /// <param name="paramField">The param field.</param>
        /// <param name="paramContent">Content of the param.</param>
        /// <param name="IsFuzzy">if set to <c>true</c> [is fuzzy].</param>
        /// <returns></returns>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-06
        public DataTable GetOrderView(bool IsView, string paramField, string paramContent, bool IsFuzzy)
        {
            DataTable myDataTable = null;
            string SqlQuery = " SELECT * FROM  ";
            if (IsView == false)
                SqlQuery += " [CMS_EMPLOYEE] ";
            else
                SqlQuery += " [View_EpmloyeePerformance] ";
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
    }
}
