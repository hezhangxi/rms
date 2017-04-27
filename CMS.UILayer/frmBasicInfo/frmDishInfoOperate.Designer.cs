namespace CMS.UILayer.frmBasicInfo
{
    partial class frmDishInfoOperate
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
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.SpinEditCost = new DevExpress.XtraEditors.SpinEdit();
            this.SpinEditPrice = new DevExpress.XtraEditors.SpinEdit();
            this.SpinEditCommission = new DevExpress.XtraEditors.SpinEdit();
            this.EditStockGoodsID = new DevExpress.XtraEditors.LookUpEdit();
            this.EditDishTypeID = new DevExpress.XtraEditors.LookUpEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.txtInfoNote = new DevExpress.XtraEditors.MemoEdit();
            this.lblStockGoodsID = new DevExpress.XtraEditors.LabelControl();
            this.lblDishType = new DevExpress.XtraEditors.LabelControl();
            this.txtDate = new DevExpress.XtraEditors.TextEdit();
            this.txtPerson = new DevExpress.XtraEditors.TextEdit();
            this.txtMeasuringUnit = new DevExpress.XtraEditors.TextEdit();
            this.txtMnemonicSymbol = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.lblPerson = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpinEditCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinEditPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinEditCommission.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditStockGoodsID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditDishTypeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInfoNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMeasuringUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMnemonicSymbol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnCancel);
            this.groupControl2.Controls.Add(this.btnBack);
            this.groupControl2.Controls.Add(this.btnSave);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl2.Location = new System.Drawing.Point(446, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(134, 379);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "操作区";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCancel.Location = new System.Drawing.Point(26, 166);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 31);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.ToolTip = "取消数据操作(Alt+C)";
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(28, 278);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 31);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "返回(&B)";
            this.btnBack.ToolTip = "返回主界面(Alt+B/Esc)";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(26, 54);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 31);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.ToolTip = "保存用户信息(Alt+S/Enter)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.SpinEditCost);
            this.groupControl1.Controls.Add(this.SpinEditPrice);
            this.groupControl1.Controls.Add(this.SpinEditCommission);
            this.groupControl1.Controls.Add(this.EditStockGoodsID);
            this.groupControl1.Controls.Add(this.EditDishTypeID);
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.lblStockGoodsID);
            this.groupControl1.Controls.Add(this.lblDishType);
            this.groupControl1.Controls.Add(this.txtDate);
            this.groupControl1.Controls.Add(this.txtPerson);
            this.groupControl1.Controls.Add(this.txtMeasuringUnit);
            this.groupControl1.Controls.Add(this.txtMnemonicSymbol);
            this.groupControl1.Controls.Add(this.txtName);
            this.groupControl1.Controls.Add(this.lblDate);
            this.groupControl1.Controls.Add(this.lblPerson);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(446, 379);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "信息显示区 ";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // SpinEditCost
            // 
            this.SpinEditCost.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SpinEditCost.Location = new System.Drawing.Point(63, 153);
            this.SpinEditCost.Name = "SpinEditCost";
            this.SpinEditCost.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.SpinEditCost.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.SpinEditCost.Size = new System.Drawing.Size(69, 21);
            this.SpinEditCost.TabIndex = 4;
            // 
            // SpinEditPrice
            // 
            this.SpinEditPrice.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SpinEditPrice.Location = new System.Drawing.Point(206, 153);
            this.SpinEditPrice.Name = "SpinEditPrice";
            this.SpinEditPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.SpinEditPrice.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.SpinEditPrice.Size = new System.Drawing.Size(63, 21);
            this.SpinEditPrice.TabIndex = 5;
            // 
            // SpinEditCommission
            // 
            this.SpinEditCommission.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SpinEditCommission.Location = new System.Drawing.Point(357, 153);
            this.SpinEditCommission.Name = "SpinEditCommission";
            this.SpinEditCommission.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.SpinEditCommission.Properties.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.SpinEditCommission.Properties.MaxValue = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.SpinEditCommission.Size = new System.Drawing.Size(64, 21);
            this.SpinEditCommission.TabIndex = 6;
            // 
            // EditStockGoodsID
            // 
            this.EditStockGoodsID.AllowDrop = true;
            this.EditStockGoodsID.Location = new System.Drawing.Point(87, 191);
            this.EditStockGoodsID.Name = "EditStockGoodsID";
            this.EditStockGoodsID.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.EditStockGoodsID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EditStockGoodsID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "关联商品名称", 78, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Specifications", "计量单位", 58, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", "单价"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Number", "数量")});
            this.EditStockGoodsID.Properties.DisplayMember = "Name";
            this.EditStockGoodsID.Properties.ValueMember = "ID";
            this.EditStockGoodsID.Size = new System.Drawing.Size(334, 21);
            this.EditStockGoodsID.TabIndex = 7;
            // 
            // EditDishTypeID
            // 
            this.EditDishTypeID.AllowDrop = true;
            this.EditDishTypeID.Location = new System.Drawing.Point(87, 77);
            this.EditDishTypeID.Name = "EditDishTypeID";
            this.EditDishTypeID.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.EditDishTypeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EditDishTypeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 41, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.EditDishTypeID.Properties.DisplayMember = "Name";
            this.EditDishTypeID.Properties.ValueMember = "ID";
            this.EditDishTypeID.Size = new System.Drawing.Size(334, 21);
            this.EditDishTypeID.TabIndex = 1;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.txtInfoNote);
            this.groupControl3.Location = new System.Drawing.Point(21, 224);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(402, 85);
            this.groupControl3.TabIndex = 13;
            this.groupControl3.Text = "信息备注";
            // 
            // txtInfoNote
            // 
            this.txtInfoNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInfoNote.EditValue = "暂无";
            this.txtInfoNote.Location = new System.Drawing.Point(2, 23);
            this.txtInfoNote.Name = "txtInfoNote";
            this.txtInfoNote.Size = new System.Drawing.Size(398, 60);
            this.txtInfoNote.TabIndex = 0;
            // 
            // lblStockGoodsID
            // 
            this.lblStockGoodsID.Location = new System.Drawing.Point(21, 194);
            this.lblStockGoodsID.Name = "lblStockGoodsID";
            this.lblStockGoodsID.Size = new System.Drawing.Size(60, 14);
            this.lblStockGoodsID.TabIndex = 3;
            this.lblStockGoodsID.Text = "关联商品：";
            // 
            // lblDishType
            // 
            this.lblDishType.Location = new System.Drawing.Point(21, 80);
            this.lblDishType.Name = "lblDishType";
            this.lblDishType.Size = new System.Drawing.Size(60, 14);
            this.lblDishType.TabIndex = 3;
            this.lblDishType.Text = "所属类别：";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(275, 324);
            this.txtDate.Name = "txtDate";
            this.txtDate.Properties.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(148, 21);
            this.txtDate.TabIndex = 1;
            // 
            // txtPerson
            // 
            this.txtPerson.Location = new System.Drawing.Point(77, 324);
            this.txtPerson.Name = "txtPerson";
            this.txtPerson.Properties.ReadOnly = true;
            this.txtPerson.Size = new System.Drawing.Size(104, 21);
            this.txtPerson.TabIndex = 1;
            // 
            // txtMeasuringUnit
            // 
            this.txtMeasuringUnit.Location = new System.Drawing.Point(357, 115);
            this.txtMeasuringUnit.Name = "txtMeasuringUnit";
            this.txtMeasuringUnit.Size = new System.Drawing.Size(64, 21);
            this.txtMeasuringUnit.TabIndex = 3;
            // 
            // txtMnemonicSymbol
            // 
            this.txtMnemonicSymbol.Location = new System.Drawing.Point(87, 115);
            this.txtMnemonicSymbol.Name = "txtMnemonicSymbol";
            this.txtMnemonicSymbol.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtMnemonicSymbol.Size = new System.Drawing.Size(136, 21);
            this.txtMnemonicSymbol.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(87, 39);
            this.txtName.Name = "txtName";
            this.txtName.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtName.Size = new System.Drawing.Size(334, 21);
            this.txtName.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(209, 327);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(60, 14);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "创建时间：";
            // 
            // lblPerson
            // 
            this.lblPerson.Location = new System.Drawing.Point(23, 327);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(48, 14);
            this.lblPerson.TabIndex = 0;
            this.lblPerson.Text = "创建人：";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(315, 157);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(36, 14);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "提成：";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(164, 158);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(36, 14);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "售价：";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(21, 156);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(36, 14);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "成本：";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(315, 118);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 14);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "单位：";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(21, 118);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(56, 14);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "助 记 符：";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(21, 42);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "菜品名称：";
            // 
            // frmDishInfoOperate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 379);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Name = "frmDishInfoOperate";
            this.Text = "菜品信息操作";
            this.Load += new System.EventHandler(this.frmDishInfoOperate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpinEditCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinEditPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinEditCommission.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditStockGoodsID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditDishTypeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtInfoNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMeasuringUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMnemonicSymbol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LookUpEdit EditStockGoodsID;
        private DevExpress.XtraEditors.LookUpEdit EditDishTypeID;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.MemoEdit txtInfoNote;
        private DevExpress.XtraEditors.LabelControl lblStockGoodsID;
        private DevExpress.XtraEditors.LabelControl lblDishType;
        private DevExpress.XtraEditors.TextEdit txtDate;
        private DevExpress.XtraEditors.TextEdit txtPerson;
        private DevExpress.XtraEditors.TextEdit txtMeasuringUnit;
        private DevExpress.XtraEditors.TextEdit txtMnemonicSymbol;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraEditors.LabelControl lblPerson;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SpinEdit SpinEditCommission;
        private DevExpress.XtraEditors.SpinEdit SpinEditCost;
        private DevExpress.XtraEditors.SpinEdit SpinEditPrice;
    }
}