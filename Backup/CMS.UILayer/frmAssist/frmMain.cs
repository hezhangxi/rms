
//******************************************************************************************************
//** Copyright (C) 2010-2013 重大网络教育学院
//** 创建人：桂书丛
//** 类名称\文件名：frmMain
//** 类功能：系统主窗体
//** 描 述：餐饮管理系统主窗体
//** 创建日期：2013-1-14
//** 修改(&U)人：桂书丛
//** 修改(&U)日期：2013-1-27
//** 整理日期：2013-1-27
//******************************************************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using System.Threading;
using DevExpress.XtraGrid.Views.Grid;
using CMS.BULayer;
using CMS.Model;
using CMS.CommonLayer;

namespace CMS.UILayer.frmAssist
{
    /// <summary>
    /// 系统主窗体
    /// </summary>
    /// 创建人：桂书丛
    /// 创建日期：2013-02-01
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        private frmBAMain frmBAMain = new frmBAMain();

        #region 构造函数
        /// <summary>
        /// Initializes a new instance of the <see cref="frmMain"/> class.
        /// </summary>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-23
        public frmMain()
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
            frmBAMain myfrmBAMain = new frmBAMain();
            SplitContainerControl tempMainControl = myfrmBAMain.splitContainerControlMain;
            myfrmBAMain.barManagerMain.Form = this;                                       //这句不能少，是给菜单指定一个窗体
            this.panelControlMain.Controls.Add(tempMainControl);
            tempMainControl.Dock = DockStyle.Fill;
        }
        #endregion

        #region private void LoadUserInfo() 加载用户信息
        /// <summary>
        /// 加载用户信息
        /// </summary>
        private void LoadUserInfo()
        {
            string UserName = frmLogin.SysUser.UserName;
            string UserRight = frmLogin.SysUser.UserRight;
            this.barBtnItemCurrentUser.Caption = "当前用户：" + UserName;
            this.barBtnItemUserRight.Caption = "用户权限：" + UserRight;
            this.icnMain.Text = "系统用户：" + UserName;
            this.icnMain.Text += Environment.NewLine + "用户权限：" + UserRight;
            this.icnMain.Text += Environment.NewLine + "餐饮管理系统测试版 V1.0";
            this.Text += " ------ 用户：" + UserRight + "[" + UserName + "]";
        }
        #endregion

        #region 窗体事件

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            //获得当前日期、时间、星期，显示到左边伸缩面板标题上
            string strCurrentTime = DateTime.Now.ToString("yyyy年M月d日 HH:mm:ss dddd");
            this.barStaticItemCurrentTime.Caption = "当前时间：" + DateTime.Now.ToString();
            this.dockPanelLeft.Text = strCurrentTime;
        }

        /// <summary>
        /// Handles the Load event of the frmMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-23
        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                InitSkins();
                LoadUserInfo();
                LoadModule(frmLogin.SysUser.UserModule);//加载模块菜单
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handles the FormClosing event of the frmMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.FormClosingEventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-23
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            string INIFileName = Environment.CurrentDirectory + "\\SysSettings.ini";
            ClassAssist.INIOperator myINIOperator = new CMS.UILayer.ClassAssist.INIOperator(INIFileName);
            bool RemberOrNot = myINIOperator.ReadBoolean("AppExit", "Remember");
            if (RemberOrNot == true)
            {
                bool DirectExit = myINIOperator.ReadBoolean("AppExit", "DirectExit");
                if (DirectExit == true)
                {
                    BUT_SysLog.InsertSysLog(VariedEnum.LogType.系统事件, frmAssist.frmLogin.SysUser.UserID, "退出系统");
                    ClassAssist.CommonOperator.AnimateWindowClosing(this.Handle);
                    Application.ExitThread();
                }
                else
                {
                    e.Cancel = true;
                    this.WindowState = FormWindowState.Minimized;
                    this.Hide();
                }
            }
            else
            {
                frmAssist.frmClosing myfrmClosing = new frmClosing();
                DialogResult myDialogResult = myfrmClosing.ShowDialog();
                if (myDialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else
                {
                    if (frmClosing.DirectExit == true)
                    {
                        ClassAssist.CommonOperator.AnimateWindowClosing(this.Handle);
                        Application.ExitThread();
                    }
                    else
                    {
                        e.Cancel = true;
                        this.WindowState = FormWindowState.Minimized;
                        this.Hide();
                    }
                }
            }
        }

        /// <summary>
        /// Handles the Resize event of the frmMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-23
        private void frmMain_Resize(object sender, EventArgs e)
        {
            //if (this.WindowState == FormWindowState.Normal)
            //   this.WindowState = FormWindowState.Maximized;
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.icnMain.ShowBalloonTip(1500, "餐饮管理系统", "嘿……我还没退出,我在这里啊！", ToolTipIcon.Info);
                this.Hide();
            }
        }

        /// <summary>
        /// Handles the Shown event of the frmMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-23
        private void frmMain_Shown(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Resize += this.frmMain_Resize;
        }
        #endregion

        #region private void InitSkins() 初始化加载可用系统皮肤
        /// <summary>
        /// 初始化加载可用系统皮肤
        /// </summary>
        private void InitSkins()
        {
            foreach (DevExpress.Skins.SkinContainer cnt in DevExpress.Skins.SkinManager.Default.Skins)
            {
                BarButtonItem item = new BarButtonItem(barManagerMain, cnt.SkinName);
                ToolStripMenuItem tempItem = new ToolStripMenuItem(cnt.SkinName);
                this.ChangeSkinToolStripMenuItem.DropDownItems.Add(tempItem);
                this.barSubItemSkinChange.AddItem(item);
                tempItem.Click+=new EventHandler(tempItem_Click);
                item.ItemClick += new ItemClickEventHandler(barBtnItemSkin_ItemClick);
                tempItem.CheckOnClick = true;
                item.ButtonStyle = BarButtonStyle.Check;
                if (DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveSkinName == cnt.SkinName)
                {
                    InitPaintStyle(item);
                    tempItem.Checked = true;
                }
            }
        }
        #endregion

        #region private void InitPaintStyle(BarItem item) 初始加载皮肤
        /// <summary>
        /// 初始加载皮肤
        /// </summary>
        /// <param name="item"></param>
        private void InitPaintStyle(BarItem item)
        {
            if (item == null)
                return;
            foreach (LinkPersistInfo obj in barSubItemSkinChange.LinksPersistInfo)
            {
                (obj.Item as BarButtonItem).Down = false;
                (obj.Item as BarButtonItem).Refresh();
            }

            (item as BarButtonItem).Down = true;
            (item as BarButtonItem).Refresh();
        }
        #endregion

        #region 换肤事件
        /// <summary>
        /// 换肤事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barBtnItemSkin_ItemClick(object sender, ItemClickEventArgs e)
        {
            DevExpress.Skins.SkinManager.EnableFormSkins();
            string skinName = e.Item.Caption;
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(skinName);
            InitPaintStyle(e.Item);
            Properties.Settings.Default.Save();
        }
        private void tempItem_Click(object sender, EventArgs e)
        {
            DevExpress.Skins.SkinManager.EnableFormSkins();
            string skinName = ((ToolStripMenuItem)sender).Text;
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(skinName);
            Properties.Settings.Default.Save();
        }
        #endregion

        #region private void LoadModule(DataTable paramDataTable) 加载系统模块
        /// <summary>
        /// 加载系统模块
        /// </summary>
        /// <param name="paramDataTable"></param>
        private void LoadModule(DataTable paramDataTable)
        {
            if (paramDataTable.Rows.Count > 0)
            {
                //创建GROUP
                DevExpress.XtraNavBar.NavBarGroup navBarGroupParent;
                if (paramDataTable == null)
                    return;
                BindingBarManager(paramDataTable);
                foreach (DataRow tempDataRow in paramDataTable.Rows)
                {
                    if (tempDataRow["MODULEID"].ToString() != string.Empty)
                    {
                        if (!(tempDataRow["PARENTID"].ToString() == "0"))
                            continue;
                        else
                        {
                            navBarGroupParent = new DevExpress.XtraNavBar.NavBarGroup(tempDataRow["FULLNAME"].ToString());
                            navBarGroupParent.Name = tempDataRow["ID"].ToString();
                            navBarGroupParent.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
                            navBarGroupParent.Appearance.Options.UseFont = true;
                            navBarGroupParent.Expanded = true;
                            this.navBarControlLeft.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {navBarGroupParent});
                            LoadChildItem(paramDataTable, navBarGroupParent);
                        }
                    }
                }
            }
        }
        #endregion

        #region private void BindingBarManager(DataTable paramDataTable) 加载系统菜单栏和工具栏
        /// <summary>
        /// 加载系统菜单栏和工具栏
        /// </summary>
        /// <param name="paramDataTable"></param>
        private void BindingBarManager(DataTable paramDataTable)
        {
            for (int i = 0; i < paramDataTable.Rows.Count; i++)
            {
                foreach (DevExpress.XtraBars.BarItem trl in this.barManagerMain.Items)
                {
                    if (paramDataTable.Rows[i]["MODULEID"].ToString() == string.Empty)
                    {
                        if (trl.Tag != null && trl.Tag.ToString() == paramDataTable.Rows[i]["ID"].ToString())
                        {
                            trl.Enabled = false;
                            trl.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        }
                    }
                    if (trl.Tag != null && trl.Tag.ToString() == paramDataTable.Rows[i]["ID"].ToString())
                    {
                        trl.Tag = paramDataTable.Rows[i]["HREF"].ToString();
                    }
                }
            }
        }
        #endregion

        #region private void LoadChildItem(DataTable paramDataTable,DevExpress.XtraNavBar.NavBarGroup paramNavBarGroup) 加载系统二级菜单
        /// <summary>
        /// 加载系统二级菜单
        /// </summary>
        /// <param name="paramDataTable">用户权限数据集</param>
        /// <param name="paramNavBarGroup">左侧二级菜单</param>
        private void LoadChildItem(DataTable paramDataTable,DevExpress.XtraNavBar.NavBarGroup paramNavBarGroup)
        {
            DevExpress.XtraNavBar.NavBarItem navBarItemChild;
            foreach (DataRow tempDataRow in paramDataTable.Rows)
            {
                if ((tempDataRow["MODULEID"].ToString() != string.Empty))
                {
                    if (!(tempDataRow["PARENTID"].ToString() == paramNavBarGroup.Name))
                        continue;
                    else
                    {
                        navBarItemChild = new DevExpress.XtraNavBar.NavBarItem(tempDataRow["FULLName"].ToString());
                        navBarItemChild.Name = tempDataRow["ID"].ToString();
                        navBarItemChild.Tag = tempDataRow["HREF"].ToString();
                        navBarItemChild.LinkClicked += this.navBarItem_LinkClicked;
                        paramNavBarGroup.ItemLinks.Add(navBarItemChild);
                    }
                }
            }
            //paramNavBarGroup.Expanded = true;
        }
        #endregion

        #region private void navBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e) 二级菜单事件
        /// <summary>
        /// 二级菜单事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void navBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                DevExpress.XtraNavBar.NavBarItem tempnavBarItem = (DevExpress.XtraNavBar.NavBarItem)sender;
                System.Reflection.Assembly tempAssembly = System.Reflection.Assembly.GetExecutingAssembly();
                //XtraMessageBox.Show(tempnavBarItem.Tag.ToString());
                Form myForm = (Form)tempAssembly.CreateInstance(tempnavBarItem.Tag.ToString());
                myForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion 

        #region private void barBtnItem_ItemClick(object sender, ItemClickEventArgs e) 二级菜单事件
        /// <summary>
        /// 二级菜单事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barBtnItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DevExpress.XtraBars.BarItem tempbarBtnItem = e.Item;
                System.Reflection.Assembly tempAssembly = System.Reflection.Assembly.GetExecutingAssembly();
                //XtraMessageBox.Show(tempbarBtnItem.Tag.ToString());
                Form myForm = (Form)tempAssembly.CreateInstance(tempbarBtnItem.Tag.ToString());
                myForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region nico控件事件
        /// <summary>
        /// Handles the MouseDoubleClick event of the nicoMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-23
        private void nicoMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DisplayToolStripMenuItem_Click(sender, e);
        }

        /// <summary>
        /// Handles the Click event of the DisplayToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-23
        private void DisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Maximized;
                this.Show();
                this.Activate();
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
                this.icnMain.ShowBalloonTip(1500, "餐饮管理系统", "嘿……我还没退出,我在这里啊！", ToolTipIcon.Info);
                this.Hide();
            }
        }

        /// <summary>
        /// Handles the Click event of the SafeExitToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-23
        private void SafeExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BUT_SysLog.InsertSysLog(VariedEnum.LogType.系统事件, frmAssist.frmLogin.SysUser.UserID, "退出系统");
            Application.ExitThread();
        }
        #endregion

        /// <summary>
        /// 交班管理
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-3-6
        private void toolbtnExchange_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.FormClosing -= this.frmMain_FormClosing;
            Application.Restart();
        }
        /// <summary>
        /// Handles the ItemClick event of the barLargeButtonItem16 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-3-6
        private void barLargeButtonItemHelp_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraMessageBox.Show("系统暂无帮助信息，若想要帮助请和本系统作者联系","抱歉");
        }

    }
}