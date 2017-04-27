//******************************************************************************************************
//** Copyright (C) 2010-2013 重大网络教育学院
//** 创建人：桂书丛
//** 类名称\文件名：IDAFuncations
//** 接口功能：DA层必须实现的公用方法接口
//** 描 述：DA层必须实现的公用方法接口
//** 创建日期：2013-2-4
//** 修改(&U)人：桂书丛
//** 修改(&U)日期：2013-2-4
//** 整理日期：2013-2-4
//******************************************************************************************************

using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
namespace DBUtility
{
    ///<summary>
    ///DA层必须实现的公用方法接口
    ///</summary>
    ///<typeparam name="T">参数类型，主为实体类名称</typeparam>
    ///创建人：桂书丛
    ///创建日期：2013-02-22
    public interface IDALayer<T>
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
        DataTable GetOrder(bool IsView,string paramField, string paramContent,bool IsFuzzy);

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

        #region int Update(T model) 更新一条数据记录
        /// <summary>
        /// 更新一条数据记录
        /// </summary>
        /// <param name="model">实体类实例</param>
        /// <returns></returns>
        int Update(T model);
        #endregion 

        #region int Insert(T model) 插入一条数据记录
        /// <summary>
        /// 插入一条数据记录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        int Insert(T model);
        #endregion 

        #region int Delete(string paramID) 删除(&D)一条数据记录
        /// <summary>
        /// 删除(&D)一条数据记录
        /// </summary>
        /// <param name="paramID">记录ID</param>
        /// <returns></returns>
        int Delete(string paramID);
        #endregion

        #endregion
    }
}
