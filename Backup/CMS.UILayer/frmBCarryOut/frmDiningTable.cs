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
    public partial class frmDiningTable : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="frmDiningTable"/> class.
        /// </summary>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-04
        public frmDiningTable()
        {
            InitializeComponent();
            GetBAMain();
        }

        /// <summary>
        /// 获得主显示控件
        /// </summary>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-24
        private void GetBAMain()
        {
            frmAssist.frmBAMain myfrmBAMain = new CMS.UILayer.frmAssist.frmBAMain();
            myfrmBAMain.btnBuffetStatus_ItemClick(null, null);
            SplitGroupPanel tempMainControl = myfrmBAMain.splitContainerControlMain.Panel1;
            myfrmBAMain.barManagerMain.Form = this;                                       //这句不能少，是给菜单制定一个窗体
            this.panelControlMain.Controls.Add(tempMainControl);
            tempMainControl.Dock = DockStyle.Fill;
        }
    }
}