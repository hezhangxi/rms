namespace CMS.UILayer.frmEmployee
{
    partial class frmAdd
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
            this.lblNameDep = new DevExpress.XtraEditors.LabelControl();
            this.txtNameDep = new DevExpress.XtraEditors.TextEdit();
            this.lblPerson = new DevExpress.XtraEditors.LabelControl();
            this.txtPerson = new DevExpress.XtraEditors.TextEdit();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDate = new DevExpress.XtraEditors.TextEdit();
            this.medDescription = new DevExpress.XtraEditors.MemoEdit();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancle = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameDep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNameDep
            // 
            this.lblNameDep.Location = new System.Drawing.Point(20, 42);
            this.lblNameDep.Name = "lblNameDep";
            this.lblNameDep.Size = new System.Drawing.Size(60, 14);
            this.lblNameDep.TabIndex = 0;
            this.lblNameDep.Text = "部门名称：";
            // 
            // txtNameDep
            // 
            this.txtNameDep.Location = new System.Drawing.Point(86, 39);
            this.txtNameDep.Name = "txtNameDep";
            this.txtNameDep.Size = new System.Drawing.Size(167, 21);
            this.txtNameDep.TabIndex = 0;
            // 
            // lblPerson
            // 
            this.lblPerson.Location = new System.Drawing.Point(20, 146);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(48, 14);
            this.lblPerson.TabIndex = 0;
            this.lblPerson.Text = "创建人：";
            // 
            // txtPerson
            // 
            this.txtPerson.Location = new System.Drawing.Point(86, 143);
            this.txtPerson.Name = "txtPerson";
            this.txtPerson.Properties.ReadOnly = true;
            this.txtPerson.Size = new System.Drawing.Size(167, 21);
            this.txtPerson.TabIndex = 1;
            this.txtPerson.TabStop = false;
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(20, 181);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(60, 14);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "创建时间：";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(20, 82);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 14);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "描述：";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(86, 178);
            this.txtDate.Name = "txtDate";
            this.txtDate.Properties.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(167, 21);
            this.txtDate.TabIndex = 1;
            this.txtDate.TabStop = false;
            // 
            // medDescription
            // 
            this.medDescription.Location = new System.Drawing.Point(86, 80);
            this.medDescription.Name = "medDescription";
            this.medDescription.Size = new System.Drawing.Size(167, 47);
            this.medDescription.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(25, 44);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(78, 30);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.ToolTip = "确定(Alt+O/Enter)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.Location = new System.Drawing.Point(25, 111);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(78, 30);
            this.btnCancle.TabIndex = 3;
            this.btnCancle.Text = "取消(&C)";
            this.btnCancle.ToolTip = "取消(Alt+C/Esc)";
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lblNameDep);
            this.groupControl1.Controls.Add(this.txtNameDep);
            this.groupControl1.Controls.Add(this.lblPerson);
            this.groupControl1.Controls.Add(this.medDescription);
            this.groupControl1.Controls.Add(this.txtPerson);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.lblDate);
            this.groupControl1.Controls.Add(this.txtDate);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(275, 221);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "信息";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnOK);
            this.groupControl2.Controls.Add(this.btnCancle);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl2.Location = new System.Drawing.Point(272, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(124, 221);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "操作";
            // 
            // frmAdd
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancle;
            this.ClientSize = new System.Drawing.Size(396, 221);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加新部门";
            this.Load += new System.EventHandler(this.frmAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNameDep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblNameDep;
        private DevExpress.XtraEditors.TextEdit txtNameDep;
        private DevExpress.XtraEditors.LabelControl lblPerson;
        private DevExpress.XtraEditors.TextEdit txtPerson;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtDate;
        private DevExpress.XtraEditors.MemoEdit medDescription;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnCancle;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
    }
}