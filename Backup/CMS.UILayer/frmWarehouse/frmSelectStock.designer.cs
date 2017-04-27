namespace CMS.UILayer.frmWarehouse
{
    partial class frmSelectStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectStock));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnAddition = new DevExpress.XtraEditors.PictureEdit();
            this.btnDelect = new DevExpress.XtraEditors.PictureEdit();
            this.btnReturn = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.gvStock = new DevExpress.XtraGrid.GridControl();
            this.gvAddStock = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcSpecifications = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtStockName = new DevExpress.XtraEditors.ButtonEdit();
            this.btnSelect = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gvInventory = new DevExpress.XtraGrid.GridControl();
            this.gvAddInventory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcGetName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcGetNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gcGetSpecifications = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcGetPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.GetTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.toolTip = new DevExpress.Utils.ToolTipController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelect.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAddStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAddInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.panelControl2);
            this.groupControl1.Controls.Add(this.gvStock);
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(885, 565);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "库存";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnAddition);
            this.panelControl2.Controls.Add(this.btnDelect);
            this.panelControl2.Controls.Add(this.btnReturn);
            this.panelControl2.Controls.Add(this.btnSave);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(397, 71);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(48, 492);
            this.panelControl2.TabIndex = 19;
            // 
            // btnAddition
            // 
            this.btnAddition.EditValue = ((object)(resources.GetObject("btnAddition.EditValue")));
            this.btnAddition.Location = new System.Drawing.Point(5, 253);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(37, 40);
            this.btnAddition.TabIndex = 0;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // btnDelect
            // 
            this.btnDelect.EditValue = ((object)(resources.GetObject("btnDelect.EditValue")));
            this.btnDelect.Location = new System.Drawing.Point(6, 31);
            this.btnDelect.Name = "btnDelect";
            this.btnDelect.Size = new System.Drawing.Size(36, 40);
            this.btnDelect.TabIndex = 0;
            this.btnDelect.Click += new System.EventHandler(this.btnDelect_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(4, 447);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(40, 40);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "返  回";
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(4, 376);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(40, 40);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "保  存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gvStock
            // 
            this.gvStock.Dock = System.Windows.Forms.DockStyle.Left;
            this.gvStock.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gvStock.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gvStock.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gvStock.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gvStock.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gvStock.Location = new System.Drawing.Point(2, 71);
            this.gvStock.MainView = this.gvAddStock;
            this.gvStock.Name = "gvStock";
            this.gvStock.Size = new System.Drawing.Size(395, 492);
            this.gvStock.TabIndex = 18;
            this.gvStock.UseEmbeddedNavigator = true;
            this.gvStock.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAddStock});
            // 
            // gvAddStock
            // 
            this.gvAddStock.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.gvAddStock.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvAddStock.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.gvAddStock.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gvAddStock.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvAddStock.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvAddStock.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvAddStock.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvAddStock.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gvAddStock.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvAddStock.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gvAddStock.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvAddStock.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvAddStock.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvAddStock.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvAddStock.Appearance.Empty.Options.UseBackColor = true;
            this.gvAddStock.Appearance.EvenRow.BackColor = System.Drawing.Color.Silver;
            this.gvAddStock.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.gvAddStock.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvAddStock.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvAddStock.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvAddStock.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvAddStock.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvAddStock.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.gvAddStock.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvAddStock.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvAddStock.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvAddStock.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvAddStock.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvAddStock.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvAddStock.Appearance.FilterPanel.BackColor = System.Drawing.Color.Black;
            this.gvAddStock.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvAddStock.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvAddStock.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvAddStock.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvAddStock.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvAddStock.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gvAddStock.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvAddStock.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvAddStock.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Purple;
            this.gvAddStock.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvAddStock.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvAddStock.Appearance.FocusedRow.BackColor = System.Drawing.Color.Purple;
            this.gvAddStock.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(50)))), ((int)(((byte)(178)))));
            this.gvAddStock.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvAddStock.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvAddStock.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvAddStock.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.gvAddStock.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.gvAddStock.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvAddStock.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvAddStock.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvAddStock.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvAddStock.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gvAddStock.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gvAddStock.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvAddStock.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvAddStock.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvAddStock.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvAddStock.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gvAddStock.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gvAddStock.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvAddStock.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvAddStock.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvAddStock.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvAddStock.Appearance.GroupPanel.BackColor = System.Drawing.Color.Black;
            this.gvAddStock.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvAddStock.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvAddStock.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gvAddStock.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvAddStock.Appearance.GroupPanel.Options.UseFont = true;
            this.gvAddStock.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvAddStock.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gvAddStock.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.gvAddStock.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvAddStock.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvAddStock.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gvAddStock.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.gvAddStock.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvAddStock.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvAddStock.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvAddStock.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvAddStock.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvAddStock.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvAddStock.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.gvAddStock.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvAddStock.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvAddStock.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvAddStock.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.gvAddStock.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvAddStock.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvAddStock.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gvAddStock.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvAddStock.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gvAddStock.Appearance.OddRow.Options.UseBackColor = true;
            this.gvAddStock.Appearance.OddRow.Options.UseForeColor = true;
            this.gvAddStock.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.gvAddStock.Appearance.Preview.BackColor2 = System.Drawing.Color.White;
            this.gvAddStock.Appearance.Preview.ForeColor = System.Drawing.Color.Purple;
            this.gvAddStock.Appearance.Preview.Options.UseBackColor = true;
            this.gvAddStock.Appearance.Preview.Options.UseForeColor = true;
            this.gvAddStock.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvAddStock.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvAddStock.Appearance.Row.Options.UseBackColor = true;
            this.gvAddStock.Appearance.Row.Options.UseForeColor = true;
            this.gvAddStock.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvAddStock.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvAddStock.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvAddStock.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(10)))), ((int)(((byte)(138)))));
            this.gvAddStock.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvAddStock.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvAddStock.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvAddStock.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.gvAddStock.Appearance.VertLine.Options.UseBackColor = true;
            this.gvAddStock.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcID,
            this.gcName,
            this.gcSpecifications,
            this.gcNumber,
            this.gcPrice});
            styleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.Red;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.gcNumber;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition1.Value1 = "5";
            this.gvAddStock.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gvAddStock.GridControl = this.gvStock;
            this.gvAddStock.Name = "gvAddStock";
            this.gvAddStock.OptionsBehavior.Editable = false;
            this.gvAddStock.OptionsPrint.EnableAppearanceOddRow = true;
            this.gvAddStock.OptionsPrint.ExpandAllDetails = true;
            this.gvAddStock.OptionsPrint.PrintDetails = true;
            this.gvAddStock.OptionsPrint.PrintFilterInfo = true;
            this.gvAddStock.OptionsPrint.UsePrintStyles = true;
            this.gvAddStock.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvAddStock.OptionsView.EnableAppearanceEvenRow = true;
            this.gvAddStock.OptionsView.EnableAppearanceOddRow = true;
            this.gvAddStock.OptionsView.ShowFooter = true;
            this.gvAddStock.OptionsView.ShowGroupPanel = false;
            this.gvAddStock.DoubleClick += new System.EventHandler(this.gvAddStock_DoubleClick);
            // 
            // gcID
            // 
            this.gcID.Caption = "商品编号";
            this.gcID.FieldName = "ID";
            this.gcID.Name = "gcID";
            this.gcID.SummaryItem.DisplayFormat = "当前库存共有{0}件商品";
            this.gcID.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            this.gcID.Visible = true;
            this.gcID.VisibleIndex = 0;
            // 
            // gcName
            // 
            this.gcName.Caption = "商品名称";
            this.gcName.FieldName = "Name";
            this.gcName.Name = "gcName";
            this.gcName.Visible = true;
            this.gcName.VisibleIndex = 1;
            // 
            // gcSpecifications
            // 
            this.gcSpecifications.Caption = "单位";
            this.gcSpecifications.FieldName = "Specifications";
            this.gcSpecifications.Name = "gcSpecifications";
            this.gcSpecifications.Visible = true;
            this.gcSpecifications.VisibleIndex = 2;
            // 
            // gcNumber
            // 
            this.gcNumber.Caption = "数量";
            this.gcNumber.FieldName = "Number";
            this.gcNumber.Name = "gcNumber";
            this.gcNumber.Visible = true;
            this.gcNumber.VisibleIndex = 3;
            // 
            // gcPrice
            // 
            this.gcPrice.Caption = "单价";
            this.gcPrice.FieldName = "Price";
            this.gcPrice.Name = "gcPrice";
            this.gcPrice.Visible = true;
            this.gcPrice.VisibleIndex = 4;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txtStockName);
            this.panelControl1.Controls.Add(this.btnSelect);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 23);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(443, 48);
            this.panelControl1.TabIndex = 17;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "商品名称：";
            // 
            // txtStockName
            // 
            this.txtStockName.Location = new System.Drawing.Point(90, 11);
            this.txtStockName.Name = "txtStockName";
            this.txtStockName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtStockName.Size = new System.Drawing.Size(129, 21);
            this.txtStockName.TabIndex = 0;
            this.txtStockName.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtName_ButtonClick);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(248, 9);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "查询(&S)";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gvInventory);
            this.groupControl2.Controls.Add(this.simpleButton2);
            this.groupControl2.Controls.Add(this.simpleButton3);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl2.Location = new System.Drawing.Point(445, 23);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(438, 540);
            this.groupControl2.TabIndex = 16;
            this.groupControl2.Text = "采购清单";
            // 
            // gvInventory
            // 
            this.gvInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvInventory.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gvInventory.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gvInventory.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gvInventory.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gvInventory.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gvInventory.Location = new System.Drawing.Point(2, 23);
            this.gvInventory.MainView = this.gvAddInventory;
            this.gvInventory.Name = "gvInventory";
            this.gvInventory.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1,
            this.repositoryItemSpinEdit2});
            this.gvInventory.Size = new System.Drawing.Size(434, 515);
            this.gvInventory.TabIndex = 5;
            this.gvInventory.UseEmbeddedNavigator = true;
            this.gvInventory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAddInventory,
            this.gridView1});
            // 
            // gvAddInventory
            // 
            this.gvAddInventory.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.gvAddInventory.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvAddInventory.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.gvAddInventory.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gvAddInventory.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvAddInventory.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvAddInventory.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvAddInventory.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvAddInventory.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gvAddInventory.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvAddInventory.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gvAddInventory.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvAddInventory.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvAddInventory.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvAddInventory.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvAddInventory.Appearance.Empty.Options.UseBackColor = true;
            this.gvAddInventory.Appearance.EvenRow.BackColor = System.Drawing.Color.Silver;
            this.gvAddInventory.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.gvAddInventory.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvAddInventory.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvAddInventory.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvAddInventory.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvAddInventory.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvAddInventory.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.gvAddInventory.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvAddInventory.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvAddInventory.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvAddInventory.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvAddInventory.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvAddInventory.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvAddInventory.Appearance.FilterPanel.BackColor = System.Drawing.Color.Black;
            this.gvAddInventory.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvAddInventory.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvAddInventory.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvAddInventory.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvAddInventory.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvAddInventory.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gvAddInventory.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvAddInventory.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvAddInventory.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Purple;
            this.gvAddInventory.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvAddInventory.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvAddInventory.Appearance.FocusedRow.BackColor = System.Drawing.Color.Purple;
            this.gvAddInventory.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(50)))), ((int)(((byte)(178)))));
            this.gvAddInventory.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvAddInventory.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvAddInventory.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvAddInventory.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.gvAddInventory.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.gvAddInventory.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvAddInventory.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvAddInventory.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvAddInventory.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvAddInventory.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gvAddInventory.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gvAddInventory.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvAddInventory.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvAddInventory.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvAddInventory.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvAddInventory.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gvAddInventory.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gvAddInventory.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvAddInventory.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvAddInventory.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvAddInventory.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvAddInventory.Appearance.GroupPanel.BackColor = System.Drawing.Color.Black;
            this.gvAddInventory.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvAddInventory.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvAddInventory.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gvAddInventory.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvAddInventory.Appearance.GroupPanel.Options.UseFont = true;
            this.gvAddInventory.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvAddInventory.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gvAddInventory.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.gvAddInventory.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvAddInventory.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvAddInventory.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gvAddInventory.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.gvAddInventory.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvAddInventory.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvAddInventory.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvAddInventory.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvAddInventory.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvAddInventory.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvAddInventory.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.gvAddInventory.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvAddInventory.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvAddInventory.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvAddInventory.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.gvAddInventory.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvAddInventory.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvAddInventory.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gvAddInventory.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvAddInventory.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gvAddInventory.Appearance.OddRow.Options.UseBackColor = true;
            this.gvAddInventory.Appearance.OddRow.Options.UseForeColor = true;
            this.gvAddInventory.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.gvAddInventory.Appearance.Preview.BackColor2 = System.Drawing.Color.White;
            this.gvAddInventory.Appearance.Preview.ForeColor = System.Drawing.Color.Purple;
            this.gvAddInventory.Appearance.Preview.Options.UseBackColor = true;
            this.gvAddInventory.Appearance.Preview.Options.UseForeColor = true;
            this.gvAddInventory.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvAddInventory.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvAddInventory.Appearance.Row.Options.UseBackColor = true;
            this.gvAddInventory.Appearance.Row.Options.UseForeColor = true;
            this.gvAddInventory.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvAddInventory.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvAddInventory.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvAddInventory.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(10)))), ((int)(((byte)(138)))));
            this.gvAddInventory.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvAddInventory.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvAddInventory.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvAddInventory.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.gvAddInventory.Appearance.VertLine.Options.UseBackColor = true;
            this.gvAddInventory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcGetName,
            this.gcGetNumber,
            this.gcGetSpecifications,
            this.gcGetPrice,
            this.GetTotal});
            this.gvAddInventory.GridControl = this.gvInventory;
            this.gvAddInventory.Name = "gvAddInventory";
            this.gvAddInventory.OptionsPrint.EnableAppearanceOddRow = true;
            this.gvAddInventory.OptionsPrint.ExpandAllDetails = true;
            this.gvAddInventory.OptionsPrint.PrintDetails = true;
            this.gvAddInventory.OptionsPrint.PrintFilterInfo = true;
            this.gvAddInventory.OptionsPrint.UsePrintStyles = true;
            this.gvAddInventory.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvAddInventory.OptionsView.EnableAppearanceEvenRow = true;
            this.gvAddInventory.OptionsView.EnableAppearanceOddRow = true;
            this.gvAddInventory.OptionsView.ShowFooter = true;
            this.gvAddInventory.OptionsView.ShowGroupPanel = false;
            // 
            // gcGetName
            // 
            this.gcGetName.Caption = "商品名称";
            this.gcGetName.FieldName = "GetName";
            this.gcGetName.Name = "gcGetName";
            this.gcGetName.OptionsColumn.AllowEdit = false;
            this.gcGetName.SummaryItem.DisplayFormat = "清单中共有不同的商品：{0}件";
            this.gcGetName.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            this.gcGetName.ToolTip = "商品名称";
            this.gcGetName.Visible = true;
            this.gcGetName.VisibleIndex = 0;
            this.gcGetName.Width = 88;
            // 
            // gcGetNumber
            // 
            this.gcGetNumber.Caption = "采购数量";
            this.gcGetNumber.ColumnEdit = this.repositoryItemSpinEdit1;
            this.gcGetNumber.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gcGetNumber.FieldName = "GetNumber";
            this.gcGetNumber.Name = "gcGetNumber";
            this.gcGetNumber.SummaryItem.DisplayFormat = "共有商品：{0}件";
            this.gcGetNumber.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.gcGetNumber.Visible = true;
            this.gcGetNumber.VisibleIndex = 1;
            this.gcGetNumber.Width = 99;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // gcGetSpecifications
            // 
            this.gcGetSpecifications.Caption = "单位";
            this.gcGetSpecifications.FieldName = "GetSpecifications";
            this.gcGetSpecifications.Name = "gcGetSpecifications";
            this.gcGetSpecifications.OptionsColumn.AllowEdit = false;
            this.gcGetSpecifications.SummaryItem.DisplayFormat = "商品总金额：{0}元";
            this.gcGetSpecifications.SummaryItem.FieldName = "GetTotal";
            this.gcGetSpecifications.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.gcGetSpecifications.Visible = true;
            this.gcGetSpecifications.VisibleIndex = 2;
            this.gcGetSpecifications.Width = 57;
            // 
            // gcGetPrice
            // 
            this.gcGetPrice.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gcGetPrice.AppearanceCell.Options.UseBackColor = true;
            this.gcGetPrice.Caption = "商品单价";
            this.gcGetPrice.ColumnEdit = this.repositoryItemSpinEdit2;
            this.gcGetPrice.DisplayFormat.FormatString = "c";
            this.gcGetPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gcGetPrice.FieldName = "GetPrice";
            this.gcGetPrice.Name = "gcGetPrice";
            this.gcGetPrice.OptionsColumn.AllowEdit = false;
            this.gcGetPrice.Visible = true;
            this.gcGetPrice.VisibleIndex = 3;
            this.gcGetPrice.Width = 77;
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
            this.GetTotal.OptionsColumn.AllowEdit = false;
            this.GetTotal.Visible = true;
            this.GetTotal.VisibleIndex = 4;
            this.GetTotal.Width = 131;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gvInventory;
            this.gridView1.Name = "gridView1";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(646, 221);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(85, 38);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "添    加";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(768, 221);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(85, 38);
            this.simpleButton3.TabIndex = 4;
            this.simpleButton3.Text = "取    消";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(546, 37);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(168, 14);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "请在保存之前选择要采购的商品";
            // 
            // frmSelectStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 565);
            this.Controls.Add(this.groupControl1);
            this.MaximizeBox = false;
            this.Name = "frmSelectStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加采购清单";
            this.Load += new System.EventHandler(this.frmStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAddition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelect.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAddStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAddInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnSelect;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ButtonEdit txtStockName;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.Utils.ToolTipController toolTip;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraGrid.GridControl gvInventory;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAddInventory;
        private DevExpress.XtraGrid.Columns.GridColumn gcGetName;
        private DevExpress.XtraGrid.Columns.GridColumn gcGetNumber;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gcGetPrice;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn gcGetSpecifications;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PictureEdit btnAddition;
        private DevExpress.XtraEditors.PictureEdit btnDelect;
        private DevExpress.XtraEditors.SimpleButton btnReturn;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraGrid.GridControl gvStock;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAddStock;
        private DevExpress.XtraGrid.Columns.GridColumn gcID;
        private DevExpress.XtraGrid.Columns.GridColumn gcName;
        private DevExpress.XtraGrid.Columns.GridColumn gcSpecifications;
        private DevExpress.XtraGrid.Columns.GridColumn gcNumber;
        private DevExpress.XtraGrid.Columns.GridColumn gcPrice;
        private DevExpress.XtraGrid.Columns.GridColumn GetTotal;

    }
}