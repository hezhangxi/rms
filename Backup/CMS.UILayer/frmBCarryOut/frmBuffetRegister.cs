
//******************************************************************************************************
//** Copyright (C) 2010-2013 重大网络教育学院
//** 创建人：桂书丛
//** 类名称\文件名：frmBuffetRegister
//** 类功能：注册窗体
//** 描 述：餐饮管理系统主窗体 注册窗体
//** 创建日期：2013-1-29
//** 修改(&U)人：桂书丛
//** 修改(&U)日期：2013-1-29
//** 整理日期：2013-1-29
//******************************************************************************************************

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
namespace CMS.UILayer.frmBCarryOut
{
    /// <summary>
    /// 
    /// </summary>
    /// 创建人：桂书丛
    /// 创建日期：2013-02-26
    public partial class frmBuffetRegister : DevExpress.XtraEditors.XtraForm
    {
        #region 变量定义
        private ModelCMS_Buffets myModelCMS_Buffets = new ModelCMS_Buffets();       //餐台实例
        private ListViewItem BuffetControl;                                         //消费餐台控件
        private BUCMS_ConsumptionReg myBUConsumptionReg = new BUCMS_ConsumptionReg();       //消费注册
        private string MarkID = string.Empty;                                       //消费单号
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="frmBuffetRegister"/> class.
        /// </summary>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-26
        public frmBuffetRegister()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 重载构造函数
        /// </summary>
        /// <param name="paramBuffetControl">The param list view item.</param>
        public frmBuffetRegister(ListViewItem paramBuffetControl)
        {
            InitializeComponent();
            this.BuffetControl = paramBuffetControl;
            this.myModelCMS_Buffets = ClassAssist.BuffetOperator.GetBuffetModel(paramBuffetControl);
            this.lblID.Text = myModelCMS_Buffets.ID.ToString();
            DisplayBuffetInfo();
        }

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

        #region private ModelCMS_ConsumptionReg GetConsumptionRegModel() 得到消费注册信息实体
        /// <summary>
        /// 得到消费注册信息实体
        /// </summary>
        /// <returns></returns>
        private ModelCMS_ConsumptionReg GetConsumptionRegModel()
        {
            ModelCMS_ConsumptionReg myModelCMS_ConsumptionReg = new ModelCMS_ConsumptionReg();
            try
            {
                myModelCMS_ConsumptionReg.BuffetsID = myModelCMS_Buffets.ID;
                myModelCMS_ConsumptionReg.CustomerNum = Convert.ToInt32(this.CustomerNum.Value);
                myModelCMS_ConsumptionReg.IsPaied = false;
                myModelCMS_ConsumptionReg.IsVIP = false;
                myModelCMS_ConsumptionReg.Description = this.txtDescription.Text.Trim();
                myModelCMS_ConsumptionReg.EmployeeID = Convert.ToInt32(this.lupEmployee.EditValue);
                myModelCMS_ConsumptionReg.MarkID = this.MarkID = ClassAssist.CommonOperator.GetRandomBillID();
                myModelCMS_ConsumptionReg.TotalAmount = 0;
                myModelCMS_ConsumptionReg.TypeID = Convert.ToInt32(VariedEnum.ConsumeWay.饭店消费);
                myModelCMS_ConsumptionReg.PayTypeID = VariedDefault.DefaultPayType;                                                
                myModelCMS_ConsumptionReg.CreatePerson = "服务员：" + this.lupEmployee.Text;
                myModelCMS_ConsumptionReg.CreateDate = myModelCMS_ConsumptionReg.ModifyDate = DateTime.Now;
                return myModelCMS_ConsumptionReg;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        /// <summary>
        /// Handles the Click event of the btnOK control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-27
        private void btnOK_Click(object sender, EventArgs e)
        {
            ModelCMS_ConsumptionReg tempCMS_ConsumptionReg = AddBuffetsRegInfo();
            if (tempCMS_ConsumptionReg == null)
            {
                XtraMessageBox.Show("开台失败，请确定信息输入正确","抱歉！",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            if (ClassAssist.BuffetOperator.UpdateBuffetInfo(this.BuffetControl,VariedEnum.BuffetStatus.占用,this.MarkID))
            {
                BUT_SysLog.InsertSysLog(VariedEnum.LogType.数据操作, frmAssist.frmLogin.SysUser.UserID, "新开餐台:" + myModelCMS_Buffets.Name);
                this.Close();
            }
            if (this.chkAuto.Checked == false)
                return;
            frmDineRegister myfrmDineRegister = new frmDineRegister(this.BuffetControl,tempCMS_ConsumptionReg);
            myfrmDineRegister.ShowDialog();
        }

        #region private ModelCMS_ConsumptionReg AddBuffetsRegInfo() 添加(&A)消费注册信息，成功后返回(&B)消费注册实例
        /// <summary>
        /// 添加(&A)消费注册信息，成功后返回(&B)消费注册实例
        /// </summary>
        /// <returns></returns>
        private ModelCMS_ConsumptionReg AddBuffetsRegInfo()
        {
            try
            {
                VariedEnum.OperatorStatus tempOperatorStatus;
                ModelCMS_ConsumptionReg tempCMS_ConsumptionReg = GetConsumptionRegModel();
                tempOperatorStatus = myBUConsumptionReg.Insert(tempCMS_ConsumptionReg);
                if (tempOperatorStatus == VariedEnum.OperatorStatus.Successed)
                    return tempCMS_ConsumptionReg;
                else
                    return null;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                return null;
            }
        }
        #endregion

        /// <summary>
        /// Handles the Click event of the btnCancel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-27
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the TextChanged event of the CustomerNum control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-27
        private void CustomerNum_TextChanged(object sender, EventArgs e)
        {
            int tempMax = Convert.ToInt32(this.lblANum.Text.Substring(0, lblANum.Text.Length - 1));
            if (CustomerNum.Value > tempMax)
            {
                XtraMessageBox.Show("将大于此餐台可容纳人数，请开多台", "操作违规",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.CustomerNum.EditValue = tempMax;
            }
        }

        /// <summary>
        /// Handles the Load event of the frmBuffetRegister control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-27
        private void frmBuffetRegister_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable tempDataTable = new BUCMS_Employee().GetOrder(true,string.Empty,string.Empty,false);
                this.lupEmployee.Properties.DataSource = tempDataTable;
                this.lupEmployee.ItemIndex = 0;
                this.MarkID = ClassAssist.CommonOperator.GetRandomBillID();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
    }
}