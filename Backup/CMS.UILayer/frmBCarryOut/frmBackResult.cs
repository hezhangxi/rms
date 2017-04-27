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
    /// 退菜窗体
    /// </summary>
    /// 创建人：桂书丛
    /// 创建日期：2013-2-25
    public partial class frmBackResult : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// 退菜数量
        /// </summary>
        /// 创建人：桂书丛
        /// 创建日期：2013-2-25
        public static int QuitNum = 1;
        private DataRow DishDataRow;                          //菜品信息数据集
                        
        /// <summary>
        /// Initializes a new instance of the <see cref="frmBackResult"/> class.
        /// </summary>
        /// 创建人：桂书丛
        /// 创建日期：2013-2-25
        public frmBackResult()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="frmBackResult"/> class.
        /// </summary>
        /// <param name="paramDataRow">The param data row.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-2-25
        public frmBackResult(DataRow paramDataRow)
        {
            InitializeComponent();
            this.DishDataRow = paramDataRow;
        }

        private void InitializeControls(DataRow paramDataRow)
        {
            try
            {
                FillAllInfo(paramDataRow);
                DataTable tempDataTable = new BUCMS_ItemDetail().GetItemByType(VariedItemType.BackResult);
                ClassAssist.CommonOperator.DataBindingLookUpEdit(lupResult,tempDataTable,"Name","ID",true);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Fills all info.
        /// </summary>
        /// <param name="paramDataRow">The param data row.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-2-25
        private void FillAllInfo(DataRow paramDataRow)
        {
            if (paramDataRow != null)
            {
                this.lblID.Text += paramDataRow["ID"].ToString();
                this.lblName.Text += paramDataRow["Name"].ToString();
                this.lblAvaNum.Text = paramDataRow["Num"].ToString();
                this.lblIsPresent.Text = Convert.ToBoolean(paramDataRow["IsPresent"]) ? "是赠菜" : "不是赠菜";
                this.lblPrice.Text += paramDataRow["Price"].ToString() + "元";
                this.lblTotal.Text += paramDataRow["Total"].ToString() + "元";
            }
        }

        /// <summary>
        /// Handles the Click event of the btnCancel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-2-25
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Handles the Click event of the btnOK control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-2-25
        private void btnOK_Click(object sender, EventArgs e)
        {
            VariedEnum.OperatorStatus EnOperatorStatus;
            try
            {
                EnOperatorStatus = new BUCMS_RetreatDishes().Insert(GetModel());
                if (ClassAssist.CommonOperator.HandleOperatorEnum("退菜", EnOperatorStatus))
                {
                    BUT_SysLog.InsertSysLog(VariedEnum.LogType.数据操作, frmAssist.frmLogin.SysUser.UserID,
                        "成功退了" + QuitNum.ToString() + "个编号为：" + DishDataRow["ID"].ToString() + "的商品");
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Add");
            }
        }

        /// <summary>
        /// 获得实体
        /// </summary>
        /// <returns></returns>
        /// 创建人：桂书丛
        /// 创建日期：2013-2-25
        private ModelCMS_RetreatDishes GetModel()
        {
            ModelCMS_RetreatDishes tempModelCMS_RetreatDishes = new ModelCMS_RetreatDishes();
            try
            {
                tempModelCMS_RetreatDishes.DishID = Convert.ToInt32(DishDataRow["ID"]);
                tempModelCMS_RetreatDishes.DishNum = QuitNum;
                tempModelCMS_RetreatDishes.CauseID = Convert.ToInt32(this.lupResult.EditValue);
                tempModelCMS_RetreatDishes.RetreatDate = DateTime.Now;
                tempModelCMS_RetreatDishes.InfoNote = this.txtInfoNote.Text;
                tempModelCMS_RetreatDishes.CreatePerson = frmAssist.frmLogin.SysUser.UserName;
                return tempModelCMS_RetreatDishes;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Handles the Load event of the frmBackResult control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-2-25
        private void frmBackResult_Load(object sender, EventArgs e)
        {
            InitializeControls(this.DishDataRow);
        }

        /// <summary>
        /// Handles the TextChanged event of the speBackNum control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-2-25
        private void speBackNum_TextChanged(object sender, EventArgs e)
        {
            int AvaNum = Convert.ToInt32(this.lblAvaNum.Text.Trim());
            if (speBackNum.Value > AvaNum)
            {
                XtraMessageBox.Show("退菜数量将达到可退上限", "不能再退");
                this.speBackNum.EditValue = AvaNum.ToString();
            }
            QuitNum = Convert.ToInt32(speBackNum.EditValue);
        }
    }
}