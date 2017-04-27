namespace CMS.UILayer.frmBCarryOut
{
    partial class frmBackResult
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
            this.lblIsPresent = new DevExpress.XtraEditors.LabelControl();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.lblPrice = new DevExpress.XtraEditors.LabelControl();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lupResult = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.speBackNum = new DevExpress.XtraEditors.SpinEdit();
            this.btnEditResult = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.lblAvaNum = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtInfoNote = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lupResult.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speBackNum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInfoNote.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lblIsPresent);
            this.groupControl1.Controls.Add(this.lblTotal);
            this.groupControl1.Controls.Add(this.lblPrice);
            this.groupControl1.Controls.Add(this.lblName);
            this.groupControl1.Controls.Add(this.lblID);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(369, 88);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "消费详情";
            // 
            // lblIsPresent
            // 
            this.lblIsPresent.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsPresent.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblIsPresent.Appearance.Options.UseFont = true;
            this.lblIsPresent.Appearance.Options.UseForeColor = true;
            this.lblIsPresent.Location = new System.Drawing.Point(301, 59);
            this.lblIsPresent.Name = "lblIsPresent";
            this.lblIsPresent.Size = new System.Drawing.Size(42, 17);
            this.lblIsPresent.TabIndex = 0;
            this.lblIsPresent.Text = "是赠菜";
            // 
            // lblTotal
            // 
            this.lblTotal.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Appearance.Options.UseForeColor = true;
            this.lblTotal.Location = new System.Drawing.Point(156, 61);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(60, 14);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "消费金额：";
            // 
            // lblPrice
            // 
            this.lblPrice.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblPrice.Appearance.Options.UseForeColor = true;
            this.lblPrice.Location = new System.Drawing.Point(16, 61);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(36, 14);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "单价：";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(156, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 14);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "消费项目：";
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(16, 32);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(60, 14);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "项目编号：";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(243, 100);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "可退菜数量：";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 134);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "退菜原因：";
            // 
            // lupResult
            // 
            this.lupResult.Location = new System.Drawing.Point(82, 131);
            this.lupResult.Name = "lupResult";
            this.lupResult.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupResult.Size = new System.Drawing.Size(261, 21);
            this.lupResult.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 100);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 14);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "退菜数量：";
            // 
            // speBackNum
            // 
            this.speBackNum.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speBackNum.Location = new System.Drawing.Point(82, 97);
            this.speBackNum.Name = "speBackNum";
            this.speBackNum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.speBackNum.Properties.MaxValue = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.speBackNum.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speBackNum.Size = new System.Drawing.Size(60, 21);
            this.speBackNum.TabIndex = 3;
            this.speBackNum.TextChanged += new System.EventHandler(this.speBackNum_TextChanged);
            // 
            // btnEditResult
            // 
            this.btnEditResult.Location = new System.Drawing.Point(137, 230);
            this.btnEditResult.Name = "btnEditResult";
            this.btnEditResult.Size = new System.Drawing.Size(84, 23);
            this.btnEditResult.TabIndex = 4;
            this.btnEditResult.Text = "编辑原因(&E)";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(16, 230);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(267, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblAvaNum
            // 
            this.lblAvaNum.Location = new System.Drawing.Point(321, 100);
            this.lblAvaNum.Name = "lblAvaNum";
            this.lblAvaNum.Size = new System.Drawing.Size(7, 14);
            this.lblAvaNum.TabIndex = 1;
            this.lblAvaNum.Text = "5";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(16, 171);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(60, 14);
            this.labelControl9.TabIndex = 1;
            this.labelControl9.Text = "退菜备注：";
            // 
            // txtInfoNote
            // 
            this.txtInfoNote.EditValue = "暂无";
            this.txtInfoNote.Location = new System.Drawing.Point(82, 169);
            this.txtInfoNote.Name = "txtInfoNote";
            this.txtInfoNote.Size = new System.Drawing.Size(261, 41);
            this.txtInfoNote.TabIndex = 5;
            // 
            // frmBackResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 272);
            this.Controls.Add(this.txtInfoNote);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnEditResult);
            this.Controls.Add(this.speBackNum);
            this.Controls.Add(this.lupResult);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lblAvaNum);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBackResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "退菜原因";
            this.Load += new System.EventHandler(this.frmBackResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lupResult.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speBackNum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInfoNote.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit lupResult;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SpinEdit speBackNum;
        private DevExpress.XtraEditors.SimpleButton btnEditResult;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraEditors.LabelControl lblID;
        private DevExpress.XtraEditors.LabelControl lblTotal;
        private DevExpress.XtraEditors.LabelControl lblPrice;
        private DevExpress.XtraEditors.LabelControl lblIsPresent;
        private DevExpress.XtraEditors.LabelControl lblAvaNum;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.MemoEdit txtInfoNote;
    }
}