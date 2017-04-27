namespace CMS.UILayer.frmWarehouse
{
    partial class frmInGoods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInGoods));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControlMain = new DevExpress.XtraEditors.GroupControl();
            this.gvInGoods = new DevExpress.XtraGrid.GridControl();
            this.gvAddInGoods = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GetName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GetSpecifications = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GetNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.GetPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.GetTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbSupplier = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtEmpName = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.txtInfoNote = new DevExpress.XtraEditors.TextEdit();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSelectGoods = new DevExpress.XtraEditors.SimpleButton();
            this.txtInDate = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labSerialNumber = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnOut = new DevExpress.XtraEditors.SimpleButton();
            this.btnSelect = new DevExpress.XtraEditors.SimpleButton();
            this.btnWarehouse = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlMain)).BeginInit();
            this.groupControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvInGoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAddInGoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInfoNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupControlMain);
            this.groupControl1.Controls.Add(this.cmbSupplier);
            this.groupControl1.Controls.Add(this.txtEmpName);
            this.groupControl1.Controls.Add(this.labelControl16);
            this.groupControl1.Controls.Add(this.txtInfoNote);
            this.groupControl1.Controls.Add(this.labelControl18);
            this.groupControl1.Controls.Add(this.labelControl19);
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(893, 503);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "采购入库";
            // 
            // groupControlMain
            // 
            this.groupControlMain.Controls.Add(this.gvInGoods);
            this.groupControlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControlMain.Location = new System.Drawing.Point(2, 75);
            this.groupControlMain.Name = "groupControlMain";
            this.groupControlMain.Size = new System.Drawing.Size(889, 340);
            this.groupControlMain.TabIndex = 25;
            this.groupControlMain.Text = "采购清单";
            // 
            // gvInGoods
            // 
            this.gvInGoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvInGoods.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gvInGoods.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gvInGoods.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gvInGoods.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gvInGoods.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gvInGoods.Location = new System.Drawing.Point(2, 23);
            this.gvInGoods.MainView = this.gvAddInGoods;
            this.gvInGoods.Name = "gvInGoods";
            this.gvInGoods.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1,
            this.repositoryItemSpinEdit2});
            this.gvInGoods.Size = new System.Drawing.Size(885, 315);
            this.gvInGoods.TabIndex = 1;
            this.gvInGoods.UseEmbeddedNavigator = true;
            this.gvInGoods.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAddInGoods});
            // 
            // gvAddInGoods
            // 
            this.gvAddInGoods.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GetName,
            this.GetSpecifications,
            this.GetNumber,
            this.GetPrice,
            this.GetTotal});
            this.gvAddInGoods.GridControl = this.gvInGoods;
            this.gvAddInGoods.Name = "gvAddInGoods";
            this.gvAddInGoods.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvAddInGoods.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvAddInGoods.OptionsBehavior.AutoExpandAllGroups = true;
            this.gvAddInGoods.OptionsBehavior.Editable = false;
            this.gvAddInGoods.OptionsPrint.EnableAppearanceOddRow = true;
            this.gvAddInGoods.OptionsPrint.ExpandAllDetails = true;
            this.gvAddInGoods.OptionsPrint.PrintDetails = true;
            this.gvAddInGoods.OptionsPrint.PrintFilterInfo = true;
            this.gvAddInGoods.OptionsPrint.PrintPreview = true;
            this.gvAddInGoods.OptionsPrint.UsePrintStyles = true;
            this.gvAddInGoods.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvAddInGoods.OptionsView.EnableAppearanceEvenRow = true;
            this.gvAddInGoods.OptionsView.ShowFooter = true;
            this.gvAddInGoods.OptionsView.ShowGroupPanel = false;
            // 
            // GetName
            // 
            this.GetName.Caption = "商品名称";
            this.GetName.FieldName = "GetName";
            this.GetName.Name = "GetName";
            this.GetName.SummaryItem.DisplayFormat = "列表中共有不同的商品：{0}件";
            this.GetName.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            this.GetName.ToolTip = "商品名称";
            this.GetName.Visible = true;
            this.GetName.VisibleIndex = 0;
            this.GetName.Width = 212;
            // 
            // GetSpecifications
            // 
            this.GetSpecifications.Caption = "商品单位";
            this.GetSpecifications.FieldName = "GetSpecifications";
            this.GetSpecifications.Name = "GetSpecifications";
            this.GetSpecifications.SummaryItem.DisplayFormat = "共有商品：{0}件";
            this.GetSpecifications.SummaryItem.FieldName = "GetNumber";
            this.GetSpecifications.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.GetSpecifications.ToolTip = "商品单位";
            this.GetSpecifications.Visible = true;
            this.GetSpecifications.VisibleIndex = 2;
            this.GetSpecifications.Width = 168;
            // 
            // GetNumber
            // 
            this.GetNumber.Caption = "商品数量";
            this.GetNumber.ColumnEdit = this.repositoryItemSpinEdit1;
            this.GetNumber.FieldName = "GetNumber";
            this.GetNumber.Name = "GetNumber";
            this.GetNumber.SummaryItem.DisplayFormat = "商品总金额：{0}元";
            this.GetNumber.SummaryItem.FieldName = "GetTotal";
            this.GetNumber.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.GetNumber.Visible = true;
            this.GetNumber.VisibleIndex = 1;
            this.GetNumber.Width = 118;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // GetPrice
            // 
            this.GetPrice.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GetPrice.AppearanceCell.Options.UseBackColor = true;
            this.GetPrice.Caption = "商品单价";
            this.GetPrice.ColumnEdit = this.repositoryItemSpinEdit2;
            this.GetPrice.DisplayFormat.FormatString = "c";
            this.GetPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GetPrice.FieldName = "GetPrice";
            this.GetPrice.Name = "GetPrice";
            this.GetPrice.Visible = true;
            this.GetPrice.VisibleIndex = 3;
            this.GetPrice.Width = 126;
            // 
            // repositoryItemSpinEdit2
            // 
            this.repositoryItemSpinEdit2.AutoHeight = false;
            this.repositoryItemSpinEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2";
            // 
            // GetTotal
            // 
            this.GetTotal.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GetTotal.AppearanceCell.Options.UseBackColor = true;
            this.GetTotal.Caption = "商品总价";
            this.GetTotal.DisplayFormat.FormatString = "c";
            this.GetTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GetTotal.FieldName = "GetTotal";
            this.GetTotal.Name = "GetTotal";
            this.GetTotal.Visible = true;
            this.GetTotal.VisibleIndex = 4;
            this.GetTotal.Width = 257;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.EditValue = "街口菜市场";
            this.cmbSupplier.Location = new System.Drawing.Point(79, 425);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cmbSupplier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSupplier.Properties.Items.AddRange(new object[] {
            "街口菜市场",
            "东平百货",
            "西南批发部",
            "哓哓菜市场"});
            this.cmbSupplier.Size = new System.Drawing.Size(147, 21);
            this.cmbSupplier.TabIndex = 24;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(366, 425);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtEmpName.Size = new System.Drawing.Size(349, 21);
            this.txtEmpName.TabIndex = 23;
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(288, 428);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(60, 14);
            this.labelControl16.TabIndex = 22;
            this.labelControl16.Text = "进货员工：";
            // 
            // txtInfoNote
            // 
            this.txtInfoNote.EditValue = "暂无";
            this.txtInfoNote.Location = new System.Drawing.Point(79, 458);
            this.txtInfoNote.Name = "txtInfoNote";
            this.txtInfoNote.Size = new System.Drawing.Size(636, 21);
            this.txtInfoNote.TabIndex = 21;
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(13, 461);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(60, 14);
            this.labelControl18.TabIndex = 18;
            this.labelControl18.Text = "采购备注：";
            // 
            // labelControl19
            // 
            this.labelControl19.Location = new System.Drawing.Point(13, 428);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(48, 14);
            this.labelControl19.TabIndex = 19;
            this.labelControl19.Text = "供应商：";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSelectGoods);
            this.panelControl1.Controls.Add(this.txtInDate);
            this.panelControl1.Controls.Add(this.labelControl14);
            this.panelControl1.Controls.Add(this.labSerialNumber);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 23);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(889, 52);
            this.panelControl1.TabIndex = 0;
            // 
            // btnSelectGoods
            // 
            this.btnSelectGoods.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectGoods.Image")));
            this.btnSelectGoods.Location = new System.Drawing.Point(789, 8);
            this.btnSelectGoods.Name = "btnSelectGoods";
            this.btnSelectGoods.Size = new System.Drawing.Size(90, 36);
            this.btnSelectGoods.TabIndex = 18;
            this.btnSelectGoods.Text = "选择物品";
            this.btnSelectGoods.Click += new System.EventHandler(this.btnSelectStock_Click);
            // 
            // txtInDate
            // 
            this.txtInDate.Enabled = false;
            this.txtInDate.Location = new System.Drawing.Point(298, 16);
            this.txtInDate.Name = "txtInDate";
            this.txtInDate.Size = new System.Drawing.Size(220, 21);
            this.txtInDate.TabIndex = 17;
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(232, 19);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(60, 14);
            this.labelControl14.TabIndex = 16;
            this.labelControl14.Text = "进货时间：";
            // 
            // labSerialNumber
            // 
            this.labSerialNumber.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSerialNumber.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labSerialNumber.Appearance.Options.UseFont = true;
            this.labSerialNumber.Appearance.Options.UseForeColor = true;
            this.labSerialNumber.Location = new System.Drawing.Point(77, 19);
            this.labSerialNumber.Name = "labSerialNumber";
            this.labSerialNumber.Size = new System.Drawing.Size(32, 14);
            this.labSerialNumber.TabIndex = 15;
            this.labSerialNumber.Text = "String";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(11, 19);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(60, 14);
            this.labelControl6.TabIndex = 14;
            this.labelControl6.Text = "货单编号：";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnOut);
            this.groupControl2.Controls.Add(this.btnSelect);
            this.groupControl2.Controls.Add(this.btnWarehouse);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 491);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(893, 74);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "信息操作";
            // 
            // btnOut
            // 
            this.btnOut.Image = ((System.Drawing.Image)(resources.GetObject("btnOut.Image")));
            this.btnOut.Location = new System.Drawing.Point(790, 30);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(91, 36);
            this.btnOut.TabIndex = 6;
            this.btnOut.Text = "返    回";
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.Location = new System.Drawing.Point(166, 29);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(91, 36);
            this.btnSelect.TabIndex = 7;
            this.btnSelect.Text = "库存查询";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnWarehouse
            // 
            this.btnWarehouse.Image = ((System.Drawing.Image)(resources.GetObject("btnWarehouse.Image")));
            this.btnWarehouse.Location = new System.Drawing.Point(13, 29);
            this.btnWarehouse.Name = "btnWarehouse";
            this.btnWarehouse.Size = new System.Drawing.Size(90, 36);
            this.btnWarehouse.TabIndex = 4;
            this.btnWarehouse.Text = "商品入库";
            this.btnWarehouse.Click += new System.EventHandler(this.btnWarehouse_Click);
            // 
            // frmInGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 565);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmInGoods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInGoods";
            this.Load += new System.EventHandler(this.frmInGoods_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInGoods_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlMain)).EndInit();
            this.groupControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvInGoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAddInGoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInfoNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtInDate;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labSerialNumber;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnOut;
        private DevExpress.XtraEditors.SimpleButton btnSelect;
        private DevExpress.XtraEditors.SimpleButton btnWarehouse;
        private DevExpress.XtraEditors.LookUpEdit txtEmpName;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.TextEdit txtInfoNote;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraGrid.GridControl gvInGoods;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAddInGoods;
        private DevExpress.XtraGrid.Columns.GridColumn GetName;
        private DevExpress.XtraGrid.Columns.GridColumn GetSpecifications;
        private DevExpress.XtraGrid.Columns.GridColumn GetNumber;
        private DevExpress.XtraGrid.Columns.GridColumn GetPrice;
        private DevExpress.XtraEditors.SimpleButton btnSelectGoods;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn GetTotal;
        private DevExpress.XtraEditors.ComboBoxEdit cmbSupplier;
        private DevExpress.XtraEditors.GroupControl groupControlMain;

    }
}