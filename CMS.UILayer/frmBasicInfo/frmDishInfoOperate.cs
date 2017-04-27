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

namespace CMS.UILayer.frmBasicInfo
{
    public partial class frmDishInfoOperate : DevExpress.XtraEditors.XtraForm
    {
        #region 变量的定义
        BUCMS_DishServer myBUCMS_DishServer = new BUCMS_DishServer();
        BUCMS_ItemDetail myBUCMS_ItemDetail = new BUCMS_ItemDetail();
        BUCMS_Stock myBUCMS_Stock = new BUCMS_Stock();
        int ItemID = -5; 

        #endregion
        public frmDishInfoOperate()
        {
            InitializeComponent();
            this.txtPerson.Text = frmAssist.frmLogin.SysUser.UserName;
            this.txtDate.Text = DateTime.Now.ToString();
        }

        public frmDishInfoOperate(object[] paramInfo)
        {
            InitializeComponent();
            FillInfo(paramInfo);
            this.txtPerson.Text = frmAssist.frmLogin.SysUser.UserName;
            this.txtDate.Text = DateTime.Now.ToString();
            this.lblPerson.Text = "修改(&U)人：";
            this.lblDate.Text = "修改(&U)时间：";
            this.btnSave.Click -= this.btnSave_Click;
            this.btnSave.Click += this.btnRSave_Click;
        }

        private void FillInfo(object[] paramInfo)
        {
            try
            {
                ItemID = Convert.ToInt16(paramInfo[0]);
                this.txtName.Text = paramInfo[1].ToString();
                this.EditDishTypeID.Text = paramInfo[2].ToString();
                this.txtMnemonicSymbol.Text = paramInfo[3].ToString();
                this.SpinEditCost.Text = paramInfo[4].ToString();
                this.txtMeasuringUnit.Text = paramInfo[5].ToString();
                this.SpinEditPrice.Text = paramInfo[6].ToString();
                this.EditStockGoodsID.Text = paramInfo[7].ToString();
                this.SpinEditCommission.Text = paramInfo[10].ToString();
                this.txtInfoNote.Text = paramInfo[11].ToString();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "mmm");
            }
        }

        #region btnSave_Click 菜品信息维护中保存按钮的单击事件
        /// <summary>
        /// 菜品信息维护中保存按钮的单击事件
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!CheckInput())
                return;
            VariedEnum.OperatorStatus EnOperatorStatus;
            try
            {
                EnOperatorStatus = myBUCMS_DishServer.Insert(GetModel());
                if (ClassAssist.CommonOperator.HandleOperatorEnum("菜品信息添加(&A)", EnOperatorStatus))
                {
                    BUT_SysLog.InsertSysLog(VariedEnum.LogType.数据操作, frmAssist.frmLogin.SysUser.UserID,"成功添加(&A)了一条菜品信息");
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }                        
        }

        private void btnRSave_Click(object sender, EventArgs e)
        {
            try
            {
                VariedEnum.OperatorStatus EnOperatorStatus;
                EnOperatorStatus = myBUCMS_DishServer.Update(GetModel());
                if (ClassAssist.CommonOperator.HandleOperatorEnum("菜品信息修改(&U)", EnOperatorStatus))
                {
                    BUT_SysLog.InsertSysLog(VariedEnum.LogType.数据操作, frmAssist.frmLogin.SysUser.UserID,
                        "成功修改(&U)了一条菜品信息");
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private ModelCMS_DishServer GetModel()
        {
            ModelCMS_DishServer tempModelCMS_DishServer = new ModelCMS_DishServer();
            tempModelCMS_DishServer.ID = ItemID;
            tempModelCMS_DishServer.Name = this.txtName.Text.Trim();
            tempModelCMS_DishServer.DishTypeID = Convert.ToInt32(this.EditDishTypeID.EditValue);
            tempModelCMS_DishServer.MnemonicSymbol = this.txtMnemonicSymbol.Text.Trim();
            tempModelCMS_DishServer.Cost = Convert.ToDecimal(this.SpinEditCost.Text.Trim());
            tempModelCMS_DishServer.MeasuringUnit = this.txtMeasuringUnit.Text.Trim();
            tempModelCMS_DishServer.Price = Convert.ToDecimal(this.SpinEditPrice.Text.Trim());
            tempModelCMS_DishServer.StockGoodsID = Convert.ToInt32(this.EditStockGoodsID.EditValue);
            tempModelCMS_DishServer.Commission = Convert.ToDecimal(this.SpinEditCommission.Text.Trim());
            tempModelCMS_DishServer.InfoNote = this.txtInfoNote.Text.Trim();
            tempModelCMS_DishServer.CreatePerson = tempModelCMS_DishServer.ModifyPerson = frmAssist.frmLogin.SysUser.UserName;
            tempModelCMS_DishServer.CreateDate = tempModelCMS_DishServer.ModifyDate = DateTime.Now;
            return tempModelCMS_DishServer;
        }
        #endregion

        #region private void CheckInput() 检查是否输入菜品名称
        /// <summary>
        /// 检查是否输入菜品名称
        /// </summary>
        /// <remarks></remarks>
        private bool CheckInput()
        {
            if (this.txtName.Text.Length == 0)
            {
                XtraMessageBox.Show("╯^╰)请输入菜品名称！","信息输入不完整",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }
        #endregion


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDishInfoOperate_Load(object sender, EventArgs e)
        {
            DataTable myDT = myBUCMS_ItemDetail.GetItemByType(VariedItemType.DishType);
            ClassAssist.CommonOperator.DataBindingLookUpEdit(EditDishTypeID, myDT, "Name", "ID", true);
            this.EditDishTypeID.ItemIndex = 0;
            this.EditStockGoodsID.Properties.DataSource = myBUCMS_Stock.GetOrder(false, string.Empty, string.Empty, false);
            this.EditStockGoodsID.ItemIndex = 0;
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
