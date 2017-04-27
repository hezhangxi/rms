
//*************************************************************************************************
//** 创建人:桂书丛
//** 类名称:frmPrintSet
//** 类功能:数据打印(&P)设置
//** 创建日期:2012-12-28
//** 描 述: 数据打印(&P)设置窗体
//** 整理日期：2012-12-28
//*************************************************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CMS.UILayer.frmOther
{
    public partial class frmPrintSet : Form
    {
        public frmPrintSet()
        {
            InitializeComponent();
        }

        public frmPrintSet(List<string> availableFields)
        {
            InitializeComponent();
            foreach (string field in availableFields)
                chklst.Items.Add(field, true);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FormPrintSet_Load(object sender, EventArgs e)
        {
            rdoAllRows.Checked = true;
            chkFitToPageWidth.Checked = true; 
        }
        /// <summary>
        /// 获取选择的列数进行添加(&A)到chklst中
        /// </summary>
        /// <returns></returns>
        public List<string> GetSetlectedColumns()
        {
            List<string> lst = new List<string>();
            foreach (object item in chklst.CheckedItems)
                lst.Add(item.ToString());
            return lst;
        }
        //打印(&P)标题
        public string PrintTitle
        {
            get { return txtTitle.Text; }
        }
        //打印(&P)行数
        public bool PrintAllRows
        {
            get { return rdoAllRows.Checked; }
        }
        //打印(&P)宽度调整
        public bool FitToPageWidth
        {
            get { return chkFitToPageWidth.Checked; }
        }
    }
}
