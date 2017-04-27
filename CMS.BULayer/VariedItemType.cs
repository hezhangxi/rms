
//******************************************************************************************************
//** Copyright (C) 2010-2013 重大网络教育学院
//** 创建人：桂书丛
//** 类名称\文件名：VariedItemType
//** 类功能：列举应用程序中用到的项目名称
//** 描 述：列举应用程序中用到的项目名称
//** 创建日期：2013-1-31
//** 修改(&U)人：桂书丛
//** 修改(&U)日期：2013-1-31
//** 整理日期：2013-1-31
//******************************************************************************************************

using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
namespace CMS.BULayer
{
    public class VariedItemType
    {
        #region private static string GetSysItemTypeName(int paramKey) 通过Key获得其对应的Value的值
        /// <summary>
        /// 通过Key获得其对应的Value的值
        /// </summary>
        /// <param name="paramKey">Key</param>
        /// <returns></returns>
        private static string GetSysItemTypeName(int paramKey)
        {
            try
            {
                Dictionary<int, string> SysItemType = GetSysItemTypeDictionary();
                string ItemTypeName=string.Empty;
                foreach (KeyValuePair<int,string> tempKeyValue in SysItemType)
                {
                    if (tempKeyValue.Key == paramKey)
                        ItemTypeName = tempKeyValue.Value;
                }
                return ItemTypeName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region  private static Dictionary<int,string> GetSysItemTypeDictionary() 获得系统项目类别词典
        /// <summary>
        /// 获得系统项目类别词典
        /// </summary>
        /// <returns></returns>
        private static Dictionary<int,string> GetSysItemTypeDictionary()
        {
            BUCMS_ItemType myBUCMSItemType = new BUCMS_ItemType();
            Dictionary<int, string> returnSysItemType = new Dictionary<int, string>();
            try
            {
                DataTable tempDataTable = myBUCMSItemType.GetOrder(false,string.Empty,string.Empty,false);
                foreach (DataRow tempDataRow in tempDataTable.Rows)
                {
                    int Key=Convert.ToInt32(tempDataRow["ID"]);
                    if (!returnSysItemType.ContainsKey(Key))
                    {
                        string Value = tempDataRow["Name"].ToString();
                        returnSysItemType.Add(Key,Value);
                    }
                }
                return returnSysItemType;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region 系统项目类型
        /// <summary>
        /// 菜品类别
        /// </summary>
        public static string DishType
        {
            get
            {
                return GetSysItemTypeName(Convert.ToInt32(VariedEnum.ItemType.DishType));
            }
        }
        /// <summary>
        /// 菜品口味
        /// </summary>
        public static string TasteType
        {
            get
            {
                return GetSysItemTypeName(Convert.ToInt32(VariedEnum.ItemType.TasteType));
            }
        }
        /// <summary>
        /// 房间楼层
        /// </summary>
        public static string RoomFloor
        {
            get
            {
                return GetSysItemTypeName(Convert.ToInt32(VariedEnum.ItemType.RoomFloor));
            }
        }
        /// <summary>
        /// 餐台使用状态
        /// </summary>
        public static string BuffetStatus
        {
            get
            {
                return GetSysItemTypeName(Convert.ToInt32(VariedEnum.ItemType.BuffetStatus));
            }
        }
        /// <summary>
        /// 退菜原因
        /// </summary>
        public static string BackResult
        {
            get
            {
                return GetSysItemTypeName(Convert.ToInt32(VariedEnum.ItemType.BackResult));
            }
        }
        /// <summary>
        /// 员工工作状态
        /// </summary>
        public static string WorkStatus
        {
            get
            {
                return GetSysItemTypeName(Convert.ToInt32(VariedEnum.ItemType.WorkStatus));
            }
        }
        /// <summary>
        /// 消费类型
        /// </summary>
        public static string ConsumeType
        {
            get
            {
                return GetSysItemTypeName(Convert.ToInt32(VariedEnum.ItemType.ConsumeType));
            }
        }
        /// <summary>
        /// 支付方式
        /// </summary>
        public static string PayType
        {
            get
            {
                return GetSysItemTypeName(Convert.ToInt32(VariedEnum.ItemType.PayType));
            }
        }
        #endregion

    }
}
