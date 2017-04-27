namespace CMS.UILayer.frmEmployee
{
    partial class frmAddPosition
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
            this.btnCancle = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.medDescription = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDate = new DevExpress.XtraEditors.TextEdit();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.lblDep = new DevExpress.XtraEditors.LabelControl();
            this.txtNamePos = new DevExpress.XtraEditors.TextEdit();
            this.lblNameDep = new DevExpress.XtraEditors.LabelControl();
            this.lupDep = new DevExpress.XtraEditors.LookUpEdit();
            this.txtPerson = new DevExpress.XtraEditors.TextEdit();
            this.lblPerson = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.medDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamePos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupDep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancle
            // 
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.Location = new System.Drawing.Point(23, 119);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(78, 30);
            this.btnCancle.TabIndex = 13;
            this.btnCancle.Text = "取消(&C)";
            this.btnCancle.ToolTip = "取消(Alt+C/Esc)";
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(23, 39);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(78, 30);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.ToolTip = "信息确定(Alt+O/Enter)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // medDescription
            // 
            this.medDescription.Location = new System.Drawing.Point(89, 117);
            this.medDescription.Name = "medDescription";
            this.medDescription.Size = new System.Drawing.Size(218, 47);
            this.medDescription.TabIndex = 10;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(26, 119);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 14);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "描述：";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(89, 227);
            this.txtDate.Name = "txtDate";
            this.txtDate.Properties.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(215, 21);
            this.txtDate.TabIndex = 11;
            this.txtDate.TabStop = false;
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(26, 230);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(60, 14);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "创建时间：";
            // 
            // lblDep
            // 
            this.lblDep.Location = new System.Drawing.Point(26, 79);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(60, 14);
            this.lblDep.TabIndex = 6;
            this.lblDep.Text = "所属部门：";
            // 
            // txtNamePos
            // 
            this.txtNamePos.Location = new System.Drawing.Point(92, 36);
            this.txtNamePos.Name = "txtNamePos";
            this.txtNamePos.Size = new System.Drawing.Size(215, 21);
            this.txtNamePos.TabIndex = 8;
            // 
            // lblNameDep
            // 
            this.lblNameDep.Location = new System.Drawing.Point(26, 39);
            this.lblNameDep.Name = "lblNameDep";
            this.lblNameDep.Size = new System.Drawing.Size(60, 14);
            this.lblNameDep.TabIndex = 7;
            this.lblNameDep.Text = "职位名称：";
            // 
            // lupDep
            // 
            this.lupDep.Location = new System.Drawing.Point(92, 76);
            this.lupDep.Name = "lupDep";
            this.lupDep.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupDep.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "编号"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "名称")});
            this.lupDep.Properties.ValueMember = "ID";
            this.lupDep.Size = new System.Drawing.Size(218, 21);
            this.lupDep.TabIndex = 14;
            // 
            // txtPerson
            // 
            this.txtPerson.Location = new System.Drawing.Point(89, 182);
            this.txtPerson.Name = "txtPerson";
            this.txtPerson.Properties.ReadOnly = true;
            this.txtPerson.Size = new System.Drawing.Size(215, 21);
            this.txtPerson.TabIndex = 16;
            this.txtPerson.TabStop = false;
            // 
            // lblPerson
            // 
            this.lblPerson.Location = new System.Drawing.Point(26, 185);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(48, 14);
            this.lblPerson.TabIndex = 15;
            this.lblPerson.Text = "创建人：";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lblPerson);
            this.groupControl1.Controls.Add(this.txtPerson);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.medDescription);
            this.groupControl1.Controls.Add(this.lblNameDep);
            this.groupControl1.Controls.Add(this.txtNamePos);
            this.groupControl1.Controls.Add(this.lblDate);
            this.groupControl1.Controls.Add(this.lupDep);
            this.groupControl1.Controls.Add(this.lblDep);
            this.groupControl1.Controls.Add(this.txtDate);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(326, 269);
            this.groupControl1.TabIndex = 17;
            this.groupControl1.Text = "信息";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnOK);
            this.groupControl2.Controls.Add(this.btnCancle);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl2.Location = new System.Drawing.Point(329, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(113, 269);
            this.groupControl2.TabIndex = 18;
            this.groupControl2.Text = "操作";
            // 
            // frmAddPosition
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancle;
            this.ClientSize = new System.Drawing.Size(442, 269);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAddPosition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加新职位";
            this.Load += new System.EventHandler(this.frmAddPosition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamePos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupDep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCancle;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.MemoEdit medDescription;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtDate;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraEditors.LabelControl lblDep;
        private DevExpress.XtraEditors.TextEdit txtNamePos;
        private DevExpress.XtraEditors.LabelControl lblNameDep;
        private DevExpress.XtraEditors.LookUpEdit lupDep;
        private DevExpress.XtraEditors.TextEdit txtPerson;
        private DevExpress.XtraEditors.LabelControl lblPerson;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
    }
}