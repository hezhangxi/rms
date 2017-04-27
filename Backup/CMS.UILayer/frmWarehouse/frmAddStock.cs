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
                toolTip.ShowHint("��Ʒ���Ʋ���Ϊ�գ�", txtName.PointToScreen(new Point()));
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
        /// ��ԭ���ؼ���ֵ
        /// </summary>
        private void ReductionTextValue()
        {
            this.txtName.Text = "";
            this.txtSpecifications.Text = "��";
            this.lbcInfoNote.Text = "����";
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
        //            if (ClassAssist.CommonOperator.HandleOperatorEnum("��Ʒ��Ϣ���", EnOperatorStatus))
        //            {
        //                BUT_SysLog.InsertSysLog(VariedEnum.LogType.���ݲ���, frmAssist.frmLogin.SysUser.UserID, "�ɹ������һ����Ʒ��Ϣ���");
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            XtraMessageBox.Show(ex.Message);
        //        }
        //    }
        //    else
        //    {
        //        XtraMessageBox.Show("����Ʒ�Դ��ڣ���������룡");
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