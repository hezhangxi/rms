namespace CMS.UILayer.frmWarehouse
{
    partial class frmDetaileStock
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
            this.components = new System.ComponentModel.Container();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnEnter = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPrice = new DevExpress.XtraEditors.SpinEdit();
            this.txtNumber = new DevExpress.XtraEditors.SpinEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.toolTip = new DevExpress.Utils.ToolTipController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(133, 121);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "返回(&B)";
            this.btnCancel.ToolTip = "返回系统主界面(Alt+B/Esc)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(21, 121);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "确定(&O)";
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(21, 85);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 14);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "商品单价：";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(21, 50);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "商品数量：";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(21, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "商品名称：";
            // 
            // txtPrice
            // 
            this.txtPrice.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txtPrice.Location = new System.Drawing.Point(87, 78);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtPrice.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtPrice.Properties.Appearance.Options.UseForeColor = true;
            this.txtPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtPrice.Properties.DisplayFormat.FormatString = "{0}元";
            this.txtPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPrice.Properties.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txtPrice.Properties.MaxValue = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.txtPrice.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txtPrice.Size = new System.Drawing.Size(121, 21);
            this.txtPrice.TabIndex = 1;
            // 
            // txtNumber
            // 
            this.txtNumber.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNumber.Location = new System.Drawing.Point(87, 47);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtNumber.Properties.MaxValue = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.txtNumber.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNumber.Size = new System.Drawing.Size(121, 21);
            this.txtNumber.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(87, 14);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 21);
            this.txtName.TabIndex = 4;
            this.txtName.TabStop = false;
            // 
            // frmDetaileStock
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(231, 156);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDetaileStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "采购商品详细信息";
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnEnter;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SpinEdit txtPrice;
        private DevExpress.XtraEditors.SpinEdit txtNumber;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.Utils.ToolTipController toolTip;
    }
}