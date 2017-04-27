
//******************************************************************************************************
//** Copyright (C) 2010-2013 重大网络教育学院
//** 创建人：桂书丛
//** 类名称\文件名：frmRightAdd
//** 类功能：系统权限添加(&A)
//** 描 述：对登录系统的用户的权限进行添加(&A)
//** 创建日期：2013-1-23
//** 修改人：桂书丛
//** 修改日期：2013-1-23
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
    public partial class frmRightAdd : DevExpress.XtraEditors.XtraForm
    {
        private BUT_Right myBURight = new BUT_Right();
        private int RightID = -5;                       //权限ID

        public frmRightAdd(int paramRightID)
        {
            InitializeComponent();
            this.RightID = paramRightID;
            this.txtPerson.Text = frmAssist.frmLogin.SysUser.UserName;
            this.txtDate.Text = DateTime.Now.ToString();
        }

        /// <summary>
        /// 重载构造函数:用于修改用户信息
        /// </summary>
        /// <param name="paramInfo">用户信息</param>
        public frmRightAdd(object[] paramInfo)
        {
            InitializeComponent();
            this.btnSave.Click -= this.btnSave_Click;
            this.btnSave.Click += this.btnSaveUpdate_Click;
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
                this.RightID = Convert.ToInt32(paramInfo[0]);
                this.txtName.Text = paramInfo[1].ToString();
                this.txtPerson.Text = frmAssist.frmLogin.SysUser.UserName;
                this.txtDate.Text = DateTime.Now.ToString();
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        #region private bool CheckInput() 自定义方法：检测用户输入
        /// <summary>
        /// 自定义方法：检测用户输入
        /// </summary>
        /// <returns></returns>
        private bool CheckInput()
        {
            string RightName = this.txtName.Text.Trim();
            if (RightName.Length == 0)
            {
                XtraMessageBox.Show("请输入新系统权限名称", "信息输入不完整",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtName.Focus();
                return false;
            }
            return true;
        }
        #endregion

        #region private ModelT_Right GetRightModel() 得到权限信息实体
        /// <summary>
        /// 得到权限信息实体
        /// </summary>
        /// <returns></returns>
        private ModelT_Right GetRightModel()
        {
            ModelT_Right myModelT_Right = new ModelT_Right();
            try
            {
                myModelT_Right.ID = this.RightID;
                myModelT_Right.Name = this.txtName.Text.Trim();
                myModelT_Right.CreatePerson = myModelT_Right.ModifyPerson = frmAssist.frmLogin.SysUser.UserName;
                myModelT_Right.CreateDate = myModelT_Right.ModifyDate = DateTime.Now;
                return myModelT_Right;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        /// <summary>
        /// Handles the Click event of the btnSaveUpdate control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-06
        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
                return;
            VariedEnum.OperatorStatus EnOperatorStatus;
            try
            {
                EnOperatorStatus = myBURight.Update(GetRightModel());
                if (ClassAssist.CommonOperator.HandleOperatorEnum("权限信息修改", EnOperatorStatus))
                {
                    BUT_SysLog.InsertSysLog(VariedEnum.LogType.系统事件, frmAssist.frmLogin.SysUser.UserID,"成功修改了编号为" + this.RightID.ToString() + "的权限信息");
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Update");
            }
        }

        /// <summary>
        /// Handles the Click event of the btnSave control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-06
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
                return;
            VariedEnum.OperatorStatus EnOperatorStatus;
            try
            {
                EnOperatorStatus = myBURight.Insert(GetRightModel());
                if (ClassAssist.CommonOperator.HandleOperatorEnum("权限信息添加(&A)", EnOperatorStatus))
                {
                    BUT_SysLog.InsertSysLog(VariedEnum.LogType.系统事件, frmAssist.frmLogin.SysUser.UserID,"成功添加(&A)了一条的权限信息");
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Add");
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
            this.DialogResult = DialogResult.Cancel;
        }
    }
}