namespace CMS.UILayer.frmBusiness
{
    partial class frmTurnoverStatistics
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.HatchFillOptions hatchFillOptions1 = new DevExpress.XtraCharts.HatchFillOptions();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel2 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.btnOut = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.groupControlMain = new DevExpress.XtraEditors.GroupControl();
            this.chartControlMain = new DevExpress.XtraCharts.ChartControl();
            this.groupControlCustomer = new DevExpress.XtraEditors.GroupControl();
            this.textTitle = new DevExpress.XtraEditors.TextEdit();
            this.cmbViewType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbHText = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControlMain = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.calCost = new DevExpress.XtraEditors.CalcEdit();
            this.MruIsVIP = new DevExpress.XtraEditors.MRUEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.lupVIPType = new DevExpress.XtraEditors.LookUpEdit();
            this.lupVIPClient = new DevExpress.XtraEditors.LookUpEdit();
            this.lupWaiter = new DevExpress.XtraEditors.LookUpEdit();
            this.btnAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.lupTableName = new DevExpress.XtraEditors.LookUpEdit();
            this.lupPayment = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmbField = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dateEnd = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblFrom = new DevExpress.XtraEditors.LabelControl();
            this.dateStart = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlMain)).BeginInit();
            this.groupControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlCustomer)).BeginInit();
            this.groupControlCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbViewType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbHText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).BeginInit();
            this.xtraTabControlMain.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MruIsVIP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupVIPType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupVIPClient.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupWaiter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupTableName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupPayment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbField.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(25, 263);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(131, 30);
            this.btnOut.TabIndex = 15;
            this.btnOut.Text = "导出图片(&O)";
            this.btnOut.ToolTip = "将图标导出为图片(Alt+O)";
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(20, 354);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(136, 30);
            this.btnPrint.TabIndex = 14;
            this.btnPrint.Text = "打印(&P)";
            this.btnPrint.ToolTip = "打印图表(&P)";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(25, 445);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(136, 30);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "返回(&B)";
            this.btnBack.ToolTip = "返回系统主界面(Alt+B/Esc)";
            // 
            // groupControlMain
            // 
            this.groupControlMain.Controls.Add(this.chartControlMain);
            this.groupControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlMain.Location = new System.Drawing.Point(0, 97);
            this.groupControlMain.Name = "groupControlMain";
            this.groupControlMain.Size = new System.Drawing.Size(829, 541);
            this.groupControlMain.TabIndex = 2;
            this.groupControlMain.Text = "统计图表";
            // 
            // chartControlMain
            // 
            this.chartControlMain.BackColor = System.Drawing.SystemColors.Info;
            xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisX.Tickmarks.CrossAxis = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.PaneDistance = 7;
            this.chartControlMain.Diagram = xyDiagram1;
            this.chartControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControlMain.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Hatch;
            hatchFillOptions1.HatchStyle = System.Drawing.Drawing2D.HatchStyle.Horizontal;
            this.chartControlMain.FillStyle.Options = hatchFillOptions1;
            this.chartControlMain.Location = new System.Drawing.Point(2, 23);
            this.chartControlMain.Name = "chartControlMain";
            this.chartControlMain.PaletteBaseColorNumber = 5;
            sideBySideBarSeriesLabel1.Antialiasing = true;
            sideBySideBarSeriesLabel1.LineVisible = true;
            sideBySideBarSeriesLabel1.ShowForZeroValues = true;
            series1.Label = sideBySideBarSeriesLabel1;
            series1.Name = "销售金额";
            this.chartControlMain.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            sideBySideBarSeriesLabel2.LineVisible = true;
            this.chartControlMain.SeriesTemplate.Label = sideBySideBarSeriesLabel2;
            this.chartControlMain.SeriesTemplate.ValueScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            this.chartControlMain.Size = new System.Drawing.Size(825, 516);
            this.chartControlMain.TabIndex = 0;
            chartTitle1.Text = "销售统计";
            chartTitle1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chartControlMain.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // groupControlCustomer
            // 
            this.groupControlCustomer.Controls.Add(this.btnBack);
            this.groupControlCustomer.Controls.Add(this.btnPrint);
            this.groupControlCustomer.Controls.Add(this.btnOut);
            this.groupControlCustomer.Controls.Add(this.textTitle);
            this.groupControlCustomer.Controls.Add(this.cmbViewType);
            this.groupControlCustomer.Controls.Add(this.cmbHText);
            this.groupControlCustomer.Controls.Add(this.labelControl6);
            this.groupControlCustomer.Controls.Add(this.labelControl3);
            this.groupControlCustomer.Controls.Add(this.labelControl1);
            this.groupControlCustomer.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControlCustomer.Location = new System.Drawing.Point(829, 97);
            this.groupControlCustomer.Name = "groupControlCustomer";
            this.groupControlCustomer.Size = new System.Drawing.Size(173, 541);
            this.groupControlCustomer.TabIndex = 3;
            this.groupControlCustomer.Text = "自定义显示统计";
            // 
            // textTitle
            // 
            this.textTitle.EditValue = "-------回车后确定-------";
            this.textTitle.Location = new System.Drawing.Point(25, 130);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(122, 21);
            this.textTitle.TabIndex = 2;
            this.textTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textTitle_KeyDown);
            this.textTitle.Click += new System.EventHandler(this.textTitle_Click);
            // 
            // cmbViewType
            // 
            this.cmbViewType.EditValue = "折线图表";
            this.cmbViewType.Location = new System.Drawing.Point(25, 59);
            this.cmbViewType.Name = "cmbViewType";
            this.cmbViewType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbViewType.Properties.Items.AddRange(new object[] {
            "折线图表",
            "柱状图表"});
            this.cmbViewType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbViewType.Size = new System.Drawing.Size(122, 21);
            this.cmbViewType.TabIndex = 1;
            this.cmbViewType.SelectedIndexChanged += new System.EventHandler(this.cmbViewType_SelectedIndexChanged);
            // 
            // cmbHText
            // 
            this.cmbHText.Location = new System.Drawing.Point(25, 202);
            this.cmbHText.Name = "cmbHText";
            this.cmbHText.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbHText.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbHText.Size = new System.Drawing.Size(131, 21);
            this.cmbHText.TabIndex = 1;
            this.cmbHText.SelectedIndexChanged += new System.EventHandler(this.cmbHText_SelectedIndexChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(25, 39);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(84, 14);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "图表显示类型：";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(25, 110);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 14);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "统计图标题：";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(25, 182);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "横坐标显示：";
            // 
            // xtraTabControlMain
            // 
            this.xtraTabControlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.xtraTabControlMain.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControlMain.Name = "xtraTabControlMain";
            this.xtraTabControlMain.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControlMain.Size = new System.Drawing.Size(1002, 97);
            this.xtraTabControlMain.TabIndex = 4;
            this.xtraTabControlMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.groupControl3);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(995, 67);
            this.xtraTabPage1.Text = "按消费账单查询";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.calCost);
            this.groupControl3.Controls.Add(this.MruIsVIP);
            this.groupControl3.Controls.Add(this.txtID);
            this.groupControl3.Controls.Add(this.lupVIPType);
            this.groupControl3.Controls.Add(this.lupVIPClient);
            this.groupControl3.Controls.Add(this.lupWaiter);
            this.groupControl3.Controls.Add(this.btnAll);
            this.groupControl3.Controls.Add(this.btnSearch);
            this.groupControl3.Controls.Add(this.lupTableName);
            this.groupControl3.Controls.Add(this.lupPayment);
            this.groupControl3.Controls.Add(this.labelControl4);
            this.groupControl3.Controls.Add(this.cmbField);
            this.groupControl3.Controls.Add(this.dateEnd);
            this.groupControl3.Controls.Add(this.labelControl5);
            this.groupControl3.Controls.Add(this.lblFrom);
            this.groupControl3.Controls.Add(this.dateStart);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.ShowCaption = false;
            this.groupControl3.Size = new System.Drawing.Size(995, 67);
            this.groupControl3.TabIndex = 53;
            this.groupControl3.Text = "日志查询";
            // 
            // calCost
            // 
            this.calCost.Location = new System.Drawing.Point(310, 23);
            this.calCost.Name = "calCost";
            this.calCost.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calCost.Size = new System.Drawing.Size(218, 21);
            this.calCost.TabIndex = 81;
            // 
            // MruIsVIP
            // 
            this.MruIsVIP.EditValue = "否";
            this.MruIsVIP.Location = new System.Drawing.Point(310, 23);
            this.MruIsVIP.Name = "MruIsVIP";
            this.MruIsVIP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.MruIsVIP.Properties.Items.AddRange(new object[] {
            "否",
            "是"});
            this.MruIsVIP.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.MruIsVIP.Size = new System.Drawing.Size(218, 21);
            this.MruIsVIP.TabIndex = 80;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(310, 23);
            this.txtID.Name = "txtID";
            this.txtID.Properties.Mask.EditMask = "d";
            this.txtID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtID.Size = new System.Drawing.Size(218, 21);
            this.txtID.TabIndex = 79;
            // 
            // lupVIPType
            // 
            this.lupVIPType.Location = new System.Drawing.Point(310, 23);
            this.lupVIPType.Name = "lupVIPType";
            this.lupVIPType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupVIPType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "会员卡类型"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Discount", "折扣")});
            this.lupVIPType.Properties.DisplayMember = "Name";
            this.lupVIPType.Size = new System.Drawing.Size(218, 21);
            this.lupVIPType.TabIndex = 78;
            // 
            // lupVIPClient
            // 
            this.lupVIPClient.Location = new System.Drawing.Point(310, 23);
            this.lupVIPClient.Name = "lupVIPClient";
            this.lupVIPClient.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupVIPClient.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "会员姓名")});
            this.lupVIPClient.Properties.DisplayMember = "Name";
            this.lupVIPClient.Size = new System.Drawing.Size(218, 21);
            this.lupVIPClient.TabIndex = 77;
            // 
            // lupWaiter
            // 
            this.lupWaiter.Location = new System.Drawing.Point(310, 23);
            this.lupWaiter.Name = "lupWaiter";
            this.lupWaiter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupWaiter.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "服务员")});
            this.lupWaiter.Properties.DisplayMember = "Name";
            this.lupWaiter.Properties.ShowHeader = false;
            this.lupWaiter.Size = new System.Drawing.Size(218, 21);
            this.lupWaiter.TabIndex = 75;
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(899, 21);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(75, 23);
            this.btnAll.TabIndex = 73;
            this.btnAll.Text = "全部(&A)";
            this.btnAll.ToolTip = "统计全部营业额(Alt+A)";
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(806, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 56;
            this.btnSearch.Text = "统计(&S)";
            this.btnSearch.ToolTip = "统计满足条件的营业记录(Alt+S/Enter)";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lupTableName
            // 
            this.lupTableName.Location = new System.Drawing.Point(310, 23);
            this.lupTableName.Name = "lupTableName";
            this.lupTableName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupTableName.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "餐台名称")});
            this.lupTableName.Properties.DisplayMember = "Name";
            this.lupTableName.Size = new System.Drawing.Size(218, 21);
            this.lupTableName.TabIndex = 55;
            // 
            // lupPayment
            // 
            this.lupPayment.Location = new System.Drawing.Point(310, 23);
            this.lupPayment.Name = "lupPayment";
            this.lupPayment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupPayment.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "支付方式")});
            this.lupPayment.Properties.DisplayMember = "Name";
            this.lupPayment.Properties.ShowHeader = false;
            this.lupPayment.Size = new System.Drawing.Size(218, 21);
            this.lupPayment.TabIndex = 55;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(43, 25);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 14);
            this.labelControl4.TabIndex = 50;
            this.labelControl4.Text = "按：";
            // 
            // cmbField
            // 
            this.cmbField.EditValue = "消费日期";
            this.cmbField.Location = new System.Drawing.Point(69, 22);
            this.cmbField.Name = "cmbField";
            this.cmbField.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbField.Properties.Items.AddRange(new object[] {
            "餐台名称",
            "是否会员",
            "会员姓名",
            "会员卡类型",
            "服务员",
            "支付方式",
            "消费日期"});
            this.cmbField.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbField.Size = new System.Drawing.Size(152, 21);
            this.cmbField.TabIndex = 51;
            this.cmbField.SelectedIndexChanged += new System.EventHandler(this.cmbField_SelectedIndexChanged);
            // 
            // dateEnd
            // 
            this.dateEnd.EditValue = new System.DateTime(2013, 2, 5, 0, 0, 0, 0);
            this.dateEnd.Location = new System.Drawing.Point(559, 23);
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
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(244, 25);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 14);
            this.labelControl5.TabIndex = 44;
            this.labelControl5.Text = "第二条件：";
            // 
            // lblFrom
            // 
            this.lblFrom.Location = new System.Drawing.Point(540, 26);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(12, 14);
            this.lblFrom.TabIndex = 46;
            this.lblFrom.Text = "至";
            // 
            // dateStart
            // 
            this.dateStart.EditValue = new System.DateTime(2013, 1, 25, 0, 0, 0, 0);
            this.dateStart.Location = new System.Drawing.Point(310, 23);
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
            // frmTurnoverStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 638);
            this.Controls.Add(this.groupControlMain);
            this.Controls.Add(this.groupControlCustomer);
            this.Controls.Add(this.xtraTabControlMain);
            this.Name = "frmTurnoverStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "营业额统计";
            this.Load += new System.EventHandler(this.frmTurnoverStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlMain)).EndInit();
            this.groupControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlCustomer)).EndInit();
            this.groupControlCustomer.ResumeLayout(false);
            this.groupControlCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbViewType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbHText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).EndInit();
            this.xtraTabControlMain.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MruIsVIP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupVIPType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupVIPClient.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupWaiter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupTableName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupPayment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbField.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnOut;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.GroupControl groupControlMain;
        private DevExpress.XtraCharts.ChartControl chartControlMain;
        private DevExpress.XtraEditors.GroupControl groupControlCustomer;
        private DevExpress.XtraEditors.ComboBoxEdit cmbHText;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textTitle;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraTab.XtraTabControl xtraTabControlMain;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.CalcEdit calCost;
        private DevExpress.XtraEditors.MRUEdit MruIsVIP;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LookUpEdit lupVIPType;
        private DevExpress.XtraEditors.LookUpEdit lupVIPClient;
        private DevExpress.XtraEditors.LookUpEdit lupWaiter;
        private DevExpress.XtraEditors.SimpleButton btnAll;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.LookUpEdit lupTableName;
        private DevExpress.XtraEditors.LookUpEdit lupPayment;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cmbField;
        private DevExpress.XtraEditors.DateEdit dateEnd;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lblFrom;
        private DevExpress.XtraEditors.DateEdit dateStart;
        private DevExpress.XtraEditors.ComboBoxEdit cmbViewType;
        private DevExpress.XtraEditors.LabelControl labelControl6;


    }
}