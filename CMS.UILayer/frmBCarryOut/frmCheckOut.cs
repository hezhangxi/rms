
//******************************************************************************************************
//** Copyright (C) 2010-2013 重大网络教育学院
//** 创建人：桂书丛
//** 类名称\文件名：frmCheckOut
//** 类功能：消费结账
//** 描 述：餐饮管理系统消费结账窗体
//** 创建日期：2013-2-4
//** 修改(&U)人：桂书丛
//** 修改(&U)日期：2013-2-4
//** 整理日期：2013-2-4
//******************************************************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using CMS.Model;
using CMS.BULayer;
namespace CMS.UILayer.frmBCarryOut
{
    /// <summary>
    /// 消费结账
    /// </summary>
    /// 创建人：桂书丛
    /// 创建日期：2013-02-23
    public partial class frmCheckOut : DevExpress.XtraEditors.XtraForm
    {
        #region 定义变量
        private BUCMS_ConsumptionReg myBUConsumptionReg = new BUCMS_ConsumptionReg();   //账单信息操作集
        private ModelCMS_ConsumptionReg myModelCMS_ConsumptionReg;                      //消费注册信息实体
        private ModelCMS_Buffets myModelCMS_Buffets;                                    //餐台信息实体
        private ListViewItem BuffetControl;                                             //结账餐台控件
        private string AssistorName = string.Empty;                                     //服务员
        private bool IsShown = true;                                                    //是否可以显示窗体,默认显示
        private int VIPID = 0;                                                          //VIP消费时VIP卡的类型
        private DataRow VIPInfo;                                                        //VIP信息数据集
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="frmCheckOut"/> class.
        /// </summary>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-23
        public frmCheckOut()
        {
            InitializeComponent();
            this.txtPayMoney.EditValue = 0.0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="frmCheckOut"/> class.
        /// </summary>
        /// <param name="paramBuffetControl">The param control.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-23
        public frmCheckOut(ListViewItem paramBuffetControl)
        {
            InitializeComponent();
            this.BuffetControl = paramBuffetControl;
            this.myModelCMS_Buffets = ClassAssist.BuffetOperator.GetBuffetModel(paramBuffetControl);
            InitializeControls();
        }

        /// <summary>
        /// 初始化所有控件
        /// </summary>
        private void InitializeControls()
        {
            try
            {
                myModelCMS_ConsumptionReg = new ModelCMS_ConsumptionReg();
                DisplayBuffetInfo();
                GetConsumptionInfo(myModelCMS_Buffets.MarkID);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Datas the binding controls.
        /// </summary>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-23
        private void DataBindingControls()
        {
            try
            {
                DataTable myDataTable = new BUCMS_ItemDetail().GetItemByType(VariedItemType.PayType);
                ClassAssist.CommonOperator.DataBindingLookUpEdit(this.lupPayType, myDataTable, "Name", "ID", true);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        #region  private void GetConsumptionInfo(string paramMarkID) 获得消费详细信息
        /// <summary>
        /// 获得消费详细信息
        /// </summary>
        /// <param name="paramMarkID"></param>
        private void GetConsumptionInfo(string paramMarkID)
        {
            try
            {
                DataTable tempDataTable = new BUCMS_ConsumptionDish().GetOrder(true,"MarkID", paramMarkID,false);
                if (tempDataTable.Rows[0]["菜品编号"].ToString() == string.Empty)
                {
                    if (XtraMessageBox.Show("当前餐台暂未消费任何项,是否先增加消费", "是否要增加消费后再结账？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        frmDineRegister myfrmDineRegister = new frmDineRegister(this.BuffetControl);
                        myfrmDineRegister.Owner = this;
                        myfrmDineRegister.Show();
                        this.IsShown = false;
                    }
                }
                this.gridControlItem.DataSource = tempDataTable;
                GetConsumptionRegModel(tempDataTable);
                FillConsumptionRegModelInfo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        /// <summary>
        /// 通过消费信息得到消费注册实体
        /// </summary>
        /// <param name="paramDataTable"></param>
        private void GetConsumptionRegModel(DataTable paramDataTable)
        {
            if (paramDataTable.Rows.Count <= 0)
                return;
            try
            {
                DataRow tempDataRow = paramDataTable.Rows[0];
                myModelCMS_ConsumptionReg.BuffetsID = myModelCMS_Buffets.ID;
                myModelCMS_ConsumptionReg.CustomerNum = Convert.ToInt32(tempDataRow["宾客人数"]);
                myModelCMS_ConsumptionReg.Description = tempDataRow["备注"].ToString();
                myModelCMS_ConsumptionReg.EmployeeID = Convert.ToInt32(tempDataRow["服务员编号"]);
                myModelCMS_ConsumptionReg.ID = Convert.ToInt32(tempDataRow["账单编号"]);
                myModelCMS_ConsumptionReg.IsPaied = false;
                myModelCMS_ConsumptionReg.IsVIP = false;
                myModelCMS_ConsumptionReg.MarkID = myModelCMS_Buffets.MarkID;
                myModelCMS_ConsumptionReg.CreateDate = Convert.ToDateTime(tempDataRow["消费时间"]);
                myModelCMS_ConsumptionReg.CreatePerson = tempDataRow["服务员"].ToString();
                myModelCMS_ConsumptionReg.ModifyDate = DateTime.Now;
                myModelCMS_ConsumptionReg.ModifyPerson = frmAssist.frmLogin.SysUser.UserName;
                myModelCMS_ConsumptionReg.PayTypeID = VariedDefault.DefaultPayType;
                myModelCMS_ConsumptionReg.TotalAmount = Convert.ToDecimal(this.DishType.SummaryItem.SummaryValue);
                myModelCMS_ConsumptionReg.TypeID = VariedDefault.DefaultPayType;
            }
            catch{}
        }

        /// <summary>
        /// 更新消费账单信息
        /// </summary>
        private ModelCMS_ConsumptionReg GetUpdateConsumptionRegModel()
        {
            try
            {
                myModelCMS_ConsumptionReg.IsPaied = true;
                myModelCMS_ConsumptionReg.IsVIP = true;
                myModelCMS_ConsumptionReg.VIPID = this.VIPID;
                if (this.chkVIP.Checked == false)
                {
                    myModelCMS_ConsumptionReg.IsVIP = false;
                    myModelCMS_ConsumptionReg.VIPID = 1;
                }
                myModelCMS_ConsumptionReg.TypeID = Convert.ToInt32(VariedEnum.ConsumeWay.饭店消费);
                myModelCMS_ConsumptionReg.ModifyDate = DateTime.Now;
                myModelCMS_ConsumptionReg.ModifyPerson = frmAssist.frmLogin.SysUser.UserName;
                myModelCMS_ConsumptionReg.PayTypeID = Convert.ToInt32(this.lupPayType.EditValue);
                myModelCMS_ConsumptionReg.TotalAmount = Convert.ToDecimal(this.txtShouldPay.EditValue); 
            }
            catch { }
            return myModelCMS_ConsumptionReg;
        }

        /// <summary>
        /// Fills the consumption reg model info.
        /// </summary>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-23
        private void FillConsumptionRegModelInfo()
        {
            if (myModelCMS_ConsumptionReg == null)
                return;
            this.lblBillID.Text = myModelCMS_ConsumptionReg.ID.ToString();
            this.lblCustomerNum.Text = myModelCMS_ConsumptionReg.CustomerNum.ToString() + "人";
            this.Assistor.Text = myModelCMS_ConsumptionReg.CreatePerson;
            this.lblBillInfoNote.Text = myModelCMS_ConsumptionReg.Description;
            this.txtTotalAmount.EditValue = myModelCMS_ConsumptionReg.TotalAmount;
            this.txtShouldPay.EditValue = this.txtTotalAmount.EditValue;
            this.txtChangeMoney.EditValue = -1.0 * Convert.ToDouble(this.txtTotalAmount.EditValue);
        }

        #region private void DisplayBuffetInfo() 显示餐台信息
        /// <summary>
        /// 显示餐台信息
        /// </summary>
        private void DisplayBuffetInfo()
        {
            Control[] tempShowControl = new Control[5];
            tempShowControl[0] = this.lblID;
            tempShowControl[1] = this.lblName;
            tempShowControl[2] = this.lblStatus;
            tempShowControl[3] = this.lblStatus;
            tempShowControl[4] = this.lblInfoNote;
            ClassAssist.BuffetOperator.ShowBuffetInfo(myModelCMS_Buffets, tempShowControl);
        }
        #endregion

        /// <summary>
        /// Updates the VIP info.
        /// </summary>
        /// 创建人：桂书丛
        /// 创建日期：2013-3-3
        private VariedEnum.OperatorStatus UpdateVIPInfo()
        {
            try
            {
                ModelCMS_VIPClient myModelCMS_VIPClient = new ModelCMS_VIPClient();
                Decimal TotalCost = Convert.ToDecimal(VIPInfo["VIPCost"]) - Convert.ToDecimal(this.txtShouldPay.EditValue);
                myModelCMS_VIPClient.VIPCost = Convert.ToDecimal(TotalCost);
                myModelCMS_VIPClient.ID = Convert.ToInt32(VIPInfo["ID"]);
                myModelCMS_VIPClient.RechargeDate = DateTime.Now;
                return new BUCMS_VIPClient().Update(myModelCMS_VIPClient, "");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
            return VariedEnum.OperatorStatus.Successed;                                                                                                                                                                                                                                                                                                                                                                                                                                                           
        }

        /// <summary>
        /// Handles the Click event of the btnCheckOut control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-24
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            VariedEnum.OperatorStatus EnOperatorStatus;
            try
            {
                if (Convert.ToDouble(this.txtChangeMoney.Text.Substring(1)) < 0.0)
                {
                    XtraMessageBox.Show("支付金额不足，无法结账","结账失败！",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }
                if(VIPInfo != null)
                    if (UpdateVIPInfo() != VariedEnum.OperatorStatus.Successed)
                        return;
                EnOperatorStatus = myBUConsumptionReg.Update(GetUpdateConsumptionRegModel());
                if (ClassAssist.CommonOperator.HandleOperatorEnum("结账", EnOperatorStatus))
                {
                    if (ClassAssist.BuffetOperator.UpdateBuffetInfo(this.BuffetControl, VariedEnum.BuffetStatus.空闲, myModelCMS_Buffets.MarkID))
                    {
                        if(VIPInfo != null)
                            BUT_SysLog.InsertSysLog(VariedEnum.LogType.数据操作, frmAssist.frmLogin.SysUser.UserID, "VIP编号为" + VIPInfo["ID"].ToString() +"的会员消费了"+ this.txtShouldPay.Text + "元");
                        else
                            BUT_SysLog.InsertSysLog(VariedEnum.LogType.数据操作, frmAssist.frmLogin.SysUser.UserID,"结账收取：" + this.txtShouldPay.Text + "元");
                        if (this.chkPrintList.Checked == true)
                            ClassAssist.DataOperator.DataPrint(this.gridControlItem, "消费记录", this);
                        else
                            this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Source == "mscorlib")                                //如果发生数据转化异常
                {
                    XtraMessageBox.Show("支付金额不足，无法结账", "结账失败！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                XtraMessageBox.Show(ex.Message, "Add");
            }
        }

        /// <summary>
        /// Handles the EditValueChanging event of the txtPayMoney control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraEditors.Controls.ChangingEventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-23
        private void txtPayMoney_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                double ShouldPay = Convert.ToDouble(this.txtShouldPay.EditValue);
                double Paied = 0.0;
                Paied = Convert.ToDouble(this.txtPayMoney.Text);
                this.txtChangeMoney.EditValue = Paied-ShouldPay;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handles the EditValueChanging event of the spDisCount control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraEditors.Controls.ChangingEventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-23
        private void spDisCount_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                double DisCount = Convert.ToDouble(this.spDisCount.EditValue) * 0.1;
                double TotalAmount = Convert.ToDouble(this.txtTotalAmount.EditValue) * DisCount;
                this.txtShouldPay.EditValue = TotalAmount;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handles the Load event of the frmCheckOut control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-24
        private void frmCheckOut_Load(object sender, EventArgs e)
        {
            DataBindingControls();
        }

        /// <summary>
        /// Handles the Click event of the btnBack control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-24
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the btnOutList control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-24
        private void btnOutList_Click(object sender, EventArgs e)
        {
            try
            {
                ClassAssist.DataOperator.DataOut(this.gridViewMain, "消费记录");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the btnOutBill control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-24
        private void btnOutBill_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Shown event of the frmCheckOut control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-26
        private void frmCheckOut_Shown(object sender, EventArgs e)
        {
            if (this.IsShown == false)
                this.Hide();
        }

        /// <summary>
        /// Handles the CheckedChanged event of the chkVIP control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建时间：2013-03-02
        private void chkVIP_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkVIP.Checked == true)
            {
                FillInputInfo();
            }
            else
            {
                this.lupPayType.Enabled = true;
                this.spDisCount.Enabled = true;
            }
        }

        /// <summary>
        /// Fills the input info.
        /// </summary>
        /// 创建人：桂书丛
        /// 创建时间：2013-03-02
        private void FillInputInfo()
        {
            frmVIPClient.frmVIPSearch myfrmVIPSearch = new CMS.UILayer.frmVIPClient.frmVIPSearch();
            myfrmVIPSearch.ShowDialog();
            this.lupPayType.EditValue = VariedDefault.DefaultPayType;
            this.lupPayType.Enabled = false;
            VIPInfo = frmVIPClient.frmVIPSearch.VIPInfo;
            if (VIPInfo != null)
            {
                this.spDisCount.EditValue = VIPInfo["Discount"];
                this.spDisCount.Enabled = false;
                this.txtPayMoney.EditValue = Convert.ToDouble(VIPInfo["VIPCost"]);
                this.VIPID = Convert.ToInt32(VIPInfo["ID"]);
            }
        }

        /// <summary>
        /// Handles the EditValueChanged event of the txtPayMoney control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-3-3
        private void txtPayMoney_EditValueChanged(object sender, EventArgs e)
        {
            txtPayMoney_EditValueChanging(null,null);
        }

        /// <summary>
        /// Handles the EditValueChanged event of the spDisCount control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-3-3
        private void spDisCount_EditValueChanged(object sender, EventArgs e)
        {
            spDisCount_EditValueChanging(null,null);
        }
    }
}