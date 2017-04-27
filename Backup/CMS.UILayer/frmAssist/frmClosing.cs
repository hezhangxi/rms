
//******************************************************************************************************
//** Copyright (C) 2010-2013 重大网络教育学院
//** 创建人：桂书丛
//** 类名称\文件名：frmClosing
//** 类功能：系统关闭时提示窗体
//** 描 述：提示用户是否确定退出
//** 创建日期：2013-1-15
//** 修改(&U)人：桂书丛
//** 修改(&U)日期：2013-1-15
//** 整理日期：2013-1-15
//******************************************************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CMS.UILayer.frmAssist
{
    public partial class frmClosing : DevExpress.XtraEditors.XtraForm
    {
        public static bool DirectExit = false;
        private ClassAssist.INIOperator myINIOperator = ClassAssist.CommonOperator.GetSysINI();
        public frmClosing()
        {
            InitializeComponent();
        }

        private void frmClosing_Load(object sender, EventArgs e)
        {
            bool RemberOrNot = myINIOperator.ReadBoolean("AppExit", "Remember");
            if (RemberOrNot == false)
            {
                if (myINIOperator.ReadBoolean("AppExit", "DirectExit") == true)
                    this.radioGroupChoose.SelectedIndex = 1;
                return;
            }
            else
            {
                DirectExit = myINIOperator.ReadBoolean("AppExit", "DirectExit");
                this.DialogResult = DialogResult.Yes;
            }
        }


        private void radioGroupChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tempIntValue = this.radioGroupChoose.SelectedIndex;
            DirectExit = (tempIntValue == 0) ? false : true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            chkRember_CheckedChanged(sender, e);
            this.DialogResult = DialogResult.Yes;
        }

        private void chkRember_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkRember.Checked == true)
            {
                myINIOperator.Write("AppExit", "Remember", true);
                myINIOperator.Write("AppExit", "DirectExit", DirectExit);
            }
            else
            {
                myINIOperator.Write("AppExit", "Remember", false);
                myINIOperator.Write("AppExit", "DirectExit", DirectExit);
            }
        }
    }
}
