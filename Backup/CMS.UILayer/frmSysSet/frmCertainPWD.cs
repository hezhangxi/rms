
//******************************************************************************************************
//** Copyright (C) 2010-2013 重大网络教育学院
//** 创建人：桂书丛
//** 类名称\文件名：frmCertainPWD
//** 类功能：密码确定窗体
//** 描 述：餐饮管理系统密码确定窗体
//** 创建日期：2013-1-20
//** 修改人：桂书丛
//** 修改日期：2013-1-20
//** 整理日期：2013-1-20
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
namespace CMS.UILayer.frmSysSet
{
    public partial class frmCertainPWD : DevExpress.XtraEditors.XtraForm
    {
        private int UserID = -5;                    //用户ID
        private string UserPWD = string.Empty;      //用户密码

        /// <summary>
        /// Initializes a new instance of the <see cref="frmCertainPWD"/> class.
        /// </summary>
        /// <param name="paramUserID">The param user ID.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-06
        public frmCertainPWD(int paramUserID)
        {
            InitializeComponent();
            this.UserID = paramUserID;
        }

        /// <summary>
        /// Handles the Load event of the frmCertainPWD control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-06
        private void frmCertainPWD_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.UserID != -5)
                    UserPWD = new BUT_User().GetUserPWD(this.UserID);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the btnOK control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-06
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.txtUserPWD.Text.Length == 0)
            {
                XtraMessageBox.Show("请输入此用户密码","操作违规",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            if (this.txtUserPWD.Text != this.UserPWD)
            {
                XtraMessageBox.Show("密码输入错误","拒绝修改",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                this.txtUserPWD.Focus();
                this.txtUserPWD.SelectAll();
                return;
            }
            if (this.txtUserPWD.Text == this.UserPWD)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}