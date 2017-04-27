using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using System.Configuration;
namespace CMS.UILayer.frmGeneralTool
{
    public partial class SysDataConfig : DevExpress.XtraEditors.XtraForm
    {
        public SysDataConfig()
        {
            InitializeComponent();
        }

        private void SysDataConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.Owner != null)
                {
                    ((frmAssist.frmLogin)this.Owner).Show();
                    this.Hide();
                }
                else
                    this.Hide();
            }
            catch (Exception ex) { }
        }

        /// <summary>
        /// 检测数据输入
        /// </summary>
        /// <returns></returns>
        private bool CheckInput()
        {
            if (this.txtServerName.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("服务器名不能为空","提示：",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                this.txtServerName.Focus();
                return false;
            }
            if (this.txtLoginName.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("用户名不能为空", "提示：",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtServerName.Focus();
                return false;
            }
            if (this.txtPassword.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("密码不能为空", "提示：",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtPassword.Focus();
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
                return;
            else
            {
                //"server=.;database=CMS;uid=sa;pwd=sa2000"
                string tempConString = "server=" + this.txtServerName.Text.Trim()
                    + "; database=CMS;uid=" + this.txtLoginName.Text.Trim() + ";pwd="+this .txtPassword .Text .Trim ();
                if (ConStringProcess(tempConString))
                {
                    XtraMessageBox.Show("数据配置保存成功,重启系统后生效");
                    this.DialogResult = DialogResult.OK;
                }
                else
                    XtraMessageBox.Show("数据配置保存失败", "请查明后再试", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// 配置数据连接字符串函数
        /// </summary>
        /// <param name="paramUpdateString">要修改(&U)的连接字符串</param>
        /// <returns>true：成功</returns>
        private bool ConStringProcess(string paramUpdateString)
        {
            string ProcessedString = string.Empty;
            try
            {
                ClassAssist.CommonOperator.SaveConfig("ConExpresslyString", paramUpdateString);
                paramUpdateString = ClassAssist.Encryption.AESEncrypt(paramUpdateString, "SIMByZMM");
                ClassAssist.CommonOperator.SaveConfig("ConCiphertextString", paramUpdateString);
            }
            catch //(Exception ex)
            {
                //XtraMessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Owner != null)
                {
                    ((frmAssist.frmLogin)this.Owner).Show();
                    this.Hide();
                }
                else
                    this.Close();
            }
            catch (Exception ex){}
        }

        private void SysDataConfig_Load(object sender, EventArgs e)
        {
            //Activate();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }
    }
}
