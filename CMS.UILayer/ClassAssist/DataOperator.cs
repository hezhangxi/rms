
//******************************************************************************************************
//** Copyright (C) 2010-2013 重大网络教育学院
//** 创建人：桂书丛
//** 类名称\文件名：DataOperator
//** 类功能：数据操作类
//** 描 述：对控件动态添加(&A)数据
//** 创建日期：2013-1-21
//** 修改(&U)人：桂书丛
//** 修改(&U)日期：2013-1-22
//******************************************************************************************************

using System;
using System.Collections.Generic;
using System.Text;

using System.IO;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;
using CMS.BULayer;
using DevExpress.XtraPrinting;
namespace CMS.UILayer.ClassAssist
{
    class DataOperator
    {
        #region public static void BindTreeView(TreeView paramTVW, DataTable paramDataTable) 绑定根目录
        /// <summary>
        /// 绑定根目录
        /// </summary>
        /// <param name="paramTVW"></param>
        /// <param name="paramDataTable"></param>
        public static void BindTreeView(TreeView paramTVW, DataTable paramDataTable)
        {
            if (paramDataTable.Rows.Count <= 0)
            {
                return;
            }
            paramTVW.Nodes.Clear();
            TreeNode myTreeNode;
            //查询根目录
            foreach (DataRow myDataRow in paramDataTable.Rows)
            {
                if (Convert.ToInt32(myDataRow["PARENTID"]) == 0)
                {
                    myTreeNode = new TreeNode(myDataRow["FULLNAME"].ToString());
                    myTreeNode.Name = myDataRow["ID"].ToString();
                    if (myDataRow["MODULEID"].ToString() != string.Empty)
                        myTreeNode.Checked = true;
                    BindChildTreeView(myTreeNode, paramDataTable);
                    paramTVW.Nodes.Add(myTreeNode);
                }
            }
            paramTVW.ExpandAll();
        }

        /// <summary>
        /// 绑定子节点
        /// </summary>
        /// <param name="paramParentID">根节点ID</param>
        /// <param name="paramTreeNode">根节点</param>
        /// <param name="paramDataTable">目录列表</param>
        private static void BindChildTreeView(TreeNode paramTreeNode, DataTable paramDataTable)
        {
            TreeNode myTreeNode;
            foreach (DataRow myDataRow in paramDataTable.Rows)
            {
                if (myDataRow["PARENTID"].ToString() == paramTreeNode.Name)
                {
                    myTreeNode = new TreeNode(myDataRow["FULLNAME"].ToString());
                    myTreeNode.Name = myDataRow["ID"].ToString();
                    if (paramDataTable.Select("PARENTID=" + myTreeNode.Name + "").Length <= 0)//没有子节点,设置样式
                    {
                        myTreeNode.ImageIndex = 4;
                        myTreeNode.SelectedImageIndex = 3;
                    }
                    if (myDataRow["MODULEID"].ToString() != string.Empty)
                        myTreeNode.Checked = true;
                    paramTreeNode.Nodes.Add(myTreeNode);
                    BindChildTreeView(myTreeNode, paramDataTable);
                }
            }
        }
        #endregion

        #region public static void OperatorTree(TreeView paramTreeView, DataTable paramDataTable) 根据数据集操作树节点：相应的打上勾
        /// <summary>
        /// 根据数据集操作树节点：相应的打上勾，若paramDataTable为null则全部节点不打勾
        /// </summary>
        /// <param name="paramTreeView">要操作的数</param>
        /// <param name="paramDataTable">数据集</param>
        public static void OperatorTree(TreeView paramTreeView, DataTable paramDataTable)
        {
            if (paramTreeView.Nodes.Count <= 0)
                return;
            TreeNodeCollection tempTreeNodeCollection = paramTreeView.Nodes;
            foreach (TreeNode tempTreeNode in tempTreeNodeCollection)
            {  
                if (paramDataTable == null)
                {
                    tempTreeNode.Checked = false;
                    OperatorTreeNode(tempTreeNode, paramDataTable);
                    continue;
                }
                foreach (DataRow tempDataRow in paramDataTable.Rows)
                {
                    if (tempTreeNode.Name == tempDataRow["ID"].ToString())
                    {
                        if (tempDataRow["MODULEID"].ToString() != string.Empty)
                            tempTreeNode.Checked = true;
                        else
                            tempTreeNode.Checked = false;
                        OperatorTreeNode(tempTreeNode, paramDataTable);
                    }
                }
            }
        }

        /// <summary>
        /// 操作子节点
        /// </summary>
        /// <param name="paramTreeNode"></param>
        /// <param name="paramDataTable"></param>
        private static void OperatorTreeNode(TreeNode paramTreeNode, DataTable paramDataTable)
        {
            if (paramTreeNode.Nodes.Count <= 0)
                return;
            TreeNodeCollection tempTreeNodeCollection = paramTreeNode.Nodes;
            foreach (TreeNode tempTreeNode in tempTreeNodeCollection)
            {
                if (paramDataTable == null)
                {
                    tempTreeNode.Checked = false;
                    OperatorTreeNode(tempTreeNode, paramDataTable);
                    continue;
                }
                foreach (DataRow tempDataRow in paramDataTable.Rows)
                {
                    if (tempTreeNode.Name == tempDataRow["ID"].ToString())
                    {
                        if (tempDataRow["MODULEID"].ToString() != string.Empty)
                            tempTreeNode.Checked = true;
                        else
                            tempTreeNode.Checked = false;
                        OperatorTreeNode(tempTreeNode, paramDataTable);
                    }
                }
            }
        }
        #endregion

        #region public static int GetCheckedTreeNodeNum(TreeView paramTreeView,int CurrentNum) 得到树中的选中的节点数
        /// <summary>
        /// 得到树中的选中的节点数
        /// </summary>
        /// <param name="paramTreeView">要操作的树控件</param>
        /// <param name="CurrentNum">计数基数</param>
        /// <returns></returns>
        public static int GetCheckedTreeNodeNum(TreeView paramTreeView,int CurrentNum)
        {
            if (paramTreeView.Nodes.Count <= 0)
                return 0;
            TreeNodeCollection tempTreeNodeCollection = paramTreeView.Nodes;
            foreach (TreeNode tempTreeNode in tempTreeNodeCollection)
            {
                if (tempTreeNode.Checked == true)
                {
                    CurrentNum++;
                }
                CurrentNum = GetCheckedTreeNodeNum(tempTreeNode, CurrentNum);
            }
            return CurrentNum;
        }

        /// <summary>
        /// 对子节点进行计数
        /// </summary>
        /// <param name="paramTreeNode">要操作的节点</param>
        /// <param name="CurrentNum">计数基数</param>
        /// <returns></returns>
        private static int GetCheckedTreeNodeNum(TreeNode paramTreeNode,int CurrentNum)
        {
            if (paramTreeNode.Nodes.Count <= 0)
                return CurrentNum;
            TreeNodeCollection tempTreeNodeCollection = paramTreeNode.Nodes;
            foreach (TreeNode tempTreeNode in tempTreeNodeCollection)
            {
                if (tempTreeNode.Checked == true)
                {
                    CurrentNum++;
                }
                CurrentNum = GetCheckedTreeNodeNum(tempTreeNode, CurrentNum);
            }
            return CurrentNum;
        }
        #endregion

        #region public static void OutData(DevExpress.XtraGrid.Views.Grid.GridView paramGridView,string paramTarget) 数据导出
        /// <summary>
        /// 数据导出:paramGridView:要操作的GridView控件
        /// </summary>
        /// <param name="paramGridView">要操作的GridView控件</param>
        /// <param name="paramTarget">导出操作对象描述：如系统日志</param>
        public static void DataOut(DevExpress.XtraGrid.Views.Grid.GridView paramGridView,string paramTarget)    //另存新档按钮   导出成Excel 
        {
            string tempFilePath = string.Empty;
            string tempFileExt = string.Empty;
            SaveFileDialog mySaveFileDialog = new SaveFileDialog();
            mySaveFileDialog.Filter = "Execl表格(*.xls)|*.xls|Word文档(*.doc)|*.doc|文本文档(*.txt)|*.txt";
            mySaveFileDialog.AddExtension=true;
            mySaveFileDialog.DefaultExt="xls";
            mySaveFileDialog.FilterIndex = 0;
            mySaveFileDialog.RestoreDirectory = true;
            mySaveFileDialog.Title = "数据导出到";
            mySaveFileDialog.FileName = "导出的数据";
            if (mySaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                 tempFilePath = mySaveFileDialog.FileName;
                 int tempPointPos = tempFilePath.LastIndexOf(".");
                 tempFileExt = tempFilePath.Substring(tempPointPos+1).ToLower();
                 switch (tempFileExt)
                 {
                     case "xls": ExportToExcel(paramGridView, tempFilePath);
                         break;
                     case "doc": ExportToWord(paramGridView, tempFilePath);
                         break;
                     default: ExportToTXT(paramGridView, tempFilePath);
                         break;
                 }
                 OpenFile(tempFilePath);
                 BUT_SysLog.InsertSysLog(VariedEnum.LogType.数据操作, frmAssist.frmLogin.SysUser.UserID,"成功导出了" + paramGridView.DataRowCount.ToString() + "条" + paramTarget);
            }
        }
        #endregion

        #region private static void ExportToExcel(DevExpress.XtraGrid.Views.Grid.GridView paramGridView, string paramFilePath) 数据导出到Excel
        /// <summary>
        /// 数据导出到Excel
        /// </summary>
        /// <param name="paramGridView">要操作的GridView控件</param>
        /// <param name="paramFilePath">导出文件路径</param>
        private static void ExportToExcel(DevExpress.XtraGrid.Views.Grid.GridView paramGridView, string paramFilePath)
        {
            DevExpress.XtraPrinting.XlsExportOptions myXlsExportOptions = new DevExpress.XtraPrinting.XlsExportOptions();
            myXlsExportOptions.ExportHyperlinks = true;
            myXlsExportOptions.SheetName = "餐饮管理系统";
            myXlsExportOptions.ShowGridLines = true;
            myXlsExportOptions.TextExportMode = DevExpress.XtraPrinting.TextExportMode.Value;
            paramGridView.ExportToXls(paramFilePath, myXlsExportOptions);
        }
        #endregion

        #region private static void ExportToWord(DevExpress.XtraGrid.Views.Grid.GridView paramGridView, string paramFilePath) 数据导出到Word
        /// <summary>
        /// 数据导出到Word
        /// </summary>
        /// <param name="paramGridView">要操作的GridView控件</param>
        /// <param name="paramFilePath">导出文件路径</param>
        private static void ExportToWord(DevExpress.XtraGrid.Views.Grid.GridView paramGridView, string paramFilePath)
        {
            paramGridView.ExportToRtf(paramFilePath);
        }
        #endregion

        #region private static void ExportToTXT(DevExpress.XtraGrid.Views.Grid.GridView paramGridView, string paramFilePath) 其他数据导出
        /// <summary>
        /// 其他数据导出
        /// </summary>
        /// <param name="paramGridView">要操作的GridView控件</param>
        /// <param name="paramFilePath">导出文件路径</param>
        private static void ExportToTXT(DevExpress.XtraGrid.Views.Grid.GridView paramGridView, string paramFilePath)
        {
            DevExpress.XtraPrinting.TextExportOptions myTextExportOptions = new DevExpress.XtraPrinting.TextExportOptions();
            myTextExportOptions.QuoteStringsWithSeparators = true;
            myTextExportOptions.TextExportMode=DevExpress.XtraPrinting.TextExportMode.Text;
            paramGridView.ExportToText(paramFilePath, myTextExportOptions);
        }
        #endregion

        #region private static void OpenFile(string paramFileName) 打开文件
        /// <summary>
        /// 打开文件
        /// </summary>
        /// <param name="paramFileName">要打开的文件名称</param>
        private static void OpenFile(string paramFileName)
        {
            if (XtraMessageBox.Show("是否打开此文件？", "导出成功", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    process.StartInfo.FileName = paramFileName;
                    process.StartInfo.Verb = "Open";
                    process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                    process.Start();
                }
                catch
                {
                    XtraMessageBox.Show("您系统中未安装支持此类文件的应用程序", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region public static void DataPrint(IPrintable paramPrintObject,string paramTarget,Form ClosedForm) 数据导出
        /// <summary>
        /// 将GridControl中的数据导出
        /// </summary>
        /// <param name="paramPrintObject">要打印的对象</param>
        /// <param name="paramTarget">打印操作对象描述：如系统日志</param>
        /// <param name="ClosedForm">要关闭的窗体，为null时表示不关闭</param>
        public static void DataPrint(IPrintable paramPrintObject,string paramTarget,Form ClosedForm)
        {
            PrintingSystem tempPrintingSystem = new PrintingSystem();
            PrintableComponentLink tempPCLink = new PrintableComponentLink();
            tempPCLink.Component = paramPrintObject;        //这里可以是可打印的部件
            tempPrintingSystem.Links.Add(tempPCLink);
            PageHeaderFooter tempPHeaderFooter = tempPCLink.PageHeaderFooter as PageHeaderFooter;
            tempPHeaderFooter.Footer.Content.AddRange(new string[]{"CMS(餐饮管理系统)","","打印时间:"+DateTime.Now.ToString()});
            tempPHeaderFooter.Footer.LineAlignment = BrickAlignment.Near;
            tempPHeaderFooter.Header.Content.AddRange(new string[]{"",paramTarget,""});
            tempPHeaderFooter.Header.Font = new System.Drawing.Font("Tahoma", 11, System.Drawing.FontStyle.Bold);
            tempPHeaderFooter.Header.LineAlignment = BrickAlignment.Center;
            tempPCLink.CreateDocument();                    //建立打印文档
            tempPrintingSystem.PreviewRibbonFormEx.Show();
            BUT_SysLog.InsertSysLog(VariedEnum.LogType.数据操作, frmAssist.frmLogin.SysUser.UserID,
                        "成功打印了" + paramTarget);
            if (ClosedForm != null)
                ClosedForm.Close();
        }
        #endregion
    }
}
