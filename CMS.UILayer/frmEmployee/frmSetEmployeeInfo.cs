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

namespace CMS.UILayer.frmEmployee
{
    /// <summary>
    /// 
    /// </summary>
    /// 整理人：桂书丛
    /// 整理时间：2013-02-01
    public partial class frmSetEmployeeInfo : DevExpress.XtraEditors.XtraForm
    {
        BUCMS_DPInfo myBUCMS_DPInfo = new BUCMS_DPInfo();
        DataTable myDataTable = new DataTable();
        int myDepID = 0; //添加(&A)职位的时候用来初始化部门默认值(保存的是选中部门的ID)
        public frmSetEmployeeInfo()
        {
            InitializeComponent();
        }

        #region public void BindingDeP()绑定部门
        /// <summary>
        /// 绑定部门
        /// </summary>
        public  void BindingDeP()
        {
            try
            {
                myDataTable = myBUCMS_DPInfo.GetOrder(false,"SubID","0",false);
                this.gridControlDep.DataSource = myDataTable;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        #endregion

        private void frmSetEmployeeInfo_Load(object sender, EventArgs e)
        {
            BindingDeP();
            //BindingPos();
        }

        #region 部门

        /// <summary>
        /// Handles the Click event of the btnAddDep control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-06
        private void btnAddDep_Click(object sender, EventArgs e) //添加(&A)部门
        {
            frmAdd myfrmAdd = new frmAdd();
            if (myfrmAdd.ShowDialog() == DialogResult.OK)
                BindingDeP();
        }

        /// <summary>
        /// Handles the Click event of the btnUpdateDep control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-06
        private void btnUpdateDep_Click(object sender, EventArgs e) //修改部门
        {
            if(this.gridViewDep.SelectedRowsCount<=0)
            {
                XtraMessageBox.Show("请选中要修改的项!","注意",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            DataRow myDataRow = this.gridViewDep.GetFocusedDataRow();//选中行的原始数据
             frmAdd myfrmAdd = new frmAdd(myDataRow);
            if (myfrmAdd.ShowDialog() == DialogResult.OK)
                BindingDeP();
        }

        /// <summary>
        /// Handles the Click event of the btnDeleteDep control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-06
        private void btnDeleteDep_Click(object sender, EventArgs e) //删除部门
        {
            if (this.gridViewDep.SelectedRowsCount <= 0)
            {
                XtraMessageBox.Show("请选择要删除的项!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string DepID = this.gridViewDep.GetFocusedRowCellValue("ID").ToString();
            myDataTable=myBUCMS_DPInfo.GetOrder(false,"SubID",DepID,false);
            if(myDataTable.Rows.Count>0)
            {
                XtraMessageBox.Show("您准备删除的部门下面还有职位,请先处理职位!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult myDialogResult = XtraMessageBox.Show("编号为" + DepID + "部门","确定删除？", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == myDialogResult)
            {
                VariedEnum.OperatorStatus EnOperatorStatus;
                try
                {
                    EnOperatorStatus = myBUCMS_DPInfo.Delete(DepID);
                    if (ClassAssist.CommonOperator.HandleOperatorEnum("删除", EnOperatorStatus))
                    {
                        BUT_SysLog.InsertSysLog(VariedEnum.LogType.系统事件, frmAssist.frmLogin.SysUser.UserID,"成功删除了编号为" + DepID + "的部门!");
                        BindingDeP();
                    }
                }
                catch
                {
                    XtraMessageBox.Show("请确定此条数据不正在被使用后重试", "删除失败",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the btnPrintDep control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-06
        private void btnPrintDep_Click(object sender, EventArgs e) //打印(&P)
        {
            try
            {
                ClassAssist.DataOperator.DataPrint(this.gridControlDep, "部门信息",null);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the btnOutDep control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-06
        private void btnOutDep_Click(object sender, EventArgs e) //导出(&O)
        {
            try
            {
                ClassAssist.DataOperator.DataOut(this.gridViewDep, "部门信息");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handles the SelectionChanged event of the gridViewDep control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.Data.SelectionChangedEventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-06
        private void gridViewDep_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            DataRow myDataRow = this.gridViewDep.GetFocusedDataRow();//选中行的原始数据(数据库中的)
            if (myDataRow == null)
                return;
            string SubID = myDataRow["ID"].ToString();
            try
            {
                 myDataTable = myBUCMS_DPInfo.GetOrder(false,"SubID",SubID,false);
                this.gridControlPos.DataSource = myDataTable;
                this.groupControlPos.Text = myDataRow["Name"].ToString() + "所有的职位";
                myDepID = Convert.ToInt32(myDataRow["ID"]);
            }
            catch (Exception  ex)
            {
                
                throw ex;
            }
        }
  
        #endregion 部门


        #region 职位

        private void btnAddPos_Click(object sender, EventArgs e)//添加(&A)职位
        {
            DevExpress.Data.SelectionChangedEventArgs ex = null;
            frmAddPosition myfrmAddPosition = new frmAddPosition(myDepID);//,myDepName);
            if (myfrmAddPosition.ShowDialog() == DialogResult.OK)
                gridViewDep_SelectionChanged(sender,ex);
        }

        /// <summary>
        /// Handles the Click event of the btnUpdatePos control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-06
        private void btnUpdatePos_Click(object sender, EventArgs e)//修改职位
        {
            DevExpress.Data.SelectionChangedEventArgs ex = null;
            if (this.gridViewPos.SelectedRowsCount <= 0)//如果一行都没有选中
            {
                XtraMessageBox.Show("请选择要修改的项!", "注意:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataRow tempDataRow = this.gridViewPos.GetFocusedDataRow();
            frmAddPosition myfrmAddPosition = new frmAddPosition(tempDataRow,myDepID);
            if (myfrmAddPosition.ShowDialog() == DialogResult.OK)
                gridViewDep_SelectionChanged(sender, ex);
        }

        /// <summary>
        /// Handles the Click event of the btnDeletePos control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-06
        private void btnDeletePos_Click(object sender, EventArgs e)//删除职位
        {
            DevExpress.Data.SelectionChangedEventArgs ex = null;
            if (this.gridViewPos.SelectedRowsCount <= 0)
            {
                XtraMessageBox.Show("请选择要删除的项!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string PosID = this.gridViewPos.GetFocusedRowCellValue("ID").ToString();
            DialogResult myDialogResult = XtraMessageBox.Show("编号为" + PosID + "的职位","确定删除？", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == myDialogResult)
            {
                VariedEnum.OperatorStatus EnOperatorStatus;
                try
                {
                    EnOperatorStatus = myBUCMS_DPInfo.Delete(PosID);
                    if (ClassAssist.CommonOperator.HandleOperatorEnum("删除", EnOperatorStatus))
                    {
                        BUT_SysLog.InsertSysLog(VariedEnum.LogType.系统事件, frmAssist.frmLogin.SysUser.UserID,"成功删除了编号为" + PosID + "的职位!");
                        gridViewDep_SelectionChanged(sender, ex);
                    }
                }
                catch
                {
                    XtraMessageBox.Show("请确定此条数据不正在被使用后重试", "删除失败",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnPrintPos_Click(object sender, EventArgs e)//打印(&P)
        {
            try
            {
                ClassAssist.DataOperator.DataPrint(this.gridControlPos, "职位信息",null);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnOutPos_Click(object sender, EventArgs e)//导出(&O)
        {
            try
            {
                ClassAssist.DataOperator.DataOut(this.gridViewPos, "职位信息");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        #endregion 职位

        private void gridViewDep_DoubleClick(object sender, EventArgs e)
        {
            btnUpdateDep_Click(sender,e);
        }

        private void gridViewPos_DoubleClick(object sender, EventArgs e)
        {
            btnUpdatePos_Click(sender,e);
        }

    }
}
