using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CMS.UILayer.frmBCarryOut
{
    /// <summary>
    /// Ԥ����Ϣȷ��
    /// </summary>
    /// �����ˣ������
    /// ����ʱ�䣺2013-02-02
    public partial class frmScheduledDeterminee : DevExpress.XtraEditors.XtraForm
    {
        #region ��������
        private DataRow BuffetBookInfo;
        #endregion 

        /// <summary>
        /// Initializes a new instance of the <see cref="frmScheduledDeterminee"/> class.
        /// </summary>
        /// �����ˣ������
        /// ����ʱ�䣺2013-02-02
        public frmScheduledDeterminee()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ԥ����Ϣ���ݼ�
        /// </summary>
        /// <param name="paramBuffetInfo">The param buffet info.</param>
        /// �����ˣ������
        /// ����ʱ�䣺2013-02-02
        public frmScheduledDeterminee(object paramBuffetInfo)
        {
            InitializeComponent();
            if (paramBuffetInfo == null)
                return;
            else
            {
                DataRow tempDataRow = (DataRow)paramBuffetInfo;
                this.BuffetBookInfo = tempDataRow;
            }
        }

        /// <summary>
        /// Handles the Click event of the btnOK control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// �����ˣ������
        /// ����ʱ�䣺2013-02-02
        private void btnOK_Click(object sender, EventArgs e)
        {
            string tempCustomerName = this.txtName.Text.Trim();
            string tempPhone = this.txtPhone.Text.Trim();
            if (tempCustomerName.Length == 0 && tempPhone.Length == 0)
            {
                XtraMessageBox.Show("����������һ������","��Ϣ���벻����",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            else if (this.radioGroupRelation.SelectedIndex == 0)
            {
                if (tempCustomerName == this.BuffetBookInfo["CName"].ToString())
                    this.DialogResult = DialogResult.OK;
                else if (tempPhone == this.BuffetBookInfo["CTelPhone"].ToString())
                    this.DialogResult = DialogResult.OK;
                else
                    XtraMessageBox.Show("Ԥ����Ϣ�������޷�����̨", "��Ǹ,���޷�����̨", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (this.radioGroupRelation.SelectedIndex == 1)
            {
                if (tempCustomerName == this.BuffetBookInfo["CName"].ToString())
                    if (tempPhone == this.BuffetBookInfo["CTelPhone"].ToString())
                        this.DialogResult = DialogResult.OK;
            }
            else
                XtraMessageBox.Show("Ԥ����Ϣ�������޷�����̨", "��Ǹ,���޷�����̨", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}