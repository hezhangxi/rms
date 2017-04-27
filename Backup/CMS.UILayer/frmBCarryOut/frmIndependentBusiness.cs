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
    /// ����Ӫҵ
    /// </summary>
    /// �����ˣ������
    /// ����ʱ�䣺2013-02-04
    public partial class frmIndependentBusiness : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="frmIndependentBusiness"/> class.
        /// </summary>
        /// �����ˣ������
        /// ����ʱ�䣺2013-02-04
        public frmIndependentBusiness()
        {
            InitializeComponent();
            GetBAMain();
        }

        /// <summary>
        /// Gets the BA main.
        /// </summary>
        /// �����ˣ������
        /// ����ʱ�䣺2013-02-04
        private void GetBAMain()
        {
            frmAssist.frmBAMain myfrmBAMain = new CMS.UILayer.frmAssist.frmBAMain();
            SplitContainerControl tempMainControl = myfrmBAMain.splitContainerControlMain;
            myfrmBAMain.barManagerMain.Form = this;                                       //��䲻���٣��Ǹ��˵��ƶ�һ������
            this.groupControlMain.Controls.Add(tempMainControl);
            tempMainControl.Dock = DockStyle.Fill;
        }
    }
}