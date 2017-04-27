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

namespace CMS.UILayer.frmFinance
{
    public partial class frmFinanceRegister : DevExpress.XtraEditors.XtraForm
    {
        #region 定义变量
        BUCMS_PaymentsDetail myBUCMS_PaymentsDetail = new BUCMS_PaymentsDetail();
        object[] tempInfo = null;
        #endregion
        public frmFinanceRegister()
        {
            InitializeComponent();
        }

        private void btnFinanceRegisterAdd_Click(object sender, EventArgs e)
        {
            frmFinanceRegisterOperate myfrmFinanceDetailOperate = new frmFinanceRegisterOperate();
            if (myfrmFinanceDetailOperate.ShowDialog() == DialogResult.OK)
                BindGridControl();
        }

        private void btnFinanceRegisterDele_Click(object sender, EventArgs e)
        {
            if (this.gridViewFinanceRegister.SelectedRowsCount <= 0)
            {
                XtraMessageBox.Show("请先选择要删除(&D)的项", "操作违规",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string tempID = this.gridViewFinanceRegister.GetFocusedRowCellValue("编号").ToString();
            DialogResult tempDialogResult = XtraMessageBox.Show("编号为：" + tempID + "的财务记录",
                "确定删除(&D)", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == tempDialogResult)
            {
                VariedEnum.OperatorStatus EnOperatorStatus;
                try
                {
                    EnOperatorStatus = myBUCMS_PaymentsDetail.Delete(tempID);
                    if (ClassAssist.CommonOperator.HandleOperatorEnum("删除(&D)", EnOperatorStatus))
                    {
                        BUT_SysLog.InsertSysLog(VariedEnum.LogType.系统事件, frmAssist.frmLogin.SysUser.UserID,
                            "成功删除(&D)了编号为：" + tempID + "的财务记录");
                        BindGridControl();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("请确定该条数据没用正在使用后重试", "删除(&D)失败",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnFinanceRegisterAlter_Click(object sender, EventArgs e)
        {
            if (this.gridViewFinanceRegister.SelectedRowsCount <= 0)
            {
                XtraMessageBox.Show("请先选择要修改(&U)的项", "操作违规",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            tempInfo = ClassAssist.CommonOperator.GetGVSelectRowInfo(this.gridViewFinanceRegister);
            if (tempInfo != null)
            {
                frmFinanceRegisterOperate myfrmFinanceDetailOperate = new frmFinanceRegisterOperate(tempInfo);
                if (myfrmFinanceDetailOperate.ShowDialog() == DialogResult.OK)
                    BindGridControl();
            }
        }

        private void btnFinanceRegisterOut_Click(object sender, EventArgs e)
        {

        }

        private void btnFinanceRegisterPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnFinanceRegisterBack_Click(object sender, EventArgs e)
        {

        }

        private void frmFinanceRegister_Load(object sender, EventArgs e)
        {
            BindGridControl();
        }

        private void BindGridControl()
        {
            DataTable myDataTable = myBUCMS_PaymentsDetail.GetOrder(true, string.Empty, string.Empty, false);
            this.grdctrlItemManagement.DataSource = myDataTable;
        }

    }
}