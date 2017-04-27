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
        #region **********************定义变量******************************
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

        #region private void BindMruEdit() 项目类型绑定
        /// <summary>
        /// 项目类型绑定
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

        #region private void BindLookUpEditName() 名称数据绑定
        /// <summary>
        /// 名称数据绑定
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

        #region private void BindLookUpEditHandlePeople() 经手人数据绑定
        /// <summary>
        /// 经手人数据绑定
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

        #region private void BindLookUpEditCreatePerson() 创建人数据绑定
        /// <summary>
        /// 创建人数据绑定
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

        #region private void BindLookUpEdit(string paramFirstSelection) LookUpEdit的数据绑定
        /// <summary>
        /// LookUpEdit的数据绑定
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

        #region mruEditType_SelectedIndexChanged 收支类型的SelectedIndexChanged事件
        /// <summary>
        /// 收支类型的SelectedIndexChanged事件
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void mruEditType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string paramType = this.mruEditType.Text;
            DataTable myDataTable = myBUCMS_PaymentsDetail.GetOrder(true,"类型",paramType,false);
            this.grdctrInOutDetail.DataSource = myDataTable;
        }
        #endregion 

        #region private void btnSelectAll_Click(object sender, EventArgs e) 查询全部按钮的单击事件
        /// <summary>
        /// 查询全部的单击事件
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            BindGridControl();
        }
        #endregion

        #region private string GetCondition(string paramField) 获得第二查询条件
        /// <summary>
        /// 获得第二查询条件
        /// </summary>
        /// <param name="paramField"></param>
        /// <returns></returns>
        private string GetCondition(string paramField)
        {
            string returnStringConditon = string.Empty;
            switch (paramField)
            {
                case "金额": returnStringConditon = this.txtNumAndAmount.Text.ToString();
                    break;
                case "类型": returnStringConditon = this.mruEditType.Text.ToString();
                    break;
                case "编号": returnStringConditon = this.txtNumAndAmount.Text.ToString();
                    break;
                default: returnStringConditon = this.EditSecSelcCondition.Text.Trim();
                    break;
            }
            return returnStringConditon;
        }
        #endregion

        #region btnSelect_Click 查询按钮的单击事件
        /// <summary>
        /// 查询按钮的单击事件
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            string tempStringField = this.cmbSelectCondition.Text.Trim();
            if (tempStringField == "创建时间")
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

        #region private int DateDiff 计算两个日期的时间间隔,返回(&B)他们之间相差的天数(paramDateTime1-paramDateTime2)
        /// <summary>
        /// 计算两个日期的时间间隔,返回(&B)他们之间相差的天数(paramDateTime1-paramDateTime2)
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

        #region dateEditCEnd_EditValueChanged 结束时间EditValueChanged事件
        /// <summary>
        /// 结束时间EditValueChanged事件
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
                XtraMessageBox.Show("结束时间必须小于当前时间", "信息输入不正确", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.dateEditCEnd.EditValue = DateTime.Now;
            }
        }
        #endregion

        #region private void DateQuery() 创建时间查询
        /// <summary>
        /// 日期查询
        /// </summary>
        private void DateQuery()
        {
            string tempDateTimeStart = this.dateEditCStart.Text.Trim();
            string tempDateTimeEnd = this.dateEditCEnd.Text.Trim();
            try
            {
                DataTable myDataTable = myBUCMS_PaymentsDetail.GetOrder(true, "[创建时间]", tempDateTimeEnd,true );
                this.grdctrInOutDetail.DataSource = myDataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region private void cmbSelectCondition_SelectedIndexChanged(object sender, EventArgs e)第一条件选择改变
        /// <summary>
        /// 第一条件选择改变
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void cmbSelectCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            string paramSelectCondition = this.cmbSelectCondition.Text.Trim();
            if (paramSelectCondition == "编号")
            {
                BoolValue("ID");
                return;
            }
            if (paramSelectCondition == "名称")
            {
                BoolValue("Name");
                BindLookUpEdit("Name");
                return;
            }
            if (paramSelectCondition == "类型")
            {
                BoolValue("Type");
                BindMruEdit();
                return;
            }
            if (paramSelectCondition == "金额")
            {
                BoolValue("Amount");
                return;
            }
            if (paramSelectCondition == "经手人")
            {
                BoolValue("HandlePeople");
                BindLookUpEdit("HandlePeople");
                return;
            }
            if (paramSelectCondition == "创建人")
            {
                BoolValue("CreatePerson");
                BindLookUpEdit("CreatePerson");
                return;
            }
            if (paramSelectCondition == "创建时间")
            {
                BoolValue("CreateDate");
                return;
            }
        }
        #endregion

        #region private void BoolValue(string paramBoolValue) 初始化查询控件
        /// <summary>
        /// 初始化查询控件
        /// </summary>
        /// <param name="paramBoolValue">T第二条件控件选择</param>
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

        #region private void VisibleOrNot3(bool paramBool)根据参数设置类型、金额编号、第二条件选择的可视状态
        /// <summary>
        /// 根据参数设置类型、金额编号、第二条件选择的可视状态
        /// </summary>
        /// <param name="paramBool">是否可视 <c>true</c> [param bool].</param>
        /// <remarks></remarks>
        private void VisibleOrNot3(bool paramBool)
        {
            this.EditSecSelcCondition.Visible = paramBool;
            this.mruEditType.Visible = paramBool;
            this.txtNumAndAmount.Visible = paramBool;
        }
        #endregion

        #region private void VisibleOrNot2(bool paramBool)根据参数设置第二条件选择、开始时间、结束时间、Label标签的可视状态
        /// <summary>
        /// 根据参数设置第二条件选择、开始时间、结束时间、Label标签的可视状态
        /// </summary>
        /// <param name="paramBool">是否可视 <c>true</c> [param bool].</param>
        /// <remarks></remarks>
        private void VisibleOrNot2(bool paramBool)
        {
            this.EditSecSelcCondition.Visible = paramBool;
            this.dateEditCStart.Visible = paramBool;
            this.dateEditCEnd.Visible = paramBool;
            this.lblCome.Visible = paramBool;
        }
        #endregion

        #region private void VisibleOrNot1(bool paramBool)根据参数设置类型、金额编号、开始时间、结束时间、Label标签的可视状态
        /// <summary>
        /// 根据参数设置类型、金额编号、开始时间、结束时间、Label标签的可视状态
        /// </summary>
        /// <param name="paramBool">是否可视 <c>true</c> [param bool].</param>
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

        #region txtNumAndAmount_EditValueChanged 按编号查询
        /// <summary>
        /// 按编号查询
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void txtNumAndAmount_EditValueChanged(object sender, EventArgs e)
        {
            string tempStringField = this.cmbSelectCondition.Text.Trim();
            if (!tempStringField.Equals("编号"))
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

        #region btnPrint_Click 打印(&P)按钮的单击事件
        /// <summary>
        /// 打印(&P)按钮的单击事件
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                ClassAssist.DataOperator.DataPrint(this.grdctrInOutDetail, "收支明细信息",null);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region btnOut_Click 打印(&P)按钮的单击事件
        /// <summary>
        /// 打印(&P)按钮的单击事件
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnOut_Click(object sender, EventArgs e)
        {
            try
            {
                ClassAssist.DataOperator.DataOut(this.gridViewInOutDetail, "收支明细信息");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        #endregion

        


    }
}