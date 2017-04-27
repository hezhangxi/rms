using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CMS.Model;
using CMS.BULayer;

namespace CMS.UILayer.frmWarehouse
{
    public partial class frmAddStock : DevExpress.XtraEditors.XtraForm
    {
        ModelCMS_Stock myModelCMS_Stock = new ModelCMS_Stock();
        BUCMS_Stock myBUCMS_Stock = new BUCMS_Stock();
        public string StockName;
        public string StockSpecifications;
        public string StockInfoNote;
        public int StockNumber;
        public decimal StockPrice;

        public frmAddStock()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.txtName.Text.Trim().Length == 0)
            {
                txtName.ToolTipController = toolTip;
                toolTip.ShowHint("商品名称不能为空！", txtName.PointToScreen(new Point()));
                txtName.Focus();
            }
            else
            {
                StockWrite();
                ReductionTextValue();
                this.DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// 还原个控件的值
        /// </summary>
        private void ReductionTextValue()
        {
            this.txtName.Text = "";
            this.txtSpecifications.Text = "斤";
            this.lbcInfoNote.Text = "暂无";
        }

        //private void AddStock(ModelCMS_Stock myModelCMS_Stock)
        //{
        //    DataTable tempDataTable = myBUCMS_Stock.GetOrder(false, myReturn, myModelCMS_Stock.Name, true);
        //    if (tempDataTable.Rows.Count == 0)
        //    {
        //        VariedEnum.OperatorStatus EnOperatorStatus;
        //        try
        //        {
        //            EnOperatorStatus = myBUCMS_Stock.Insert(myModelCMS_Stock);
        //            if (ClassAssist.CommonOperator.HandleOperatorEnum("商品信息添加", EnOperatorStatus))
        //            {
        //                BUT_SysLog.InsertSysLog(VariedEnum.LogType.数据操作, frmAssist.frmLogin.SysUser.UserID, "成功添加了一条商品信息添加");
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            XtraMessageBox.Show(ex.Message);
        //        }
        //    }
        //    else
        //    {
        //        XtraMessageBox.Show("该商品以存在，请从新输入！");
        //        this.txtStockName.Focus();
        //        this.txtStockName.SelectAll();
        //    }
        //}

        private void StockWrite()
        {
          StockName = this.txtName.Text.Trim();
          StockSpecifications = this.txtSpecifications.Text.Trim();
          StockInfoNote = this.lbcInfoNote.Text.Trim();
          StockNumber = 0;
          StockPrice = 0;
        }
    }
}