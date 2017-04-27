using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using CMS.BULayer;
using DevExpress.XtraEditors;

namespace CMS.UILayer.frmFinance
{
    public partial class frmInOutItemManagement : DevExpress.XtraEditors.XtraForm
    {
        #region 变量定义
        DataTable myDataTable = new DataTable();
        BUCMS_PaymentsItem myBUCMS_PaymentsItem = new BUCMS_PaymentsItem();
        object[] tempInfo = null;
        #endregion
        public frmInOutItemManagement()
        {
            InitializeComponent();
        }

        private void btneInOutItemAdd_Click(object sender, EventArgs e)
        {
            frmFinaceOperate myfrmFinaceOperate = new frmFinaceOperate();
            if (myfrmFinaceOperate.ShowDialog() == DialogResult.OK)
                BindGridControl();
        }

        private void btnInOutItemDele_Click(object sender, EventArgs e)
        {
            if (this.gridViewInOutItemInfo.SelectedRowsCount <= 0)
            {
                XtraMessageBox.Show("请先选择要删除(&D)的项", "操作违规",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string tempID = this.gridViewInOutItemInfo.GetFocusedRowCellValue("ID").ToString();
            DialogResult tempDialogResult = XtraMessageBox.Show("编号为：" + tempID + "的项目信息",
                "确定删除(&D)", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == tempDialogResult)
            {
                VariedEnum.OperatorStatus EnOperatorStatus;
                try
                {
                    EnOperatorStatus = myBUCMS_PaymentsItem.Delete(tempID);
                    if (ClassAssist.CommonOperator.HandleOperatorEnum("删除(&D)", EnOperatorStatus))
                    {
                        BUT_SysLog.InsertSysLog(VariedEnum.LogType.系统事件, frmAssist.frmLogin.SysUser.UserID,
                            "成功删除(&D)了编号为：" + tempID + "的项目信息");
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

        private void btnInOutItemAlter_Click(object sender, EventArgs e)
        {
            if (this.gridViewInOutItemInfo.SelectedRowsCount <= 0)
            {
                XtraMessageBox.Show("请先选择要修改(&U)的项", "操作违规",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            tempInfo = ClassAssist.CommonOperator.GetGVSelectRowInfo(this.gridViewInOutItemInfo);
            if (tempInfo != null)
            {
                frmFinaceOperate myfrmFinaceOperate = new frmFinaceOperate(tempInfo);
                if (myfrmFinaceOperate.ShowDialog() == DialogResult.OK)
                    BindGridControl();
            }
        }

        private void btnInOutItemOut_Click(object sender, EventArgs e)
        {
            try
            {
                ClassAssist.DataOperator.DataOut(this.gridViewInOutItemInfo,"收支项目信息");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }

        private void btnInOutItemPrint_Click(object sender, EventArgs e)
        {
            try
            {
                ClassAssist.DataOperator.DataPrint(this.grdctrlInOutItemInfo, "收支项目信息",null);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }

        private void frmInOutItemManagement_Load(object sender, EventArgs e)
        {
            BindGridControl();        
        }

        private void BindGridControl()
        {
            myDataTable = myBUCMS_PaymentsItem.GetOrder(false, string.Empty, string.Empty, false);
            if (myDataTable.Rows.Count < 0)
                return;
            else
                this.grdctrlInOutItemInfo.DataSource = myDataTable;
        }
    }
}