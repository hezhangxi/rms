
//******************************************************************************************************
//** Copyright (C) 2010-2013 重大网络教育学院
//** 创建人：桂书丛
//** 类名称\文件名：frmLogin
//** 类功能：系统登录窗体
//** 描 述：餐饮管理系统登录窗体
//** 创建日期：2013-1-14
//** 修改(&U)人：桂书丛
//** 修改(&U)日期：2013-1-14
//** 整理日期：2013-1-14
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
    /// 系统登录窗体
    /// </summary>
    /// 创建人：桂书丛
    /// 创建日期：2013-2-24
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        #region 变量定义
        /// <summary>
        /// 登录系统用户实体
        /// </summary>
        /// 创建人：桂书丛
        /// 创建日期：2013-2-24
        public static ClassAssist.SysUser SysUser;
        private BUT_User myBUUser = new BUT_User();
        private VariedEnum.UserLoginStatus EnUserLoginStatus;
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="frmLogin"/> class.
        /// </summary>
        /// 创建人：桂书丛
        /// 创建日期：2013-2-24
        public frmLogin()
        {
            InitializeComponent();
            if (ClassAssist.SysExamine.SysDBExam(this) == false)
                Application.ExitThread();
        }

        /// <summary>
        /// 检测用户输入
        /// </summary>
        /// <returns>成功true</returns>
        private bool CheckInput()
        {
            string UserName = this.txtUserName.Text.Trim();
            string UserPWD = this.txtUserPassword.Text.Trim();
            if (UserName.Length == 0)
            {
                XtraMessageBox.Show("用户名不能为空！", "提示：",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtUserName.Focus();
                return false;
            }
            if (UserPWD.Length == 0)
            {
                XtraMessageBox.Show("用户密码不能为空！", "提示：",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtUserPassword.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// 检测用户登录
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
                //XtraMessageBox.Show("系统繁忙！请稍后再试！", "提示：",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Handles the Click event of the btnLogin control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-2-24
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!CheckLogin())
                return;
            string UserName = this.txtUserName.Text.Trim();
            string UserPWD = this.txtUserPassword.Text.Trim();
            switch (EnUserLoginStatus)
            {
                case VariedEnum.UserLoginStatus.DotExistUser:
                    XtraMessageBox.Show("用户名不存在！请确认您的用户名称！","提示：", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtUserName.Focus();
                    this.txtUserName.Select();
                    break;
                case VariedEnum.UserLoginStatus.PasswordError:
                    XtraMessageBox.Show("密码错误！", "提示：",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtUserPassword.Focus();
                    this.txtUserPassword.Select();
                    break;
                case VariedEnum.UserLoginStatus.Successed:
                    EnterSystem(UserName,UserPWD);
                    break;
                case VariedEnum.UserLoginStatus.UnknowError:
                    XtraMessageBox.Show("验证用户信息出错，请确定您的输入合法", "提示：",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                default:
                    XtraMessageBox.Show("系统繁忙！请稍后再试！", "提示：",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
        }

        /// <summary>
        /// 进入系统
        /// </summary>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-26
        private void EnterSystem(string paramUserName,string paramUserPWD)
        {
            try
            {
                SysUser = new CMS.UILayer.ClassAssist.SysUser(paramUserName, paramUserPWD);
                BUT_SysLog.InsertSysLog(VariedEnum.LogType.系统事件, SysUser.UserID, "成功登陆系统");
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
        /// 创建人：桂书丛
        /// 创建日期：2013-2-24
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 主页面配置数据库
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

        private void 数据库配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetSql(this);
        }
    }
}