using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using CMS.BULayer;
namespace CMS.UILayer.frmBCarryOut
{
    /// <summary>
    /// 餐台查询
    /// </summary>
    /// 创建人：桂书丛
    /// 创建时间：2013-02-04
    public partial class frmBuffetBookSearch : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="frmBuffetBookSearch"/> class.
        /// </summary>
        /// 创建人：桂书丛
        /// 创建时间：2013-02-04
        public frmBuffetBookSearch()
        {
            InitializeComponent();
            InitializeControls();
        }

        #region
        private BUCMS_BuffetBooking myBUCMS_BuffetBooking = new BUCMS_BuffetBooking();
        #endregion

        /// <summary>
        /// Initializes the controls.
        /// </summary>
        /// 创建人：桂书丛
        /// 创建时间：2013-02-02
        private void InitializeControls()
        {
            try
            {
                DataTable myDataTable = myBUCMS_BuffetBooking.GetOrder(true,string.Empty,string.Empty,false);
                this.gridControlMain.DataSource = myDataTable;
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Handles the Load event of the frmBuffetBookSearch control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建时间：2013-02-02
        private void frmBuffetBookSearch_Load(object sender, EventArgs e)
        {
            DataBindingsControls();
        }

        /// <summary>
        /// Datas the bindings controls.
        /// </summary>
        /// 创建人：桂书丛
        /// 创建时间：2013-02-02
        private void DataBindingsControls()
        {
            BindingFirstPage();
            BindingTwoPage();
            cmbField_SelectedIndexChanged(null, null);
            //cmbSField_SelectedIndexChanged(null,null);
        }

        /// <summary>
        /// Bindings the two page.
        /// </summary>
        /// 创建人：桂书丛
        /// 创建时间：2013-02-02
        private void BindingTwoPage()
        {
            try
            {
                 DataTable tempDataTable = new BUCMS_Buffets().GetOrder(true, string.Empty, string.Empty, false);
                ClassAssist.CommonOperator.DataBindingLookUpEdit(this.lupBuffetName, tempDataTable, "餐台名称", "餐台编号", true);
                this.lupRoomType.Properties.DataSource = tempDataTable;
                this.lupRoomType.ItemIndex = 0;
                tempDataTable = new BUT_User().GetAllUserInfo();
                ClassAssist.CommonOperator.DataBindingLookUpEdit(this.lupCreatePerson, tempDataTable, "USERNAME", "ID", true);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Bindings the first page.
        /// </summary>
        /// 创建人：桂书丛
        /// 创建时间：2013-02-02
        private void BindingFirstPage()
        {
            try
            {
                DataTable tempDataTable = myBUCMS_BuffetBooking.GetOrder(false, string.Empty, string.Empty, false);
                ClassAssist.CommonOperator.DataBindingLookUpEdit(this.lupCustomerName, tempDataTable, "CName","ID",true);
                tempDataTable = new BUT_User().GetAllUserInfo();
                ClassAssist.CommonOperator.DataBindingLookUpEdit(this.lupTransactor,tempDataTable,"USERNAME","ID",true);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }

        #region ==========================================查询==========================================

        #region private void ComboBoxAndTextBoxVisible(bool paramDisplayOrNot) 根据参数设置ComboBox和TextBox第二条件控件的可视状态
        /// <summary>
        /// 根据参数设置ComboBox和TextBox第二条件控件的可视状态
        /// </summary>
        /// <param name="paramDisplayOrNot">是否可视</param>
        private void ComboBoxAndTextBoxVisible(bool paramDisplayOrNot)
        {
            this.txCondition.Visible = paramDisplayOrNot;
            this.mruCondition.Visible = paramDisplayOrNot;
            this.lupBuffetName.Visible = paramDisplayOrNot;
            this.lupCreatePerson.Visible = paramDisplayOrNot;
            this.lupCustomerName.Visible = paramDisplayOrNot;
            this.lupRoomType.Visible = paramDisplayOrNot;
            this.lupTransactor.Visible = paramDisplayOrNot;
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
                case "lupPeople": DataControlVisible(false);
                    ComboBoxAndTextBoxVisible(false);
                    this.lupTransactor.Visible = true;
                    this.lupCreatePerson.Visible = true;
                    this.lupCreatePerson.ItemIndex = 0;
                    break;
                case "lupName": DataControlVisible(false);
                    ComboBoxAndTextBoxVisible(false);
                    this.lupBuffetName.Visible = true;
                    this.lupCustomerName.Visible = true;
                    this.lupBuffetName.ItemIndex = 0;
                    break;
                case "Suplup": DataControlVisible(false);
                    ComboBoxAndTextBoxVisible(false);
                    this.lupRoomType.Visible = true;
                    this.lupRoomType.ItemIndex = 0;
                    break;
                default: DataControlVisible(false);
                    ComboBoxAndTextBoxVisible(false);
                    this.txCondition.Visible = true;
                    this.mruCondition.Visible = true;
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
            this.dateCreateEnd.Visible = paramDisplayOrNot;
            this.lblFrom.Visible = paramDisplayOrNot;
            this.dateCreateEnd.Visible = paramDisplayOrNot;
            this.dateStart.Visible = paramDisplayOrNot;
            this.lblOverForm.Visible = paramDisplayOrNot;
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
            if (tempStringField == "预定时间" || tempStringField == "失效时间")
            {
                ModeQueryInit("DatePicker");
                return;
            }
            if (tempStringField == "办理人")
            {
                ModeQueryInit("lupPeople");
                return;
            }
            if (tempStringField == "顾客名称")
            {
                ModeQueryInit("luprName");
                return;
            }
            if (tempStringField == "预定餐台")
            {
                this.xtraTabControlMain.SelectedTabPageIndex = 1;
                return;
            }
            ModeQueryInit("Other");
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
                DataTable tempDataTable = myBUCMS_BuffetBooking.GetOrder(true,this.cmbField.Text.Trim(),tempDateTimeStart,tempDateTimeEnd);
                this.gridControlMain.DataSource = tempDataTable;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 日期查询
        /// </summary>
        private void DateQuery(bool Flages)
        {
            DateTime tempDateTimeStart = Convert.ToDateTime(this.dateCreateStart.EditValue);
            DateTime tempDateTimeEnd = Convert.ToDateTime(this.dateCreateEnd.EditValue);
            try
            {
                DataTable tempDataTable = myBUCMS_BuffetBooking.GetOrder(true, this.cmbSField.Text.Trim(), tempDateTimeStart, tempDateTimeEnd);
                this.gridControlMain.DataSource = tempDataTable;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
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
                case "顾客名称": returnStringConditon = this.lupCustomerName.Text.Trim();
                    break;
                case "办理人": returnStringConditon = this.lupTransactor.Text.ToString();
                    break;
                default: returnStringConditon = this.txCondition.Text.Trim();
                    break;
            }
            return returnStringConditon;
        }

        /// <summary>
        /// 获得第二查询条件
        /// </summary>
        /// <param name="paramField"></param>
        /// <returns></returns>
        private string GetCondition(string paramField,bool Flages)
        {
            string returnStringConditon = string.Empty;
            switch (paramField)
            {
                case "餐台名称": returnStringConditon = this.lupBuffetName.Text.Trim();
                    break;
                case "包厢类型": returnStringConditon = this.lupRoomType.Text;
                    break;
                case "创建人": returnStringConditon = this.lupCreatePerson.Text;
                    break;
                default: returnStringConditon = this.mruCondition.Text.Trim();
                    break;
            }
            return returnStringConditon;
        }
        #endregion

        /// <summary>
        /// Handles the Click event of the btnSearch control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建时间：2013-03-04
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string tempStringField = this.cmbField.Text.Trim();
            if (tempStringField == "办理时间"||tempStringField=="失效时间")
            {
                DateQuery();
                return;
            }
            string tempStringCondition = GetCondition(tempStringField);
            try
            {
                DataTable myDataTable = myBUCMS_BuffetBooking.GetOrder(true,tempStringField,tempStringCondition,false);
                this.gridControlMain.DataSource = myDataTable;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        #endregion

        /// <summary>
        /// Handles the Click event of the btnAll control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建时间：2013-02-04
        private void btnAll_Click(object sender, EventArgs e)
        {
            InitializeControls();
        }

        /// <summary>
        /// Handles the SelectionChanged event of the gridViewMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.Data.SelectionChangedEventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建时间：2013-02-04
        private void gridViewMain_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            DataRow tempDataRow = this.gridViewMain.GetFocusedDataRow();
            if (tempDataRow == null)
                return;
            FillDetailInfo(tempDataRow);
        }

        /// <summary>
        /// Fills the detail info.
        /// </summary>
        /// <param name="paramDataRow">The param data row.</param>
        /// 创建人：桂书丛
        /// 创建时间：2013-02-04
        private void FillDetailInfo(DataRow paramDataRow)
        {
            this.lblBuffetID.Text = paramDataRow["餐台编号"].ToString();
            this.lblBuffetName.Text = paramDataRow["餐台名称"].ToString();
            this.lblAvaNum.Text = paramDataRow["可容纳人数"].ToString();
            this.lblFloor.Text = paramDataRow["所在楼层"].ToString();
            this.groupControlRoom.Text = "所在：" + paramDataRow["所在包厢"].ToString() + "的详细信息";
            this.chkCondition.Checked = Convert.ToBoolean(paramDataRow["Condition"]);
            this.chkFan.Checked=Convert.ToBoolean(paramDataRow["Fan"]);
            this.chkTV.Checked = Convert.ToBoolean(paramDataRow["TV"]);
            this.chkDVD.Checked = Convert.ToBoolean(paramDataRow["DVD"]);
            this.txtOther.Text = paramDataRow["Other"].ToString();
        }

        /// <summary>
        /// Handles the Click event of the btnBack control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建时间：2013-02-04
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the cmbSField control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建时间：2013-02-04
        private void cmbSField_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tempStringField = this.cmbSField.Text.Trim();
            if (tempStringField == "创建时间")
            {
                ModeQueryInit("DatePicker");
                return;
            }
            if (tempStringField == "创建人")
            {
                ModeQueryInit("lupPeople");
                return;
            }
            if (tempStringField == "餐台名称")
            {
                ModeQueryInit("lupName");
                return;
            }
            if (tempStringField == "包厢类型")
            {
                ModeQueryInit("Suplup");
                return;
            }
            ModeQueryInit("Other");
        }

        /// <summary>
        /// Handles the Click event of the btnSSearch control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建时间：2013-02-04
        private void btnSSearch_Click(object sender, EventArgs e)
        {
            string tempStringField = this.cmbSField.Text.Trim();
            if (tempStringField == "创建时间")
            {
                DateQuery(false);
                return;
            }
            string tempStringCondition = GetCondition(tempStringField,false);
            try
            {
                DataTable myDataTable=new DataTable();
                if (tempStringField == "包厢类型")
                    myDataTable = myBUCMS_BuffetBooking.GetOrder(true, "所在包厢", tempStringCondition, false);
                else
                    myDataTable = myBUCMS_BuffetBooking.GetOrder(true,tempStringField,tempStringCondition,false);
                this.gridControlMain.DataSource = myDataTable;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the btnSAll control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建时间：2013-02-04
        private void btnSAll_Click(object sender, EventArgs e)
        {
            btnAll_Click(sender, e);
        }

        /// <summary>
        /// Handles the Click event of the BtnDel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建时间：2013-02-04
        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (this.gridViewMain.SelectedRowsCount <= 0)
            {
                XtraMessageBox.Show("请先选择要删除(&D)的项", "操作违规",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string tempID = this.gridViewMain.GetFocusedRowCellDisplayText(this.ID);
            DialogResult tempDialogResult = XtraMessageBox.Show("编号为：" + tempID + "的预定信息","确定删除(&D)？", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == tempDialogResult)
            {
                VariedEnum.OperatorStatus EnOperatorStatus;
                try
                {
                    EnOperatorStatus = myBUCMS_BuffetBooking.Delete(tempID);
                    if (ClassAssist.CommonOperator.HandleOperatorEnum("删除(&D)预定信息", EnOperatorStatus))
                    {
                        BUT_SysLog.InsertSysLog(VariedEnum.LogType.数据操作, frmAssist.frmLogin.SysUser.UserID, "成功删除(&D)了编号为" + tempID + "的预定信息");
                        InitializeControls();
                    }
                }
                catch
                {
                    XtraMessageBox.Show("请确定此条数据不正在被使用后重试", "删除(&D)失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the btnPrint control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建时间：2013-02-04
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                ClassAssist.DataOperator.DataPrint(this.gridControlMain, "预定信息", null);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the btnOut control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建时间：2013-02-04
        private void btnOut_Click(object sender, EventArgs e)
        {
            try
            {
                ClassAssist.DataOperator.DataOut(this.gridViewMain, "预定信息");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
    }
}