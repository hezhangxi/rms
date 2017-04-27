
//******************************************************************************************************
//** Copyright (C) 2010-2013 重大网络教育学院
//** 创建人：桂书丛
//** 类名称\文件名：frmProcess
//** 类功能：数据导出(&O)辅助窗体
//** 描 述：餐饮管理系统 数据导出(&O)辅助窗体
//** 创建日期：2013-1-25
//** 修改(&U)人：桂书丛
//** 修改(&U)日期：2013-1-25
//** 整理日期：2013-1-25
//******************************************************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CMS.UILayer.frmOther
{
    /// <summary>
    /// 进度显示窗体
    /// </summary>
    /// 创建人：桂书丛
    /// 创建日期：2013-02-25
    public partial class frmProcess : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="frmProcess"/> class.
        /// </summary>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-25
        public frmProcess()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="frmProcess"/> class.
        /// </summary>
        /// <param name="paramTitle">The param title.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-25
        public frmProcess(string paramTitle)
        {
            InitializeComponent();
            this._titleText = paramTitle;
        }

        private string _titleText = string.Empty;

        /// <summary>
        /// 窗体标题文本
        /// </summary>
        /// <value>
        /// The title text.
        /// </value>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-25
        public string TitleText
        {
            set
            {
                this._titleText = value;
            }
        }

        /// <summary>
        /// Handles the Load event of the frmProcess control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-25
        private void frmProcess_Load(object sender, EventArgs e)
        {
            this.Text = this._titleText;
            this.lblDisplay.Text = "请等待，" + this._titleText + "……";
        }

        /// <summary>
        /// Handles the Tick event of the tmrProcess control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-25
        private void tmrProcess_Tick(object sender, EventArgs e)
        {
            this.pgbProcess.PerformStep();
            if (Convert.ToInt32(this.pgbProcess.EditValue) == this.pgbProcess.Properties.Maximum)
                this.DialogResult = DialogResult.OK;
        }
    }
}
