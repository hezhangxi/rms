using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
namespace CMS.BULayer
{

    /// <summary>
    /// BU层必须实现的公用方法接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// 创建人：桂书丛
    /// 创建日期：2013-02-22
    public interface IBULayer<T>
    {
        #region 方法接口

        #region DataTable GetOrder(……)根据字段名称和字段值获得指定的数据，存在重载
        /// <summary>
        /// 根据字段名称和字段值获得指定的数据，当paramField和paramContent都为空时表示获得全部数据
        /// </summary>
        /// <param name="IsView">数据源是表还是视图，false是表</param>
        /// <param name="paramField">字段名称</param>
        /// <param name="paramContent">字段内容</param>
        /// <param name="IsFuzzy">此查询是否是模糊询，false不是</param>
        /// <returns></returns>
        DataTable GetOrder(bool IsView, string paramField, string paramContent, bool IsFuzzy);

        /// <summary>
        /// 根据字段名称和字段值获得指定的数据，此方法针对时间查询
        /// </summary>
        /// <param name="IsView">数据源是表还是视图，false是表</param>
        /// <param name="paramField">字段名称</param>
        /// <param name="paramStart">开始时间</param>
        /// <param name="paramEnd">结束时间</param>
        /// <returns></returns>
        DataTable GetOrder(bool IsView, string paramField, DateTime paramStart, DateTime paramEnd);
        #endregion

        #region VariedEnum.OperatorStatus Update(T model) 更新一条数据记录
        /// <summary>
        /// 更新一条数据记录
        /// </summary>
        /// <param name="model">实体类实例</param>
        /// <returns></returns>
        VariedEnum.OperatorStatus Update(T model);
        #endregion

        #region VariedEnum.OperatorStatus Insert(T model) 插入一条数据记录
        /// <summary>
        /// 插入一条数据记录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        VariedEnum.OperatorStatus Insert(T model);
        #endregion

        #region VariedEnum.OperatorStatus Delete(string paramID) 删除(&D)一条数据记录
        /// <summary>
        /// 删除(&D)一条数据记录
        /// </summary>
        /// <param name="paramID">记录ID</param>
        /// <returns></returns>
        VariedEnum.OperatorStatus Delete(string paramID);
        #endregion

        #endregion
    }
}

