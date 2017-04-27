namespace CMS.UILayer.frmEmployee
{
    partial class frmSetEmployeeInfo
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
            this.gridControlDep = new DevExpress.XtraGrid.GridControl();
            this.gridViewDep = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DepID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DepName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DepDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DepCreatePerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DepCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DepModifyPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DepModifyDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControlDep = new DevExpress.XtraEditors.GroupControl();
            this.btnOutDep = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrintDep = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteDep = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdateDep = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddDep = new DevExpress.XtraEditors.SimpleButton();
            this.groupControlPos = new DevExpress.XtraEditors.GroupControl();
            this.gridControlPos = new DevExpress.XtraGrid.GridControl();
            this.gridViewPos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PosID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PosName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PosDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PosCreatePerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PosCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PosModifyPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PosModifyDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnOutPos = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrintPos = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeletePos = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdatePos = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddPos = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControlPosition = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDep)).BeginInit();
            this.groupControlDep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlPos)).BeginInit();
            this.groupControlPos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlPosition)).BeginInit();
            this.groupControlPosition.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlDep
            // 
            this.gridControlDep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDep.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlDep.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlDep.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlDep.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlDep.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlDep.Location = new System.Drawing.Point(2, 23);
            this.gridControlDep.MainView = this.gridViewDep;
            this.gridControlDep.Name = "gridControlDep";
            this.gridControlDep.Size = new System.Drawing.Size(551, 225);
            this.gridControlDep.TabIndex = 0;
            this.gridControlDep.UseEmbeddedNavigator = true;
            this.gridControlDep.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDep});
            // 
            // gridViewDep
            // 
            this.gridViewDep.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewDep.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewDep.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewDep.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gridViewDep.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridViewDep.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridViewDep.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridViewDep.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewDep.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gridViewDep.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewDep.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gridViewDep.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridViewDep.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridViewDep.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridViewDep.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewDep.Appearance.Empty.Options.UseBackColor = true;
            this.gridViewDep.Appearance.EvenRow.BackColor = System.Drawing.Color.Silver;
            this.gridViewDep.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.gridViewDep.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewDep.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewDep.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridViewDep.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridViewDep.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewDep.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.gridViewDep.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewDep.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewDep.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewDep.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridViewDep.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridViewDep.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridViewDep.Appearance.FilterPanel.BackColor = System.Drawing.Color.Black;
            this.gridViewDep.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewDep.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewDep.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewDep.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridViewDep.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridViewDep.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gridViewDep.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridViewDep.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gridViewDep.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Purple;
            this.gridViewDep.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridViewDep.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridViewDep.Appearance.FocusedRow.BackColor = System.Drawing.Color.Purple;
            this.gridViewDep.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(50)))), ((int)(((byte)(178)))));
            this.gridViewDep.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewDep.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewDep.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewDep.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.gridViewDep.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridViewDep.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewDep.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridViewDep.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridViewDep.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewDep.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewDep.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewDep.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewDep.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridViewDep.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridViewDep.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridViewDep.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewDep.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewDep.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridViewDep.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridViewDep.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridViewDep.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridViewDep.Appearance.GroupPanel.BackColor = System.Drawing.Color.Black;
            this.gridViewDep.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridViewDep.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewDep.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewDep.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewDep.Appearance.GroupPanel.Options.UseFont = true;
            this.gridViewDep.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridViewDep.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewDep.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.gridViewDep.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridViewDep.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridViewDep.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gridViewDep.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridViewDep.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewDep.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewDep.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewDep.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridViewDep.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewDep.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewDep.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewDep.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewDep.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewDep.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewDep.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewDep.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridViewDep.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridViewDep.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gridViewDep.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewDep.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gridViewDep.Appearance.OddRow.Options.UseBackColor = true;
            this.gridViewDep.Appearance.OddRow.Options.UseForeColor = true;
            this.gridViewDep.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.gridViewDep.Appearance.Preview.BackColor2 = System.Drawing.Color.White;
            this.gridViewDep.Appearance.Preview.ForeColor = System.Drawing.Color.Purple;
            this.gridViewDep.Appearance.Preview.Options.UseBackColor = true;
            this.gridViewDep.Appearance.Preview.Options.UseForeColor = true;
            this.gridViewDep.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridViewDep.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridViewDep.Appearance.Row.Options.UseBackColor = true;
            this.gridViewDep.Appearance.Row.Options.UseForeColor = true;
            this.gridViewDep.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridViewDep.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewDep.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridViewDep.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(10)))), ((int)(((byte)(138)))));
            this.gridViewDep.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewDep.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewDep.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewDep.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewDep.Appearance.VertLine.Options.UseBackColor = true;
            this.gridViewDep.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DepID,
            this.DepName,
            this.DepDescription,
            this.DepCreatePerson,
            this.DepCreateDate,
            this.DepModifyPerson,
            this.DepModifyDate});
            this.gridViewDep.GridControl = this.gridControlDep;
            this.gridViewDep.Name = "gridViewDep";
            this.gridViewDep.OptionsBehavior.Editable = false;
            this.gridViewDep.OptionsPrint.EnableAppearanceOddRow = true;
            this.gridViewDep.OptionsPrint.ExpandAllDetails = true;
            this.gridViewDep.OptionsPrint.PrintDetails = true;
            this.gridViewDep.OptionsPrint.PrintFilterInfo = true;
            this.gridViewDep.OptionsPrint.PrintPreview = true;
            this.gridViewDep.OptionsPrint.UsePrintStyles = true;
            this.gridViewDep.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewDep.OptionsSelection.MultiSelect = true;
            this.gridViewDep.OptionsView.ColumnAutoWidth = false;
            this.gridViewDep.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewDep.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewDep.OptionsView.ShowGroupPanel = false;
            this.gridViewDep.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridViewDep_SelectionChanged);
            this.gridViewDep.DoubleClick += new System.EventHandler(this.gridViewDep_DoubleClick);
            // 
            // DepID
            // 
            this.DepID.Caption = "编号";
            this.DepID.FieldName = "ID";
            this.DepID.Name = "DepID";
            this.DepID.ToolTip = "部门编号";
            this.DepID.Visible = true;
            this.DepID.VisibleIndex = 0;
            this.DepID.Width = 50;
            // 
            // DepName
            // 
            this.DepName.Caption = "部门名称";
            this.DepName.FieldName = "Name";
            this.DepName.Name = "DepName";
            this.DepName.ToolTip = "部门名称";
            this.DepName.Visible = true;
            this.DepName.VisibleIndex = 1;
            this.DepName.Width = 94;
            // 
            // DepDescription
            // 
            this.DepDescription.Caption = "描述";
            this.DepDescription.FieldName = "Description";
            this.DepDescription.Name = "DepDescription";
            this.DepDescription.ToolTip = "描述";
            this.DepDescription.Visible = true;
            this.DepDescription.VisibleIndex = 2;
            this.DepDescription.Width = 240;
            // 
            // DepCreatePerson
            // 
            this.DepCreatePerson.Caption = "创建人";
            this.DepCreatePerson.FieldName = "CreatePerson";
            this.DepCreatePerson.Name = "DepCreatePerson";
            this.DepCreatePerson.ToolTip = "创建人";
            this.DepCreatePerson.Visible = true;
            this.DepCreatePerson.VisibleIndex = 3;
            this.DepCreatePerson.Width = 70;
            // 
            // DepCreateDate
            // 
            this.DepCreateDate.Caption = "创建时间";
            this.DepCreateDate.DisplayFormat.FormatString = "g";
            this.DepCreateDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DepCreateDate.FieldName = "CreateDate";
            this.DepCreateDate.Name = "DepCreateDate";
            this.DepCreateDate.ToolTip = "创建时间";
            this.DepCreateDate.Visible = true;
            this.DepCreateDate.VisibleIndex = 4;
            this.DepCreateDate.Width = 120;
            // 
            // DepModifyPerson
            // 
            this.DepModifyPerson.Caption = "修改人";
            this.DepModifyPerson.FieldName = "ModifyPerson";
            this.DepModifyPerson.Name = "DepModifyPerson";
            this.DepModifyPerson.ToolTip = "修改人";
            this.DepModifyPerson.Visible = true;
            this.DepModifyPerson.VisibleIndex = 5;
            this.DepModifyPerson.Width = 70;
            // 
            // DepModifyDate
            // 
            this.DepModifyDate.Caption = "修改时间";
            this.DepModifyDate.DisplayFormat.FormatString = "g";
            this.DepModifyDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DepModifyDate.FieldName = "ModifyDate";
            this.DepModifyDate.Name = "DepModifyDate";
            this.DepModifyDate.ToolTip = "修改时间";
            this.DepModifyDate.Visible = true;
            this.DepModifyDate.VisibleIndex = 6;
            this.DepModifyDate.Width = 120;
            // 
            // groupControlDep
            // 
            this.groupControlDep.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControlDep.Controls.Add(this.gridControlDep);
            this.groupControlDep.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControlDep.Location = new System.Drawing.Point(2, 2);
            this.groupControlDep.Name = "groupControlDep";
            this.groupControlDep.Size = new System.Drawing.Size(555, 250);
            this.groupControlDep.TabIndex = 1;
            this.groupControlDep.Text = "部门列表";
            // 
            // btnOutDep
            // 
            this.btnOutDep.Location = new System.Drawing.Point(30, 205);
            this.btnOutDep.Name = "btnOutDep";
            this.btnOutDep.Size = new System.Drawing.Size(63, 30);
            this.btnOutDep.TabIndex = 5;
            this.btnOutDep.Text = "导出(&O)";
            this.btnOutDep.ToolTip = "导出部门信息(Alt+O)";
            this.btnOutDep.Click += new System.EventHandler(this.btnOutDep_Click);
            // 
            // btnPrintDep
            // 
            this.btnPrintDep.Location = new System.Drawing.Point(30, 162);
            this.btnPrintDep.Name = "btnPrintDep";
            this.btnPrintDep.Size = new System.Drawing.Size(63, 30);
            this.btnPrintDep.TabIndex = 4;
            this.btnPrintDep.Text = "打印(&P)";
            this.btnPrintDep.ToolTip = "打印部门信息(Alt+P)";
            this.btnPrintDep.Click += new System.EventHandler(this.btnPrintDep_Click);
            // 
            // btnDeleteDep
            // 
            this.btnDeleteDep.Location = new System.Drawing.Point(30, 119);
            this.btnDeleteDep.Name = "btnDeleteDep";
            this.btnDeleteDep.Size = new System.Drawing.Size(63, 30);
            this.btnDeleteDep.TabIndex = 3;
            this.btnDeleteDep.Text = "删除(&D)";
            this.btnDeleteDep.ToolTip = "删除部门(Alt+D)";
            this.btnDeleteDep.Click += new System.EventHandler(this.btnDeleteDep_Click);
            // 
            // btnUpdateDep
            // 
            this.btnUpdateDep.Location = new System.Drawing.Point(30, 76);
            this.btnUpdateDep.Name = "btnUpdateDep";
            this.btnUpdateDep.Size = new System.Drawing.Size(63, 30);
            this.btnUpdateDep.TabIndex = 2;
            this.btnUpdateDep.Text = "修改(&U)";
            this.btnUpdateDep.ToolTip = "修改部门信息(Alt+U)";
            this.btnUpdateDep.Click += new System.EventHandler(this.btnUpdateDep_Click);
            // 
            // btnAddDep
            // 
            this.btnAddDep.Location = new System.Drawing.Point(30, 33);
            this.btnAddDep.Name = "btnAddDep";
            this.btnAddDep.Size = new System.Drawing.Size(63, 30);
            this.btnAddDep.TabIndex = 1;
            this.btnAddDep.Text = "添加(&A)";
            this.btnAddDep.ToolTip = "添加新部门(Alt+A)";
            this.btnAddDep.Click += new System.EventHandler(this.btnAddDep_Click);
            // 
            // groupControlPos
            // 
            this.groupControlPos.Controls.Add(this.gridControlPos);
            this.groupControlPos.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControlPos.Location = new System.Drawing.Point(2, 2);
            this.groupControlPos.Name = "groupControlPos";
            this.groupControlPos.Size = new System.Drawing.Size(553, 255);
            this.groupControlPos.TabIndex = 2;
            this.groupControlPos.Text = "下属职位";
            // 
            // gridControlPos
            // 
            this.gridControlPos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPos.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlPos.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlPos.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlPos.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlPos.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlPos.Location = new System.Drawing.Point(2, 23);
            this.gridControlPos.MainView = this.gridViewPos;
            this.gridControlPos.Name = "gridControlPos";
            this.gridControlPos.Size = new System.Drawing.Size(549, 230);
            this.gridControlPos.TabIndex = 0;
            this.gridControlPos.UseEmbeddedNavigator = true;
            this.gridControlPos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPos});
            // 
            // gridViewPos
            // 
            this.gridViewPos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewPos.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewPos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewPos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gridViewPos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridViewPos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridViewPos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridViewPos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewPos.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gridViewPos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewPos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gridViewPos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridViewPos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridViewPos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridViewPos.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewPos.Appearance.Empty.Options.UseBackColor = true;
            this.gridViewPos.Appearance.EvenRow.BackColor = System.Drawing.Color.Silver;
            this.gridViewPos.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.gridViewPos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewPos.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewPos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridViewPos.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridViewPos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewPos.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.gridViewPos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewPos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewPos.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewPos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridViewPos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridViewPos.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridViewPos.Appearance.FilterPanel.BackColor = System.Drawing.Color.Black;
            this.gridViewPos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewPos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewPos.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewPos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridViewPos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridViewPos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gridViewPos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridViewPos.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gridViewPos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Purple;
            this.gridViewPos.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridViewPos.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridViewPos.Appearance.FocusedRow.BackColor = System.Drawing.Color.Purple;
            this.gridViewPos.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(50)))), ((int)(((byte)(178)))));
            this.gridViewPos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewPos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewPos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewPos.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.gridViewPos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridViewPos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewPos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridViewPos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridViewPos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewPos.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewPos.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewPos.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewPos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridViewPos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridViewPos.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridViewPos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewPos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewPos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridViewPos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridViewPos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridViewPos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridViewPos.Appearance.GroupPanel.BackColor = System.Drawing.Color.Black;
            this.gridViewPos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridViewPos.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewPos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewPos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewPos.Appearance.GroupPanel.Options.UseFont = true;
            this.gridViewPos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridViewPos.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewPos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.gridViewPos.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridViewPos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridViewPos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gridViewPos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridViewPos.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewPos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewPos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewPos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridViewPos.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewPos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewPos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewPos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewPos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewPos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewPos.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewPos.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridViewPos.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridViewPos.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gridViewPos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewPos.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gridViewPos.Appearance.OddRow.Options.UseBackColor = true;
            this.gridViewPos.Appearance.OddRow.Options.UseForeColor = true;
            this.gridViewPos.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.gridViewPos.Appearance.Preview.BackColor2 = System.Drawing.Color.White;
            this.gridViewPos.Appearance.Preview.ForeColor = System.Drawing.Color.Purple;
            this.gridViewPos.Appearance.Preview.Options.UseBackColor = true;
            this.gridViewPos.Appearance.Preview.Options.UseForeColor = true;
            this.gridViewPos.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridViewPos.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridViewPos.Appearance.Row.Options.UseBackColor = true;
            this.gridViewPos.Appearance.Row.Options.UseForeColor = true;
            this.gridViewPos.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridViewPos.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewPos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridViewPos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(10)))), ((int)(((byte)(138)))));
            this.gridViewPos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewPos.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewPos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewPos.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewPos.Appearance.VertLine.Options.UseBackColor = true;
            this.gridViewPos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PosID,
            this.PosName,
            this.PosDescription,
            this.PosCreatePerson,
            this.PosCreateDate,
            this.PosModifyPerson,
            this.PosModifyDate});
            this.gridViewPos.GridControl = this.gridControlPos;
            this.gridViewPos.Name = "gridViewPos";
            this.gridViewPos.OptionsBehavior.Editable = false;
            this.gridViewPos.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewPos.OptionsPrint.EnableAppearanceOddRow = true;
            this.gridViewPos.OptionsPrint.ExpandAllDetails = true;
            this.gridViewPos.OptionsPrint.PrintDetails = true;
            this.gridViewPos.OptionsPrint.PrintFilterInfo = true;
            this.gridViewPos.OptionsPrint.PrintPreview = true;
            this.gridViewPos.OptionsPrint.PrintSelectedRowsOnly = true;
            this.gridViewPos.OptionsPrint.UsePrintStyles = true;
            this.gridViewPos.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewPos.OptionsSelection.MultiSelect = true;
            this.gridViewPos.OptionsView.ColumnAutoWidth = false;
            this.gridViewPos.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewPos.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewPos.OptionsView.ShowGroupPanel = false;
            this.gridViewPos.DoubleClick += new System.EventHandler(this.gridViewPos_DoubleClick);
            // 
            // PosID
            // 
            this.PosID.Caption = "编号";
            this.PosID.FieldName = "ID";
            this.PosID.Name = "PosID";
            this.PosID.ToolTip = "职位编号";
            this.PosID.Visible = true;
            this.PosID.VisibleIndex = 0;
            this.PosID.Width = 50;
            // 
            // PosName
            // 
            this.PosName.Caption = "职位名称";
            this.PosName.FieldName = "Name";
            this.PosName.Name = "PosName";
            this.PosName.ToolTip = "职位名称";
            this.PosName.Visible = true;
            this.PosName.VisibleIndex = 1;
            this.PosName.Width = 70;
            // 
            // PosDescription
            // 
            this.PosDescription.Caption = "描述";
            this.PosDescription.FieldName = "Description";
            this.PosDescription.Name = "PosDescription";
            this.PosDescription.ToolTip = "描述";
            this.PosDescription.Visible = true;
            this.PosDescription.VisibleIndex = 2;
            this.PosDescription.Width = 180;
            // 
            // PosCreatePerson
            // 
            this.PosCreatePerson.Caption = "创建人";
            this.PosCreatePerson.FieldName = "CreatePerson";
            this.PosCreatePerson.Name = "PosCreatePerson";
            this.PosCreatePerson.ToolTip = "创建人";
            this.PosCreatePerson.Visible = true;
            this.PosCreatePerson.VisibleIndex = 3;
            this.PosCreatePerson.Width = 70;
            // 
            // PosCreateDate
            // 
            this.PosCreateDate.Caption = "创建时间";
            this.PosCreateDate.DisplayFormat.FormatString = "g";
            this.PosCreateDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.PosCreateDate.FieldName = "CreateDate";
            this.PosCreateDate.Name = "PosCreateDate";
            this.PosCreateDate.ToolTip = "创建时间";
            this.PosCreateDate.Visible = true;
            this.PosCreateDate.VisibleIndex = 4;
            this.PosCreateDate.Width = 120;
            // 
            // PosModifyPerson
            // 
            this.PosModifyPerson.Caption = "修改(&U)人";
            this.PosModifyPerson.FieldName = "ModifyPerson";
            this.PosModifyPerson.Name = "PosModifyPerson";
            this.PosModifyPerson.ToolTip = "修改(&U)人";
            this.PosModifyPerson.Visible = true;
            this.PosModifyPerson.VisibleIndex = 5;
            this.PosModifyPerson.Width = 70;
            // 
            // PosModifyDate
            // 
            this.PosModifyDate.Caption = "修改(&U)时间";
            this.PosModifyDate.DisplayFormat.FormatString = "g";
            this.PosModifyDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.PosModifyDate.FieldName = "ModifyDate";
            this.PosModifyDate.Name = "PosModifyDate";
            this.PosModifyDate.ToolTip = "修改(&U)时间";
            this.PosModifyDate.Visible = true;
            this.PosModifyDate.VisibleIndex = 6;
            this.PosModifyDate.Width = 120;
            // 
            // btnOutPos
            // 
            this.btnOutPos.Location = new System.Drawing.Point(34, 210);
            this.btnOutPos.Name = "btnOutPos";
            this.btnOutPos.Size = new System.Drawing.Size(63, 30);
            this.btnOutPos.TabIndex = 10;
            this.btnOutPos.Text = "导出(&S)";
            this.btnOutPos.ToolTip = "导出职位信息(Alt+S)";
            this.btnOutPos.Click += new System.EventHandler(this.btnOutPos_Click);
            // 
            // btnPrintPos
            // 
            this.btnPrintPos.Location = new System.Drawing.Point(34, 166);
            this.btnPrintPos.Name = "btnPrintPos";
            this.btnPrintPos.Size = new System.Drawing.Size(61, 30);
            this.btnPrintPos.TabIndex = 9;
            this.btnPrintPos.Text = "打印(&R)";
            this.btnPrintPos.ToolTip = "打印职位信息(Alt+R)";
            this.btnPrintPos.Click += new System.EventHandler(this.btnPrintPos_Click);
            // 
            // btnDeletePos
            // 
            this.btnDeletePos.Location = new System.Drawing.Point(32, 122);
            this.btnDeletePos.Name = "btnDeletePos";
            this.btnDeletePos.Size = new System.Drawing.Size(63, 30);
            this.btnDeletePos.TabIndex = 8;
            this.btnDeletePos.Text = "删除(&E)";
            this.btnDeletePos.ToolTip = "删除职位(Alt+E)";
            this.btnDeletePos.Click += new System.EventHandler(this.btnDeletePos_Click);
            // 
            // btnUpdatePos
            // 
            this.btnUpdatePos.Location = new System.Drawing.Point(32, 78);
            this.btnUpdatePos.Name = "btnUpdatePos";
            this.btnUpdatePos.Size = new System.Drawing.Size(63, 30);
            this.btnUpdatePos.TabIndex = 7;
            this.btnUpdatePos.Text = "修改(&T)";
            this.btnUpdatePos.ToolTip = "修改职位信息(Alt+T)";
            this.btnUpdatePos.Click += new System.EventHandler(this.btnUpdatePos_Click);
            // 
            // btnAddPos
            // 
            this.btnAddPos.Location = new System.Drawing.Point(32, 34);
            this.btnAddPos.Name = "btnAddPos";
            this.btnAddPos.Size = new System.Drawing.Size(63, 30);
            this.btnAddPos.TabIndex = 6;
            this.btnAddPos.Text = "添加(&B)";
            this.btnAddPos.ToolTip = "添加新职位(Alt+B)";
            this.btnAddPos.Click += new System.EventHandler(this.btnAddPos_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnAddDep);
            this.groupControl1.Controls.Add(this.btnOutDep);
            this.groupControl1.Controls.Add(this.btnUpdateDep);
            this.groupControl1.Controls.Add(this.btnPrintDep);
            this.groupControl1.Controls.Add(this.btnDeleteDep);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(557, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(116, 250);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "操作";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnOutPos);
            this.groupControl2.Controls.Add(this.btnAddPos);
            this.groupControl2.Controls.Add(this.btnDeletePos);
            this.groupControl2.Controls.Add(this.btnPrintPos);
            this.groupControl2.Controls.Add(this.btnUpdatePos);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(555, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(118, 255);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "操作";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.groupControl1);
            this.groupControl3.Controls.Add(this.groupControlDep);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.ShowCaption = false;
            this.groupControl3.Size = new System.Drawing.Size(675, 254);
            this.groupControl3.TabIndex = 8;
            this.groupControl3.Text = "部门管理";
            // 
            // groupControlPosition
            // 
            this.groupControlPosition.Controls.Add(this.groupControl2);
            this.groupControlPosition.Controls.Add(this.groupControlPos);
            this.groupControlPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlPosition.Location = new System.Drawing.Point(0, 254);
            this.groupControlPosition.Name = "groupControlPosition";
            this.groupControlPosition.ShowCaption = false;
            this.groupControlPosition.Size = new System.Drawing.Size(675, 259);
            this.groupControlPosition.TabIndex = 9;
            this.groupControlPosition.Text = "职位管理";
            // 
            // frmSetEmployeeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 513);
            this.Controls.Add(this.groupControlPosition);
            this.Controls.Add(this.groupControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSetEmployeeInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工信息设置";
            this.Load += new System.EventHandler(this.frmSetEmployeeInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDep)).EndInit();
            this.groupControlDep.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlPos)).EndInit();
            this.groupControlPos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlPosition)).EndInit();
            this.groupControlPosition.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlDep;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDep;
        private DevExpress.XtraEditors.GroupControl groupControlDep;
        private DevExpress.XtraEditors.GroupControl groupControlPos;
        private DevExpress.XtraGrid.GridControl gridControlPos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPos;
        private DevExpress.XtraGrid.Columns.GridColumn DepID;
        private DevExpress.XtraGrid.Columns.GridColumn DepName;
        private DevExpress.XtraGrid.Columns.GridColumn DepDescription;
        private DevExpress.XtraGrid.Columns.GridColumn DepCreatePerson;
        private DevExpress.XtraGrid.Columns.GridColumn DepCreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn DepModifyPerson;
        private DevExpress.XtraGrid.Columns.GridColumn DepModifyDate;
        private DevExpress.XtraGrid.Columns.GridColumn PosID;
        private DevExpress.XtraGrid.Columns.GridColumn PosName;
        private DevExpress.XtraGrid.Columns.GridColumn PosDescription;
        private DevExpress.XtraGrid.Columns.GridColumn PosCreatePerson;
        private DevExpress.XtraGrid.Columns.GridColumn PosCreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn PosModifyPerson;
        private DevExpress.XtraGrid.Columns.GridColumn PosModifyDate;
        private DevExpress.XtraEditors.SimpleButton btnDeleteDep;
        private DevExpress.XtraEditors.SimpleButton btnUpdateDep;
        private DevExpress.XtraEditors.SimpleButton btnAddDep;
        private DevExpress.XtraEditors.SimpleButton btnOutDep;
        private DevExpress.XtraEditors.SimpleButton btnPrintDep;
        private DevExpress.XtraEditors.SimpleButton btnOutPos;
        private DevExpress.XtraEditors.SimpleButton btnPrintPos;
        private DevExpress.XtraEditors.SimpleButton btnDeletePos;
        private DevExpress.XtraEditors.SimpleButton btnUpdatePos;
        private DevExpress.XtraEditors.SimpleButton btnAddPos;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControlPosition;
    }
}