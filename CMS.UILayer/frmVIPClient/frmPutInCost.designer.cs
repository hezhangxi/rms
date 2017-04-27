namespace CMS.UILayer.frmVIPClient
{
    partial class frmPutInCost
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
            this.txtVIPName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiscount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtVIPCost = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtDate = new DevExpress.XtraEditors.TextEdit();
            this.calCost = new DevExpress.XtraEditors.CalcEdit();
            this.txtVIPType = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVIPName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVIPCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVIPType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "会员姓名：";
            // 
            // txtVIPName
            // 
            this.txtVIPName.Location = new System.Drawing.Point(94, 15);
            this.txtVIPName.Name = "txtVIPName";
            this.txtVIPName.Properties.ReadOnly = true;
            this.txtVIPName.Size = new System.Drawing.Size(224, 21);
            this.txtVIPName.TabIndex = 1;
            this.txtVIPName.TabStop = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(24, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "会员卡类别：";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(229, 58);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 14);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "优惠：";
            // 
            // txtDiscount
            // 
            this.txtDiscount.EditValue = "";
            this.txtDiscount.Location = new System.Drawing.Point(263, 55);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Properties.DisplayFormat.FormatString = "{0}折";
            this.txtDiscount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDiscount.Properties.ReadOnly = true;
            this.txtDiscount.Size = new System.Drawing.Size(55, 21);
            this.txtDiscount.TabIndex = 1;
            this.txtDiscount.TabStop = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(24, 97);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 14);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "卡上余额：";
            // 
            // txtVIPCost
            // 
            this.txtVIPCost.Location = new System.Drawing.Point(94, 94);
            this.txtVIPCost.Name = "txtVIPCost";
            this.txtVIPCost.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtVIPCost.Properties.Appearance.Options.UseBackColor = true;
            this.txtVIPCost.Properties.ReadOnly = true;
            this.txtVIPCost.Size = new System.Drawing.Size(68, 21);
            this.txtVIPCost.TabIndex = 1;
            this.txtVIPCost.TabStop = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(186, 97);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 14);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "充值金额：";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(24, 170);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(72, 25);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.ToolTip = "确定充值(Alt+O/Enter)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(244, 170);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 25);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "取消(&C)";
            this.btnExit.ToolTip = "取消充值并返回(&B)上一级(Alt+C/Esc)";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(24, 136);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(60, 14);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "充值时间：";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(94, 133);
            this.txtDate.Name = "txtDate";
            this.txtDate.Properties.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(224, 21);
            this.txtDate.TabIndex = 1;
            this.txtDate.TabStop = false;
            // 
            // calCost
            // 
            this.calCost.Location = new System.Drawing.Point(244, 94);
            this.calCost.Name = "calCost";
            this.calCost.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.calCost.Properties.Appearance.Options.UseBackColor = true;
            this.calCost.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calCost.Properties.DisplayFormat.FormatString = "c";
            this.calCost.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calCost.Properties.EditFormat.FormatString = "c";
            this.calCost.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calCost.Size = new System.Drawing.Size(74, 21);
            this.calCost.TabIndex = 0;
            // 
            // txtVIPType
            // 
            this.txtVIPType.Location = new System.Drawing.Point(94, 55);
            this.txtVIPType.Name = "txtVIPType";
            this.txtVIPType.Properties.ReadOnly = true;
            this.txtVIPType.Size = new System.Drawing.Size(100, 21);
            this.txtVIPType.TabIndex = 4;
            this.txtVIPType.TabStop = false;
            // 
            // frmPutInCost
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(340, 219);
            this.Controls.Add(this.txtVIPType);
            this.Controls.Add(this.calCost);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtVIPCost);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtVIPName);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPutInCost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "会员充值";
            ((System.ComponentModel.ISupportInitialize)(this.txtVIPName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVIPCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVIPType.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtVIPName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtDiscount;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtVIPCost;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtDate;
        private DevExpress.XtraEditors.CalcEdit calCost;
        private DevExpress.XtraEditors.TextEdit txtVIPType;
    }
}