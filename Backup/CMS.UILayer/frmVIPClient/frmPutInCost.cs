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
    /// 会员充值
    /// </summary>
    /// 整理人：桂书丛
    /// 整理时间：2013-02-28
    public partial class frmPutInCost : DevExpress.XtraEditors.XtraForm
    {
        private int VIPClientID = 0;
        /// <summary>
        /// Initializes a new instance of the <see cref="frmPutInCost"/> class.
        /// </summary>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-28
        public frmPutInCost()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="frmPutInCost"/> class.
        /// </summary>
        /// <param name="paramDataRow">The param data row.</param>
        /// <param name="paramVIPName">Name of the param VIP.</param>
        /// <param name="paramVIPDiscount">The param VIP discount.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-28
        public frmPutInCost(DataRow paramDataRow,object paramVIPName,object paramVIPDiscount)
        {
            InitializeComponent();
            if(Convert.ToBoolean(paramDataRow["IsClient"])==true)
            {
                this.Text = "客户充值";
            }
            this.txtVIPName.Text =paramDataRow["Name"].ToString();
            this.txtDiscount.Text = paramVIPDiscount.ToString();
            this.txtVIPType.Text = paramVIPName.ToString();
            this.txtVIPCost.Text=paramDataRow["VIPCost"].ToString();
            this.txtDate.Text = DateTime.Now.ToString();
            VIPClientID=Convert.ToInt32(paramDataRow["ID"]);
        }

        /// <summary>
        /// Handles the Click event of the btnOK control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-28
        private void btnOK_Click(object sender, EventArgs e)
        {
            if(this.calCost.Value <= 0)
            {
                XtraMessageBox.Show("您还未输入充值金额或输入金额为负","提示：");
                this.calCost.Focus();
                this.calCost.SelectAll();
                return;
            }
            if (ClassAssist.CommonOperator.HandleOperatorEnum("会员卡充值", UpdateCost()))
            {
                BUT_SysLog.InsertSysLog(VariedEnum.LogType.数据操作, frmAssist.frmLogin.SysUser.UserID,"为会员:"+this.txtVIPName.Text+"成功充值了："+this.calCost.Text);
                this.DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// Updates the cost.
        /// </summary>
        /// <returns></returns>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-28
        private VariedEnum.OperatorStatus UpdateCost()
        {
            try
            {
                ModelCMS_VIPClient myModelCMS_VIPClient = new ModelCMS_VIPClient();
                Decimal TotalCost = Convert.ToDecimal(this.txtVIPCost.Text) + Convert.ToDecimal(this.calCost.Value);
                myModelCMS_VIPClient.VIPCost = Convert.ToDecimal(TotalCost);
                myModelCMS_VIPClient.ID = VIPClientID;
                myModelCMS_VIPClient.RechargeDate = Convert.ToDateTime(this.txtDate.Text);
                return new BUCMS_VIPClient().Update(myModelCMS_VIPClient, "");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
            return VariedEnum.OperatorStatus.Successed;
        }

        /// <summary>
        /// Handles the Click event of the btnExit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-28
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
