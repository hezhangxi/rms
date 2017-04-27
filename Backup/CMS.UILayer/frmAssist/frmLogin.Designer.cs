namespace CMS.UILayer.frmAssist
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtUserPassword = new DevExpress.XtraEditors.TextEdit();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtUserName = new DevExpress.XtraEditors.MRUEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.SqlSet = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.数据库配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SqlSet.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(25, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "用户名称：";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(25, 79);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "用户密码：";
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.EditValue = "admin";
            this.txtUserPassword.Location = new System.Drawing.Point(88, 76);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Properties.Mask.BeepOnError = true;
            this.txtUserPassword.Properties.PasswordChar = '*';
            this.txtUserPassword.Size = new System.Drawing.Size(137, 21);
            this.txtUserPassword.TabIndex = 1;
            this.txtUserPassword.ToolTip = "登录系统用户密码";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(25, 115);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "登录(&L)";
            this.btnLogin.ToolTip = "登录系统(Alt+L/Enter)";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(150, 115);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.ToolTip = "取消登录(Alt+C/Esc)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.txtUserName);
            this.groupControl1.Controls.Add(this.txtUserPassword);
            this.groupControl1.Controls.Add(this.btnLogin);
            this.groupControl1.Controls.Add(this.btnCancel);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(114, 41);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(248, 176);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "登录";
            // 
            // txtUserName
            // 
            this.txtUserName.EditValue = "admin";
            this.txtUserName.Location = new System.Drawing.Point(88, 38);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtUserName.Properties.Items.AddRange(new object[] {
            "admin"});
            this.txtUserName.Size = new System.Drawing.Size(137, 21);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.ToolTip = "登录系统用户名称";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseBackColor = true;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl3.Location = new System.Drawing.Point(0, 0);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(362, 41);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "  餐饮点菜管理系统";
            this.labelControl3.ToolTip = "餐饮点菜管理系统测试版 V1.0";
            this.labelControl3.ToolTipIconType = DevExpress.Utils.ToolTipIconType.WindLogo;
            this.labelControl3.ToolTipTitle = "  餐饮管理系统";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureEdit1.EditValue = global::CMS.UILayer.Properties.Resources.food;
            this.pictureEdit1.Location = new System.Drawing.Point(0, 41);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(114, 176);
            this.pictureEdit1.TabIndex = 5;
            this.pictureEdit1.ToolTip = "餐饮管理系统测试版 V1.0";
            this.pictureEdit1.ToolTipIconType = DevExpress.Utils.ToolTipIconType.WindLogo;
            this.pictureEdit1.ToolTipTitle = "餐饮管理系统";
            // 
            // SqlSet
            // 
            this.SqlSet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据库配置ToolStripMenuItem});
            this.SqlSet.Name = "SqlSet";
            this.SqlSet.Size = new System.Drawing.Size(153, 48);
            // 
            // 数据库配置ToolStripMenuItem
            // 
            this.数据库配置ToolStripMenuItem.Name = "数据库配置ToolStripMenuItem";
            this.数据库配置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.数据库配置ToolStripMenuItem.Text = "数据库配置";
            this.数据库配置ToolStripMenuItem.Click += new System.EventHandler(this.数据库配置ToolStripMenuItem_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(362, 217);
            this.ContextMenuStrip = this.SqlSet;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelControl3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统登录";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtUserPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.SqlSet.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtUserPassword;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.MRUEdit txtUserName;
        private System.Windows.Forms.ContextMenuStrip SqlSet;
        private System.Windows.Forms.ToolStripMenuItem 数据库配置ToolStripMenuItem;
    }
}