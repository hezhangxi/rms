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
    public partial class frmVIPSearch : DevExpress.XtraEditors.XtraForm
    {
        #region 变量定义
        BUCMS_VIPClient myBUCMS_VIPClient = new BUCMS_VIPClient();
        BUCMS_VIPType myBUCMS_VIPType = new BUCMS_VIPType();
        DataTable myDataTable = new DataTable();
        string FiledName = null; //按条件查询(字段名))
        /// <summary>
        /// 所选的VIP信息数据集
        /// </summary>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-02
        public static  DataRow VIPInfo = null;
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="frmVIPSearch"/> class.
        /// </summary>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-02
        public frmVIPSearch()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the frmVIPSearch control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-02
        private void frmVIPSearch_Load(object sender, EventArgs e)
        {
            BindingControls();
            HideControls();
            this.dateStart.Visible = true; //默认按注册时间查询
            this.dateEnd.Visible = true;
            this.lblFrom.Visible = true;
            this.cmbField.SelectedIndex = 4;
        }

        #region private void BindingControls()绑定控件
        /// <summary>
        /// 绑定控件
        /// </summary>
        private void BindingControls()
        {
            try
            {
                myDataTable = myBUCMS_VIPClient.VIPSearch(false,string.Empty,string.Empty); //false表示全部查询
                this.gridControlVIPInfo.DataSource = myDataTable;
                myDataTable = myBUCMS_VIPType.GetOrder(false,string.Empty,string.Empty,false);
                this.lupVIPType.Properties.DataSource = myDataTable;
                this.lupVIPType.ItemIndex = 0;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region private void HideControls()隐藏所有控件
        /// <summary>
        /// 隐藏所有控件
        /// </summary>
        private void HideControls()
        {
            this.lupVIPType.Visible = false;
            this.mruID.Visible = false;
            this.mruName.Visible = false;
            this.mruPhone.Visible = false;
            this.dateStart.Visible = false;
            this.dateEnd.Visible = false;
            this.lblFrom.Visible = false;
        }
        #endregion

        /// <summary>
        /// Handles the Click event of the btnAll control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-02
        private void btnAll_Click(object sender, EventArgs e)
        {
            BindingControls();
        }

        /// <summary>
        /// Handles the SelectionChanged event of the gridViewOne control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.Data.SelectionChangedEventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-02
        private void gridViewOne_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            DataRow myDataRow = this.gridViewVIPInfo.GetFocusedDataRow();//取出选中行的原始数据
            if(myDataRow==null)
                return;
            try
            {
                this.txtVIPCost.EditValue = myDataRow["VIPCost"];
                DataTable myDataTable = myBUCMS_VIPType.GetOrder(false, "ID", myDataRow["VIPTypeID"].ToString(), false);
                this.txtVIPName.Text = myDataTable.Rows[0]["Name"].ToString();
                this.txtVIPDiscount.EditValue = myDataTable.Rows[0]["Discount"];
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the btnSearch control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-02
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string ComFileName = this.cmbField.Text.ToString();
            if(ComFileName=="注册时间")
            {
                SearchDate();
                return;
            }
            string MarValue = OtherMarValue(ComFileName);
            try
            {
                myDataTable = myBUCMS_VIPClient.VIPSearch(true,FiledName,MarValue);
                this.gridControlVIPInfo.DataSource = myDataTable;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        #region private void SearchDate()按时间查询
        /// <summary>
        /// 按时间查询
        /// </summary>
        private void SearchDate()
        {
            DateTime TimeStart = Convert.ToDateTime(this.dateStart.EditValue);
            DateTime TimeEnd = Convert.ToDateTime(this.dateEnd.EditValue);
            DataTable myDataTable = new DataTable();
            try
            {
                myDataTable = myBUCMS_VIPClient.VIPSearch(false, TimeStart, TimeEnd);
                this.gridControlVIPInfo.DataSource = myDataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region private string OtherMarValue()按其他条件查询
        /// <summary>
        /// 按其他条件查询
        /// </summary>
        /// <returns></returns>
        private string OtherMarValue(string ComFileName)
        {
            string MarValue = null;
            switch (ComFileName)
          {
              case "编号":
                  MarValue = this.mruID.Text.Trim().ToString();
                  break;
              case "姓名":
                  MarValue = this.mruName.Text.Trim().ToString();
                  break;
              case "会员卡":
                  MarValue = this.lupVIPType.EditValue.ToString();
                  break;
              case "电话":
                  MarValue = this.mruPhone.Text.Trim().ToString();
                  break;
              default:
                  break;
          }
            return MarValue;
        }
        #endregion

        /// <summary>
        /// Handles the SelectedIndexChanged event of the cmbField control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-02
        private void cmbField_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tempStringField = this.cmbField.Text.Trim().ToString();
            switch (tempStringField)
            {
                case "编号":
                    HideControls();
                    this.mruID.Visible = true;
                    FiledName = "ID";
                    break;
                case "姓名":
                    HideControls();
                    this.mruName.Visible = true;
                    FiledName = "Name";
                    break;
                case "会员卡":
                    HideControls();
                    this.lupVIPType.Visible = true;
                    FiledName = "VIPTypeID";
                    break;
                case "电话":
                    HideControls();
                    this.mruPhone.Visible = true;
                    FiledName = "TelPhone";
                    break;
                case "注册时间":
                    this.dateStart.Visible = true;
                    this.dateEnd.Visible = true;
                    this.lblFrom.Visible = true;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Handles the Click event of the btnOK control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-02
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.gridViewVIPInfo.SelectedRowsCount <= 0)
            {
                XtraMessageBox.Show("请选择要提取的项!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            VIPInfo = this.gridViewVIPInfo.GetFocusedDataRow();//获取原始数据(连表后显示的数据,不用再在VIPType表中获取)
            this.Close();
        }

        /// <summary>
        /// Handles the DoubleClick event of the gridViewVIPInfo control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-02
        private void gridViewVIPInfo_DoubleClick(object sender, EventArgs e)
        {
            btnOK_Click(sender,e);
        }

        private void txtVIPCost_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                double tempDiscount = Convert.ToDouble(this.txtVIPDiscount.EditValue);
                double tempVIPCost = Convert.ToDouble(this.txtVIPCost.EditValue);
                this.txtCash.EditValue = tempVIPCost / (tempDiscount * 0.1);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }
    }
}
