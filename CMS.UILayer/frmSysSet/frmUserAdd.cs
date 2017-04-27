
//******************************************************************************************************
//** Copyright (C) 2010-2013 重大网络教育学院
//** 创建人：桂书丛
//** 类名称\文件名：frmUserAdd
//** 类功能：用户信息操作窗体
//** 描 述：餐饮管理系统用户信息操作窗体
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
using CMS.Model;
namespace CMS.UILayer.frmSysSet
{
    public partial class frmUserAdd : DevExpress.XtraEditors.XtraForm
    {
        private int UserID = -100;                  //暂时存储用户ID
        private BUT_User myBUUser = new BUT_User();     //用户信息操作逻辑
        private int UserRightID = -5;               //用户的权限编号

        public frmUserAdd()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 重载构造函数:用于修改用户信息
        /// </summary>
        /// <param name="paramInfo">用户信息</param>
        public frmUserAdd(object[] paramInfo)
        {
            InitializeComponent();
            this.btnSave.Click -= this.btnSave_Click;
            this.btnSave.Click += this.btnSaveUpdate_Click;
            this.Text = "修改用户信息";
            this.lblPerson.Text = "修改人：";
            this.lblDate.Text = "修改时间：";
            FillInfo(paramInfo);
        }

        /// <summary>
        /// 将传递过来的数据给指定的控件
        /// </summary>
        /// <param name="paramInfo">用户信息</param>
        private void FillInfo(object[] paramInfo)
        {
            try
            {
                BUT_User tempBUUser = new BUT_User();
                UserID = Convert.ToInt32(paramInfo[0]);
                this.txtUserName.Text = paramInfo[1].ToString();
                this.txtUserPwd.Text = tempBUUser.GetUserPWD(UserID);
                this.UserRightID = tempBUUser.GetUserRightID(paramInfo[1].ToString(), this.txtUserPwd.Text);
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message,"mmm");
            }
        }

        #region private void InitializeControls() 自定义方法：绑定控件
        /// <summary>
        /// 自定义方法：绑定控件
        /// </summary>
        private void InitializeControls()
        {
            DataTable tempDataTable = new BUT_Right().GetOrder(false,string.Empty,string.Empty,false);
            if (tempDataTable != null)
            {
                ClassAssist.CommonOperator.DataBindingLookUpEdit(this.lookUpEditRight,tempDataTable,"NAME","ID",true);
                if (this.UserRightID != -5)
                    this.lookUpEditRight.EditValue = this.UserRightID;
            }
        }
        #endregion

        #region private bool CheckInput() 自定义方法：检测用户输入
        /// <summary>
        /// 自定义方法：检测用户输入
        /// </summary>
        /// <returns></returns>
        private bool CheckInput()
        {
            string UserName = this.txtUserName.Text.Trim();
            string UserPWD = this.txtUserPwd.Text.Trim();
            string RePWD = this.txtRePwd.Text.Trim();
            if (UserName == string.Empty)
            {
                XtraMessageBox.Show("请输入新用户名称","信息输入不完整",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                this.txtUserName.Focus();
                return false;
            }
            if (UserPWD == string.Empty)
            {
                XtraMessageBox.Show("请输入新用户密码", "信息输入不完整",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtUserPwd.Focus();
                return false;
            }
            if (RePWD == string.Empty)
            {
                XtraMessageBox.Show("请再次输入用户密码", "信息输入不完整",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtRePwd.Focus();
                return false;
            }
            if (UserPWD!=RePWD)
            {
                XtraMessageBox.Show("两次输入的密码不一致", "信息输入错误",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtRePwd.Focus();
                this.txtRePwd.SelectAll();
                return false;
            }
            return true;
        }
        #endregion

        #region private ModelT_User GetUserModel() 得到用户信息实体
        /// <summary>
        /// 得到用户信息实体
        /// </summary>
        /// <returns></returns>
        private ModelT_User GetUserModel()
        {
            ModelT_User myModelT_User=new ModelT_User();
            try
            {
                myModelT_User.ID = this.UserID;
                myModelT_User.UserName = this.txtUserName.Text.Trim();
                myModelT_User.UserPWD = this.txtRePwd.Text.Trim();
                myModelT_User.UserRightID = Convert.ToInt32(this.lookUpEditRight.EditValue);
                myModelT_User.CreatePerson=myModelT_User.ModifyPerson = this.txtCreatePerson.Text.Trim();
                myModelT_User.CreateDate=myModelT_User.ModifyDate = Convert.ToDateTime(this.txtCreateDate.Text.Trim());
                return myModelT_User;
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }
        #endregion

        /// <summary>
        /// "保存"按钮点击事件住用于添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
                return;
            VariedEnum.OperatorStatus EnOperatorStatus;
            try
            {
                EnOperatorStatus = myBUUser.AddUserInfo(GetUserModel());
                if (ClassAssist.CommonOperator.HandleOperatorEnum("用户信息添加", EnOperatorStatus))
                {
                    BUT_SysLog.InsertSysLog(VariedEnum.LogType.系统事件, frmAssist.frmLogin.SysUser.UserID,"成功添加了一条系统用户信息");
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// "保存"按钮点击事件住用于修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
                return;
             VariedEnum.OperatorStatus EnOperatorStatus;
            try
            {
                EnOperatorStatus = myBUUser.UpdateUserInfo(GetUserModel());
                if (ClassAssist.CommonOperator.HandleOperatorEnum("用户信息修改", EnOperatorStatus))
                {
                    BUT_SysLog.InsertSysLog(VariedEnum.LogType.系统事件, frmAssist.frmLogin.SysUser.UserID,"成功修改了一条系统用户信息");
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
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
        /// Handles the Click event of the btnCancel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-06
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.txtUserPwd.Text = string.Empty;
            this.txtUserName.Text = string.Empty;
            this.txtRePwd.Text = string.Empty;
        }

        /// <summary>
        /// Handles the Load event of the frmUserAdd control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-06
        private void frmUserAdd_Load(object sender, EventArgs e)
        {
            InitializeControls();
            this.txtCreateDate.Text = DateTime.Now.ToString();
            this.txtCreatePerson.Text = frmAssist.frmLogin.SysUser.UserName;
        }
    }
}