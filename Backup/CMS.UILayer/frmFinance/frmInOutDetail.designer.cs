namespace CMS.UILayer.frmFinance
{
    partial class frmInOutDetail
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
            this.grdctrInOutDetail = new DevExpress.XtraGrid.GridControl();
            this.gridViewInOutDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InOutName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Amount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HandlePeople = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InfoNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreatePerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ModifyPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ModifyDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnSelectAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnOut = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.EditSecSelcCondition = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtNumAndAmount = new DevExpress.XtraEditors.TextEdit();
            this.btnSelect = new DevExpress.XtraEditors.SimpleButton();
            this.cmbSelectCondition = new DevExpress.XtraEditors.ComboBoxEdit();
            this.mruEditType = new DevExpress.XtraEditors.MRUEdit();
            this.dateEditCEnd = new DevExpress.XtraEditors.DateEdit();
            this.dateEditCStart = new DevExpress.XtraEditors.DateEdit();
            this.lblCome = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grdctrInOutDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInOutDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditSecSelcCondition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumAndAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSelectCondition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mruEditType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditCEnd.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditCEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditCStart.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditCStart.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdctrInOutDetail
            // 
            this.grdctrInOutDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdctrInOutDetail.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grdctrInOutDetail.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grdctrInOutDetail.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grdctrInOutDetail.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grdctrInOutDetail.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grdctrInOutDetail.Location = new System.Drawing.Point(0, 122);
            this.grdctrInOutDetail.MainView = this.gridViewInOutDetail;
            this.grdctrInOutDetail.Name = "grdctrInOutDetail";
            this.grdctrInOutDetail.Size = new System.Drawing.Size(902, 394);
            this.grdctrInOutDetail.TabIndex = 26;
            this.grdctrInOutDetail.UseEmbeddedNavigator = true;
            this.grdctrInOutDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewInOutDetail});
            // 
            // gridViewInOutDetail
            // 
            this.gridViewInOutDetail.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewInOutDetail.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewInOutDetail.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewInOutDetail.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gridViewInOutDetail.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridViewInOutDetail.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridViewInOutDetail.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridViewInOutDetail.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewInOutDetail.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gridViewInOutDetail.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewInOutDetail.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gridViewInOutDetail.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridViewInOutDetail.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridViewInOutDetail.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridViewInOutDetail.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewInOutDetail.Appearance.Empty.Options.UseBackColor = true;
            this.gridViewInOutDetail.Appearance.EvenRow.BackColor = System.Drawing.Color.Silver;
            this.gridViewInOutDetail.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.gridViewInOutDetail.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewInOutDetail.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewInOutDetail.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridViewInOutDetail.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridViewInOutDetail.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewInOutDetail.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.gridViewInOutDetail.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewInOutDetail.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewInOutDetail.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewInOutDetail.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridViewInOutDetail.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridViewInOutDetail.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridViewInOutDetail.Appearance.FilterPanel.BackColor = System.Drawing.Color.Black;
            this.gridViewInOutDetail.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewInOutDetail.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewInOutDetail.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewInOutDetail.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridViewInOutDetail.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridViewInOutDetail.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gridViewInOutDetail.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridViewInOutDetail.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gridViewInOutDetail.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Purple;
            this.gridViewInOutDetail.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridViewInOutDetail.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridViewInOutDetail.Appearance.FocusedRow.BackColor = System.Drawing.Color.Purple;
            this.gridViewInOutDetail.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(50)))), ((int)(((byte)(178)))));
            this.gridViewInOutDetail.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewInOutDetail.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewInOutDetail.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewInOutDetail.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.gridViewInOutDetail.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridViewInOutDetail.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewInOutDetail.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridViewInOutDetail.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridViewInOutDetail.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewInOutDetail.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewInOutDetail.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewInOutDetail.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewInOutDetail.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridViewInOutDetail.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridViewInOutDetail.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridViewInOutDetail.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewInOutDetail.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewInOutDetail.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridViewInOutDetail.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridViewInOutDetail.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridViewInOutDetail.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridViewInOutDetail.Appearance.GroupPanel.BackColor = System.Drawing.Color.Black;
            this.gridViewInOutDetail.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridViewInOutDetail.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewInOutDetail.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewInOutDetail.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewInOutDetail.Appearance.GroupPanel.Options.UseFont = true;
            this.gridViewInOutDetail.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridViewInOutDetail.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewInOutDetail.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.gridViewInOutDetail.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridViewInOutDetail.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridViewInOutDetail.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gridViewInOutDetail.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridViewInOutDetail.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewInOutDetail.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewInOutDetail.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewInOutDetail.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridViewInOutDetail.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewInOutDetail.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewInOutDetail.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewInOutDetail.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewInOutDetail.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewInOutDetail.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewInOutDetail.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewInOutDetail.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridViewInOutDetail.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridViewInOutDetail.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gridViewInOutDetail.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewInOutDetail.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gridViewInOutDetail.Appearance.OddRow.Options.UseBackColor = true;
            this.gridViewInOutDetail.Appearance.OddRow.Options.UseForeColor = true;
            this.gridViewInOutDetail.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.gridViewInOutDetail.Appearance.Preview.BackColor2 = System.Drawing.Color.White;
            this.gridViewInOutDetail.Appearance.Preview.ForeColor = System.Drawing.Color.Purple;
            this.gridViewInOutDetail.Appearance.Preview.Options.UseBackColor = true;
            this.gridViewInOutDetail.Appearance.Preview.Options.UseForeColor = true;
            this.gridViewInOutDetail.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridViewInOutDetail.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridViewInOutDetail.Appearance.Row.Options.UseBackColor = true;
            this.gridViewInOutDetail.Appearance.Row.Options.UseForeColor = true;
            this.gridViewInOutDetail.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridViewInOutDetail.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewInOutDetail.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridViewInOutDetail.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(10)))), ((int)(((byte)(138)))));
            this.gridViewInOutDetail.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewInOutDetail.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewInOutDetail.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewInOutDetail.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewInOutDetail.Appearance.VertLine.Options.UseBackColor = true;
            this.gridViewInOutDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.InOutName,
            this.Type,
            this.Amount,
            this.HandlePeople,
            this.InfoNote,
            this.CreatePerson,
            this.CreateDate,
            this.ModifyPerson,
            this.ModifyDate});
            this.gridViewInOutDetail.GridControl = this.grdctrInOutDetail;
            this.gridViewInOutDetail.Name = "gridViewInOutDetail";
            this.gridViewInOutDetail.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewInOutDetail.OptionsBehavior.Editable = false;
            this.gridViewInOutDetail.OptionsPrint.EnableAppearanceOddRow = true;
            this.gridViewInOutDetail.OptionsPrint.ExpandAllDetails = true;
            this.gridViewInOutDetail.OptionsPrint.PrintDetails = true;
            this.gridViewInOutDetail.OptionsPrint.PrintFilterInfo = true;
            this.gridViewInOutDetail.OptionsPrint.PrintSelectedRowsOnly = true;
            this.gridViewInOutDetail.OptionsPrint.UsePrintStyles = true;
            this.gridViewInOutDetail.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewInOutDetail.OptionsView.ColumnAutoWidth = false;
            this.gridViewInOutDetail.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewInOutDetail.OptionsView.EnableAppearanceOddRow = true;
            // 
            // ID
            // 
            this.ID.AppearanceCell.Options.UseTextOptions = true;
            this.ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ID.Caption = "编号";
            this.ID.FieldName = "编号";
            this.ID.Name = "ID";
            this.ID.ToolTip = "财务记录编号";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 49;
            // 
            // InOutName
            // 
            this.InOutName.AppearanceCell.Options.UseTextOptions = true;
            this.InOutName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.InOutName.Caption = "收支名称";
            this.InOutName.FieldName = "名称";
            this.InOutName.Name = "InOutName";
            this.InOutName.ToolTip = "收支项目类型";
            this.InOutName.Visible = true;
            this.InOutName.VisibleIndex = 1;
            this.InOutName.Width = 76;
            // 
            // Type
            // 
            this.Type.Caption = "收支类型";
            this.Type.FieldName = "类型";
            this.Type.Name = "Type";
            this.Type.ToolTip = "收支类型";
            this.Type.Visible = true;
            this.Type.VisibleIndex = 2;
            this.Type.Width = 68;
            // 
            // Amount
            // 
            this.Amount.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Amount.AppearanceCell.Options.UseBackColor = true;
            this.Amount.Caption = "金额";
            this.Amount.DisplayFormat.FormatString = "c";
            this.Amount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Amount.FieldName = "金额";
            this.Amount.Name = "Amount";
            this.Amount.ToolTip = "金额";
            this.Amount.Visible = true;
            this.Amount.VisibleIndex = 3;
            this.Amount.Width = 77;
            // 
            // HandlePeople
            // 
            this.HandlePeople.Caption = "经手人";
            this.HandlePeople.FieldName = "经手人";
            this.HandlePeople.Name = "HandlePeople";
            this.HandlePeople.ToolTip = "经手人";
            this.HandlePeople.Visible = true;
            this.HandlePeople.VisibleIndex = 4;
            this.HandlePeople.Width = 71;
            // 
            // InfoNote
            // 
            this.InfoNote.Caption = "信息备注";
            this.InfoNote.FieldName = "信息备注";
            this.InfoNote.Name = "InfoNote";
            this.InfoNote.ToolTip = "信息备注";
            this.InfoNote.Visible = true;
            this.InfoNote.VisibleIndex = 5;
            this.InfoNote.Width = 240;
            // 
            // CreatePerson
            // 
            this.CreatePerson.Caption = "创建人";
            this.CreatePerson.FieldName = "创建人";
            this.CreatePerson.Name = "CreatePerson";
            this.CreatePerson.ToolTip = "创建人";
            this.CreatePerson.Visible = true;
            this.CreatePerson.VisibleIndex = 6;
            this.CreatePerson.Width = 62;
            // 
            // CreateDate
            // 
            this.CreateDate.Caption = "创建时间";
            this.CreateDate.DisplayFormat.FormatString = "g";
            this.CreateDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.CreateDate.FieldName = "创建时间";
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ToolTip = "创建时间";
            this.CreateDate.Visible = true;
            this.CreateDate.VisibleIndex = 7;
            this.CreateDate.Width = 114;
            // 
            // ModifyPerson
            // 
            this.ModifyPerson.Caption = "修改人";
            this.ModifyPerson.FieldName = "修改人";
            this.ModifyPerson.Name = "ModifyPerson";
            this.ModifyPerson.ToolTip = "修改人";
            this.ModifyPerson.Visible = true;
            this.ModifyPerson.VisibleIndex = 8;
            this.ModifyPerson.Width = 64;
            // 
            // ModifyDate
            // 
            this.ModifyDate.Caption = "修改时间";
            this.ModifyDate.DisplayFormat.FormatString = "g";
            this.ModifyDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ModifyDate.FieldName = "修改时间";
            this.ModifyDate.Name = "ModifyDate";
            this.ModifyDate.ToolTip = "修改时间";
            this.ModifyDate.Visible = true;
            this.ModifyDate.VisibleIndex = 9;
            this.ModifyDate.Width = 132;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnBack);
            this.groupControl1.Controls.Add(this.btnSelectAll);
            this.groupControl1.Controls.Add(this.btnOut);
            this.groupControl1.Controls.Add(this.btnPrint);
            this.groupControl1.Controls.Add(this.EditSecSelcCondition);
            this.groupControl1.Controls.Add(this.txtNumAndAmount);
            this.groupControl1.Controls.Add(this.btnSelect);
            this.groupControl1.Controls.Add(this.cmbSelectCondition);
            this.groupControl1.Controls.Add(this.mruEditType);
            this.groupControl1.Controls.Add(this.dateEditCEnd);
            this.groupControl1.Controls.Add(this.dateEditCStart);
            this.groupControl1.Controls.Add(this.lblCome);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(902, 122);
            this.groupControl1.TabIndex = 27;
            this.groupControl1.Text = "查询区";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(25, 74);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 30);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "返回(&B)";
            this.btnBack.ToolTip = "返回系统主界面(Alt+B/Esc)";
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(772, 74);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 30);
            this.btnSelectAll.TabIndex = 3;
            this.btnSelectAll.Text = "全部(&A)";
            this.btnSelectAll.ToolTip = "查询全部(Alt+A)";
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(274, 74);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(75, 30);
            this.btnOut.TabIndex = 3;
            this.btnOut.Text = "导出(&O)";
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(523, 74);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 30);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "打印(&P)";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // EditSecSelcCondition
            // 
            this.EditSecSelcCondition.Location = new System.Drawing.Point(287, 34);
            this.EditSecSelcCondition.Name = "EditSecSelcCondition";
            this.EditSecSelcCondition.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EditSecSelcCondition.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.EditSecSelcCondition.Size = new System.Drawing.Size(218, 21);
            this.EditSecSelcCondition.TabIndex = 11;
            // 
            // txtNumAndAmount
            // 
            this.txtNumAndAmount.Location = new System.Drawing.Point(287, 34);
            this.txtNumAndAmount.Name = "txtNumAndAmount";
            this.txtNumAndAmount.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtNumAndAmount.Properties.Mask.EditMask = "d";
            this.txtNumAndAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtNumAndAmount.Size = new System.Drawing.Size(218, 21);
            this.txtNumAndAmount.TabIndex = 10;
            this.txtNumAndAmount.EditValueChanged += new System.EventHandler(this.txtNumAndAmount_EditValueChanged);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(772, 32);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(73, 23);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "查询(&S)";
            this.btnSelect.ToolTip = "信息查询(Alt+S/Enter)";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // cmbSelectCondition
            // 
            this.cmbSelectCondition.Location = new System.Drawing.Point(52, 34);
            this.cmbSelectCondition.Name = "cmbSelectCondition";
            this.cmbSelectCondition.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSelectCondition.Properties.Items.AddRange(new object[] {
            "编号",
            "名称",
            "类型",
            "金额",
            "经手人",
            "创建人",
            "创建时间"});
            this.cmbSelectCondition.Properties.MaxLength = 10;
            this.cmbSelectCondition.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbSelectCondition.Size = new System.Drawing.Size(138, 21);
            this.cmbSelectCondition.TabIndex = 9;
            this.cmbSelectCondition.EditValueChanged += new System.EventHandler(this.cmbSelectCondition_SelectedIndexChanged);
            // 
            // mruEditType
            // 
            this.mruEditType.Location = new System.Drawing.Point(287, 34);
            this.mruEditType.Name = "mruEditType";
            this.mruEditType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mruEditType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.mruEditType.Size = new System.Drawing.Size(218, 21);
            this.mruEditType.TabIndex = 7;
            // 
            // dateEditCEnd
            // 
            this.dateEditCEnd.EditValue = new System.DateTime(2013, 3, 6, 0, 0, 0, 0);
            this.dateEditCEnd.Location = new System.Drawing.Point(532, 34);
            this.dateEditCEnd.Name = "dateEditCEnd";
            this.dateEditCEnd.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dateEditCEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditCEnd.Properties.DisplayFormat.FormatString = "D";
            this.dateEditCEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditCEnd.Properties.EditFormat.FormatString = "D";
            this.dateEditCEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditCEnd.Properties.Mask.EditMask = "D";
            this.dateEditCEnd.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEditCEnd.Size = new System.Drawing.Size(218, 21);
            this.dateEditCEnd.TabIndex = 4;
            this.dateEditCEnd.EditValueChanged += new System.EventHandler(this.dateEditCEnd_EditValueChanged);
            // 
            // dateEditCStart
            // 
            this.dateEditCStart.EditValue = new System.DateTime(2013, 3, 6, 0, 0, 0, 0);
            this.dateEditCStart.Location = new System.Drawing.Point(287, 34);
            this.dateEditCStart.Name = "dateEditCStart";
            this.dateEditCStart.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dateEditCStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditCStart.Properties.DisplayFormat.FormatString = "D";
            this.dateEditCStart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditCStart.Properties.EditFormat.FormatString = "D";
            this.dateEditCStart.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditCStart.Properties.Mask.EditMask = "D";
            this.dateEditCStart.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEditCStart.Size = new System.Drawing.Size(218, 21);
            this.dateEditCStart.TabIndex = 4;
            // 
            // lblCome
            // 
            this.lblCome.Location = new System.Drawing.Point(512, 38);
            this.lblCome.Name = "lblCome";
            this.lblCome.Size = new System.Drawing.Size(12, 14);
            this.lblCome.TabIndex = 0;
            this.lblCome.Text = "到";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(221, 37);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(60, 14);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "第二条件：";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(25, 37);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(24, 14);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "按：";
            // 
            // frmInOutDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 516);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.grdctrInOutDetail);
            this.Name = "frmInOutDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "收入支出明细";
            this.Load += new System.EventHandler(this.frmFinanceInOutDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdctrInOutDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInOutDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditSecSelcCondition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumAndAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSelectCondition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mruEditType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditCEnd.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditCEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditCStart.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditCStart.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdctrInOutDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewInOutDetail;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn InOutName;
        private DevExpress.XtraGrid.Columns.GridColumn Amount;
        private DevExpress.XtraGrid.Columns.GridColumn HandlePeople;
        private DevExpress.XtraGrid.Columns.GridColumn InfoNote;
        private DevExpress.XtraGrid.Columns.GridColumn CreatePerson;
        private DevExpress.XtraGrid.Columns.GridColumn CreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn ModifyPerson;
        private DevExpress.XtraGrid.Columns.GridColumn ModifyDate;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.DateEdit dateEditCStart;
        private DevExpress.XtraEditors.SimpleButton btnOut;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.LabelControl lblCome;
        private DevExpress.XtraEditors.DateEdit dateEditCEnd;
        private DevExpress.XtraGrid.Columns.GridColumn Type;
        private DevExpress.XtraEditors.SimpleButton btnSelectAll;
        private DevExpress.XtraEditors.SimpleButton btnSelect;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.MRUEdit mruEditType;
        private DevExpress.XtraEditors.ComboBoxEdit cmbSelectCondition;
        private DevExpress.XtraEditors.TextEdit txtNumAndAmount;
        private DevExpress.XtraEditors.ComboBoxEdit EditSecSelcCondition;
        private DevExpress.XtraEditors.SimpleButton btnBack;
    }
}