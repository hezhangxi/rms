using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraCharts;

using CMS.BULayer;
namespace CMS.UILayer.frmBusiness
{
    /// <summary>
    /// 营业额统计
    /// </summary>
    /// 创建人：桂书丛
    /// 创建日期：2013-02-05
    public partial class frmTurnoverStatistics : DevExpress.XtraEditors.XtraForm
    {
        #region 变量定义
        BUCMS_ConsumptionReg myBUCMS_ConsumptionReg = new BUCMS_ConsumptionReg();
        DataTable myDataTable = new DataTable();     //全部数据 (多次使用，请勿覆盖！)
        private ViewType CharViewType = ViewType.Line;              //图表显示方式
        private string CharTitleText = "销售统计";                  //图表的标题
        private string ChartXText = "菜品名称";                     //图表横坐标要显示的值
        private string ChartYText = "销售金额";                     //图表纵坐标要显示的值
        string FiledName = "消费时间";                              //查找条件
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="frmTurnoverStatistics"/> class.
        /// </summary>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-05
        public frmTurnoverStatistics()
        {
            InitializeComponent();
            InitializeControls();
        }

        /// <summary>
        /// Initializes the controls.
        /// </summary>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-04
        private void InitializeControls()
        {
            this.cmbHText.SelectedIndexChanged -= this.cmbHText_SelectedIndexChanged;
            foreach (object tempItems in this.cmbField.Properties.Items)
            {
                this.cmbHText.Properties.Items.Add(tempItems);
            }
            this.cmbHText.Properties.Items.Add("菜品名称");
            this.btnAll.Enabled = false;
            this.cmbHText.SelectedIndex = this.cmbHText.Properties.Items.Count - 1;
            btnAll_Click(null,null);
            this.cmbHText.SelectedIndexChanged += this.cmbHText_SelectedIndexChanged;
        }

        /// <summary>
        /// 数据绑定到图表控件
        /// </summary>
        /// <param name="paramDataTable">The param data table.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-05
        private void DataBindingChartControl(DataTable paramDataTable)
        {
            chartControlMain.Series.Clear();
            chartControlMain.Titles[0].Text = CharTitleText;
            ViewType tempDisplayView=ViewType.Line;
            if (this.cmbViewType.Text == "折线图表")
                tempDisplayView = ViewType.Line;
            if (this.cmbViewType.Text == "柱状图表")
                tempDisplayView = ViewType.Bar;
            Series DisplayOne = new Series(ChartYText, tempDisplayView);
            
            DisplayOne.DataSource = paramDataTable;

            
            DisplayOne.ArgumentDataMember = ChartXText;//X轴的数据字段 
            //if (ChartXText == "消费时间")
                //DisplayOne.DataFilters = new DataFilterCondition();

            DisplayOne.ValueDataMembers[0] = ChartYText;//Y轴的数据字段
 
            this.chartControlMain.Series.Add(DisplayOne);
            this.chartControlMain.Series[0].SummaryFunction = "SUM(["+ChartYText+"])";
        }

        #region  按账单查询
        //第一条件改变时
        private void cmbField_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CmFileName = this.cmbField.Text.ToString();
            switch (CmFileName)
            {
                case "餐台名称":
                    HideControl();
                    this.lupTableName.Visible = true;
                    this.btnAll.Enabled = true;
                    FiledName = "餐台名称";
                    break;
                case "是否会员":
                    HideControl();
                    this.MruIsVIP.Visible = true;
                    this.btnAll.Enabled = true;
                    FiledName = "IsVIP";
                    break;
                case "会员姓名":
                    HideControl();
                    this.lupVIPClient.Visible = true;
                    this.btnAll.Enabled = true;
                    FiledName = "会员姓名";
                    break;
                case "会员卡类型":
                    HideControl();
                    this.lupVIPType.Visible = true;
                    this.btnAll.Enabled = true;
                    FiledName = "Name";
                    break;
                case "服务员":
                    HideControl();
                    this.lupWaiter.Visible = true;
                    this.btnAll.Enabled = true;
                    FiledName = "服务员";
                    break;
                case "支付方式":
                    HideControl();
                    this.lupPayment.Visible = true;
                    this.btnAll.Enabled = true;
                    FiledName = "支付方式";
                    break;
                case "消费日期":
                    HideControl();
                    this.dateStart.Visible = true;
                    this.lblFrom.Visible = true;
                    this.dateEnd.Visible = true;
                    this.btnAll.Enabled = false;
                    FiledName = "消费时间";
                    break;
                default:
                    break;
            }
        }
        #endregion

        /// <summary>
        /// Handles the Click event of the btnPrint control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-05
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                ClassAssist.DataOperator.DataPrint(this.chartControlMain, "销售信息", null);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 导出(&O)图片
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-05
        private void btnOut_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "导出(&O)图片";
            saveFileDialog.Filter = "bmp文件(*.bmp)|*.bmp";
            DialogResult dialogResult = saveFileDialog.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                chartControlMain.ExportToImage(saveFileDialog.FileName.ToString(), System.Drawing.Imaging.ImageFormat.Bmp);
                DevExpress.XtraEditors.XtraMessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Handles the Load event of the frmSellBill control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-04
        private void frmTurnoverStatistics_Load(object sender, EventArgs e)
        {
            Bindinglup();
            HideControl();
            this.dateStart.Visible = true;
            this.lblFrom.Visible = true;
            this.dateEnd.Visible = true;
        }

        #region private void Bindinglup()绑定数据到lup下拉框(按账单查询的)
        /// <summary>
        /// 绑定数据到lup下拉框（按账单查询的）
        /// </summary>
        private void Bindinglup()
        {
            DataTable LupDatatable = new DataTable();
            BUCMS_Buffets myBUCMS_Buffets=new BUCMS_Buffets();
            BUCMS_VIPType myBUCMS_VIPType=new BUCMS_VIPType();
            BUCMS_VIPClient myBUCMS_VIPClient=new BUCMS_VIPClient();
            BUCMS_Employee myBUCMS_Employee = new BUCMS_Employee();
            BUCMS_ItemDetail myBUCMS_ItemDetail =new BUCMS_ItemDetail();
            try
            {
                LupDatatable = myBUCMS_Buffets.GetOrder(false,string.Empty,string.Empty,false);
                ClassAssist.CommonOperator.DataBindingLookUpEdit(this.lupTableName,LupDatatable,"Name","ID",true);
                LupDatatable = myBUCMS_VIPType.GetOrder(false,string.Empty,string.Empty,false);
                ClassAssist.CommonOperator.DataBindingLookUpEdit(lupVIPType,LupDatatable,"Name","ID",true);
                LupDatatable = myBUCMS_VIPClient.GetOrder(false,string.Empty,string.Empty,false);
                ClassAssist.CommonOperator.DataBindingLookUpEdit(lupVIPClient, LupDatatable, "Name", "ID", true);
                LupDatatable = myBUCMS_Employee.GetOrder(false,string.Empty,string.Empty,false);
                ClassAssist.CommonOperator.DataBindingLookUpEdit(lupWaiter, LupDatatable, "Name", "ID", true);
                LupDatatable = myBUCMS_ItemDetail.GetItemByType(VariedItemType.PayType);
                ClassAssist.CommonOperator.DataBindingLookUpEdit(lupPayment, LupDatatable, "Name", "ID", true);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region private void HideControl()隐藏控件
        /// <summary>
        /// 隐藏控件
        /// </summary>
        private void HideControl()
        {
            this.txtID.Visible = false;
            this.lupPayment.Visible = false;
            this.lupTableName.Visible = false;
            this.lupVIPClient.Visible = false;
            this.lupVIPType.Visible = false;
            this.lupWaiter.Visible = false;
            this.calCost.Visible = false;
            this.MruIsVIP.Visible = false;
            this.dateStart.Visible = false;
            this.lblFrom.Visible = false;
            this.dateEnd.Visible = false;
        }
        #endregion

        #region  private string GetMruValue(string paramCmFileName)获得第二条件
        /// <summary>
        /// 获得第二条件
        /// </summary>
        /// <param name="paramCmFileName"></param>
        /// <returns></returns>
        private string GetMruValue(string paramCmFileName)
        {
            switch (paramCmFileName)
            {
                case "餐台名称":
                    return this.lupTableName.Text.ToString() ;
                case "消费总额":
                    return this.calCost.Text.Trim().ToString();
                case "是否会员":
                    if (this.MruIsVIP.Text.ToString() == "是")
                        return "True";
                    else
                        return "False";
                case "会员姓名":
                    return this.lupVIPClient.Text.ToString();
                case "Name":
                    return this.lupVIPType.Text.ToString();
                case "服务员":
                   return this.lupWaiter.Text.ToString();
                case "支付方式":
                   return this.lupPayment.Text.ToString();
                default:
                    return null;
            }
        }
        #endregion

        #region private void SearchDate()按消费日期查询
        /// <summary>
        /// 按消费日期查询
        /// </summary>
        private void SearchDate()
        {
            DateTime DateStart = Convert.ToDateTime(this.dateStart.EditValue);
            DateTime DateEnd = Convert.ToDateTime(this.dateEnd.EditValue);
            try
            {
                myDataTable = myBUCMS_ConsumptionReg.GetOrder(true, "[消费时间]", DateStart, DateEnd);
                this.ChartXText = "消费时间";
                DataBindingChartControl(myDataTable);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region  private void GetDataOnCondition(string paramFileName,string paramMarValue)根据条件获取数据
        /// <summary>
        /// 根据条件获取数据
        /// </summary>
        /// <param name="paramFileName"></param>
        /// <param name="paramMarValue"></param>
        /// <returns></returns>
        private void GetDataOnCondition(string paramFileName,string paramMarValue)
        {
            try
            {
                myDataTable = myBUCMS_ConsumptionReg.GetOrder(true,paramFileName,paramMarValue,false);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }
        #endregion

        /// <summary>
        /// Handles the Click event of the btnAll control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-05
        private void btnAll_Click(object sender, EventArgs e)
        {
            try
            {
                myDataTable = new BUCMS_ConsumptionReg().GetOrder(true, string.Empty, string.Empty, false);
                DataBindingChartControl(myDataTable);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the cmbViewType control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-05
        private void cmbViewType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataBindingChartControl(myDataTable);
        }

        /// <summary>
        /// Handles the Click event of the btnSearch control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-05
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.FiledName == "消费时间")
                {
                    SearchDate();
                    return;
                }
                string MarValue = GetMruValue(FiledName);
                GetDataOnCondition(FiledName, MarValue);
                DataBindingChartControl(myDataTable);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the cmbHText control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-05
        private void cmbHText_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ChartXText = this.cmbHText.Text;
            if(this.cmbHText.Text == "是否会员")
                this.ChartXText="IsVIP";
            if(this.cmbHText.Text == "会员卡类型")
                this.ChartXText  = "Name";
            if (this.cmbHText.Text == "消费日期")
            {
                if (XtraMessageBox.Show("必须先按时间查出数据", "是否按时间查询？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    SearchDate();
                else
                    return;
            }
            DataBindingChartControl(myDataTable);
        }

        /// <summary>
        /// Handles the KeyDown event of the textTitle control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.KeyEventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-05
        private void textTitle_KeyDown(object sender, KeyEventArgs e)
        {
            CharTitleText=this.textTitle.Text.Trim();
            if (e.KeyCode == Keys.Enter)
                btnSearch_Click(null,null);
        }

        /// <summary>
        /// Handles the Click event of the textTitle control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-05
        private void textTitle_Click(object sender, EventArgs e)
        {
            this.textTitle.Text = string.Empty;
        }
    }
}