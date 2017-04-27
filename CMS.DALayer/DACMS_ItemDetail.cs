
//******************************************************************************************************
//** Copyright (C) 2010-2013 重大网络教育学院
//** 创建人：桂书丛
//** 类名称\文件名：DACMSItemDetail
//** 类功能：提供对Item信息操作的底层方法
//** 描 述：包括基本的增、删、查、改（所有关于Item数据库操作的方法）
//** 创建日期：2013-1-26
//** 修改(&U)人：桂书丛
//** 修改(&U)日期：2013-1-26
//** 整理日期：2013-1-26
//******************************************************************************************************

using System;
using System.Collections.Generic;
using System.Text;

using System.Data.SqlClient;
using System.Data;
using CMS.Model;
using DBUtility;
namespace CMS.DALayer
{
    /// <summary>
    /// 数据访问类DACMS_ItemDetail 
    /// </summary>
    public class DACMS_ItemDetail:IDALayer<ModelCMS_ItemDetail>
    {

        int returnIntValue = -5;

        #region public DataTable GetItemByType(string paramItemType) 根据项目类型获得对应项目信息
        /// <summary>
        /// 根据项目类型获得对应项目信息
        /// </summary>
        /// <param name="paramItemType">项目类型</param>
        /// <returns></returns>
        public DataTable GetItemByType(string paramItemType)
        {
            DataTable myDataTable = null;
            string SqlQuery = " SELECT * FROM [CMS_ITEMDETAIL] WHERE [TYPEID] = "
                + " (SELECT [ID] FROM [CMS_ITEMTYPE] WHERE [NAME] = '" + paramItemType + "') ";
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

        #region IDALayer<ModelT_ItemDetail> 成员

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
                SqlQuery += " [CMS_ItemDetail]  ";
            else
                SqlQuery += "[View_DishServer]";
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
                SqlQuery += " [CMS_ItemDetail] ";
            else
                SqlQuery += "[View_DishServer]";
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
        /// 创建人： 桂书丛
        /// 创建日期：2013-02-22
        public int Update(ModelCMS_ItemDetail model)
        {
            string sqlQuery = " UPDATE [CMS_ItemDetail]"
                              + "SET [Name] = '" + model.Name + "',"
                              + "[Description] = '" + model.Description + "'"
                              + "WHERE [ID]=" + model.ID;
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

        //#region public int Update(ModelCMS_ItemDetail model) 使用存储过程进行数据更新
        ///// <summary>
        ///// 更新一条数据记录
        ///// </summary>
        ///// <param name="model">实体类实例</param>
        ///// <returns></returns>
        ///// 创建人： 桂书丛
        ///// 创建日期：2013-02-22
        //public int Update(ModelCMS_ItemDetail model)
        //{
        //    object returnObjectValue = null;
        //    try
        //    {
        //        returnObjectValue = DbHelperSQL.ExecReturnSingleProc(paramStoredProcName, paramParameters);
        //        return returnObjectValue;
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //        throw ex;
        //    }
        //}
        //#endregion

        /// <summary>
        /// 插入一条数据记录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-22
        public int Insert(ModelCMS_ItemDetail model)
        {
            string SqlQuery = " INSERT INTO [CMS_ItemDetail] "
                + "([TypeID]"
                + ",[Name]"
                + ",[Description]"
                + ",[CreatePerson]"
                + ",[CreateDate]"
                + " ) VALUES ( "
                + "" + model.TypeID + ""
                + ",'" + model.Name + "'"
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
            string sqlQuery = " DELETE FROM [CMS_ItemDetail] WHERE [ID]=" + paramID;
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

        //#region public DataTable GetCMBEInfo() 对ComoBoxEdit进行数据绑定
        ///// <summary>
        ///// cmbeDishType数据绑定
        ///// </summary>
        ///// <returns>DataTable</returns>
        //public DataTable GetCMBEInfo()
        //{
        //    string sqlQuery = "SELECT * FROM CMS_ITEMDETAIL WHERE 1=1";
        //    try
        //    {
        //        myDataTable = DbHelperSQL.GetDataTable(sqlQuery);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return myDataTable;
        //}
        //#endregion

        #region public DataTable GetDishType() 对grictrlDishType进行数据绑定
        /// <summary>
        /// grictrlDishType数据绑定
        /// </summary>
        /// <param name="paramID"></param>
        /// <returns></returns>
        public DataTable GetDishType(int paramID)
        {
            string sqlQuery = " SELECT [ID],[NAME] FROM [CMS_ITEMDETAIL] WHERE TYPEID=" + paramID;
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return DbHelperSQL.GetDataTable(sqlQuery);
        }
        #endregion

        #region public DataTable GetQuitReason(int paramID) 对grictrlQuitReason进行数据绑定
        /// <summary>
        /// grictrlQuitReason数据绑定
        /// </summary>
        /// <param name="paramID"></param>
        /// <returns></returns>
        public DataTable GetQuitReason(int paramID)
        {
            string sqlQuery = "SELECT [ID],[NAME] FROM [CMS_ITEMDETAIL] WHERE TYPEID=" + paramID;
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return DbHelperSQL.GetDataTable(sqlQuery);
        }
        #endregion

        #region public DataTable GetDishTaste(int paramID) 对grictrlDishTaste进行数据绑定
        /// <summary>
        /// grictrlDishTaste数据绑定
        /// </summary>
        /// <param name="paramID"></param>
        /// <returns></returns>
        public DataTable GetDishTaste(int paramID)
        {
            string sqlQuery = "SELECT [ID],[NAME] FROM [CMS_ITEMDETAIL] WHERE TYPEID=" + paramID;
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return DbHelperSQL.GetDataTable(sqlQuery);
        }
        #endregion

        #region public DataTable GetBuffState(int paramID) 对grictrlBuffState进行数据绑定
        /// <summary>
        /// grictrlBuffState数据绑定
        /// </summary>
        /// <param name="paramID"></param>
        /// <returns></returns>
        public DataTable GetBuffState(int paramID)
        {
            string sqlQuery = "SELECT [ID],[NAME] FROM [CMS_ITEMDETAIL] WHERE TYPEID=" + paramID;
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return DbHelperSQL.GetDataTable(sqlQuery);
        }
        #endregion

        #region public DataTable GetOtherInstall(int paramID) 对grictrlOtherInstall进行数据绑定
        /// <summary>
        /// grictrlOtherInstall数据绑定
        /// </summary>
        /// <param name="paramID"></param>
        /// <returns></returns>
        public DataTable GetOtherInstall(int paramID)
        {
            string sqlQuery = "SELECT [ID],[NAME] FROM [CMS_ITEMDETAIL] WHERE TYPEID=" + paramID;
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return DbHelperSQL.GetDataTable(sqlQuery);
        }
        #endregion



        //***************************添加按钮的单击事件*************************************//

        #region public int RAddDishType(string paramtxtDishTypeNum, string paramtxtDishType) 添加菜品类别
        /// <summary>
        /// 添加菜品类别
        /// </summary>
        /// <param name="paramtxtDishTypeNum"></param>
        /// <param name="paramtxtDishType"></param>
        /// <returns></returns>
        public int RAddDishType(string paramDishTypeNum, string paramDishType)
        {
            string sqlQuery = @" INSERT INTO [CMS_ItemDetail] ([TYPEID],[Name])
                               VALUES ('" + paramDishTypeNum + "','" + paramDishType + "') ";
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return DbHelperSQL.ExecuteNonQuery(sqlQuery);
        }
        #endregion

        #region public int RGetDishTaste(string paramDishTasteNum, string paramDishTaste) 添加菜品口味
        /// <summary>
        /// 添加菜品口味
        /// </summary>
        /// <param name="paramDishTasteNum"></param>
        /// <param name="paramDishTaste"></param>
        /// <returns></returns>
        public int RGetDishTaste(string paramDishTasteNum, string paramDishTaste)
        {
            string sqlQuery = @" INSERT INTO [CMS_ItemDetail] ([TYPEID],[Name])
                               VALUES ('" + paramDishTasteNum + "','" + paramDishTaste + "') ";
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return DbHelperSQL.ExecuteNonQuery(sqlQuery);
        }
        #endregion

        #region public int RGetQuitReason(string paramQuitReasonNum, string paramQuitReason) 添加退菜原因
        /// <summary>
        /// 添加退菜原因
        /// </summary>
        /// <param name="paramQuitReasonNum"></param>
        /// <param name="paramQuitReason"></param>
        /// <returns></returns>
        public int RGetQuitReason(string paramQuitReasonNum, string paramQuitReason)
        {
            string sqlQuery = @" INSERT INTO [CMS_ItemDetail] ([TYPEID],[Name])
                               VALUES ('" + paramQuitReasonNum + "','" + paramQuitReason + "') ";
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return DbHelperSQL.ExecuteNonQuery(sqlQuery);
        }
        #endregion

        #region public int RGetBuffState(string paramBuffStateNum, string paramBuffState) 添加餐台状态
        /// <summary>
        /// 添加餐台状态
        /// </summary>
        /// <param name="paramBuffStateNum"></param>
        /// <param name="paramBuffState"></param>
        /// <returns></returns>
        public int RGetBuffState(string paramBuffStateNum, string paramBuffState)
        {
            string sqlQuery = @" INSERT INTO [CMS_ItemDetail] ([TYPEID],[Name])
                               VALUES ('" + paramBuffStateNum + "','" + paramBuffState + "') ";
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return DbHelperSQL.ExecuteNonQuery(sqlQuery);
        }
        #endregion

        #region public int RGetOtherInstall(string paramOtherInstallNum, string paramOtherInstall) 添加其他设置
        /// <summary>
        /// 添加其他设置
        /// </summary>
        /// <param name="paramOtherInstallNum"></param>
        /// <param name="paramOtherInstall"></param>
        /// <returns></returns>
        public int RGetOtherInstall(string paramOtherInstallNum, string paramOtherInstall)
        {
            string sqlQuery = @" INSERT INTO [CMS_ItemDetail] ([TYPEID],[Name])
                               VALUES ('" + paramOtherInstallNum + "','" + paramOtherInstall + "') ";
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return DbHelperSQL.ExecuteNonQuery(sqlQuery);
        }
        #endregion




        //***************************删除(&D)按钮的单击事件*************************************//

        #region public int RDeleDishType(string paramDishTypeNum) 删除(&D)菜品类别中选中的记录
        /// <summary>
        /// 删除(&D)菜品类别中选中的记录
        /// </summary>
        /// <param name="paramDishTypeNum"></param>
        /// <returns></returns>
        public int RDeleDishType(string paramDishTypeNum)
        {
            string sqlQuery = "DELETE FROM [CMS_ITEMDETAIL] WHERE ID ='" + paramDishTypeNum + "'";
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return DbHelperSQL.ExecuteNonQuery(sqlQuery);
        }
        #endregion

        #region public int RDeleDishTaste(string paramDishTypeNum) 删除(&D)菜品口味中选中的记录
        /// <summary>
        /// 删除(&D)菜品口味中选中的记录
        /// </summary>
        /// <param name="paramDishTasteNum"></param>
        /// <returns></returns>
        public int RDeleDishTaste(string paramDishTasteNum)
        {
            string sqlQuery = "DELETE FROM [CMS_ITEMDETAIL] WHERE ID ='" + paramDishTasteNum + "'";
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return DbHelperSQL.ExecuteNonQuery(sqlQuery);
        }
        #endregion

        #region public int RDeleQuitReason(string paramQuitReasonNum) 删除(&D)退菜原因中选中的记录
        /// <summary>
        /// 删除(&D)退菜原因中选中的记录
        /// </summary>
        /// <param name="paramQuitReasonNum"></param>
        /// <returns></returns>
        public int RDeleQuitReason(string paramQuitReasonNum)
        {
            string sqlQuery = "DELETE FROM [CMS_ITEMDETAIL] WHERE ID ='" + paramQuitReasonNum + "'";
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return DbHelperSQL.ExecuteNonQuery(sqlQuery);
        }
        #endregion

        #region public int RDeleBuffState(string paramBuffStateNum) 删除(&D)餐台使用状态中选中的记录
        /// <summary>
        /// 删除(&D)餐台使用状态中选中的记录
        /// </summary>
        /// <param name="paramBuffStateNum"></param>
        /// <returns></returns>
        public int RDeleBuffState(string paramBuffStateNum)
        {
            string sqlQuery = "DELETE FROM [CMS_ITEMDETAIL] WHERE ID ='" + paramBuffStateNum + "'";
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return DbHelperSQL.ExecuteNonQuery(sqlQuery);
        }
        #endregion

        #region public int RDeleOtherInstall(string paramOtherInstallNum) 删除(&D)其他设置中选中的记录
        /// <summary>
        /// 删除(&D)其他设置中选中的记录
        /// </summary>
        /// <param name="paramOtherInstallNum"></param>
        /// <returns></returns>
        public int RDeleOtherInstall(string paramOtherInstallNum)
        {
            string sqlQuery = "DELETE FROM [CMS_ITEMDETAIL] WHERE ID ='" + paramOtherInstallNum + "'";
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return DbHelperSQL.ExecuteNonQuery(sqlQuery);
        }
        #endregion




        //***************************修改(&U)按钮的单击事件*************************************//

        #region public int RAlterDishType(string paramDishTypeNum, string paramDishType) 修改(&U)菜品类别中选中的记录
        /// <summary>
        /// 修改(&U)菜品类别中选中的记录
        /// </summary>
        /// <param name="paramDishTypeNum"></param>
        /// <param name="paramDishType"></param>
        /// <returns></returns>
        public int RAlterDishType(string paramDishTypeNum, string paramDishType)
        {
            string sqlQuery = "UPDATE [CMS_ITEMDETAIL] SET [NAME]='" + paramDishType + "' WHERE [ID] =" + paramDishTypeNum;
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return DbHelperSQL.ExecuteNonQuery(sqlQuery);
        }
        #endregion

        #region public int RAlterDishTaste(string paramDishTasteNum, string paramDishTaste) 修改(&U)菜品口味中选中的记录
        /// <summary>
        /// 修改(&U)菜品口味中选中的记录
        /// </summary>
        /// <param name="paramDishTasteNum"></param>
        /// <param name="paramDishTaste"></param>
        /// <returns></returns>
        public int RAlterDishTaste(string paramDishTasteNum, string paramDishTaste)
        {
            string sqlQuery = "UPDATE [CMS_ITEMDETAIL] SET [NAME]='" + paramDishTaste + "' WHERE [ID] =" + paramDishTasteNum;
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return DbHelperSQL.ExecuteNonQuery(sqlQuery);
        }
        #endregion

        #region public int RAlterQuitReason(string paramQuitReasonNum, string paramQuitReason) 修改(&U)退菜原因中选中的记录
        /// <summary>
        /// 修改(&U)退菜原因中选中的记录
        /// </summary>
        /// <param name="paramQuitReasonNum"></param>
        /// <param name="paramQuitReason"></param>
        /// <returns></returns>
        public int RAlterQuitReason(string paramQuitReasonNum, string paramQuitReason)
        {
            string sqlQuery = "UPDATE [CMS_ITEMDETAIL] SET [NAME]='" + paramQuitReason + "' WHERE [ID] =" + paramQuitReasonNum;
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return DbHelperSQL.ExecuteNonQuery(sqlQuery);
        }
        #endregion

        #region public int RAlterBuffState(string paramBuffStateNum, string paramBuffState) 修改(&U)餐台使用状态中选中的记录
        /// <summary>
        /// 修改(&U)餐台使用状态中选中的记录
        /// </summary>
        /// <param name="paramBuffStateNum"></param>
        /// <param name="paramBuffState"></param>
        /// <returns></returns>
        public int RAlterBuffState(string paramBuffStateNum, string paramBuffState)
        {
            string sqlQuery = "UPDATE [CMS_ITEMDETAIL] SET [NAME]='" + paramBuffState + "' WHERE [ID] =" + paramBuffStateNum;
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return DbHelperSQL.ExecuteNonQuery(sqlQuery);
        }
        #endregion

        #region public int RAlterOtherInstall(string paramOtherInstallNum, string paramOtherInstall) 修改(&U)其他设置中选中的记录
        /// <summary>
        /// 修改(&U)其他设置中选中的记录
        /// </summary>
        /// <param name="paramOtherInstallNum"></param>
        /// <param name="paramOtherInstall"></param>
        /// <returns></returns>
        public int RAlterOtherInstall(string paramOtherInstallNum, string paramOtherInstall)
        {
            string sqlQuery = "UPDATE [CMS_ITEMDETAIL] SET [NAME]='" + paramOtherInstall + "' WHERE [ID] =" + paramOtherInstallNum;
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return DbHelperSQL.ExecuteNonQuery(sqlQuery);
        }
        #endregion

    }
}
