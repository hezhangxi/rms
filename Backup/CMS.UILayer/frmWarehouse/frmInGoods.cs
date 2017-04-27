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
    /// 商品入库
    /// </summary>
    /// 整理人：桂书丛
    /// 整理时间：2013-02-01
    public partial class frmInGoods : DevExpress.XtraEditors.XtraForm
    {
        #region 实例化类，定义全局变量
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
        /// 货单号
        /// </summary>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-01
        public string StockID;
        /// <summary>
        /// 库存表名称
        /// </summary>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-01
        public string StockName;
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="frmInGoods"/> class.
        /// </summary>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-01
        public frmInGoods()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 保存采购商品信息事件
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-01
        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            if (this.gvAddInGoods.RowCount <= 0)
            {
                XtraMessageBox.Show("商品列表不能为空，请先选择商品！","提示：");
                return;
            }
            SaveInGoods();
        }

        /// <summary>
        /// 保存入库表数据
        /// </summary>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-01
        private void SaveInGoods()
        {
            myDataTable = myBUCMS_InGoods.GetOrder(false, "SerialNumber", StockID, false);
            if (myDataTable.Rows.Count == 0)
            {
                try
                {
                    if (this.txtEmpName.Text.Trim() == "")
                    {
                        XtraMessageBox.Show("请输入接收人信息！");
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
                    if (ClassAssist.CommonOperator.HandleOperatorEnum("商品信息添加", EnOperatorStatus))
                    {
                        BUT_SysLog.InsertSysLog(VariedEnum.LogType.数据操作, frmAssist.frmLogin.SysUser.UserID, "成功添加了一批货单编号为" + myModelCMS_InGoods.SerialNumber + "商品信息");
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
                XtraMessageBox.Show("该流水号已存在，在单击确定之后系统将自动生成新的流水号！");
                GetRandomBillID();
            }
        }

        /// <summary>
        /// Saves the payments detail.
        /// </summary>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-04
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
        /// 保存库存表数据
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
        ///// 清空采购页面所有数据，及frmSelectStock
        ///// </summary>
        //private void ClearText()
        //{
        //    this.txtSpulier.Text = "";
        //    this.txtInfoNote.Text = "";
        //    this.txtSpulier.Text = "暂无";
        //    this.txtInfoNote.Text = "暂无";
        //    for (int i = 0; i < this.gvAddInGoods.RowCount; i++)
        //    {
        //        this.gvAddInGoods.GetDataRow(i).Delete();
        //    }
        //    frmSelectStock.myDataTable.Rows.Clear();
        //}

        /// <summary>
        /// 库存查看事件
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
        /// 商品查找单击事件，查找商品及添加商品信息，并将商品添加到采购清单中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectStock_Click(object sender, EventArgs e)
        {
            SelectStock();
        }

        /// <summary>
        /// 将采购清单中的数据添加到frmInGoods页面的gvInGoods控件中
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
        /// 页面加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmInGoods_Load(object sender, EventArgs e)
        {
            GetRandomBillID();
            BindLookUpEmployee();
        }

        /// <summary>
        /// 获取流水号和入库时间
        /// </summary>
        private void GetRandomBillID()
        {
            this.labSerialNumber.Text = CommonOperator.GetRandomBillID();
            txtInDate.Text = DateTime.Now.ToString();
        }

        /// <summary>
        /// 绑定LookUpEdit控件
        /// </summary>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-01
        private void BindLookUpEmployee()
        {
            try
            {
                myDataTable = myBUCMS_Employee.GetOrder(false, string.Empty, string.Empty, false);
                CommonOperator.DataBindingLookUpEdit(this.txtEmpName, myDataTable, "Name", "ID", true);
                //CommonOperator.BindLookUpEdit(this.txtEmpName, myDataTable, "Name", "ID", false, "员工");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 返回(&B)事件
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
        /// 窗体关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmInGoods_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnOut_Click(sender,e);
        }
    }
}