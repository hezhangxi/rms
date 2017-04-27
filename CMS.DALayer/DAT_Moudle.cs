
//******************************************************************************************************
//** Copyright (C) 2010-2013 重大网络教育学院
//** 创建人：桂书丛
//** 类名称\文件名：DAMoudle
//** 类功能：提供系统模块操作底层方法
//** 描 述：数据库表T_Module数据库访问类
//** 创建日期：2013-1-14
//** 修改(&U)人：桂书丛
//** 修改(&U)日期：2013-1-14
//** 整理日期：2013-1-14
//******************************************************************************************************

using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using CMS.Model;
using DBUtility;
using System.Data.SqlClient;
namespace CMS.DALayer
{
    /// <summary>
    /// 数据访问类DAT_Moudle 
    /// </summary>
    public class DAT_Moudle:IDALayer<ModelT_Module>
    {

        #region public DataTable GetUserModule(string paramUserRightID) 根据用户权限ID获得用户可访问的模块
        /// <summary>
        /// 根据用户权限ID获得用户可访问的模块
        /// </summary>
        /// <param name="paramUserRightID">用户权限ID</param>
        /// <returns></returns>
        public DataTable GetUserModule(string paramUserRightID)
        {
            DataTable myDataTable = null;
            string SqlQuery = " SELECT [M].[ID],[M].[FULLNAME],[M].[HREF],[M].[PARENTID],[RM].[MODULEID] "
                +" FROM [T_MODULE] AS [M] LEFT JOIN (SELECT [MODULEID] FROM [T_RIGHT_MODULE_MAP] "
                +" WHERE [RIGHTID]="+paramUserRightID+" ) AS [RM] ON [RM].[MODULEID]=[M].[ID] ";
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

        #region IDALayer<ModelT_Module> 成员

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
            string SqlQuery = " SELECT [ID],[FULLNAME],[HREF],[PARENTID],[DESCRIPTION] FROM  ";
            if (IsView == false)
                SqlQuery += " [T_MODULE] ";
            else
                SqlQuery += string.Empty;
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
                SqlQuery += " [T_MODULE] ";
            else
                SqlQuery += string.Empty;
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
        /// 创建人：桂书丛
        /// 创建日期：2013-02-22
        public int Update(ModelT_Module model)
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
        public int Insert(ModelT_Module model)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        #endregion
    }
}
