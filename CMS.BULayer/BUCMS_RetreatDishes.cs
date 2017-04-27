using System;
using System.Data;
using System.Collections.Generic;
using CMS.DALayer;

using CMS.Model;
namespace CMS.BULayer
{
	/// <summary>
	/// 业务逻辑类BUCMS_RetreatDishes   
	/// </summary>
	public class BUCMS_RetreatDishes:IBULayer<ModelCMS_RetreatDishes>
	{
		private readonly DACMS_RetreatDishes dal=new DACMS_RetreatDishes();

        #region IBULayer<ModelCMS_RetreatDishes> 成员

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

        /// <summary>
        /// 更新一条数据记录
        /// </summary>
        /// <param name="model">实体类实例</param>
        /// <returns></returns>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-22
        public VariedEnum.OperatorStatus Update(ModelCMS_RetreatDishes model)
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
        /// 插入一条数据记录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-22
        public VariedEnum.OperatorStatus Insert(ModelCMS_RetreatDishes model)
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
        /// 创建日期：2013-02-23
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

        #region public int ClearRetreatDishes() 清空所有退菜记录
        /// <summary>
        /// 清空所有退菜记录
        /// </summary>
        public int ClearRetreatDishes()
        {
            int returnIntValue = -5;
            try
            {
                returnIntValue = dal.ClearRetreatDishes();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return returnIntValue;
        }
        #endregion

        #region public DataTable GetOrder(string paramFileName,string paramMarValue) 查询(方法重载)按其他字段查询
        /// <summary>
        ///  查询(方法重载)按其他字段查询
        /// </summary>
        /// <param name="paramFileName"></param>
        /// <param name="paramMarValue"></param>
        /// <returns></returns>
        public DataTable GetOrder(string paramFileName, string paramMarValue)
        {
            DataTable myDataTable = null;
            try
            {
                myDataTable = dal.GetOrder(paramFileName, paramMarValue);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return myDataTable;
        }
        #endregion

        #region public DataTable GetOrder(DateTime paramDateStart, DateTime paramDateEn) 查询(方法重载)专门按时间查询
        /// <summary>
        ///  查询(方法重载)专门按时间查询
        /// </summary>
        /// <param name="paramFileName"></param>
        /// <param name="paramMarValue"></param>
        /// <returns></returns>
        public DataTable GetOrder(DateTime paramDateStart, DateTime paramDateEn)
        {
            DataTable myDataTable = null;
            try
            {
                myDataTable = dal.GetOrder(paramDateStart, paramDateEn);
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

