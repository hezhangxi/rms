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
using CMS.UILayer.ClassAssist;

namespace CMS.UILayer.frmEmployee
{
    public partial class frmEpmloyeePerformance : DevExpress.XtraEditors.XtraForm
    {
        #region 变量定义
        BUCMS_Employee myBUCMS_Employee = new BUCMS_Employee();
        ModelCMS_DishServer myModelCMS_DishServer = new ModelCMS_DishServer();
        BUCMS_DishServer myBUCMS_DishServer = new BUCMS_DishServer();
        DataTable myDataTable = new DataTable();
        VariedEnum.OperatorStatus EnOperatorStatus;
        private string paramEmployeeID = string.Empty;
        private string paramDishServerID = string.Empty;
        private string returnEmployeeid = string.Empty;
        #endregion 

        public frmEpmloyeePerformance()
        {
            InitializeComponent();
        }

        public frmEpmloyeePerformance( string returnEmployeeID)
        {
            InitializeComponent();
            returnEmployeeid = returnEmployeeID;
        }

        private void frmEpmloyeePerformance_Load(object sender, EventArgs e)
        {
            BindLvPerformance();
            BindComBoxValue();
        }

        private void BindComBoxValue()
        {
            myDataTable = myBUCMS_Employee.GetOrder(false, string.Empty, string.Empty, false);
            for (int i = 0; i < myDataTable.Rows.Count; i++)
            {
                txtEmpID.Properties.Items.Add(myDataTable.Rows[i]["ID"].ToString());
                txtEmpName.Properties.Items.Add(myDataTable.Rows[i]["Name"].ToString());
            }
            myDataTable = myBUCMS_DishServer.GetOrder(false, string.Empty, string.Empty, false);
            for (int i = 0; i < myDataTable.Rows.Count; i++)
            {
                txtItemID.Properties.Items.Add(myDataTable.Rows[i]["ID"].ToString());
                txtName.Properties.Items.Add(myDataTable.Rows[i]["Name"].ToString());
            }
        }
        /// <summary>
        /// 获取ComBox中选中的值，用来查询
        /// </summary>
        private void BindComBox()
        {
            string paramValue = this.SelectValue.Text.Trim();
            if (paramValue == "员工编号")
            {
                DisplayVisbleText("EmpID");
            }
            else if (paramValue == "员工姓名")
            {
                DisplayVisbleText("EmpName");
            }
            else if(paramValue == "菜品编号")
            {
                DisplayVisbleText("DishServerID");
            }
             else
            {
                DisplayVisbleText("DishServerName");
            }
        }

        private void DisplayVisbleText(string paramTextValue)
        {
            switch (paramTextValue)
            {
                case "EmpID": DataEntryDateVisible(false);
                    this.txtEmpID.Visible = true;
                    break;
                case "EmpName": DataEntryDateVisible(false);
                    this.txtEmpName.Visible = true;
                    break;
                case "DishServerName": DataEntryDateVisible(false);
                    this.txtName.Visible = true;
                    break;
                default:DataEntryDateVisible(false);
                  this.txtItemID.Visible = true;
                    break;
            }
        }

        private void DataEntryDateVisible(bool paramBool)
        {
            this.txtEmpID.Visible = paramBool;
            this.txtEmpName.Visible = paramBool;
            this.txtItemID.Visible = paramBool;
            this.txtName.Visible = paramBool;
        }

        private void BindLvPerformance()
        {
            if (returnEmployeeid.Length == 0)
            {
                myDataTable = myBUCMS_Employee.GetOrderView(true, string.Empty, string.Empty, false);
                lvPerformance.DataSource = myDataTable;
            }
            else
            {
                myDataTable = myBUCMS_Employee.GetOrderView(true, "员工编号", returnEmployeeid, false);
                lvPerformance.DataSource = myDataTable;
            }
        }

        private void lvPerformanceMain_Click(object sender, EventArgs e)
        {
            paramEmployeeID = this.lvPerformanceMain.GetFocusedRowCellValue(gcID).ToString();
            paramDishServerID = this.lvPerformanceMain.GetFocusedRowCellValue(gcDishServerID).ToString();
            this.lvPerformanceMain.OptionsBehavior.Editable = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                myModelCMS_DishServer = BindModel();
                DialogResult tempDialogResult = XtraMessageBox.Show("编号为" + paramEmployeeID + "员工业绩数据的数据", "确定修改(&U)？", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == tempDialogResult)
                {
                   EnOperatorStatus = myBUCMS_DishServer.Update(myModelCMS_DishServer);
                    if (ClassAssist.CommonOperator.HandleOperatorEnum("员工提成信息修改(&U)成功", EnOperatorStatus))
                    {
                        BUT_SysLog.InsertSysLog(VariedEnum.LogType.数据操作, frmAssist.frmLogin.SysUser.UserID, "成功修改(&U)了员工提成信息");
                        BindLvPerformance();
                    }
                }
            }
            catch (Exception ex) 
            {
                throw ex;
            }           
        }

        private ModelCMS_DishServer BindModel()
        {
            myModelCMS_DishServer.ID = Convert.ToInt32(paramDishServerID);
            myModelCMS_DishServer.Name = this.lvPerformanceMain.GetFocusedRowCellValue(gcDishServerName).ToString();
            myModelCMS_DishServer.Commission = Convert.ToDecimal(this.lvPerformanceMain.GetFocusedRowCellValue(gcDishServerCommission).ToString());
            myModelCMS_DishServer.InfoNote = this.lvPerformanceMain.GetFocusedRowCellValue(gcPosInfoName).ToString();
            return myModelCMS_DishServer;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string paramValue = this.SelectValue.Text.Trim();
            try
            {
               string TermValue = GetEmployeeCondition(paramValue);
               myDataTable = myBUCMS_Employee.GetOrderView(true, paramValue, TermValue, false);
                this.lvPerformance.DataSource = myDataTable;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }

        private string GetEmployeeCondition(string paramValue)
        {
            string returnValue = string.Empty;
            switch (paramValue)
            {
                    case "菜品名称":returnValue = this.txtName.Text.Trim();
                    break;
                    case "菜品编号":returnValue = this.txtItemID.Text.Trim();
                    break;
                    case "员工姓名":returnValue = this.txtEmpName.Text.Trim();
                    break;
                    case "员工编号":returnValue = this.txtEmpID.Text.Trim();
                    break;
            }
            return returnValue;
        }

        private void SelectValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindComBox();
        }

        private void txtEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                DataOperator.DataPrint(this.lvPerformance, "员工信息",null);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            BindLvPerformance();
        }
    }
}