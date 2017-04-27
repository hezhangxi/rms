using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CMS.UILayer.frmBCarryOut
{
    /// <summary>
    /// 预定信息确定
    /// </summary>
    /// 整理人：桂书丛
    /// 整理时间：2013-02-02
    public partial class frmScheduledDeterminee : DevExpress.XtraEditors.XtraForm
    {
        #region 变量定义
        private DataRow BuffetBookInfo;
        #endregion 

        /// <summary>
        /// Initializes a new instance of the <see cref="frmScheduledDeterminee"/> class.
        /// </summary>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-02
        public frmScheduledDeterminee()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 预定信息数据集
        /// </summary>
        /// <param name="paramBuffetInfo">The param buffet info.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-02
        public frmScheduledDeterminee(object paramBuffetInfo)
        {
            InitializeComponent();
            if (paramBuffetInfo == null)
                return;
            else
            {
                DataRow tempDataRow = (DataRow)paramBuffetInfo;
                this.BuffetBookInfo = tempDataRow;
            }
        }

        /// <summary>
        /// Handles the Click event of the btnOK control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建时间：2013-02-02
        private void btnOK_Click(object sender, EventArgs e)
        {
            string tempCustomerName = this.txtName.Text.Trim();
            string tempPhone = this.txtPhone.Text.Trim();
            if (tempCustomerName.Length == 0 && tempPhone.Length == 0)
            {
                XtraMessageBox.Show("请至少输入一个条件","信息输入不完整",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            else if (this.radioGroupRelation.SelectedIndex == 0)
            {
                if (tempCustomerName == this.BuffetBookInfo["CName"].ToString())
                    this.DialogResult = DialogResult.OK;
                else if (tempPhone == this.BuffetBookInfo["CTelPhone"].ToString())
                    this.DialogResult = DialogResult.OK;
                else
                    XtraMessageBox.Show("预定信息错误，暂无法开餐台", "抱歉,暂无法开餐台", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (this.radioGroupRelation.SelectedIndex == 1)
            {
                if (tempCustomerName == this.BuffetBookInfo["CName"].ToString())
                    if (tempPhone == this.BuffetBookInfo["CTelPhone"].ToString())
                        this.DialogResult = DialogResult.OK;
            }
            else
                XtraMessageBox.Show("预定信息错误，暂无法开餐台", "抱歉,暂无法开餐台", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}