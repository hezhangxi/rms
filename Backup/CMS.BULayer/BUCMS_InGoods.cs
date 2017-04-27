using System;
using System.Data;
using System.Collections.Generic;
using CMS.DALayer;
using CMS.Model;
namespace CMS.BULayer
{
	/// <summary>
	/// 业务逻辑类BUCMS_InGoods   
	/// </summary>
	public class BUCMS_InGoods:IBULayer<ModelCMS_InGoods>
	{
		private readonly DACMS_InGoods dal=new DACMS_InGoods();

        #region IBULayer<ModelCMS_InGoods> 成员

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

        /// <summary>
        /// 更新一条数据记录
        /// </summary>
        /// <param name="model">实体类实例</param>
        /// <returns></returns>
        public VariedEnum.OperatorStatus Update(ModelCMS_InGoods model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 插入一条数据记录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public VariedEnum.OperatorStatus Insert(ModelCMS_InGoods model)
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

        public DataTable GetDateMoney(DateTime paramStartDateTime, DateTime paramEndDateTime)
        {
            DataTable myDataTable = null;
            try
            {
                myDataTable = dal.GetDateMoney(paramStartDateTime, paramEndDateTime);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return myDataTable;
        }
    }
}

