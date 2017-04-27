namespace CMS.UILayer.frmAssist
{
    partial class frmClosing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClosing));
            this.chkRember = new DevExpress.XtraEditors.CheckEdit();
            this.radioGroupChoose = new DevExpress.XtraEditors.RadioGroup();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.chkRember.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupChoose.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // chkRember
            // 
            this.chkRember.Location = new System.Drawing.Point(24, 60);
            this.chkRember.Name = "chkRember";
            this.chkRember.Properties.Caption = "记住选择，不再提示";
            this.chkRember.Size = new System.Drawing.Size(134, 19);
            this.chkRember.TabIndex = 4;
            this.chkRember.CheckedChanged += new System.EventHandler(this.chkRember_CheckedChanged);
            // 
            // radioGroupChoose
            // 
            this.radioGroupChoose.Location = new System.Drawing.Point(26, 14);
            this.radioGroupChoose.Name = "radioGroupChoose";
            this.radioGroupChoose.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroupChoose.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroupChoose.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "隐藏到任务栏"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "直接退出")});
            this.radioGroupChoose.Size = new System.Drawing.Size(225, 36);
            this.radioGroupChoose.TabIndex = 5;
            this.radioGroupChoose.SelectedIndexChanged += new System.EventHandler(this.radioGroupChoose_SelectedIndexChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(26, 91);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.ToolTip = "确定执行所选(Alt+O/Enter)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(176, 91);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.ToolTip = "取消退出系统(Alt+C/Esc)";
            // 
            // frmClosing
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(276, 134);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.radioGroupChoose);
            this.Controls.Add(this.chkRember);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClosing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统退出提示";
            this.Load += new System.EventHandler(this.frmClosing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chkRember.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupChoose.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit chkRember;
        private DevExpress.XtraEditors.RadioGroup radioGroupChoose;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}