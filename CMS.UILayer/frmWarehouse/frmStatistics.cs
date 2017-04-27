using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CMS.BULayer;
using DevExpress.XtraCharts;

namespace CMS.UILayer.frmWarehouse
{
    /// <summary>
    /// 
    /// </summary>
    /// 整理人：桂书丛
    /// 整理时间：2013-03-04
    public partial class frmStatistics : DevExpress.XtraEditors.XtraForm
    {
        BUCMS_InGoods myBUCMS_InGoods = new BUCMS_InGoods();
        BUCMS_Stock myBUCMS_Stock = new BUCMS_Stock();
        DataTable myDataTable = new DataTable();
        DevExpress.XtraCharts.SeriesPoint mySeriesPoint;
        DevExpress.XtraCharts.Series mySeries;
        public frmStatistics()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the frmStatistics control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-04
        private void frmStatistics_Load(object sender, EventArgs e)
        {
            myDataTable = myBUCMS_Stock.GetDateItems();
            for (int j = 0; j < myDataTable.Rows.Count; j++)
            {
                mySeries = new DevExpress.XtraCharts.Series();
                mySeries.Name = myDataTable.Rows[j]["Name"].ToString();
                chartInGoodsDate.Series.Add(mySeries);
            }
        }
        /// <summary>
        /// Handles the Click event of the btnStatistics control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-04
        private void btnStatistics_Click(object sender, EventArgs e)
        {
            string paramStartDateTime = this.txtStartData.Text.Trim() + " " + this.tmeStartInGoods.Text.Trim();
            string paramEndDateTime = this.txtEndData.Text.Trim() + " " + this.tmeEndInGoods.Text.Trim();
            myDataTable = myBUCMS_InGoods.GetDateMoney(Convert.ToDateTime(paramStartDateTime), Convert.ToDateTime(paramEndDateTime));
            for (int i = 0; i < myDataTable.Rows.Count; i++)
            {
                foreach (Series s in chartInGoodsDate.Series)
                {
                    if (myDataTable.Rows[i]["Name"].ToString() == s.Name)
                    {
                        mySeriesPoint = new DevExpress.XtraCharts.SeriesPoint();
                        mySeriesPoint.Argument = myDataTable.Rows[i]["Name"].ToString();
                        mySeriesPoint.Values = new double[] { Convert.ToDouble(myDataTable.Rows[i]["Total"].ToString()) };
                        s.Points.Add(mySeriesPoint);
                    }
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the btnDerive control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-04
        private void btnDerive_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "导出(&O)图片";
            saveFileDialog.Filter = "bmp文件(*.bmp)|*.bmp";
            DialogResult dialogResult = saveFileDialog.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                chartInGoodsDate.ExportToImage(saveFileDialog.FileName.ToString(), System.Drawing.Imaging.ImageFormat.Bmp);
                DevExpress.XtraEditors.XtraMessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Handles the Click event of the btnPrint control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-04
        private void btnPrint_Click(object sender, EventArgs e)
        {
            System.Drawing.Printing.PageSettings set_print_page = new System.Drawing.Printing.PageSettings();
            DevExpress.XtraPrinting.DynamicPrintHelper ph = new DevExpress.XtraPrinting.DynamicPrintHelper();
            if (ph.IsPrintingAvailable)
            {
                ph.PageSettings = set_print_page;
                ph.PageSettings.Landscape = true;
                ph.ShowPreview(this.chartInGoodsDate, true);
            }
        }

        /// <summary>
        /// Handles the Click event of the btnReturn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-04
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}