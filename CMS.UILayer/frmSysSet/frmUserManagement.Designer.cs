namespace CMS.UILayer.frmSysSet
{
    partial class frmUserManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserManagement));
            this.gridControlUser = new DevExpress.XtraGrid.GridControl();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.UserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserRight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreatePerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ModifyPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ModifyDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.groupControlData = new DevExpress.XtraEditors.GroupControl();
            this.groupControlOperator = new DevExpress.XtraEditors.GroupControl();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnOut = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.printPreviewRibbonPageGroup7 = new DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroup();
            this.printPreviewRibbonPageGroup6 = new DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroup();
            this.printPreviewRibbonPageGroup5 = new DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroup();
            this.printPreviewRibbonPageGroup4 = new DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroup();
            this.printPreviewRibbonPageGroup3 = new DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlData)).BeginInit();
            this.groupControlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlOperator)).BeginInit();
            this.groupControlOperator.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlUser
            // 
            this.gridControlUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlUser.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlUser.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlUser.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlUser.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlUser.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlUser.Location = new System.Drawing.Point(2, 23);
            this.gridControlUser.MainView = this.gridViewMain;
            this.gridControlUser.Name = "gridControlUser";
            this.gridControlUser.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gridControlUser.Size = new System.Drawing.Size(696, 247);
            this.gridControlUser.TabIndex = 0;
            this.gridControlUser.UseEmbeddedNavigator = true;
            this.gridControlUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            this.gridControlUser.DoubleClick += new System.EventHandler(this.gridControlUser_DoubleClick);
            this.gridControlUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridControlUser_KeyDown);
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
            this.UserID,
            this.UserName,
            this.UserRight,
            this.CreatePerson,
            this.CreateDate,
            this.ModifyPerson,
            this.ModifyDate});
            this.gridViewMain.GridControl = this.gridControlUser;
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
            this.gridViewMain.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewMain.OptionsView.EnableAppearanceOddRow = true;
            // 
            // UserID
            // 
            this.UserID.Caption = "编号";
            this.UserID.FieldName = "ID";
            this.UserID.Name = "UserID";
            this.UserID.OptionsColumn.AllowEdit = false;
            this.UserID.ToolTip = "用户编号";
            this.UserID.Visible = true;
            this.UserID.VisibleIndex = 0;
            this.UserID.Width = 70;
            // 
            // UserName
            // 
            this.UserName.Caption = "用户名称";
            this.UserName.FieldName = "USERNAME";
            this.UserName.Name = "UserName";
            this.UserName.ToolTip = "用户名称";
            this.UserName.Visible = true;
            this.UserName.VisibleIndex = 1;
            this.UserName.Width = 101;
            // 
            // UserRight
            // 
            this.UserRight.Caption = "用户权限";
            this.UserRight.FieldName = "NAME";
            this.UserRight.Name = "UserRight";
            this.UserRight.ToolTip = "用户权限";
            this.UserRight.Visible = true;
            this.UserRight.VisibleIndex = 2;
            this.UserRight.Width = 91;
            // 
            // CreatePerson
            // 
            this.CreatePerson.Caption = "创建人";
            this.CreatePerson.FieldName = "CREATEPERSON";
            this.CreatePerson.Name = "CreatePerson";
            this.CreatePerson.ToolTip = "创建人";
            this.CreatePerson.Visible = true;
            this.CreatePerson.VisibleIndex = 3;
            this.CreatePerson.Width = 77;
            // 
            // CreateDate
            // 
            this.CreateDate.Caption = "创建时间";
            this.CreateDate.FieldName = "CREATEDATE";
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ToolTip = "创建时间";
            this.CreateDate.Visible = true;
            this.CreateDate.VisibleIndex = 4;
            this.CreateDate.Width = 120;
            // 
            // ModifyPerson
            // 
            this.ModifyPerson.Caption = "修改人";
            this.ModifyPerson.FieldName = "MODIFYPERSON";
            this.ModifyPerson.Name = "ModifyPerson";
            this.ModifyPerson.ToolTip = "修改人";
            this.ModifyPerson.Visible = true;
            this.ModifyPerson.VisibleIndex = 5;
            this.ModifyPerson.Width = 91;
            // 
            // ModifyDate
            // 
            this.ModifyDate.Caption = "修改时间";
            this.ModifyDate.FieldName = "MODIFYDATE";
            this.ModifyDate.Name = "ModifyDate";
            this.ModifyDate.ToolTip = "修改时间";
            this.ModifyDate.Visible = true;
            this.ModifyDate.VisibleIndex = 6;
            this.ModifyDate.Width = 125;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // groupControlData
            // 
            this.groupControlData.Controls.Add(this.gridControlUser);
            this.groupControlData.Location = new System.Drawing.Point(12, 12);
            this.groupControlData.Name = "groupControlData";
            this.groupControlData.Size = new System.Drawing.Size(700, 272);
            this.groupControlData.TabIndex = 1;
            this.groupControlData.Text = "系统用户信息";
            // 
            // groupControlOperator
            // 
            this.groupControlOperator.Controls.Add(this.btnBack);
            this.groupControlOperator.Controls.Add(this.btnPrint);
            this.groupControlOperator.Controls.Add(this.btnOut);
            this.groupControlOperator.Controls.Add(this.btnUpdate);
            this.groupControlOperator.Controls.Add(this.btnDel);
            this.groupControlOperator.Controls.Add(this.btnAdd);
            this.groupControlOperator.Location = new System.Drawing.Point(12, 293);
            this.groupControlOperator.Name = "groupControlOperator";
            this.groupControlOperator.Size = new System.Drawing.Size(698, 103);
            this.groupControlOperator.TabIndex = 2;
            this.groupControlOperator.Text = "用户信息操作";
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(599, 44);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 30);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "返回(&B)";
            this.btnBack.ToolTip = "返回系统主界面(Alt+B/Esc)";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(483, 44);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 30);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "打印(&P)";
            this.btnPrint.ToolTip = "用户信息打印(Alt+P/Enter)";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(367, 44);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(75, 30);
            this.btnOut.TabIndex = 0;
            this.btnOut.Text = "导出(&O)";
            this.btnOut.ToolTip = "用户信息导出(Alt+O)";
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(251, 44);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 30);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "修改(&U)";
            this.btnUpdate.ToolTip = "修改用户信息(Alt+U)";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(135, 44);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 30);
            this.btnDel.TabIndex = 0;
            this.btnDel.Text = "删除(&D)";
            this.btnDel.ToolTip = "删除用户信息(Alt+D)";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(19, 44);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "添加(&A)";
            this.btnAdd.ToolTip = "添加用户信息(Alt+A)";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // printPreviewRibbonPageGroup7
            // 
            this.printPreviewRibbonPageGroup7.Kind = DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroupKind.Print;
            this.printPreviewRibbonPageGroup7.Name = "printPreviewRibbonPageGroup7";
            // 
            // printPreviewRibbonPageGroup6
            // 
            this.printPreviewRibbonPageGroup6.Kind = DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroupKind.Print;
            this.printPreviewRibbonPageGroup6.Name = "printPreviewRibbonPageGroup6";
            // 
            // printPreviewRibbonPageGroup5
            // 
            this.printPreviewRibbonPageGroup5.Kind = DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroupKind.Print;
            this.printPreviewRibbonPageGroup5.Name = "printPreviewRibbonPageGroup5";
            // 
            // printPreviewRibbonPageGroup4
            // 
            this.printPreviewRibbonPageGroup4.Kind = DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroupKind.Print;
            this.printPreviewRibbonPageGroup4.Name = "printPreviewRibbonPageGroup4";
            // 
            // printPreviewRibbonPageGroup3
            // 
            this.printPreviewRibbonPageGroup3.Kind = DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroupKind.Print;
            this.printPreviewRibbonPageGroup3.Name = "printPreviewRibbonPageGroup3";
            // 
            // frmUserManagement
            // 
            this.AcceptButton = this.btnPrint;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(726, 405);
            this.Controls.Add(this.groupControlOperator);
            this.Controls.Add(this.groupControlData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmUserManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户管理";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlData)).EndInit();
            this.groupControlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlOperator)).EndInit();
            this.groupControlOperator.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlUser;
        private DevExpress.XtraEditors.GroupControl groupControlData;
        private DevExpress.XtraEditors.GroupControl groupControlOperator;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDel;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.SimpleButton btnOut;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroup printPreviewRibbonPageGroup7;
        private DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroup printPreviewRibbonPageGroup6;
        private DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroup printPreviewRibbonPageGroup5;
        private DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroup printPreviewRibbonPageGroup4;
        private DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroup printPreviewRibbonPageGroup3;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraGrid.Columns.GridColumn UserID;
        private DevExpress.XtraGrid.Columns.GridColumn UserName;
        private DevExpress.XtraGrid.Columns.GridColumn UserRight;
        private DevExpress.XtraGrid.Columns.GridColumn CreatePerson;
        private DevExpress.XtraGrid.Columns.GridColumn CreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn ModifyDate;
        private DevExpress.XtraGrid.Columns.GridColumn ModifyPerson;
    }
}