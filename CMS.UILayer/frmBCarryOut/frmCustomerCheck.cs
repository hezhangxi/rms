using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using CMS.BULayer;
namespace CMS.UILayer.frmBCarryOut
{
    /// <summary>
    /// 顾客结账
    /// </summary>
    /// 整理人：桂书丛
    /// 整理时间：2013-02-04
    public partial class frmCustomerCheck : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="frmCustomerCheck"/> class.
        /// </summary>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-04
        public frmCustomerCheck()
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
            foreach (Control tempTabPage in myfrmBAMain.xtraTabControlMain.TabPages)
            {
                if (tempTabPage.GetType() == typeof(DevExpress.XtraTab.XtraTabPage))
                {
                    DevExpress.XtraTab.XtraTabPage tempPage = (DevExpress.XtraTab.XtraTabPage)tempTabPage;
                    if (tempPage.Text == VariedEnum.BuffetStatus.占用.ToString())
                        myfrmBAMain.xtraTabControlMain.SelectedTabPage = tempPage;

                }
            }
        }
    }
}