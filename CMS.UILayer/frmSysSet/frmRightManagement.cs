
//******************************************************************************************************
//** Copyright (C) 2010-2013 重大网络教育学院
//** 创建人：桂书丛
//** 类名称\文件名：frmRightManagement
//** 类功能：系统权限设置
//** 描 述：对登录系统的用户的权限进行设置
//** 创建日期：2013-1-22
//** 修改人：桂书丛
//** 修改日期：2013-1-22
//******************************************************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using CMS.BULayer;
using CMS.Model;
using System.Data.SqlClient;
namespace CMS.UILayer.frmSysSet
{
    /// <summary>
    /// 系统权限设置
    /// </summary>
    /// 创建人：桂书丛
    /// 创建日期：2013-02-23
    public partial class frmRightManagement : DevExpress.XtraEditors.XtraForm
    {          
        private BUT_Right myBURight = new BUT_Right();
        private BUT_Right_Module_Map myBUT_Right_Module_Map = new BUT_Right_Module_Map();
        private int RightID = -5;
        private bool IsFirst = true;                    //此窗体是第一次加载


        /// <summary>
        /// Initializes a new instance of the <see cref="frmRightManagement"/> class.
        /// </summary>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-23
        public frmRightManagement()
        {
            InitializeComponent();
            InitializeControls();
        }

        /// <summary>
        /// 初始化控件数据
        /// </summary>
        private void InitializeControls()
        {
            InitializeDate();
            LoadModuleTree();
        }

        /// <summary>
        /// 初始化数据主控件数据
        /// </summary>
        private void InitializeDate()
        {
            try
            {
                DataTable tempDataTable = myBURight.GetOrder(false,string.Empty,string.Empty,false);
                this.gridControlRight.DataSource = tempDataTable;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 加载模块树
        /// </summary>
        private void LoadModuleTree()
        {
            try
            {
                string tempRightID = this.gridViewMain.GetFocusedRowCellValue("ID").ToString();
                ClassAssist.DataOperator.BindTreeView(this.tvwModule, myBUT_Right_Module_Map.GetRightModule(tempRightID));
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handles the SelectionChanged event of the gridViewMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.Data.SelectionChangedEventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-23
        private void gridViewMain_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            this.RightID = Convert.ToInt32(this.gridViewMain.GetFocusedRowCellValue("ID"));
            ReBindingTreeView();
        }

        /// <summary>
        /// 重新绑定权限树:主要对有的打勾
        /// </summary>
        private void ReBindingTreeView()
        {
            try
            {
                string tempRightID = this.gridViewMain.GetFocusedRowCellValue("ID").ToString();
                DataTable tempDataTable = myBUT_Right_Module_Map.GetRightModule(tempRightID);
                ClassAssist.DataOperator.OperatorTree(this.tvwModule, tempDataTable);
                GetModuleNum();               
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        #region private void GetModuleNum() 得到当前权限拥有的模块数
        /// <summary>
        /// 得到当前权限拥有的模块数
        /// </summary>
        private void GetModuleNum()
        {
            int tempModuleNum = ClassAssist.DataOperator.GetCheckedTreeNodeNum(this.tvwModule,0);
            if (this.IsFirst == true)
            {
                tempModuleNum = 42;
                this.IsFirst = false;
            }
            this.lblModuleNum.Text = "此权限可访问共："+tempModuleNum.ToString()+"个模块";
        }
        #endregion

        /// <summary>
        /// Handles the AfterCheck event of the tvwModule control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.TreeViewEventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-23
        private void tvwModule_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action == TreeViewAction.ByMouse)
            {
                SetChildrenNodeChecked(e.Node, e.Node.Checked);
                if (e.Node.Parent != null)
                {
                    SetParentNodeChecked(e.Node, e.Node.Checked);
                }
                GetModuleNum();
            }
        }

        /// <summary>
        /// 设置子节点选中状态
        /// </summary>
        /// <param name="CurrNode"></param>
        /// <param name="state"></param>
        private void SetChildrenNodeChecked(TreeNode CurrNode, bool state)
        {
            TreeNodeCollection nodes = CurrNode.Nodes;
            if (nodes.Count > 0)
            {
                foreach (TreeNode tn in nodes)
                {
                    tn.Checked = state;
                    SetChildrenNodeChecked(tn, state);
                }
            }
        }

        /// <summary>
        /// 设置父节点选中状态
        /// </summary>
        /// <param name="CurrNode"></param>
        /// <param name="state"></param>
        private void SetParentNodeChecked(TreeNode CurrNode, bool state)
        {
            TreeNode parentNode = CurrNode.Parent;
            parentNode.Checked = state;
            if (!state)
            {
                foreach (TreeNode myNode in parentNode.Nodes)
                {
                    if (CurrNode == myNode)
                    {
                        continue;
                    }
                    if (myNode.Checked)
                    {
                        parentNode.Checked = true;
                        break;
                    }
                }
                if (CurrNode.Parent.Parent != null)
                {
                    SetParentNodeChecked(CurrNode.Parent, state);
                }
            }
        }

        /// <summary>
        /// Handles the AfterSelect event of the tvwModule control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.TreeViewEventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-23
        private void tvwModule_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name == string.Empty)
                return;
            try
            {
                string tempID = e.Node.Name;
                DataTable tempDataTable = new BUT_Module().GetOrder(false,"ID",tempID,false);
                FillModuleInfo(tempDataTable);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 动态填充模块信息
        /// </summary>
        /// <param name="paramSqlDataReader"></param>
        private void FillModuleInfo(DataTable paramDataTable)
        {
            if (paramDataTable.Rows.Count <= 0)
                return;
            foreach(DataRow tempDataRow in paramDataTable.Rows)
            {
                this.txtName.Text = tempDataRow["FULLNAME"].ToString();
                this.txtHref.Text = tempDataRow["HREF"].ToString();
                this.meDesc.Text = tempDataRow["DESCRIPTION"].ToString();
            }
        }

        /// <summary>
        /// Handles the Click event of the btnBack control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-23
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the btnDel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-23
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (this.gridViewMain.SelectedRowsCount <= 0)
            {
                XtraMessageBox.Show("请先选择要删除的项", "操作违规",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string tempID = this.gridViewMain.GetFocusedRowCellValue("ID").ToString();
            DialogResult tempDialogResult = XtraMessageBox.Show("编号为：" + tempID + "的权限","确定删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == tempDialogResult)
            {
                VariedEnum.OperatorStatus EnOperatorStatus;
                try
                {
                    EnOperatorStatus = myBURight.Delete(tempID);           //删除注册权限
                    if (EnOperatorStatus == VariedEnum.OperatorStatus.Successed) //如果注册权限删除成功在删除关系映射
                        EnOperatorStatus = myBUT_Right_Module_Map.Delete(tempID);
                    if (ClassAssist.CommonOperator.HandleOperatorEnum("权限信息删除", EnOperatorStatus))
                    {
                        BUT_SysLog.InsertSysLog(VariedEnum.LogType.系统事件, frmAssist.frmLogin.SysUser.UserID,"成功删除了编号为" + this.RightID.ToString() + "的权限信息");
                        InitializeDate();
                    }
                }
                catch
                {
                    XtraMessageBox.Show("请确定此条数据未被使用后重试","删除失败",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the btnAdd control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-23
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Random myRandom = new Random();
            this.RightID = myRandom.Next(0, 32767);
            ClassAssist.DataOperator.OperatorTree(this.tvwModule,null);
            frmRightAdd myfrmRightAdd = new frmRightAdd(this.RightID);
            if (myfrmRightAdd.ShowDialog() == DialogResult.OK)
                InitializeDate();
        }

        /// <summary>
        /// Handles the Click event of the btnSave control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-23
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                myBUT_Right_Module_Map.Delete(this.RightID.ToString());
                if (InsertRightModuleMap(this.RightID)==true)
                {
                    XtraMessageBox.Show("模块信息保存成功", "恭喜");
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Right");
            }
        }

        /// <summary>
        /// 向权限表中插入用户所选权限
        /// </summary>
        /// <param name="paramPowID"></param>
        /// <returns></returns>
        private bool InsertRightModuleMap(int paramRightID)
        {
            string CreatePerson = frmAssist.frmLogin.SysUser.UserName;
            try
            {
                foreach (TreeNode myTreeNode in this.tvwModule.Nodes)
                {
                    if (myTreeNode.Checked == true)
                    {
                        int tempModuleID = Convert.ToInt32(myTreeNode.Name);
                        myBUT_Right_Module_Map.Insert(paramRightID, tempModuleID, CreatePerson);
                        foreach (TreeNode myNode in myTreeNode.Nodes)
                        {
                            if (myNode.Checked == true)
                            {
                                int ModuleID = Convert.ToInt32(myNode.Name);
                                myBUT_Right_Module_Map.Insert(paramRightID, ModuleID, CreatePerson);
                            }
                        }
                    }
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Handles the DoubleClick event of the gridControlRight control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-23
        private void gridControlRight_DoubleClick(object sender, EventArgs e)
        {
            btnUpdate_Click(sender,e);
        }

        /// <summary>
        /// Handles the Click event of the btnUpdate control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-23
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.gridViewMain.SelectedRowsCount <= 0)
            {
                XtraMessageBox.Show("请先选择要修改的项", "操作违规",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            object[] tempInfo = ClassAssist.CommonOperator.GetGVSelectRowInfo(this.gridViewMain);
            if (tempInfo != null)
            {
                frmRightAdd myfrmRightAdd = new frmRightAdd(tempInfo);
                if (myfrmRightAdd.ShowDialog() == DialogResult.OK)
                    InitializeDate();
            }
        }
    }
}