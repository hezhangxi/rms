using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CMS.UILayer.frmBCarryOut
{
    /// <summary>
    /// 独立营业
    /// </summary>
    /// 整理人：桂书丛
    /// 整理时间：2013-02-04
    public partial class frmIndependentBusiness : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="frmIndependentBusiness"/> class.
        /// </summary>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-04
        public frmIndependentBusiness()
        {
            InitializeComponent();
            GetBAMain();
        }

        /// <summary>
        /// Gets the BA main.
        /// </summary>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-04
        private void GetBAMain()
        {
            frmAssist.frmBAMain myfrmBAMain = new CMS.UILayer.frmAssist.frmBAMain();
            SplitContainerControl tempMainControl = myfrmBAMain.splitContainerControlMain;
            myfrmBAMain.barManagerMain.Form = this;                                       //这句不能少，是给菜单制定一个窗体
            this.groupControlMain.Controls.Add(tempMainControl);
            tempMainControl.Dock = DockStyle.Fill;
        }
    }
}