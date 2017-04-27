
//******************************************************************************************************
//** Copyright (C) 2010-2013 �ش��������ѧԺ
//** �����ˣ������
//** ������\�ļ�����frmLogin
//** �๦�ܣ�ϵͳ��¼����
//** �� ������������ϵͳ��¼����
//** �������ڣ�2013-1-14
//** �޸�(&U)�ˣ������
//** �޸�(&U)���ڣ�2013-1-14
//** �������ڣ�2013-1-14
//******************************************************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using System.Threading;
using CMS.BULayer;
namespace CMS.UILayer.frmAssist
{
    /// <summary>
    /// ϵͳ��¼����
    /// </summary>
    /// �����ˣ������
    /// �������ڣ�2013-2-24
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        #region ��������
        /// <summary>
        /// ��¼ϵͳ�û�ʵ��
        /// </summary>
        /// �����ˣ������
        /// �������ڣ�2013-2-24
        public static ClassAssist.SysUser SysUser;
        private BUT_User myBUUser = new BUT_User();
        private VariedEnum.UserLoginStatus EnUserLoginStatus;
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="frmLogin"/> class.
        /// </summary>
        /// �����ˣ������
        /// �������ڣ�2013-2-24
        public frmLogin()
        {
            InitializeComponent();
            if (ClassAssist.SysExamine.SysDBExam(this) == false)
                Application.ExitThread();
        }

        /// <summary>
        /// ����û�����
        /// </summary>
        /// <returns>�ɹ�true</returns>
        private bool CheckInput()
        {
            string UserName = this.txtUserName.Text.Trim();
            string UserPWD = this.txtUserPassword.Text.Trim();
            if (UserName.Length == 0)
            {
                XtraMessageBox.Show("�û�������Ϊ�գ�", "��ʾ��",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtUserName.Focus();
                return false;
            }
            if (UserPWD.Length == 0)
            {
                XtraMessageBox.Show("�û����벻��Ϊ�գ�", "��ʾ��",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtUserPassword.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// ����û���¼
        /// </summary>
        /// <returns></returns>
        private bool CheckLogin()
        {
            string UserName = this.txtUserName.Text.Trim();
            string UserPWD = this.txtUserPassword.Text.Trim();
            if (!CheckInput())
                return false;
            try
            {
                EnUserLoginStatus = myBUUser.CheckLogin(UserName, UserPWD);
                //EnUserLoginStatus = true;
            }
            catch(Exception ex)
            {
                EnUserLoginStatus = VariedEnum.UserLoginStatus.UnknowError;
                //XtraMessageBox.Show("ϵͳ��æ�����Ժ����ԣ�", "��ʾ��",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Handles the Click event of the btnLogin control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// �����ˣ������
        /// �������ڣ�2013-2-24
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!CheckLogin())
                return;
            string UserName = this.txtUserName.Text.Trim();
            string UserPWD = this.txtUserPassword.Text.Trim();
            switch (EnUserLoginStatus)
            {
                case VariedEnum.UserLoginStatus.DotExistUser:
                    XtraMessageBox.Show("�û��������ڣ���ȷ�������û����ƣ�","��ʾ��", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtUserName.Focus();
                    this.txtUserName.Select();
                    break;
                case VariedEnum.UserLoginStatus.PasswordError:
                    XtraMessageBox.Show("�������", "��ʾ��",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtUserPassword.Focus();
                    this.txtUserPassword.Select();
                    break;
                case VariedEnum.UserLoginStatus.Successed:
                    EnterSystem(UserName,UserPWD);
                    break;
                case VariedEnum.UserLoginStatus.UnknowError:
                    XtraMessageBox.Show("��֤�û���Ϣ������ȷ����������Ϸ�", "��ʾ��",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                default:
                    XtraMessageBox.Show("ϵͳ��æ�����Ժ����ԣ�", "��ʾ��",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
        }

        /// <summary>
        /// ����ϵͳ
        /// </summary>
        /// �����ˣ������
        /// �������ڣ�2013-02-26
        private void EnterSystem(string paramUserName,string paramUserPWD)
        {
            try
            {
                SysUser = new CMS.UILayer.ClassAssist.SysUser(paramUserName, paramUserPWD);
                BUT_SysLog.InsertSysLog(VariedEnum.LogType.ϵͳ�¼�, SysUser.UserID, "�ɹ���½ϵͳ");
                frmMain myfrmMain = new frmMain();
                this.Hide();
                myfrmMain.Show();
            }
            catch (Exception ex)
            {
                BUT_SysLog.InsertSysLog(ex,SysUser.UserID);
            }
        }

        /// <summary>
        /// Handles the Click event of the btnCancel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// �����ˣ������
        /// �������ڣ�2013-2-24
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// ��ҳ���������ݿ�
        /// </summary>
        /// <param name="paramOperatorForm"></param>
        public void SetSql(Form paramOperatorForm)
        {
            frmGeneralTool.SysDataConfig mySysDataConfig = new CMS.UILayer.frmGeneralTool.SysDataConfig();
            //mySysDataConfig.Owner = paramOperatorForm;
            mySysDataConfig.Show();
            mySysDataConfig.TopMost = true;
            mySysDataConfig.Activate();
           
        }

        private void ���ݿ�����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetSql(this);
        }
    }
}