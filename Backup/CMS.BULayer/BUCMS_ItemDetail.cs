
//******************************************************************************************************
//** Copyright (C) 2010-2013 重大网络教育学院
//** 创建人：桂书丛
//** 类名称\文件名：BUCMSItemDetail
//** 类功能：提供对系统项目操作的逻辑处理方法
//** 描 述：包括基本的增、删、查、改（所有关于系统项目数据库操作的方法）
//** 创建日期：2013-1-26
//** 修改(&U)人：桂书丛
//** 修改(&U)日期：2013-2-25
//** 整理日期：2013-1-26
//******************************************************************************************************

using System;
using System.Collections.Generic;
using System.Text;

using System.Data.SqlClient;
using System.Data;
using CMS.DALayer;
using CMS.Model;
namespace CMS.BULayer
{
    /// <summary>
    /// 业务逻辑类BUCMS_ItemDetail
    /// </summary>
    /// <remarks></remarks>
    public class BUCMS_ItemDetail:IBULayer<ModelCMS_ItemDetail>
    {
        private readonly DACMS_ItemDetail dal = new DACMS_ItemDetail();

        #region IBULayer<ModelCMS_ItemDetail> 成员

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
            try
            {
                myDataTable = dal.GetOrder(IsView, paramField, paramContent, IsFuzzy);
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
            try
            {
                myDataTable = dal.GetOrder(IsView, paramField, paramStart, paramEnd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return myDataTable;
        }

        //#region public VariedEnum.OperatorStatus Update(ModelCMS_ItemDetail model) 使用存储过程进行数据更新
        ///// <summary>
        ///// 更新一条数据记录
        ///// </summary>
        ///// <param name="model">实体类实例</param>
        ///// <returns></returns>
        ///// 创建人：桂书丛
        ///// 创建日期：2013-02-22
        //public VariedEnum.OperatorStatus Update(ModelCMS_ItemDetail model)
        //{
        //    object returnObjectValue = null;
        //    SqlParameter[] mySqlParameter = new SqlParameter[5];
        //    mySqlParameter[0] = new SqlParameter("@ID", SqlDbType.Int);
        //    mySqlParameter[0].Value = model.ID;
        //    mySqlParameter[1] = new SqlParameter("@TypeID", SqlDbType.Int);
        //    mySqlParameter[1].Value = model.TypeID;
        //    mySqlParameter[2] = new SqlParameter("@Name", SqlDbType.NVarChar, 20);
        //    mySqlParameter[2].Value = model.Name;
        //    mySqlParameter[3] = new SqlParameter("@Description", SqlDbType.NVarChar, 200);
        //    mySqlParameter[3].Value = model.Description;
        //    mySqlParameter[4] = new SqlParameter("@ModifyPerson", SqlDbType.NVarChar, 20);
        //    mySqlParameter[4].Value = model.ModifyPerson;
        //    try
        //    {
        //        returnObjectValue = dal.Update("proc_UpdateItemInfo", mySqlParameter);
        //        if (Convert.ToInt32(returnObjectValue) > 0)
        //            return VariedEnum.OperatorStatus.Successed;
        //        else
        //            return VariedEnum.OperatorStatus.Failed;
        //    }
        //    catch (Exception ex)
        //    {
        //        return VariedEnum.OperatorStatus.UnknowError;
        //        throw ex;
        //    }
        //}
        //#endregion


        /// <summary>
        /// 更新一条数据记录
        /// </summary>
        /// <param name="model">实体类实例</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public VariedEnum.OperatorStatus Update(ModelCMS_ItemDetail model)
        {
            int tempIntvalue = -5;
            try
            {
                tempIntvalue = dal.Update(model);
                if (tempIntvalue > 0)
                    return VariedEnum.OperatorStatus.Successed;
                else
                    return VariedEnum.OperatorStatus.Failed;
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
        public VariedEnum.OperatorStatus Insert(ModelCMS_ItemDetail model)
        {
            int tempIntValue = -5;
            try
            {
                tempIntValue = dal.Insert(model);
                if (tempIntValue > 0)
                    return VariedEnum.OperatorStatus.Successed;
                else
                    return VariedEnum.OperatorStatus.Failed;
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
        public VariedEnum.OperatorStatus Delete(string paramID)
        {
            int tempIntValue = -5;
            try
            {
                tempIntValue = dal.Delete(paramID);
                if (tempIntValue > 0)
                    return VariedEnum.OperatorStatus.Successed;
                else
                    return VariedEnum.OperatorStatus.Failed;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region public DataTable GetItemByType(string paramItemType) 根据项目类型获得对应项目信息
        /// <summary>
        /// 根据项目类型获得对应项目信息
        /// </summary>
        /// <param name="paramItemType">项目类型</param>
        /// <returns></returns>
        public DataTable GetItemByType(string paramItemType)
        {
            DataTable myDataTable = null;
            try
            {
                myDataTable = dal.GetItemByType(paramItemType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return myDataTable;
        }
        #endregion

        #region 不用的

        #region public DataTable GetCMBEInfo() 对ComoBoxEdit进行数据绑定
        /// <summary>
        /// cmbeDishType数据绑定
        /// </summary>
        /// <returns></returns>
        //public DataTable GetCMBEInfo(VariedEnum.ItemType paramItemType)
        //{
        //    try
        //    {

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return dal.GetCMBEInfo(paramItemType);
        //}
        #endregion
        //#region public DataTable GetDishType() 对grictrlDishType进行数据绑定
        ///// <summary>
        ///// grictrlDishType数据绑定
        ///// </summary>
        ///// <returns></returns>
        //public DataTable GetDishType(int paramID)
        //{
        //    try
        //    {

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return dal.GetDishType(paramID);
        //}
        //#endregion

        //#region public DataTable GetQuitReason() 对grictrlQuitReason进行数据绑定
        ///// <summary>
        ///// grictrlQuitReason数据绑定
        ///// </summary>
        ///// <returns></returns>
        //public DataTable GetQuitReason(int paramID)
        //{
        //    try
        //    {

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return dal.GetQuitReason(paramID);
        //}
        //#endregion

        //#region public DataTable GetDishType() 对grictrlDishTaste进行数据绑定
        ///// <summary>
        ///// grictrlDishTaste数据绑定
        ///// </summary>
        ///// <returns></returns>
        //public DataTable GetDishTaste(int paramID)
        //{
        //    try
        //    {

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return dal.GetDishTaste(paramID);
        //}
        //#endregion

        //#region public DataTable GetBuffState() 对grictrlBuffState进行数据绑定
        ///// <summary>
        ///// grictrlBuffState数据绑定
        ///// </summary>
        ///// <returns></returns>
        //public DataTable GetBuffState(int paramID)
        //{
        //    try
        //    {

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return dal.GetBuffState(paramID);
        //}
        //#endregion
        #endregion

        #region public DataTable GetOtherInstall() 对grictrlOtherInstall进行数据绑定
        /// <summary>
        /// grictrlOtherInstall数据绑定
        /// </summary>
        /// <returns></returns>
        public DataTable GetOtherInstall(int paramID)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dal.GetOtherInstall(paramID);
        }
        #endregion



        //***************************添加按钮的单击事件*************************************//

        #region public int RAddDishType(string paramtxtDishTypeNum, string paramtxtDishType) 添加菜品类别
        /// <summary>
        /// 添加菜品类别
        /// </summary>
        /// <param name="paramDishTypeNum">The param dish type num.</param>
        /// <param name="paramtDishType">Type of the paramt dish.</param>
        /// <returns></returns>
        public int RAddDishType(string paramDishTypeNum, string paramtDishType)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dal.RAddDishType(paramDishTypeNum, paramtDishType);
        }
        #endregion

        #region public int RAddDishTaste(string paramDishTasteNum, string paramDishTaste) 添加菜品类别
        /// <summary>
        /// 添加菜品类别
        /// </summary>
        /// <param name="paramDishTasteNum">The param dish taste num.</param>
        /// <param name="paramDishTaste">The param dish taste.</param>
        /// <returns></returns>
        public int RAddDishTaste(string paramDishTasteNum, string paramDishTaste)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dal.RGetDishTaste(paramDishTasteNum, paramDishTaste);
        }
        #endregion

        #region public void RGetQuitReason(string paramQuitReasonNum, string paramQuitReason) 添加退菜原因
        /// <summary>
        /// 添加退菜原因
        /// </summary>
        /// <param name="paramQuitReasonNum"></param>
        /// <param name="paramQuitReason"></param>
        /// <returns></returns>
        public int RGetQuitReason(string paramQuitReasonNum, string paramQuitReason)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dal.RGetQuitReason(paramQuitReasonNum, paramQuitReason);
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
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dal.RGetBuffState(paramBuffStateNum, paramBuffState);
        }
        #endregion

        #region public int RGetOtherInstall(string paramBuffStateNum, string paramBuffState) 添加其他设置
        /// <summary>
        /// 添加其他设置
        /// </summary>
        /// <param name="paramBuffStateNum"></param>
        /// <param name="paramBuffState"></param>
        /// <returns></returns>
        public int RGetOtherInstall(string paramOtherInstallNum, string paramOtherInstall)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dal.RGetOtherInstall(paramOtherInstallNum, paramOtherInstall);
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
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dal.RDeleDishType(paramDishTypeNum);
        }
        #endregion

        #region public int RDeleDishTaste(string paramDishTasteNum)删除(&D)菜品口味中选中的记录
        /// <summary>
        /// 删除(&D)菜品口味中选中的记录
        /// </summary>
        /// <param name="paramDishTasteNum"></param>
        /// <returns></returns>
        public int RDeleDishTaste(string paramDishTasteNum)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dal.RDeleDishTaste(paramDishTasteNum);
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
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dal.RDeleQuitReason(paramQuitReasonNum);
        }
        #endregion

        #region public int RDeleBuffState(string paramBuffStateNum)删除(&D)餐台使用状态中选中的记录
        /// <summary>
        /// 删除(&D)餐台使用状态中选中的记录
        /// </summary>
        /// <param name="paramBuffStateNum"></param>
        /// <returns></returns>
        public int RDeleBuffState(string paramBuffStateNum)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dal.RDeleBuffState(paramBuffStateNum);
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
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dal.RDeleOtherInstall(paramOtherInstallNum);
        }
        #endregion




        //***************************修改(&U)按钮的单击事件*************************************//

        #region public int RAlterDishType(string paramDishTypeNum, string paramDishType)修改(&U)菜品类别中选中的记录
        /// <summary>
        /// 修改(&U)菜品类别中选中的记录
        /// </summary>
        /// <param name="paramDishTypeNum"></param>
        /// <param name="paramDishType"></param>
        /// <returns></returns>
        public int RAlterDishType(string paramDishTypeNum, string paramDishType)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dal.RAlterDishType(paramDishTypeNum, paramDishType);
        }
        #endregion

        #region public int RAlterDishTaste(string paramDishTasteNum, string paramDishTaste)修改(&U)菜品口味中选中的记录
        /// <summary>
        /// 修改(&U)菜品口味中选中的记录
        /// </summary>
        /// <param name="paramDishTasteNum"></param>
        /// <param name="paramDishTaste"></param>
        /// <returns></returns>
        public int RAlterDishTaste(string paramDishTasteNum, string paramDishTaste)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dal.RAlterDishTaste(paramDishTasteNum, paramDishTaste);
        }
        #endregion

        #region public int RAlterQuitReason(string paramQuitReasonNum, string paramQuitReason)修改(&U)退菜原因中选中的记录
        /// <summary>
        /// 修改(&U)退菜原因中选中的记录
        /// </summary>
        /// <param name="paramQuitReasonNum"></param>
        /// <param name="paramQuitReason"></param>
        /// <returns></returns>
        public int RAlterQuitReason(string paramQuitReasonNum, string paramQuitReason)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dal.RAlterQuitReason(paramQuitReasonNum, paramQuitReason);
        }
        #endregion

        #region public int RAlterBuffState(string paramBuffStateNum, string paramBuffState)修改(&U)餐台使用状态中选中的记录
        /// <summary>
        /// 修改(&U)餐台使用状态中选中的记录
        /// </summary>
        /// <param name="paramBuffStateNum"></param>
        /// <param name="paramBuffState"></param>
        /// <returns></returns>
        public int RAlterBuffState(string paramBuffStateNum, string paramBuffState)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dal.RAlterBuffState(paramBuffStateNum, paramBuffState);
        }
        #endregion

        #region public int RAlterOtherInstall(string paramOtherInstallNum, string paramOtherInstall)修改(&U)其他设置中选中的记录
        /// <summary>
        /// 修改(&U)其他设置中选中的记录
        /// </summary>
        /// <param name="paramOtherInstallNum"></param>
        /// <param name="paramOtherInstall"></param>
        /// <returns></returns>
        public int RAlterOtherInstall(string paramOtherInstallNum, string paramOtherInstall)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dal.RAlterOtherInstall(paramOtherInstallNum, paramOtherInstall);
        }
        #endregion

    }
}
