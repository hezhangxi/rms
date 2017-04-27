using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CMS.BULayer;
using CMS.Model;
using DevExpress.XtraEditors;


namespace CMS.UILayer.frmVIPClient
{
    /// <summary>
    /// 客户信息管理
    /// </summary>
    /// 整理人：桂书丛
    /// 整理时间：2013-02-28
    public partial class frmClientInformation : DevExpress.XtraEditors.XtraForm
    {
        #region 变量定义
        BUCMS_VIPClient myBUCMS_VIPClient = new BUCMS_VIPClient();
        DataTable myDataTable = new DataTable();
        string MruValue = null; //按条件查询的第二条件值
        #endregion 

        /// <summary>
        /// Initializes a new instance of the <see cref="frmClientInformation"/> class.
        /// </summary>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-28
        public frmClientInformation()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the frmClientInformation control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-28
        private void frmClientInformation_Load(object sender, EventArgs e)
        {
            InitializeControls();
            BindingToSerach();
            IsVisible();                            //将所有控件隐藏
            this.dateStart.Visible = true;          //默认显示按时间查询
            this.dateEnd.Visible = true;
            this.lblFrom.Visible = true;
            this.cmbField.SelectedIndex = 7;
        }

        #region public void InitializeControls()绑定数据到gridControl表格
        /// <summary>
        /// 绑定数据到gridControl表格
        /// </summary>
        public void InitializeControls()
        {
            try
            {
                DataTable myDataTable = myBUCMS_VIPClient.GetOrderVIPClient(true,string.Empty,string.Empty);
                this.gridControlMain.DataSource = myDataTable;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }

        }
        #endregion

        /// <summary>
        /// Handles the SelectionChanged event of the gridViewMain control.选中一项时发生
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.Data.SelectionChangedEventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-28
        private void gridViewMain_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            DataRow tempDataRow = this.gridViewMain.GetFocusedDataRow();                                            //取出选中行的原始数据(在数据库中的)(数据库中的数据不一定全在控件中显示)
            if (tempDataRow == null)
                return;
            string myVIPID = tempDataRow["VIPTypeID"].ToString();
            BUCMS_VIPType myBUCMS_VIPType = new BUCMS_VIPType();
            try
            {
                DataTable myDataTable = myBUCMS_VIPType.GetOrder(false, "ID", myVIPID, false);
                this.txtVIPName.Text = myDataTable.Rows[0]["Name"].ToString();
                this.txtDiscount.EditValue = myDataTable.Rows[0]["Discount"];
                this.txtVIPCost.EditValue = tempDataRow["VIPCost"];
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        #region 按钮事件

        /// <summary>
        /// 登记新客户
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-28
        private void btnRegisterNewClient_Click(object sender, EventArgs e)
        {
            frmRegisterClient myfrmRegisterClient = new frmRegisterClient();
            if (myfrmRegisterClient.ShowDialog() == DialogResult.OK)
                InitializeControls();
        }

        /// <summary>
        /// 修改客户信息
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-28
        private void btnUpdateClientInfo_Click(object sender, EventArgs e)
        {
            if (this.gridViewMain.SelectedRowsCount <= 0)                                                           //如果一行都没有选中
            {
                XtraMessageBox.Show("请选择要修改的项!", "注意:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataRow tempDataRow = this.gridViewMain.GetFocusedDataRow();
            string VIPName = this.txtVIPName.Text.Trim().ToString();
            frmRegisterClient myfrmRegisterClient = new frmRegisterClient(tempDataRow, VIPName);
            if (myfrmRegisterClient.ShowDialog() == DialogResult.OK)
                InitializeControls();
        }

        /// <summary>
        /// 删除客户
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-28
        private void btnDeleteClient_Click(object sender, EventArgs e)
        {

            if (this.gridViewMain.SelectedRowsCount <= 0)
            {
                XtraMessageBox.Show("请选择要删除的项!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string VIPClientID = this.gridViewMain.GetFocusedRowCellValue("ID").ToString();
            DialogResult myDialogResult = XtraMessageBox.Show("编号为" + VIPClientID + "的客户?","确定删除？", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == myDialogResult)
            {
                VariedEnum.OperatorStatus EnOperatorStatus;
                try
                {
                    EnOperatorStatus = myBUCMS_VIPClient.Delete(VIPClientID);
                    if (ClassAssist.CommonOperator.HandleOperatorEnum("删除客户信息", EnOperatorStatus))
                    {
                        BUT_SysLog.InsertSysLog(VariedEnum.LogType.系统事件, frmAssist.frmLogin.SysUser.UserID,"成功删除了编号为" + VIPClientID + "的客户");
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
        /// 打印(&P)
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-28
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                ClassAssist.DataOperator.DataPrint(this.gridControlMain, "客户信息",null);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 导出(&O)
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-28
        private void btnOut_Click(object sender, EventArgs e)
        {
            try
            {
                ClassAssist.DataOperator.DataOut(this.gridViewMain, "客户信息");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 返回(&B)
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-28
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 查询

        /// <summary>
        /// 全部查询
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-28
        private void btnAll_Click(object sender, EventArgs e)
        {
            InitializeControls();
        }

        /// <summary>
        /// 按条件查询
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-28
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string FieldName = this.cmbField.Text.Trim().ToString();
            if (FieldName == "创建时间")
            {
                DateSearch();
                return;
            }
            if (FieldName == "享受优惠")
            {
                SearchVIPType();
                return;
            }
            string tempSecondContidion = SecondContidion(FieldName);
            try
            {
                DataTable myDataTable = new DataTable();
                myDataTable = myBUCMS_VIPClient.GetOrderVIPClient(true, tempSecondContidion, MruValue);
                this.gridControlMain.DataSource = myDataTable;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        #region DateSearch()时间查询
        /// <summary>
        /// 时间查询
        /// </summary>
        private void DateSearch()
        {
            DateTime TimeStart = Convert.ToDateTime(this.dateStart.EditValue);
            DateTime TimeEnd = Convert.ToDateTime(this.dateEnd.EditValue);
            DataTable myDataTable = new DataTable();
            try
            {
                myDataTable = myBUCMS_VIPClient.GetOrderVIPClientOnDate(true, "CreateDate", TimeStart, TimeEnd);
                this.gridControlMain.DataSource = myDataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region private void SearchVIPType()按享受优惠查询
        /// <summary>
        /// 按享受优惠查询
        /// </summary>
        private void SearchVIPType()
        {
            string VIPTypeID = this.lupVIPType.EditValue.ToString(); //获取VIPTypeID
            try
            {
                DataTable myDataTable = new DataTable();
                myDataTable = myBUCMS_VIPClient.GetOrderVIPClient(true, "VIPTypeID", VIPTypeID);
                this.gridControlMain.DataSource = myDataTable;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region  private string SecondContidion() 获得第二查询条件字段
        /// <summary>
        /// 获得第二查询条件字段
        /// </summary>
        /// <returns></returns>
        private string SecondContidion(string paramSecondCondition)
        {
            string returnStringConditon = string.Empty;
            switch (paramSecondCondition)
            {
                case "客户编号": returnStringConditon = "ID";
                    MruValue = this.mruID.Text.ToString();
                    break;
                case "客户姓名": returnStringConditon = "Name";
                    MruValue = this.mruName.Text.ToString();
                    break;
                case "客户电话": returnStringConditon = "TelPhone";
                    MruValue = this.mruPhone.Text.ToString();
                    break;
                case "所在单位": returnStringConditon = "DepName";
                    MruValue = this.mruPosition.Text.ToString();
                    break;
                case "当前职位": returnStringConditon = "Position";
                    MruValue = this.mruPosition.Text.ToString();
                    break;
                case "创建人": returnStringConditon = "CreatePerson";
                    MruValue = this.lupCreatePerson.Text.ToString();
                    break;
                default:
                    break;
            }
            return returnStringConditon;
        }
        #endregion

        /// <summary>
        /// 第一条件改变时
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-28
        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
           string tempStringField = this.cmbField.Text.Trim();
            if(tempStringField=="客户编号")
            {
                ModeQueryInit("mruID");
                return;
            }
            if (tempStringField == "客户姓名")
            {
                ModeQueryInit("mruName");
                return;
            }
            if (tempStringField == "客户电话")
            {
                ModeQueryInit("mruPhone");
                return;
            }
            if (tempStringField == "享受优惠")
            {
                ModeQueryInit("lupVIPType");
                return;
            }
            if (tempStringField == "所在单位")
            {
                ModeQueryInit("mruDepName");
                return;
            }
            if (tempStringField == "当前职位")
            {
                ModeQueryInit("mruPosition");
                return;
            }
            if (tempStringField == "创建人")
            {
                ModeQueryInit("lupCreatePerson");
                return;
            }
            if (tempStringField == "创建时间")
            {
                ModeQueryInit("dateStart");
                return;
            }
        }

        #region   private void BindingToSerach()绑定数据到查询条件的控件
        /// <summary>
        /// 绑定数据到查询条件的控件
        /// </summary>
        private void BindingToSerach()
        {
            DataTable myDataTable = new DataTable();
            try
            {
                //会员卡要从VIPType表中获取
                BUCMS_VIPType myBUCMS_VIPType = new BUCMS_VIPType();
                myDataTable = myBUCMS_VIPType.GetOrder(false, string.Empty, string.Empty, false);
                this.lupVIPType.Properties.DataSource = myDataTable;
                this.lupVIPType.ItemIndex = 0;
                this.lupVIPType.Properties.DisplayMember = "Name";
                //创建人要到User表中获取
                BUT_User myBUT_User = new BUT_User();
                myDataTable = myBUT_User.GetAllUserInfo();
                this.lupCreatePerson.Properties.DataSource = myDataTable;
                this.lupCreatePerson.ItemIndex = 0;
                this.lupCreatePerson.Properties.DisplayMember = "USERNAME";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region private void ModeQueryInit(string paramType)根据第一条件来判断
        /// <summary>
        /// 根据第一条件来判断
        /// </summary>
        /// <param name="paramType"></param>
         private void ModeQueryInit(string paramType)
        {
            switch (paramType)
            {
                case "mruID": IsVisible();
                    this.mruID.Visible = true;
                    break;
                case "mruName": IsVisible();
                    this.mruName.Visible = true;
                    break;
                case "mruPhone": IsVisible();
                    this.mruPhone.Visible = true;
                    break;
                case "lupVIPType": IsVisible();
                    this.lupVIPType.Visible = true;
                    this.lupVIPType.ItemIndex = 0;
                    break;
                case "mruDepName": IsVisible();
                    this.mruPosition.Visible = true;
                    break;
                case "mruPosition": IsVisible();
                    this.mruPosition.Visible = true;
                    break;
                case "lupCreatePerson": IsVisible();
                    this.lupCreatePerson.Visible = true;
                    this.lupCreatePerson.ItemIndex = 0;
                    break;
                case "dateStart": IsVisible();
                    this.dateStart.Visible = true;
                    this.dateEnd.Visible = true;
                    this.lblFrom.Visible = true;
                    break;
                default: IsVisible();
                    break;
            }
            }
        #endregion

        #region private void IsVisible() 隐藏/显示查询条件的控件
        /// <summary>
        /// 隐藏/显示查询条件的控件
        /// </summary>
        private void IsVisible()
        {
            this.lupVIPType.Visible = false;
            this.lupCreatePerson.Visible = false;
            this.mruDepName.Visible = false;
            this.mruID.Visible = false;
            this.mruPhone.Visible = false;
            this.mruPosition.Visible = false;
            this.mruName.Visible = false;
            this.dateStart.Visible = false;
            this.dateEnd.Visible = false;
            this.lblFrom.Visible = false;
        }
        #endregion

        /// <summary>
        /// 如果一行都没有选中
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-28
        private void btnPutInCost_Click(object sender, EventArgs e)
        {
            if (this.gridViewMain.SelectedRowsCount <= 0)
            {
                XtraMessageBox.Show("请选择要修改的项!", "注意:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataRow tempDataRow = this.gridViewMain.GetFocusedDataRow();
            object VIPName = this.txtVIPName.Text.ToString();
            object VIPDiscount = this.txtDiscount.Text.ToString();
            frmPutInCost myfrmPutInCost = new frmPutInCost(tempDataRow, VIPName, VIPDiscount);
            if (myfrmPutInCost.ShowDialog() == DialogResult.OK)
                InitializeControls();
        }
        #endregion

        /// <summary>
        /// Handles the EditValueChanged event of the txtVIPCost control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 添加人：桂书丛
        /// 添加时间：2013-02-28
        private void txtVIPCost_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                double tempDiscount = Convert.ToDouble(this.txtDiscount.EditValue);
                double tempVIPCost = Convert.ToDouble(this.txtVIPCost.EditValue);
                this.txtOverCash.EditValue = tempVIPCost / (tempDiscount * 0.1);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }
    }
}
