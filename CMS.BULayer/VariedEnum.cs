
//******************************************************************************************************
//** Copyright (C) 2010-2013 重大网络教育学院
//** 创建人：桂书丛
//** 类名称\文件名：VariedEnum
//** 类功能：列举应用程序中用到的枚举
//** 描 述：提供所有应用程序中的枚举
//** 创建日期：2013-1-21
//** 修改(&U)人：桂书丛
//** 修改(&U)日期：2013-1-21
//** 整理日期：2013-1-21
//******************************************************************************************************

using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.BULayer
{
    /// <summary>
    /// 系统枚举
    /// </summary>
    /// 创建人：桂书丛
    /// 创建日期：2013-02-22
    public class VariedEnum
    {
        #region 用户登陆状态枚举
        /// <summary>
        /// 用户登陆状态枚举
        /// </summary>
        public enum UserLoginStatus
        {
            DotExistUser,   //用户不存在
            PasswordError,  //密码错误
            Successed,      //登录成功
            UnknowError     //未知错误
        }
        #endregion

        #region 信息操作状态枚举
        /// <summary>
        /// 信息操作状态枚举
        /// </summary>
        public enum OperatorStatus
        {
            /// <summary>
            /// 失败
            /// </summary>
            /// 创建人：桂书丛
            /// 创建时间：2013-03-02
            Failed,         
            /// <summary>
            /// 成功
            /// </summary>
            /// 创建人：桂书丛
            /// 创建时间：2013-03-02
            Successed,     
            /// <summary>
            /// 未知错误
            /// </summary>
            /// 创建人：桂书丛
            /// 创建时间：2013-03-02
            UnknowError     
        }
        #endregion

        #region 系统常用枚举
        /// <summary>
        /// 餐台使用状态
        /// </summary>
        public enum BuffetStatus
        {
            /// <summary>
            /// 空闲 = 1
            /// </summary>
            /// 创建人：桂书丛
            /// 创建时间：2013-03-02
            空闲 = 1,               
            /// <summary>
            /// 占用 =2
            /// </summary>
            /// 创建人：桂书丛
            /// 创建时间：2013-03-02
            占用 =2,                
            /// <summary>
            /// 预定 = 3
            /// </summary>
            /// 创建人：桂书丛
            /// 创建时间：2013-03-02
            预定 = 3,               
            /// <summary>
            /// 脏台 = 4
            /// </summary>
            /// 创建人：桂书丛
            /// 创建时间：2013-03-02
            脏台 = 4,               
            /// <summary>
            /// 未定义 = 5
            /// </summary>
            /// 创建人：桂书丛
            /// 创建时间：2013-03-02
            未定义 = 5,            
        }
        /// <summary>
        /// 消费方式
        /// </summary>
        public enum ConsumeWay
        {
            /// <summary>
            /// 饭店消费 = 145
            /// </summary>
            /// 创建人：桂书丛
            /// 创建时间：2013-03-02
            饭店消费 = 145,
            /// <summary>
            /// 外卖 = 146
            /// </summary>
            /// 创建人：桂书丛
            /// 创建时间：2013-03-02
            外卖 = 146
        }
        /// <summary>
        /// 系统日志类型
        /// </summary>
        public enum LogType
        {
            /// <summary>
            /// 数据操作=1
            /// </summary>
            /// 创建人：桂书丛
            /// 创建时间：2013-03-02
            数据操作=1,
            /// <summary>
            /// 系统事件 = 2
            /// </summary>
            /// 创建人：桂书丛
            /// 创建时间：2013-03-02
            系统事件 = 2,
            /// <summary>
            /// 系统异常=3
            /// </summary>
            /// 创建人：桂书丛
            /// 创建时间：2013-03-02
            系统异常=3
        }

        /// <summary>
        /// 项目类别枚举
        /// </summary>
        public enum ItemType
        {
            /// <summary>
            /// 菜品类别
            /// </summary>
            /// 创建人：桂书丛
            /// 创建时间：2013-03-02
            DishType = 1,
            /// <summary>
            /// 菜品口味
            /// </summary>
            /// 创建人：桂书丛
            /// 创建时间：2013-03-02
            TasteType = 2,

            /// <summary>
            /// 房间楼层
            /// </summary>
            /// 创建人：桂书丛
            /// 创建时间：2013-03-02
            RoomFloor = 3,
           
            /// <summary>
            /// 餐台使用状态
            /// </summary>
            /// 创建人：桂书丛
            /// 创建时间：2013-03-02
            BuffetStatus = 4,

            /// <summary>
            /// 退菜原因
            /// </summary>
            /// 创建人：桂书丛
            /// 创建时间：2013-03-02
            BackResult = 5,

            /// <summary>
            /// 员工工作状态
            /// </summary>
            /// 创建人：桂书丛
            /// 创建时间：2013-03-02
            WorkStatus = 6,

            /// <summary>
            /// 消费类型
            /// </summary>
            /// 创建人：桂书丛
            /// 创建时间：2013-03-02
            ConsumeType = 7,

            /// <summary>
            /// 支付方式
            /// </summary>
            /// 创建人：桂书丛
            /// 创建时间：2013-03-02
            PayType = 8,
        }


        /// <summary>
        /// 支付方式
        /// </summary>
        /// 创建人：桂书丛
        /// 创建时间：2013-03-02
        public enum PayType
        {
            /// <summary>
            /// VIP消费
            /// </summary>
            /// 创建人：桂书丛
            /// 创建时间：2013-03-02
            VIPPay=153
        }

        #endregion
    }
}
