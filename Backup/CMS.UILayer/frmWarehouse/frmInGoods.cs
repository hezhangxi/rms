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
using CMS.Model;

namespace CMS.UILayer.frmWarehouse
{
    /// <summary>
    /// ��Ʒ���
    /// </summary>
    /// �����ˣ������
    /// ����ʱ�䣺2013-02-01
    public partial class frmInGoods : DevExpress.XtraEditors.XtraForm
    {
        #region ʵ�����࣬����ȫ�ֱ���
        DataTable myDataTable = new DataTable();
        BUCMS_Employee myBUCMS_Employee = new BUCMS_Employee();
        BUCMS_InGoods myBUCMS_InGoods = new BUCMS_InGoods();
        BUCMS_Stock myBUCMS_Stock = new BUCMS_Stock();
        BUCMS_PaymentsDetail myBUCMS_PaymentsDetail = new BUCMS_PaymentsDetail();
        ModelCMS_PaymentsDetail myModelCMS_PaymentsDetail = new ModelCMS_PaymentsDetail();
        ModelCMS_InGoods myModelCMS_InGoods =new ModelCMS_InGoods();
        ModelCMS_Stock myModelCMS_Stock = new ModelCMS_Stock();
        VariedEnum.OperatorStatus EnOperatorStatus;
        public static int I = 0;
        /// <summary>
        /// ������
        /// </summary>
        /// �����ˣ������
        /// ����ʱ�䣺2013-03-01
        public string StockID;
        /// <summary>
        /// ��������
        /// </summary>
        /// �����ˣ������
        /// ����ʱ�䣺2013-03-01
        public string StockName;
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="frmInGoods"/> class.
        /// </summary>
        /// �����ˣ������
        /// ����ʱ�䣺2013-02-01
        public frmInGoods()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ����ɹ���Ʒ��Ϣ�¼�
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// �����ˣ������
        /// ����ʱ�䣺2013-02-01
        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            if (this.gvAddInGoods.RowCount <= 0)
            {
                XtraMessageBox.Show("��Ʒ�б���Ϊ�գ�����ѡ����Ʒ��","��ʾ��");
                return;
            }
            SaveInGoods();
        }

        /// <summary>
        /// ������������
        /// </summary>
        /// �����ˣ������
        /// ����ʱ�䣺2013-02-01
        private void SaveInGoods()
        {
            myDataTable = myBUCMS_InGoods.GetOrder(false, "SerialNumber", StockID, false);
            if (myDataTable.Rows.Count == 0)
            {
                try
                {
                    if (this.txtEmpName.Text.Trim() == "")
                    {
                        XtraMessageBox.Show("�������������Ϣ��");
                        return;
                    }
                    SaveStock();
                    SavePaymentsDetail();
                    for (int i = 0; i < this.gvAddInGoods.RowCount; i++)
                    {
                        myModelCMS_InGoods.SerialNumber = this.labSerialNumber.Text.Trim();
                        myModelCMS_InGoods.Name = this.gvAddInGoods.GetDataRow(i)["GetName"].ToString();
                        myModelCMS_InGoods.Specifications = this.gvAddInGoods.GetDataRow(i)["GetSpecifications"].ToString();
                        myModelCMS_InGoods.Number = Convert.ToInt32(this.gvAddInGoods.GetDataRow(i)["GetNumber"].ToString());
                        myModelCMS_InGoods.Price = Convert.ToDecimal(this.gvAddInGoods.GetDataRow(i)["GetPrice"].ToString());
                        myModelCMS_InGoods.Total = Convert.ToDecimal(this.gvAddInGoods.GetDataRow(i)["GetTotal"].ToString());
                        myModelCMS_InGoods.Supplier = this.cmbSupplier.Text.Trim();
                        myModelCMS_InGoods.InDate = Convert.ToDateTime(this.txtInDate.Text.Trim());
                        myModelCMS_InGoods.HandlesPeopleID = Convert.ToInt32(this.txtEmpName.EditValue.ToString());
                        myModelCMS_InGoods.InfoNote = this.txtInfoNote.Text.Trim();
                        EnOperatorStatus = myBUCMS_InGoods.Insert(myModelCMS_InGoods);
                    } 
                    if (ClassAssist.CommonOperator.HandleOperatorEnum("��Ʒ��Ϣ���", EnOperatorStatus))
                    {
                        BUT_SysLog.InsertSysLog(VariedEnum.LogType.���ݲ���, frmAssist.frmLogin.SysUser.UserID, "�ɹ������һ���������Ϊ" + myModelCMS_InGoods.SerialNumber + "��Ʒ��Ϣ");
                        this.Close();
                        //GetRandomBillID();
                        //ClearText();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.ToString());
                }
            }
            else
            {
                XtraMessageBox.Show("����ˮ���Ѵ��ڣ��ڵ���ȷ��֮��ϵͳ���Զ������µ���ˮ�ţ�");
                GetRandomBillID();
            }
        }

        /// <summary>
        /// Saves the payments detail.
        /// </summary>
        /// �����ˣ������
        /// ����ʱ�䣺2013-02-04
        private void SavePaymentsDetail()
        {
            myDataTable = myBUCMS_PaymentsDetail.GetOrder(false, string.Empty, string.Empty, false);
            for (int i = 0; i < this.gvAddInGoods.RowCount; i++)
            {
                myModelCMS_PaymentsDetail.HandlesPeopleID = Convert.ToInt32(this.txtEmpName.EditValue);
                myModelCMS_PaymentsDetail.Amount = Convert.ToDecimal(this.gvAddInGoods.GetDataRow(i)["GetTotal"].ToString());
                myModelCMS_PaymentsDetail.InfoNote = this.txtInfoNote.Text.Trim();
                EnOperatorStatus = myBUCMS_PaymentsDetail.Insert(myModelCMS_PaymentsDetail);
            }
        }        

        /// <summary>
        /// �����������
        /// </summary>
        private void SaveStock()
        {
            myDataTable = myBUCMS_Stock.GetOrder(false, string.Empty, string.Empty, false);
                try
                {
                    for (int j = 0; j < this.gvAddInGoods.RowCount; j++)
                    {
                        for (int i = 0; i < myDataTable.Rows.Count; i++)
                        {
                            if (this.gvAddInGoods.GetDataRow(j)["GetName"].ToString() == myDataTable.Rows[i]["Name"].ToString())
                            {
                                myModelCMS_Stock.Name = this.gvAddInGoods.GetDataRow(j)["GetName"].ToString();
                                myModelCMS_Stock.Specifications = this.gvAddInGoods.GetDataRow(j)["GetSpecifications"].ToString();
                                myModelCMS_Stock.Price = Convert.ToDecimal(this.gvAddInGoods.GetDataRow(j)["GetPrice"].ToString());
                                myModelCMS_Stock.Total = Convert.ToDecimal(this.gvAddInGoods.GetDataRow(j)["GetTotal"].ToString());
                                myModelCMS_Stock.Number = Convert.ToInt32(myDataTable.Rows[i]["Number"]) + Convert.ToInt32(this.gvAddInGoods.GetDataRow(j)["GetNumber"]);
                                myModelCMS_Stock.Supplier = this.cmbSupplier.Text.Trim();
                                myModelCMS_Stock.InfoNote = this.txtInfoNote.Text.Trim();
                                EnOperatorStatus = myBUCMS_Stock.Update(myModelCMS_Stock);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.ToString());
                }
        }

        ///// <summary>
        ///// ��ղɹ�ҳ���������ݣ���frmSelectStock
        ///// </summary>
        //private void ClearText()
        //{
        //    this.txtSpulier.Text = "";
        //    this.txtInfoNote.Text = "";
        //    this.txtSpulier.Text = "����";
        //    this.txtInfoNote.Text = "����";
        //    for (int i = 0; i < this.gvAddInGoods.RowCount; i++)
        //    {
        //        this.gvAddInGoods.GetDataRow(i).Delete();
        //    }
        //    frmSelectStock.myDataTable.Rows.Clear();
        //}

        /// <summary>
        /// ���鿴�¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            frmSelectGoods mySelectGoods = new frmSelectGoods();
            if (mySelectGoods.ShowDialog() == DialogResult.OK)
            {
                return;
            }
        }

        /// <summary>
        /// ��Ʒ���ҵ����¼���������Ʒ�������Ʒ��Ϣ��������Ʒ��ӵ��ɹ��嵥��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectStock_Click(object sender, EventArgs e)
        {
            SelectStock();
        }

        /// <summary>
        /// ���ɹ��嵥�е�������ӵ�frmInGoodsҳ���gvInGoods�ؼ���
        /// </summary>
        private void SelectStock()
        {
            if (this.labSerialNumber.Text.Trim().ToString() == StockID)
            {
                I = 1;
                frmSelectStock myStock = new frmSelectStock();
                if (myStock.ShowDialog() == DialogResult.OK)
                {
                    myDataTable = frmSelectStock.myDataTable;
                }
                //else
                //{
                //    myDataTable = frmSelectStock.myDataTable;
                //}
                this.gvInGoods.DataSource = myDataTable;
            }
            else
            {
                I = 0;
                StockID = this.labSerialNumber.Text;
                frmSelectStock myStock = new frmSelectStock();
                if (myStock.ShowDialog() == DialogResult.OK)
                {
                    myDataTable = frmSelectStock.myDataTable;
                }
            //    else
            //    {
            //        myDataTable = frmSelectStock.myDataTable;
            //    }
                this.gvInGoods.DataSource = myDataTable;
            }
        }

        /// <summary>
        /// ҳ������¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmInGoods_Load(object sender, EventArgs e)
        {
            GetRandomBillID();
            BindLookUpEmployee();
        }

        /// <summary>
        /// ��ȡ��ˮ�ź����ʱ��
        /// </summary>
        private void GetRandomBillID()
        {
            this.labSerialNumber.Text = CommonOperator.GetRandomBillID();
            txtInDate.Text = DateTime.Now.ToString();
        }

        /// <summary>
        /// ��LookUpEdit�ؼ�
        /// </summary>
        /// �����ˣ������
        /// ����ʱ�䣺2013-02-01
        private void BindLookUpEmployee()
        {
            try
            {
                myDataTable = myBUCMS_Employee.GetOrder(false, string.Empty, string.Empty, false);
                CommonOperator.DataBindingLookUpEdit(this.txtEmpName, myDataTable, "Name", "ID", true);
                //CommonOperator.BindLookUpEdit(this.txtEmpName, myDataTable, "Name", "ID", false, "Ա��");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ����(&B)�¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOut_Click(object sender, EventArgs e)
        {
            frmInGoods.I = 0;
            frmSelectStock.myDataTable.Rows.Clear();
            StockID = string.Empty;
            this.Close();
        }

        /// <summary>
        /// ����ر��¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmInGoods_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnOut_Click(sender,e);
        }
    }
}