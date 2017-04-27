namespace CMS.UILayer.frmBasicInfo
{
    partial class frmDishInfoMaintenance
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
            this.txtDishName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbeDishType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnSelectAll = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSimpleSpell = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDishID = new DevExpress.XtraEditors.TextEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnDishInfoAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnDishInfoBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnDishInfoPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnDishInfoOut = new DevExpress.XtraEditors.SimpleButton();
            this.btnDishInfoAlter = new DevExpress.XtraEditors.SimpleButton();
            this.btnDishInfoDele = new DevExpress.XtraEditors.SimpleButton();
            this.grdctrlDishInfo = new DevExpress.XtraGrid.GridControl();
            this.gridViewDishInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DishID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DishName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DishType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SimpleSpell = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DishCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DishPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DishMeasuringUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RelatedGoodsName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DishStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DishCommission = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InfoNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DishCreatePerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DishCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DishModifyPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DishModifyDate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtDishName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbeDishType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSimpleSpell.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDishID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdctrlDishInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDishInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDishName
            // 
            this.txtDishName.Location = new System.Drawing.Point(473, 37);
            this.txtDishName.Name = "txtDishName";
            this.txtDishName.Size = new System.Drawing.Size(95, 21);
            this.txtDishName.TabIndex = 32;
            this.txtDishName.EditValueChanged += new System.EventHandler(this.txtDishName_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(407, 40);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 31;
            this.labelControl2.Text = "菜品名称：";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(41, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 29;
            this.labelControl1.Text = "菜品类别：";
            // 
            // cmbeDishType
            // 
            this.cmbeDishType.Location = new System.Drawing.Point(107, 37);
            this.cmbeDishType.Name = "cmbeDishType";
            this.cmbeDishType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbeDishType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbeDishType.Size = new System.Drawing.Size(102, 21);
            this.cmbeDishType.TabIndex = 30;
            this.cmbeDishType.SelectedIndexChanged += new System.EventHandler(this.cmbeDishType_SelectedIndexChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnSelectAll);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.cmbeDishType);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtSimpleSpell);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtDishID);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtDishName);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(908, 72);
            this.groupControl1.TabIndex = 45;
            this.groupControl1.Text = "查询区";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(821, 35);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAll.TabIndex = 33;
            this.btnSelectAll.Text = "查询全部";
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(612, 40);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 14);
            this.labelControl3.TabIndex = 31;
            this.labelControl3.Text = "拼音简写：";
            // 
            // txtSimpleSpell
            // 
            this.txtSimpleSpell.Location = new System.Drawing.Point(678, 37);
            this.txtSimpleSpell.Name = "txtSimpleSpell";
            this.txtSimpleSpell.Size = new System.Drawing.Size(95, 21);
            this.txtSimpleSpell.TabIndex = 32;
            this.txtSimpleSpell.EditValueChanged += new System.EventHandler(this.txtSimpleSpell_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(228, 40);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 14);
            this.labelControl4.TabIndex = 31;
            this.labelControl4.Text = "菜品编号：";
            // 
            // txtDishID
            // 
            this.txtDishID.Location = new System.Drawing.Point(294, 37);
            this.txtDishID.Name = "txtDishID";
            this.txtDishID.Size = new System.Drawing.Size(95, 21);
            this.txtDishID.TabIndex = 32;
            this.txtDishID.EditValueChanged += new System.EventHandler(this.txtDishID_EditValueChanged);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btnDishInfoAdd);
            this.groupControl3.Controls.Add(this.btnDishInfoBack);
            this.groupControl3.Controls.Add(this.btnDishInfoPrint);
            this.groupControl3.Controls.Add(this.btnDishInfoOut);
            this.groupControl3.Controls.Add(this.btnDishInfoAlter);
            this.groupControl3.Controls.Add(this.btnDishInfoDele);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl3.Location = new System.Drawing.Point(0, 533);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(908, 97);
            this.groupControl3.TabIndex = 47;
            this.groupControl3.Text = "操作区";
            // 
            // btnDishInfoAdd
            // 
            this.btnDishInfoAdd.Location = new System.Drawing.Point(41, 49);
            this.btnDishInfoAdd.Name = "btnDishInfoAdd";
            this.btnDishInfoAdd.Size = new System.Drawing.Size(87, 30);
            this.btnDishInfoAdd.TabIndex = 18;
            this.btnDishInfoAdd.Text = "添加(&A)";
            this.btnDishInfoAdd.Click += new System.EventHandler(this.btnDishInfoAdd_Click);
            // 
            // btnDishInfoBack
            // 
            this.btnDishInfoBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDishInfoBack.Location = new System.Drawing.Point(766, 49);
            this.btnDishInfoBack.Name = "btnDishInfoBack";
            this.btnDishInfoBack.Size = new System.Drawing.Size(87, 30);
            this.btnDishInfoBack.TabIndex = 19;
            this.btnDishInfoBack.Text = "返回(&B)";
            this.btnDishInfoBack.ToolTip = "返回系统主界面(Alt+B/Esc)";
            // 
            // btnDishInfoPrint
            // 
            this.btnDishInfoPrint.Location = new System.Drawing.Point(621, 49);
            this.btnDishInfoPrint.Name = "btnDishInfoPrint";
            this.btnDishInfoPrint.Size = new System.Drawing.Size(87, 30);
            this.btnDishInfoPrint.TabIndex = 19;
            this.btnDishInfoPrint.Text = "打印(&P)";
            this.btnDishInfoPrint.ToolTip = "数据打印(Alt+P)";
            this.btnDishInfoPrint.Click += new System.EventHandler(this.btnDishInfoPrint_Click);
            // 
            // btnDishInfoOut
            // 
            this.btnDishInfoOut.Location = new System.Drawing.Point(476, 49);
            this.btnDishInfoOut.Name = "btnDishInfoOut";
            this.btnDishInfoOut.Size = new System.Drawing.Size(87, 30);
            this.btnDishInfoOut.TabIndex = 19;
            this.btnDishInfoOut.Text = "导出(&O)";
            this.btnDishInfoOut.ToolTip = "数据导出(Alt+O)";
            this.btnDishInfoOut.Click += new System.EventHandler(this.btnDishInfoOut_Click);
            // 
            // btnDishInfoAlter
            // 
            this.btnDishInfoAlter.Location = new System.Drawing.Point(331, 49);
            this.btnDishInfoAlter.Name = "btnDishInfoAlter";
            this.btnDishInfoAlter.Size = new System.Drawing.Size(87, 30);
            this.btnDishInfoAlter.TabIndex = 19;
            this.btnDishInfoAlter.Text = "修改(&U)";
            this.btnDishInfoAlter.Click += new System.EventHandler(this.btnDishInfoAlter_Click);
            // 
            // btnDishInfoDele
            // 
            this.btnDishInfoDele.Location = new System.Drawing.Point(186, 49);
            this.btnDishInfoDele.Name = "btnDishInfoDele";
            this.btnDishInfoDele.Size = new System.Drawing.Size(87, 30);
            this.btnDishInfoDele.TabIndex = 19;
            this.btnDishInfoDele.Text = "删除(&D)";
            this.btnDishInfoDele.Click += new System.EventHandler(this.btnDishInfoDele_Click);
            // 
            // grdctrlDishInfo
            // 
            this.grdctrlDishInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdctrlDishInfo.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grdctrlDishInfo.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grdctrlDishInfo.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.grdctrlDishInfo.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grdctrlDishInfo.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grdctrlDishInfo.Location = new System.Drawing.Point(0, 72);
            this.grdctrlDishInfo.MainView = this.gridViewDishInfo;
            this.grdctrlDishInfo.Name = "grdctrlDishInfo";
            this.grdctrlDishInfo.Size = new System.Drawing.Size(908, 461);
            this.grdctrlDishInfo.TabIndex = 48;
            this.grdctrlDishInfo.UseEmbeddedNavigator = true;
            this.grdctrlDishInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDishInfo});
            // 
            // gridViewDishInfo
            // 
            this.gridViewDishInfo.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewDishInfo.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewDishInfo.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewDishInfo.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gridViewDishInfo.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridViewDishInfo.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridViewDishInfo.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridViewDishInfo.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewDishInfo.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gridViewDishInfo.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewDishInfo.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gridViewDishInfo.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridViewDishInfo.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridViewDishInfo.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridViewDishInfo.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewDishInfo.Appearance.Empty.Options.UseBackColor = true;
            this.gridViewDishInfo.Appearance.EvenRow.BackColor = System.Drawing.Color.Silver;
            this.gridViewDishInfo.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.gridViewDishInfo.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewDishInfo.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewDishInfo.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridViewDishInfo.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridViewDishInfo.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewDishInfo.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.gridViewDishInfo.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewDishInfo.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewDishInfo.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewDishInfo.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridViewDishInfo.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridViewDishInfo.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridViewDishInfo.Appearance.FilterPanel.BackColor = System.Drawing.Color.Black;
            this.gridViewDishInfo.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewDishInfo.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewDishInfo.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewDishInfo.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridViewDishInfo.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridViewDishInfo.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gridViewDishInfo.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridViewDishInfo.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gridViewDishInfo.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Purple;
            this.gridViewDishInfo.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridViewDishInfo.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridViewDishInfo.Appearance.FocusedRow.BackColor = System.Drawing.Color.Purple;
            this.gridViewDishInfo.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(50)))), ((int)(((byte)(178)))));
            this.gridViewDishInfo.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewDishInfo.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewDishInfo.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewDishInfo.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.gridViewDishInfo.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridViewDishInfo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewDishInfo.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridViewDishInfo.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridViewDishInfo.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewDishInfo.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewDishInfo.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewDishInfo.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewDishInfo.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridViewDishInfo.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridViewDishInfo.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridViewDishInfo.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewDishInfo.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewDishInfo.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridViewDishInfo.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridViewDishInfo.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridViewDishInfo.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridViewDishInfo.Appearance.GroupPanel.BackColor = System.Drawing.Color.Black;
            this.gridViewDishInfo.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridViewDishInfo.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewDishInfo.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewDishInfo.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewDishInfo.Appearance.GroupPanel.Options.UseFont = true;
            this.gridViewDishInfo.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridViewDishInfo.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewDishInfo.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.gridViewDishInfo.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridViewDishInfo.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridViewDishInfo.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gridViewDishInfo.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridViewDishInfo.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewDishInfo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewDishInfo.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewDishInfo.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridViewDishInfo.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewDishInfo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewDishInfo.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewDishInfo.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewDishInfo.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewDishInfo.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewDishInfo.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewDishInfo.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridViewDishInfo.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridViewDishInfo.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gridViewDishInfo.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewDishInfo.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gridViewDishInfo.Appearance.OddRow.Options.UseBackColor = true;
            this.gridViewDishInfo.Appearance.OddRow.Options.UseForeColor = true;
            this.gridViewDishInfo.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.gridViewDishInfo.Appearance.Preview.BackColor2 = System.Drawing.Color.White;
            this.gridViewDishInfo.Appearance.Preview.ForeColor = System.Drawing.Color.Purple;
            this.gridViewDishInfo.Appearance.Preview.Options.UseBackColor = true;
            this.gridViewDishInfo.Appearance.Preview.Options.UseForeColor = true;
            this.gridViewDishInfo.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridViewDishInfo.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridViewDishInfo.Appearance.Row.Options.UseBackColor = true;
            this.gridViewDishInfo.Appearance.Row.Options.UseForeColor = true;
            this.gridViewDishInfo.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridViewDishInfo.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewDishInfo.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridViewDishInfo.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(10)))), ((int)(((byte)(138)))));
            this.gridViewDishInfo.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewDishInfo.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewDishInfo.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewDishInfo.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewDishInfo.Appearance.VertLine.Options.UseBackColor = true;
            this.gridViewDishInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DishID,
            this.DishName,
            this.DishType,
            this.SimpleSpell,
            this.DishCost,
            this.DishPrice,
            this.DishMeasuringUnit,
            this.RelatedGoodsName,
            this.DishStock,
            this.DishCommission,
            this.InfoNote,
            this.DishCreatePerson,
            this.DishCreateDate,
            this.DishModifyPerson,
            this.DishModifyDate});
            this.gridViewDishInfo.GridControl = this.grdctrlDishInfo;
            this.gridViewDishInfo.Name = "gridViewDishInfo";
            this.gridViewDishInfo.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewDishInfo.OptionsBehavior.Editable = false;
            this.gridViewDishInfo.OptionsPrint.EnableAppearanceOddRow = true;
            this.gridViewDishInfo.OptionsPrint.ExpandAllDetails = true;
            this.gridViewDishInfo.OptionsPrint.PrintDetails = true;
            this.gridViewDishInfo.OptionsPrint.PrintFilterInfo = true;
            this.gridViewDishInfo.OptionsPrint.PrintPreview = true;
            this.gridViewDishInfo.OptionsPrint.UsePrintStyles = true;
            this.gridViewDishInfo.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewDishInfo.OptionsView.ColumnAutoWidth = false;
            this.gridViewDishInfo.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewDishInfo.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewDishInfo.OptionsView.ShowFooter = true;
            // 
            // DishID
            // 
            this.DishID.AppearanceCell.Options.UseTextOptions = true;
            this.DishID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DishID.Caption = "菜品编号";
            this.DishID.FieldName = "编号";
            this.DishID.Name = "DishID";
            this.DishID.ToolTip = "菜品编号";
            this.DishID.Visible = true;
            this.DishID.VisibleIndex = 0;
            this.DishID.Width = 68;
            // 
            // DishName
            // 
            this.DishName.Caption = "菜品名称";
            this.DishName.FieldName = "名称";
            this.DishName.Name = "DishName";
            this.DishName.ToolTip = "菜品名称";
            this.DishName.Visible = true;
            this.DishName.VisibleIndex = 1;
            this.DishName.Width = 77;
            // 
            // DishType
            // 
            this.DishType.Caption = "菜品类别";
            this.DishType.FieldName = "类别";
            this.DishType.Name = "DishType";
            this.DishType.ToolTip = "菜品类别";
            this.DishType.Visible = true;
            this.DishType.VisibleIndex = 2;
            this.DishType.Width = 73;
            // 
            // SimpleSpell
            // 
            this.SimpleSpell.AppearanceCell.Options.UseTextOptions = true;
            this.SimpleSpell.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SimpleSpell.Caption = "助记符";
            this.SimpleSpell.FieldName = "助记符";
            this.SimpleSpell.Name = "SimpleSpell";
            this.SimpleSpell.ToolTip = "菜品助记符";
            this.SimpleSpell.Visible = true;
            this.SimpleSpell.VisibleIndex = 3;
            this.SimpleSpell.Width = 61;
            // 
            // DishCost
            // 
            this.DishCost.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DishCost.AppearanceCell.Options.UseBackColor = true;
            this.DishCost.Caption = "成本";
            this.DishCost.DisplayFormat.FormatString = "c";
            this.DishCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DishCost.FieldName = "成本";
            this.DishCost.Name = "DishCost";
            this.DishCost.ToolTip = "菜品成本";
            this.DishCost.Visible = true;
            this.DishCost.VisibleIndex = 4;
            this.DishCost.Width = 61;
            // 
            // DishPrice
            // 
            this.DishPrice.Caption = "单价";
            this.DishPrice.FieldName = "单价";
            this.DishPrice.Name = "DishPrice";
            this.DishPrice.ToolTip = "菜品单价";
            this.DishPrice.Visible = true;
            this.DishPrice.VisibleIndex = 6;
            this.DishPrice.Width = 61;
            // 
            // DishMeasuringUnit
            // 
            this.DishMeasuringUnit.Caption = "单位";
            this.DishMeasuringUnit.DisplayFormat.FormatString = "c";
            this.DishMeasuringUnit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DishMeasuringUnit.FieldName = "单位";
            this.DishMeasuringUnit.Name = "DishMeasuringUnit";
            this.DishMeasuringUnit.ToolTip = "菜品单位";
            this.DishMeasuringUnit.Visible = true;
            this.DishMeasuringUnit.VisibleIndex = 5;
            this.DishMeasuringUnit.Width = 61;
            // 
            // RelatedGoodsName
            // 
            this.RelatedGoodsName.Caption = "关联商品";
            this.RelatedGoodsName.FieldName = "关联商品名称";
            this.RelatedGoodsName.Name = "RelatedGoodsName";
            this.RelatedGoodsName.ToolTip = "关联商品名称";
            this.RelatedGoodsName.Visible = true;
            this.RelatedGoodsName.VisibleIndex = 7;
            this.RelatedGoodsName.Width = 95;
            // 
            // DishStock
            // 
            this.DishStock.Caption = "当前库存";
            this.DishStock.FieldName = "当前库存";
            this.DishStock.Name = "DishStock";
            this.DishStock.ToolTip = "菜品当前库存";
            this.DishStock.Visible = true;
            this.DishStock.VisibleIndex = 8;
            this.DishStock.Width = 87;
            // 
            // DishCommission
            // 
            this.DishCommission.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DishCommission.AppearanceCell.Options.UseBackColor = true;
            this.DishCommission.Caption = "提成";
            this.DishCommission.DisplayFormat.FormatString = "c";
            this.DishCommission.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DishCommission.FieldName = "提成";
            this.DishCommission.Name = "DishCommission";
            this.DishCommission.ToolTip = "菜品提成";
            this.DishCommission.Visible = true;
            this.DishCommission.VisibleIndex = 9;
            this.DishCommission.Width = 61;
            // 
            // InfoNote
            // 
            this.InfoNote.Caption = "信息备注";
            this.InfoNote.FieldName = "信息备注";
            this.InfoNote.Name = "InfoNote";
            this.InfoNote.ToolTip = "菜品信息备注";
            this.InfoNote.Visible = true;
            this.InfoNote.VisibleIndex = 10;
            this.InfoNote.Width = 240;
            // 
            // DishCreatePerson
            // 
            this.DishCreatePerson.Caption = "创建人";
            this.DishCreatePerson.FieldName = "创建人";
            this.DishCreatePerson.Name = "DishCreatePerson";
            this.DishCreatePerson.ToolTip = "创建人";
            this.DishCreatePerson.Visible = true;
            this.DishCreatePerson.VisibleIndex = 11;
            this.DishCreatePerson.Width = 61;
            // 
            // DishCreateDate
            // 
            this.DishCreateDate.Caption = "创建时间";
            this.DishCreateDate.DisplayFormat.FormatString = "g";
            this.DishCreateDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DishCreateDate.FieldName = "创建日期";
            this.DishCreateDate.Name = "DishCreateDate";
            this.DishCreateDate.ToolTip = "创建日期";
            this.DishCreateDate.Visible = true;
            this.DishCreateDate.VisibleIndex = 12;
            this.DishCreateDate.Width = 127;
            // 
            // DishModifyPerson
            // 
            this.DishModifyPerson.Caption = "修改人";
            this.DishModifyPerson.FieldName = "修改人";
            this.DishModifyPerson.Name = "DishModifyPerson";
            this.DishModifyPerson.ToolTip = "修改人";
            this.DishModifyPerson.Visible = true;
            this.DishModifyPerson.VisibleIndex = 13;
            this.DishModifyPerson.Width = 72;
            // 
            // DishModifyDate
            // 
            this.DishModifyDate.Caption = "修改时间";
            this.DishModifyDate.DisplayFormat.FormatString = "g";
            this.DishModifyDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DishModifyDate.FieldName = "修改日期";
            this.DishModifyDate.Name = "DishModifyDate";
            this.DishModifyDate.ToolTip = "修改日期";
            this.DishModifyDate.Visible = true;
            this.DishModifyDate.VisibleIndex = 14;
            this.DishModifyDate.Width = 128;
            // 
            // frmDishInfoMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 630);
            this.Controls.Add(this.grdctrlDishInfo);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl1);
            this.MaximizeBox = false;
            this.Name = "frmDishInfoMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "菜品信息维护";
            this.Load += new System.EventHandler(this.frmDishInfoMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDishName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbeDishType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSimpleSpell.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDishID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdctrlDishInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDishInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtDishName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbeDishType;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btnDishInfoAdd;
        private DevExpress.XtraEditors.SimpleButton btnDishInfoBack;
        private DevExpress.XtraEditors.SimpleButton btnDishInfoPrint;
        private DevExpress.XtraEditors.SimpleButton btnDishInfoOut;
        private DevExpress.XtraEditors.SimpleButton btnDishInfoAlter;
        private DevExpress.XtraEditors.SimpleButton btnDishInfoDele;
        private DevExpress.XtraGrid.GridControl grdctrlDishInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDishInfo;
        private DevExpress.XtraGrid.Columns.GridColumn DishID;
        private DevExpress.XtraGrid.Columns.GridColumn DishName;
        private DevExpress.XtraGrid.Columns.GridColumn DishType;
        private DevExpress.XtraGrid.Columns.GridColumn SimpleSpell;
        private DevExpress.XtraGrid.Columns.GridColumn DishCost;
        private DevExpress.XtraGrid.Columns.GridColumn DishMeasuringUnit;
        private DevExpress.XtraGrid.Columns.GridColumn DishPrice;
        private DevExpress.XtraGrid.Columns.GridColumn RelatedGoodsName;
        private DevExpress.XtraGrid.Columns.GridColumn DishStock;
        private DevExpress.XtraGrid.Columns.GridColumn DishCommission;
        private DevExpress.XtraGrid.Columns.GridColumn InfoNote;
        private DevExpress.XtraGrid.Columns.GridColumn DishCreatePerson;
        private DevExpress.XtraGrid.Columns.GridColumn DishCreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn DishModifyPerson;
        private DevExpress.XtraGrid.Columns.GridColumn DishModifyDate;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtSimpleSpell;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtDishID;
        private DevExpress.XtraEditors.SimpleButton btnSelectAll;
    }
}