using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CMS.Model;
using CMS.BULayer;
using DevExpress.XtraEditors;

namespace CMS.UILayer.frmVIPClient
{
    /// <summary>
    /// 注册新会员
    /// </summary>
    /// 整理人：桂书丛
    /// 整理时间：2013-02-01
    public partial class frmRegisterNewVIP : DevExpress.XtraEditors.XtraForm
    {
        #region 定义变量
        BUCMS_VIPClient myBUCMS_VIPClient = new BUCMS_VIPClient();
        ModelCMS_VIPClient myModelCMS_VIPClient = new ModelCMS_VIPClient();
        private DataRow InfoDataRow;
        string VIPName = string.Empty;
        int BtnExit = 0;
        #endregion 

        public frmRegisterNewVIP()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="frmRegisterNewVIP"/> class.
        /// </summary>
        /// <param name="paramDataRow">The param data row.</param>
        /// <param name="paramVIPName">Name of the param VIP.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-01
        public frmRegisterNewVIP(DataRow paramDataRow, string paramVIPName)
        {
            InitializeComponent();
            this.InfoDataRow = paramDataRow;
            VIPName = paramVIPName;
        }

        #region private void InitializeForm(DataRow paramDataRow, string paramVIPName)初始化修改会员信息窗体
        /// <summary>
        /// 初始化修改会员信息窗体
        /// </summary>
        private void InitializeForm(DataRow paramDataRow, string paramVIPName)
        {
            this.Text = "修改会员信息";
            this.lblPerson.Text = "修改人:";
            this.lblDate.Text = "修改时间:";
            lblVIPCost.Text = "卡上余额:";
            this.btnExit.Text = "取消";
            BtnExit = 1;
            this.txtVIPName.Properties.ReadOnly = true;
            this.txtVIPName.TabStop = false;
            this.txtVIPName.Text = paramDataRow["Name"].ToString();
            this.cmbSex.Text = paramDataRow["Sex"].ToString();
            this.lkdVIPType.EditValue = paramDataRow["VIPTypeID"];
            this.calVIPCost.Value = Convert.ToDecimal(paramDataRow["VIPCost"]);//卡上余额
            this.cmbPosition.Text = paramDataRow["Position"].ToString();
            this.txtDepName.Text = paramDataRow["DepName"].ToString();
            this.txtPhone.Text = paramDataRow["TelPhone"].ToString();
            this.txtAddress.Text = paramDataRow["Address"].ToString();
            this.medInfoNote.Text = paramDataRow["InfoNote"].ToString();
        }
        #endregion

        #region public void InitializeControls()绑定数据到会员级别下拉框(会员卡信息)
        /// <summary>
        ///绑定数据到会员级别下拉框(会员卡信息)
        /// </summary>
        public void InitializeControls()
        {
            //获取CMS_VIPType表即会员卡信息表中的数据时直接调用BUCMS_VIPType的这个方法
            BUCMS_VIPType myBUCMS_VIPType = new BUCMS_VIPType();
            try
            {
                DataTable myDataTable = myBUCMS_VIPType.GetOrder(false, string.Empty, string.Empty, false);
               //绑定到下拉框
                this.lkdVIPType.Properties.DataSource = myDataTable;
                this.lkdVIPType.ItemIndex = 0;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        #endregion

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-01
        private void frmRegisterNewVIP_Load(object sender, EventArgs e)
        {
            //把会员卡信息添加到会员级别下拉框
            InitializeControls();
            if(VIPName!=string.Empty)//说明是修改会员信息
                InitializeForm(InfoDataRow, VIPName);
            this.txtCreatePerson.Text = frmAssist.frmLogin.SysUser.UserName.ToString();
            this.txtCreateDate.Text = DateTime.Now.ToString();
        }

        #region private bool Register()注册会员(添加)
        /// <summary>
        /// 注册会员(添加)
        /// </summary>
        /// <returns></returns>
        private bool Register()
        {
          if(ClassAssist.CommonOperator.HandleOperatorEnum("注册新会员",Add()))
          {
              BUT_SysLog.InsertSysLog(VariedEnum.LogType.数据操作,frmAssist.frmLogin.SysUser.UserID,"成功注册了一个新会员");
              this.DialogResult = DialogResult.OK;
          }
          return true;
        }
        #endregion

        #region private VariedEnum.OperatorStatus Add()添加数据
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <returns></returns>
        private VariedEnum.OperatorStatus Add()
        {
            myModelCMS_VIPClient.Name = this.txtVIPName.Text.Trim().ToString();
            myModelCMS_VIPClient.Sex = this.cmbSex.Text;
            myModelCMS_VIPClient.VIPTypeID = Convert.ToInt32(this.lkdVIPType.EditValue.ToString());
            myModelCMS_VIPClient.VIPCost = Convert.ToDecimal(this.calVIPCost.Value);
            myModelCMS_VIPClient.Position = this.cmbPosition.Text.Trim().ToString();
            myModelCMS_VIPClient.DepName = this.txtDepName.Text.Trim().ToString();
            myModelCMS_VIPClient.TelPhone = this.txtPhone.Text.Trim().ToString();
            myModelCMS_VIPClient.Address = this.txtAddress.Text.Trim().ToString();
            myModelCMS_VIPClient.CreatePerson = this.txtCreatePerson.Text.Trim().ToString();
            myModelCMS_VIPClient.CreateDate = DateTime.Now;
            myModelCMS_VIPClient.InfoNote = this.medInfoNote.Text.Trim().ToString();
            myModelCMS_VIPClient.IsClient = false;//不是客户
            return myBUCMS_VIPClient.Insert(myModelCMS_VIPClient);
        }
        #endregion
  
        /// <summary>
        /// Handles the Click event of the btnOK control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-01
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.txtVIPName.Text.Trim().ToString().Length==0)
            {
                XtraMessageBox.Show("会员名不能为空!");
                this.txtVIPName.Focus();
                this.txtVIPName.SelectAll();
                return ;
            }
            if(this.Text=="注册新会员")
            {
                 if (Register() == false)//注册（添加）
                   return;
            }
            if(this.Text=="修改会员信息")
            {
                if(CheckIsUpdate()==false)//先判断是否做了改动
                {
                    return;
                }
                if (UpdateVIPInfo()==false)  //修改
                {
                    return;
                }
            }
        }

        #region 修改会员
        #region private bool CheckIsUpdate()判断是否做了改动
        /// <summary>
        /// 判断是否做了改动
        /// </summary>
        /// <returns></returns>
        private bool CheckIsUpdate()
        {
            if (this.cmbSex.Text == InfoDataRow["Sex"].ToString())
            {
                if (this.lkdVIPType.Text.ToString() == VIPName)
                {
                    if (this.cmbPosition.Text.ToString() == InfoDataRow["Position"].ToString())
                    {
                        if (this.txtDepName.Text.ToString() == InfoDataRow["DepName"].ToString())
                        {
                            if (this.txtPhone.Text.ToString() == InfoDataRow["TelPhone"].ToString())
                            {
                                if (this.txtAddress.Text.ToString() == InfoDataRow["Address"].ToString())
                                {
                                    if (this.medInfoNote.Text.ToString() == InfoDataRow["InfoNote"].ToString())
                                    {
                                        if (this.calVIPCost.Value.ToString() == InfoDataRow["VIPCost"].ToString())
                                        {
                                            XtraMessageBox.Show("您未做任何修改!");
                                            return false;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return true;
        }
        #endregion

        #region private bool UpdateVIPInfo()
        /// <summary>
        /// 修改会员(写入日志)
        /// </summary>
        /// <returns></returns>
        private bool UpdateVIPInfo()
        {
            if (ClassAssist.CommonOperator.HandleOperatorEnum("会员信息修改", Update()))
            {
                BUT_SysLog.InsertSysLog(VariedEnum.LogType.数据操作, frmAssist.frmLogin.SysUser.UserID,"成功修改了一条会员信息!");
                this.DialogResult = DialogResult.OK;
            }
            return true;
        }
        #endregion

        #region private bool Update()修改会员信息
        /// <summary>
        /// 修改会员信息
        /// </summary>
        /// <returns></returns>
        private VariedEnum.OperatorStatus Update()
        {
            myModelCMS_VIPClient.ID = Convert.ToInt32(InfoDataRow["ID"]);
            myModelCMS_VIPClient.VIPTypeID = Convert.ToInt32(this.lkdVIPType.EditValue);
            myModelCMS_VIPClient.VIPCost = this.calVIPCost.Value;
            myModelCMS_VIPClient.Position = this.cmbPosition.Text.Trim().ToString();
            myModelCMS_VIPClient.DepName=this.txtDepName.Text.Trim().ToString();
            myModelCMS_VIPClient.TelPhone = this.txtPhone.Text.Trim().ToString();
            myModelCMS_VIPClient.Address = this.txtAddress.Text.Trim().ToString();
            myModelCMS_VIPClient.InfoNote = this.medInfoNote.Text.Trim().ToString();
            myModelCMS_VIPClient.ModifyPerson =this.txtCreatePerson.Text.ToString();
            myModelCMS_VIPClient.ModifyDate = Convert.ToDateTime(this.txtCreateDate.Text);
            return  myBUCMS_VIPClient.Update(myModelCMS_VIPClient);
        }
        #endregion

        #endregion 

        /// <summary>
        /// Handles the Click event of the btnExit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-01
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (BtnExit == 1)
            {
                this.Close();
            }
            else
            {
                this.txtVIPName.Text = "";
                this.calVIPCost.Value = 0;
                this.cmbPosition.Text = "";
                this.txtDepName.Text = "";
                this.txtAddress.Text = "";
                this.txtPhone.Text = "";
                this.medInfoNote.Text = "";
                this.txtVIPName.Focus();
                this.txtVIPName.SelectAll();
            }
        }
    }
}
