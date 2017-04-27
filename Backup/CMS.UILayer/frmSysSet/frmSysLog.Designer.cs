namespace CMS.UILayer.frmSysSet
{
    partial class frmSysLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSysLog));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dateEnd = new DevExpress.XtraEditors.DateEdit();
            this.lblFrom = new DevExpress.XtraEditors.LabelControl();
            this.dateStart = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtLogTime = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlSysLog = new DevExpress.XtraGrid.GridControl();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LogID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LogType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OperatorPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RecordDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnAll = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOut = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.lupOperatorID = new DevExpress.XtraEditors.LookUpEdit();
            this.lupLogType = new DevExpress.XtraEditors.LookUpEdit();
            this.txtLogID = new DevExpress.XtraEditors.MRUEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmbField = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtOperator = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.memoDescription = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtType = new DevExpress.XtraEditors.TextEdit();
            this.popupMenuLog = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barBtnAll = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDel = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnClear = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnOut = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.barManagerLog = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSysLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lupOperatorID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupLogType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbField.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOperator.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerLog)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "日志类型：";
            // 
            // dateEnd
            // 
            this.dateEnd.EditValue = new System.DateTime(2013, 2, 5, 0, 0, 0, 0);
            this.dateEnd.Location = new System.Drawing.Point(552, 40);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEnd.Properties.DisplayFormat.FormatString = "D";
            this.dateEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEnd.Properties.EditFormat.FormatString = "D";
            this.dateEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEnd.Properties.Mask.EditMask = "D";
            this.dateEnd.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEnd.Size = new System.Drawing.Size(218, 21);
            this.dateEnd.TabIndex = 47;
            // 
            // lblFrom
            // 
            this.lblFrom.Location = new System.Drawing.Point(534, 43);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(12, 14);
            this.lblFrom.TabIndex = 46;
            this.lblFrom.Text = "至";
            // 
            // dateStart
            // 
            this.dateStart.EditValue = new System.DateTime(2013, 1, 25, 0, 0, 0, 0);
            this.dateStart.Location = new System.Drawing.Point(310, 40);
            this.dateStart.Name = "dateStart";
            this.dateStart.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dateStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStart.Properties.DisplayFormat.FormatString = "D";
            this.dateStart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateStart.Properties.EditFormat.FormatString = "D";
            this.dateStart.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateStart.Properties.Mask.EditMask = "D";
            this.dateStart.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateStart.Size = new System.Drawing.Size(218, 21);
            this.dateStart.TabIndex = 45;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(244, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 44;
            this.labelControl2.Text = "第二条件：";
            // 
            // txtLogTime
            // 
            this.txtLogTime.Location = new System.Drawing.Point(653, 35);
            this.txtLogTime.Name = "txtLogTime";
            this.txtLogTime.Properties.MaxLength = 500;
            this.txtLogTime.Properties.ReadOnly = true;
            this.txtLogTime.Size = new System.Drawing.Size(256, 21);
            this.txtLogTime.TabIndex = 44;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(587, 38);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(60, 14);
            this.labelControl11.TabIndex = 39;
            this.labelControl11.Text = "记录时间：";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlSysLog);
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(934, 447);
            this.groupControl1.TabIndex = 24;
            // 
            // gridControlSysLog
            // 
            this.gridControlSysLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSysLog.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlSysLog.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlSysLog.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlSysLog.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlSysLog.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlSysLog.Location = new System.Drawing.Point(2, 138);
            this.gridControlSysLog.MainView = this.gridViewMain;
            this.gridControlSysLog.Name = "gridControlSysLog";
            this.gridControlSysLog.Size = new System.Drawing.Size(930, 307);
            this.gridControlSysLog.TabIndex = 53;
            this.gridControlSysLog.UseEmbeddedNavigator = true;
            this.gridControlSysLog.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            this.gridControlSysLog.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridControlSysLog_MouseUp);
            // 
            // gridViewMain
            // 
            this.gridViewMain.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewMain.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewMain.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewMain.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gridViewMain.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridViewMain.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridViewMain.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridViewMain.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewMain.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gridViewMain.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewMain.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gridViewMain.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridViewMain.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridViewMain.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridViewMain.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewMain.Appearance.Empty.Options.UseBackColor = true;
            this.gridViewMain.Appearance.EvenRow.BackColor = System.Drawing.Color.Silver;
            this.gridViewMain.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.gridViewMain.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewMain.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewMain.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridViewMain.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridViewMain.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMain.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.gridViewMain.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMain.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewMain.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewMain.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridViewMain.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridViewMain.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridViewMain.Appearance.FilterPanel.BackColor = System.Drawing.Color.Black;
            this.gridViewMain.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMain.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewMain.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewMain.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridViewMain.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridViewMain.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gridViewMain.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridViewMain.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gridViewMain.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Purple;
            this.gridViewMain.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridViewMain.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridViewMain.Appearance.FocusedRow.BackColor = System.Drawing.Color.Purple;
            this.gridViewMain.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(50)))), ((int)(((byte)(178)))));
            this.gridViewMain.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewMain.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewMain.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewMain.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.gridViewMain.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridViewMain.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewMain.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridViewMain.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridViewMain.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewMain.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewMain.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewMain.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewMain.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridViewMain.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridViewMain.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridViewMain.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewMain.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewMain.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridViewMain.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridViewMain.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridViewMain.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridViewMain.Appearance.GroupPanel.BackColor = System.Drawing.Color.Black;
            this.gridViewMain.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridViewMain.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewMain.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewMain.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewMain.Appearance.GroupPanel.Options.UseFont = true;
            this.gridViewMain.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridViewMain.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewMain.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.gridViewMain.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridViewMain.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridViewMain.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gridViewMain.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridViewMain.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewMain.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewMain.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewMain.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridViewMain.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewMain.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewMain.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewMain.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMain.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewMain.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewMain.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewMain.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridViewMain.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridViewMain.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gridViewMain.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewMain.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gridViewMain.Appearance.OddRow.Options.UseBackColor = true;
            this.gridViewMain.Appearance.OddRow.Options.UseForeColor = true;
            this.gridViewMain.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.gridViewMain.Appearance.Preview.BackColor2 = System.Drawing.Color.White;
            this.gridViewMain.Appearance.Preview.ForeColor = System.Drawing.Color.Purple;
            this.gridViewMain.Appearance.Preview.Options.UseBackColor = true;
            this.gridViewMain.Appearance.Preview.Options.UseForeColor = true;
            this.gridViewMain.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridViewMain.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridViewMain.Appearance.Row.Options.UseBackColor = true;
            this.gridViewMain.Appearance.Row.Options.UseForeColor = true;
            this.gridViewMain.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridViewMain.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewMain.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridViewMain.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(10)))), ((int)(((byte)(138)))));
            this.gridViewMain.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewMain.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewMain.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewMain.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewMain.Appearance.VertLine.Options.UseBackColor = true;
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.LogID,
            this.LogType,
            this.OperatorPerson,
            this.Description,
            this.RecordDate});
            this.gridViewMain.GridControl = this.gridControlSysLog;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewMain.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewMain.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewMain.OptionsBehavior.Editable = false;
            this.gridViewMain.OptionsPrint.EnableAppearanceOddRow = true;
            this.gridViewMain.OptionsPrint.ExpandAllDetails = true;
            this.gridViewMain.OptionsPrint.PrintDetails = true;
            this.gridViewMain.OptionsPrint.PrintFilterInfo = true;
            this.gridViewMain.OptionsPrint.PrintPreview = true;
            this.gridViewMain.OptionsPrint.UsePrintStyles = true;
            this.gridViewMain.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewMain.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gridViewMain.OptionsSelection.MultiSelect = true;
            this.gridViewMain.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewMain.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewMain.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.RecordDate, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridViewMain.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridViewMain_SelectionChanged);
            this.gridViewMain.DoubleClick += new System.EventHandler(this.gridViewMain_DoubleClick);
            // 
            // LogID
            // 
            this.LogID.Caption = "日志编号";
            this.LogID.FieldName = "日志编号";
            this.LogID.Name = "LogID";
            this.LogID.OptionsColumn.AllowEdit = false;
            this.LogID.ToolTip = "日志编号";
            this.LogID.Visible = true;
            this.LogID.VisibleIndex = 0;
            // 
            // LogType
            // 
            this.LogType.Caption = "日志类型";
            this.LogType.FieldName = "日志类型";
            this.LogType.Name = "LogType";
            this.LogType.ToolTip = "日志类型";
            this.LogType.Visible = true;
            this.LogType.VisibleIndex = 1;
            // 
            // OperatorPerson
            // 
            this.OperatorPerson.Caption = "操作员";
            this.OperatorPerson.FieldName = "操作员";
            this.OperatorPerson.Name = "OperatorPerson";
            this.OperatorPerson.ToolTip = "操作员";
            this.OperatorPerson.Visible = true;
            this.OperatorPerson.VisibleIndex = 3;
            // 
            // Description
            // 
            this.Description.Caption = "记录描述";
            this.Description.FieldName = "记录描述";
            this.Description.Name = "Description";
            this.Description.ToolTip = "记录描述";
            this.Description.Visible = true;
            this.Description.VisibleIndex = 2;
            // 
            // RecordDate
            // 
            this.RecordDate.Caption = "记录时间";
            this.RecordDate.DisplayFormat.FormatString = "g";
            this.RecordDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.RecordDate.FieldName = "记录时间";
            this.RecordDate.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange;
            this.RecordDate.Name = "RecordDate";
            this.RecordDate.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.DateSmart;
            this.RecordDate.ToolTip = "记录时间";
            this.RecordDate.Visible = true;
            this.RecordDate.VisibleIndex = 4;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.groupControl4);
            this.groupControl3.Controls.Add(this.btnSearch);
            this.groupControl3.Controls.Add(this.lupOperatorID);
            this.groupControl3.Controls.Add(this.lupLogType);
            this.groupControl3.Controls.Add(this.txtLogID);
            this.groupControl3.Controls.Add(this.labelControl4);
            this.groupControl3.Controls.Add(this.cmbField);
            this.groupControl3.Controls.Add(this.dateEnd);
            this.groupControl3.Controls.Add(this.labelControl2);
            this.groupControl3.Controls.Add(this.lblFrom);
            this.groupControl3.Controls.Add(this.dateStart);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl3.Location = new System.Drawing.Point(2, 2);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(930, 136);
            this.groupControl3.TabIndex = 52;
            this.groupControl3.Text = "日志查询";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.btnPrint);
            this.groupControl4.Controls.Add(this.btnAll);
            this.groupControl4.Controls.Add(this.BtnDel);
            this.groupControl4.Controls.Add(this.btnOut);
            this.groupControl4.Controls.Add(this.btnClear);
            this.groupControl4.Controls.Add(this.btnBack);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl4.Location = new System.Drawing.Point(2, 85);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.ShowCaption = false;
            this.groupControl4.Size = new System.Drawing.Size(926, 49);
            this.groupControl4.TabIndex = 58;
            this.groupControl4.Text = "groupControl4";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(641, 11);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 30);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "打印(&P)";
            this.btnPrint.ToolTip = "打印日志信息(Alt+P)";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(792, 11);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(75, 30);
            this.btnAll.TabIndex = 57;
            this.btnAll.Text = "全部(&A)";
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(188, 11);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(75, 30);
            this.BtnDel.TabIndex = 0;
            this.BtnDel.Text = "删除(&D)";
            this.BtnDel.ToolTip = "删除选中的日志信息(Alt+D)";
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(490, 11);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(75, 30);
            this.btnOut.TabIndex = 2;
            this.btnOut.Text = "导出(&O)";
            this.btnOut.ToolTip = "导出日志信息(Alt+O)";
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(339, 11);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 30);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "清空(&C)";
            this.btnClear.ToolTip = "删除(&D)所有的日志信息(Alt+C)";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(37, 11);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 30);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "返回(&B)";
            this.btnBack.ToolTip = "返回系统主界面(Alt+B)";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(796, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 56;
            this.btnSearch.Text = "查找(&S)";
            this.btnSearch.ToolTip = "查找满足条件的日志记录(Alt+S/Enter)";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lupOperatorID
            // 
            this.lupOperatorID.Location = new System.Drawing.Point(310, 40);
            this.lupOperatorID.Name = "lupOperatorID";
            this.lupOperatorID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupOperatorID.Size = new System.Drawing.Size(218, 21);
            this.lupOperatorID.TabIndex = 55;
            // 
            // lupLogType
            // 
            this.lupLogType.Location = new System.Drawing.Point(310, 40);
            this.lupLogType.Name = "lupLogType";
            this.lupLogType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupLogType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("日志类型", "TypeName")});
            this.lupLogType.Properties.DisplayMember = "日志类型";
            this.lupLogType.Properties.ShowHeader = false;
            this.lupLogType.Size = new System.Drawing.Size(218, 21);
            this.lupLogType.TabIndex = 55;
            // 
            // txtLogID
            // 
            this.txtLogID.Location = new System.Drawing.Point(310, 40);
            this.txtLogID.Name = "txtLogID";
            this.txtLogID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtLogID.Size = new System.Drawing.Size(218, 21);
            this.txtLogID.TabIndex = 54;
            this.txtLogID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLogID_KeyDown);
            this.txtLogID.TextChanged += new System.EventHandler(this.txtLogID_TextChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(39, 43);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 14);
            this.labelControl4.TabIndex = 50;
            this.labelControl4.Text = "按：";
            // 
            // cmbField
            // 
            this.cmbField.EditValue = "记录时间";
            this.cmbField.Location = new System.Drawing.Point(69, 40);
            this.cmbField.Name = "cmbField";
            this.cmbField.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbField.Properties.Items.AddRange(new object[] {
            "日志编号",
            "日志类型",
            "操作员",
            "记录时间"});
            this.cmbField.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbField.Size = new System.Drawing.Size(152, 21);
            this.cmbField.TabIndex = 51;
            this.cmbField.SelectedIndexChanged += new System.EventHandler(this.cmbField_SelectedIndexChanged);
            // 
            // txtOperator
            // 
            this.txtOperator.Location = new System.Drawing.Point(334, 35);
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Properties.MaxLength = 500;
            this.txtOperator.Properties.ReadOnly = true;
            this.txtOperator.Size = new System.Drawing.Size(153, 21);
            this.txtOperator.TabIndex = 38;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(280, 38);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(48, 14);
            this.labelControl12.TabIndex = 37;
            this.labelControl12.Text = "操作员：";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.memoDescription);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.txtOperator);
            this.groupControl2.Controls.Add(this.labelControl12);
            this.groupControl2.Controls.Add(this.txtLogTime);
            this.groupControl2.Controls.Add(this.labelControl11);
            this.groupControl2.Controls.Add(this.txtType);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 447);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(934, 132);
            this.groupControl2.TabIndex = 22;
            this.groupControl2.Text = "详细信息";
            // 
            // memoDescription
            // 
            this.memoDescription.Location = new System.Drawing.Point(80, 67);
            this.memoDescription.Name = "memoDescription";
            this.memoDescription.Properties.ReadOnly = true;
            this.memoDescription.Size = new System.Drawing.Size(829, 43);
            this.memoDescription.TabIndex = 45;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(14, 69);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 14);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "记录描述：";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(14, 38);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 14);
            this.labelControl5.TabIndex = 37;
            this.labelControl5.Text = "日志类型：";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(80, 35);
            this.txtType.Name = "txtType";
            this.txtType.Properties.MaxLength = 500;
            this.txtType.Properties.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(153, 21);
            this.txtType.TabIndex = 38;
            // 
            // popupMenuLog
            // 
            this.popupMenuLog.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnAll),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnDel, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnClear),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnOut),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnPrint)});
            this.popupMenuLog.Manager = this.barManagerLog;
            this.popupMenuLog.Name = "popupMenuLog";
            // 
            // barBtnAll
            // 
            this.barBtnAll.Caption = "全部(&A)";
            this.barBtnAll.Id = 4;
            this.barBtnAll.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A));
            this.barBtnAll.Name = "barBtnAll";
            this.barBtnAll.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAll_ItemClick);
            // 
            // barBtnDel
            // 
            this.barBtnDel.Caption = "删除(&D)(&D)";
            this.barBtnDel.Id = 0;
            this.barBtnDel.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D));
            this.barBtnDel.Name = "barBtnDel";
            this.barBtnDel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDel_ItemClick);
            // 
            // barBtnClear
            // 
            this.barBtnClear.Caption = "清空(&C)";
            this.barBtnClear.Id = 1;
            this.barBtnClear.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C));
            this.barBtnClear.Name = "barBtnClear";
            this.barBtnClear.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnClear_ItemClick);
            // 
            // barBtnOut
            // 
            this.barBtnOut.Caption = "导出(&O)(&O)";
            this.barBtnOut.Id = 2;
            this.barBtnOut.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O));
            this.barBtnOut.Name = "barBtnOut";
            this.barBtnOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnOut_ItemClick);
            // 
            // barBtnPrint
            // 
            this.barBtnPrint.Caption = "打印(&P)(&P)";
            this.barBtnPrint.Id = 3;
            this.barBtnPrint.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
            this.barBtnPrint.Name = "barBtnPrint";
            this.barBtnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnPrint_ItemClick);
            // 
            // barManagerLog
            // 
            this.barManagerLog.DockControls.Add(this.barDockControlTop);
            this.barManagerLog.DockControls.Add(this.barDockControlBottom);
            this.barManagerLog.DockControls.Add(this.barDockControlLeft);
            this.barManagerLog.DockControls.Add(this.barDockControlRight);
            this.barManagerLog.Form = this;
            this.barManagerLog.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnDel,
            this.barBtnClear,
            this.barBtnOut,
            this.barBtnPrint,
            this.barBtnAll});
            this.barManagerLog.MaxItemId = 5;
            // 
            // frmSysLog
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(934, 579);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSysLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统日志";
            this.Load += new System.EventHandler(this.frmSysLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSysLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lupOperatorID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupLogType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbField.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOperator.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dateEnd;
        private DevExpress.XtraEditors.LabelControl lblFrom;
        private DevExpress.XtraEditors.DateEdit dateStart;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtLogTime;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtOperator;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cmbField;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl gridControlSysLog;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraGrid.Columns.GridColumn LogID;
        private DevExpress.XtraGrid.Columns.GridColumn LogType;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
        private DevExpress.XtraGrid.Columns.GridColumn OperatorPerson;
        private DevExpress.XtraGrid.Columns.GridColumn RecordDate;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.TextEdit txtType;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit lupOperatorID;
        private DevExpress.XtraEditors.LookUpEdit lupLogType;
        private DevExpress.XtraEditors.MRUEdit txtLogID;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnOut;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton BtnDel;
        private DevExpress.XtraEditors.MemoEdit memoDescription;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraBars.PopupMenu popupMenuLog;
        private DevExpress.XtraEditors.SimpleButton btnAll;
        private DevExpress.XtraBars.BarButtonItem barBtnAll;
        private DevExpress.XtraBars.BarButtonItem barBtnDel;
        private DevExpress.XtraBars.BarButtonItem barBtnClear;
        private DevExpress.XtraBars.BarButtonItem barBtnOut;
        private DevExpress.XtraBars.BarButtonItem barBtnPrint;
        private DevExpress.XtraBars.BarManager barManagerLog;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.GroupControl groupControl4;
    }
}