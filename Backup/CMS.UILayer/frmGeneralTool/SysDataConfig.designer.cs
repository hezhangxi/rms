namespace CMS.UILayer.frmGeneralTool
{
    partial class SysDataConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SysDataConfig));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtLoginName = new DevExpress.XtraEditors.TextEdit();
            this.txtServerName = new DevExpress.XtraEditors.MRUEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.brtnBack = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoginName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtPassword);
            this.groupControl1.Controls.Add(this.txtLoginName);
            this.groupControl1.Controls.Add(this.txtServerName);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(17, 14);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(259, 147);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "数据库服务器";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(88, 105);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(151, 21);
            this.txtPassword.TabIndex = 11;
            // 
            // txtLoginName
            // 
            this.txtLoginName.EditValue = "sa";
            this.txtLoginName.Location = new System.Drawing.Point(88, 66);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(151, 21);
            this.txtLoginName.TabIndex = 10;
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(88, 32);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtServerName.Size = new System.Drawing.Size(151, 21);
            this.txtServerName.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "密  码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "登录名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "服务器名称：";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(112, 167);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.ToolTip = "保存系统数据配置(Alt+S/Enter)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // brtnBack
            // 
            this.brtnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.brtnBack.Location = new System.Drawing.Point(212, 167);
            this.brtnBack.Name = "brtnBack";
            this.brtnBack.Size = new System.Drawing.Size(64, 23);
            this.brtnBack.TabIndex = 8;
            this.brtnBack.Text = "返回(&B)";
            this.brtnBack.ToolTip = "取消并返回系统主界面(Alt+B/Esc)";
            this.brtnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // SysDataConfig
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.brtnBack;
            this.ClientSize = new System.Drawing.Size(306, 209);
            this.Controls.Add(this.brtnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SysDataConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统数据配置";
            this.Load += new System.EventHandler(this.SysDataConfig_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SysDataConfig_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoginName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton brtnBack;
        private DevExpress.XtraEditors.MRUEdit txtServerName;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.TextEdit txtLoginName;
    }
}