
//******************************************************************************************************
//** Copyright (C) 2010-2013 重大网络教育学院
//** 创建人：桂书丛
//** 类名称\文件名：frmUserManagement
//** 类功能：用户管理窗体
//** 描 述：餐饮管理系统用户管理窗体
//** 创建日期：2013-1-15
//** 修改人：桂书丛
//** 修改日期：2013-1-15
//** 整理日期：2013-1-15
//******************************************************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using CMS.Model;
using CMS.BULayer;
namespace CMS.UILayer.frmSysSet
{
    public partial class frmUserManagement : DevExpress.XtraEditors.XtraForm
    {
        private BUT_User myBUUser = new BUT_User();

        /// <summary>
        /// Initializes a new instance of the <see cref="frmUserManagement"/> class.
        /// </summary>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-06
        public frmUserManagement()
        {
            InitializeComponent();
            InitializeControls();
        }

        #region private void InitializeControls() 初始化控件
        /// <summary>
        /// 初始化控件
        /// </summary>
        private void InitializeControls()
        {
            DataTable myDataTable = new DataTable();
            try
            {
                myDataTable = myBUUser.GetAllUserInfo();
                this.gridControlUser.DataSource = myDataTable;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmSysSet.frmUserAdd myfrmUserAdd = new frmUserAdd();
            if (myfrmUserAdd.ShowDialog() == DialogResult.OK)
                InitializeControls();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (this.gridViewMain.SelectedRowsCount <= 0)
            {
                XtraMessageBox.Show("请先选择要删除的项", "操作违规",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string tempID=this.gridViewMain.GetFocusedRowCellValue("ID").ToString();
            DialogResult tempDialogResult = XtraMessageBox.Show("编号为："+ tempID + "的用户","确定删除？",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (DialogResult.Yes == tempDialogResult)
            {
                VariedEnum.OperatorStatus EnOperatorStatus;
                try
                {
                    EnOperatorStatus = myBUUser.DeleteUser(tempID);
                    if (ClassAssist.CommonOperator.HandleOperatorEnum("删除", EnOperatorStatus))
                    {
                        BUT_SysLog.InsertSysLog(VariedEnum.LogType.系统事件, frmAssist.frmLogin.SysUser.UserID,"成功删除了编号为："+tempID+"的系统用户信息");
                        InitializeControls();
                    }
                }
                catch
                {
                    XtraMessageBox.Show("请确定此条数据不正在被使用后重试", "删除失败",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                if (new frmCertainPWD(Convert.ToInt32(tempInfo[0])).ShowDialog() != DialogResult.OK)
                    return;
                frmUserAdd myfrmUserAdd = new frmUserAdd(tempInfo);
                if (myfrmUserAdd.ShowDialog() == DialogResult.OK)
                    InitializeControls();
            }
        }

        /// <summary>
        /// Handles the DoubleClick event of the gridControlUser control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-06
        private void gridControlUser_DoubleClick(object sender, EventArgs e)
        {
            btnUpdate_Click(sender,e);
        }

        /// <summary>
        /// Handles the Click event of the btnBack control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-06
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the btnOut control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-06
        private void btnOut_Click(object sender, EventArgs e)
        {
            try
            {
                ClassAssist.DataOperator.DataOut(this.gridViewMain, "系统用户信息");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the btnPrint control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-06
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                ClassAssist.DataOperator.DataPrint(this.gridControlUser,"系统用户信息",null);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handles the KeyDown event of the gridControlUser control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.KeyEventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-06
        private void gridControlUser_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                btnUpdate_Click(sender, e);
        }
    }
}