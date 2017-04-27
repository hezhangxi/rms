namespace CMS.UILayer.frmBusiness
{
    partial class frmRetreatSearch
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.lupDisName = new DevExpress.XtraEditors.LookUpEdit();
            this.btnOut = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.dateEnd = new DevExpress.XtraEditors.DateEdit();
            this.dateStart = new DevExpress.XtraEditors.DateEdit();
            this.mruIDNum = new DevExpress.XtraEditors.MRUEdit();
            this.lupReason = new DevExpress.XtraEditors.LookUpEdit();
            this.lupCreatePerson = new DevExpress.XtraEditors.LookUpEdit();
            this.cmFiledName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblFrom = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlDish = new DevExpress.XtraGrid.GridControl();
            this.gridViewDish = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BackID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DishName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DishNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CauseName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Info = new DevExpress.XtraGrid.Columns.GridColumn();
            this.createperson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.date = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lupDisName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mruIDNum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupReason.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupCreatePerson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmFiledName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDish)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnExit);
            this.groupControl1.Controls.Add(this.lupDisName);
            this.groupControl1.Controls.Add(this.btnOut);
            this.groupControl1.Controls.Add(this.btnPrint);
            this.groupControl1.Controls.Add(this.btnDeleteAll);
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.btnAll);
            this.groupControl1.Controls.Add(this.btnSearch);
            this.groupControl1.Controls.Add(this.dateEnd);
            this.groupControl1.Controls.Add(this.dateStart);
            this.groupControl1.Controls.Add(this.mruIDNum);
            this.groupControl1.Controls.Add(this.lupReason);
            this.groupControl1.Controls.Add(this.lupCreatePerson);
            this.groupControl1.Controls.Add(this.cmFiledName);
            this.groupControl1.Controls.Add(this.lblFrom);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(897, 128);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "信息操作";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(37, 84);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 30);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "返回(&B)";
            this.btnExit.ToolTip = "返回主界面(Alt+B/Esc)";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lupDisName
            // 
            this.lupDisName.Location = new System.Drawing.Point(256, 42);
            this.lupDisName.Name = "lupDisName";
            this.lupDisName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupDisName.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "菜品名称")});
            this.lupDisName.Properties.DisplayMember = "Name";
            this.lupDisName.Properties.ValueMember = "ID";
            this.lupDisName.Size = new System.Drawing.Size(218, 21);
            this.lupDisName.TabIndex = 3;
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(609, 84);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(77, 30);
            this.btnOut.TabIndex = 13;
            this.btnOut.Text = "导出(&O)";
            this.btnOut.ToolTip = "导出数据(Alt+O)";
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(468, 84);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(74, 30);
            this.btnPrint.TabIndex = 12;
            this.btnPrint.Text = "打印(&P)";
            this.btnPrint.ToolTip = "打印数据(Alt+P)";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(323, 84);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(78, 30);
            this.btnDeleteAll.TabIndex = 11;
            this.btnDeleteAll.Text = "清空(&E)";
            this.btnDeleteAll.ToolTip = "删除(&D)所有数据(Alt+E)";
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(179, 84);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 30);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "删除(&D)";
            this.btnDelete.ToolTip = "删除退菜信息(Alt+D)";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(753, 84);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(72, 30);
            this.btnAll.TabIndex = 9;
            this.btnAll.Text = "全部(&A)";
            this.btnAll.ToolTip = "查询全部信息(Alt+A)";
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(756, 43);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "查询(&S)";
            this.btnSearch.ToolTip = "按条件查询(Alt+S)";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dateEnd
            // 
            this.dateEnd.EditValue = new System.DateTime(2013, 3, 3, 0, 0, 0, 0);
            this.dateEnd.Location = new System.Drawing.Point(501, 42);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEnd.Properties.DisplayFormat.FormatString = "D";
            this.dateEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEnd.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEnd.Size = new System.Drawing.Size(218, 21);
            this.dateEnd.TabIndex = 7;
            // 
            // dateStart
            // 
            this.dateStart.EditValue = new System.DateTime(2013, 3, 3, 0, 0, 0, 0);
            this.dateStart.Location = new System.Drawing.Point(256, 42);
            this.dateStart.Name = "dateStart";
            this.dateStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStart.Properties.DisplayFormat.FormatString = "D";
            this.dateStart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateStart.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateStart.Size = new System.Drawing.Size(218, 21);
            this.dateStart.TabIndex = 6;
            // 
            // mruIDNum
            // 
            this.mruIDNum.Location = new System.Drawing.Point(256, 41);
            this.mruIDNum.Name = "mruIDNum";
            this.mruIDNum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mruIDNum.Size = new System.Drawing.Size(218, 21);
            this.mruIDNum.TabIndex = 5;
            // 
            // lupReason
            // 
            this.lupReason.Location = new System.Drawing.Point(256, 41);
            this.lupReason.Name = "lupReason";
            this.lupReason.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupReason.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "退菜原因")});
            this.lupReason.Properties.DisplayMember = "Name";
            this.lupReason.Properties.ValueMember = "ID";
            this.lupReason.Size = new System.Drawing.Size(218, 21);
            this.lupReason.TabIndex = 4;
            // 
            // lupCreatePerson
            // 
            this.lupCreatePerson.Location = new System.Drawing.Point(256, 41);
            this.lupCreatePerson.Name = "lupCreatePerson";
            this.lupCreatePerson.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupCreatePerson.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("USERNAME", "办理人")});
            this.lupCreatePerson.Properties.DisplayMember = "USERNAME";
            this.lupCreatePerson.Size = new System.Drawing.Size(218, 21);
            this.lupCreatePerson.TabIndex = 3;
            // 
            // cmFiledName
            // 
            this.cmFiledName.Location = new System.Drawing.Point(59, 41);
            this.cmFiledName.Name = "cmFiledName";
            this.cmFiledName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmFiledName.Properties.Items.AddRange(new object[] {
            "退菜编号",
            "菜品名称",
            "退菜数量",
            "退菜原因",
            "办理人",
            "退菜时间"});
            this.cmFiledName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmFiledName.Size = new System.Drawing.Size(118, 21);
            this.cmFiledName.TabIndex = 2;
            this.cmFiledName.SelectedIndexChanged += new System.EventHandler(this.cmFiledName_SelectedIndexChanged);
            // 
            // lblFrom
            // 
            this.lblFrom.Location = new System.Drawing.Point(483, 45);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(12, 14);
            this.lblFrom.TabIndex = 1;
            this.lblFrom.Text = "至";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(190, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "第二条件：";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(37, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "按：";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControlDish);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 128);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(897, 340);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "退菜信息列表";
            // 
            // gridControlDish
            // 
            this.gridControlDish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDish.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlDish.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlDish.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlDish.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlDish.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlDish.Location = new System.Drawing.Point(2, 23);
            this.gridControlDish.MainView = this.gridViewDish;
            this.gridControlDish.Name = "gridControlDish";
            this.gridControlDish.Size = new System.Drawing.Size(893, 315);
            this.gridControlDish.TabIndex = 0;
            this.gridControlDish.UseEmbeddedNavigator = true;
            this.gridControlDish.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDish});
            // 
            // gridViewDish
            // 
            this.gridViewDish.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewDish.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewDish.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewDish.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gridViewDish.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridViewDish.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridViewDish.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridViewDish.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewDish.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gridViewDish.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewDish.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gridViewDish.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridViewDish.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridViewDish.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridViewDish.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewDish.Appearance.Empty.Options.UseBackColor = true;
            this.gridViewDish.Appearance.EvenRow.BackColor = System.Drawing.Color.Silver;
            this.gridViewDish.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.gridViewDish.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewDish.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewDish.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridViewDish.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridViewDish.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewDish.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.gridViewDish.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewDish.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewDish.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewDish.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridViewDish.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridViewDish.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridViewDish.Appearance.FilterPanel.BackColor = System.Drawing.Color.Black;
            this.gridViewDish.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewDish.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewDish.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewDish.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridViewDish.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridViewDish.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gridViewDish.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridViewDish.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gridViewDish.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Purple;
            this.gridViewDish.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridViewDish.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridViewDish.Appearance.FocusedRow.BackColor = System.Drawing.Color.Purple;
            this.gridViewDish.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(50)))), ((int)(((byte)(178)))));
            this.gridViewDish.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewDish.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewDish.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewDish.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.gridViewDish.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridViewDish.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewDish.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridViewDish.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridViewDish.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewDish.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewDish.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewDish.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewDish.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridViewDish.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridViewDish.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridViewDish.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewDish.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewDish.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridViewDish.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridViewDish.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridViewDish.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridViewDish.Appearance.GroupPanel.BackColor = System.Drawing.Color.Black;
            this.gridViewDish.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridViewDish.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewDish.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewDish.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewDish.Appearance.GroupPanel.Options.UseFont = true;
            this.gridViewDish.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridViewDish.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewDish.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.gridViewDish.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridViewDish.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridViewDish.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gridViewDish.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridViewDish.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewDish.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewDish.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewDish.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridViewDish.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewDish.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewDish.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewDish.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewDish.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewDish.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewDish.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewDish.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridViewDish.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridViewDish.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gridViewDish.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewDish.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gridViewDish.Appearance.OddRow.Options.UseBackColor = true;
            this.gridViewDish.Appearance.OddRow.Options.UseForeColor = true;
            this.gridViewDish.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.gridViewDish.Appearance.Preview.BackColor2 = System.Drawing.Color.White;
            this.gridViewDish.Appearance.Preview.ForeColor = System.Drawing.Color.Purple;
            this.gridViewDish.Appearance.Preview.Options.UseBackColor = true;
            this.gridViewDish.Appearance.Preview.Options.UseForeColor = true;
            this.gridViewDish.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridViewDish.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridViewDish.Appearance.Row.Options.UseBackColor = true;
            this.gridViewDish.Appearance.Row.Options.UseForeColor = true;
            this.gridViewDish.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridViewDish.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewDish.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridViewDish.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(10)))), ((int)(((byte)(138)))));
            this.gridViewDish.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewDish.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewDish.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewDish.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewDish.Appearance.VertLine.Options.UseBackColor = true;
            this.gridViewDish.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.BackID,
            this.DishName,
            this.DishNum,
            this.CauseName,
            this.Info,
            this.createperson,
            this.date});
            this.gridViewDish.GridControl = this.gridControlDish;
            this.gridViewDish.Name = "gridViewDish";
            this.gridViewDish.OptionsBehavior.Editable = false;
            this.gridViewDish.OptionsPrint.EnableAppearanceOddRow = true;
            this.gridViewDish.OptionsPrint.ExpandAllDetails = true;
            this.gridViewDish.OptionsPrint.PrintDetails = true;
            this.gridViewDish.OptionsPrint.PrintFilterInfo = true;
            this.gridViewDish.OptionsPrint.PrintPreview = true;
            this.gridViewDish.OptionsPrint.UsePrintStyles = true;
            this.gridViewDish.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewDish.OptionsView.ColumnAutoWidth = false;
            this.gridViewDish.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewDish.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewDish.OptionsView.ShowFooter = true;
            this.gridViewDish.DoubleClick += new System.EventHandler(this.gridViewDish_DoubleClick);
            // 
            // BackID
            // 
            this.BackID.Caption = "编号";
            this.BackID.FieldName = "ID";
            this.BackID.Name = "BackID";
            this.BackID.ToolTip = "数据编号";
            this.BackID.Visible = true;
            this.BackID.VisibleIndex = 0;
            this.BackID.Width = 65;
            // 
            // DishName
            // 
            this.DishName.Caption = "菜品名称";
            this.DishName.FieldName = "DishName";
            this.DishName.Name = "DishName";
            this.DishName.ToolTip = "菜品名称";
            this.DishName.Visible = true;
            this.DishName.VisibleIndex = 1;
            this.DishName.Width = 114;
            // 
            // DishNum
            // 
            this.DishNum.Caption = "退菜数量";
            this.DishNum.DisplayFormat.FormatString = "{0}道";
            this.DishNum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DishNum.FieldName = "DishNum";
            this.DishNum.Name = "DishNum";
            this.DishNum.SummaryItem.DisplayFormat = "共有退菜：{0}道";
            this.DishNum.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.DishNum.ToolTip = "退菜数量";
            this.DishNum.Visible = true;
            this.DishNum.VisibleIndex = 2;
            this.DishNum.Width = 111;
            // 
            // CauseName
            // 
            this.CauseName.Caption = "原因";
            this.CauseName.FieldName = "Cause";
            this.CauseName.Name = "CauseName";
            this.CauseName.ToolTip = "原因";
            this.CauseName.Visible = true;
            this.CauseName.VisibleIndex = 3;
            this.CauseName.Width = 191;
            // 
            // Info
            // 
            this.Info.Caption = "备注";
            this.Info.FieldName = "InfoNote";
            this.Info.Name = "Info";
            this.Info.ToolTip = "原因";
            this.Info.Visible = true;
            this.Info.VisibleIndex = 4;
            this.Info.Width = 240;
            // 
            // createperson
            // 
            this.createperson.Caption = "办理人";
            this.createperson.FieldName = "CreatePerson";
            this.createperson.Name = "createperson";
            this.createperson.ToolTip = "办理人";
            this.createperson.Visible = true;
            this.createperson.VisibleIndex = 5;
            this.createperson.Width = 121;
            // 
            // date
            // 
            this.date.Caption = "退菜时间";
            this.date.DisplayFormat.FormatString = "g";
            this.date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date.FieldName = "RetreatDate";
            this.date.Name = "date";
            this.date.ToolTip = "退菜时间";
            this.date.Visible = true;
            this.date.VisibleIndex = 6;
            this.date.Width = 140;
            // 
            // frmRetreatSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 468);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.MaximizeBox = false;
            this.Name = "frmRetreatSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "退菜明细查询";
            this.Load += new System.EventHandler(this.frmRetreatSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lupDisName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mruIDNum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupReason.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupCreatePerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmFiledName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDish)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.MRUEdit mruIDNum;
        private DevExpress.XtraEditors.LookUpEdit lupReason;
        private DevExpress.XtraEditors.LookUpEdit lupDisName;
        private DevExpress.XtraEditors.ComboBoxEdit cmFiledName;
        private DevExpress.XtraEditors.LabelControl lblFrom;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnOut;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnDeleteAll;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAll;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.DateEdit dateStart;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControlDish;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDish;
        private DevExpress.XtraEditors.DateEdit dateEnd;
        private DevExpress.XtraGrid.Columns.GridColumn BackID;
        private DevExpress.XtraGrid.Columns.GridColumn DishName;
        private DevExpress.XtraGrid.Columns.GridColumn DishNum;
        private DevExpress.XtraGrid.Columns.GridColumn CauseName;
        private DevExpress.XtraGrid.Columns.GridColumn Info;
        private DevExpress.XtraGrid.Columns.GridColumn createperson;
        private DevExpress.XtraGrid.Columns.GridColumn date;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit lupCreatePerson;
    }
}