namespace CMS.UILayer.frmFinance
{
    partial class frmFinaceOperate
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
            this.cmbEditInOutType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.txtInfoNote = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDate = new DevExpress.XtraEditors.TextEdit();
            this.txtPerson = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.lblPerson = new DevExpress.XtraEditors.LabelControl();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEditInOutType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInfoNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnBack);
            this.groupControl2.Controls.Add(this.btnSave);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl2.Location = new System.Drawing.Point(322, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(119, 253);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "操作区";
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(20, 116);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(74, 30);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "返回(&B)";
            this.btnBack.ToolTip = "返回主界面(Alt+B/Esc)";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(20, 37);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 30);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.ToolTip = "保存用户信息(Alt+S/Enter)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cmbEditInOutType);
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtDate);
            this.groupControl1.Controls.Add(this.txtPerson);
            this.groupControl1.Controls.Add(this.txtName);
            this.groupControl1.Controls.Add(this.lblDate);
            this.groupControl1.Controls.Add(this.lblPerson);
            this.groupControl1.Controls.Add(this.lblName);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(322, 253);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "信息显示区 ";
            // 
            // cmbEditInOutType
            // 
            this.cmbEditInOutType.Location = new System.Drawing.Point(84, 65);
            this.cmbEditInOutType.Name = "cmbEditInOutType";
            this.cmbEditInOutType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cmbEditInOutType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEditInOutType.Properties.Items.AddRange(new object[] {
            "收入",
            "支出"});
            this.cmbEditInOutType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbEditInOutType.Size = new System.Drawing.Size(218, 21);
            this.cmbEditInOutType.TabIndex = 23;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.txtInfoNote);
            this.groupControl3.Location = new System.Drawing.Point(24, 103);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(278, 64);
            this.groupControl3.TabIndex = 13;
            this.groupControl3.Text = "信息备注";
            // 
            // txtInfoNote
            // 
            this.txtInfoNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInfoNote.EditValue = "暂无";
            this.txtInfoNote.Location = new System.Drawing.Point(2, 23);
            this.txtInfoNote.Name = "txtInfoNote";
            this.txtInfoNote.Size = new System.Drawing.Size(274, 39);
            this.txtInfoNote.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 68);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "收支类型：";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(83, 218);
            this.txtDate.Name = "txtDate";
            this.txtDate.Properties.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(217, 21);
            this.txtDate.TabIndex = 1;
            // 
            // txtPerson
            // 
            this.txtPerson.Location = new System.Drawing.Point(84, 183);
            this.txtPerson.Name = "txtPerson";
            this.txtPerson.Properties.ReadOnly = true;
            this.txtPerson.Size = new System.Drawing.Size(216, 21);
            this.txtPerson.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(84, 34);
            this.txtName.Name = "txtName";
            this.txtName.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtName.Size = new System.Drawing.Size(218, 21);
            this.txtName.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(26, 221);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(60, 14);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "创建时间：";
            // 
            // lblPerson
            // 
            this.lblPerson.Location = new System.Drawing.Point(26, 186);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(48, 14);
            this.lblPerson.TabIndex = 0;
            this.lblPerson.Text = "创建人：";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(24, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 14);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "收支名称：";
            // 
            // frmFinaceOperate
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(441, 253);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmFinaceOperate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "收支项目操作";
            this.Load += new System.EventHandler(this.frmFinaceOperate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEditInOutType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtInfoNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.MemoEdit txtInfoNote;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtDate;
        private DevExpress.XtraEditors.TextEdit txtPerson;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraEditors.LabelControl lblPerson;
        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraEditors.ComboBoxEdit cmbEditInOutType;

    }
}