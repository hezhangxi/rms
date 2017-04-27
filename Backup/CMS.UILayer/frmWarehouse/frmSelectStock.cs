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

namespace CMS.UILayer.frmWarehouse
{
    public partial class frmSelectStock : DevExpress.XtraEditors.XtraForm
    {
        #region ��������
        BUCMS_Stock myBUCMS_Stock = new BUCMS_Stock();
        ModelCMS_Stock myModelCMS_Stock = new ModelCMS_Stock();
        BUCMS_InGoods myBUCMS_InGoods = new BUCMS_InGoods();
        frmAddStock myfrmAddStock = new frmAddStock();
        public static DataTable myDataTable = new DataTable();
        private string myReturn = "[Name]";
        private string returnID;
        private string returnName;
        private int returnNumber;
        private decimal returnPrice;
        private string returnSpecifications;
        int i = frmInGoods.I;
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="frmSelectStock"/> class.
        /// </summary>
        /// �����ˣ������
        /// �������ڣ�2013-2-1
        public frmSelectStock()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the ButtonClick event of the txtName control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraEditors.Controls.ButtonPressedEventArgs"/> instance containing the event data.</param>
        /// �����ˣ������
        /// �������ڣ�2013-2-1
        private void txtName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (myfrmAddStock.ShowDialog() == DialogResult.OK)
            {
                AddStock(GetStockValue());
            }
        }

        /// <summary>
        /// Gets the stock value.
        /// </summary>
        /// <returns></returns>
        /// �����ˣ������
        /// �������ڣ�2013-2-1
        public ModelCMS_Stock GetStockValue()
        {
            myModelCMS_Stock.Name = myfrmAddStock.StockName;
            myModelCMS_Stock.Specifications = myfrmAddStock.StockSpecifications;
            myModelCMS_Stock.InfoNote = myfrmAddStock.StockInfoNote;
            myModelCMS_Stock.Number = Convert.ToInt32(myfrmAddStock.StockNumber);
            myModelCMS_Stock.Price = Convert.ToDecimal(myfrmAddStock.StockPrice);
            return myModelCMS_Stock;
        }
        /// <summary>
        /// ��ӿ����Ʒ
        /// </summary>
        /// <param name="myModelCMS_Stock"></param>
        private void AddStock(ModelCMS_Stock myModelCMS_Stock)
        {
            DataTable tempDataTable = myBUCMS_Stock.GetOrder(false, myReturn, myModelCMS_Stock.Name, true);
            if (tempDataTable.Rows.Count == 0)
            {
                VariedEnum.OperatorStatus EnOperatorStatus;
                try
                {
                    EnOperatorStatus = myBUCMS_Stock.Insert(myModelCMS_Stock);
                    if (ClassAssist.CommonOperator.HandleOperatorEnum("��Ʒ��Ϣ���", EnOperatorStatus))
                    {
                        BindGridView();
                        BUT_SysLog.InsertSysLog(VariedEnum.LogType.���ݲ���, frmAssist.frmLogin.SysUser.UserID, "�ɹ������һ����Ʒ��Ϣ");
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.ToString());
                }
            }
            else
            {
                XtraMessageBox.Show("����Ʒ�Ѵ��ڣ����������룡","��ʾ��");
                this.txtStockName.Focus();
                this.txtStockName.SelectAll();
            }
        }

        /// <summary>
        /// ��ѯ������ݣ�����gvStock�ؼ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            string myValue = this.txtStockName.Text.Trim();
            if (myValue.Trim() == "")
            {
                BindGridView();
            }
            else     
            {
                BindGridView(myValue);       
            }
        }

        /// <summary>
        /// ������ѯ
        /// </summary>
        /// <param name="myValue"></param>
        private void BindGridView(string myValue)
        {
            this.gvStock.DataSource = myBUCMS_Stock.GetOrder(false, myReturn, myValue, true);
        }

        /// <summary>
        /// ȫ����ѯ
        /// </summary>
        private void BindGridView()
        {
            BindGridStock();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.gvAddInventory.RowCount == 0)
            {
                XtraMessageBox.Show("�嵥����Ϊ�գ���ɹ���Ʒ��");
                return;
            }
            else
            {
                GetSave();
                this.DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void GetSave()
        {
            myDataTable = (this.gvInventory.DataSource as DataTable);
        }

        /// <summary>
        /// ���嵥
        /// </summary>
        private void AddBindInventory()
        {
            if (this.gvAddStock.SelectedRowsCount == 0)
            {
                XtraMessageBox.Show("��ѡ��Ҫ�ɹ�����Ʒ��","��ʾ��");
                return;
            }
            string paramID = this.gvAddStock.GetFocusedRowCellValue(gcID).ToString();
            string paramName = this.gvAddStock.GetFocusedRowCellValue(gcName).ToString();
            frmDetaileStock myfrmDetaileStock = new frmDetaileStock(paramID, paramName);
            if (myfrmDetaileStock.ShowDialog() == DialogResult.OK)
            {
                this.returnID = myfrmDetaileStock.StockID;
                this.returnName = myfrmDetaileStock.StockName;
                this.returnNumber = myfrmDetaileStock.StockNum;
                this.returnPrice = myfrmDetaileStock.StockPrice;
                //this.returnSpecifications = myModelCMS_Stock.Specifications;
                GetInventory();
            }
        }

        /// <summary>
        /// ����Ʒ��Ӳɹ��嵥��
        /// </summary>
        private void GetInventory()
        {
            try
            {
                DataTable tempDataTable = this.gvInventory.DataSource as DataTable;
                if (tempDataTable != null)
                    foreach (DataRow tempDataRow in tempDataTable.Rows)
                    {
                        if (tempDataRow["GetName"].ToString() == returnName)
                        {
                            tempDataRow["GetNumber"] = Convert.ToInt32(tempDataRow["GetNumber"]) + returnNumber;
                            //int i = Convert.ToInt32(tempDataRow["GetNumber"]);
                            //int j = Convert.ToInt32(returnPrice);
                            //tempDataRow["GetPrice"] = Convert.ToDecimal(i * j);
                            tempDataRow["GetPrice"] = returnPrice;
                            tempDataRow["GetTotal"] = Convert.ToDecimal(Convert.ToDecimal(tempDataRow["GetNumber"]) * Convert.ToDecimal(tempDataRow["GetPrice"]));
                            //tempDataRow["GetPrice"] = Convert.ToDecimal(Convert.ToInt32(tempDataRow["GetNumber"]) * Convert.ToInt32(tempDataRow["GetPrice"]) + returnPrice);
                            this.gvAddInventory.RefreshData();
                            return;
                        }
                    }
                returnSpecifications = this.gvAddStock.GetFocusedRowCellValue(gcSpecifications).ToString();
                DataRow myDataRow;
                myDataRow = myDataTable.NewRow();
                myDataRow["GetName"] = returnName;
                myDataRow["GetNumber"] = returnNumber;
                myDataRow["GetSpecifications"] = returnSpecifications; 
                myDataRow["GetPrice"] = returnPrice;
                myDataRow["GetTotal"] = Convert.ToDecimal(returnNumber * returnPrice);
                myDataTable.Rows.Add(myDataRow);
                this.gvInventory.DataSource = myDataTable;
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ҳ������¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmStock_Load(object sender, EventArgs e)
        {
            if (i == 1)
            {
                this.gvInventory.DataSource = myDataTable;
                return;
            }
            if (myDataTable.Columns.Count < 4)
            {
                myDataTable.Columns.Add("GetName");
                myDataTable.Columns.Add("GetNumber",typeof(System.Int32));
                myDataTable.Columns.Add("GetSpecifications");
                myDataTable.Columns.Add("GetPrice", typeof(System.Decimal));
                myDataTable.Columns.Add("GetTotal", typeof(System.Decimal));
            }
            BindGridView();
        }

        /// <summary>
        /// ��gvInGoods�ؼ�
        /// </summary>
        /// �����ˣ������
        /// ����ʱ�䣺2013-02-01
        private void BindGridStock()
        {
            try
            {
                DataTable tempDataTable = myBUCMS_Stock.GetOrder(false, string.Empty, string.Empty, false);
                this.gvStock.DataSource = tempDataTable;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Handles the Click event of the btnAddition control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnAddition_Click(object sender, EventArgs e)
        {
            AddBindInventory();
        }

        /// <summary>
        /// Handles the Click event of the btnDelect control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnDelect_Click(object sender, EventArgs e)
        {
            if (this.gvAddInventory.RowCount == 0)
            {
                XtraMessageBox.Show("���ڲɹ��嵥��ѡ��Ҫ�Ƴ������ݣ�");
                return;
            }
            else
            {
                if ((XtraMessageBox.Show("�Ƿ��Ƴ�������", "ϵͳ��ʾ", MessageBoxButtons.YesNo,MessageBoxIcon.Question)) == DialogResult.No)
                {
                    return;
                }
                DeleteInventory();
            }
        }

        /// <summary>
        /// Handles the Click event of the btnReturn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteInventory()
        {
            this.gvAddInventory.DeleteSelectedRows();
        }

        private void gvAddStock_DoubleClick(object sender, EventArgs e)
        {
            AddBindInventory();
        }
    }
}