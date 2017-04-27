//************************************************************************************************
//** Copyright (c) 2013-2013 重大网络教育学院
//** 创建人：桂书丛
//** 类名称\文件名：frmBasicMaintenance
//** 类功能：基本信息维护
//** 描 述：餐饮管理系统基本信息维护
//** 创建日期：2013-2-14
//** 修改人：桂书丛
//** 修改日期：2013-2-14
//** 整理日期：2013-2-14
//************************************************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CMS.BULayer;

namespace CMS.UILayer.frmBasicInfo
{
    public partial class frmBasicMaintenance : DevExpress.XtraEditors.XtraForm
    {
        BUCMS_ItemDetail myBUCMS_ItemDetail = new BUCMS_ItemDetail();
        DataTable myDT = new DataTable();
        int ID = 0;
        object[] tempInfo = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="frmBasicMaintenance"/> class.
        /// </summary>
        /// <remarks></remarks>
        public frmBasicMaintenance()
        {
            InitializeComponent();
            this.tbctrl.SelectedTabPageIndex = 1;
            //InitializeControls();
        }

        /// <summary>
        /// Handles the Load event of the frmBasicMaintenance control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void frmBasicMaintenance_Load(object sender, EventArgs e)
        {
            this.tbctrl.SelectedTabPageIndex = 0;
        }

        #region tbctrl_SelectedPageChanging GridControl中的数据绑定
        /// <summary>
        /// GridControl中的数据绑定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbctrl_SelectedPageChanging(object sender, DevExpress.XtraTab.TabPageChangingEventArgs e)
        {
            try
            {
                string ItemType = e.Page.Tag.ToString();
                DataTable tempDataTable = myBUCMS_ItemDetail.GetItemByType(ItemType);
                foreach (Control tempControl in e.Page.Controls)
                {
                    if (tempControl.GetType() == typeof(DevExpress.XtraGrid.GridControl))
                        ((DevExpress.XtraGrid.GridControl)tempControl).DataSource = tempDataTable;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region private void RefreshData(DevExpress.XtraTab.XtraTabPage paramPage)更新当前页数据
        /// <summary>
        /// 更新当前页数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshData()
        {
            string ItemType = string.Empty;
            try
            {
                DevExpress.XtraTab.XtraTabPage tempTabPage = this.tbctrl.SelectedTabPage;
                if (tempTabPage != null)
                    ItemType = tempTabPage.Tag.ToString();
                DataTable tempDataTable = myBUCMS_ItemDetail.GetItemByType(ItemType);
                foreach (Control tempControl in tempTabPage.Controls)
                {
                    if (tempControl.GetType() == typeof(DevExpress.XtraGrid.GridControl))
                        ((DevExpress.XtraGrid.GridControl)tempControl).DataSource = tempDataTable;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        #endregion



        #region private void LoadDishType() 对grictrlDishType进行数据绑定
        /// <summary>
        /// grictrlDishType绑定数据
        /// </summary>
        private void LoadDishType()
        {
            myDT = myBUCMS_ItemDetail.GetItemByType(VariedItemType.DishType);
            grictrlDishType.DataSource = myDT;
        }
        #endregion


        //***************************添加按钮的单击事件*************************************//

        #region btnDishTypeAdd_Click菜品类别中添加按钮的单击事件
        /// <summary>
        /// 菜品类别中添加按钮的单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDishTypeAdd_Click(object sender, EventArgs e)
        {
            frmPublicOperateArea myfrmPublicOperateArea = new frmPublicOperateArea(VariedEnum.ItemType.DishType);
            if (myfrmPublicOperateArea.ShowDialog() == DialogResult.OK)
                LoadDishType();
        }
        #endregion

        #region btnDishTasteAdd_Click 菜品口味中添加按钮的单击事件
        /// <summary>
        /// 菜品口味中添加按钮的单机事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDishTasteAdd_Click(object sender, EventArgs e)
        {
            frmPublicOperateArea myfrmPublicOperateArea = new frmPublicOperateArea(VariedEnum.ItemType.TasteType);
            if (myfrmPublicOperateArea.ShowDialog() == DialogResult.OK)
                RefreshData();
        }
        #endregion

        #region btnQuitReasonAdd_Click退菜原因中添加按钮的单击事件
        /// <summary>
        /// 退菜原因中添加按钮的单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitReasonAdd_Click(object sender, EventArgs e)
        {
            frmPublicOperateArea myfrmPublicOperateArea = new frmPublicOperateArea(VariedEnum.ItemType.BackResult);
            if (myfrmPublicOperateArea.ShowDialog() == DialogResult.OK)
                RefreshData();
        }
        #endregion

        #region btnWorkStatusAdd_Click 餐台使用状态中添加按钮的单击事件
        /// <summary>
        /// 餐台使用状态中按钮的单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWorkStatusAdd_Click(object sender, EventArgs e)
        {
            frmPublicOperateArea myfrmPublicOperateArea = new frmPublicOperateArea(VariedEnum.ItemType.WorkStatus);
            if (myfrmPublicOperateArea.ShowDialog() == DialogResult.OK)
                RefreshData();
        }
        #endregion

        #region btnRoomFloorAdd_Click 员工工作状态中添加按钮的单击事件
        /// <summary>
        /// 其他设置中按钮的单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRoomFloorAdd_Click(object sender, EventArgs e)
        {
            frmPublicOperateArea myfrmPublicOperateArea = new frmPublicOperateArea(VariedEnum.ItemType.RoomFloor);
            if (myfrmPublicOperateArea.ShowDialog() == DialogResult.OK)
                RefreshData();
        }
        #endregion

        #region btnPayTypeAdd_Click 支付方式中的添加按钮的单击事件
        /// <summary>
        /// 支付方式中的添加按钮的单击事件
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnPayTypeAdd_Click(object sender, EventArgs e)
        {
            frmPublicOperateArea myfrmPublicOperateArea = new frmPublicOperateArea(VariedEnum.ItemType.PayType);
            if (myfrmPublicOperateArea.ShowDialog() == DialogResult.OK)
                RefreshData();
        }
        #endregion



        //***************************删除按钮的单击事件*************************************//


        #region btnDishTypeDele_Click 菜品类别中删除按钮的单击事件
        /// <summary>
        /// 菜品类别中删除按钮的单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDishTypeDele_Click(object sender, EventArgs e)
        {
            if (this.gridViewDishType.SelectedRowsCount <= 0)
            {
                XtraMessageBox.Show("请先选择要删除的项", "操作违规",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string tempID = this.gridViewDishType.GetFocusedRowCellValue("ID").ToString();
            DialogResult tempDialogResult = XtraMessageBox.Show("编号为：" + tempID + "的项目信息",
                "确定删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == tempDialogResult)
            {
                VariedEnum.OperatorStatus EnOperatorStatus;
                try
                {
                    EnOperatorStatus = myBUCMS_ItemDetail.Delete(tempID);
                    if (ClassAssist.CommonOperator.HandleOperatorEnum("删除", EnOperatorStatus))
                    {
                        BUT_SysLog.InsertSysLog(VariedEnum.LogType.系统事件, frmAssist.frmLogin.SysUser.UserID,
                            "成功删除了编号为：" + tempID + "的项目信息");
                        LoadDishType();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("请确定该条数据没用正在使用后重试", "删除失败",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        #endregion

        #region btnDishTasteDele_Click 菜品口味中删除按钮的单击事件
        /// <summary>
        /// 菜品口味中删除按钮的单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDishTasteDele_Click(object sender, EventArgs e)
        {
            if (this.gridViewDishTaste.SelectedRowsCount <= 0)
            {
                XtraMessageBox.Show("请先选择要删除的项", "操作违规",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string tempID = this.gridViewDishTaste.GetFocusedRowCellValue("ID").ToString();
            DialogResult tempDialogResult = XtraMessageBox.Show("编号为：" + tempID + "的项目信息",
                "确定删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == tempDialogResult)
            {
                VariedEnum.OperatorStatus EnOperatorStatus;
                try
                {
                    EnOperatorStatus = myBUCMS_ItemDetail.Delete(tempID);
                    if (ClassAssist.CommonOperator.HandleOperatorEnum("删除", EnOperatorStatus))
                    {
                        BUT_SysLog.InsertSysLog(VariedEnum.LogType.系统事件, frmAssist.frmLogin.SysUser.UserID,
                            "成功删除了编号为：" + tempID + "的项目信息");
                        RefreshData();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("请确定该条数据没用正在使用后重试", "删除失败",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        #endregion

        #region btnQuitReasonDele_Click 退菜原因中删除按钮的单击事件
        /// <summary>
        /// 退菜原因中删除按钮的单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitReasonDele_Click(object sender, EventArgs e)
        {
            if (this.gridViewQuitReason.SelectedRowsCount <= 0)
            {
                XtraMessageBox.Show("请先选择要删除的项", "操作违规",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string tempID = this.gridViewQuitReason.GetFocusedRowCellValue("ID").ToString();
            DialogResult tempDialogResult = XtraMessageBox.Show("编号为：" + tempID + "的项目信息",
                "确定删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == tempDialogResult)
            {
                VariedEnum.OperatorStatus EnOperatorStatus;
                try
                {
                    EnOperatorStatus = myBUCMS_ItemDetail.Delete(tempID);
                    if (ClassAssist.CommonOperator.HandleOperatorEnum("删除", EnOperatorStatus))
                    {
                        BUT_SysLog.InsertSysLog(VariedEnum.LogType.系统事件, frmAssist.frmLogin.SysUser.UserID,
                            "成功删除了编号为：" + tempID + "的项目信息");
                        RefreshData();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("请确定该条数据没用正在使用后重试", "删除失败",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        #endregion

        #region btnWorkStatusDele_Click 工作状态中删除按钮的单击事件
        /// <summary>
        /// 工作状态中删除按钮的单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWorkStatusDele_Click(object sender, EventArgs e)
        {
            if (this.gridViewStaffWorkStatus.SelectedRowsCount <= 0)
            {
                XtraMessageBox.Show("请先选择要删除的项", "操作违规",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string tempID = this.gridViewStaffWorkStatus.GetFocusedRowCellValue("ID").ToString();
            DialogResult tempDialogResult = XtraMessageBox.Show("编号为：" + tempID + "的项目信息",
                "确定删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == tempDialogResult)
            {
                VariedEnum.OperatorStatus EnOperatorStatus;
                try
                {
                    EnOperatorStatus = myBUCMS_ItemDetail.Delete(tempID);
                    if (ClassAssist.CommonOperator.HandleOperatorEnum("删除", EnOperatorStatus))
                    {
                        BUT_SysLog.InsertSysLog(VariedEnum.LogType.系统事件, frmAssist.frmLogin.SysUser.UserID,
                            "成功删除了编号为：" + tempID + "的项目信息");
                        RefreshData();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("请确定该条数据没用正在使用后重试", "删除失败",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        #endregion

        #region btnRoomFloorDele_Click 房间楼层中删除按钮的单击事件
        /// <summary>
        /// 房间楼层中删除按钮的单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRoomFloorDele_Click(object sender, EventArgs e)
        {
            if (this.gridViewRoomFloor.SelectedRowsCount <= 0)
            {
                XtraMessageBox.Show("请先选择要删除的项", "操作违规",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string tempID = this.gridViewRoomFloor.GetFocusedRowCellValue("ID").ToString();
            DialogResult tempDialogResult = XtraMessageBox.Show("编号为：" + tempID + "的项目信息",
                "确定删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == tempDialogResult)
            {
                VariedEnum.OperatorStatus EnOperatorStatus;
                try
                {
                    EnOperatorStatus = myBUCMS_ItemDetail.Delete(tempID);
                    if (ClassAssist.CommonOperator.HandleOperatorEnum("删除", EnOperatorStatus))
                    {
                        BUT_SysLog.InsertSysLog(VariedEnum.LogType.系统事件, frmAssist.frmLogin.SysUser.UserID,
                            "成功删除了编号为：" + tempID + "的项目信息");
                        RefreshData();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("请确定该条数据没用正在使用后重试", "删除失败",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        #endregion

        #region btnPayTypeDele_Click 支付方式中删除按钮的单击事件
        /// <summary>
        /// 支付方式中删除按钮的单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPayTypeDele_Click(object sender, EventArgs e)
        {
            if (this.gridViewPayType.SelectedRowsCount <= 0)
            {
                XtraMessageBox.Show("请先选择要删除的项", "操作违规",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string tempID = this.gridViewPayType.GetFocusedRowCellValue("ID").ToString();
            DialogResult tempDialogResult = XtraMessageBox.Show("编号为：" + tempID + "的项目信息",
                "确定删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == tempDialogResult)
            {
                VariedEnum.OperatorStatus EnOperatorStatus;
                try
                {
                    EnOperatorStatus = myBUCMS_ItemDetail.Delete(tempID);
                    if (ClassAssist.CommonOperator.HandleOperatorEnum("删除", EnOperatorStatus))
                    {
                        BUT_SysLog.InsertSysLog(VariedEnum.LogType.系统事件, frmAssist.frmLogin.SysUser.UserID,
                            "成功删除了编号为：" + tempID + "的项目信息");
                        RefreshData();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("请确定该条数据没用正在使用后重试", "删除失败",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        #endregion




        //***************************修改按钮的单击事件*************************************//

        #region btnDishTypeAlter_Click 菜品类别中修改按钮的单击事件
        /// <summary>
        /// 菜品类别中修改按钮的单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDishTypeAlter_Click(object sender, EventArgs e)
        {
            if (this.gridViewDishType.SelectedRowsCount <= 0)
            {
                XtraMessageBox.Show("请先选择要修改的项", "操作违规",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            tempInfo = ClassAssist.CommonOperator.GetGVSelectRowInfo(this.gridViewDishType);
            if (tempInfo != null)
            {
                frmPublicOperateArea myfrmPublicOperateArea = new frmPublicOperateArea(VariedEnum.ItemType.DishType, tempInfo);
                if (myfrmPublicOperateArea.ShowDialog() == DialogResult.Cancel)
                    RefreshData();
            }
        }

        #endregion

        #region btnDishTasteAlter_Click 菜品口味中修改按钮的单击事件
        /// <summary>
        /// 菜品口味中修改按钮的单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDishTasteAlter_Click(object sender, EventArgs e)
        {
            if (this.gridViewDishTaste.SelectedRowsCount < 0)
                XtraMessageBox.Show("请选择要修改的项", "操作违规",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            tempInfo = ClassAssist.CommonOperator.GetGVSelectRowInfo(this.gridViewDishTaste);
            if (tempInfo != null)
            {
                frmPublicOperateArea myfrmPublicOperateArea = new frmPublicOperateArea(VariedEnum.ItemType.TasteType, tempInfo);
                if (myfrmPublicOperateArea.ShowDialog() == DialogResult.Cancel)
                    RefreshData();
            }

        }

        #endregion

        #region btnQuitReasonAlter_Click 退菜原因中修改按钮的单击事件
        /// <summary>
        /// 菜品退菜原因中修改按钮的单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitReasonAlter_Click(object sender, EventArgs e)
        {
            if (this.gridViewQuitReason.SelectedRowsCount < 0)
            {
                XtraMessageBox.Show("请选择要修改的项", "操作违规",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            tempInfo = ClassAssist.CommonOperator.GetGVSelectRowInfo(this.gridViewQuitReason);
            if (tempInfo != null)
            {
                frmPublicOperateArea myfrmPublicOperateArea = new frmPublicOperateArea(VariedEnum.ItemType.BackResult, tempInfo);
                if (myfrmPublicOperateArea.ShowDialog() == DialogResult.Cancel)
                    RefreshData();
            }
        }

        #endregion

        #region btnWorkStatusAlter_Click 员工工作状态中修改按钮的单击事件
        /// <summary>
        /// 员工工作状态中修改按钮的单击事件
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnWorkStatusAlter_Click(object sender, EventArgs e)
        {
            if (this.gridViewStaffWorkStatus.SelectedRowsCount < 0)
            {
                XtraMessageBox.Show("请选择要修改的项", "操作违规",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            tempInfo = ClassAssist.CommonOperator.GetGVSelectRowInfo(this.gridViewStaffWorkStatus);
            if (tempInfo != null)
            {
                frmPublicOperateArea myfrmPublicOperateArea = new frmPublicOperateArea(VariedEnum.ItemType.WorkStatus, tempInfo);
                if (myfrmPublicOperateArea.ShowDialog() == DialogResult.Cancel)
                    RefreshData();
            }
        }
        #endregion

        #region btnRoomFloorAlter_Click 房间楼层中修改按钮的单击事件
        /// <summary>
        /// 房间楼层中修改按钮的单击事件
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnRoomFloorAlter_Click(object sender, EventArgs e)
        {
            if (this.gridViewRoomFloor.SelectedRowsCount < 0)
            {
                XtraMessageBox.Show("请选择要修改的项", "操作违规",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            tempInfo = ClassAssist.CommonOperator.GetGVSelectRowInfo(this.gridViewRoomFloor);
            if (tempInfo != null)
            {
                frmPublicOperateArea myfrmPublicOperateArea = new frmPublicOperateArea(VariedEnum.ItemType.RoomFloor, tempInfo);
                if (myfrmPublicOperateArea.ShowDialog() == DialogResult.Cancel)
                    RefreshData();
            }
        }
        #endregion

        #region btnPayTypeAlter_Click 支付方式中修改按钮的单击事件
        /// <summary>
        /// 支付方式中修改按钮的单击事件
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnPayTypeAlter_Click(object sender, EventArgs e)
        {
            if (this.gridViewPayType.SelectedRowsCount < 0)
            {
                XtraMessageBox.Show("请选择要修改的项", "操作违规",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            tempInfo = ClassAssist.CommonOperator.GetGVSelectRowInfo(this.gridViewPayType);
            if (tempInfo != null)
            {
                frmPublicOperateArea myfrmPublicOperateArea = new frmPublicOperateArea(VariedEnum.ItemType.PayType, tempInfo);
                if (myfrmPublicOperateArea.ShowDialog() == DialogResult.Cancel)
                    RefreshData();
            }
        }
        #endregion


        //***************************返回按钮的单击事件*************************************//


        #region btnDishTypeBack_Click 菜品类别中返回按钮的单击事件
        /// <summary>
        /// 菜品类别中返回按钮的单击事件
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnDishTypeBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            return;
        }
        #endregion



        //***************************不用的代码*************************************//


        #region private void AlterOtherInstall(string paramOtherInstallNum, string paramOtherInstall)修改其他设置中选中的记录
        /// <summary>
        /// 修改其他设置中选中的记录
        /// </summary>
        /// <param name="paramOtherInstallNum"></param>
        /// <param name="paramOtherInstall"></param>
        private void AlterOtherInstall(string paramOtherInstallNum, string paramOtherInstall)
        {
            int returnValue5 = myBUCMS_ItemDetail.RAlterOtherInstall(paramOtherInstallNum, paramOtherInstall);
            if (returnValue5 > 0)
            {
                MessageBox.Show("修改成功！");
                return;
            }
        }
        #endregion

        #region //private void BindComoboxEdit() 对ComoBoxEdit进行数据绑定
        /// <summary>
        /// 对cmbeDishType数据绑定
        /// </summary>
        //private void BindComoboxEdit()
        //{
        //    myDT = myBUCMS_ItemDetail.GetCMBEInfo();
        //    this.cmbeDishType.Properties.NullText = "请选择…";

        //    for (int i = 0; i < myDT.Rows.Count; i++)
        //    {
        //        if (Convert.ToInt32(myDT.Rows[i]["TypeID"])==1)
        //        {
        //            cmbeDishType.Properties.Items.Add(myDT.Rows[i]["Name"].ToString());
        //        }
        //        else
        //        {
        //            return;
        //        }
        //        switch (Convert.ToInt32(myDT.Rows[i]["TypeID"]))
        //        {
        //            case 1:
        //                cmbeDishType.Properties.Items.Add(myDT.Rows[i]["Name"].ToString());
        //                break;
        //            case 2:
        //                cmbeDishTaste.Properties.Items.Add(myDT.Rows[i]["Name"].ToString());
        //                break;
        //            case 3:
        //                cmbeQuitReason.Properties.Items.Add(myDT.Rows[i]["Name"].ToString());
        //                break;
        //            case 4:
        //                cmbeBuffetState.Properties.Items.Add(myDT.Rows[i]["Name"].ToString());
        //                break;
        //            case 5:
        //                cmbeOtherSetup.Properties.Items.Add(myDT.Rows[i]["Name"].ToString());
        //                break;
        //            default:
        //                return;
        //        }
        //    }
        //}
        #endregion

        #region private void DeleBuffState(string paramBuffStateNum)删除餐台使用状态中选中的记录
        ///// <summary>
        ///// 删除餐台使用状态中选中的记录
        ///// </summary>
        ///// <param name="paramBuffStateNum"></param>
        ///// <param name="paramBuffState"></param>
        //private void DeleBuffState(string paramBuffStateNum)
        //{
        //    int returnValue4 = myBUCMS_ItemDetail.RDeleBuffState(paramBuffStateNum);
        //    if (returnValue4 > 0)
        //    {
        //        MessageBox.Show("删除成功！");
        //        return;
        //    }
        //}
        #endregion

        #region btnBuffStateDele_Click 其他设置中删除按钮的单击事件
        ///// <summary>
        ///// 其他设置中删除按钮的单击事件
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        private void btnOtherInstallDele_Click(object sender, EventArgs e)
        {
            //    string paramOtherInstallNum = this.txtOtherInstallNum.Text.Trim();
            //    if (paramOtherInstallNum.Length == 0)
            //    {
            //        MessageBox.Show("请选择要删除的记录！");
            //    }
            //    else
            //    {
            //        //在这加个窗体，提示确定要删除该条记录吗？否的话取消删除
            //        DeleOtherInstall(paramOtherInstallNum);
            //    }
            //    LoadOtherInstall();
        }
        #endregion

        #region btnBuffStateAlter_Click 餐台使用状态中修改按钮的单击事件
        /// <summary>
        /// 餐台使用状态中修改按钮的单击事件
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnBuffStateAlter_Click(object sender, EventArgs e)
        {
            //    string paramBuffStateNum = this.txtBuffStateNum.Text.Trim();
            //    string paramBuffState = this.txtBuffState.Text.Trim();
            //    if (paramBuffStateNum.Length == 0 || paramBuffState.Length == 0)
            //    {
            //        MessageBox.Show("请选择要修改的记录！");
            //    }
            //    else
            //    {
            //        AlterBuffState(paramBuffStateNum, paramBuffState);
            //    }
            //    LoadBuffState();
        }
        #endregion

        private void btnDishTypeOut_Click(object sender, EventArgs e)
        {
            try
            {
                DevExpress.XtraEditors.SimpleButton tempBtn = (DevExpress.XtraEditors.SimpleButton)sender;
                if (tempBtn == null)
                    return;
                string tempItem = tempBtn.Tag.ToString();
                foreach (Control tempControl in this.tbctrl.SelectedTabPage.Controls)
                {
                    if (tempControl.GetType() == typeof(DevExpress.XtraGrid.GridControl))
                    {
                        DevExpress.XtraGrid.GridControl tempGridControl = (DevExpress.XtraGrid.GridControl)tempControl;
                        DevExpress.XtraGrid.Views.Grid.GridView tempGrid = tempGridControl.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
                        ClassAssist.DataOperator.DataOut(tempGrid, tempItem);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }

        private void btnDishTypePrint_Click(object sender, EventArgs e)
        {
            try
            {
                DevExpress.XtraEditors.SimpleButton tempBtn = (DevExpress.XtraEditors.SimpleButton)sender;
                if (tempBtn == null)
                    return;
                string tempItem = tempBtn.Tag.ToString();
                foreach (Control tempControl in this.tbctrl.SelectedTabPage.Controls)
                {
                    if (tempControl.GetType() == typeof(DevExpress.XtraGrid.GridControl))
                    {
                        DevExpress.XtraGrid.GridControl tempGridControl = (DevExpress.XtraGrid.GridControl)tempControl;
                        ClassAssist.DataOperator.DataPrint(tempGridControl, tempItem,null);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }

        #region private void AlterBuffState(string paramBuffStateNum, string paramBuffState)修改餐台使用状态中选中的记录
        ///// <summary>
        ///// 修改餐台使用状态中选中的记录
        ///// </summary>
        ///// <param name="paramBuffStateNum"></param>
        ///// <param name="paramBuffState"></param>
        //private void AlterBuffState(string paramBuffStateNum, string paramBuffState)
        //{
        //    int returnValue4 = myBUCMS_ItemDetail.RAlterBuffState(paramBuffStateNum, paramBuffState);
        //    if (returnValue4 > 0)
        //    {
        //        MessageBox.Show("修改成功！");
        //        return;
        //    }
        //}
        #endregion
    }
}