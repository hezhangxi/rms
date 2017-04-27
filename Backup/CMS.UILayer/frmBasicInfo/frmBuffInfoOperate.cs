using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using CMS.Model;
using CMS.BULayer;
using DevExpress.XtraEditors;

namespace CMS.UILayer.frmBasicInfo
{
    public partial class frmBuffInfoOperate : DevExpress.XtraEditors.XtraForm
    {
        #region 变量定义
        BUCMS_Buffets myBUCMS_Buffets = new BUCMS_Buffets();
        BUCMS_RoomType myBUCMS_RoomType = new BUCMS_RoomType();
        BUCMS_Equipment myBUCMS_Equipment = new BUCMS_Equipment();
        BUCMS_ItemDetail myBUCMS_ItemDetail = new BUCMS_ItemDetail();
        int ItemID = -5;
        #endregion

        #region public frmBuffInfoOperate() 构造函数
        /// <summary>
        /// 构造函数 <see cref="frmBuffInfoOperate"/> class.
        /// </summary>
        /// <remarks></remarks>
        public frmBuffInfoOperate()
        {
            InitializeComponent();
            this.lblFloor.Visible = false;
            this.txtFloor.Visible = false;
            this.txtPerson.Text = frmAssist.frmLogin.SysUser.UserName;
            this.txtDate.Text = DateTime.Now.ToString();
        }
        #endregion

        #region public frmBuffInfoOperate(object[] paramInfo) 重载构造函数
        /// <summary>
        /// 重载构造函数 <see cref="frmBuffInfoOperate"/> 
        /// </summary>
        /// <param name="paramInfo">The param info.</param>
        /// <remarks></remarks>
        public frmBuffInfoOperate(object[] paramInfo)
        {
            InitializeComponent();
            this.lblPerson.Text = "修改人";
            this.lblDate.Text = "修改时间";
            this.txtPerson.Text = frmAssist.frmLogin.SysUser.UserName;
            this.txtDate.Text = DateTime.Now.ToString();
            FillBuffInfo(paramInfo);
            this.btnSave.Click -= this.btnSave_Click;
            this.btnSave.Click += this.btnRSave_Click;
        }
        #endregion

        #region private void FillBuffInfo(object[] paramInfo) 餐台信息填充
        /// <summary>
        /// 餐台信息填充
        /// </summary>
        /// <param name="paramInfo">The param info.</param>
        /// <remarks></remarks>
        private void FillBuffInfo(object[] paramInfo)
        {
            ItemID = Convert.ToInt32(paramInfo[0]);
            this.txtName.Text = paramInfo[1].ToString();
            this.spinEditPeopleContain.Text = paramInfo[2].ToString();
            this.txtFloor.Text = paramInfo[4].ToString();
            this.EditRoomTypeID.EditValue = paramInfo[18];
            this.txtInfoNote.Text = paramInfo[6].ToString();
            this.txtPerson.Text = frmAssist.frmLogin.SysUser.UserName;
            this.txtDate.Text = DateTime.Now.ToString();
        }
        #endregion

        #region private bool CheckInput() 检查是否输入餐台名称
        /// <summary>
        /// 检查是否输入餐台名称
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        private bool CheckInput()
        {
            string Name = this.txtName.Text.Trim();
            if (Name.Length == 0)
            {
                XtraMessageBox.Show("请输入新餐台名称", "信息输入不完整",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtName.Focus();
                return false;
            }
            return true;
        }
        #endregion

        #region private ModelCMS_Buffets GetModel() 使用实体类传递参数
        /// <summary>
        /// 使用实体类传递参数
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        private ModelCMS_Buffets GetModel()
        {
            try
            {
                ModelCMS_Buffets tempModelCMS_Buffets = new ModelCMS_Buffets();
                tempModelCMS_Buffets.ID = this.ItemID;
                tempModelCMS_Buffets.Name = this.txtName.Text.Trim().ToString();
                tempModelCMS_Buffets.AccommodateNum = Convert.ToInt32(this.spinEditPeopleContain.EditValue);
                tempModelCMS_Buffets.RoomTypeID = Convert.ToInt32(this.EditRoomTypeID.EditValue);
                tempModelCMS_Buffets.StateID = Convert.ToInt32(VariedEnum.BuffetStatus.空闲);
                tempModelCMS_Buffets.InfoNote = this.txtInfoNote.Text.Trim();
                tempModelCMS_Buffets.CreateDate = tempModelCMS_Buffets.ModifyDate = DateTime.Now;
                tempModelCMS_Buffets.CreatePerson = tempModelCMS_Buffets.ModifyPerson = frmAssist.frmLogin.SysUser.UserName;
                return tempModelCMS_Buffets;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            return null;
        }
        #endregion


        #region btnSave_Click 餐台信息操作中添加保存按钮的单击事件
        /// <summary>
        /// 餐台信息操作中添加后保存按钮的单击事件
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
                return;
            VariedEnum.OperatorStatus EnOperatorStatus;
            try
            {
                EnOperatorStatus = myBUCMS_Buffets.Insert(GetModel());
                if (ClassAssist.CommonOperator.HandleOperatorEnum("餐台信息添加", EnOperatorStatus))
                {
                    BUT_SysLog.InsertSysLog(VariedEnum.LogType.数据操作, frmAssist.frmLogin.SysUser.UserID,
                        "成功添加了一条餐台信息");
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region btnRSave_Click 餐台信息管理中修改后保存按钮的单击事件
        /// <summary>
        /// 餐台信息管理中修改后保存按钮的单击事件
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnRSave_Click(object sender, EventArgs e)
        {
            VariedEnum.OperatorStatus EnOperatorStatus;
            try
            {
                EnOperatorStatus = myBUCMS_Buffets.Update(GetModel());
                if (ClassAssist.CommonOperator.HandleOperatorEnum("餐台信息修改", EnOperatorStatus))
                {
                    BUT_SysLog.InsertSysLog(VariedEnum.LogType.数据操作, frmAssist.frmLogin.SysUser.UserID,
                        "成功修改了一条餐台信息");
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        #endregion
        }

        #region btnCancel_Click 取消按钮的单击事件
        /// <summary>
        /// 取消按钮的单击事件
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region btnBack_Click 返回按钮的单击事件
        /// <summary>
        /// 返回按钮的单击事件
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region frmBuffInfoOperate_Load 窗体的Load事件
        /// <summary>
        /// 窗体的Load事件
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void frmBuffInfoOperate_Load(object sender, EventArgs e)
        {
            BindLookUpEdit();
        }
        #endregion

        #region Binds the look up edit.
        /// <summary>
        /// Binds the look up edit.
        /// </summary>
        /// <remarks></remarks>
        private void BindLookUpEdit()
        {
            DataTable myDT = myBUCMS_RoomType.GetOrder(true, string.Empty, string.Empty, false);
            this.EditRoomTypeID.Properties.DataSource = myDT;
            if (ItemID.Equals(-5))
            {
                this.EditRoomTypeID.ItemIndex = 0;
            }
            else
            {
                return;
            }
        }
        #endregion
    }
}
