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
        /// �����ˣ������
        /// ����ʱ�䣺2013-02-04
        public frmDiningTable()
        {
            InitializeComponent();
            GetBAMain();
        }

        /// <summary>
        /// �������ʾ�ؼ�
        /// </summary>
        /// �����ˣ������
        /// �������ڣ�2013-02-24
        private void GetBAMain()
        {
            frmAssist.frmBAMain myfrmBAMain = new CMS.UILayer.frmAssist.frmBAMain();
            myfrmBAMain.btnBuffetStatus_ItemClick(null, null);
            SplitGroupPanel tempMainControl = myfrmBAMain.splitContainerControlMain.Panel1;
            myfrmBAMain.barManagerMain.Form = this;                                       //��䲻���٣��Ǹ��˵��ƶ�һ������
            this.panelControlMain.Controls.Add(tempMainControl);
            tempMainControl.Dock = DockStyle.Fill;
        }
    }
}