
//******************************************************************************************************
//** Copyright (C) 2010-2013 重大网络教育学院
//** 创建人：桂书丛
//** 类名称\文件名：DARoomType
//** 类功能：提供对房间信息操作的底层方法
//** 描 述：包括基本的增、删、查、改（所有关于房间信息数据库操作的方法）
//** 创建日期：2013-1-26
//** 修改(&U)人：桂书丛
//** 修改(&U)日期：2013-1-27
//** 整理日期：2013-1-27
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
    /// 数据访问类DACMS_RoomType 
    /// </summary>
    public class DACMS_RoomType:IDALayer<ModelCMS_RoomType>
    {
        int returnIntValue = -5;
        #region IDALayer<ModelCMS_RoomType> 成员

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
                SqlQuery += " [CMS_RoomType] ";
            else
                SqlQuery += "[View_RoomInfo]";
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
        public int Update(ModelCMS_RoomType model)
        {
            int returnIntValue = -5;
            string SqlQuery = "UPDATE [CMS_RoomType]"
                + "SET [Name] = '" + model.Name + "'"
                + ",[FloorID] = " + model.FloorID + ""
                + ",[EquipmentID] = " + model.EquipmentID + ""
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
        public int Insert(ModelCMS_RoomType model)
        {
            string SqlQuery = " INSERT INTO [CMS_RoomType] "
                + "([Name]"
                + ",[FloorID]"
                + ",[EquipmentID]"
                + ",[Description]"
                + ",[CreatePerson]"
                + ",[CreateDate]"
                + " ) VALUES ( "
                + "'" + model.Name + "'"
                + "," + model.FloorID + ""
                + ",'" + model.EquipmentID + "'"
                + ",'" + model.Description+ "'"
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
            string sqlQuery = " DELETE FROM [CMS_RoomType] WHERE [ID]=" + paramID;
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
    }
}
