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
    public partial class frmFinaceOperate : DevExpress.XtraEditors.XtraForm
    {
        BUCMS_PaymentsItem myBUCMS_PaymentsItem = new BUCMS_PaymentsItem();
        int tempID = -5;

        public frmFinaceOperate()
        {
            InitializeComponent();
            this.txtDate.Text = DateTime.Now.ToString();
            this.txtPerson.Text = frmAssist.frmLogin.SysUser.UserName;
        }

        public frmFinaceOperate(object[] paramInfo)
        {
            InitializeComponent();
            FillInfo(paramInfo);
            this.lblPerson.Text = "�޸�(&U)�ˣ�";
            this.lblDate.Text = "�޸�(&U)ʱ�䣺";
            this.txtDate.Text = DateTime.Now.ToString();
            this.txtPerson.Text = frmAssist.frmLogin.SysUser.UserName;
            this.btnSave.Click -= this.btnSave_Click;
            this.btnSave.Click += this.btnRSave_Click;
        }

        private void FillInfo(object[] paramInfo)
        {
            tempID = Convert.ToInt16( paramInfo[0]);
            this.txtName.Text = paramInfo[2].ToString() ;
            this.cmbEditInOutType.Text = paramInfo[1].ToString();
            this.txtInfoNote.Text=paramInfo[3].ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
                return;
            try
            {
                VariedEnum.OperatorStatus EnOperatorStatus;
                EnOperatorStatus = myBUCMS_PaymentsItem.Insert(GetModel());
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
                EnOperatorStatus = myBUCMS_PaymentsItem.Update(GetModel());
                if (ClassAssist.CommonOperator.HandleOperatorEnum("��֧��Ŀ��Ϣ�޸�(&U)", EnOperatorStatus))
                {
                    BUT_SysLog.InsertSysLog(VariedEnum.LogType.���ݲ���, frmAssist.frmLogin.SysUser.UserID, "�ɹ������(&A)��һ����֧��¼");
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private ModelCMS_PaymentsItem GetModel()
        {
            ModelCMS_PaymentsItem tempModelCMS_PaymentsItem = new ModelCMS_PaymentsItem();
            tempModelCMS_PaymentsItem.ID = tempID;
            tempModelCMS_PaymentsItem.Name = this.txtName.Text.Trim();
            tempModelCMS_PaymentsItem.Type = this.cmbEditInOutType.Text.Trim();
            tempModelCMS_PaymentsItem.Description = this.txtInfoNote.Text.Trim();
            tempModelCMS_PaymentsItem.CreatePerson = tempModelCMS_PaymentsItem.ModifyPerson = frmAssist.frmLogin.SysUser.UserName;
            tempModelCMS_PaymentsItem.CreateDate = tempModelCMS_PaymentsItem.CreateDate = DateTime.Now;
            return tempModelCMS_PaymentsItem;
        }

        private bool CheckInput()
        {
            string paramName = this.txtName.Text.Trim();
            DataTable myDT = myBUCMS_PaymentsItem.GetOrder(false,"[Name]",paramName,false);
            if (paramName.Length == 0)
            {
                XtraMessageBox.Show("��Ϣ���벻������", "����", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if(myDT.Rows.Count>0)
            {
                XtraMessageBox.Show("����Ŀ�Ѵ��ڣ����������룡");
                return false;
            }
            return true;
        }

        private void frmFinaceOperate_Load(object sender, EventArgs e)
        {
            //BindComoBox();
            this.cmbEditInOutType.SelectedIndex = 0;
        }

        //private void BindComoBox()
        //{
        //    DataTable myDataTable = new DataTable();
        //    myDataTable = myBUCMS_PaymentsItem.GetOrder(false, string.Empty, string.Empty, false);
        //    for (int i = 0; i < myDataTable.Rows.Count; i++)
        //    {
        //        cmbEditInOutType.Properties.Items.Add(myDataTable.Rows[i]["Type"].ToString());
        //    }
        //    this.cmbEditInOutType.Properties.NullText = "��ѡ�񡭡�";
        //}
    }
}