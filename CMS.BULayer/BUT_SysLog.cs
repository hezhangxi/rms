
//******************************************************************************************************
//** Copyright (C) 2010-2013 重大网络教育学院
//** 创建人：桂书丛
//** 类名称\文件名：BUSysLog
//** 类功能：提供对系统日志信息操作的逻辑处理方法
//** 描 述：包括基本的增、删、查、改（所有关于系统日志数据库操作的方法）
//** 创建日期：2013-1-24
//** 修改(&U)人：桂书丛
//** 修改(&U)日期：2013-1-24
//** 整理日期：2013-1-24
//******************************************************************************************************

using System;
using System.Collections.Generic;
using System.Text;

using CMS.DALayer;
using System.Data;
using CMS.Model;
using DBUtility;
namespace CMS.BULayer
{
    /// <summary>
    /// 业务逻辑类BUT_Right_Module_Map   
    /// </summary>
    public class BUT_SysLog : IBULayer<ModelT_SysLog>
    {
        private readonly DAT_SysLog dal = new DAT_SysLog();

        #region IBULayer<ModelT_SysLog> 成员

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
        public VariedEnum.OperatorStatus Update(ModelT_SysLog model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 插入一条数据记录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-22
        public VariedEnum.OperatorStatus Insert(ModelT_SysLog model)
        {
            throw new NotImplementedException();
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

        #region public static void InsertSysLog(int paramLogType,int paramOperatorID,string paramDescription) 添加系系统日志信息：paramLogType：日志类型，paramOperatorID：操作员ID，paramDescription：描述
        /// <summary>
        /// 添加系系统日志信息：paramLogType：日志类型，paramOperatorID：操作员ID，paramDescription：描述
        /// </summary>
        /// <param name="paramLogType">日志类型枚举</param>
        /// <param name="paramOperatorID">操作员ID</param>
        /// <param name="paramDescription">详细描述</param>
        public static void InsertSysLog(VariedEnum.LogType paramLogType, int paramOperatorID, string paramDescription)
        {
            ModelT_SysLog tempSysLog = new ModelT_SysLog();
            tempSysLog.LogType = Convert.ToInt32(paramLogType);
            tempSysLog.OperatorID = paramOperatorID;
            tempSysLog.Description = paramDescription;
            tempSysLog.RecordDate = DateTime.Now;
            try
            {
                new DAT_SysLog().Insert(tempSysLog);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 添加系系统日志信息：paramEx：异常实例，paramOperatorID：操作员ID
        /// </summary>
        /// <param name="paramEx">异常实例</param>
        /// <param name="paramOperatorID">操作员ID</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-26
        public static void InsertSysLog(Exception paramEx,int paramOperatorID)
        {
            ModelT_SysLog tempSysLog = new ModelT_SysLog();
            tempSysLog.LogType = Convert.ToInt32(VariedEnum.LogType.系统异常);
            tempSysLog.OperatorID = paramOperatorID;
            tempSysLog.Description = "类型：" + paramEx.GetType() + "    消息：" + paramEx.Message;
            tempSysLog.RecordDate = DateTime.Now;
            try
            {
                new DAT_SysLog().Insert(tempSysLog);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region public VariedEnum.OperatorStatus ClearSysLog() 清空所有日志记录
        /// <summary>
        /// 清空所有日志记录
        /// </summary>
        public VariedEnum.OperatorStatus ClearSysLog()
        {
            int tempIntValue = -5;
            try
            {
                tempIntValue = dal.ClearSysLog();
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
    }
}
