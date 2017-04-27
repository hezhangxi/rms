namespace CMS.UILayer.frmBasicInfo
{
    partial class frmPublicOperateArea
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.txtCreateDate = new DevExpress.XtraEditors.TextEdit();
            this.txtCreatePerson = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.lblPerson = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreatePerson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtDescription);
            this.groupControl1.Controls.Add(this.txtCreateDate);
            this.groupControl1.Controls.Add(this.txtCreatePerson);
            this.groupControl1.Controls.Add(this.txtName);
            this.groupControl1.Controls.Add(this.lblDate);
            this.groupControl1.Controls.Add(this.lblPerson);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(276, 273);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "信息";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(77, 79);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(183, 56);
            this.txtDescription.TabIndex = 2;
            // 
            // txtCreateDate
            // 
            this.txtCreateDate.Location = new System.Drawing.Point(77, 210);
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.Properties.ReadOnly = true;
            this.txtCreateDate.Size = new System.Drawing.Size(183, 21);
            this.txtCreateDate.TabIndex = 1;
            // 
            // txtCreatePerson
            // 
            this.txtCreatePerson.Location = new System.Drawing.Point(77, 158);
            this.txtCreatePerson.Name = "txtCreatePerson";
            this.txtCreatePerson.Properties.ReadOnly = true;
            this.txtCreatePerson.Size = new System.Drawing.Size(183, 21);
            this.txtCreatePerson.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(77, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(183, 21);
            this.txtName.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(16, 213);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(60, 14);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "创建时间：";
            // 
            // lblPerson
            // 
            this.lblPerson.Location = new System.Drawing.Point(16, 161);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(48, 14);
            this.lblPerson.TabIndex = 0;
            this.lblPerson.Text = "创建人：";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 81);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 14);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "描述：";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "名称：";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnCancel);
            this.groupControl2.Controls.Add(this.btnBack);
            this.groupControl2.Controls.Add(this.btnSave);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl2.Location = new System.Drawing.Point(277, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(119, 273);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "操作";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(21, 105);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.ToolTip = "取消数据操作(Alt+C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(21, 179);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 30);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "返回(&B)";
            this.btnBack.ToolTip = "返回系统主界面(Alt+B/Esc)";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(21, 36);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.ToolTip = "保存用户信息(Alt+S/Enter)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmPublicOperateArea
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(396, 273);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPublicOperateArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "信息添加";
            this.Load += new System.EventHandler(this.frmPublicOperateArea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreatePerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private DevExpress.XtraEditors.TextEdit txtCreateDate;
        private DevExpress.XtraEditors.TextEdit txtCreatePerson;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraEditors.LabelControl lblPerson;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}