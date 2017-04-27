using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using CMS.BULayer;

namespace CMS.UILayer.frmFinance
{
    public partial class frmInOutDetail : DevExpress.XtraEditors.XtraForm
    {
        #region **********************�������******************************
        BUCMS_PaymentsItem myBUCMS_PaymentsItem = new BUCMS_PaymentsItem();
        BUCMS_PaymentsDetail myBUCMS_PaymentsDetail = new BUCMS_PaymentsDetail();
        BUCMS_Employee myBUCMS_Employee = new BUCMS_Employee();
        BUT_User myBUT_User = new BUT_User();
        #endregion

        #region public frmInOutDetail() Initializes a new instance
        /// <summary>
        /// Initializes a new instance of the <see cref="frmInOutDetail"/> class.
        /// </summary>
        /// <remarks></remarks>
        public frmInOutDetail()
        {
            InitializeComponent();
        }
        #endregion 

        #region frmFinanceInOutDetail_Load Handles the Load
        /// <summary>
        /// Handles the Load event of the frmFinanceInOutDetail control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void frmFinanceInOutDetail_Load(object sender, EventArgs e)
        {
            BindGridControl();
            this.cmbSelectCondition.SelectedIndex = 0;
            VisibleOrNot1(false);
            this.txtNumAndAmount.Visible = true;
            this.dateEditCStart.Text = this.dateEditCEnd.Text = DateTime.Now.ToString();
        }
        #endregion

        #region private void BindGridControl() Binds the grid control.
        /// <summary>
        /// Binds the grid control.
        /// </summary>
        /// <remarks></remarks>
        private void BindGridControl()
        {
            DataTable myDataTable = myBUCMS_PaymentsDetail.GetOrder(true, string.Empty, string.Empty, false);
            this.grdctrInOutDetail.DataSource = myDataTable;
        }
        #endregion

        #region private void BindMruEdit() ��Ŀ���Ͱ�
        /// <summary>
        /// ��Ŀ���Ͱ�
        /// </summary>
        /// <remarks></remarks>
        private void BindMruEdit()
        {
            DataTable myDataTable = new DataTable();
            myDataTable = myBUCMS_PaymentsItem.GetOrder(false, string.Empty, string.Empty, false);
            for (int i = 0; i < myDataTable.Rows.Count; i++)
            {
                mruEditType.Properties.Items.Add(myDataTable.Rows[i]["Type"].ToString());
            }
            this.mruEditType.SelectedIndex = 1;
        }
        #endregion

        #region private void BindLookUpEditName() �������ݰ�
        /// <summary>
        /// �������ݰ�
        /// </summary>
        /// <remarks></remarks>
        private void BindLookUpEditName()
        {
            this.EditSecSelcCondition.Properties.Items.Clear();
            DataTable myDataTable = myBUCMS_PaymentsItem.GetOrder(false, string.Empty, string.Empty, false);
            for (int i = 0; i < myDataTable.Rows.Count; i++)
            {
                this.EditSecSelcCondition.Properties.Items.Add(myDataTable.Rows[i]["Name"].ToString());
            }
            this.EditSecSelcCondition.SelectedIndex = 0;
        }
        #endregion

        #region private void BindLookUpEditHandlePeople() ���������ݰ�
        /// <summary>
        /// ���������ݰ�
        /// </summary>
        /// <remarks></remarks>
        private void BindLookUpEditHandlePeople()
        {
            this.EditSecSelcCondition.Properties.Items.Clear();
            DataTable myDT = myBUCMS_Employee.GetOrder(false, string.Empty, string.Empty, false);
            for (int i = 0; i < myDT.Rows.Count; i++)
            {
                this.EditSecSelcCondition.Properties.Items.Add(myDT.Rows[i]["Name"].ToString());
            }
            this.EditSecSelcCondition.SelectedIndex = 0;
        }
        #endregion

        #region private void BindLookUpEditCreatePerson() ���������ݰ�
        /// <summary>
        /// ���������ݰ�
        /// </summary>
        /// <remarks></remarks>
        private void BindLookUpEditCreatePerson()
        {
            this.EditSecSelcCondition.Properties.Items.Clear();
            DataTable myDataTable = myBUT_User.GetAllUserInfo();
            for (int i = 0; i < myDataTable.Rows.Count; i++)
            {
                this.EditSecSelcCondition.Properties.Items.Add(myDataTable.Rows[i]["USERNAME"].ToString());
            }
            this.EditSecSelcCondition.SelectedIndex = 0;
        }
        #endregion

        #region private void BindLookUpEdit(string paramFirstSelection) LookUpEdit�����ݰ�
        /// <summary>
        /// LookUpEdit�����ݰ�
        /// </summary>
        /// <param name="paramFirstSelection">The param first selection.</param>
        /// <remarks></remarks>
        private void BindLookUpEdit(string paramFirstSelection)
        {
            DataTable myDataTable = new DataTable();
            switch (paramFirstSelection)
                {
                    case "Name":
                        BindLookUpEditName();
                        break;
                    case "HandlePeople":
                        BindLookUpEditHandlePeople();
                        break;
                    case "CreatePerson":
                        BindLookUpEditCreatePerson();
                        break;
                    default :
                        break;
                }
        }
        #endregion

        #region mruEditType_SelectedIndexChanged ��֧���͵�SelectedIndexChanged�¼�
        /// <summary>
        /// ��֧���͵�SelectedIndexChanged�¼�
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void mruEditType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string paramType = this.mruEditType.Text;
            DataTable myDataTable = myBUCMS_PaymentsDetail.GetOrder(true,"����",paramType,false);
            this.grdctrInOutDetail.DataSource = myDataTable;
        }
        #endregion 

        #region private void btnSelectAll_Click(object sender, EventArgs e) ��ѯȫ����ť�ĵ����¼�
        /// <summary>
        /// ��ѯȫ���ĵ����¼�
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            BindGridControl();
        }
        #endregion

        #region private string GetCondition(string paramField) ��õڶ���ѯ����
        /// <summary>
        /// ��õڶ���ѯ����
        /// </summary>
        /// <param name="paramField"></param>
        /// <returns></returns>
        private string GetCondition(string paramField)
        {
            string returnStringConditon = string.Empty;
            switch (paramField)
            {
                case "���": returnStringConditon = this.txtNumAndAmount.Text.ToString();
                    break;
                case "����": returnStringConditon = this.mruEditType.Text.ToString();
                    break;
                case "���": returnStringConditon = this.txtNumAndAmount.Text.ToString();
                    break;
                default: returnStringConditon = this.EditSecSelcCondition.Text.Trim();
                    break;
            }
            return returnStringConditon;
        }
        #endregion

        #region btnSelect_Click ��ѯ��ť�ĵ����¼�
        /// <summary>
        /// ��ѯ��ť�ĵ����¼�
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            string tempStringField = this.cmbSelectCondition.Text.Trim();
            if (tempStringField == "����ʱ��")
            {
                DateQuery();
                return;
            }
            string tempStringCondition = GetCondition(tempStringField);
            try
            {
                DataTable myDataTable = myBUCMS_PaymentsDetail.GetOrder(true, tempStringField, tempStringCondition, false);
                this.grdctrInOutDetail.DataSource = myDataTable;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region private int DateDiff �����������ڵ�ʱ����,����(&B)����֮����������(paramDateTime1-paramDateTime2)
        /// <summary>
        /// �����������ڵ�ʱ����,����(&B)����֮����������(paramDateTime1-paramDateTime2)
        /// </summary>
        /// <param name="paramDateTime1">The param date time1.</param>
        /// <param name="paramDateTime2">The param date time2.</param>
        /// <returns></returns>
        private int DateDiff(DateTime paramDateTime1, DateTime paramDateTime2)
        {
            int dateDiff = -5;
            TimeSpan ts1 = new TimeSpan(paramDateTime1.Ticks);
            TimeSpan ts2 = new TimeSpan(paramDateTime2.Ticks);
            TimeSpan ts = ts1.Subtract(ts2);
            dateDiff = ts.Days;       
            return dateDiff;
        }
        #endregion

        #region dateEditCEnd_EditValueChanged ����ʱ��EditValueChanged�¼�
        /// <summary>
        /// ����ʱ��EditValueChanged�¼�
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void dateEditCEnd_EditValueChanged(object sender, EventArgs e)
        {
            string tempDateTime = this.dateEditCEnd.Text ;
            DateTime tempOver=Convert.ToDateTime(tempDateTime);
            if (DateDiff(DateTime.Now, tempOver) < 0)
            {
                XtraMessageBox.Show("����ʱ�����С�ڵ�ǰʱ��", "��Ϣ���벻��ȷ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.dateEditCEnd.EditValue = DateTime.Now;
            }
        }
        #endregion

        #region private void DateQuery() ����ʱ���ѯ
        /// <summary>
        /// ���ڲ�ѯ
        /// </summary>
        private void DateQuery()
        {
            string tempDateTimeStart = this.dateEditCStart.Text.Trim();
            string tempDateTimeEnd = this.dateEditCEnd.Text.Trim();
            try
            {
                DataTable myDataTable = myBUCMS_PaymentsDetail.GetOrder(true, "[����ʱ��]", tempDateTimeEnd,true );
                this.grdctrInOutDetail.DataSource = myDataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region private void cmbSelectCondition_SelectedIndexChanged(object sender, EventArgs e)��һ����ѡ��ı�
        /// <summary>
        /// ��һ����ѡ��ı�
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void cmbSelectCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            string paramSelectCondition = this.cmbSelectCondition.Text.Trim();
            if (paramSelectCondition == "���")
            {
                BoolValue("ID");
                return;
            }
            if (paramSelectCondition == "����")
            {
                BoolValue("Name");
                BindLookUpEdit("Name");
                return;
            }
            if (paramSelectCondition == "����")
            {
                BoolValue("Type");
                BindMruEdit();
                return;
            }
            if (paramSelectCondition == "���")
            {
                BoolValue("Amount");
                return;
            }
            if (paramSelectCondition == "������")
            {
                BoolValue("HandlePeople");
                BindLookUpEdit("HandlePeople");
                return;
            }
            if (paramSelectCondition == "������")
            {
                BoolValue("CreatePerson");
                BindLookUpEdit("CreatePerson");
                return;
            }
            if (paramSelectCondition == "����ʱ��")
            {
                BoolValue("CreateDate");
                return;
            }
        }
        #endregion

        #region private void BoolValue(string paramBoolValue) ��ʼ����ѯ�ؼ�
        /// <summary>
        /// ��ʼ����ѯ�ؼ�
        /// </summary>
        /// <param name="paramBoolValue">T�ڶ������ؼ�ѡ��</param>
        /// <remarks></remarks>
        private void BoolValue(string paramBoolValue)
        {
            switch (paramBoolValue)
            {
                case "ID": VisibleOrNot2(false);
                    this.mruEditType.Visible = false;
                    this.txtNumAndAmount.Visible = true;
                    break;
                case "Name": VisibleOrNot1(false);
                    this.EditSecSelcCondition.Visible = true;
                    break;
                case "Type": VisibleOrNot2(false);
                    this.txtNumAndAmount.Visible = false;
                    this.mruEditType.Visible = true;
                    break;
                case "Amount": VisibleOrNot2(false);
                    this.mruEditType.Visible = false;
                    this.txtNumAndAmount.Visible = true;
                    break;
                case "HandlePeople": VisibleOrNot1(false);
                    this.EditSecSelcCondition.Visible = true;
                    break;
                case "CreatePerson": VisibleOrNot1(false);
                    this.EditSecSelcCondition.Visible = true;
                    break;
                case "CreateDate": VisibleOrNot3(false);
                    this.dateEditCStart.Visible = true;
                    this.dateEditCEnd.Visible = true;
                    this.lblCome.Visible = true;
                    break;
                default :
                    VisibleOrNot1(false);
                    break;
            }

        }
        #endregion

        #region private void VisibleOrNot3(bool paramBool)���ݲ����������͡�����š��ڶ�����ѡ��Ŀ���״̬
        /// <summary>
        /// ���ݲ����������͡�����š��ڶ�����ѡ��Ŀ���״̬
        /// </summary>
        /// <param name="paramBool">�Ƿ���� <c>true</c> [param bool].</param>
        /// <remarks></remarks>
        private void VisibleOrNot3(bool paramBool)
        {
            this.EditSecSelcCondition.Visible = paramBool;
            this.mruEditType.Visible = paramBool;
            this.txtNumAndAmount.Visible = paramBool;
        }
        #endregion

        #region private void VisibleOrNot2(bool paramBool)���ݲ������õڶ�����ѡ�񡢿�ʼʱ�䡢����ʱ�䡢Label��ǩ�Ŀ���״̬
        /// <summary>
        /// ���ݲ������õڶ�����ѡ�񡢿�ʼʱ�䡢����ʱ�䡢Label��ǩ�Ŀ���״̬
        /// </summary>
        /// <param name="paramBool">�Ƿ���� <c>true</c> [param bool].</param>
        /// <remarks></remarks>
        private void VisibleOrNot2(bool paramBool)
        {
            this.EditSecSelcCondition.Visible = paramBool;
            this.dateEditCStart.Visible = paramBool;
            this.dateEditCEnd.Visible = paramBool;
            this.lblCome.Visible = paramBool;
        }
        #endregion

        #region private void VisibleOrNot1(bool paramBool)���ݲ����������͡�����š���ʼʱ�䡢����ʱ�䡢Label��ǩ�Ŀ���״̬
        /// <summary>
        /// ���ݲ����������͡�����š���ʼʱ�䡢����ʱ�䡢Label��ǩ�Ŀ���״̬
        /// </summary>
        /// <param name="paramBool">�Ƿ���� <c>true</c> [param bool].</param>
        /// <remarks></remarks>
        private void VisibleOrNot1(bool paramBool)
        {
            this.mruEditType.Visible = paramBool;
            this.dateEditCStart.Visible = paramBool;
            this.txtNumAndAmount.Visible = paramBool;
            this.lblCome.Visible = paramBool;
            this.dateEditCEnd.Visible = paramBool;
        }
        #endregion

        #region txtNumAndAmount_EditValueChanged ����Ų�ѯ
        /// <summary>
        /// ����Ų�ѯ
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void txtNumAndAmount_EditValueChanged(object sender, EventArgs e)
        {
            string tempStringField = this.cmbSelectCondition.Text.Trim();
            if (!tempStringField.Equals("���"))
            {
                return;
            }
            string tempStringCondition = this.txtNumAndAmount.Text.Trim();
            try
            {
                DataTable myDataTable = myBUCMS_PaymentsDetail.GetOrder(true, tempStringField, tempStringCondition, true);
                this.grdctrInOutDetail.DataSource = myDataTable;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region btnPrint_Click ��ӡ(&P)��ť�ĵ����¼�
        /// <summary>
        /// ��ӡ(&P)��ť�ĵ����¼�
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                ClassAssist.DataOperator.DataPrint(this.grdctrInOutDetail, "��֧��ϸ��Ϣ",null);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region btnOut_Click ��ӡ(&P)��ť�ĵ����¼�
        /// <summary>
        /// ��ӡ(&P)��ť�ĵ����¼�
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnOut_Click(object sender, EventArgs e)
        {
            try
            {
                ClassAssist.DataOperator.DataOut(this.gridViewInOutDetail, "��֧��ϸ��Ϣ");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        #endregion

        


    }
}