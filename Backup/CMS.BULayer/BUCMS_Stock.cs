
//******************************************************************************************************
//** Copyright (C) 2010-2013 重大网络教育学院
//** 创建人：桂书丛
//** 类名称\文件名：BUStock
//** 类功能：提供对库存信息操作的逻辑处理方法
//** 描 述：包括基本的增、删、查、改（所有关于库存信息数据库操作的方法）
//** 创建日期：2013-2-4
//** 修改(&U)人：桂书丛
//** 修改(&U)日期：2013-2-4
//** 整理日期：2013-2-4
//******************************************************************************************************

using System;
using System.Collections.Generic;
using System.Text;

using CMS.DALayer;
using System.Data;
using CMS.Model;
namespace CMS.BULayer
{
    /// <summary>
    /// 业务逻辑类BUCMS_Stock   
    /// </summary>
    public class BUCMS_Stock:IBULayer<ModelCMS_Stock>
    {
        private readonly DACMS_Stock dal = new DACMS_Stock();

        #region public VariedEnum.OperatorStatus UpdateStock(string paramWhereField, string paramWhereContent,string paramField, string paramContent)  根据字段和相应的值更新数据信息
        /// <summary>
        /// 根据字段和相应的值更新数据信息
        /// </summary>
        /// <param name="paramIDContent">条件字段值,条件字段为ID</param>
        /// <param name="paramField">要更新的字段名称</param>
        /// <param name="paramContent">要更新的字段值</param>
        /// <returns></returns>
        public VariedEnum.OperatorStatus UpdateStock(string paramIDContent, string paramField, string paramContent)
        {
            int tempIntValue = -5;
            try
            {
                tempIntValue = dal.UpdateStock(paramIDContent, paramField, paramContent);
                if (tempIntValue > 0 )
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

        #region IBULayer<ModelCMS_Stock> 成员

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
            try
            {
                myDataTable = dal.GetOrder(IsView, paramField, paramContent, IsFuzzy);
                return myDataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
        public VariedEnum.OperatorStatus Update(ModelCMS_Stock model)
        {
            int returnValue = -5;
            try
            {
                returnValue = dal.Update(model);
                if (returnValue > 0)
                {
                    return VariedEnum.OperatorStatus.Successed;
                }
                else
                {
                    return VariedEnum.OperatorStatus.Failed;
                }
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
        public VariedEnum.OperatorStatus Insert(ModelCMS_Stock model)
        {
            int returnValue = -5;
            try
            {
                returnValue = dal.Insert(model);
                if (returnValue > 0)
                {
                    return VariedEnum.OperatorStatus.Successed;
                }
                else
                {
                    return VariedEnum.OperatorStatus.Failed;
                }
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

        public DataTable GetDateItems()
        {
            DataTable myDataTable = null;
            try
            {
                myDataTable = dal.GetDateItems();
                return myDataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
