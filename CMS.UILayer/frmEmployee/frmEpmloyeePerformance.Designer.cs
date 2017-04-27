namespace CMS.UILayer.frmEmployee
{
    partial class frmEpmloyeePerformance
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
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnReturn = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lvPerformance = new DevExpress.XtraGrid.GridControl();
            this.lvPerformanceMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcSex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPosInfoName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDPInfoName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDishServerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDishServerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDishServerCommission = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcEmployeeInfoNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtEmpID = new DevExpress.XtraEditors.MRUEdit();
            this.txtItemID = new DevExpress.XtraEditors.MRUEdit();
            this.btnSelectAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnSelect = new DevExpress.XtraEditors.SimpleButton();
            this.txtName = new DevExpress.XtraEditors.MRUEdit();
            this.txtEmpName = new DevExpress.XtraEditors.MRUEdit();
            this.SelectValue = new DevExpress.XtraEditors.MRUEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvPerformance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvPerformanceMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectValue.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnPrint);
            this.groupControl2.Controls.Add(this.btnReturn);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 454);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(806, 73);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "业绩操作";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(629, 30);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 36);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "打    印";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(719, 30);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 36);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "返    回";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lvPerformance);
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(806, 454);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "查询条件";
            // 
            // lvPerformance
            // 
            this.lvPerformance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPerformance.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.lvPerformance.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.lvPerformance.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.lvPerformance.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.lvPerformance.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.lvPerformance.Location = new System.Drawing.Point(2, 74);
            this.lvPerformance.MainView = this.lvPerformanceMain;
            this.lvPerformance.Name = "lvPerformance";
            this.lvPerformance.Size = new System.Drawing.Size(802, 378);
            this.lvPerformance.TabIndex = 1;
            this.lvPerformance.UseEmbeddedNavigator = true;
            this.lvPerformance.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.lvPerformanceMain});
            // 
            // lvPerformanceMain
            // 
            this.lvPerformanceMain.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.lvPerformanceMain.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.lvPerformanceMain.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.lvPerformanceMain.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.lvPerformanceMain.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.lvPerformanceMain.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.lvPerformanceMain.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.lvPerformanceMain.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.lvPerformanceMain.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.lvPerformanceMain.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.lvPerformanceMain.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.lvPerformanceMain.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.lvPerformanceMain.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.lvPerformanceMain.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.lvPerformanceMain.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.lvPerformanceMain.Appearance.Empty.Options.UseBackColor = true;
            this.lvPerformanceMain.Appearance.EvenRow.BackColor = System.Drawing.Color.Silver;
            this.lvPerformanceMain.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.lvPerformanceMain.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.lvPerformanceMain.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.lvPerformanceMain.Appearance.EvenRow.Options.UseBackColor = true;
            this.lvPerformanceMain.Appearance.EvenRow.Options.UseForeColor = true;
            this.lvPerformanceMain.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.lvPerformanceMain.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lvPerformanceMain.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.lvPerformanceMain.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.lvPerformanceMain.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.lvPerformanceMain.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.lvPerformanceMain.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.lvPerformanceMain.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.lvPerformanceMain.Appearance.FilterPanel.BackColor = System.Drawing.Color.Black;
            this.lvPerformanceMain.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.lvPerformanceMain.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.lvPerformanceMain.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.lvPerformanceMain.Appearance.FilterPanel.Options.UseBackColor = true;
            this.lvPerformanceMain.Appearance.FilterPanel.Options.UseForeColor = true;
            this.lvPerformanceMain.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.lvPerformanceMain.Appearance.FixedLine.Options.UseBackColor = true;
            this.lvPerformanceMain.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.lvPerformanceMain.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Purple;
            this.lvPerformanceMain.Appearance.FocusedCell.Options.UseBackColor = true;
            this.lvPerformanceMain.Appearance.FocusedCell.Options.UseForeColor = true;
            this.lvPerformanceMain.Appearance.FocusedRow.BackColor = System.Drawing.Color.Purple;
            this.lvPerformanceMain.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(50)))), ((int)(((byte)(178)))));
            this.lvPerformanceMain.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.lvPerformanceMain.Appearance.FocusedRow.Options.UseBackColor = true;
            this.lvPerformanceMain.Appearance.FocusedRow.Options.UseForeColor = true;
            this.lvPerformanceMain.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.lvPerformanceMain.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.lvPerformanceMain.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.lvPerformanceMain.Appearance.FooterPanel.Options.UseBackColor = true;
            this.lvPerformanceMain.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.lvPerformanceMain.Appearance.FooterPanel.Options.UseForeColor = true;
            this.lvPerformanceMain.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.lvPerformanceMain.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.lvPerformanceMain.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.lvPerformanceMain.Appearance.GroupButton.Options.UseBackColor = true;
            this.lvPerformanceMain.Appearance.GroupButton.Options.UseBorderColor = true;
            this.lvPerformanceMain.Appearance.GroupButton.Options.UseForeColor = true;
            this.lvPerformanceMain.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.lvPerformanceMain.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.lvPerformanceMain.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.lvPerformanceMain.Appearance.GroupFooter.Options.UseBackColor = true;
            this.lvPerformanceMain.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.lvPerformanceMain.Appearance.GroupFooter.Options.UseForeColor = true;
            this.lvPerformanceMain.Appearance.GroupPanel.BackColor = System.Drawing.Color.Black;
            this.lvPerformanceMain.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.lvPerformanceMain.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lvPerformanceMain.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.lvPerformanceMain.Appearance.GroupPanel.Options.UseBackColor = true;
            this.lvPerformanceMain.Appearance.GroupPanel.Options.UseFont = true;
            this.lvPerformanceMain.Appearance.GroupPanel.Options.UseForeColor = true;
            this.lvPerformanceMain.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.lvPerformanceMain.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.lvPerformanceMain.Appearance.GroupRow.Options.UseBackColor = true;
            this.lvPerformanceMain.Appearance.GroupRow.Options.UseForeColor = true;
            this.lvPerformanceMain.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.lvPerformanceMain.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.lvPerformanceMain.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lvPerformanceMain.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.lvPerformanceMain.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.lvPerformanceMain.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.lvPerformanceMain.Appearance.HeaderPanel.Options.UseFont = true;
            this.lvPerformanceMain.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.lvPerformanceMain.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.lvPerformanceMain.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.lvPerformanceMain.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.lvPerformanceMain.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.lvPerformanceMain.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.lvPerformanceMain.Appearance.HorzLine.Options.UseBackColor = true;
            this.lvPerformanceMain.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.lvPerformanceMain.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.lvPerformanceMain.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.lvPerformanceMain.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.lvPerformanceMain.Appearance.OddRow.Options.UseBackColor = true;
            this.lvPerformanceMain.Appearance.OddRow.Options.UseForeColor = true;
            this.lvPerformanceMain.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.lvPerformanceMain.Appearance.Preview.BackColor2 = System.Drawing.Color.White;
            this.lvPerformanceMain.Appearance.Preview.ForeColor = System.Drawing.Color.Purple;
            this.lvPerformanceMain.Appearance.Preview.Options.UseBackColor = true;
            this.lvPerformanceMain.Appearance.Preview.Options.UseForeColor = true;
            this.lvPerformanceMain.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.lvPerformanceMain.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.lvPerformanceMain.Appearance.Row.Options.UseBackColor = true;
            this.lvPerformanceMain.Appearance.Row.Options.UseForeColor = true;
            this.lvPerformanceMain.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.lvPerformanceMain.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.lvPerformanceMain.Appearance.RowSeparator.Options.UseBackColor = true;
            this.lvPerformanceMain.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(10)))), ((int)(((byte)(138)))));
            this.lvPerformanceMain.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.lvPerformanceMain.Appearance.SelectedRow.Options.UseBackColor = true;
            this.lvPerformanceMain.Appearance.SelectedRow.Options.UseForeColor = true;
            this.lvPerformanceMain.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.lvPerformanceMain.Appearance.VertLine.Options.UseBackColor = true;
            this.lvPerformanceMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcID,
            this.gcName,
            this.gcSex,
            this.gcPosInfoName,
            this.gcDPInfoName,
            this.gcDishServerID,
            this.gcDishServerName,
            this.gcType,
            this.gcPrice,
            this.gcDishServerCommission,
            this.gcEmployeeInfoNote});
            this.lvPerformanceMain.GridControl = this.lvPerformance;
            this.lvPerformanceMain.Name = "lvPerformanceMain";
            this.lvPerformanceMain.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.lvPerformanceMain.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.lvPerformanceMain.OptionsBehavior.AutoExpandAllGroups = true;
            this.lvPerformanceMain.OptionsBehavior.Editable = false;
            this.lvPerformanceMain.OptionsPrint.EnableAppearanceOddRow = true;
            this.lvPerformanceMain.OptionsPrint.ExpandAllDetails = true;
            this.lvPerformanceMain.OptionsPrint.PrintDetails = true;
            this.lvPerformanceMain.OptionsPrint.PrintFilterInfo = true;
            this.lvPerformanceMain.OptionsPrint.PrintPreview = true;
            this.lvPerformanceMain.OptionsPrint.UsePrintStyles = true;
            this.lvPerformanceMain.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.lvPerformanceMain.OptionsView.ColumnAutoWidth = false;
            this.lvPerformanceMain.OptionsView.EnableAppearanceEvenRow = true;
            this.lvPerformanceMain.OptionsView.EnableAppearanceOddRow = true;
            this.lvPerformanceMain.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.lvPerformanceMain.OptionsView.ShowFooter = true;
            // 
            // gcID
            // 
            this.gcID.Caption = "员工编号";
            this.gcID.FieldName = "员工编号";
            this.gcID.Name = "gcID";
            this.gcID.SummaryItem.DisplayFormat = "共有：{0}项";
            this.gcID.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            this.gcID.Visible = true;
            this.gcID.VisibleIndex = 0;
            this.gcID.Width = 79;
            // 
            // gcName
            // 
            this.gcName.Caption = "员工姓名";
            this.gcName.FieldName = "员工姓名";
            this.gcName.Name = "gcName";
            this.gcName.SummaryItem.DisplayFormat = "共可提成：{0}元";
            this.gcName.SummaryItem.FieldName = "菜品提成";
            this.gcName.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.gcName.Visible = true;
            this.gcName.VisibleIndex = 1;
            this.gcName.Width = 83;
            // 
            // gcSex
            // 
            this.gcSex.Caption = "员工性别";
            this.gcSex.FieldName = "员工性别";
            this.gcSex.Name = "gcSex";
            this.gcSex.Visible = true;
            this.gcSex.VisibleIndex = 2;
            this.gcSex.Width = 78;
            // 
            // gcPosInfoName
            // 
            this.gcPosInfoName.Caption = "当前职务";
            this.gcPosInfoName.FieldName = "当前职务";
            this.gcPosInfoName.Name = "gcPosInfoName";
            this.gcPosInfoName.Visible = true;
            this.gcPosInfoName.VisibleIndex = 3;
            this.gcPosInfoName.Width = 77;
            // 
            // gcDPInfoName
            // 
            this.gcDPInfoName.Caption = "所在部门";
            this.gcDPInfoName.FieldName = "所在部门";
            this.gcDPInfoName.Name = "gcDPInfoName";
            this.gcDPInfoName.Visible = true;
            this.gcDPInfoName.VisibleIndex = 4;
            this.gcDPInfoName.Width = 74;
            // 
            // gcDishServerID
            // 
            this.gcDishServerID.Caption = "菜品编号";
            this.gcDishServerID.FieldName = "菜品编号";
            this.gcDishServerID.Name = "gcDishServerID";
            this.gcDishServerID.Visible = true;
            this.gcDishServerID.VisibleIndex = 5;
            this.gcDishServerID.Width = 120;
            // 
            // gcDishServerName
            // 
            this.gcDishServerName.Caption = "菜品名称";
            this.gcDishServerName.FieldName = "菜品名称";
            this.gcDishServerName.Name = "gcDishServerName";
            this.gcDishServerName.Visible = true;
            this.gcDishServerName.VisibleIndex = 6;
            this.gcDishServerName.Width = 124;
            // 
            // gcType
            // 
            this.gcType.Caption = "菜品类别";
            this.gcType.FieldName = "菜品类别";
            this.gcType.Name = "gcType";
            this.gcType.Visible = true;
            this.gcType.VisibleIndex = 7;
            this.gcType.Width = 80;
            // 
            // gcPrice
            // 
            this.gcPrice.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gcPrice.AppearanceCell.Options.UseBackColor = true;
            this.gcPrice.Caption = "单价";
            this.gcPrice.DisplayFormat.FormatString = "c";
            this.gcPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gcPrice.FieldName = "单价";
            this.gcPrice.Name = "gcPrice";
            this.gcPrice.Visible = true;
            this.gcPrice.VisibleIndex = 8;
            this.gcPrice.Width = 97;
            // 
            // gcDishServerCommission
            // 
            this.gcDishServerCommission.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gcDishServerCommission.AppearanceCell.Options.UseBackColor = true;
            this.gcDishServerCommission.Caption = "菜品提成";
            this.gcDishServerCommission.DisplayFormat.FormatString = "c";
            this.gcDishServerCommission.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gcDishServerCommission.FieldName = "菜品提成";
            this.gcDishServerCommission.Name = "gcDishServerCommission";
            this.gcDishServerCommission.Visible = true;
            this.gcDishServerCommission.VisibleIndex = 9;
            this.gcDishServerCommission.Width = 107;
            // 
            // gcEmployeeInfoNote
            // 
            this.gcEmployeeInfoNote.Caption = "备注";
            this.gcEmployeeInfoNote.FieldName = "备注";
            this.gcEmployeeInfoNote.Name = "gcEmployeeInfoNote";
            this.gcEmployeeInfoNote.Visible = true;
            this.gcEmployeeInfoNote.VisibleIndex = 10;
            this.gcEmployeeInfoNote.Width = 240;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtEmpID);
            this.panelControl1.Controls.Add(this.txtItemID);
            this.panelControl1.Controls.Add(this.btnSelectAll);
            this.panelControl1.Controls.Add(this.btnSelect);
            this.panelControl1.Controls.Add(this.txtName);
            this.panelControl1.Controls.Add(this.txtEmpName);
            this.panelControl1.Controls.Add(this.SelectValue);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 23);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(802, 51);
            this.panelControl1.TabIndex = 0;
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(270, 17);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtEmpID.Size = new System.Drawing.Size(218, 21);
            this.txtEmpID.TabIndex = 3;
            this.txtEmpID.SelectedIndexChanged += new System.EventHandler(this.txtEmpID_SelectedIndexChanged);
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(270, 17);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtItemID.Size = new System.Drawing.Size(218, 21);
            this.txtItemID.TabIndex = 1;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(717, 8);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 36);
            this.btnSelectAll.TabIndex = 2;
            this.btnSelectAll.Text = "查询全部";
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(627, 8);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 36);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "查    询";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(270, 17);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtName.Size = new System.Drawing.Size(218, 21);
            this.txtName.TabIndex = 1;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(270, 17);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtEmpName.Size = new System.Drawing.Size(218, 21);
            this.txtEmpName.TabIndex = 1;
            // 
            // SelectValue
            // 
            this.SelectValue.EditValue = "员工编号";
            this.SelectValue.Location = new System.Drawing.Point(58, 17);
            this.SelectValue.Name = "SelectValue";
            this.SelectValue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SelectValue.Properties.Items.AddRange(new object[] {
            "菜品名称",
            "菜品编号",
            "员工姓名",
            "员工编号"});
            this.SelectValue.Size = new System.Drawing.Size(130, 21);
            this.SelectValue.TabIndex = 1;
            this.SelectValue.SelectedIndexChanged += new System.EventHandler(this.SelectValue_SelectedIndexChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(207, 20);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "第二条件：";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(28, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "按：";
            // 
            // frmEpmloyeePerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 527);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.HelpButton = true;
            this.Name = "frmEpmloyeePerformance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工业绩查询";
            this.Load += new System.EventHandler(this.frmEpmloyeePerformance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lvPerformance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvPerformanceMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectValue.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl lvPerformance;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.MRUEdit SelectValue;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSelect;
        private DevExpress.XtraEditors.SimpleButton btnReturn;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.MRUEdit txtItemID;
        private DevExpress.XtraEditors.MRUEdit txtName;
        private DevExpress.XtraEditors.MRUEdit txtEmpName;
        private DevExpress.XtraEditors.MRUEdit txtEmpID;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraGrid.Views.Grid.GridView lvPerformanceMain;
        private DevExpress.XtraGrid.Columns.GridColumn gcID;
        private DevExpress.XtraGrid.Columns.GridColumn gcName;
        private DevExpress.XtraGrid.Columns.GridColumn gcSex;
        private DevExpress.XtraGrid.Columns.GridColumn gcPosInfoName;
        private DevExpress.XtraGrid.Columns.GridColumn gcDPInfoName;
        private DevExpress.XtraGrid.Columns.GridColumn gcDishServerID;
        private DevExpress.XtraGrid.Columns.GridColumn gcDishServerName;
        private DevExpress.XtraGrid.Columns.GridColumn gcType;
        private DevExpress.XtraGrid.Columns.GridColumn gcPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gcDishServerCommission;
        private DevExpress.XtraGrid.Columns.GridColumn gcEmployeeInfoNote;
        private DevExpress.XtraEditors.SimpleButton btnSelectAll;

    }
}