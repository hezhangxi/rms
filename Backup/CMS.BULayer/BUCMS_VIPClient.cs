using System;
using System.Data;
using System.Collections.Generic;
using CMS.DALayer;
using CMS.Model;
namespace CMS.BULayer
{
    /// <summary>
    /// 业务逻辑类BUCMS_VIPClient
    /// </summary>
    /// <remarks></remarks>
	public class BUCMS_VIPClient:IBULayer<ModelCMS_VIPClient>
	{
		private readonly DACMS_VIPClient dal=new DACMS_VIPClient();

        #region IBULayer<ModelCMS_VIPClient> 成员
        /// <summary>
        /// 根据字段名称和字段值获得指定的数据，当paramField和paramContent都为空时表示获得全部数据
        /// </summary>
        /// <param name="IsView">数据源是表还是视图，false是表</param>
        /// <param name="paramField">字段名称</param>
        /// <param name="paramContent">字段内容</param>
        /// <param name="IsFuzzy">此查询是否是模糊询，false不是</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public DataTable GetOrder(bool IsView, string paramField, string paramContent, bool IsFuzzy)
        {
            DataTable myDataTable = new DataTable();
            try
            {
              myDataTable=dal.GetOrder(IsView,paramField,paramContent,IsFuzzy);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return myDataTable;
        }

        /// <summary>
        /// 这个方法专门查询客户/会员信息。因为这两个信息在一张表中
        /// </summary>
        /// <param name="IsClient"></param>
        /// <param name="paramField"></param>
        /// <param name="paramContent"></param>
        /// <returns></returns>
        public DataTable GetOrderVIPClient(bool IsClient, string paramField, string paramContent)
        {
            DataTable myDataTable = new DataTable();
            try
            {
                myDataTable = dal.GetOrderVIPClient(IsClient,paramField,paramContent);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return myDataTable;
        }

        /// <summary>
        /// 专门查询会员信息(要用的连表查询，Sql语句不一样)(按其他条件或全部查询)
        /// </summary>
        /// <returns></returns>
        public DataTable VIPSearch(bool paramIsCondition, string paramFileName, string paramMarvalue)
        {
            DataTable myDataTable = new DataTable();
            try
            {
                myDataTable = dal.VIPSearch(paramIsCondition,paramFileName,paramMarvalue);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return myDataTable;
        }

        /// <summary>
        /// 专门查询会员信息(要用的连表查询，Sql语句不一样)按条件查询
        /// </summary>
        /// <returns></returns>
        public DataTable VIPSearch(bool paramIsCondition, DateTime paramDateStart, DateTime paramDateEnd)
        {
            DataTable myDataTable = new DataTable();
            try
            {
                myDataTable = dal.VIPSearch(paramIsCondition, paramDateStart, paramDateEnd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return myDataTable;
        }

        /// <summary>
        /// 获取一列
        /// </summary>
        /// <returns></returns>
        public DataTable GetOnlyOne(string paramFileName)
        {
            DataTable myDataTable = new DataTable();
            try
            {
                myDataTable = dal.GetOnlyOne(paramFileName);
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
        /// <remarks></remarks>
        public DataTable GetOrder(bool IsView, string paramField, DateTime paramStart, DateTime paramEnd)
        {
            DataTable myDataTable = new DataTable();
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
        /// 用来按时间条件查询会员/客户信息
        /// </summary>
        /// <param name="IsClient"></param>
        /// <param name="paramStart"></param>
        /// <param name="paramEnd"></param>
        /// <returns></returns>
        public DataTable GetOrderVIPClientOnDate(bool IsClient,string paramField, DateTime paramStart, DateTime paramEnd)
        {
            DataTable myDataTable = new DataTable();
            try
            {
                myDataTable = dal.GetOrderVIPClientOnDate(IsClient, paramField, paramStart,paramEnd);
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
        /// <remarks></remarks>
        public VariedEnum.OperatorStatus Update(ModelCMS_VIPClient model)
        {
            int tempIntValue = -5;
            try
            {
                tempIntValue = dal.Update(model);
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
        /// 更新一条数据记录
        /// </summary>
        /// <param name="model">实体类实例</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public VariedEnum.OperatorStatus Update(ModelCMS_VIPClient model,string param)
        {
            int tempIntValue = -5;
            try
            {
                tempIntValue = dal.Update(model,param);
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
        /// 插入一条数据记录
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public VariedEnum.OperatorStatus Insert(ModelCMS_VIPClient model)
        {
            int tempIntValue = -8;
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
        /// <remarks></remarks>
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
    }
}

