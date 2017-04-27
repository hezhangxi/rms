namespace CMS.UILayer.frmSysSet
{
    partial class frmUserAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserAdd));
            this.groupControlOperator = new DevExpress.XtraEditors.GroupControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtUserPwd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lblPerson = new DevExpress.XtraEditors.LabelControl();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.txtRePwd = new DevExpress.XtraEditors.TextEdit();
            this.txtCreatePerson = new DevExpress.XtraEditors.TextEdit();
            this.txtCreateDate = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lookUpEditRight = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlOperator)).BeginInit();
            this.groupControlOperator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserPwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRePwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreatePerson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditRight.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlOperator
            // 
            this.groupControlOperator.Controls.Add(this.btnCancel);
            this.groupControlOperator.Controls.Add(this.btnBack);
            this.groupControlOperator.Controls.Add(this.btnSave);
            this.groupControlOperator.Location = new System.Drawing.Point(374, 12);
            this.groupControlOperator.Name = "groupControlOperator";
            this.groupControlOperator.Size = new System.Drawing.Size(107, 285);
            this.groupControlOperator.TabIndex = 1;
            this.groupControlOperator.Text = "信息操作";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(15, 129);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.ToolTip = "取消数据操作(Alt+C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(15, 208);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 30);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "返回(&B)";
            this.btnBack.ToolTip = "返回主界面(&Alt+B/Esc)";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 50);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.ToolTip = "保存用户信息(Alt+S/Enter)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "用户名称：";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(90, 37);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(218, 21);
            this.txtUserName.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(24, 81);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "用户权限：";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(24, 122);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 14);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "用户密码：";
            // 
            // txtUserPwd
            // 
            this.txtUserPwd.Location = new System.Drawing.Point(90, 119);
            this.txtUserPwd.Name = "txtUserPwd";
            this.txtUserPwd.Properties.PasswordChar = '*';
            this.txtUserPwd.Size = new System.Drawing.Size(218, 21);
            this.txtUserPwd.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(24, 163);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 14);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "重复密码：";
            // 
            // lblPerson
            // 
            this.lblPerson.Location = new System.Drawing.Point(24, 204);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(48, 14);
            this.lblPerson.TabIndex = 0;
            this.lblPerson.Text = "创建人：";
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(24, 245);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(60, 14);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "创建时间：";
            // 
            // txtRePwd
            // 
            this.txtRePwd.Location = new System.Drawing.Point(90, 160);
            this.txtRePwd.Name = "txtRePwd";
            this.txtRePwd.Properties.PasswordChar = '*';
            this.txtRePwd.Size = new System.Drawing.Size(218, 21);
            this.txtRePwd.TabIndex = 3;
            // 
            // txtCreatePerson
            // 
            this.txtCreatePerson.Location = new System.Drawing.Point(90, 201);
            this.txtCreatePerson.Name = "txtCreatePerson";
            this.txtCreatePerson.Properties.ReadOnly = true;
            this.txtCreatePerson.Size = new System.Drawing.Size(218, 21);
            this.txtCreatePerson.TabIndex = 4;
            this.txtCreatePerson.TabStop = false;
            // 
            // txtCreateDate
            // 
            this.txtCreateDate.Location = new System.Drawing.Point(90, 242);
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.Properties.ReadOnly = true;
            this.txtCreateDate.Size = new System.Drawing.Size(218, 21);
            this.txtCreateDate.TabIndex = 5;
            this.txtCreateDate.TabStop = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lookUpEditRight);
            this.groupControl1.Controls.Add(this.txtCreateDate);
            this.groupControl1.Controls.Add(this.txtCreatePerson);
            this.groupControl1.Controls.Add(this.txtRePwd);
            this.groupControl1.Controls.Add(this.lblDate);
            this.groupControl1.Controls.Add(this.lblPerson);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtUserPwd);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtUserName);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(339, 285);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "用户信息";
            // 
            // lookUpEditRight
            // 
            this.lookUpEditRight.Location = new System.Drawing.Point(90, 79);
            this.lookUpEditRight.Name = "lookUpEditRight";
            this.lookUpEditRight.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditRight.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductName", 100, "Product Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QuantityPerUnit", 50, "Quantity Per Unit"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UnitPrice", "Unit Price", 30, DevExpress.Utils.FormatType.Numeric, "c", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Discontinued", "Discontinued", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center)});
            this.lookUpEditRight.Properties.DropDownRows = 10;
            this.lookUpEditRight.Size = new System.Drawing.Size(218, 21);
            this.lookUpEditRight.TabIndex = 6;
            // 
            // frmUserAdd
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(503, 313);
            this.Controls.Add(this.groupControlOperator);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmUserAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新添用户信息";
            this.Load += new System.EventHandler(this.frmUserAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlOperator)).EndInit();
            this.groupControlOperator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserPwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRePwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreatePerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditRight.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlOperator;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtUserPwd;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lblPerson;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraEditors.TextEdit txtRePwd;
        private DevExpress.XtraEditors.TextEdit txtCreatePerson;
        private DevExpress.XtraEditors.TextEdit txtCreateDate;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditRight;
    }
}