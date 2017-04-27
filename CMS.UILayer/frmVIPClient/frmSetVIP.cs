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
    /// <summary>
    /// VIP卡设置
    /// </summary>
    /// 整理人：桂书丛
    /// 整理时间：2013-02-01
    public partial class frmSetVIP : DevExpress.XtraEditors.XtraForm
    {
        private BUCMS_VIPType myBUCMS_VIPType = new BUCMS_VIPType();

        /// <summary>
        /// Initializes a new instance of the <see cref="frmSetVIP"/> class.
        /// </summary>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-01
        public frmSetVIP()
        {
            InitializeComponent();

        }

        #region public void InitializeControls()绑定数据到gridControl表格(会员卡信息)
        /// <summary>
        /// 绑定数据到gridControl表格(会员卡信息)
        /// </summary>
        public void InitializeControls() 
        {
            try
            {
                DataTable myDataTable = myBUCMS_VIPType.GetOrder(false,string.Empty,string.Empty,false);
                this.gridControlMain.DataSource = myDataTable;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message); 
            }
        }
        #endregion

        /// <summary>
        /// Handles the Load event of the frmSetVIP control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-01
        private void frmSetVIP_Load(object sender, EventArgs e)
        {
            InitializeControls();//绑定数据
        }

        /// <summary>
        /// 修改按钮
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-01
        private void btnUpdate_Click(object sender, EventArgs e)//
        {
            if (this.gridViewMain.SelectedRowsCount <= 0)//如果一项都没有选中
            {
                XtraMessageBox.Show("请选择要修改的项!","注意:",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            object[] tempInfo = ClassAssist.CommonOperator.GetGVSelectRowInfo(this.gridViewMain);//选中的行
            frmVIPClient.frmUpdateVIPCard myUpdateVIP = new frmUpdateVIPCard(tempInfo);//通过构造函数把选中行的数据传到修改窗
            if (myUpdateVIP.ShowDialog() == DialogResult.OK)
                InitializeControls();
        }

        /// <summary>
        /// 添加按钮
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-01
        private void btnAddNewVIP_Click(object sender, EventArgs e)
        {
            frmVIPClient.frmUpdateVIPCard myfrmAddVIPCard = new frmUpdateVIPCard();
            if (myfrmAddVIPCard.ShowDialog() == DialogResult.OK)
                InitializeControls();
        }
        

        /// <summary>
        /// Handles the Click event of the btnCancle control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-01
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the btnPrint control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-01
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                ClassAssist.DataOperator.DataPrint(this.gridControlMain, "会员卡信息",null);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the btnDel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-06
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (this.gridViewMain.SelectedRowsCount <= 0)//如果一项都没有选中
            {
                XtraMessageBox.Show("请选择要删除的项!", "注意:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string VIPID = this.gridViewMain.GetFocusedRowCellValue("ID").ToString();//选中的行的ID，根据这个来删除
            DialogResult myDialogResult = XtraMessageBox.Show("编号为" + VIPID + "的会员卡?","确定删除？", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == myDialogResult)
            {
                BUCMS_VIPType myBUCMS_VIPType = new BUCMS_VIPType();
                VariedEnum.OperatorStatus EnOperatorStatus;
                try
                {
                    EnOperatorStatus = myBUCMS_VIPType.Delete(VIPID);
                    if (ClassAssist.CommonOperator.HandleOperatorEnum("删除", EnOperatorStatus))
                    {
                        BUT_SysLog.InsertSysLog(VariedEnum.LogType.系统事件, frmAssist.frmLogin.SysUser.UserID,"成功删除了编号为" + VIPID + "的会员卡信息");
                        InitializeControls();
                    }
                }
                catch
                {
                    XtraMessageBox.Show("请确定此条数据不正在被使用后重试", "删除失败",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the btnOut control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-06
        private void btnOut_Click(object sender, EventArgs e)
        {
            try
            {
                ClassAssist.DataOperator.DataOut(this.gridViewMain, "会员卡信息");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }
    }
}
