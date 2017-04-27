using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using CMS.BULayer;
using CMS.Model;
using CMS.CommonLayer;

namespace CMS.UILayer.frmBasicInfo
{
    public partial class frmBuffInfoManagement : DevExpress.XtraEditors.XtraForm
    {
        #region 变量定义
        DataTable tempDataTable = new DataTable();
        BUCMS_RoomType myBUCMS_RoomType = new BUCMS_RoomType();
        BUCMS_Buffets myBUCMS_Buffets = new BUCMS_Buffets();
        object[] tempInfo = null;
        frmBuffInfoOperate myfrmBuffInfoOperate = null;
        frmRoomInfoOperate myfrmRoomInfoOperate = null;
        string tempID = null;
        #endregion

        public frmBuffInfoManagement()
        {
            InitializeComponent();
            this.tbctrl.SelectedTabPageIndex = 1;
        }

        private void frmBuffInfoManagement_Load(object sender, EventArgs e)
        {
            this.tbctrl.SelectedTabPageIndex = 0;
        }

        #region tbctrl_SelectedPageChanging GridControl中的数据绑定
        /// <summary>
        /// GridControl的数据绑定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbctrl_SelectedPageChanging(object sender, DevExpress.XtraTab.TabPageChangingEventArgs e)
        {
            SelectedPageChanging(e.Page);
            //try
            //{
            //    DevExpress.XtraTab.TabPageChangingEventArgs e;
            //    if (Convert.ToInt32(e.Page.Tag) == 1)
            //    {
            //        tempDataTable = myBUCMS_RoomType.GetOrder(true, string.Empty, string.Empty, false);
            //    }
            //    else
            //        tempDataTable = myBUCMS_Buffets.GetOrder(true, string.Empty, string.Empty, false);
            //    foreach (Control tempControl in e.Page.Controls)
            //    {
            //        if (tempControl.GetType() == typeof(DevExpress.XtraGrid.GridControl))
            //            ((DevExpress.XtraGrid.GridControl)tempControl).DataSource = tempDataTable;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    XtraMessageBox.Show(ex.Message);
            //}
        }
        #endregion

        private void SelectedPageChanging(DevExpress.XtraTab.XtraTabPage paramPage)
        {
            try
            {
                if (Convert.ToInt32(paramPage.Tag) == 1)
                {
                    tempDataTable = myBUCMS_RoomType.GetOrder(true, string.Empty, string.Empty, false);
                }
                else
                    tempDataTable = myBUCMS_Buffets.GetOrder(true, string.Empty, string.Empty, false);
                foreach (Control tempControl in paramPage.Controls)
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

        private void gridViewBuffInfo_DoubleClick(object sender, EventArgs e)
        {
            object[] tempInfo = ClassAssist.CommonOperator.GetGVSelectRowInfo(this.gridViewBuffInfo);
            if (tempInfo != null)
            {
                frmBuffInfoOperate myfrmBuffInfoOperate = new frmBuffInfoOperate(tempInfo);
                if (myfrmBuffInfoOperate.ShowDialog() == DialogResult.OK)
                {
                    if (this.tbctrl.SelectedTabPage != null)
                        SelectedPageChanging(this.tbctrl.SelectedTabPage);
                    //写日志
                }
            }
        }

        //****************************按钮的单击事件****************************//


        private void btnBuffInfoAdd_Click(object sender, EventArgs e)
        {
            DevExpress.XtraTab.XtraTabPage tempTabPage = this.tbctrl.SelectedTabPage;
            if (tempTabPage == null)
                return;
            if (Convert.ToInt32(tempTabPage.Tag) == 1)
            {
                myfrmRoomInfoOperate = new frmRoomInfoOperate();
                if (myfrmRoomInfoOperate.ShowDialog() == DialogResult.OK)
                {
                    SelectedPageChanging(this.tbctrl.SelectedTabPage);
                }
            }
            else
            {
                myfrmBuffInfoOperate = new frmBuffInfoOperate();
                if (myfrmBuffInfoOperate.ShowDialog() == DialogResult.OK)
                {
                    SelectedPageChanging(this.tbctrl.SelectedTabPage);
                }
            }
        }


        /// <summary>
        /// Handles the Click event of the btnBuffInfoDele control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-06
        private void btnBuffInfoDele_Click(object sender, EventArgs e)
        {
            DevExpress.XtraTab.XtraTabPage tempTabPage = this.tbctrl.SelectedTabPage;
            if (tempTabPage == null)
                return;
            if (Convert.ToInt32(tempTabPage.Tag) == 1)
            {
                if (this.gridView1.SelectedRowsCount <= 0)
                {
                    XtraMessageBox.Show("请先选择要删除的项", "操作违规", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                tempID = this.gridView1.GetFocusedRowCellValue("包厢编号").ToString();
                BuffInfoDele(tempID);
                return;
            }
            else
            {
                if (this.gridViewBuffInfo.SelectedRowsCount <= 0)
                {
                    XtraMessageBox.Show("请先选择要删除的项", "操作违规", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                tempID = this.gridViewBuffInfo.GetFocusedRowCellValue("餐台编号").ToString();
            }
            DialogResult tempDialogResult = XtraMessageBox.Show("编号为：" + tempID + "的餐台信息", "确定删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == tempDialogResult)
            {
                VariedEnum.OperatorStatus EnOperatorStatus;
                try
                {
                    EnOperatorStatus = myBUCMS_Buffets.Delete(tempID);
                    if (ClassAssist.CommonOperator.HandleOperatorEnum("删除", EnOperatorStatus))
                    {
                        BUT_SysLog.InsertSysLog(VariedEnum.LogType.系统事件, frmAssist.frmLogin.SysUser.UserID,
                            "成功删除了编号为：" + tempID + "的餐台信息");
                        SelectedPageChanging(this.tbctrl.SelectedTabPage);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("请确定该条数据没有正在使用后重试", "删除失败",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        /// <summary>
        /// Buffs the info dele.
        /// </summary>
        /// <param name="tempID">The temp ID.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-06
        private void BuffInfoDele(string tempID)
        {
            DialogResult tempDialogResult = XtraMessageBox.Show("编号为：" + tempID + "的包厢信息", "确定删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == tempDialogResult)
            {
                VariedEnum.OperatorStatus EnOperatorStatus;
                try
                {
                    EnOperatorStatus = myBUCMS_RoomType.Delete(tempID);
                    if (ClassAssist.CommonOperator.HandleOperatorEnum("删除", EnOperatorStatus))
                    {
                        BUT_SysLog.InsertSysLog(VariedEnum.LogType.系统事件, frmAssist.frmLogin.SysUser.UserID,
                            "成功删除了编号为：" + tempID + "的包厢信息");
                        SelectedPageChanging(this.tbctrl.SelectedTabPage);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("请确定该条数据没有正在使用后重试", "删除失败",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the btnBuffInfoAlter control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-06
        private void btnBuffInfoAlter_Click(object sender, EventArgs e)
        {
            DevExpress.XtraTab.XtraTabPage tempTabPage = this.tbctrl.SelectedTabPage;
            if (tempTabPage == null)
                return;
            if (Convert.ToInt32(tempTabPage.Tag) == 1)
            {
                if (this.gridView1.SelectedRowsCount < 0)
                {
                    XtraMessageBox.Show("请先选择要修改的项", "操作违规",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                tempInfo = ClassAssist.CommonOperator.GetGVSelectRowInfo(this.gridView1);
                if (tempInfo != null)
                    myfrmRoomInfoOperate = new frmRoomInfoOperate(tempInfo);
                if (myfrmRoomInfoOperate.ShowDialog() == DialogResult.OK)
                {
                    SelectedPageChanging(this.tbctrl.SelectedTabPage);
                }
            }
            else
            {
                if (this.gridViewBuffInfo.SelectedRowsCount < 0)
                {
                    XtraMessageBox.Show("请先选择要修改的项", "操作违规",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                tempInfo = ClassAssist.CommonOperator.GetGVSelectRowInfo(this.gridViewBuffInfo);
                if (tempInfo != null)
                    myfrmBuffInfoOperate = new frmBuffInfoOperate(tempInfo);
                if (myfrmBuffInfoOperate.ShowDialog() == DialogResult.OK)
                {
                    SelectedPageChanging(this.tbctrl.SelectedTabPage);
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the btnBuffInfoOut control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-06
        private void btnBuffInfoOut_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt16(this.tbctrl.SelectedTabPage.Tag) == 1)
                    ClassAssist.DataOperator.DataOut(this.gridView1, "包厢信息");
                else
                    ClassAssist.DataOperator.DataOut(this.gridViewBuffInfo, "餐台信息");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the btnBuffInfoPrint control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-06
        private void btnBuffInfoPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt16(this.tbctrl.SelectedTabPage.Tag) == 1)
                    ClassAssist.DataOperator.DataPrint(this.grdctrlRoomInfo, "包厢信息",null);
                else
                    ClassAssist.DataOperator.DataPrint(this.grdctrlBuffInfo, "餐台信息",null);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handles the DoubleClick event of the grdctrlRoomInfo control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-06
        private void grdctrlRoomInfo_DoubleClick(object sender, EventArgs e)
        {
            btnBuffInfoAlter_Click(sender, e);
        }

        /// <summary>
        /// Handles the FormClosing event of the frmBuffInfoManagement control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.FormClosingEventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-06
        private void frmBuffInfoManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAssist.frmBAMain.IsRefresh = true;
        }
    }
}
