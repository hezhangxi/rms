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

namespace CMS.UILayer.frmFinance
{
    public partial class frmFinanceRegister : DevExpress.XtraEditors.XtraForm
    {
        #region �������
        BUCMS_PaymentsDetail myBUCMS_PaymentsDetail = new BUCMS_PaymentsDetail();
        object[] tempInfo = null;
        #endregion
        public frmFinanceRegister()
        {
            InitializeComponent();
        }

        private void btnFinanceRegisterAdd_Click(object sender, EventArgs e)
        {
            frmFinanceRegisterOperate myfrmFinanceDetailOperate = new frmFinanceRegisterOperate();
            if (myfrmFinanceDetailOperate.ShowDialog() == DialogResult.OK)
                BindGridControl();
        }

        private void btnFinanceRegisterDele_Click(object sender, EventArgs e)
        {
            if (this.gridViewFinanceRegister.SelectedRowsCount <= 0)
            {
                XtraMessageBox.Show("����ѡ��Ҫɾ��(&D)����", "����Υ��",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string tempID = this.gridViewFinanceRegister.GetFocusedRowCellValue("���").ToString();
            DialogResult tempDialogResult = XtraMessageBox.Show("���Ϊ��" + tempID + "�Ĳ����¼",
                "ȷ��ɾ��(&D)", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == tempDialogResult)
            {
                VariedEnum.OperatorStatus EnOperatorStatus;
                try
                {
                    EnOperatorStatus = myBUCMS_PaymentsDetail.Delete(tempID);
                    if (ClassAssist.CommonOperator.HandleOperatorEnum("ɾ��(&D)", EnOperatorStatus))
                    {
                        BUT_SysLog.InsertSysLog(VariedEnum.LogType.ϵͳ�¼�, frmAssist.frmLogin.SysUser.UserID,
                            "�ɹ�ɾ��(&D)�˱��Ϊ��" + tempID + "�Ĳ����¼");
                        BindGridControl();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("��ȷ����������û������ʹ�ú�����", "ɾ��(&D)ʧ��",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnFinanceRegisterAlter_Click(object sender, EventArgs e)
        {
            if (this.gridViewFinanceRegister.SelectedRowsCount <= 0)
            {
                XtraMessageBox.Show("����ѡ��Ҫ�޸�(&U)����", "����Υ��",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            tempInfo = ClassAssist.CommonOperator.GetGVSelectRowInfo(this.gridViewFinanceRegister);
            if (tempInfo != null)
            {
                frmFinanceRegisterOperate myfrmFinanceDetailOperate = new frmFinanceRegisterOperate(tempInfo);
                if (myfrmFinanceDetailOperate.ShowDialog() == DialogResult.OK)
                    BindGridControl();
            }
        }

        private void btnFinanceRegisterOut_Click(object sender, EventArgs e)
        {

        }

        private void btnFinanceRegisterPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnFinanceRegisterBack_Click(object sender, EventArgs e)
        {

        }

        private void frmFinanceRegister_Load(object sender, EventArgs e)
        {
            BindGridControl();
        }

        private void BindGridControl()
        {
            DataTable myDataTable = myBUCMS_PaymentsDetail.GetOrder(true, string.Empty, string.Empty, false);
            this.grdctrlItemManagement.DataSource = myDataTable;
        }

    }
}