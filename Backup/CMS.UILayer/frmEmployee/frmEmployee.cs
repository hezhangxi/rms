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
using System.IO;
using DevExpress.XtraGrid.Views.Layout.ViewInfo;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Base;

namespace CMS.UILayer.frmEmployee
{
    public partial class frmEmployee : DevExpress.XtraEditors.XtraForm
    {
        BUCMS_Employee myBUCMS_Employee = new BUCMS_Employee();
        BUCMS_DPInfo myBUCMS_DPInfo = new BUCMS_DPInfo();
        frmAddEmployee myfrmAddEmployee;
        DataTable myDataTable = new DataTable();
        VariedEnum.OperatorStatus EnOperatorStatus;
        private static string paramID;
        string strHideExtendedMode = "�б�";
        string strShowExtendedMode = "��ϸ��Ϣ";
        bool fExtendedEditMode = false;
        //bool allowEditOnDoubleClickCore;
        public frmEmployee()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ��������¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEmployee_Load(object sender, EventArgs e)
        {
            BindGvEmployee();
            BindGvEmployeeView();
            BindTextValue();
        }

        /// <summary>
        /// �󶨸��ı����ֵ
        /// </summary>
        private void BindTextValue()
        {
            myDataTable = myBUCMS_Employee.GetOrder(false, string.Empty, string.Empty, false);
            CommonOperator.DataBindingLookUpEdit(this.txtName, myDataTable, "Name", "ID", true);

            myDataTable = myBUCMS_DPInfo.GetOrder(false, "SubID", "0", false);
            CommonOperator.DataBindingLookUpEdit(this.txtDPInfo, myDataTable, "Name", "ID", true);

            myDataTable = myBUCMS_DPInfo.GetOrder(false, "SubID", "1", false);
            CommonOperator.DataBindingLookUpEdit(this.txtPosID, myDataTable, "Name", "ID", true);

            myDataTable = myBUCMS_DPInfo.GetOrder(false, "SubID", "1", false);
            CommonOperator.DataBindingLookUpEdit(this.txtIDCardNum, myDataTable, "TelPhone", "ID", true);
            //��ǰְ��

        }

        /// <summary>
        /// ��Ա��ͼƬ
        /// </summary>
        /// <summary>
        /// ��Ա��ͼƬ
        /// </summary>
        private void BindGvEmployeeView()
        {
            myDataTable = myBUCMS_Employee.GetOrder(true, string.Empty, string.Empty, false);
            myDataTable.Columns.Add("PhotoName", System.Type.GetType("System.Byte[]"));
            DataTable tempDataTable = new DataTable();
            tempDataTable.Columns.Add("Photo", typeof(System.Byte[]));
            tempDataTable.Columns.Add("Name", typeof(System.String));
            for (int i = 0; i < myDataTable.Rows.Count; i++)
            {
                string paramImgPath = Application.StartupPath + "\\Employee\\" + myDataTable.Rows[i]["Ա����Ƭ"].ToString();
                byte[] tempbyte = getImageByte(paramImgPath);
                DataRow tempDataRow = tempDataTable.NewRow();
                tempDataRow["Photo"] = tempbyte;
                tempDataRow["Name"] = myDataTable.Rows[i]["Ա������"].ToString();
                tempDataTable.Rows.Add(tempDataRow);
            }
            gvEmployeeView.DataSource = tempDataTable;
        }

        private byte[] getImageByte(string imagePath)
        {
            Image img = Image.FromFile(imagePath);
            Image bmp = new Bitmap(img);
            img.Dispose();
            MemoryStream stream = new MemoryStream();
            bmp.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            bmp.Dispose();
            return stream.ToArray();
        }

        ///��Image����ת���ɶ�������///
        ///</summary>
        ///<paramname="image"></param>
        ///<returns></returns>
        public static byte[] ImageToByteArray(Image image)
        {
            MemoryStream stream = new MemoryStream();
            image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            image.Dispose();
            return stream.ToArray();
        }

        /// <summary>
        /// ��gvEmployee�ؼ�����(Ա������),��lvEmployee�ؼ�
        /// </summary>
        private void BindGvEmployee()
        {
            myDataTable = myBUCMS_Employee.GetOrder(true, string.Empty, string.Empty, false);
            this.gvEmployee.DataSource = myDataTable;
            //ͼƬҲҪ��
           
            //myDataTable = myBUCMS_DPInfo.GetViewData();
        }

        //private void BindGvEmployeeView()
        //{
        //    myDataTable = myBUCMS_Employee.GetOrder(false, string.Empty, string.Empty, false);
        //    gvEmployeeView.DataSource = myDataTable;
        //}
        /// <summary>
        /// ���(&A)Ա����Ϣ��ť�¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEmployee myfrmAddEmployee = new frmAddEmployee();
            if (myfrmAddEmployee.ShowDialog() == DialogResult.OK)
            {
                BindGvEmployee();

                BindGvEmployeeView();
            }
        }

        private void btnDetailed_Click(object sender, EventArgs e)
        {
            if (fExtendedEditMode)
            {
                HideDetail((gvEmployee.MainView as ColumnView).FocusedRowHandle);
            }
            else
            {
                ShowDetail((gvEmployee.MainView as ColumnView).FocusedRowHandle);
            }
        }
        protected void ShowDetail(int rowHandle)
        {
            try
            {
                int datasourceRowIndex = gvEmployeeMain.GetDataSourceRowIndex(rowHandle);
                gvEmployee.MainView = editOrderlayoutView;
                SynchronizeOrdersDetailView(datasourceRowIndex);
                gvEmployee.UseEmbeddedNavigator = true;
                btnDetailed.Text = strHideExtendedMode;
                fExtendedEditMode = (gvEmployee.MainView == editOrderlayoutView);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }

        protected void SynchronizeOrdersDetailView(int dataSourceRowIndex)
        {
            int rowHandle = editOrderlayoutView.GetRowHandle(dataSourceRowIndex);
            editOrderlayoutView.VisibleRecordIndex = editOrderlayoutView.GetVisibleIndex(rowHandle);
            editOrderlayoutView.FocusedRowHandle = dataSourceRowIndex;
        }

        private void gvEmployeeMain_DoubleClick(object sender, EventArgs e)
        {
            MouseEventArgs ea = e as MouseEventArgs;
            if (ea == null)
            {
                return;
            }
            GridHitInfo hi = gvEmployeeMain.CalcHitInfo(ea.Location);
            if (hi.InRow)
            {
                ShowDetail(hi.RowHandle);
            }
        }

        protected void SynchronizeOrdersView(int dataSourceRowIndex)
        {
            int rowHandle = gvEmployeeMain.GetRowHandle(dataSourceRowIndex);
            gvEmployeeMain.FocusedRowHandle = rowHandle;
        }

        protected void editOrderlayoutView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                LayoutViewHitInfo hi = editOrderlayoutView.CalcHitInfo(e.Location);
                if (hi.InCard)
                {
                    HideDetail(hi.RowHandle);
                }
            }
        }

        protected void HideDetail(int rowHandle)
        {
            gvEmployee.MainView.PostEditor();
            int datasourceRowIndex = editOrderlayoutView.GetDataSourceRowIndex(rowHandle);
            gvEmployee.MainView = gvEmployeeMain;
            SynchronizeOrdersView(datasourceRowIndex);
            gvEmployee.UseEmbeddedNavigator = false;
            btnDetailed.Text = strShowExtendedMode;
            fExtendedEditMode = (gvEmployee.MainView == editOrderlayoutView);
        }

        /// <summary>
        /// �޸�(&U)Ա����Ϣ��ť�¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (fExtendedEditMode)
            {
                if (editOrderlayoutView.Columns.Count < 0)
                {
                    XtraMessageBox.Show("��ѡ��Ҫ�޸�(&U)��Ա����Ϣ��");
                    return;
                }
                paramID = editOrderlayoutView.GetFocusedRowCellValue(gcID).ToString();
            }
            else
            {
                paramID = gvEmployeeMain.GetFocusedRowCellValue(gcID).ToString();
            }
            myfrmAddEmployee = new frmAddEmployee(paramID);
            if (myfrmAddEmployee.ShowDialog() == DialogResult.OK)
            {
                BindGvEmployee();
            }
        }

        /// <summary>
        /// ɾ��(&D)Ա����Ϣ��ť�¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResign_Click(object sender, EventArgs e)
        {
            if (fExtendedEditMode)
            {
                if (editOrderlayoutView.Columns.Count < 0)
                {
                    XtraMessageBox.Show("��ѡ��Ҫ�޸�(&U)��Ա����Ϣ��");
                    return;
                }
                paramID = editOrderlayoutView.GetFocusedRowCellValue(gcID).ToString();
            }
            else
            {
                paramID = gvEmployeeMain.GetFocusedRowCellValue(gcID).ToString();
            }
            try
            {
                DialogResult tempDialogResult = XtraMessageBox.Show("���Ϊ" + paramID + "������", "ȷ��������", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == tempDialogResult)
                {
                    EnOperatorStatus = myBUCMS_Employee.Delete(paramID);
                    if (ClassAssist.CommonOperator.HandleOperatorEnum("Ա����Ϣ����", EnOperatorStatus))
                    {
                        BUT_SysLog.InsertSysLog(VariedEnum.LogType.���ݲ���, frmAssist.frmLogin.SysUser.UserID, "�ɹ�������Ա����Ϣ");
                        BindGvEmployee();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// ��ӡ(&P)Ա����Ϣ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                DataOperator.DataPrint(this.gvEmployee, "Ա����Ϣ",null);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// �رյ�ǰ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// ��ְʱ���ѯ
        /// </summary>
        private void SelectEntryDate()
        {
            DateTime startDateTime = Convert.ToDateTime(this.txtStartEntryDate.Text.Trim());
            DateTime overDateTime = Convert.ToDateTime(this.txtOverEntryDate.Text.Trim());
            try
            {
                myDataTable = myBUCMS_Employee.GetOrder(true, this.cmbValue.Text.Trim(), startDateTime, overDateTime);
                this.gvEmployee.DataSource = myDataTable;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// ������ѯcmbValue�ؼ�ѡ��ʱ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            string paramValue = this.cmbValue.Text.Trim();
            if (paramValue == "��ְʱ��")
            {
                DisplayVisbleText("EntryDate");
            }
            else if (paramValue == "��������")
            {
                DisplayVisbleText("BirthDate");
            }
            else if (paramValue == "Ա�����")
            {
                DisplayVisbleText("ID");
            }
            else if (paramValue == "��ǰְ��")
            {
                DisplayVisbleText("PosID");
            }
            else if (paramValue == "�绰����")
            {
                DisplayVisbleText("TelPhone");
            }
            else if (paramValue == "���֤����")
            {
                DisplayVisbleText("IDCardNum");
            }
            else if (paramValue == "������")
            {
                DisplayVisbleText("CreatePerson");
            }
            else if (paramValue == "�޸�(&U)ʱ��")
            {
                DisplayVisbleText("ModifyDate");
            }
            else if (paramValue == "Ա������")
            {
                DisplayVisbleText("Name");
            }
            else if (paramValue == "���ڲ���")
            {
                DisplayVisbleText("DPname");
            }
            else
            {
                DisplayVisbleText("Degree");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        private void DisplayVisbleText(string paramValue)
        {
            switch (paramValue)
            {
                case "EntryDate": DataEntryDateVisible(true);
                    DataBirthDateVisible(false);
                    ComboBoxAndTextBoxVisible(false);
                    DataModifyDateVisible(false);
                    break;
                case "BirthDate": DataEntryDateVisible(false);
                    DataBirthDateVisible(true);
                    ComboBoxAndTextBoxVisible(false);
                    DataModifyDateVisible(false);
                    this.labValue.Visible = true;
                    break;
                case "ModifyDate": DataEntryDateVisible(false);
                    DataBirthDateVisible(false);
                    ComboBoxAndTextBoxVisible(false);
                    DataModifyDateVisible(true);
                    this.labValue.Visible = true;
                    break;
                case "PosID": DataEntryDateVisible(false);
                    DataBirthDateVisible(false);
                    ComboBoxAndTextBoxVisible(false);
                    this.txtPosID.Visible = true;
                    break;
                case "ID": DataEntryDateVisible(false);
                    DataBirthDateVisible(false);
                    ComboBoxAndTextBoxVisible(false);
                    DataModifyDateVisible(false);
                    this.txtID.Visible = true;
                    break;
                case "TelPhone": DataEntryDateVisible(false);
                    DataBirthDateVisible(false);
                    ComboBoxAndTextBoxVisible(false);
                    DataModifyDateVisible(false);
                    this.txtTelPhone.Visible = true;
                    break;
                case "IDCardNum": DataEntryDateVisible(false);
                    DataBirthDateVisible(false);
                    ComboBoxAndTextBoxVisible(false);
                    DataModifyDateVisible(false);
                    this.txtIDCardNum.Visible = true;
                    break;
                case "CreatePerson": DataEntryDateVisible(false);
                    DataBirthDateVisible(false);
                    ComboBoxAndTextBoxVisible(false);
                    DataModifyDateVisible(false);
                    this.txtCreatePerson.Visible = true;
                    break;
                case "Name": DataEntryDateVisible(false);
                    DataBirthDateVisible(false);
                    ComboBoxAndTextBoxVisible(false);
                    DataModifyDateVisible(false);
                    this.txtName.Visible = true;
                    break;
                case "DPname": DataEntryDateVisible(false);
                    DataBirthDateVisible(false);
                    ComboBoxAndTextBoxVisible(false);
                    DataModifyDateVisible(false);
                    this.txtDPInfo.Visible = true;
                    break;
                default: DataEntryDateVisible(false);
                    DataBirthDateVisible(false);
                    ComboBoxAndTextBoxVisible(false);
                    DataModifyDateVisible(false);
                    this.txtDegree.Visible = true;
                    break;
            }
        }

        private void DataModifyDateVisible(bool paramBool)
        {
            this.txtStartModifyDate.Visible = paramBool;
            this.txtOverModifyDate.Visible = paramBool;
        }

        private void DataBirthDateVisible(bool paramBool)
        {
            this.txtStartBirthDate.Visible = paramBool;
            this.txtOverBirthDate.Visible = paramBool;
        }

        private void ComboBoxAndTextBoxVisible(bool paramBool)
        {
            this.txtTelPhone.Visible = paramBool;
            this.txtPosID.Visible = paramBool;
            this.txtName.Visible = paramBool;
            this.txtCreatePerson.Visible = paramBool;
            this.txtIDCardNum.Visible = paramBool;
            this.txtDegree.Visible = paramBool;
            this.txtDPInfo.Visible = paramBool;
            this.txtID.Visible = paramBool;
        }

        private void DataEntryDateVisible(bool paramBool)
        {
            this.txtStartEntryDate.Visible = paramBool;
            this.labValue.Visible = paramBool;
            this.txtOverEntryDate.Visible = paramBool;
        }

        /// <summary>
        /// ������ѯ��ť
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectEmployee_Click(object sender, EventArgs e)
        {
            string paramValue = this.cmbValue.Text.Trim();
            if (paramValue == "��ְʱ��")
            {
                SelectEntryDate();
                return;
            }
            else if (paramValue == "��������")
            {
                SelectBirthDate();
                return;
            }
            else if (paramValue == "�޸�(&U)ʱ��")
            {
                SelectModifyDate();
                return;
            }
            else
            {
                string TermValue = GetEmployeeCondition(paramValue);
                try
                {
                    if (paramValue == "���ڲ���")
                    {
                        myDataTable = myBUCMS_DPInfo.GetOrder(false, "Name", TermValue, false);
                        this.gvEmployee.DataSource = myDataTable;
                    }
                    //else (paramValue == "Ա��ְ��")
                    //{
                    //    myDataTable = myBUCMS_DPInfo.GetOrder(true, paramValue, TermValue, false);
                    //}
                    myDataTable = myBUCMS_Employee.GetOrder(true, paramValue, TermValue, false);
                    this.gvEmployee.DataSource = myDataTable;
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
        }

        private void SelectModifyDate()
        {
            DateTime startDateTime = Convert.ToDateTime(this.txtStartModifyDate.Text.Trim());
            DateTime overDateTime = Convert.ToDateTime(this.txtOverModifyDate.Text.Trim());
            try
            {
                myDataTable = myBUCMS_Employee.GetOrder(true, this.cmbValue.Text.Trim(), startDateTime, overDateTime);
                this.gvEmployee.DataSource = myDataTable;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// �������ڲ�ѯ
        /// </summary>
        private void SelectBirthDate()
        {
            DateTime startDateTime = Convert.ToDateTime(this.txtStartEntryDate.Text.Trim());
            DateTime overDateTime = Convert.ToDateTime(this.txtOverEntryDate.Text.Trim());
            try
            {
                myDataTable = myBUCMS_Employee.GetOrder(true, this.cmbValue.Text.Trim(), startDateTime, overDateTime);
                this.gvEmployee.DataSource = myDataTable;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// �õ�������ѯ��ֵ
        /// </summary>
        /// <param name="paramValue"></param>
        /// <returns></returns>
        private string GetEmployeeCondition(string paramValue)
        {
            string returnValue = string.Empty;
            switch (paramValue)
            {
                case "��ǰְ��": returnValue = this.txtPosID.Text.Trim();
                    break;
                case "�绰����": returnValue = this.txtTelPhone.Text.Trim();
                    break;
                case "���֤����": returnValue = this.txtIDCardNum.Text.Trim();
                    break;
                case "������": returnValue = this.txtCreatePerson.Text.Trim();
                    break;
                case "Ա������": returnValue = this.txtName.Text.Trim();
                    break;
                case "���ڲ���": returnValue = this.txtDPInfo.Text.Trim();
                    break;
                case "Ա�����": returnValue = this.txtID.Text.Trim();
                    break;
                default: returnValue = this.txtDegree.Text.Trim();
                    break;
            }
            return returnValue;
        }

        private void btnDerived_Click(object sender, EventArgs e)
        {
            try
            {
                DataOperator.DataOut(this.gvEmployeeMain, "Ա����Ϣ");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnAllSelect_Click(object sender, EventArgs e)
        {
            BindGvEmployee();
        }

        private void lvEmployeeMain_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            //if (e.Column == colFullName)
            //{
            //    DataRow row = lvEmployeeMain.GetDataRow(e.RowHandle);
            //    e.Value = String.Format("{0} {1}", row["FirstName"], row["LastName"]);
            //}
        }

        private void gvEmployeeMain_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }

        private void gvEmployeeMain_Click(object sender, EventArgs e)
        {
            SetGdvRowHandle();
        }

        private void SetGdvRowHandle()
        {
            string rowHandle = GetGdvRowHandle();
            for (int i = 0; i < lvEmployeeMain.RowCount; i++)
            {
                if (rowHandle == Convert.ToString(lvEmployeeMain.GetRowCellValue(i, lvcName)))
                {
                    lvEmployeeMain.FocusedRowHandle = i;
                    break;
                }
            }
        }
        private string GetGdvRowHandle()
        {
            string paramEmpName;
            int rowHandle = gvEmployeeMain.GetFocusedDataSourceRowIndex();
            paramEmpName = Convert.ToString(gvEmployeeMain.GetFocusedRowCellValue("Ա������"));
            return paramEmpName;
        }

        private string GetImgRowHandle()
        {
            string paramEmpName;
            int rowHandle = lvEmployeeMain.GetFocusedDataSourceRowIndex();
            paramEmpName = Convert.ToString(lvEmployeeMain.GetFocusedRowCellValue("Name"));
            //MessageBox.Show(paramEmpName);
            return paramEmpName;
        }

        private void lvEmployeeMain_Click(object sender, EventArgs e)
        {
            SetImgRowHandle();
        }

        /// <summary>
        /// ͼ��ѡ���û�
        /// </summary>
        private void SetImgRowHandle()
        {
            string rowHandle = GetImgRowHandle();
            if (gvEmployee.MainView == gvEmployeeMain)
            {
                for (int i = 0; i < gvEmployeeMain.RowCount; i++)
                {
                    if (rowHandle == Convert.ToString(gvEmployeeMain.GetRowCellValue(i, gcName)))
                    {
                        gvEmployeeMain.FocusedRowHandle = i;
                        gvEmployeeMain.SelectRow(i);
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < editOrderlayoutView.RowCount; i++)
                {
                    if (rowHandle == Convert.ToString(editOrderlayoutView.GetRowCellValue(i, gcName)))
                    {
                        editOrderlayoutView.FocusedRowHandle = i;
                        break;
                    }
                }
            }
        }

        private void btnPerformance_Click(object sender, EventArgs e)
        {
            if (fExtendedEditMode)
            {
                if (editOrderlayoutView.Columns.Count < 0)
                {
                    XtraMessageBox.Show("��ѡ��Ҫ�鿴Ա���ı�ţ�");
                    return;
                }
                paramID = editOrderlayoutView.GetFocusedRowCellValue(gcID).ToString();
            }
            else
            {
                paramID = gvEmployeeMain.GetFocusedRowCellValue(gcID).ToString();
            }
            frmEpmloyeePerformance myfrmEpmloyeePerformance = new frmEpmloyeePerformance(paramID);
            if (myfrmEpmloyeePerformance.ShowDialog() == DialogResult.OK)
            {
                return;
            }
        }
    }
}