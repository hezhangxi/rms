namespace CMS.UILayer.frmVIPClient
{
    partial class frmUpdateVIPCard
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtVIPName = new DevExpress.XtraEditors.TextEdit();
            this.txtModifyPerson = new DevExpress.XtraEditors.TextEdit();
            this.txtModifyDate = new DevExpress.XtraEditors.TextEdit();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.medDescription = new DevExpress.XtraEditors.MemoEdit();
            this.speDiscount = new DevExpress.XtraEditors.SpinEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtVIPName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModifyPerson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModifyDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(21, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "卡 名 称：";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(229, 22);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(28, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "折扣:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(21, 180);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 14);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "修改时间：";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(21, 143);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(56, 14);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "修 改 人：";
            // 
            // txtVIPName
            // 
            this.txtVIPName.Location = new System.Drawing.Point(83, 19);
            this.txtVIPName.Name = "txtVIPName";
            this.txtVIPName.Size = new System.Drawing.Size(118, 21);
            this.txtVIPName.TabIndex = 0;
            // 
            // txtModifyPerson
            // 
            this.txtModifyPerson.Location = new System.Drawing.Point(83, 140);
            this.txtModifyPerson.Name = "txtModifyPerson";
            this.txtModifyPerson.Properties.ReadOnly = true;
            this.txtModifyPerson.Size = new System.Drawing.Size(240, 21);
            this.txtModifyPerson.TabIndex = 7;
            this.txtModifyPerson.TabStop = false;
            // 
            // txtModifyDate
            // 
            this.txtModifyDate.Location = new System.Drawing.Point(83, 177);
            this.txtModifyDate.Name = "txtModifyDate";
            this.txtModifyDate.Properties.ReadOnly = true;
            this.txtModifyDate.Size = new System.Drawing.Size(238, 21);
            this.txtModifyDate.TabIndex = 1;
            this.txtModifyDate.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(21, 217);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(84, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.ToolTip = "确定添加新会员";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(239, 217);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "取消(&C)";
            this.btnExit.ToolTip = "取消添加并返回(&B)上级(Alt+C/Esc)";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // medDescription
            // 
            this.medDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.medDescription.EditValue = "暂无";
            this.medDescription.Location = new System.Drawing.Point(2, 23);
            this.medDescription.Name = "medDescription";
            this.medDescription.Size = new System.Drawing.Size(298, 42);
            this.medDescription.TabIndex = 2;
            // 
            // speDiscount
            // 
            this.speDiscount.EditValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.speDiscount.Location = new System.Drawing.Point(263, 19);
            this.speDiscount.Name = "speDiscount";
            this.speDiscount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.speDiscount.Properties.DisplayFormat.FormatString = "{0}折";
            this.speDiscount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.speDiscount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.speDiscount.Properties.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.speDiscount.Properties.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.speDiscount.Size = new System.Drawing.Size(60, 21);
            this.speDiscount.TabIndex = 8;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.medDescription);
            this.groupControl1.Location = new System.Drawing.Point(21, 59);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(302, 67);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "信息备注";
            // 
            // frmUpdateVIPCard
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(345, 262);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.speDiscount);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtModifyDate);
            this.Controls.Add(this.txtModifyPerson);
            this.Controls.Add(this.txtVIPName);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmUpdateVIPCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加会员卡类别";
            this.Load += new System.EventHandler(this.frmUpdateVIPCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtVIPName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModifyPerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModifyDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtVIPName;
        private DevExpress.XtraEditors.TextEdit txtModifyPerson;
        private DevExpress.XtraEditors.TextEdit txtModifyDate;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.MemoEdit medDescription;
        private DevExpress.XtraEditors.SpinEdit speDiscount;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}