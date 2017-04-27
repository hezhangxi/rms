
//******************************************************************************************************
//** Copyright (C) 2010-2013 重大网络教育学院
//** 创建人：桂书丛
//** 类名称\文件名：BUDishServer
//** 类功能：提供对菜品信息操作的逻辑处理方法
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
using CMS.DALayer;
using CMS.Model;
namespace CMS.BULayer
{
    /// <summary>
    /// 业务逻辑类BUCMS_DishServer   
    /// </summary>
    public class BUCMS_DishServer:IBULayer<ModelCMS_DishServer>
    {
        private readonly DACMS_DishServer dal = new DACMS_DishServer();

        #region public VariedEnum.OperatorStatus UpdateDishServer(string paramWhereField, string paramWhereContent,string paramField, string paramContent)  根据字段和相应的值更新数据信息
        /// <summary>
        /// 根据字段和相应的值更新数据信息
        /// </summary>
        /// <param name="paramWhereField">条件字段名称</param>
        /// <param name="paramWhereContent">条件字段值</param>
        /// <param name="paramField">要更新的字段名称</param>
        /// <param name="paramContent">要更新的字段值</param>
        /// <returns></returns>
        public VariedEnum.OperatorStatus UpdateDishServer(string paramWhereField, string paramWhereContent, string paramField, string paramContent)
        {
            int tempIntValue = -5;
            try
            {
                tempIntValue = dal.UpdateDishServer(paramWhereField, paramWhereContent, paramField, paramContent);
                if (tempIntValue != -5)
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

        #region IBULayer<ModelCMS_DishServer> 成员

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
                myDataTable = dal.GetOrder(IsView,paramField,paramContent,IsFuzzy);
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
                myDataTable = dal.GetOrder(IsView,paramField,paramStart,paramEnd);
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
        public VariedEnum.OperatorStatus Update(ModelCMS_DishServer model)
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
        public VariedEnum.OperatorStatus Insert(ModelCMS_DishServer model)
        {
            int returnIntValue = -5;
            try
            {
                returnIntValue= dal.Insert(model);
                if (returnIntValue > 0)
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

        #region public DataTable GetAllColumns()  获得表中的所有字段
        /// <summary>
        /// 获得表中的所有字段
        /// </summary>
        /// <returns></returns>
        private string[] GetAllColumns()
        {
            DataTable tempDataTable = new DataTable();
            List<string> returnStringArrary = new List<string>();
            try
            {
                tempDataTable = dal.GetAllColumns();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            foreach (DataRow tempDataRow in tempDataTable.Rows)
            {
                returnStringArrary.Add(tempDataRow[0].ToString());
            }
            return returnStringArrary.ToArray();
        }
        #endregion

        #region public DataTable GetOrderMemberInfo(string paramCondition) 超级模糊查询
        /// <summary>
        /// 超级模糊查询
        /// </summary>
        /// <param name="paramCondition">查询条件</param>
        /// <returns></returns>
        public DataTable GetOrder(string paramCondition)
        {
            DataTable myDataTable = null;
            try
            {
                string[] TableColumnsText = GetAllColumns();
                myDataTable = dal.GetOrder(TableColumnsText, paramCondition);
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
