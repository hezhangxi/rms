using System;
using System.Collections.Generic;
using System.Text;

using DBUtility;
using CMS.Model;
using System.Data;
namespace CMS.DALayer
{
    /// <summary>
    /// 数据访问类DAT_Right_Module_Map 
    /// </summary>
    public class DAT_Right_Module_Map:IDALayer<ModelT_Right_Module_Map>
    {
        #region public DataTable GetRightModule(string paramRightID) 根据权限ID获得可访问的模块
        /// <summary>
        /// 根据权限ID获得可访问的模块
        /// </summary>
        /// <param name="paramRightID">权限ID</param>
        /// <returns></returns>
        public DataTable GetRightModule(string paramRightID)
        {
            DataTable myDataTable = null;
            string SqlQuery = " SELECT [M].[ID],[M].[FULLNAME],[M].[HREF],[M].[PARENTID],[RM].[MODULEID] "
                + " FROM [T_MODULE] AS [M] LEFT JOIN (SELECT [MODULEID] FROM [T_RIGHT_MODULE_MAP] "
                + " WHERE [RIGHTID]=" + paramRightID + " ) AS [RM] ON [RM].[MODULEID]=[M].[ID] ";
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

        #region IDALayer<ModelT_Right_Module_Map> 成员

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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        /// <summary>
        /// 更新一条数据记录
        /// </summary>
        /// <param name="model">实体类实例</param>
        /// <returns></returns>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-22
        public int Update(ModelT_Right_Module_Map model)
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
        public int Insert(ModelT_Right_Module_Map model)
        {
            int returnIntValue = -5;
            string SqlQuery = " INSERT INTO [T_Right_Module_Map]"
                + "([RightID]"
                + ",[ModuleID]"
                + ",[CreatePerson]"
                + ",[CreateDate]"
                + " ) VALUES ( "
                + " " + model.RightID + ""
                + "," + model.ModuleID + ""
                + ",'" + model.CreatePerson + "'"
                + ",'" + model.CreateDate + "')";
            try
            {
                returnIntValue = DbHelperSQL.ExecuteNonQuery(SqlQuery);
                return returnIntValue;
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
        public int Delete(string paramID)
        {
            int returnIntValue = -5;
            string SqlQuery = " DELETE FROM [T_RIGHT_MODULE_MAP] WHERE [RIGHTID] = " + paramID + " ";
            try
            {
                returnIntValue = DbHelperSQL.ExecuteNonQuery(SqlQuery);
                return returnIntValue;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
