
//******************************************************************************************************
//** Copyright (C) 2010-2013 重大网络教育学院
//** 创建人：桂书丛
//** 类名称\文件名：frmSysLog
//** 类功能：系统日志操作窗体
//** 描 述：餐饮管理系统 系统日志操作窗体
//** 创建日期：2013-1-23
//** 修改(&U)人：桂书丛
//** 修改(&U)日期：2013-2-4
//** 整理日期：2013-2-4
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
    public partial class frmSysLog : DevExpress.XtraEditors.XtraForm
    {
        #region =========================================变量定义==========================================
        private BUT_SysLog myBUSysLog = new BUT_SysLog();
        private DataTable myDataTable = new DataTable();
        #endregion

        #region ==========================================其他===========================================
        /// <summary>
        /// Initializes a new instance of the <see cref="frmSysLog"/> class.
        /// </summary>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-06
        public frmSysLog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the frmSysLog control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-06
        private void frmSysLog_Load(object sender, EventArgs e)
        {
            InitializeControls();
        }

        /// <summary>
        /// 初始化控件
        /// </summary>
        private void InitializeControls()
        {
            GetAllSysLogInfo();
            DataBindingsOtherControl();
        }

        /// <summary>
        /// 自定义方法：绑定其他数据控件
        /// </summary>
        private void DataBindingsOtherControl()
        {
            try
            {
                myDataTable=new BUT_User().GetAllUserInfo();
                ClassAssist.CommonOperator.DataBindingLookUpEdit(lupOperatorID,myDataTable,"USERNAME","ID",true);
                myDataTable = new BUT_ItemDetail().GetItemByType("日志类型");
                ClassAssist.CommonOperator.DataBindingLookUpEdit(lupLogType,myDataTable,"NAME","ID",true);
                cmbField_SelectedIndexChanged(null,null);
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
        /// 整理人：桂书丛
        /// 整理时间：2013-03-06
        private void gridViewMain_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            try
            {
                this.txtType.Text = gridViewMain.GetFocusedRowCellDisplayText(LogType);
                this.txtOperator.Text = gridViewMain.GetFocusedRowCellDisplayText(OperatorPerson);
                this.txtLogTime.Text = gridViewMain.GetFocusedRowCellDisplayText(RecordDate);
                this.memoDescription.Text = gridViewMain.GetFocusedRowCellDisplayText(Description);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handles the KeyDown event of the txtLogID control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.KeyEventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-06
        private void txtLogID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch_Click(sender, null);
        }

        /// <summary>
        /// Handles the TextChanged event of the txtLogID control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-06
        private void txtLogID_TextChanged(object sender, EventArgs e)
        {
            string tempStringField = this.cmbField.Text.Trim();
            string tempStringCondition = GetCondition(tempStringField);
            try
            {
                myDataTable = myBUSysLog.GetOrder(true,tempStringField, tempStringCondition,true);
                this.gridControlSysLog.DataSource = myDataTable;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        #endregion 

        #region ==========================================查询==========================================
        #region private void GetAllSysLogInfo() 获得所有系统日志
        /// <summary>
        /// 获得所有系统日志
        /// </summary>
        private void GetAllSysLogInfo()
        {
            try
            {
                myDataTable = myBUSysLog.GetOrder(true,string.Empty,string.Empty,false);
                this.gridControlSysLog.DataSource = myDataTable;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region private void ComboBoxAndTextBoxVisible(bool paramDisplayOrNot) 根据参数设置ComboBox和TextBox第二条件控件的可视状态
        /// <summary>
        /// 根据参数设置ComboBox和TextBox第二条件控件的可视状态
        /// </summary>
        /// <param name="paramDisplayOrNot">是否可视</param>
        private void ComboBoxAndTextBoxVisible(bool paramDisplayOrNot)
        {
            this.txtLogID.Visible = paramDisplayOrNot;
            this.lupOperatorID.Visible = paramDisplayOrNot;
            this.lupLogType.Visible = paramDisplayOrNot;
        }
        #endregion

        #region private void ModeQueryInit(string paramType) 初始化查询控件
        /// <summary>
        /// 初始化查询控件
        /// </summary>
        ///<param name="paramType">第二条件控件类型</param>
        private void ModeQueryInit(string paramType)
        {
            switch (paramType)
            {
                case "DatePicker": DataControlVisible(true);
                    ComboBoxAndTextBoxVisible(false);
                    break;
                case "lupLogType": DataControlVisible(false);
                    ComboBoxAndTextBoxVisible(false);
                    this.lupLogType.Visible = true;
                    break;
                case "lupOperatorID": DataControlVisible(false);
                    ComboBoxAndTextBoxVisible(false);
                    this.lupOperatorID.Visible = true;
                    break;
                default: DataControlVisible(false);
                    ComboBoxAndTextBoxVisible(false);
                    this.txtLogID.Visible = true;
                    break;
            }
        }
        #endregion

        #region private void DataControlVisible(bool paramDisplayOrNot) 根据参数设置时间第二条件控件的可视状态
        /// <summary>
        /// 根据参数设置时间第二条件控件的可视状态
        /// </summary>
        /// <param name="paramDisplayOrNot">是否可视</param>
        private void DataControlVisible(bool paramDisplayOrNot)
        {
            this.dateStart.Visible = paramDisplayOrNot;
            this.lblFrom.Visible = paramDisplayOrNot;
            this.dateEnd.Visible = paramDisplayOrNot;
        }
        #endregion

        /// <summary>
        /// 第一条件选择改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbField_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tempStringField = this.cmbField.Text.Trim();
            if (tempStringField == "记录时间")
            {
                ModeQueryInit("DatePicker");
                return;
            }
            if (tempStringField == "日志类型")
            {
                ModeQueryInit("lupLogType");
                return;
            }
            if (tempStringField == "操作员")
            {
                ModeQueryInit("lupOperatorID");
                return;
            }
            ModeQueryInit("LogID");
        }

        #region private void DateQuery() 日期查询
        /// <summary>
        /// 日期查询
        /// </summary>
        private void DateQuery()
        {
            DateTime tempDateTimeStart = Convert.ToDateTime(this.dateStart.EditValue);
            DateTime tempDateTimeEnd = Convert.ToDateTime(this.dateEnd.EditValue);
            try
            {
                myDataTable = myBUSysLog.GetOrder(true, "[记录时间]", tempDateTimeStart, tempDateTimeEnd);
                this.gridControlSysLog.DataSource = myDataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region private string GetCondition(string paramField) 获得第二查询条件
        /// <summary>
        /// 获得第二查询条件
        /// </summary>
        /// <param name="paramField"></param>
        /// <returns></returns>
        private string GetCondition(string paramField)
        {
            string returnStringConditon = string.Empty;
            switch (paramField)
            {
                case "日志类型": returnStringConditon = this.lupLogType.Text.ToString();
                    break;
                case "操作员": returnStringConditon = this.lupOperatorID.Text.ToString();
                    break;
                default: returnStringConditon = this.txtLogID.Text.Trim();
                    break;
            }
            return returnStringConditon;
        }
        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string tempStringField = this.cmbField.Text.Trim();
            if (tempStringField == "记录时间")
            {
                DateQuery();
                return;
            }
            string tempStringCondition = GetCondition(tempStringField);
            try
            {
                myDataTable = myBUSysLog.GetOrder(true,tempStringField,tempStringCondition,false);
                this.gridControlSysLog.DataSource = myDataTable;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region ========================================按钮事件========================================
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (this.gridViewMain.SelectedRowsCount <= 0)
            {
                XtraMessageBox.Show("请先选择要删除的项", "操作违规",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string tempID = this.gridViewMain.GetFocusedRowCellDisplayText(LogID);
            DialogResult tempDialogResult = XtraMessageBox.Show("编号为：" + tempID + "的信息","确定删除？", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == tempDialogResult)
            {
                VariedEnum.OperatorStatus EnOperatorStatus;
                try
                {
                    EnOperatorStatus = myBUSysLog.Delete(tempID);
                    if (ClassAssist.CommonOperator.HandleOperatorEnum("删除日志信息", EnOperatorStatus))
                    {
                        BUT_SysLog.InsertSysLog(VariedEnum.LogType.系统事件, frmAssist.frmLogin.SysUser.UserID, "成功删除了编号为" + tempID + "的日志信息");
                        GetAllSysLogInfo();
                    }
                }
                catch
                {
                    XtraMessageBox.Show("请确定此条数据不正在被使用后重试", "删除失败",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        /// <summary>
        /// 返回(&B)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 清空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            VariedEnum.OperatorStatus EnOperatorStatus;
            try
            {
                DialogResult tempDialogResult = XtraMessageBox.Show("确定清空所有的日志信息","确定清空？",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (tempDialogResult == DialogResult.No)
                    return;
                EnOperatorStatus = myBUSysLog.ClearSysLog();
                if (ClassAssist.CommonOperator.HandleOperatorEnum("清空日志信息", EnOperatorStatus))
                {
                    BUT_SysLog.InsertSysLog(VariedEnum.LogType.系统事件, frmAssist.frmLogin.SysUser.UserID, "成功清空了所有的日志信息");
                    GetAllSysLogInfo();
                }
            }
            catch
            {
                XtraMessageBox.Show("请确定此条数据不正在被使用后重试", "删除失败",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// 全部
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAll_Click(object sender, EventArgs e)
        {
            GetAllSysLogInfo();
        }

        /// <summary>
        /// Handles the DoubleClick event of the gridViewMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-2-28
        private void gridViewMain_DoubleClick(object sender, EventArgs e)
        {
            BtnDel_Click(sender, e);
        }

        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOut_Click(object sender, EventArgs e)
        {
            try
            {
                ClassAssist.DataOperator.DataOut(this.gridViewMain,"日志信息");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 打印
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                ClassAssist.DataOperator.DataPrint(this.gridControlSysLog,"日志信息",null);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region =======================================右键菜单事件=======================================
        /// <summary>
        /// 显示右键菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridControlSysLog_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.popupMenuLog.ShowPopup(MousePosition);
            }
        }

        /// <summary>
        /// 全部
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barBtnAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnAll_Click(sender,null);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barBtnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BtnDel_Click(sender, null);
        }

        /// <summary>
        /// 清空    
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barBtnClear_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnClear_Click(sender,null);
        }

        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barBtnOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnOut_Click(sender,null);
        }

        /// <summary>
        /// 打印
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barBtnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnPrint_Click(sender,null);
        }
        #endregion

    }
}