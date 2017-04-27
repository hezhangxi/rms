namespace CMS.UILayer.frmFinance
{
    partial class frmFinanceRegisterOperate
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
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.txtInfoNote = new DevExpress.XtraEditors.MemoEdit();
            this.EditHandlePeopleID = new DevExpress.XtraEditors.LookUpEdit();
            this.EditItemID = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtDate = new DevExpress.XtraEditors.TextEdit();
            this.txtPerson = new DevExpress.XtraEditors.TextEdit();
            this.txtAmount = new DevExpress.XtraEditors.TextEdit();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.lblPerson = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInfoNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditHandlePeopleID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditItemID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnBack);
            this.groupControl2.Controls.Add(this.btnSave);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl2.Location = new System.Drawing.Point(332, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(117, 293);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "操作区";
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(22, 108);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(64, 30);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "返回(&B)";
            this.btnBack.ToolTip = "返回主界面(Alt+B/Esc)";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(22, 38);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 30);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.ToolTip = "保存用户信息(Alt+S/Enter)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.EditHandlePeopleID);
            this.groupControl1.Controls.Add(this.EditItemID);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtDate);
            this.groupControl1.Controls.Add(this.txtPerson);
            this.groupControl1.Controls.Add(this.txtAmount);
            this.groupControl1.Controls.Add(this.lblDate);
            this.groupControl1.Controls.Add(this.lblPerson);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(331, 293);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "信息显示区 ";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.txtInfoNote);
            this.groupControl3.Location = new System.Drawing.Point(26, 173);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(284, 64);
            this.groupControl3.TabIndex = 24;
            this.groupControl3.Text = "信息备注";
            // 
            // txtInfoNote
            // 
            this.txtInfoNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInfoNote.Location = new System.Drawing.Point(2, 23);
            this.txtInfoNote.Name = "txtInfoNote";
            this.txtInfoNote.Size = new System.Drawing.Size(280, 39);
            this.txtInfoNote.TabIndex = 2;
            // 
            // EditHandlePeopleID
            // 
            this.EditHandlePeopleID.Location = new System.Drawing.Point(90, 70);
            this.EditHandlePeopleID.Name = "EditHandlePeopleID";
            this.EditHandlePeopleID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EditHandlePeopleID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "经手人", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.EditHandlePeopleID.Properties.DisplayMember = "Name";
            this.EditHandlePeopleID.Properties.ShowHeader = false;
            this.EditHandlePeopleID.Properties.ValueMember = "ID";
            this.EditHandlePeopleID.Size = new System.Drawing.Size(218, 21);
            this.EditHandlePeopleID.TabIndex = 23;
            this.EditHandlePeopleID.EditValueChanged += new System.EventHandler(this.EditItemID_EditValueChanged);
            // 
            // EditItemID
            // 
            this.EditItemID.Location = new System.Drawing.Point(90, 35);
            this.EditItemID.Name = "EditItemID";
            this.EditItemID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EditItemID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "收支项目名称", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.EditItemID.Properties.DisplayMember = "Name";
            this.EditItemID.Properties.ShowHeader = false;
            this.EditItemID.Properties.ValueMember = "ID";
            this.EditItemID.Size = new System.Drawing.Size(218, 21);
            this.EditItemID.TabIndex = 23;
            this.EditItemID.EditValueChanged += new System.EventHandler(this.EditItemID_EditValueChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(26, 73);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 14);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "经手人：";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(24, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "收支项目：";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(26, 108);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(48, 14);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "金   额：";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(94, 250);
            this.txtDate.Name = "txtDate";
            this.txtDate.Properties.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(214, 21);
            this.txtDate.TabIndex = 1;
            // 
            // txtPerson
            // 
            this.txtPerson.Location = new System.Drawing.Point(92, 140);
            this.txtPerson.Name = "txtPerson";
            this.txtPerson.Properties.ReadOnly = true;
            this.txtPerson.Size = new System.Drawing.Size(218, 21);
            this.txtPerson.TabIndex = 1;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(92, 105);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtAmount.Properties.Mask.EditMask = "d";
            this.txtAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAmount.Properties.MaxLength = 12;
            this.txtAmount.Size = new System.Drawing.Size(218, 21);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.EditValueChanged += new System.EventHandler(this.txtAmount_EditValueChanged);
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(28, 253);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(60, 14);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "创建时间：";
            // 
            // lblPerson
            // 
            this.lblPerson.Location = new System.Drawing.Point(26, 143);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(56, 14);
            this.lblPerson.TabIndex = 0;
            this.lblPerson.Text = "创 建 人：";
            // 
            // frmFinanceRegisterOperate
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(449, 293);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmFinanceRegisterOperate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "财务记录操作";
            this.Load += new System.EventHandler(this.frmFinanceDetailOperate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtInfoNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditHandlePeopleID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditItemID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LookUpEdit EditItemID;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtDate;
        private DevExpress.XtraEditors.TextEdit txtPerson;
        private DevExpress.XtraEditors.TextEdit txtAmount;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraEditors.LabelControl lblPerson;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.MemoEdit txtInfoNote;
        private DevExpress.XtraEditors.LookUpEdit EditHandlePeopleID;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}