
//******************************************************************************************************************
//** Copyright (C) 2010-2013 重大网络教育学院
//** 创建人：桂书丛
//** 类名称\文件名：SysHotKey
//** 类功能：注册系统热键
//** 描 述：注册系统热键
//** 创建日期：2013-2-3
//** 修改(&U)人：桂书丛
//** 修改(&U)日期：2013-2-3
//** 整理日期：2013-2-3
//******************************************************************************************************************

using System;
using System.Collections.Generic;
using System.Text;

using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace CMS.CommonLayer
{
    /// <summary>
    /// 注册定义窗口热键
    /// </summary>
    public class SysHotKey
    {
        //************************************************************************************************************
        //** Copyright (C) 2010-2013 桂书丛
        //** 创建人：桂书丛
        //** 创建日期：2013-2-3
        //** 描 述：系统热键使用方法
        //************************************************************************************************************
        //*///////////////////////////////////////////////////////////////////////////////////////////////////////////
        //* RegisterHotKey函数原型及说明：
        //* BOOL RegisterHotKey(
        //* HWND hWnd,         // window to receive hot-key notification
        //* int id,            // identifier of hot key
        //* UINT fsModifiers,  // key-modifier flags
        //* UINT vk            // virtual-key code);
        //* 参数 id为你自己定义的一个ID值
        //* 对一个线程来讲其值必需在0x0000 - 0xBFFF范围之内,十进制为0~49151
        //* 对DLL来讲其值必需在0xC000 - 0xFFFF 范围之内,十进制为49152~65535
        //* 在同一进程内该值必须唯一参数 fsModifiers指明与热键联合使用按键
        //* 可取值为：MOD_ALT MOD_CONTROL MOD_WIN MOD_SHIFT参数，或数字0为无，1为Alt,2为Control，4为Shift，8为Windows
        //* vk指明热键的虚拟键码
        //*//////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////使用时必须重写WndProc()方法，通过监视系统消息，来调用自定义的热键处理过程
        //protected override void WndProc(ref Message m)    //监视Windows消息
        //{
        //    const int WM_HOTKEY = 0x0312;                 //如果m.Msg的值为0x0312那么表示用户按下了热键
        //    switch (m.Msg)
        //    {
        //        case WM_HOTKEY:
        //            ProcessHotkey(m);                     //按下热键时调用ProcessHotkey()函数
        //            break;
        //        case WM_QUERYENDSESSION:                  //系统关闭消息
        //            Application.ExitThread();
        //            Application.Exit();
        //            base.WndProc(ref m);                  //将系统消息传递自父类的WndProc
        //            break;
        //        default: break;
        //    }
        //    base.WndProc(ref m);                          //将系统消息传递自父类的WndProc
        //}
        ////自定义热键处理过程函数
        //private void ProcessHotkey(Message m)             //按下设定的键时调用该函数
        //{
        //    IntPtr id = m.WParam;                         //IntPtr用于表示指针或句柄的平台特定类型
        //    string sid = id.ToString();
        //    switch (sid)
        //    {
        //        case "100":
        //            MessageBox.Show("调用A函数");
        //            break;
        //        case "200":
        //            MessageBox.Show("调用B函数");
        //            break;
        //        default: break;
        //    }
        //}
        ////////////////////////////////////////////////////////////////////////////////////////////////////


        /// <summary>
        /// 注册热键(快捷键)
        /// </summary>
        /// <param name="hWnd">要定义热键的窗口的句柄</param>
        /// <param name="HotKeyID">定义热键ID(不能有重复的ID)</param>
        /// <param name="IsModifiers">标识热键需配合功能键时才会生效(Alt、Ctrl、Shift、Win键或None)</param>
        /// <param name="Key">定义热键为键盘的按键</param>
        /// <returns>true:注册热键成功;false:注册热键失败</returns>
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool RegisterHotKey(
            IntPtr hWnd,
            int HotKeyID,
            KeyModifiers IsModifiers,
            Keys Key
            );

        /// <summary>
        /// 销毁热键
        /// </summary>
        /// <param name="hWnd">要销毁热键的窗口的句柄</param>
        /// <param name="HotKeyID">要销毁热键的ID号(注册时定义的)</param>
        /// <returns>true:销毁热键成功;false:销毁热键失败</returns>
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool UnregisterHotKey(
            IntPtr hWnd,
            int HotKeyID
            );

        //定义了辅助键的名称（将数字转变为字符以便于记忆，也可去除此枚举而直接使用数值）
        /// <summary>
        /// 定义组合键
        /// </summary>
        [Flags()]
        public enum KeyModifiers
        {
            None = 0,
            Alt = 1,
            Ctrl = 2,
            Shift = 4,
            WindowsKey = 8
        }
    }
}
