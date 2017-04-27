
//******************************************************************************************************
//** Copyright (C) 2010-2013 重大网络教育学院
//** 创建人：桂书丛
//** 类名称\文件名：BUUser
//** 类功能：提供对通用项目操作的逻辑处理方法
//** 描 述：包括基本的增、删、查、改（所有关于通用项目数据库操作的方法）
//** 创建日期：2013-1-14
//** 修改(&U)人：桂书丛
//** 修改(&U)日期：2013-1-14
//** 整理日期：2013-1-14
//******************************************************************************************************

using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using CMS.DALayer;
namespace CMS.BULayer
{
    /// <summary>
    /// 业务逻辑类BUT_ItemDetail   
    /// </summary>
    public class BUT_ItemDetail
    {
        private readonly DAT_ItemDetail dal = new DAT_ItemDetail();

        #region public DataTable GetItemByType(string paramItemType) 根据项目类型获得对应项目信息
        /// <summary>
        /// 根据项目类型获得对应项目信息
        /// </summary>
        /// <param name="paramItemType">项目类型</param>
        /// <returns></returns>
        public DataTable GetItemByType(string paramItemType)
        {
            DataTable myDataTable = null;
            try
            {
                myDataTable = dal.GetItemByType(paramItemType);
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
