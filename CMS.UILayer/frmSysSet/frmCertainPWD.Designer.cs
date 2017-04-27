namespace CMS.UILayer.frmSysSet
{
    partial class frmCertainPWD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCertainPWD));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtUserPWD = new DevExpress.XtraEditors.TextEdit();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserPWD.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(216, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "请输入要修改用户的密码以确定您的权限";
            // 
            // txtUserPWD
            // 
            this.txtUserPWD.Location = new System.Drawing.Point(27, 41);
            this.txtUserPWD.Name = "txtUserPWD";
            this.txtUserPWD.Properties.PasswordChar = '*';
            this.txtUserPWD.Size = new System.Drawing.Size(229, 21);
            this.txtUserPWD.TabIndex = 1;
            this.txtUserPWD.ToolTip = "密码输入";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(277, 40);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.ToolTip = "确定密码(Alt+O/Enter)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmCertainPWD
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 95);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtUserPWD);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCertainPWD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户密码确定";
            this.Load += new System.EventHandler(this.frmCertainPWD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtUserPWD.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtUserPWD;
        private DevExpress.XtraEditors.SimpleButton btnOK;
    }
}