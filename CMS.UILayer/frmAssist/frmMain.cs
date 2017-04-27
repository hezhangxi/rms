
//******************************************************************************************************
//** Copyright (C) 2010-2013 �ش��������ѧԺ
//** �����ˣ������
//** ������\�ļ�����frmMain
//** �๦�ܣ�ϵͳ������
//** �� ������������ϵͳ������
//** �������ڣ�2013-1-14
//** �޸�(&U)�ˣ������
//** �޸�(&U)���ڣ�2013-1-27
//** �������ڣ�2013-1-27
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
    /// ϵͳ������
    /// </summary>
    /// �����ˣ������
    /// �������ڣ�2013-02-01
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        private frmBAMain frmBAMain = new frmBAMain();

        #region ���캯��
        /// <summary>
        /// Initializes a new instance of the <see cref="frmMain"/> class.
        /// </summary>
        /// �����ˣ������
        /// �������ڣ�2013-02-23
        public frmMain()
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
            frmBAMain myfrmBAMain = new frmBAMain();
            SplitContainerControl tempMainControl = myfrmBAMain.splitContainerControlMain;
            myfrmBAMain.barManagerMain.Form = this;                                       //��䲻���٣��Ǹ��˵�ָ��һ������
            this.panelControlMain.Controls.Add(tempMainControl);
            tempMainControl.Dock = DockStyle.Fill;
        }
        #endregion

        #region private void LoadUserInfo() �����û���Ϣ
        /// <summary>
        /// �����û���Ϣ
        /// </summary>
        private void LoadUserInfo()
        {
            string UserName = frmLogin.SysUser.UserName;
            string UserRight = frmLogin.SysUser.UserRight;
            this.barBtnItemCurrentUser.Caption = "��ǰ�û���" + UserName;
            this.barBtnItemUserRight.Caption = "�û�Ȩ�ޣ�" + UserRight;
            this.icnMain.Text = "ϵͳ�û���" + UserName;
            this.icnMain.Text += Environment.NewLine + "�û�Ȩ�ޣ�" + UserRight;
            this.icnMain.Text += Environment.NewLine + "��������ϵͳ���԰� V1.0";
            this.Text += " ------ �û���" + UserRight + "[" + UserName + "]";
        }
        #endregion

        #region �����¼�

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            //��õ�ǰ���ڡ�ʱ�䡢���ڣ���ʾ�����������������
            string strCurrentTime = DateTime.Now.ToString("yyyy��M��d�� HH:mm:ss dddd");
            this.barStaticItemCurrentTime.Caption = "��ǰʱ�䣺" + DateTime.Now.ToString();
            this.dockPanelLeft.Text = strCurrentTime;
        }

        /// <summary>
        /// Handles the Load event of the frmMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// �����ˣ������
        /// �������ڣ�2013-02-23
        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                InitSkins();
                LoadUserInfo();
                LoadModule(frmLogin.SysUser.UserModule);//����ģ��˵�
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
        /// �����ˣ������
        /// �������ڣ�2013-02-23
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
                    BUT_SysLog.InsertSysLog(VariedEnum.LogType.ϵͳ�¼�, frmAssist.frmLogin.SysUser.UserID, "�˳�ϵͳ");
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
        /// �����ˣ������
        /// �������ڣ�2013-02-23
        private void frmMain_Resize(object sender, EventArgs e)
        {
            //if (this.WindowState == FormWindowState.Normal)
            //   this.WindowState = FormWindowState.Maximized;
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.icnMain.ShowBalloonTip(1500, "��������ϵͳ", "�١����һ�û�˳�,�������ﰡ��", ToolTipIcon.Info);
                this.Hide();
            }
        }

        /// <summary>
        /// Handles the Shown event of the frmMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// �����ˣ������
        /// �������ڣ�2013-02-23
        private void frmMain_Shown(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Resize += this.frmMain_Resize;
        }
        #endregion

        #region private void InitSkins() ��ʼ�����ؿ���ϵͳƤ��
        /// <summary>
        /// ��ʼ�����ؿ���ϵͳƤ��
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

        #region private void InitPaintStyle(BarItem item) ��ʼ����Ƥ��
        /// <summary>
        /// ��ʼ����Ƥ��
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

        #region �����¼�
        /// <summary>
        /// �����¼�
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

        #region private void LoadModule(DataTable paramDataTable) ����ϵͳģ��
        /// <summary>
        /// ����ϵͳģ��
        /// </summary>
        /// <param name="paramDataTable"></param>
        private void LoadModule(DataTable paramDataTable)
        {
            if (paramDataTable.Rows.Count > 0)
            {
                //����GROUP
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

        #region private void BindingBarManager(DataTable paramDataTable) ����ϵͳ�˵����͹�����
        /// <summary>
        /// ����ϵͳ�˵����͹�����
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

        #region private void LoadChildItem(DataTable paramDataTable,DevExpress.XtraNavBar.NavBarGroup paramNavBarGroup) ����ϵͳ�����˵�
        /// <summary>
        /// ����ϵͳ�����˵�
        /// </summary>
        /// <param name="paramDataTable">�û�Ȩ�����ݼ�</param>
        /// <param name="paramNavBarGroup">�������˵�</param>
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

        #region private void navBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e) �����˵��¼�
        /// <summary>
        /// �����˵��¼�
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

        #region private void barBtnItem_ItemClick(object sender, ItemClickEventArgs e) �����˵��¼�
        /// <summary>
        /// �����˵��¼�
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

        #region nico�ؼ��¼�
        /// <summary>
        /// Handles the MouseDoubleClick event of the nicoMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
        /// �����ˣ������
        /// �������ڣ�2013-02-23
        private void nicoMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DisplayToolStripMenuItem_Click(sender, e);
        }

        /// <summary>
        /// Handles the Click event of the DisplayToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// �����ˣ������
        /// �������ڣ�2013-02-23
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
                this.icnMain.ShowBalloonTip(1500, "��������ϵͳ", "�١����һ�û�˳�,�������ﰡ��", ToolTipIcon.Info);
                this.Hide();
            }
        }

        /// <summary>
        /// Handles the Click event of the SafeExitToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// �����ˣ������
        /// �������ڣ�2013-02-23
        private void SafeExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BUT_SysLog.InsertSysLog(VariedEnum.LogType.ϵͳ�¼�, frmAssist.frmLogin.SysUser.UserID, "�˳�ϵͳ");
            Application.ExitThread();
        }
        #endregion

        /// <summary>
        /// �������
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        /// �����ˣ������
        /// �������ڣ�2013-3-6
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
        /// �����ˣ������
        /// �������ڣ�2013-3-6
        private void barLargeButtonItemHelp_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraMessageBox.Show("ϵͳ���ް�����Ϣ������Ҫ������ͱ�ϵͳ������ϵ","��Ǹ");
        }

    }
}