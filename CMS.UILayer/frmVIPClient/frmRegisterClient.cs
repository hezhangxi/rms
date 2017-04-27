using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CMS.BULayer;
using CMS.Model;
using DevExpress.XtraEditors;

namespace CMS.UILayer.frmVIPClient
{
    public partial class frmRegisterClient : DevExpress.XtraEditors.XtraForm
    {
        #region 变量定义
        BUCMS_VIPClient myBUCMS_VIPClient = new BUCMS_VIPClient();
        ModelCMS_VIPClient myModelCMS_VIPClient = new ModelCMS_VIPClient();
        DataTable myDataTable = new DataTable();
        string VIPName = null;
        DataRow myDataRow;
        int Exit = 0;
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="frmRegisterClient"/> class.
        /// </summary>
        /// 整理人：桂书丛
        /// 整理日期：2013-2-1
        public frmRegisterClient()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="frmRegisterClient"/> class.
        /// </summary>
        /// <param name="paramDataRow">The param data row.</param>
        /// <param name="paramVIPName">Name of the param VIP.</param>
        /// 整理人：桂书丛
        /// 整理日期：2013-2-1
        public frmRegisterClient(DataRow paramDataRow,string paramVIPName)
        {
            InitializeComponent();
            VIPName = paramVIPName;
            myDataRow = paramDataRow;
        }

        #region  private void UpdateControls(DataRow paramDataRow,string paramVIPName) 更新控件
        /// <summary>
        /// 更新控件
        /// </summary>
        /// <param name="paramDataRow"></param>
        /// <param name="paramVIPName"></param>
        private void UpdateControls(DataRow paramDataRow, string paramVIPName)
        {
            Exit = 1;
            this.Text = "修改客户信息";
            this.lblCost.Text = "可用余额";
            this.lblPerson.Text = "修改人";
            this.lblDate.Text = "修改时间";
            this.btnExit.Text = "取消";
            this.txtClientName.Text=paramDataRow["Name"].ToString();
            this.cmbSex.Text = paramDataRow["Sex"].ToString();
            this.lupVIPType.EditValue = paramDataRow["VIPTypeID"];
            this.calCost.Text =paramDataRow["VIPCost"].ToString();
            this.cmbPosition.Text = paramDataRow["Position"].ToString();
            this.txtDepName.Text = paramDataRow["DepName"].ToString();
            this.txtPhone.Text = paramDataRow["TelPhone"].ToString();
            this.txtAddress.Text = paramDataRow["Address"].ToString();
            this.medInfoNote.Text = paramDataRow["InfoNote"].ToString();
        }
        #endregion

        #region 公共部分

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
                this.lupVIPType.Properties.DataSource = myDataTable;
                this.lupVIPType.ItemIndex = 0;
                this.lupVIPType.Properties.DisplayMember = "Name";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理日期：2013-3-1
        private void frmRegisterClient_Load(object sender, EventArgs e)
        {
            InitializeControls();
            if (VIPName != null)
            {
                UpdateControls(myDataRow, VIPName);
            }
            this.txtCreatePerson.Text = frmAssist.frmLogin.SysUser.UserName;
            this.txtCreateDate.Text = DateTime.Now.ToString();
        }
        #endregion

        #endregion 

        /// <summary>
        /// 确定按钮
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理日期：2013-2-1
        private void btnOK_Click(object sender, EventArgs e)
        {
            if(this.Text=="登记新客户")
            {
                if( RegisterClient()==false)
                    return ;
            }
            if(this.Text=="修改客户信息")
            {
                if (CheckIsUpdate() == false)               //先判断是否做了改动
                {
                    return;
                }
                if (UpdateClientInfo() == false)            //修改
                {
                    return;
                }
            }
        }

        #region 登记新客户

        #region private bool RegisterClient()
        /// <summary>
        /// 登记新客户
        /// </summary>
        /// <returns></returns>
        private bool RegisterClient()
        {
          if(this.txtClientName.Text.Length==0)
          {
              XtraMessageBox.Show("客户名不能为空!");
              return false;
          }
          if (ClassAssist.CommonOperator.HandleOperatorEnum("登记新客户", Add()))
          {
              BUT_SysLog.InsertSysLog(VariedEnum.LogType.数据操作, frmAssist.frmLogin.SysUser.UserID,"成功登记了一个新客户");
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
            try
            {
                myModelCMS_VIPClient.Name = this.txtClientName.Text.Trim().ToString();
                myModelCMS_VIPClient.Sex = this.cmbSex.Text.Trim();
                myModelCMS_VIPClient.VIPTypeID = Convert.ToInt32(this.lupVIPType.EditValue.ToString());
                myModelCMS_VIPClient.Position = this.cmbPosition.Text.Trim().ToString();
                myModelCMS_VIPClient.DepName = this.txtDepName.Text.Trim().ToString();
                myModelCMS_VIPClient.TelPhone = this.txtPhone.Text.Trim().ToString();
                myModelCMS_VIPClient.Address = this.txtAddress.Text.Trim().ToString();
                myModelCMS_VIPClient.VIPCost = Convert.ToDecimal(this.calCost.Text);
                myModelCMS_VIPClient.CreatePerson = this.txtCreatePerson.Text.Trim().ToString();
                myModelCMS_VIPClient.CreateDate = DateTime.Now;
                myModelCMS_VIPClient.InfoNote = this.medInfoNote.Text.Trim();
                myModelCMS_VIPClient.IsClient = true;                      //表示是客户(为了和会员区分)
                return myBUCMS_VIPClient.Insert(myModelCMS_VIPClient);
            }
            catch (Exception ex)
            {
                return VariedEnum.OperatorStatus.Failed;
                XtraMessageBox.Show(ex.ToString());
            }
            return VariedEnum.OperatorStatus.Failed;
        }
        #endregion
        
        #endregion 

        #region 修改客户信息

        #region private bool CheckIsUpdate()判断是否做了改动
        /// <summary>
        /// 判断是否做了改动
        /// </summary>
        /// <returns></returns>
        private bool CheckIsUpdate()
        {
            if (this.cmbSex.Text == myDataRow["Sex"].ToString())
            {
                if (this.lupVIPType.Text.ToString() == VIPName)
                {
                    if (this.cmbPosition.Text.ToString() == myDataRow["Position"].ToString())
                    {
                        if (this.txtDepName.Text.ToString() == myDataRow["DepName"].ToString())
                        {
                            if (this.txtPhone.Text.ToString() == myDataRow["TelPhone"].ToString())
                            {
                                if (this.txtAddress.Text.ToString() == myDataRow["Address"].ToString())
                                {
                                    if (this.medInfoNote.Text.ToString() == myDataRow["InfoNote"].ToString())
                                    {
                                        if (this.calCost.Text.ToString() == myDataRow["VIPCost"].ToString())
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

        #region private bool UpdateClientInfo()修改客户信息写入日志)
        /// <summary>
        /// 修改客户信息写入日志)
        /// </summary>
        /// <returns></returns>
        private bool UpdateClientInfo()
        {
            if (ClassAssist.CommonOperator.HandleOperatorEnum("修改客户信息", Update()))
            {
                BUT_SysLog.InsertSysLog(VariedEnum.LogType.数据操作, frmAssist.frmLogin.SysUser.UserID,"成功修改了一条客户信息!");
                this.DialogResult = DialogResult.OK;
            }
            return true;
        }
        #endregion

        #region private bool Update() 修改客户信息
        /// <summary>
        /// 修改客户信息
        /// </summary>
        /// <returns></returns>
        private VariedEnum.OperatorStatus Update()
        {
            try
            {
                myModelCMS_VIPClient.ID = Convert.ToInt32(myDataRow["ID"]);
                myModelCMS_VIPClient.Name = this.txtClientName.Text.Trim();
                myModelCMS_VIPClient.VIPTypeID = Convert.ToInt32(this.lupVIPType.EditValue);
                myModelCMS_VIPClient.VIPCost = Convert.ToDecimal(this.calCost.Text);
                myModelCMS_VIPClient.Position = this.cmbPosition.Text.Trim();
                myModelCMS_VIPClient.DepName = this.txtDepName.Text.Trim();
                myModelCMS_VIPClient.TelPhone = this.txtPhone.Text.Trim();
                myModelCMS_VIPClient.Address = this.txtAddress.Text.Trim();
                myModelCMS_VIPClient.InfoNote = this.medInfoNote.Text.Trim();
                myModelCMS_VIPClient.ModifyPerson = this.txtCreatePerson.Text.Trim();
                myModelCMS_VIPClient.ModifyDate = Convert.ToDateTime(this.txtCreateDate.Text);
                return myBUCMS_VIPClient.Update(myModelCMS_VIPClient);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
                return VariedEnum.OperatorStatus.Failed;
            }
            return VariedEnum.OperatorStatus.Failed;
        }
        #endregion

        #endregion 

        /// <summary>
        /// Handles the Click event of the btnExit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理日期：2013-2-1
        private void btnExit_Click(object sender, EventArgs e)//取消/重置按钮
        {
            if (Exit == 1)
                this.Close();
            else
            {
                this.txtClientName.Text = "";
                this.cmbPosition.Text = "";
                this.txtDepName.Text = "";
                this.txtPhone.Text = "";
                this.txtAddress.Text = "";
                this.medInfoNote.Text = "";
            }
        }
    }
}
