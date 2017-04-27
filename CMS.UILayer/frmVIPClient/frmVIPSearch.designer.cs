namespace CMS.UILayer.frmVIPClient
{
    partial class frmVIPSearch
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
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.dateStart = new DevExpress.XtraEditors.DateEdit();
            this.mruPhone = new DevExpress.XtraEditors.MRUEdit();
            this.mruName = new DevExpress.XtraEditors.MRUEdit();
            this.mruID = new DevExpress.XtraEditors.MRUEdit();
            this.lblFrom = new DevExpress.XtraEditors.LabelControl();
            this.lupVIPType = new DevExpress.XtraEditors.LookUpEdit();
            this.dateEnd = new DevExpress.XtraEditors.DateEdit();
            this.btnAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.cmbField = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lblSecondCondition = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.txtCash = new DevExpress.XtraEditors.TextEdit();
            this.txtVIPCost = new DevExpress.XtraEditors.TextEdit();
            this.txtVIPDiscount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtVIPName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlVIPInfo = new DevExpress.XtraGrid.GridControl();
            this.gridViewVIPInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.VIPID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VIPName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VIPSex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VIPType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VIPDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VIPCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VIPPosition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VIPPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VIPDepName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VIPAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VIPInfoNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VIPCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mruPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mruName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mruID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupVIPType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbField.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCash.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVIPCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVIPDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVIPName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlVIPInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVIPInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.dateStart);
            this.groupControl4.Controls.Add(this.mruPhone);
            this.groupControl4.Controls.Add(this.mruName);
            this.groupControl4.Controls.Add(this.mruID);
            this.groupControl4.Controls.Add(this.lblFrom);
            this.groupControl4.Controls.Add(this.lupVIPType);
            this.groupControl4.Controls.Add(this.dateEnd);
            this.groupControl4.Controls.Add(this.btnAll);
            this.groupControl4.Controls.Add(this.btnSearch);
            this.groupControl4.Controls.Add(this.cmbField);
            this.groupControl4.Controls.Add(this.labelControl4);
            this.groupControl4.Controls.Add(this.lblSecondCondition);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl4.Location = new System.Drawing.Point(0, 0);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(923, 71);
            this.groupControl4.TabIndex = 6;
            this.groupControl4.Text = "查询区";
            // 
            // dateStart
            // 
            this.dateStart.EditValue = new System.DateTime(2013, 3, 1, 0, 0, 0, 0);
            this.dateStart.Location = new System.Drawing.Point(235, 35);
            this.dateStart.Name = "dateStart";
            this.dateStart.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dateStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStart.Properties.DisplayFormat.FormatString = "D";
            this.dateStart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateStart.Properties.EditFormat.FormatString = "D";
            this.dateStart.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateStart.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateStart.Size = new System.Drawing.Size(218, 21);
            this.dateStart.TabIndex = 7;
            // 
            // mruPhone
            // 
            this.mruPhone.Location = new System.Drawing.Point(235, 35);
            this.mruPhone.Name = "mruPhone";
            this.mruPhone.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mruPhone.Size = new System.Drawing.Size(218, 21);
            this.mruPhone.TabIndex = 11;
            // 
            // mruName
            // 
            this.mruName.Location = new System.Drawing.Point(235, 35);
            this.mruName.Name = "mruName";
            this.mruName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mruName.Size = new System.Drawing.Size(218, 21);
            this.mruName.TabIndex = 10;
            // 
            // mruID
            // 
            this.mruID.Location = new System.Drawing.Point(235, 35);
            this.mruID.Name = "mruID";
            this.mruID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mruID.Size = new System.Drawing.Size(218, 21);
            this.mruID.TabIndex = 6;
            // 
            // lblFrom
            // 
            this.lblFrom.Location = new System.Drawing.Point(458, 38);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(12, 14);
            this.lblFrom.TabIndex = 9;
            this.lblFrom.Text = "至";
            // 
            // lupVIPType
            // 
            this.lupVIPType.Location = new System.Drawing.Point(235, 35);
            this.lupVIPType.Name = "lupVIPType";
            this.lupVIPType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupVIPType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "会员卡编号"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "会员卡名称"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Discount", "会员折扣")});
            this.lupVIPType.Properties.DisplayMember = "Name";
            this.lupVIPType.Properties.ValueMember = "ID";
            this.lupVIPType.Size = new System.Drawing.Size(218, 21);
            this.lupVIPType.TabIndex = 5;
            // 
            // dateEnd
            // 
            this.dateEnd.EditValue = new System.DateTime(2013, 3, 1, 0, 0, 0, 0);
            this.dateEnd.Location = new System.Drawing.Point(476, 35);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEnd.Properties.DisplayFormat.FormatString = "D";
            this.dateEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEnd.Properties.EditFormat.FormatString = "D";
            this.dateEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEnd.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEnd.Size = new System.Drawing.Size(218, 21);
            this.dateEnd.TabIndex = 8;
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(818, 33);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(72, 23);
            this.btnAll.TabIndex = 2;
            this.btnAll.Text = "全部(&A)";
            this.btnAll.ToolTip = "全部信息(Alt+A)";
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(718, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查询(&S)";
            this.btnSearch.ToolTip = "信息查询(Alt+S)";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbField
            // 
            this.cmbField.EditValue = "姓名";
            this.cmbField.Location = new System.Drawing.Point(51, 35);
            this.cmbField.Name = "cmbField";
            this.cmbField.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbField.Properties.Items.AddRange(new object[] {
            "编号",
            "姓名",
            "会员卡",
            "电话",
            "注册时间"});
            this.cmbField.Size = new System.Drawing.Size(106, 21);
            this.cmbField.TabIndex = 1;
            this.cmbField.TabStop = false;
            this.cmbField.SelectedIndexChanged += new System.EventHandler(this.cmbField_SelectedIndexChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(25, 38);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 14);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "按：";
            // 
            // lblSecondCondition
            // 
            this.lblSecondCondition.Location = new System.Drawing.Point(174, 38);
            this.lblSecondCondition.Name = "lblSecondCondition";
            this.lblSecondCondition.Size = new System.Drawing.Size(60, 14);
            this.lblSecondCondition.TabIndex = 0;
            this.lblSecondCondition.Text = "第二条件：";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.txtCash);
            this.groupControl3.Controls.Add(this.txtVIPCost);
            this.groupControl3.Controls.Add(this.txtVIPDiscount);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Controls.Add(this.txtVIPName);
            this.groupControl3.Controls.Add(this.labelControl5);
            this.groupControl3.Controls.Add(this.labelControl1);
            this.groupControl3.Controls.Add(this.btnOK);
            this.groupControl3.Controls.Add(this.labelControl2);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl3.Location = new System.Drawing.Point(0, 71);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(923, 71);
            this.groupControl3.TabIndex = 7;
            this.groupControl3.Text = "会员卡信息";
            // 
            // txtCash
            // 
            this.txtCash.Location = new System.Drawing.Point(672, 36);
            this.txtCash.Name = "txtCash";
            this.txtCash.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtCash.Properties.Appearance.Options.UseForeColor = true;
            this.txtCash.Properties.DisplayFormat.FormatString = "c";
            this.txtCash.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCash.Properties.ReadOnly = true;
            this.txtCash.Size = new System.Drawing.Size(118, 21);
            this.txtCash.TabIndex = 1;
            // 
            // txtVIPCost
            // 
            this.txtVIPCost.Location = new System.Drawing.Point(467, 35);
            this.txtVIPCost.Name = "txtVIPCost";
            this.txtVIPCost.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtVIPCost.Properties.Appearance.Options.UseForeColor = true;
            this.txtVIPCost.Properties.DisplayFormat.FormatString = "c";
            this.txtVIPCost.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtVIPCost.Properties.ReadOnly = true;
            this.txtVIPCost.Size = new System.Drawing.Size(109, 21);
            this.txtVIPCost.TabIndex = 1;
            this.txtVIPCost.EditValueChanged += new System.EventHandler(this.txtVIPCost_EditValueChanged);
            // 
            // txtVIPDiscount
            // 
            this.txtVIPDiscount.Location = new System.Drawing.Point(277, 35);
            this.txtVIPDiscount.Name = "txtVIPDiscount";
            this.txtVIPDiscount.Properties.DisplayFormat.FormatString = "{0}折";
            this.txtVIPDiscount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtVIPDiscount.Properties.ReadOnly = true;
            this.txtVIPDiscount.Size = new System.Drawing.Size(72, 21);
            this.txtVIPDiscount.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(621, 39);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "可抵现：";
            // 
            // txtVIPName
            // 
            this.txtVIPName.Location = new System.Drawing.Point(103, 36);
            this.txtVIPName.Name = "txtVIPName";
            this.txtVIPName.Properties.ReadOnly = true;
            this.txtVIPName.Size = new System.Drawing.Size(103, 21);
            this.txtVIPName.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(404, 38);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 14);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "卡上余额：";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(25, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "会员卡名称：";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(818, 34);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(72, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.ToolTip = "确定选择并返回(&B)(Alt+O/Enter)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(238, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "折扣：";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlVIPInfo);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 142);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(923, 325);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "已注册会员";
            // 
            // gridControlVIPInfo
            // 
            this.gridControlVIPInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlVIPInfo.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlVIPInfo.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlVIPInfo.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlVIPInfo.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlVIPInfo.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlVIPInfo.Location = new System.Drawing.Point(2, 23);
            this.gridControlVIPInfo.MainView = this.gridViewVIPInfo;
            this.gridControlVIPInfo.Name = "gridControlVIPInfo";
            this.gridControlVIPInfo.Size = new System.Drawing.Size(919, 300);
            this.gridControlVIPInfo.TabIndex = 0;
            this.gridControlVIPInfo.UseEmbeddedNavigator = true;
            this.gridControlVIPInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewVIPInfo});
            // 
            // gridViewVIPInfo
            // 
            this.gridViewVIPInfo.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewVIPInfo.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewVIPInfo.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewVIPInfo.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gridViewVIPInfo.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridViewVIPInfo.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridViewVIPInfo.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridViewVIPInfo.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewVIPInfo.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gridViewVIPInfo.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewVIPInfo.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gridViewVIPInfo.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridViewVIPInfo.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridViewVIPInfo.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridViewVIPInfo.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewVIPInfo.Appearance.Empty.Options.UseBackColor = true;
            this.gridViewVIPInfo.Appearance.EvenRow.BackColor = System.Drawing.Color.Silver;
            this.gridViewVIPInfo.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.gridViewVIPInfo.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewVIPInfo.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewVIPInfo.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridViewVIPInfo.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridViewVIPInfo.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewVIPInfo.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.gridViewVIPInfo.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewVIPInfo.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewVIPInfo.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewVIPInfo.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridViewVIPInfo.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridViewVIPInfo.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridViewVIPInfo.Appearance.FilterPanel.BackColor = System.Drawing.Color.Black;
            this.gridViewVIPInfo.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewVIPInfo.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewVIPInfo.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewVIPInfo.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridViewVIPInfo.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridViewVIPInfo.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gridViewVIPInfo.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridViewVIPInfo.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gridViewVIPInfo.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Purple;
            this.gridViewVIPInfo.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridViewVIPInfo.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridViewVIPInfo.Appearance.FocusedRow.BackColor = System.Drawing.Color.Purple;
            this.gridViewVIPInfo.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(50)))), ((int)(((byte)(178)))));
            this.gridViewVIPInfo.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewVIPInfo.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewVIPInfo.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewVIPInfo.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.gridViewVIPInfo.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridViewVIPInfo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewVIPInfo.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridViewVIPInfo.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridViewVIPInfo.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewVIPInfo.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewVIPInfo.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewVIPInfo.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewVIPInfo.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridViewVIPInfo.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridViewVIPInfo.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridViewVIPInfo.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewVIPInfo.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewVIPInfo.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridViewVIPInfo.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridViewVIPInfo.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridViewVIPInfo.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridViewVIPInfo.Appearance.GroupPanel.BackColor = System.Drawing.Color.Black;
            this.gridViewVIPInfo.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridViewVIPInfo.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewVIPInfo.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewVIPInfo.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewVIPInfo.Appearance.GroupPanel.Options.UseFont = true;
            this.gridViewVIPInfo.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridViewVIPInfo.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewVIPInfo.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.gridViewVIPInfo.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridViewVIPInfo.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridViewVIPInfo.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gridViewVIPInfo.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridViewVIPInfo.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewVIPInfo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewVIPInfo.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewVIPInfo.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridViewVIPInfo.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewVIPInfo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewVIPInfo.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewVIPInfo.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewVIPInfo.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewVIPInfo.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewVIPInfo.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewVIPInfo.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridViewVIPInfo.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridViewVIPInfo.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gridViewVIPInfo.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewVIPInfo.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gridViewVIPInfo.Appearance.OddRow.Options.UseBackColor = true;
            this.gridViewVIPInfo.Appearance.OddRow.Options.UseForeColor = true;
            this.gridViewVIPInfo.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.gridViewVIPInfo.Appearance.Preview.BackColor2 = System.Drawing.Color.White;
            this.gridViewVIPInfo.Appearance.Preview.ForeColor = System.Drawing.Color.Purple;
            this.gridViewVIPInfo.Appearance.Preview.Options.UseBackColor = true;
            this.gridViewVIPInfo.Appearance.Preview.Options.UseForeColor = true;
            this.gridViewVIPInfo.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridViewVIPInfo.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridViewVIPInfo.Appearance.Row.Options.UseBackColor = true;
            this.gridViewVIPInfo.Appearance.Row.Options.UseForeColor = true;
            this.gridViewVIPInfo.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridViewVIPInfo.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewVIPInfo.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridViewVIPInfo.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(10)))), ((int)(((byte)(138)))));
            this.gridViewVIPInfo.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewVIPInfo.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewVIPInfo.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewVIPInfo.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewVIPInfo.Appearance.VertLine.Options.UseBackColor = true;
            this.gridViewVIPInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.VIPID,
            this.VIPName,
            this.VIPSex,
            this.VIPType,
            this.VIPDiscount,
            this.VIPCost,
            this.VIPPosition,
            this.VIPPhone,
            this.VIPDepName,
            this.VIPAddress,
            this.VIPInfoNote,
            this.VIPCreateDate});
            this.gridViewVIPInfo.GridControl = this.gridControlVIPInfo;
            this.gridViewVIPInfo.Name = "gridViewVIPInfo";
            this.gridViewVIPInfo.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewVIPInfo.OptionsBehavior.Editable = false;
            this.gridViewVIPInfo.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewVIPInfo.OptionsSelection.MultiSelect = true;
            this.gridViewVIPInfo.OptionsView.ColumnAutoWidth = false;
            this.gridViewVIPInfo.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewVIPInfo.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewVIPInfo.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridViewOne_SelectionChanged);
            this.gridViewVIPInfo.DoubleClick += new System.EventHandler(this.gridViewVIPInfo_DoubleClick);
            // 
            // VIPID
            // 
            this.VIPID.Caption = "编号";
            this.VIPID.FieldName = "ID";
            this.VIPID.Name = "VIPID";
            this.VIPID.Visible = true;
            this.VIPID.VisibleIndex = 0;
            this.VIPID.Width = 55;
            // 
            // VIPName
            // 
            this.VIPName.Caption = "姓名";
            this.VIPName.FieldName = "Name";
            this.VIPName.Name = "VIPName";
            this.VIPName.Visible = true;
            this.VIPName.VisibleIndex = 1;
            this.VIPName.Width = 60;
            // 
            // VIPSex
            // 
            this.VIPSex.Caption = "性别";
            this.VIPSex.FieldName = "Sex";
            this.VIPSex.Name = "VIPSex";
            this.VIPSex.Visible = true;
            this.VIPSex.VisibleIndex = 2;
            this.VIPSex.Width = 60;
            // 
            // VIPType
            // 
            this.VIPType.Caption = "会员卡";
            this.VIPType.FieldName = "VIPTypeName";
            this.VIPType.Name = "VIPType";
            this.VIPType.ToolTip = "会员卡";
            this.VIPType.Visible = true;
            this.VIPType.VisibleIndex = 3;
            // 
            // VIPDiscount
            // 
            this.VIPDiscount.Caption = "折扣";
            this.VIPDiscount.DisplayFormat.FormatString = "{0}折";
            this.VIPDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.VIPDiscount.FieldName = "Discount";
            this.VIPDiscount.Name = "VIPDiscount";
            this.VIPDiscount.ToolTip = "折扣";
            this.VIPDiscount.Visible = true;
            this.VIPDiscount.VisibleIndex = 4;
            this.VIPDiscount.Width = 60;
            // 
            // VIPCost
            // 
            this.VIPCost.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.VIPCost.AppearanceCell.Options.UseBackColor = true;
            this.VIPCost.Caption = "可用余额";
            this.VIPCost.DisplayFormat.FormatString = "c";
            this.VIPCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.VIPCost.FieldName = "VIPCost";
            this.VIPCost.Name = "VIPCost";
            this.VIPCost.ToolTip = "可用余额";
            this.VIPCost.Visible = true;
            this.VIPCost.VisibleIndex = 5;
            // 
            // VIPPosition
            // 
            this.VIPPosition.Caption = "职位";
            this.VIPPosition.FieldName = "Position";
            this.VIPPosition.Name = "VIPPosition";
            this.VIPPosition.Visible = true;
            this.VIPPosition.VisibleIndex = 8;
            this.VIPPosition.Width = 95;
            // 
            // VIPPhone
            // 
            this.VIPPhone.Caption = "电话";
            this.VIPPhone.FieldName = "TelPhone";
            this.VIPPhone.Name = "VIPPhone";
            this.VIPPhone.Visible = true;
            this.VIPPhone.VisibleIndex = 6;
            this.VIPPhone.Width = 125;
            // 
            // VIPDepName
            // 
            this.VIPDepName.Caption = "单位名称";
            this.VIPDepName.FieldName = "DepName";
            this.VIPDepName.Name = "VIPDepName";
            this.VIPDepName.Visible = true;
            this.VIPDepName.VisibleIndex = 7;
            this.VIPDepName.Width = 125;
            // 
            // VIPAddress
            // 
            this.VIPAddress.Caption = "地址";
            this.VIPAddress.FieldName = "Address";
            this.VIPAddress.Name = "VIPAddress";
            this.VIPAddress.Visible = true;
            this.VIPAddress.VisibleIndex = 9;
            this.VIPAddress.Width = 149;
            // 
            // VIPInfoNote
            // 
            this.VIPInfoNote.Caption = "备注";
            this.VIPInfoNote.FieldName = "InfoNote";
            this.VIPInfoNote.Name = "VIPInfoNote";
            this.VIPInfoNote.Visible = true;
            this.VIPInfoNote.VisibleIndex = 10;
            this.VIPInfoNote.Width = 127;
            // 
            // VIPCreateDate
            // 
            this.VIPCreateDate.Caption = "注册时间";
            this.VIPCreateDate.DisplayFormat.FormatString = "g";
            this.VIPCreateDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.VIPCreateDate.FieldName = "CreateDate";
            this.VIPCreateDate.Name = "VIPCreateDate";
            this.VIPCreateDate.ToolTip = "注册时间";
            this.VIPCreateDate.Visible = true;
            this.VIPCreateDate.VisibleIndex = 11;
            this.VIPCreateDate.Width = 110;
            // 
            // frmVIPSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 467);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVIPSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "会员信息查询";
            this.Load += new System.EventHandler(this.frmVIPSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mruPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mruName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mruID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupVIPType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbField.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCash.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVIPCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVIPDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVIPName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlVIPInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVIPInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.DateEdit dateStart;
        private DevExpress.XtraEditors.MRUEdit mruPhone;
        private DevExpress.XtraEditors.MRUEdit mruName;
        private DevExpress.XtraEditors.MRUEdit mruID;
        private DevExpress.XtraEditors.LabelControl lblFrom;
        private DevExpress.XtraEditors.LookUpEdit lupVIPType;
        private DevExpress.XtraEditors.DateEdit dateEnd;
        private DevExpress.XtraEditors.SimpleButton btnAll;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.ComboBoxEdit cmbField;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lblSecondCondition;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.TextEdit txtVIPCost;
        private DevExpress.XtraEditors.TextEdit txtVIPDiscount;
        private DevExpress.XtraEditors.TextEdit txtVIPName;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControlVIPInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewVIPInfo;
        private DevExpress.XtraGrid.Columns.GridColumn VIPID;
        private DevExpress.XtraGrid.Columns.GridColumn VIPName;
        private DevExpress.XtraGrid.Columns.GridColumn VIPSex;
        private DevExpress.XtraGrid.Columns.GridColumn VIPType;
        private DevExpress.XtraGrid.Columns.GridColumn VIPCost;
        private DevExpress.XtraGrid.Columns.GridColumn VIPDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn VIPPosition;
        private DevExpress.XtraGrid.Columns.GridColumn VIPDepName;
        private DevExpress.XtraGrid.Columns.GridColumn VIPPhone;
        private DevExpress.XtraGrid.Columns.GridColumn VIPAddress;
        private DevExpress.XtraGrid.Columns.GridColumn VIPInfoNote;
        private DevExpress.XtraGrid.Columns.GridColumn VIPCreateDate;
        private DevExpress.XtraEditors.TextEdit txtCash;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnOK;
    }
}