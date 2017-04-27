namespace CMS.UILayer.frmGeneralTool
{
    partial class frmSysOption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSysOption));
            this.chkBeforExit = new System.Windows.Forms.CheckBox();
            this.chkMax = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gpbChoose = new System.Windows.Forms.GroupBox();
            this.rdbExit = new System.Windows.Forms.RadioButton();
            this.rdbHide = new System.Windows.Forms.RadioButton();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnDefault = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            this.gpbChoose.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkBeforExit
            // 
            this.chkBeforExit.AutoSize = true;
            this.chkBeforExit.Checked = true;
            this.chkBeforExit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBeforExit.Location = new System.Drawing.Point(27, 57);
            this.chkBeforExit.Name = "chkBeforExit";
            this.chkBeforExit.Size = new System.Drawing.Size(180, 18);
            this.chkBeforExit.TabIndex = 0;
            this.chkBeforExit.Text = "退出系统时询问(不记住选择)";
            this.chkBeforExit.UseVisualStyleBackColor = true;
            this.chkBeforExit.CheckedChanged += new System.EventHandler(this.chkBeforExit_CheckedChanged);
            // 
            // chkMax
            // 
            this.chkMax.AutoSize = true;
            this.chkMax.Checked = true;
            this.chkMax.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMax.Location = new System.Drawing.Point(27, 26);
            this.chkMax.Name = "chkMax";
            this.chkMax.Size = new System.Drawing.Size(122, 18);
            this.chkMax.TabIndex = 0;
            this.chkMax.Text = "系统启动时最大化";
            this.chkMax.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gpbChoose);
            this.groupBox1.Controls.Add(this.chkMax);
            this.groupBox1.Controls.Add(this.chkBeforExit);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 180);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "常规";
            // 
            // gpbChoose
            // 
            this.gpbChoose.Controls.Add(this.rdbExit);
            this.gpbChoose.Controls.Add(this.rdbHide);
            this.gpbChoose.Location = new System.Drawing.Point(27, 91);
            this.gpbChoose.Name = "gpbChoose";
            this.gpbChoose.Size = new System.Drawing.Size(255, 64);
            this.gpbChoose.TabIndex = 4;
            this.gpbChoose.TabStop = false;
            this.gpbChoose.Text = "默认选择";
            // 
            // rdbExit
            // 
            this.rdbExit.AutoSize = true;
            this.rdbExit.Location = new System.Drawing.Point(149, 23);
            this.rdbExit.Name = "rdbExit";
            this.rdbExit.Size = new System.Drawing.Size(73, 18);
            this.rdbExit.TabIndex = 3;
            this.rdbExit.Text = "直接退出";
            this.rdbExit.UseVisualStyleBackColor = true;
            // 
            // rdbHide
            // 
            this.rdbHide.AutoSize = true;
            this.rdbHide.Checked = true;
            this.rdbHide.Location = new System.Drawing.Point(17, 23);
            this.rdbHide.Name = "rdbHide";
            this.rdbHide.Size = new System.Drawing.Size(97, 18);
            this.rdbHide.TabIndex = 2;
            this.rdbHide.TabStop = true;
            this.rdbHide.Text = "隐藏到任务栏";
            this.rdbHide.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(12, 202);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "确定(&O)";
            this.btnOk.ToolTip = "确定系统设置(Alt+O/Enter)";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(122, 202);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(75, 23);
            this.btnDefault.TabIndex = 6;
            this.btnDefault.Text = "默认(&D)";
            this.btnDefault.ToolTip = "还原为系统默认(Alt+D)";
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(236, 202);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "返回(&C)";
            this.btnCancel.ToolTip = "返回系统主界面(Alt+C)";
            // 
            // frmSysOption
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(323, 234);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSysOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统选项";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpbChoose.ResumeLayout(false);
            this.gpbChoose.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkMax;
        private System.Windows.Forms.CheckBox chkBeforExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbExit;
        private System.Windows.Forms.RadioButton rdbHide;
        private System.Windows.Forms.GroupBox gpbChoose;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SimpleButton btnDefault;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}