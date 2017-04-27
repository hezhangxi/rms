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
    /// 餐台预定
    /// </summary>
    /// 创建人：桂书丛
    /// 创建日期：2013-02-26
    public partial class frmBuffetBook : DevExpress.XtraEditors.XtraForm
    {
        #region 变量定义
        private ListViewItem BuffetControl;
        private bool IsInputOver = false;
        #endregion 

        /// <summary>
        /// Initializes a new instance of the <see cref="frmBuffetBook"/> class.
        /// </summary>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-26
        public frmBuffetBook()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="frmBuffetBook"/> class.
        /// </summary>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-26
        public frmBuffetBook(ListViewItem tempBuffetControl)
        {
            InitializeComponent();
            this.BuffetControl = tempBuffetControl;
            this.dataEnd.EditValue = DateTime.Now;
            this.timeEnd.EditValue = DateTime.Now.TimeOfDay;
        }

        /// Initializes the controls.
        /// </summary>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-26
        private void InitializeControls()
        {
            DisplayBuffetInfo();
            this.txtTranstor.Text = frmAssist.frmLogin.SysUser.UserName;
            this.txtStart.Text = DateTime.Now.ToString();
        }

        #region private void DisplayBuffetInfo() 显示餐台信息
        /// <summary>
        /// 显示餐台信息
        /// </summary>
        private void DisplayBuffetInfo()
        {
            ModelCMS_Buffets tempModelCMS_Buffets = new ModelCMS_Buffets();
            tempModelCMS_Buffets = ClassAssist.BuffetOperator.GetBuffetModel(this.BuffetControl);
            Control[] tempShowControl = new Control[5];
            tempShowControl[0] = this.lblID;
            tempShowControl[1] = this.lblName;
            tempShowControl[2] = this.lblStatus;
            tempShowControl[3] = this.lblStatus;
            tempShowControl[4] = this.lblInfoNote;
            ClassAssist.BuffetOperator.ShowBuffetInfo(tempModelCMS_Buffets, tempShowControl);
        }
        #endregion

        #region private bool CheckInput() 自定义方法：检测用户输入
        /// <summary>
        /// 自定义方法：检测用户输入
        /// </summary>
        /// <returns></returns>
        /// 创建人：桂书丛
        /// 创建日期：2013-2-28
        private bool CheckInput()
        {
            string CName = this.txtCName.Text.Trim();
            string CTelPhone = this.txtCTelPhone.Text.Trim();
            if (CName.Length == 0)
            {
                XtraMessageBox.Show("请输入顾客名称", "信息输入不完整",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtCName.Focus();
                return false;
            }
            if (CTelPhone.Length == 0)
            {
                XtraMessageBox.Show("请输入顾客联系电话", "信息输入不完整",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtCTelPhone.Focus();
                return false;
            }
            return true;
        }
        #endregion

        /// <summary>
        /// Handles the Click event of the btnOK control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
                return;
            VariedEnum.OperatorStatus EnOperatorStatus;
            try
            {
                EnOperatorStatus = new BUCMS_BuffetBooking().Insert(GetModel());
                if (ClassAssist.CommonOperator.HandleOperatorEnum("餐台预定", EnOperatorStatus))
                {
                    if (ClassAssist.BuffetOperator.UpdateBuffetInfo(this.BuffetControl, VariedEnum.BuffetStatus.预定, string.Empty))
                    {
                        BUT_SysLog.InsertSysLog(VariedEnum.LogType.数据操作, frmAssist.frmLogin.SysUser.UserID, "成功办理了一次顾客餐台预定");
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 获得信息实体
        /// </summary>
        /// <returns></returns>
        /// 创建人：桂书丛
        /// 创建日期：2013-2-28
        private ModelCMS_BuffetBooking GetModel()
        {
            ModelCMS_BuffetBooking tempModelCMS_BuffetBooking = new ModelCMS_BuffetBooking();
            try                                      
            {
                tempModelCMS_BuffetBooking.BuffetsID = Convert.ToInt32(this.lblID.Text.Trim());
                tempModelCMS_BuffetBooking.BooKDate = DateTime.Now;
                tempModelCMS_BuffetBooking.CName = this.txtCName.Text.Trim();
                tempModelCMS_BuffetBooking.CNum = Convert.ToInt32(this.speCNum.Value);                    
                tempModelCMS_BuffetBooking.CTelPhone = this.txtCTelPhone.Text.Trim();
                tempModelCMS_BuffetBooking.InfoNote = this.txtInfoNote.Text.Trim();
                tempModelCMS_BuffetBooking.Transactor = frmAssist.frmLogin.SysUser.UserName;
                tempModelCMS_BuffetBooking.BooKDate = Convert.ToDateTime(this.txtStart.Text);
                string tempLongTime = this.dataEnd.Text + " " + this.timeEnd.Text;
                tempModelCMS_BuffetBooking.OverduTtime = Convert.ToDateTime(tempLongTime);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
            return tempModelCMS_BuffetBooking;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the TextChanged event of the speCNum control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void speCNum_TextChanged(object sender, EventArgs e)
        {
            if (this.IsInputOver == true)
            {
                int tempMax = Convert.ToInt32(this.lblANum.Text.Substring(0, lblANum.Text.Length - 1));
                if (speCNum.Value > tempMax)
                {
                    XtraMessageBox.Show("将大于此餐台可容纳人数，请预定多台", "操作违规", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.speCNum.EditValue = tempMax;
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the btnChoose control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建时间：2013-03-03
        private void btnChoose_Click(object sender, EventArgs e)
        {
            frmVIPClient.frmVIPSearch myfrmVIPSearch = new CMS.UILayer.frmVIPClient.frmVIPSearch();
            myfrmVIPSearch.ShowDialog();
            DataRow tempDataRow = frmVIPClient.frmVIPSearch.VIPInfo;
            if (tempDataRow != null)
            {
                this.txtCName.Text = tempDataRow["Name"].ToString();
                this.txtCTelPhone.Text = tempDataRow["TelPhone"].ToString();
                this.txtInfoNote.Text = "现有：名称为" + this.txtCName.Text + "的开台";
            }
        }

        /// <summary>
        /// Handles the TextChanged event of the dataEnd control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-04
        private void dataEnd_TextChanged(object sender, EventArgs e)
        {
            string tempDateTime = this.dataEnd.Text + " " + this.timeEnd.Text;
            DateTime tempOver = Convert.ToDateTime(tempDateTime);
            if (DateDiff(DateTime.Now, tempOver) >= 0)
            {
                XtraMessageBox.Show("失效时间必须大于当前时间", "信息输入不正确", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.dataEnd.EditValue = DateTime.Now;
                this.timeEnd.EditValue = DateTime.Now.TimeOfDay;
            }
            this.IsInputOver = true;
        }

        /// <summary>
        /// 计算两个日期的时间间隔,返回(&B)他们之间相差的分钟数(paramDateTime1-paramDateTime2)
        /// </summary>
        /// <param name="paramDateTime1">The param date time1.</param>
        /// <param name="paramDateTime2">The param date time2.</param>
        /// <returns></returns>
        private int DateDiff(DateTime paramDateTime1, DateTime paramDateTime2)
        {
            int dateDiff = -5;
            TimeSpan ts1 = new TimeSpan(paramDateTime1.Ticks);
            TimeSpan ts2 = new TimeSpan(paramDateTime2.Ticks);
            TimeSpan ts = ts1.Subtract(ts2).Duration();
            dateDiff = ts.Minutes;
       
            return dateDiff;
        }

        /// <summary>
        /// Handles the TextChanged event of the timeEnd control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-04
        private void timeEnd_TextChanged(object sender, EventArgs e)
        {
            dataEnd_TextChanged(sender,e);
            this.IsInputOver = true;
        }
    }
}