namespace CMS.UILayer.frmFinance
{
    partial class frmFinanceRegister
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
            this.btnFinanceRegisterAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnFinanceRegisterBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnFinanceRegisterPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnFinanceRegisterOut = new DevExpress.XtraEditors.SimpleButton();
            this.btnFinanceRegisterAlter = new DevExpress.XtraEditors.SimpleButton();
            this.btnFinanceRegisterDele = new DevExpress.XtraEditors.SimpleButton();
            this.grdctrlItemManagement = new DevExpress.XtraGrid.GridControl();
            this.gridViewFinanceRegister = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RegisterName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Amount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HandlePeople = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InfoNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreatePerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ModifyPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ModifyDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdctrlItemManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFinanceRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnFinanceRegisterAdd);
            this.groupControl2.Controls.Add(this.btnFinanceRegisterBack);
            this.groupControl2.Controls.Add(this.btnFinanceRegisterPrint);
            this.groupControl2.Controls.Add(this.btnFinanceRegisterOut);
            this.groupControl2.Controls.Add(this.btnFinanceRegisterAlter);
            this.groupControl2.Controls.Add(this.btnFinanceRegisterDele);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 331);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(748, 99);
            this.groupControl2.TabIndex = 26;
            this.groupControl2.Text = "操作区";
            // 
            // btnFinanceRegisterAdd
            // 
            this.btnFinanceRegisterAdd.Location = new System.Drawing.Point(42, 47);
            this.btnFinanceRegisterAdd.Name = "btnFinanceRegisterAdd";
            this.btnFinanceRegisterAdd.Size = new System.Drawing.Size(75, 30);
            this.btnFinanceRegisterAdd.TabIndex = 18;
            this.btnFinanceRegisterAdd.Text = "添加(&A)";
            this.btnFinanceRegisterAdd.Click += new System.EventHandler(this.btnFinanceRegisterAdd_Click);
            // 
            // btnFinanceRegisterBack
            // 
            this.btnFinanceRegisterBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFinanceRegisterBack.Location = new System.Drawing.Point(617, 47);
            this.btnFinanceRegisterBack.Name = "btnFinanceRegisterBack";
            this.btnFinanceRegisterBack.Size = new System.Drawing.Size(75, 30);
            this.btnFinanceRegisterBack.TabIndex = 19;
            this.btnFinanceRegisterBack.Text = "返回(&B)";
            this.btnFinanceRegisterBack.ToolTip = "返回系统主界面(Alt+B/Esc)";
            this.btnFinanceRegisterBack.Click += new System.EventHandler(this.btnFinanceRegisterBack_Click);
            // 
            // btnFinanceRegisterPrint
            // 
            this.btnFinanceRegisterPrint.Location = new System.Drawing.Point(502, 47);
            this.btnFinanceRegisterPrint.Name = "btnFinanceRegisterPrint";
            this.btnFinanceRegisterPrint.Size = new System.Drawing.Size(75, 30);
            this.btnFinanceRegisterPrint.TabIndex = 19;
            this.btnFinanceRegisterPrint.Text = "打印(&P)";
            this.btnFinanceRegisterPrint.ToolTip = "数据打印(Alt+P)";
            this.btnFinanceRegisterPrint.Click += new System.EventHandler(this.btnFinanceRegisterPrint_Click);
            // 
            // btnFinanceRegisterOut
            // 
            this.btnFinanceRegisterOut.Location = new System.Drawing.Point(387, 47);
            this.btnFinanceRegisterOut.Name = "btnFinanceRegisterOut";
            this.btnFinanceRegisterOut.Size = new System.Drawing.Size(75, 30);
            this.btnFinanceRegisterOut.TabIndex = 19;
            this.btnFinanceRegisterOut.Text = "导出(&O)";
            this.btnFinanceRegisterOut.ToolTip = "数据导出(Alt+O)";
            this.btnFinanceRegisterOut.Click += new System.EventHandler(this.btnFinanceRegisterOut_Click);
            // 
            // btnFinanceRegisterAlter
            // 
            this.btnFinanceRegisterAlter.Location = new System.Drawing.Point(272, 47);
            this.btnFinanceRegisterAlter.Name = "btnFinanceRegisterAlter";
            this.btnFinanceRegisterAlter.Size = new System.Drawing.Size(75, 30);
            this.btnFinanceRegisterAlter.TabIndex = 19;
            this.btnFinanceRegisterAlter.Text = "修改(&U)";
            this.btnFinanceRegisterAlter.Click += new System.EventHandler(this.btnFinanceRegisterAlter_Click);
            // 
            // btnFinanceRegisterDele
            // 
            this.btnFinanceRegisterDele.Location = new System.Drawing.Point(157, 47);
            this.btnFinanceRegisterDele.Name = "btnFinanceRegisterDele";
            this.btnFinanceRegisterDele.Size = new System.Drawing.Size(75, 30);
            this.btnFinanceRegisterDele.TabIndex = 19;
            this.btnFinanceRegisterDele.Text = "删除(&D)";
            this.btnFinanceRegisterDele.Click += new System.EventHandler(this.btnFinanceRegisterDele_Click);
            // 
            // grdctrlItemManagement
            // 
            this.grdctrlItemManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdctrlItemManagement.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grdctrlItemManagement.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grdctrlItemManagement.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grdctrlItemManagement.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grdctrlItemManagement.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grdctrlItemManagement.Location = new System.Drawing.Point(0, 0);
            this.grdctrlItemManagement.MainView = this.gridViewFinanceRegister;
            this.grdctrlItemManagement.Name = "grdctrlItemManagement";
            this.grdctrlItemManagement.Size = new System.Drawing.Size(748, 325);
            this.grdctrlItemManagement.TabIndex = 25;
            this.grdctrlItemManagement.UseEmbeddedNavigator = true;
            this.grdctrlItemManagement.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewFinanceRegister});
            // 
            // gridViewFinanceRegister
            // 
            this.gridViewFinanceRegister.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewFinanceRegister.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewFinanceRegister.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewFinanceRegister.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gridViewFinanceRegister.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridViewFinanceRegister.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridViewFinanceRegister.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridViewFinanceRegister.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewFinanceRegister.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gridViewFinanceRegister.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewFinanceRegister.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gridViewFinanceRegister.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridViewFinanceRegister.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridViewFinanceRegister.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridViewFinanceRegister.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewFinanceRegister.Appearance.Empty.Options.UseBackColor = true;
            this.gridViewFinanceRegister.Appearance.EvenRow.BackColor = System.Drawing.Color.Silver;
            this.gridViewFinanceRegister.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.gridViewFinanceRegister.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewFinanceRegister.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewFinanceRegister.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridViewFinanceRegister.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridViewFinanceRegister.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewFinanceRegister.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.gridViewFinanceRegister.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewFinanceRegister.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewFinanceRegister.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewFinanceRegister.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridViewFinanceRegister.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridViewFinanceRegister.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridViewFinanceRegister.Appearance.FilterPanel.BackColor = System.Drawing.Color.Black;
            this.gridViewFinanceRegister.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewFinanceRegister.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewFinanceRegister.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewFinanceRegister.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridViewFinanceRegister.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridViewFinanceRegister.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gridViewFinanceRegister.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridViewFinanceRegister.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gridViewFinanceRegister.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Purple;
            this.gridViewFinanceRegister.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridViewFinanceRegister.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridViewFinanceRegister.Appearance.FocusedRow.BackColor = System.Drawing.Color.Purple;
            this.gridViewFinanceRegister.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(50)))), ((int)(((byte)(178)))));
            this.gridViewFinanceRegister.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewFinanceRegister.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewFinanceRegister.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewFinanceRegister.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.gridViewFinanceRegister.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridViewFinanceRegister.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewFinanceRegister.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridViewFinanceRegister.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridViewFinanceRegister.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewFinanceRegister.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewFinanceRegister.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewFinanceRegister.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewFinanceRegister.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridViewFinanceRegister.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridViewFinanceRegister.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridViewFinanceRegister.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewFinanceRegister.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewFinanceRegister.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridViewFinanceRegister.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridViewFinanceRegister.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridViewFinanceRegister.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridViewFinanceRegister.Appearance.GroupPanel.BackColor = System.Drawing.Color.Black;
            this.gridViewFinanceRegister.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridViewFinanceRegister.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewFinanceRegister.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewFinanceRegister.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewFinanceRegister.Appearance.GroupPanel.Options.UseFont = true;
            this.gridViewFinanceRegister.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridViewFinanceRegister.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewFinanceRegister.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.gridViewFinanceRegister.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridViewFinanceRegister.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridViewFinanceRegister.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gridViewFinanceRegister.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridViewFinanceRegister.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewFinanceRegister.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewFinanceRegister.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewFinanceRegister.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridViewFinanceRegister.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewFinanceRegister.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewFinanceRegister.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewFinanceRegister.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewFinanceRegister.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewFinanceRegister.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewFinanceRegister.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewFinanceRegister.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridViewFinanceRegister.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridViewFinanceRegister.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gridViewFinanceRegister.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewFinanceRegister.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gridViewFinanceRegister.Appearance.OddRow.Options.UseBackColor = true;
            this.gridViewFinanceRegister.Appearance.OddRow.Options.UseForeColor = true;
            this.gridViewFinanceRegister.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.gridViewFinanceRegister.Appearance.Preview.BackColor2 = System.Drawing.Color.White;
            this.gridViewFinanceRegister.Appearance.Preview.ForeColor = System.Drawing.Color.Purple;
            this.gridViewFinanceRegister.Appearance.Preview.Options.UseBackColor = true;
            this.gridViewFinanceRegister.Appearance.Preview.Options.UseForeColor = true;
            this.gridViewFinanceRegister.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridViewFinanceRegister.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridViewFinanceRegister.Appearance.Row.Options.UseBackColor = true;
            this.gridViewFinanceRegister.Appearance.Row.Options.UseForeColor = true;
            this.gridViewFinanceRegister.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridViewFinanceRegister.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewFinanceRegister.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridViewFinanceRegister.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(10)))), ((int)(((byte)(138)))));
            this.gridViewFinanceRegister.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewFinanceRegister.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewFinanceRegister.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewFinanceRegister.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewFinanceRegister.Appearance.VertLine.Options.UseBackColor = true;
            this.gridViewFinanceRegister.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.gridColumn1,
            this.RegisterName,
            this.Amount,
            this.HandlePeople,
            this.InfoNote,
            this.CreatePerson,
            this.CreateDate,
            this.ModifyPerson,
            this.ModifyDate});
            this.gridViewFinanceRegister.GridControl = this.grdctrlItemManagement;
            this.gridViewFinanceRegister.Name = "gridViewFinanceRegister";
            this.gridViewFinanceRegister.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewFinanceRegister.OptionsBehavior.Editable = false;
            this.gridViewFinanceRegister.OptionsPrint.EnableAppearanceOddRow = true;
            this.gridViewFinanceRegister.OptionsPrint.ExpandAllDetails = true;
            this.gridViewFinanceRegister.OptionsPrint.PrintDetails = true;
            this.gridViewFinanceRegister.OptionsPrint.PrintFilterInfo = true;
            this.gridViewFinanceRegister.OptionsPrint.UsePrintStyles = true;
            this.gridViewFinanceRegister.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewFinanceRegister.OptionsView.ColumnAutoWidth = false;
            this.gridViewFinanceRegister.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewFinanceRegister.OptionsView.EnableAppearanceOddRow = true;
            // 
            // ID
            // 
            this.ID.AppearanceCell.Options.UseTextOptions = true;
            this.ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ID.Caption = "收支编号";
            this.ID.FieldName = "编号";
            this.ID.Name = "ID";
            this.ID.ToolTip = "财务记录编号";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 62;
            // 
            // RegisterName
            // 
            this.RegisterName.AppearanceCell.Options.UseTextOptions = true;
            this.RegisterName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RegisterName.Caption = "收支名称";
            this.RegisterName.FieldName = "名称";
            this.RegisterName.Name = "RegisterName";
            this.RegisterName.ToolTip = "收支项目名称";
            this.RegisterName.Visible = true;
            this.RegisterName.VisibleIndex = 2;
            this.RegisterName.Width = 63;
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
            this.Amount.Width = 60;
            // 
            // HandlePeople
            // 
            this.HandlePeople.Caption = "经手人";
            this.HandlePeople.FieldName = "经手人";
            this.HandlePeople.Name = "HandlePeople";
            this.HandlePeople.ToolTip = "经手人";
            this.HandlePeople.Visible = true;
            this.HandlePeople.VisibleIndex = 4;
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
            this.CreatePerson.Width = 54;
            // 
            // CreateDate
            // 
            this.CreateDate.Caption = "创建日期";
            this.CreateDate.DisplayFormat.FormatString = "g";
            this.CreateDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.CreateDate.FieldName = "创建日期";
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ToolTip = "创建时间";
            this.CreateDate.Visible = true;
            this.CreateDate.VisibleIndex = 7;
            this.CreateDate.Width = 116;
            // 
            // ModifyPerson
            // 
            this.ModifyPerson.Caption = "修改人";
            this.ModifyPerson.FieldName = "修改人";
            this.ModifyPerson.Name = "ModifyPerson";
            this.ModifyPerson.ToolTip = "修改人";
            this.ModifyPerson.Visible = true;
            this.ModifyPerson.VisibleIndex = 8;
            this.ModifyPerson.Width = 71;
            // 
            // ModifyDate
            // 
            this.ModifyDate.Caption = "修改时间";
            this.ModifyDate.DisplayFormat.FormatString = "g";
            this.ModifyDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ModifyDate.FieldName = "修改日期";
            this.ModifyDate.Name = "ModifyDate";
            this.ModifyDate.ToolTip = "修改时间";
            this.ModifyDate.Visible = true;
            this.ModifyDate.VisibleIndex = 9;
            this.ModifyDate.Width = 128;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "收支类型";
            this.gridColumn1.FieldName = "类型";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.ToolTip = "收支项目类型";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // frmFinanceRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 430);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.grdctrlItemManagement);
            this.MaximizeBox = false;
            this.Name = "frmFinanceRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "2";
            this.Text = "财务记录登记";
            this.Load += new System.EventHandler(this.frmFinanceRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdctrlItemManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFinanceRegister)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnFinanceRegisterAdd;
        private DevExpress.XtraEditors.SimpleButton btnFinanceRegisterBack;
        private DevExpress.XtraEditors.SimpleButton btnFinanceRegisterPrint;
        private DevExpress.XtraEditors.SimpleButton btnFinanceRegisterOut;
        private DevExpress.XtraEditors.SimpleButton btnFinanceRegisterAlter;
        private DevExpress.XtraEditors.SimpleButton btnFinanceRegisterDele;
        private DevExpress.XtraGrid.GridControl grdctrlItemManagement;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewFinanceRegister;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn RegisterName;
        private DevExpress.XtraGrid.Columns.GridColumn Amount;
        private DevExpress.XtraGrid.Columns.GridColumn InfoNote;
        private DevExpress.XtraGrid.Columns.GridColumn CreatePerson;
        private DevExpress.XtraGrid.Columns.GridColumn CreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn ModifyPerson;
        private DevExpress.XtraGrid.Columns.GridColumn ModifyDate;
        private DevExpress.XtraGrid.Columns.GridColumn HandlePeople;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;

    }
}