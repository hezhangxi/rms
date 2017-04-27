using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CMS.BULayer;
using CMS.UILayer.ClassAssist;

namespace CMS.UILayer.frmWarehouse
{
    public partial class frmSelectGoods : DevExpress.XtraEditors.XtraForm
    {
        #region ��������
        BUCMS_InGoods myBUCMS_InGoods = new BUCMS_InGoods();
        BUCMS_Stock myBUCMS_Stock = new BUCMS_Stock();
        DataTable myDataTable = new DataTable();
        BUCMS_Employee myBUCMS_Employee = new BUCMS_Employee();
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="frmSelectGoods"/> class.
        /// </summary>
        /// �����ˣ������
        /// ����ʱ�䣺2013-02-18
        public frmSelectGoods()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ���cmbTerm�ؼ�ѡ���¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            string paramValue = this.cmbTerm.Text.Trim();
            if (paramValue == "��Ʒ����")
            {
                SelectControl("Name");
            }
            else if(paramValue == "��Ӧ��")
            {
                SelectControl("Supplier");
            }
            else if (paramValue == "������")
            {
                SelectControl("HandlesPeopleID");
            }
            else if (paramValue == "��ˮ��")
            {
                SelectControl("SerialNumber"); 
            }
            else
            {
                SelectControl("InDate");
            }
        }

        /// <summary>
        /// Selects the control.
        /// </summary>
        /// <param name="paramValue">The param value.</param>
        /// �����ˣ������
        /// ����ʱ�䣺2013-02-02
        private void SelectControl(string paramValue)
        {
            switch (paramValue)
            {
                case "InDate": DataControlVisible(true);
                    ComboBoxAndTextBoxVisible(false);
                    break;
                case "Supplier": DataControlVisible(false);
                    ComboBoxAndTextBoxVisible(false);
                    this.txtSupplier.Visible = true;
                    break;
                case "HandlesPeopleID": DataControlVisible(false);
                    ComboBoxAndTextBoxVisible(false);
                    this.btnHandlesPeopleID.Visible = true;
                    break;
                case "SerialNumber": DataControlVisible(false);
                    ComboBoxAndTextBoxVisible(false);
                    this.txtSerialNumber.Visible = true;
                    break;
                default: DataControlVisible(false);
                    ComboBoxAndTextBoxVisible(false);
                    this.txtName.Visible = true;
                    break;
            }
        }

        /// <summary>
        /// Comboes the box and text box visible.
        /// </summary>
        /// <param name="paramBool">if set to <c>true</c> [param bool].</param>
        /// �����ˣ������
        /// ����ʱ�䣺2013-02-02
        private void ComboBoxAndTextBoxVisible(bool paramBool)
        {
            this.txtName.Visible = paramBool;
            this.txtSupplier.Visible = paramBool;
            this.btnHandlesPeopleID.Visible = paramBool;
            this.txtSerialNumber.Visible = paramBool;
        }

        /// <summary>
        /// Datas the control visible.
        /// </summary>
        /// <param name="paramBool">if set to <c>true</c> [param bool].</param>
        /// �����ˣ������
        /// ����ʱ�䣺2013-02-02
        private void DataControlVisible(bool paramBool)
        {
            this.txtStartTime.Visible = paramBool;
            this.labSize.Visible = paramBool;
            this.txtOverTime.Visible = paramBool;
        }

        /// <summary>
        /// ҳ������¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSelectGoods_Load(object sender, EventArgs e)
        {
            //this.lookStockSupplier.Visible = false;
            InitializeControls();
        }

        /// <summary>
        /// Initializes the controls.
        /// </summary>
        /// <remarks></remarks>
        private void InitializeControls()
        {
            BindGridStock();
            BindGridInGoods();
            BindTextValue();
        }

        /// <summary>
        /// �󶨸���ѯ�ؼ���ֵ���Ա��ѯ
        /// </summary>
        /// �����ˣ������
        /// ����ʱ�䣺2013-02-01
        private void BindTextValue()
        {
            try
            {
                myDataTable = myBUCMS_InGoods.GetOrder (false, string.Empty, string.Empty, false);
                CommonOperator.DataBindingLookUpEdit(this.txtName, myDataTable, "Name", "ID", true);

                myDataTable = myBUCMS_InGoods.GetOrder(false, string.Empty, string.Empty, false);
                CommonOperator.DataBindingLookUpEdit(this.txtSerialNumber, myDataTable, "SerialNumber", "ID", true);

                myDataTable = myBUCMS_InGoods.GetOrder(false, string.Empty, string.Empty, false);
                CommonOperator.DataBindingLookUpEdit(this.txtSupplier, myDataTable, "Supplier", "ID", true);

                myDataTable = myBUCMS_Employee.GetOrder(false, string.Empty, string.Empty, false);
                btnHandlesPeopleID.Properties.DataSource = myDataTable;
                CommonOperator.BindLookUpEdit(this.btnHandlesPeopleID, myDataTable, "Name","ID",false, "Ա��");

                myDataTable = myBUCMS_Stock.GetOrder(false, string.Empty, string.Empty, false);
                CommonOperator.DataBindingLookUpEdit(this.lookName, myDataTable, "Name", "ID", true);

                myDataTable = myBUCMS_Stock.GetOrder(false, string.Empty, string.Empty, false);
                CommonOperator.DataBindingLookUpEdit(this.lookStockSupplier, myDataTable, "Supplier", "ID", true);

                myDataTable = myBUCMS_Employee.GetOrder(false, string.Empty, string.Empty, false);
                this.gvLookUpEditHandlesPeopleID.DataSource = myDataTable;

                cmbTerm_SelectedIndexChanged(null, null);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ��gvStock�ؼ���gvInGoods�ؼ�����ҳ�������gvStock�ؼ�����ʾ�������
        /// </summary>
        private void BindGridStock()
        {
            myDataTable = myBUCMS_Stock.GetOrder(false, string.Empty, string.Empty, false);
            foreach (DataRow tempDataRow in myDataTable.Rows)
            {
                int i = Convert.ToInt32(tempDataRow["Number"]);
                decimal j = Convert.ToDecimal(tempDataRow["Price"]);
                tempDataRow["Total"] = Convert.ToDecimal(i * j);
                this.gvStockMain.RefreshData();
            }
            gvStock.DataSource = myDataTable;
        }

        /// <summary>
        /// Binds the grid in goods.
        /// </summary>
        /// �����ˣ������
        /// ����ʱ�䣺2013-02-02
        private void BindGridInGoods()
        {
            myDataTable = myBUCMS_InGoods.GetOrder(false, string.Empty, string.Empty, false);
            foreach (DataRow tempDataRow in myDataTable.Rows)
            {
                int i = Convert.ToInt32(tempDataRow["Number"]);
                decimal j = Convert.ToDecimal(tempDataRow["Price"]);
                tempDataRow["Total"] = Convert.ToDecimal(i * j);
                this.gvInGoodMain.RefreshData();
            }
            gvInGoods.DataSource = myDataTable;
        }

        /// <summary>
        /// ���cmbTermValue�ؼ�ѡ���¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTermValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            string paramValue = this.cmbTermValue.Text.Trim();
            if (paramValue == "��Ʒ����")
            {
                SelectStockControl("Name");
            }
            else
            {
                SelectStockControl("Supplier");
            }
        }

        /// <summary>
        /// Selects the stock control.
        /// </summary>
        /// <param name="paramValue">The param value.</param>
        /// �����ˣ������
        /// ����ʱ�䣺2013-02-02
        private void SelectStockControl(string paramValue)
        {
            switch (paramValue)
            {
                case "Name": DataStockControlVisible(true);
                    StockVisible(false);
                    break;
                default: DataStockControlVisible(false);
                    StockVisible(true);
                    break;
            }
        }

        /// <summary>
        /// Stocks the visible.
        /// </summary>
        /// <param name="paramBool">if set to <c>true</c> [param bool].</param>
        /// �����ˣ������
        /// ����ʱ�䣺2013-02-02
        private void StockVisible(bool paramBool)
        {
            this.lookStockSupplier.Visible = paramBool;
        }

        /// <summary>
        /// Datas the stock control visible.
        /// </summary>
        /// <param name="paramBool">if set to <c>true</c> [param bool].</param>
        /// �����ˣ������
        /// ����ʱ�䣺2013-02-02
        private void DataStockControlVisible(bool paramBool)
        {
            this.lookName.Visible = paramBool;
        }

        /// <summary>
        /// Handles the Click event of the btnSelectInGoods control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnSelectInGoods_Click(object sender, EventArgs e)
        {
            string paramValue = this.cmbTerm.Text.Trim();
            string paramInGoodsValue = string.Empty;
            if (paramValue == "���ʱ��")
            {
                if (txtStartTime.Text == "" || txtOverTime.Text == "")
                {
                    XtraMessageBox.Show("��ʼ�ͽ�ֹʱ�����벻��������������룡");
                    return;
                }
                SelectInGoodsTime();
                return;
            }
            else if (paramValue == "��ˮ��")
            {
                paramInGoodsValue = "SerialNumber";
            }
            else if (paramValue == "��Ӧ��")
            {
                paramInGoodsValue = "Supplier";
            }
            else if (paramValue == "������")
            {
                paramInGoodsValue = "HandlesPeopleID";
            }
            else
            {
                paramInGoodsValue = "Name";
            }
            string TermValue = GetInGoodsCondition(paramValue);
            try
            {
                myDataTable = myBUCMS_InGoods.GetOrder(false, paramInGoodsValue, TermValue, false);
                this.gvInGoods.DataSource = myDataTable;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Gets the in goods condition.
        /// </summary>
        /// <param name="paramValue">The param value.</param>
        /// <returns></returns>
        /// �����ˣ������
        /// ����ʱ�䣺2013-02-02
        private string GetInGoodsCondition(string paramValue)
        {
            string returnValue = string.Empty;
            switch (paramValue)
            {
                case "��Ʒ����": returnValue = this.txtName.Text.Trim();
                    break;
                case "��Ӧ��": returnValue = this.txtSupplier.Text.Trim();
                    break;
                case "������": returnValue = this.btnHandlesPeopleID.EditValue.ToString();
                    break;
                default: returnValue = this.txtSerialNumber.Text.Trim();
                    break;
            }
            return returnValue;
        }

        /// <summary>
        /// �ڶ�������ѯ
        /// </summary>
        /// <param name="paramValue"></param>
        /// <returns></returns>
        private string GetStockCondition(string paramValue)
        {
            string returnValue = string.Empty;
            switch (paramValue)
            {
                case "��Ʒ����":returnValue = this.lookName.Text.Trim();
                    break;
                default: returnValue = this.lookStockSupplier.Text.Trim();
                    break;
            }
            return returnValue;
        }

        /// <summary>
        /// ���ڲ�ѯ
        /// </summary>
        private void SelectInGoodsTime()
        {
            DateTime StartTime = Convert.ToDateTime(this.txtStartTime.Text.Trim());
            DateTime OverTime = Convert.ToDateTime(this.txtOverTime.Text.Trim());
            try
            {
                myDataTable = myBUCMS_InGoods.GetOrder(false, "[InDate]", StartTime, OverTime);
                this.gvInGoods.DataSource = myDataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Handles the Click event of the btnPrint control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// �����ˣ������
        /// ����ʱ�䣺2013-02-02
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                DataOperator.DataPrint(this.gvInGoods, "�����Ϣ",this);
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
        /// �����ˣ������
        /// ����ʱ�䣺2013-02-02
        private void btnOut_Click(object sender, EventArgs e)
        {
            try
            {
                DataOperator.DataOut(this.gvInGoodMain, "�����Ϣ");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the btnStockPrint control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// �����ˣ������
        /// ����ʱ�䣺2013-02-02
        private void btnStockPrint_Click(object sender, EventArgs e)
        {
            try
            {
                DataOperator.DataPrint(this.gvStock, "�����Ϣ",this);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the btnStockOut control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// �����ˣ������
        /// ����ʱ�䣺2013-02-02
        private void btnStockOut_Click(object sender, EventArgs e)
        {
            try
            {
                DataOperator.DataOut(this.gvStockMain, "�����Ϣ");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the BtnDelete control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// �����ˣ������
        /// ����ʱ�䣺2013-02-02
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (this.gvInGoodMain.SelectedRowsCount <= 0)
            {
                XtraMessageBox.Show("��ѡ��Ҫɾ��(&D)����Ŀ", "Υ�����", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                string InGoodID = this.gvInGoodMain.GetFocusedRowCellDisplayText(gcID).ToString();
                DialogResult tempDialogResult = XtraMessageBox.Show("���Ϊ" + InGoodID + "������", "ȷ��ɾ��(&D)��", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == tempDialogResult)
                {
                    VariedEnum.OperatorStatus EnOperatorStatus;
                    try
                    {
                        EnOperatorStatus = myBUCMS_InGoods.Delete(InGoodID);
                        if (CommonOperator.HandleOperatorEnum("ɾ��(&D)�����Ϣ", EnOperatorStatus))
                        {
                            BUT_SysLog.InsertSysLog(VariedEnum.LogType.���ݲ���, frmAssist.frmLogin.SysUser.UserID, "�ɹ�ɾ��(&D)�˱��Ϊ" + InGoodID + "�������Ϣ");
                            BindGridInGoods();
                        }
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message);
                    }
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the btnSelectStock control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// �����ˣ������
        /// ����ʱ�䣺2013-02-02
        private void btnSelectStock_Click(object sender, EventArgs e)
        {
            string paramValue = this.cmbTermValue.Text.Trim();
            string paramStockValue = string.Empty;
            if(paramValue =="��Ʒ����")
            {
                paramStockValue = "[Name]";
            }
            else
            {
                paramStockValue = "[Supplier]";
            }
            string TermValue = GetStockCondition(paramValue);
            try
            {
                myDataTable = myBUCMS_Stock.GetOrder(false, paramStockValue, TermValue, false);
                this.gvStock.DataSource = myDataTable;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the btnStockDelete control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// �����ˣ������
        /// ����ʱ�䣺2013-02-02
        private void btnStockDelete_Click(object sender, EventArgs e)
        {
            if (this.gvStockMain.SelectedRowsCount <= 0)
            {
                XtraMessageBox.Show("��ѡ��Ҫɾ��(&D)����Ŀ", "Υ�����", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                string StockID = this.gvStockMain.GetFocusedRowCellDisplayText(gcStockID).ToString();
                DialogResult tempDialogResult = XtraMessageBox.Show("���Ϊ" + StockID + "������", "ȷ��ɾ��(&D)��", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == tempDialogResult)
                {
                    VariedEnum.OperatorStatus EnOperatorStatus;
                    try
                    {
                        EnOperatorStatus = myBUCMS_Stock.Delete(StockID);
                        if (CommonOperator.HandleOperatorEnum("ɾ��(&D)�����Ϣ", EnOperatorStatus))
                        {
                            BUT_SysLog.InsertSysLog(VariedEnum.LogType.���ݲ���, frmAssist.frmLogin.SysUser.UserID, "�ɹ�ɾ��(&D)�˱��Ϊ" + StockID + "�������Ϣ");
                            BindGridStock();
                        }
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message);
                    }
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the tabGoods control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// �����ˣ������
        /// ����ʱ�䣺2013-02-02
        private void tabGoods_Click(object sender, EventArgs e)
        {
            this.lookName.ItemIndex = 0;
            this.lookStockSupplier.ItemIndex = 0;
        }

        /// <summary>
        /// Handles the Click event of the btnAll control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// �����ˣ������
        /// ����ʱ�䣺2013-02-02
        private void btnAll_Click(object sender, EventArgs e)
        {
            try
            {
                myDataTable = myBUCMS_Stock.GetOrder(false, string.Empty, string.Empty, false);
                this.gvStock.DataSource = myDataTable;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
    }
}