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
    public partial class frmFinanceRegisterOperate : DevExpress.XtraEditors.XtraForm
    {
        #region �������
        BUCMS_PaymentsDetail myBUCMS_PaymentsDetail = new BUCMS_PaymentsDetail();
        BUCMS_PaymentsItem myBUCMS_PaymentsItem = new BUCMS_PaymentsItem();
        BUCMS_Employee myBUCMS_Employee = new BUCMS_Employee();
        string paramItemType = null;
        string paramAmount = null;
        int tempID = -5;
        #endregion
        public frmFinanceRegisterOperate()
        {
            InitializeComponent();
            BindLookUpEdit();
            this.txtPerson.Text = frmAssist.frmLogin.SysUser.UserName;
            this.txtDate.Text = DateTime.Now.ToString();
        }

        public frmFinanceRegisterOperate(object[] paramInfo)
        {
            InitializeComponent();
            tempID = Convert.ToInt32(paramInfo[0]);
            this.txtPerson.Text = frmAssist.frmLogin.SysUser.UserName;
            this.txtDate.Text = DateTime.Now.ToString();
            this.lblPerson.Text = "�޸�(&U)�ˣ�";
            this.lblDate.Text = "�޸�(&U)ʱ�䣺";
            this.btnSave.Click -= this.btnSave_Click;
            this.btnSave.Click += this.btnRSave_Click;
            BindLookUpEdit();
            FillInfo(paramInfo);
        }

        private void FillInfo(object[] paramInfo)
        {
            this.EditItemID.Properties.NullText = paramInfo[1].ToString();
            this.txtAmount.Text = paramInfo[3].ToString();             
            this.EditHandlePeopleID.Properties.NullText = paramInfo[4].ToString();
            this.txtInfoNote.Text = paramInfo[5].ToString();
            this.txtPerson.Text = paramInfo[8].ToString();
            this.txtDate.Text = paramInfo[7].ToString();
        }

        private void frmFinanceDetailOperate_Load(object sender, EventArgs e)
        {
            //BindLookUpEdit();
        }

        private void BindLookUpEdit()
        {
            DataTable myDataTable = new DataTable();
            myDataTable = myBUCMS_PaymentsItem.GetOrder(false, string.Empty, string.Empty, false);
            this.EditItemID.Properties.DataSource = myDataTable;
            myDataTable = myBUCMS_Employee.GetOrder(false, string.Empty, string.Empty, false);
            this.EditHandlePeopleID.Properties.DataSource = myDataTable;
            if (!(tempID.Equals(-5)))
            {
                this.EditItemID.ItemIndex = 0;
                this.EditHandlePeopleID.ItemIndex = 0;
            }
            else
            {
                this.EditItemID.Properties.NullText = "��ѡ�񡭡�";
                this.EditHandlePeopleID.Properties.NullText = "��ѡ�񡭡�";
            }
        }

        private ModelCMS_PaymentsDetail GetModel()
        {
            ModelCMS_PaymentsDetail tempModelCMS_PaymentsDetail = new ModelCMS_PaymentsDetail();
            tempModelCMS_PaymentsDetail.ID = tempID;
            tempModelCMS_PaymentsDetail.PaymentTypeID=Convert.ToInt16( this.EditItemID.EditValue);
            tempModelCMS_PaymentsDetail.Amount = Convert.ToInt32(this.txtAmount.Text.Trim());
            tempModelCMS_PaymentsDetail.HandlesPeopleID = Convert.ToInt32(this.EditHandlePeopleID.EditValue);
            tempModelCMS_PaymentsDetail.InfoNote = this.txtInfoNote.Text.Trim();
            tempModelCMS_PaymentsDetail.CreatePerson = tempModelCMS_PaymentsDetail.ModifyPerson = frmAssist.frmLogin.SysUser.UserName;
            tempModelCMS_PaymentsDetail.CreateDate = tempModelCMS_PaymentsDetail.CreateDate = DateTime.Now;
            return tempModelCMS_PaymentsDetail;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
                return;
            try
            {
                VariedEnum.OperatorStatus EnOperatorStatus;
                EnOperatorStatus = myBUCMS_PaymentsDetail.Insert(GetModel());
                if (ClassAssist.CommonOperator.HandleOperatorEnum("��֧��Ŀ��Ϣ���(&A)", EnOperatorStatus))
                {
                    BUT_SysLog.InsertSysLog(VariedEnum.LogType.���ݲ���, frmAssist.frmLogin.SysUser.UserID, "�ɹ������(&A)��һ����֧��Ŀ��Ϣ");
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnRSave_Click(object sender, EventArgs e)
        {
            try
            {
                VariedEnum.OperatorStatus EnOperatorStatus;
                EnOperatorStatus = myBUCMS_PaymentsDetail.Update(GetModel());
                if (ClassAssist.CommonOperator.HandleOperatorEnum("�����¼�޸�(&U)", EnOperatorStatus))
                {
                    BUT_SysLog.InsertSysLog(VariedEnum.LogType.���ݲ���, frmAssist.frmLogin.SysUser.UserID, "�ɹ����޸�(&U)��һ�������¼");
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool CheckInput()
        {
            if (paramItemType == null || paramAmount == null)
            {
                XtraMessageBox.Show("�s^�t��Ϣ���벻������", "����", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditItemID_EditValueChanged(object sender, EventArgs e)
        {
            paramItemType = "True";
        }

        private void txtAmount_EditValueChanged(object sender, EventArgs e)
        {
            paramAmount = "True";
        }
    }
}