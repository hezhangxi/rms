using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using CMS.BULayer;
using DevExpress.XtraEditors;

namespace CMS.UILayer.frmFinance
{
    public partial class frmInOutItemManagement : DevExpress.XtraEditors.XtraForm
    {
        #region ��������
        DataTable myDataTable = new DataTable();
        BUCMS_PaymentsItem myBUCMS_PaymentsItem = new BUCMS_PaymentsItem();
        object[] tempInfo = null;
        #endregion
        public frmInOutItemManagement()
        {
            InitializeComponent();
        }

        private void btneInOutItemAdd_Click(object sender, EventArgs e)
        {
            frmFinaceOperate myfrmFinaceOperate = new frmFinaceOperate();
            if (myfrmFinaceOperate.ShowDialog() == DialogResult.OK)
                BindGridControl();
        }

        private void btnInOutItemDele_Click(object sender, EventArgs e)
        {
            if (this.gridViewInOutItemInfo.SelectedRowsCount <= 0)
            {
                XtraMessageBox.Show("����ѡ��Ҫɾ��(&D)����", "����Υ��",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string tempID = this.gridViewInOutItemInfo.GetFocusedRowCellValue("ID").ToString();
            DialogResult tempDialogResult = XtraMessageBox.Show("���Ϊ��" + tempID + "����Ŀ��Ϣ",
                "ȷ��ɾ��(&D)", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == tempDialogResult)
            {
                VariedEnum.OperatorStatus EnOperatorStatus;
                try
                {
                    EnOperatorStatus = myBUCMS_PaymentsItem.Delete(tempID);
                    if (ClassAssist.CommonOperator.HandleOperatorEnum("ɾ��(&D)", EnOperatorStatus))
                    {
                        BUT_SysLog.InsertSysLog(VariedEnum.LogType.ϵͳ�¼�, frmAssist.frmLogin.SysUser.UserID,
                            "�ɹ�ɾ��(&D)�˱��Ϊ��" + tempID + "����Ŀ��Ϣ");
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

        private void btnInOutItemAlter_Click(object sender, EventArgs e)
        {
            if (this.gridViewInOutItemInfo.SelectedRowsCount <= 0)
            {
                XtraMessageBox.Show("����ѡ��Ҫ�޸�(&U)����", "����Υ��",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            tempInfo = ClassAssist.CommonOperator.GetGVSelectRowInfo(this.gridViewInOutItemInfo);
            if (tempInfo != null)
            {
                frmFinaceOperate myfrmFinaceOperate = new frmFinaceOperate(tempInfo);
                if (myfrmFinaceOperate.ShowDialog() == DialogResult.OK)
                    BindGridControl();
            }
        }

        private void btnInOutItemOut_Click(object sender, EventArgs e)
        {
            try
            {
                ClassAssist.DataOperator.DataOut(this.gridViewInOutItemInfo,"��֧��Ŀ��Ϣ");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }

        private void btnInOutItemPrint_Click(object sender, EventArgs e)
        {
            try
            {
                ClassAssist.DataOperator.DataPrint(this.grdctrlInOutItemInfo, "��֧��Ŀ��Ϣ",null);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }

        private void frmInOutItemManagement_Load(object sender, EventArgs e)
        {
            BindGridControl();        
        }

        private void BindGridControl()
        {
            myDataTable = myBUCMS_PaymentsItem.GetOrder(false, string.Empty, string.Empty, false);
            if (myDataTable.Rows.Count < 0)
                return;
            else
                this.grdctrlInOutItemInfo.DataSource = myDataTable;
        }
    }
}