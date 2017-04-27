
//******************************************************************************************************
//** Copyright (C) 2010-2013 重大网络教育学院
//** 创建人：桂书丛
//** 类名称\文件名：CommonOperator
//** 类功能：通用操作类
//** 描 述：系统通用操作方法的封装
//** 创建日期：2013-1-15
//** 修改(&U)人：桂书丛
//** 修改(&U)日期：2013-1-29
//******************************************************************************************************

using System;
using System.Collections.Generic;
using System.Text;

using System.IO;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using CMS.BULayer;
using System.Xml;
using DevExpress.XtraEditors;
using System.Runtime.InteropServices;
using DevExpress.XtraEditors.Controls;
namespace CMS.UILayer.ClassAssist
{
    class CommonOperator
    {
        #region 动态显示窗体
        /// <summary>
        /// 动态显示窗体
        /// </summary>
        /// <param name="hwnd">要动态显示的窗口句柄</param>
        /// <param name="dwTime">动态显示时间</param>
        /// <param name="dwFlags">动态显示方式</param>
        /// <returns>true-显示成功，false-显示失败</returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);

        //dwflag的取值如下
        public const Int32 AW_HOR_POSITIVE = 0x00000001;
        //从左到右显示
        public const Int32 AW_HOR_NEGATIVE = 0x00000002;
        //从右到左显示
        public const Int32 AW_VER_POSITIVE = 0x00000004;
        //从上到下显示
        public const Int32 AW_VER_NEGATIVE = 0x00000008;
        //从下到上显示
        public const Int32 AW_CENTER = 0x00000010;
        //若使用了AW_HIDE标志，则使窗口向内重叠，即收缩窗口；否则使窗口向外扩展，即展开窗口
        public const Int32 AW_HIDE = 0x00010000;
        //隐藏窗口，缺省则显示窗口
        public const Int32 AW_ACTIVATE = 0x00020000;
        //激活窗口。在使用了AW_HIDE标志后不能使用这个标志
        public const Int32 AW_SLIDE = 0x00040000;
        //使用滑动类型。缺省则为滚动动画类型。当使用AW_CENTER标志时，这个标志就被忽略
        public const Int32 AW_BLEND = 0x00080000;
        //透明度从高到低

        #region 动画——中心辐射700ms
        /// <summary>
        /// 动画——中心辐射700ms
        /// </summary>
        public static void AnimateWindowLoad(IntPtr Handle)
        {
            AnimateWindow(Handle, 1200, AW_BLEND | AW_ACTIVATE);
        }

        public static void AnimateWindowClosing(IntPtr Handle)
        {
            AnimateWindow(Handle, 1200, AW_VER_NEGATIVE | AW_HIDE);
        }
        #endregion
        #endregion

        /// <summary>
        /// 获得操作系统配置文件的对像
        /// </summary>
        /// <returns></returns>
        public static INIOperator GetSysINI()
        {
            string tempIniFilePath = Application.StartupPath + "\\SysSettings.ini";
            INIOperator returnINIOperator = new INIOperator(tempIniFilePath);

            return returnINIOperator;
        }

        /// <summary>
        /// 修改(&U)App.config
        /// </summary>
        /// <param name="paramTargetString">要修改(&U)内容的标签名称</param>
        /// <param name="paramUpdateString">修改(&U)后的内容</param>
        public static void SaveConfig(string paramTargetString, string paramUpdateString)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Application.ExecutablePath + ".config");
            XmlNode node = doc.SelectSingleNode(@"//add[@key='" + paramTargetString + "']");
            XmlElement ele = (XmlElement)node;
            ele.SetAttribute("value", paramUpdateString);
            doc.Save(Application.ExecutablePath + ".config");
        }

        #region public static void DataBindingLookUpEdit() 绑定下拉框
        /// <summary>
        /// 绑定下拉框:paramLUE:控件名称，paramDataTable:数据源，paraDisplayMember:显示值，paramValueMember:实际值，paramSimpleOrNot：是否是类似Window经典风格数据绑定
        /// </summary>
        /// <param name="paramLUE">控件名</param>
        /// <param name="paramDataTable">数据源</param>
        /// <param name="paramDisplayMember">显示值</param>
        /// <param name="paramValueMember">实际值</param>
        /// <param name="paramSimpleOrNot">是否是类似Window经典风格数据绑定,false：不是</param>
        public static void DataBindingLookUpEdit(DevExpress.XtraEditors.LookUpEdit paramLUE, DataTable paramDataTable, string paramDisplayMember, string paramValueMember,bool paramSimpleOrNot)
        {
            paramLUE.Properties.Columns.Clear();
            if (paramLUE.Width < 218)
                XtraMessageBox.Show("请保证待绑定控件的宽度不小于218","宽度过小",
                    MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            DevExpress.XtraEditors.Controls.LookUpColumnInfo lupColumnInfoID = new DevExpress.XtraEditors.Controls.LookUpColumnInfo();
            lupColumnInfoID.FieldName = paramValueMember;
            lupColumnInfoID.Caption = "项目编号";
            DevExpress.XtraEditors.Controls.LookUpColumnInfo lupColumnInfoName = new DevExpress.XtraEditors.Controls.LookUpColumnInfo();
            lupColumnInfoName.FieldName = paramDisplayMember;
            lupColumnInfoName.Caption = "项目名称";
            if (paramSimpleOrNot == false)
            {
                lupColumnInfoID.Width = paramLUE.Width / 2 - 15;
                lupColumnInfoName.Width = paramLUE.Width / 2 + 15;
                paramLUE.Properties.Columns.Add(lupColumnInfoID);
            }
            paramLUE.Properties.Columns.Add(lupColumnInfoName);
            //paramLUE.Properties.ShowFooter = !paramSimpleOrNot;
            paramLUE.Properties.ShowHeader = !paramSimpleOrNot;
            //paramLUE.Properties.ShowLines = !paramSimpleOrNot;
            //paramLUE.Properties.AllowFocused = !paramSimpleOrNot;
            if(paramDataTable.Rows.Count < 7)
                paramLUE.Properties.DropDownRows = paramDataTable.Rows.Count;
            paramLUE.Properties.DisplayMember = paramDisplayMember;
            paramLUE.Properties.ValueMember = paramValueMember;
            paramLUE.Properties.DataSource = paramDataTable;
            paramLUE.ItemIndex = 0;
        }

        /// <summary>
        /// 绑定下拉框
        /// </summary>
        /// <param name="lookUpEdit">控件名</param>
        /// <param name="myDt">数据源</param>
        /// <param name="DisplayMember">显示值</param>
        /// <param name="ValueMember">实际值</param>
        /// <param name="IsNull">是否显示空行</param>
        /// <param name="paramText">显示列头的前缀</param>
        internal static void BindLookUpEdit(LookUpEdit lookUpEdit, DataTable myDt, string DisplayMember, string ValueMember, bool IsNull, string paramText)
        {
            if (IsNull)
            {
                DataRow myDr = myDt.NewRow();
                myDr[ValueMember] = "";
                myDr[DisplayMember] = "";
                myDt.Rows.InsertAt(myDr, 0);
                myDt.AcceptChanges();
            }
            lookUpEdit.Properties.Columns.Clear();
            LookUpColumnInfo lupColumnInfoID = new LookUpColumnInfo();
            lupColumnInfoID.FieldName = ValueMember;
            lupColumnInfoID.Caption = paramText + "编号";
            lupColumnInfoID.Width = 10;
            lookUpEdit.Properties.Columns.Add(lupColumnInfoID);

            LookUpColumnInfo lupColumnInfoName = new LookUpColumnInfo();
            lupColumnInfoName.FieldName = DisplayMember;
            lupColumnInfoName.Caption = paramText + "名称";
            lupColumnInfoName.Width = 10;
            lookUpEdit.Properties.Columns.Add(lupColumnInfoName);

            lookUpEdit.Properties.ShowFooter = false;
            lookUpEdit.Properties.ShowHeader = true;
            lookUpEdit.Properties.ShowLines = true;
            lookUpEdit.Properties.AllowFocused = false;

            lookUpEdit.Properties.DropDownRows = myDt.Rows.Count;
            lookUpEdit.Properties.DataSource = myDt;
            lookUpEdit.Properties.DisplayMember = DisplayMember;
            lookUpEdit.Properties.ValueMember = ValueMember;
            lookUpEdit.Properties.NullText = "";
            lookUpEdit.Properties.BestFit();
        }
        #endregion

        #region public static void GetRandomBillID() 随机生成账单ID字符串：格式:年月日时分秒。如：20130129
        /// <summary>
        /// 随机生成账单ID字符串：格式:年月日时分秒。如：20130129172548
        /// </summary>
        public static string GetRandomBillID()
        {
            string tempRandomID = string.Empty;
            tempRandomID = DateTime.Now.ToString("yyyyMMddHHmmss");

            return tempRandomID;
        }
        #endregion

        #region public static bool HandleOperatorEnum(string paramOperator,VariedEnum.OperatorStatus paramOperatorStatus) 处理操作枚举
        /// <summary>
        /// 处理操作枚举:paramOperator:操作类型,paramOperatorStatus:操作状态公用枚举实例
        /// </summary>
        /// <param name="paramOperator">操作类型</param>
        /// <param name="paramOperatorStatus">操作状态公用枚举</param>
        /// <returns></returns>
        public static bool HandleOperatorEnum(string paramOperator,VariedEnum.OperatorStatus paramOperatorStatus)
        {
            switch (paramOperatorStatus)
            {
                case VariedEnum.OperatorStatus.Successed:
                    XtraMessageBox.Show(paramOperator + "成功", "恭喜");
                    return true;
                case VariedEnum.OperatorStatus.Failed:
                    XtraMessageBox.Show(paramOperator + "失败", "抱歉",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                default: XtraMessageBox.Show(paramOperator + "失败,请查明后再试", "抱歉",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
            }
        }
        #endregion

        #region public static object[] GetGVSelectRowInfo(DevExpress.XtraGrid.Views.Grid.GridView paramGridView) 获得gridView选中的一行信息：主用于修改(&U)操作的传值
        /// <summary>
        /// 获得gridView选中的一行信息：主用于修改(&U)操作的传值
        /// </summary>
        /// <param name="paramGridView">待操作的GridView</param>
        /// <returns></returns>
        public static object[] GetGVSelectRowInfo(DevExpress.XtraGrid.Views.Grid.GridView paramGridView)
        {
            if (paramGridView.GetFocusedDataRow() == null)
                return null;
            DataRow tempDataRow = paramGridView.GetFocusedDataRow();
            if (tempDataRow == null)
                return null;
            int tempInfoCount = tempDataRow.Table.Columns.Count;
            object[] tempInfo = new object[tempInfoCount];
            try
            {
                for (int Begin = 0; Begin < tempInfoCount; Begin++)
                {
                    tempInfo[Begin] = tempDataRow[Begin];
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                return null;
            }
            return tempInfo;
        }
        #endregion
    }
}
