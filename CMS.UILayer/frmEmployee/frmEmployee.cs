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
        string strHideExtendedMode = "列表";
        string strShowExtendedMode = "详细信息";
        bool fExtendedEditMode = false;
        //bool allowEditOnDoubleClickCore;
        public frmEmployee()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
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
        /// 绑定各文本框的值
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
            //当前职务

        }

        /// <summary>
        /// 绑定员工图片
        /// </summary>
        /// <summary>
        /// 绑定员工图片
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
                string paramImgPath = Application.StartupPath + "\\Employee\\" + myDataTable.Rows[i]["员工照片"].ToString();
                byte[] tempbyte = getImageByte(paramImgPath);
                DataRow tempDataRow = tempDataTable.NewRow();
                tempDataRow["Photo"] = tempbyte;
                tempDataRow["Name"] = myDataTable.Rows[i]["员工姓名"].ToString();
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

        ///将Image对象转化成二进制流///
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
        /// 绑定gvEmployee控件数据(员工数据),和lvEmployee控件
        /// </summary>
        private void BindGvEmployee()
        {
            myDataTable = myBUCMS_Employee.GetOrder(true, string.Empty, string.Empty, false);
            this.gvEmployee.DataSource = myDataTable;
            //图片也要绑定
           
            //myDataTable = myBUCMS_DPInfo.GetViewData();
        }

        //private void BindGvEmployeeView()
        //{
        //    myDataTable = myBUCMS_Employee.GetOrder(false, string.Empty, string.Empty, false);
        //    gvEmployeeView.DataSource = myDataTable;
        //}
        /// <summary>
        /// 添加(&A)员工信息按钮事件
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
        /// 修改(&U)员工信息按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (fExtendedEditMode)
            {
                if (editOrderlayoutView.Columns.Count < 0)
                {
                    XtraMessageBox.Show("请选择要修改(&U)的员工信息！");
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
        /// 删除(&D)员工信息按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResign_Click(object sender, EventArgs e)
        {
            if (fExtendedEditMode)
            {
                if (editOrderlayoutView.Columns.Count < 0)
                {
                    XtraMessageBox.Show("请选择要修改(&U)的员工信息！");
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
                DialogResult tempDialogResult = XtraMessageBox.Show("编号为" + paramID + "的数据", "确定开除？", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == tempDialogResult)
                {
                    EnOperatorStatus = myBUCMS_Employee.Delete(paramID);
                    if (ClassAssist.CommonOperator.HandleOperatorEnum("员工信息开除", EnOperatorStatus))
                    {
                        BUT_SysLog.InsertSysLog(VariedEnum.LogType.数据操作, frmAssist.frmLogin.SysUser.UserID, "成功开除了员工信息");
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
        /// 打印(&P)员工信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                DataOperator.DataPrint(this.gvEmployee, "员工信息",null);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 关闭当前窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 入职时间查询
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
        /// 条件查询cmbValue控件选项时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            string paramValue = this.cmbValue.Text.Trim();
            if (paramValue == "入职时间")
            {
                DisplayVisbleText("EntryDate");
            }
            else if (paramValue == "出生日期")
            {
                DisplayVisbleText("BirthDate");
            }
            else if (paramValue == "员工编号")
            {
                DisplayVisbleText("ID");
            }
            else if (paramValue == "当前职务")
            {
                DisplayVisbleText("PosID");
            }
            else if (paramValue == "电话号码")
            {
                DisplayVisbleText("TelPhone");
            }
            else if (paramValue == "身份证号码")
            {
                DisplayVisbleText("IDCardNum");
            }
            else if (paramValue == "创建人")
            {
                DisplayVisbleText("CreatePerson");
            }
            else if (paramValue == "修改(&U)时间")
            {
                DisplayVisbleText("ModifyDate");
            }
            else if (paramValue == "员工姓名")
            {
                DisplayVisbleText("Name");
            }
            else if (paramValue == "所在部门")
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
        /// 条件查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectEmployee_Click(object sender, EventArgs e)
        {
            string paramValue = this.cmbValue.Text.Trim();
            if (paramValue == "入职时间")
            {
                SelectEntryDate();
                return;
            }
            else if (paramValue == "出生日期")
            {
                SelectBirthDate();
                return;
            }
            else if (paramValue == "修改(&U)时间")
            {
                SelectModifyDate();
                return;
            }
            else
            {
                string TermValue = GetEmployeeCondition(paramValue);
                try
                {
                    if (paramValue == "所在部门")
                    {
                        myDataTable = myBUCMS_DPInfo.GetOrder(false, "Name", TermValue, false);
                        this.gvEmployee.DataSource = myDataTable;
                    }
                    //else (paramValue == "员工职务")
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
        /// 出生日期查询
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
        /// 得到条件查询的值
        /// </summary>
        /// <param name="paramValue"></param>
        /// <returns></returns>
        private string GetEmployeeCondition(string paramValue)
        {
            string returnValue = string.Empty;
            switch (paramValue)
            {
                case "当前职务": returnValue = this.txtPosID.Text.Trim();
                    break;
                case "电话号码": returnValue = this.txtTelPhone.Text.Trim();
                    break;
                case "身份证号码": returnValue = this.txtIDCardNum.Text.Trim();
                    break;
                case "创建人": returnValue = this.txtCreatePerson.Text.Trim();
                    break;
                case "员工姓名": returnValue = this.txtName.Text.Trim();
                    break;
                case "所在部门": returnValue = this.txtDPInfo.Text.Trim();
                    break;
                case "员工编号": returnValue = this.txtID.Text.Trim();
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
                DataOperator.DataOut(this.gvEmployeeMain, "员工信息");
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
            paramEmpName = Convert.ToString(gvEmployeeMain.GetFocusedRowCellValue("员工姓名"));
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
        /// 图像选择用户
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
                    XtraMessageBox.Show("请选择要查看员工的编号！");
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