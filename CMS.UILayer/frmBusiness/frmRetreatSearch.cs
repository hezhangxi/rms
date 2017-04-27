using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CMS.BULayer;

namespace CMS.UILayer.frmBusiness
{
    public partial class frmRetreatSearch : DevExpress.XtraEditors.XtraForm
    {
        BUCMS_RetreatDishes myBUCMS_RetreatDishes = new BUCMS_RetreatDishes();
        BUCMS_ItemDetail myBUCMS_ItemDetail = new BUCMS_ItemDetail();
        BUCMS_DishServer myBUCMS_DishServer = new BUCMS_DishServer();
        DataTable myDataTable = new DataTable();
        string DishFiledName = null; //保存字段
        public frmRetreatSearch()
        {
            InitializeComponent();
        }

        private void frmRetreatSearch_Load(object sender, EventArgs e)
        {
            BindingGridControl();
            BindingLup();
            HideControls();
            this.dateStart.Visible = true;
            this.lblFrom.Visible = true;
            this.dateEnd.Visible = true;
            this.cmFiledName.SelectedIndex = 5;
        }

        #region  private void BindingGridControl()绑定所有数据到gridcontrol表格
        /// <summary>
        /// 绑定所有数据到gridcontrol表格
        /// </summary>
        private void BindingGridControl()
        {
            try
            {
                myDataTable = myBUCMS_RetreatDishes.GetOrder(string.Empty,string.Empty);
                this.gridControlDish.DataSource = myDataTable;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
        #endregion

        #region private void BindingLup()绑定数据到lup下拉框
        /// <summary>
        /// 绑定数据到lup下拉框
        /// </summary>
        private void BindingLup()
        {
            try
            {
                myDataTable= myBUCMS_ItemDetail.GetItemByType(VariedItemType.BackResult);
                this.lupReason.Properties.DataSource = myDataTable;
                this.lupReason.ItemIndex = 0;
                myDataTable = myBUCMS_DishServer.GetOrder(false, string.Empty, string.Empty, false);
                this.lupDisName.Properties.DataSource = myDataTable;
                this.lupDisName.ItemIndex = 0;
                myDataTable = new BUT_User().GetAllUserInfo();
                this.lupCreatePerson.Properties.DataSource = myDataTable;
                this.lupCreatePerson.ItemIndex = 0;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
        #endregion

        #region private void HideControls()隐藏控件
        /// <summary>
        /// 隐藏控件
        /// </summary>
        /// <returns></returns>
        private void HideControls()
        {
            this.mruIDNum.Visible = false;
            this.lupDisName.Visible = false;
            this.lupReason.Visible = false;
            this.lupCreatePerson.Visible = false;
            this.dateStart.Visible = false;
            this.lblFrom.Visible = false;
            this.dateEnd.Visible = false;
        }
        #endregion

        //第一条件改变时
        private void cmFiledName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FileName=cmFiledName.Text.ToString();
           switch (FileName)
           {
               case "退菜编号" :
                   HideControls();
                   this.mruIDNum.Visible = true;
                   DishFiledName = "CMS_RetreatDishes.ID";
                   break;
               case "菜品名称":
                   HideControls();
                   this.lupDisName.Visible = true;
                   DishFiledName = "CMS_RetreatDishes.DishID";
                   break;
               case "退菜数量":
                   HideControls();
                   this.mruIDNum.Visible = true;
                   DishFiledName = "CMS_RetreatDishes.DishNum";
                   break;
               case "退菜原因":
                   HideControls();
                   this.lupReason.Visible = true;
                   DishFiledName = "CMS_RetreatDishes.CauseID";
                   break;
               case "办理人":
                   HideControls();
                   this.lupCreatePerson.Visible = true;
                   DishFiledName = "CMS_RetreatDishes.CreatePerson";
                   break;
               case "退菜时间":
                   HideControls();
                   this.dateStart.Visible = true;
                   this.lblFrom.Visible = true;
                   this.dateEnd.Visible = true;
                   break;
               default:
                   break;
           }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string CmbFiledName=this.cmFiledName.Text.Trim().ToString();
            if (CmbFiledName == "退菜时间")
            {
                SearchDate();
                return;
            }
            string MarValue = SecondCondition(CmbFiledName);
            try
            {
                myDataTable = myBUCMS_RetreatDishes.GetOrder(DishFiledName,MarValue);
                this.gridControlDish.DataSource = myDataTable;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        #region  private string SecondCondition(string paramFiledName)获取第二条件
        /// <summary>
        /// 获取第二条件
        /// </summary>
        /// <param name="paramFiledName"></param>
        /// <returns></returns>
        private string SecondCondition(string paramFiledName)
        {
            switch (paramFiledName)
          {
             case "退菜编号" :
                   return this.mruIDNum.Text.Trim().ToString();
               case "菜品名称":
                   return this.lupDisName.EditValue.ToString(); //根据菜品编号
               case "退菜数量":
                   return this.mruIDNum.Text.Trim().ToString();
               case "退菜原因":
                   return this.lupReason.EditValue.ToString();  //根据原因编号
               case "办理人":
                   return this.lupCreatePerson.Text.ToString();
                default:
                   return null;
          }
        }
        #endregion

        #region  private void SearchDate()按时间查询
        /// <summary>
        /// 按时间查询
        /// </summary>
        private void SearchDate()
        {
            DateTime DateStart = Convert.ToDateTime(this.dateStart.EditValue);
            DateTime DateEnd = Convert.ToDateTime(this.dateEnd.EditValue);
            try
            {
                myDataTable = myBUCMS_RetreatDishes.GetOrder(DateStart,DateEnd);
                this.gridControlDish.DataSource = myDataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.gridViewDish.SelectedRowsCount <= 0)
            {
                XtraMessageBox.Show("请选择要删除(&D)的项!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string DishID = this.gridViewDish.GetFocusedRowCellValue("ID").ToString();
            System.Windows.Forms.DialogResult myDialogResult = XtraMessageBox.Show("编号为" + DishID + "退菜信息?",
                "确定删除(&D)", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == myDialogResult)
            {
                VariedEnum.OperatorStatus EnOperatorStatus;
                try
                {
                    EnOperatorStatus = myBUCMS_RetreatDishes.Delete(DishID);
                    if (ClassAssist.CommonOperator.HandleOperatorEnum("删除(&D)", EnOperatorStatus))
                    {
                        BUT_SysLog.InsertSysLog(VariedEnum.LogType.系统事件, frmAssist.frmLogin.SysUser.UserID,
                            "成功删除(&D)了编号为" + DishID + "退菜信息!");
                        BindingGridControl();
                    }
                }
                catch
                {
                    XtraMessageBox.Show("请确定此条数据不正在被使用后重试", "删除(&D)失败",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (this.gridViewDish.SelectedRowsCount <= 0)
            {
                XtraMessageBox.Show("没有任何数据!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            System.Windows.Forms.DialogResult myDialogResult = XtraMessageBox.Show("确定清空所有退菜退菜信息?",
               "注意", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == myDialogResult)
            {
                //VariedEnum.OperatorStatus EnOperatorStatus;
                try
                {
                    int DeleteAll = myBUCMS_RetreatDishes.ClearRetreatDishes();
                    if (DeleteAll > 0)
                        //BindingGridControl();
                        //EnOperatorStatus = VariedEnum.OperatorStatus.Successed;
                    if (ClassAssist.CommonOperator.HandleOperatorEnum("清空", VariedEnum.OperatorStatus.Successed))
                    {
                        BUT_SysLog.InsertSysLog(VariedEnum.LogType.系统事件, frmAssist.frmLogin.SysUser.UserID,
                            "成功清空了所有退菜信息!");
                        BindingGridControl();
                    }
                }
                catch
                {
                    XtraMessageBox.Show("请确定数据不正在被使用后重试", "清空失败",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            BindingGridControl();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                ClassAssist.DataOperator.DataPrint(this.gridControlDish, "退菜信息",null);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            try
            {
                ClassAssist.DataOperator.DataOut(this.gridViewDish, "退菜信息");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridViewDish_DoubleClick(object sender, EventArgs e)
        {
            btnDelete_Click(sender,e);
        }
    }
}