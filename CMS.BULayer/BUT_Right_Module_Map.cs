using System;
using System.Collections.Generic;
using System.Text;

using CMS.DALayer;
using System.Data;
using CMS.Model;
namespace CMS.BULayer
{
    /// <summary>
    /// 业务逻辑类BUT_Right_Module_Map   
    /// </summary>
    public class BUT_Right_Module_Map:IBULayer<ModelT_Right_Module_Map>
    {
        private DAT_Right_Module_Map dal = new DAT_Right_Module_Map();

        #region public DataTable GetRightModule(string paramRightID) 根据权限ID获得可访问的模块
        /// <summary>
        /// 根据权限ID获得可访问的模块
        /// </summary>
        /// <param name="paramRightID">权限ID</param>
        /// <returns></returns>
        public DataTable GetRightModule(string paramRightID)
        {
            DataTable myDataTable = null;
            try
            {
                myDataTable = dal.GetRightModule(paramRightID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return myDataTable;
        }
        #endregion

        #region public VariedEnum.OperatorStatus Insert(……) 插入一条数据记录
        /// <summary>
        /// 插入一条数据记录
        /// </summary>
        /// <param name="paramRightID">权限ID</param>
        /// <param name="paramModuleID">模块ID</param>
        /// <param name="paramCreatePerson">创建人</param>
        /// <returns></returns>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-22
        public VariedEnum.OperatorStatus Insert(int paramRightID, int paramModuleID, string paramCreatePerson)
        {
            ModelT_Right_Module_Map tempModelT_Right_Module_Map = new ModelT_Right_Module_Map();
            tempModelT_Right_Module_Map.ModuleID = paramModuleID;
            tempModelT_Right_Module_Map.RightID = paramRightID;
            tempModelT_Right_Module_Map.CreateDate = DateTime.Now;
            tempModelT_Right_Module_Map.CreatePerson = paramCreatePerson;
            try
            {
                return Insert(tempModelT_Right_Module_Map);
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region IBULayer<ModelT_Right_Module_Map> 成员

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
        public VariedEnum.OperatorStatus Update(ModelT_Right_Module_Map model)
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
        public VariedEnum.OperatorStatus Insert(ModelT_Right_Module_Map model)
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
        /// 创建日期：2013-02-22
        public VariedEnum.OperatorStatus Delete(string paramID)
        {
            int tempIntValue = -5;
            try
            {
                tempIntValue = dal.Delete(paramID);
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
