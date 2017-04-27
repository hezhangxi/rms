namespace CMS.UILayer.frmSysSet
{
    partial class frmRightAdd
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
            this.panelControlOperator = new DevExpress.XtraEditors.PanelControl();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtDate = new DevExpress.XtraEditors.TextEdit();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.txtPerson = new DevExpress.XtraEditors.TextEdit();
            this.lblPerson = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlOperator)).BeginInit();
            this.panelControlOperator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlOperator
            // 
            this.panelControlOperator.Controls.Add(this.btnBack);
            this.panelControlOperator.Controls.Add(this.btnSave);
            this.panelControlOperator.Controls.Add(this.txtDate);
            this.panelControlOperator.Controls.Add(this.lblDate);
            this.panelControlOperator.Controls.Add(this.txtPerson);
            this.panelControlOperator.Controls.Add(this.lblPerson);
            this.panelControlOperator.Controls.Add(this.txtName);
            this.panelControlOperator.Controls.Add(this.labelControl4);
            this.panelControlOperator.Controls.Add(this.labelControl1);
            this.panelControlOperator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlOperator.Location = new System.Drawing.Point(0, 0);
            this.panelControlOperator.Name = "panelControlOperator";
            this.panelControlOperator.Size = new System.Drawing.Size(307, 203);
            this.panelControlOperator.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(189, 158);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "返回(&B)";
            this.btnBack.ToolTip = "返回系统主界面(Alt+B/Esc)";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSave.Location = new System.Drawing.Point(27, 158);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.ToolTip = "保存用户权限信息(Alt+S/Enter)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(93, 113);
            this.txtDate.Name = "txtDate";
            this.txtDate.Properties.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(171, 21);
            this.txtDate.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(27, 116);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(60, 14);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "创建时间：";
            // 
            // txtPerson
            // 
            this.txtPerson.Location = new System.Drawing.Point(93, 76);
            this.txtPerson.Name = "txtPerson";
            this.txtPerson.Properties.ReadOnly = true;
            this.txtPerson.Size = new System.Drawing.Size(171, 21);
            this.txtPerson.TabIndex = 1;
            // 
            // lblPerson
            // 
            this.lblPerson.Location = new System.Drawing.Point(27, 79);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(56, 14);
            this.lblPerson.TabIndex = 0;
            this.lblPerson.Text = "创 建 人：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(93, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(171, 21);
            this.txtName.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl4.Location = new System.Drawing.Point(2, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(240, 14);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "添加权限名后回管理界面为其选取适当的权限";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "权限名称：";
            // 
            // frmRightAdd
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(307, 203);
            this.Controls.Add(this.panelControlOperator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmRightAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统权限添加";
            ((System.ComponentModel.ISupportInitialize)(this.panelControlOperator)).EndInit();
            this.panelControlOperator.ResumeLayout(false);
            this.panelControlOperator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.PanelControl panelControlOperator;
        private DevExpress.XtraEditors.TextEdit txtDate;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraEditors.TextEdit txtPerson;
        private DevExpress.XtraEditors.LabelControl lblPerson;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}