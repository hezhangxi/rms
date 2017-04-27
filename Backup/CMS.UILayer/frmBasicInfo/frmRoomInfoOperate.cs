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

namespace CMS.UILayer.frmBasicInfo
{
    public partial class frmRoomInfoOperate : DevExpress.XtraEditors.XtraForm
    {
        #region 变量定义
        BUCMS_RoomType myBUCMS_RoomType = new BUCMS_RoomType();
        ModelCMS_RoomType myModelCMS_RoomType = new ModelCMS_RoomType();
        BUCMS_ItemDetail myBUCMS_ItemDetail = new BUCMS_ItemDetail();
        BUCMS_Equipment myBUCMS_Equipment = new BUCMS_Equipment();
        private object[] tempInfo;
        int ItemID = -5;
        #endregion

        public frmRoomInfoOperate()
        {
            InitializeComponent();
            this.txtPerson.Text = frmAssist.frmLogin.SysUser.UserName;
            this.txtDate.Text = DateTime.Now.ToString();
        }

         #region public frmBuffInfoOperate() 重载构造函数
        /// <summary>
        /// 重载构造函数 <see cref="frmBuffInfoOperate"/> class.
        /// </summary>
        /// <remarks></remarks>
        public frmRoomInfoOperate(object[] paramInfo)
        {
            InitializeComponent();
            this.lblPerson.Text = "修改人";
            this.lblDate.Text = "修改时间";
            this.txtPerson.Text = frmAssist.frmLogin.SysUser.UserName;
            this.txtDate.Text = DateTime.Now.ToString();
            //BindLookUpEdit();
            this.tempInfo = paramInfo;
            FillInfo(paramInfo);
            this.btnSave.Click -= this.btnSave_Click;
            this.btnSave.Click += this.btnRSave_Click;
        }
        #endregion

        #region private void FillRoomInfo(object[] paramInfo) 包厢信息填充
        /// <summary>
        /// 包厢信息填充
        /// </summary>
        /// <param name="paramInfo">The param info.</param>
        /// <remarks></remarks>
        private void FillInfo(object[] paramInfo)
        {
            ItemID = Convert.ToInt32(paramInfo[0]);
            this.txtName.Text = paramInfo[1].ToString();
            this.EditEquipmentID.EditValue = paramInfo[14].ToString();
            this.EditFloorID.EditValue = paramInfo[13];
            this.txtInfoNote.Text = paramInfo[3].ToString();
            this.txtPerson.Text = frmAssist.frmLogin.SysUser.UserName;
            this.txtDate.Text = DateTime.Now.ToString();
        }
        #endregion

        #region private bool CheckInput() 检查是否输入包厢名称
        /// <summary>
        /// 检查是否输入包厢名称
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        private bool CheckInput()
        {
            string Name = this.txtName.Text.Trim();
            if (Name.Length == 0)
            {
                XtraMessageBox.Show("请输入新包厢名称", "信息输入不完整",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtName.Focus();
                return false;
            }
            return true;
        }
        #endregion

        #region private ModelCMS_Buffets RGetModel() 使用实体类传递参数
        /// <summary>
        /// 使用实体类传递参数
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        private ModelCMS_RoomType GetModel()
        {
            try
            {
                ModelCMS_RoomType tempModelCMS_RoomType = new ModelCMS_RoomType();
                tempModelCMS_RoomType.ID = this.ItemID;
                tempModelCMS_RoomType.Name = this.txtName.Text;
                tempModelCMS_RoomType.FloorID = Convert.ToInt32(this.EditFloorID.EditValue);
                tempModelCMS_RoomType.EquipmentID = Convert.ToInt32(this.EditEquipmentID.EditValue);
                tempModelCMS_RoomType.Description = this.txtInfoNote.Text.Trim();
                tempModelCMS_RoomType.CreateDate = tempModelCMS_RoomType.ModifyDate = DateTime.Now;
                tempModelCMS_RoomType.CreatePerson = tempModelCMS_RoomType.ModifyPerson = frmAssist.frmLogin.SysUser.UserName;
                return tempModelCMS_RoomType;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            return null;
        }
        #endregion

        #region btnSave_Click 包厢信息操作中添加后保存按钮的单击事件
        /// <summary>
        /// 包厢信息操作中添加后保存按钮的单击事件
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
                return;
            VariedEnum.OperatorStatus EnOperatorStatus;
            EnOperatorStatus = myBUCMS_RoomType.Insert(GetModel());
            try
            {
                if (ClassAssist.CommonOperator.HandleOperatorEnum("包厢信息添加", EnOperatorStatus))
                {
                    BUT_SysLog.InsertSysLog(VariedEnum.LogType.数据操作, frmAssist.frmLogin.SysUser.UserID,
                        "成功添加了一条包厢信息");
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region btnRSave_Click 包厢信息操作中修改后保存按钮的单击事件
        /// <summary>
        /// 包厢信息操作中修改后保存按钮的单击事件
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnRSave_Click(object sender, EventArgs e)
        {
            VariedEnum.OperatorStatus EnOperatorStatus;
            try
            {
                EnOperatorStatus = myBUCMS_RoomType.Update(GetModel());
                if (ClassAssist.CommonOperator.HandleOperatorEnum("包厢信息修改", EnOperatorStatus))
                {
                    BUT_SysLog.InsertSysLog(VariedEnum.LogType.数据操作, frmAssist.frmLogin.SysUser.UserID,
                        "成功修改了一条包厢信息");
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        #endregion

        //private void BindLookUpEdit()
        //{
        //    DataTable myDT = myBUCMS_ItemDetail.GetItemByType(VariedItemType.RoomFloor);
        //    this.EditFloorID.Properties.DataSource = myDT;
        //    this.EditEquipmentID.Properties.DataSource = myBUCMS_Equipment.GetDataSource();
        //    if (ItemID.Equals(-5))
        //    {
        //        this.EditFloorID.Properties.DataSource = myBUCMS_ItemDetail.GetItemByType(VariedItemType.RoomFloor);
        //        this.EditFloorID.ItemIndex = 0;
        //        this.EditEquipmentID.Properties.DataSource = myBUCMS_Equipment.GetDataSource();
        //        this.EditEquipmentID.ItemIndex = 0;
        //    }
        //}

        private void frmRoomInfoOperate_Load(object sender, EventArgs e)
        {
            if (ItemID.Equals(-5))
            {
                DataTable myDataTable = myBUCMS_ItemDetail.GetItemByType(VariedItemType.RoomFloor);
                ClassAssist.CommonOperator.DataBindingLookUpEdit(EditFloorID, myDataTable, "Name", "ID", true);
                this.EditFloorID.ItemIndex = 0;
                this.EditEquipmentID.Properties.DataSource = myBUCMS_Equipment.GetDataSource();
                this.EditEquipmentID.ItemIndex = 0;
            }
            else
            {
                DataTable myDataTable = myBUCMS_ItemDetail.GetItemByType(VariedItemType.RoomFloor);
                ClassAssist.CommonOperator.DataBindingLookUpEdit(EditFloorID, myDataTable, "Name", "ID", true);
                //this.EditFloorID.Properties.DataSource = myBUCMS_ItemDetail.GetItemByType(VariedItemType.RoomFloor);
                //ClassAssist.CommonOperator.DataBindingLookUpEdit(EditFloorID, myDataTable, "NAME", "ID", true);
                this.EditEquipmentID.Properties.DataSource = myBUCMS_Equipment.GetDataSource();
                FillInfo(this.tempInfo);
            }
        }
    }
}