namespace CMS.UILayer.frmVIPClient
{
    partial class frmRegisterClient
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
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.medInfoNote = new DevExpress.XtraEditors.MemoEdit();
            this.txtCreateDate = new DevExpress.XtraEditors.TextEdit();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.txtDepName = new DevExpress.XtraEditors.TextEdit();
            this.txtCreatePerson = new DevExpress.XtraEditors.TextEdit();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.lblPerson = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtClientName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lupVIPType = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblCost = new DevExpress.XtraEditors.LabelControl();
            this.calCost = new DevExpress.XtraEditors.CalcEdit();
            this.cmbSex = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbPosition = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.medInfoNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreatePerson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClientName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupVIPType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPosition.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(334, 315);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "重置(&R)";
            this.btnExit.ToolTip = "重置客户信息(Alt+R/Esc)";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(26, 315);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(76, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.ToolTip = "确定等级新客户(Alt+O/Enter)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // medInfoNote
            // 
            this.medInfoNote.EditValue = "暂无";
            this.medInfoNote.Location = new System.Drawing.Point(84, 259);
            this.medInfoNote.Name = "medInfoNote";
            this.medInfoNote.Size = new System.Drawing.Size(330, 41);
            this.medInfoNote.TabIndex = 8;
            // 
            // txtCreateDate
            // 
            this.txtCreateDate.Location = new System.Drawing.Point(290, 218);
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.Properties.ReadOnly = true;
            this.txtCreateDate.Size = new System.Drawing.Size(126, 21);
            this.txtCreateDate.TabIndex = 25;
            this.txtCreateDate.TabStop = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(84, 178);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(330, 21);
            this.txtAddress.TabIndex = 7;
            // 
            // txtDepName
            // 
            this.txtDepName.Location = new System.Drawing.Point(307, 138);
            this.txtDepName.Name = "txtDepName";
            this.txtDepName.Size = new System.Drawing.Size(109, 21);
            this.txtDepName.TabIndex = 6;
            // 
            // txtCreatePerson
            // 
            this.txtCreatePerson.Location = new System.Drawing.Point(84, 218);
            this.txtCreatePerson.Name = "txtCreatePerson";
            this.txtCreatePerson.Properties.ReadOnly = true;
            this.txtCreatePerson.Size = new System.Drawing.Size(128, 21);
            this.txtCreatePerson.TabIndex = 26;
            this.txtCreatePerson.TabStop = false;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(84, 138);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Properties.Mask.EditMask = "(\\d?\\d?\\d?)\\d\\d\\d-\\d\\d\\d\\d";
            this.txtPhone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtPhone.Size = new System.Drawing.Size(128, 21);
            this.txtPhone.TabIndex = 5;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(26, 261);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(52, 14);
            this.labelControl13.TabIndex = 12;
            this.labelControl13.Text = "备      注:";
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(232, 221);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(52, 14);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "创建时间:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(26, 181);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(52, 14);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "地      址:";
            // 
            // lblPerson
            // 
            this.lblPerson.Location = new System.Drawing.Point(26, 221);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(48, 14);
            this.lblPerson.TabIndex = 8;
            this.lblPerson.Text = "创 建 人:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(249, 141);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(52, 14);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "单位名称:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(26, 141);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(52, 14);
            this.labelControl7.TabIndex = 17;
            this.labelControl7.Text = "电      话:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(26, 101);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(52, 14);
            this.labelControl5.TabIndex = 19;
            this.labelControl5.Text = "职      位:";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(86, 18);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(128, 21);
            this.txtClientName.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(249, 21);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 14);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "性      别:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(26, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 14);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "客户姓名:";
            // 
            // lupVIPType
            // 
            this.lupVIPType.Location = new System.Drawing.Point(86, 58);
            this.lupVIPType.Name = "lupVIPType";
            this.lupVIPType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupVIPType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "编号"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "名称"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Discount", "折扣")});
            this.lupVIPType.Properties.ValueMember = "ID";
            this.lupVIPType.Size = new System.Drawing.Size(330, 21);
            this.lupVIPType.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(26, 61);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 14);
            this.labelControl3.TabIndex = 38;
            this.labelControl3.Text = "享受优惠:";
            // 
            // lblCost
            // 
            this.lblCost.Location = new System.Drawing.Point(249, 101);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(52, 14);
            this.lblCost.TabIndex = 39;
            this.lblCost.Text = "充值金额:";
            // 
            // calCost
            // 
            this.calCost.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            65536});
            this.calCost.Location = new System.Drawing.Point(307, 98);
            this.calCost.Name = "calCost";
            this.calCost.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.calCost.Properties.Appearance.Options.UseForeColor = true;
            this.calCost.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calCost.Properties.DisplayFormat.FormatString = "c";
            this.calCost.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calCost.Properties.EditFormat.FormatString = "c";
            this.calCost.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calCost.Size = new System.Drawing.Size(109, 21);
            this.calCost.TabIndex = 4;
            // 
            // cmbSex
            // 
            this.cmbSex.EditValue = "男";
            this.cmbSex.Location = new System.Drawing.Point(307, 18);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSex.Properties.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cmbSex.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbSex.Size = new System.Drawing.Size(109, 21);
            this.cmbSex.TabIndex = 1;
            // 
            // cmbPosition
            // 
            this.cmbPosition.EditValue = "程序员";
            this.cmbPosition.Location = new System.Drawing.Point(86, 98);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPosition.Properties.Items.AddRange(new object[] {
            "程序员",
            "工程师",
            "学生",
            "教师",
            "工人",
            "律师",
            "医生",
            "其它"});
            this.cmbPosition.Size = new System.Drawing.Size(128, 21);
            this.cmbPosition.TabIndex = 40;
            // 
            // frmRegisterClient
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(441, 355);
            this.Controls.Add(this.cmbPosition);
            this.Controls.Add(this.cmbSex);
            this.Controls.Add(this.calCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lupVIPType);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.medInfoNote);
            this.Controls.Add(this.txtCreateDate);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtDepName);
            this.Controls.Add(this.txtCreatePerson);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.lblPerson);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.Name = "frmRegisterClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登记新客户";
            this.Load += new System.EventHandler(this.frmRegisterClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medInfoNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreatePerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClientName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupVIPType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPosition.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.MemoEdit medInfoNote;
        private DevExpress.XtraEditors.TextEdit txtCreateDate;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.TextEdit txtDepName;
        private DevExpress.XtraEditors.TextEdit txtCreatePerson;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl lblPerson;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtClientName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lupVIPType;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblCost;
        private DevExpress.XtraEditors.CalcEdit calCost;
        private DevExpress.XtraEditors.ComboBoxEdit cmbSex;
        private DevExpress.XtraEditors.ComboBoxEdit cmbPosition;
    }
}