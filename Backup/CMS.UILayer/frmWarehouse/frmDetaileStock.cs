using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CMS.UILayer.frmWarehouse
{
    public partial class frmDetaileStock : DevExpress.XtraEditors.XtraForm
    {
        #region ��������
        /// <summary>
        /// ��Ʒ���
        /// </summary>
        /// �����ˣ������
        /// ����ʱ�䣺2013-03-01
        public string StockID = string.Empty;
        /// <summary>
        /// �����Ʒ����
        /// </summary>
        /// �����ˣ������
        /// ����ʱ�䣺2013-03-01
        public string StockName = string.Empty;
        /// <summary>
        /// ��Ʒ����
        /// </summary>
        /// �����ˣ������
        /// ����ʱ�䣺2013-03-01
        public int StockNum = 0;
        /// <summary>
        /// ��Ʒ����
        /// </summary>
        /// �����ˣ������
        /// ����ʱ�䣺2013-03-01
        public decimal StockPrice;
        #endregion 

        /// <summary>
        /// Initializes a new instance of the <see cref="frmDetaileStock"/> class.
        /// </summary>
        /// �����ˣ������
        /// ����ʱ�䣺2013-02-01
        public frmDetaileStock()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="frmDetaileStock"/> class.
        /// </summary>
        /// <param name="paramID">The param ID.</param>
        /// <param name="paramName">Name of the param.</param>
        /// �����ˣ������
        /// ����ʱ�䣺2013-02-01
        public frmDetaileStock(string paramID,string paramName)
        {
            InitializeComponent();
            this.txtName.Text = paramName;
            this.txtNumber.Value = 1;
            this.txtNumber.Focus();
            StockID = paramID;
        }

        /// <summary>
        /// Handles the Click event of the btnEnter control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// �����ˣ������
        /// ����ʱ�䣺2013-02-01
        private void btnEnter_Click(object sender, EventArgs e)
        {
            StockName = this.txtName.Text.Trim();
            StockNum = Convert.ToInt32(txtNumber.Value);
            StockPrice = Convert.ToDecimal(txtPrice.Value);
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Handles the Click event of the btnCancel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// �����ˣ������
        /// ����ʱ�䣺2013-02-01
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}