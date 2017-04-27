
//*************************************************************************************************
//** 创建人:桂书丛
//** 类名称:frmSysOption
//** 类功能:对系统配置的操作
//** 创建日期:2012-12-27
//** 描 述: 提供对系统配置信息的操作
//** 整理日期:2012-12-27
//*************************************************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CMS.UILayer.frmGeneralTool
{
    public partial class frmSysOption : DevExpress.XtraEditors.XtraForm
    {
        private ClassAssist.INIOperator myINIOperator = ClassAssist.CommonOperator.GetSysINI();
        public frmSysOption()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            if (myINIOperator.ReadBoolean("AppExit", "Remember") == false)
            {
                this.chkBeforExit.Checked = true;
                this.gpbChoose.Enabled = true;
                if (myINIOperator.ReadBoolean("AppExit", "DirectExit") == true)
                    this.rdbExit.Checked = true;
                else
                    this.rdbHide.Checked = true;
            }
            else
            {
                this.chkBeforExit.Checked = false;
                this.gpbChoose.Enabled = false;
            }
            if (myINIOperator.ReadBoolean("AppMainWindowState", "WindowMax"))
                this.chkMax.Checked = true;
            else
                this.chkMax.Checked = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkBeforExit_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkBeforExit.Checked == true)
                this.gpbChoose.Enabled = true;
            else
                this.gpbChoose.Enabled = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.chkMax.Checked == true)
                myINIOperator.Write("AppMainWindowState", "WindowMax",true);
            else
                myINIOperator.Write("AppMainWindowState", "WindowMax", false);
            if (this.chkBeforExit.Checked == true)
            {
                myINIOperator.Write("AppExit", "Remember", false);
                if (this.rdbHide.Checked == true)
                    myINIOperator.Write("AppExit", "DirectExit", false);
                else
                    myINIOperator.Write("AppExit", "DirectExit", true);
            }
            else
                myINIOperator.Write("AppExit", "Remember", true);
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            this.chkMax.Checked = true;
            this.chkBeforExit.Checked = true;
            this.gpbChoose.Enabled = true;
            this.rdbHide.Checked = true;
            btnOk_Click(sender, e);
        }
    }
}
