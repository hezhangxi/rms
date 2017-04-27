namespace CMS.UILayer.frmAssist
{
    partial class frmBAMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBAMain));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.IsPresent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.barManagerMain = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barBtnBuffetOpen = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnOver = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnBuffetBook = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnBuffetStatus = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSeach = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAddCon = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnExchange = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnTogether = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnBillO = new DevExpress.XtraBars.BarButtonItem();
            this.btnFloor = new DevExpress.XtraBars.BarButtonItem();
            this.btnRoomType = new DevExpress.XtraBars.BarButtonItem();
            this.btnBuffetStatus = new DevExpress.XtraBars.BarButtonItem();
            this.barItemRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCDisplay = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnFloor = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnRoomType = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnStatus = new DevExpress.XtraBars.BarButtonItem();
            this.imgcolToolBar = new DevExpress.Utils.ImageCollection(this.components);
            this.imgOther = new System.Windows.Forms.ImageList(this.components);
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barLinkContainerItem1 = new DevExpress.XtraBars.BarLinkContainerItem();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.imgcolMidbtn = new DevExpress.Utils.ImageCollection(this.components);
            this.imglstBuffetState = new System.Windows.Forms.ImageList(this.components);
            this.toolTipControllerMain = new DevExpress.Utils.ToolTipController(this.components);
            this.popupMenuMain = new DevExpress.XtraBars.PopupMenu(this.components);
            this.groupControlDetail = new DevExpress.XtraEditors.GroupControl();
            this.gridControlItem = new DevExpress.XtraGrid.GridControl();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DishName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DishType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Taste = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControlMiddle = new DevExpress.XtraEditors.GroupControl();
            this.btnShow = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnCDisplay = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControlMain = new DevExpress.XtraTab.XtraTabControl();
            this.splitContainerControlMain = new DevExpress.XtraEditors.SplitContainerControl();
            this.popupMenuShowBuffet = new DevExpress.XtraBars.PopupMenu(this.components);
            this.popupMenuAll = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcolToolBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcolMidbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDetail)).BeginInit();
            this.groupControlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlMiddle)).BeginInit();
            this.groupControlMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlMain)).BeginInit();
            this.splitContainerControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuShowBuffet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuAll)).BeginInit();
            this.SuspendLayout();
            // 
            // IsPresent
            // 
            this.IsPresent.Caption = "是否赠菜";
            this.IsPresent.ColumnEdit = this.repositoryItemCheckEdit1;
            this.IsPresent.FieldName = "是否赠菜";
            this.IsPresent.Name = "IsPresent";
            this.IsPresent.ToolTip = "是否赠菜";
            this.IsPresent.Visible = true;
            this.IsPresent.VisibleIndex = 3;
            this.IsPresent.Width = 74;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // barManagerMain
            // 
            this.barManagerMain.Categories.AddRange(new DevExpress.XtraBars.BarManagerCategory[] {
            new DevExpress.XtraBars.BarManagerCategory("popupMenuShowBuffet", new System.Guid("420bd250-4f24-4da7-a5e2-f329bbf9d6f7"))});
            this.barManagerMain.DockControls.Add(this.barDockControlTop);
            this.barManagerMain.DockControls.Add(this.barDockControlBottom);
            this.barManagerMain.DockControls.Add(this.barDockControlLeft);
            this.barManagerMain.DockControls.Add(this.barDockControlRight);
            this.barManagerMain.Form = this;
            this.barManagerMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnBuffetOpen,
            this.barBtnOver,
            this.barBtnBuffetBook,
            this.barBtnBuffetStatus,
            this.barBtnSeach,
            this.barBtnAddCon,
            this.barBtnExchange,
            this.barBtnTogether,
            this.barBtnBillO,
            this.btnFloor,
            this.btnRoomType,
            this.btnBuffetStatus,
            this.barItemRefresh,
            this.barBtnCDisplay,
            this.barBtnFloor,
            this.barBtnRoomType,
            this.barBtnStatus});
            this.barManagerMain.LargeImages = this.imgcolToolBar;
            this.barManagerMain.MaxItemId = 91;
            // 
            // barBtnBuffetOpen
            // 
            this.barBtnBuffetOpen.Caption = "开餐台(F1)";
            this.barBtnBuffetOpen.Id = 74;
            this.barBtnBuffetOpen.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F1);
            this.barBtnBuffetOpen.Name = "barBtnBuffetOpen";
            this.barBtnBuffetOpen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnBuffetOpen_ItemClick);
            // 
            // barBtnOver
            // 
            this.barBtnOver.Caption = "结账(F2)";
            this.barBtnOver.Id = 75;
            this.barBtnOver.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2);
            this.barBtnOver.Name = "barBtnOver";
            this.barBtnOver.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnOver_ItemClick);
            // 
            // barBtnBuffetBook
            // 
            this.barBtnBuffetBook.Caption = "餐台预定(&B)";
            this.barBtnBuffetBook.Id = 76;
            this.barBtnBuffetBook.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B));
            this.barBtnBuffetBook.Name = "barBtnBuffetBook";
            this.barBtnBuffetBook.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnBuffetBook_ItemClick);
            // 
            // barBtnBuffetStatus
            // 
            this.barBtnBuffetStatus.Caption = "更改餐台状态(&S)";
            this.barBtnBuffetStatus.Id = 77;
            this.barBtnBuffetStatus.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.barBtnBuffetStatus.Name = "barBtnBuffetStatus";
            this.barBtnBuffetStatus.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnBuffetStatus_ItemClick);
            // 
            // barBtnSeach
            // 
            this.barBtnSeach.Caption = "预定信息查看(&C)";
            this.barBtnSeach.Id = 78;
            this.barBtnSeach.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C));
            this.barBtnSeach.Name = "barBtnSeach";
            this.barBtnSeach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSeach_ItemClick);
            // 
            // barBtnAddCon
            // 
            this.barBtnAddCon.Caption = "增加消费(&A)";
            this.barBtnAddCon.Id = 79;
            this.barBtnAddCon.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A));
            this.barBtnAddCon.Name = "barBtnAddCon";
            this.barBtnAddCon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAddCon_ItemClick);
            // 
            // barBtnExchange
            // 
            this.barBtnExchange.Caption = "更换餐台(&E)";
            this.barBtnExchange.Id = 80;
            this.barBtnExchange.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E));
            this.barBtnExchange.Name = "barBtnExchange";
            // 
            // barBtnTogether
            // 
            this.barBtnTogether.Caption = "账单合并(&X)";
            this.barBtnTogether.Id = 81;
            this.barBtnTogether.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X));
            this.barBtnTogether.Name = "barBtnTogether";
            // 
            // barBtnBillO
            // 
            this.barBtnBillO.Caption = "账单拆分(&Y)";
            this.barBtnBillO.Id = 82;
            this.barBtnBillO.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y));
            this.barBtnBillO.Name = "barBtnBillO";
            // 
            // btnFloor
            // 
            this.btnFloor.Caption = "按楼层分类查看";
            this.btnFloor.CategoryGuid = new System.Guid("420bd250-4f24-4da7-a5e2-f329bbf9d6f7");
            this.btnFloor.Id = 83;
            this.btnFloor.Name = "btnFloor";
            this.btnFloor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFloor_ItemClick);
            // 
            // btnRoomType
            // 
            this.btnRoomType.Caption = "按包厢分类查看";
            this.btnRoomType.CategoryGuid = new System.Guid("420bd250-4f24-4da7-a5e2-f329bbf9d6f7");
            this.btnRoomType.Id = 84;
            this.btnRoomType.Name = "btnRoomType";
            this.btnRoomType.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRoomType_ItemClick);
            // 
            // btnBuffetStatus
            // 
            this.btnBuffetStatus.Caption = "按餐台使用状态";
            this.btnBuffetStatus.CategoryGuid = new System.Guid("420bd250-4f24-4da7-a5e2-f329bbf9d6f7");
            this.btnBuffetStatus.Id = 85;
            this.btnBuffetStatus.Name = "btnBuffetStatus";
            this.btnBuffetStatus.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBuffetStatus_ItemClick);
            // 
            // barItemRefresh
            // 
            this.barItemRefresh.Caption = "刷新所有(F5)";
            this.barItemRefresh.Id = 86;
            this.barItemRefresh.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.barItemRefresh.Name = "barItemRefresh";
            this.barItemRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barItemRefresh_ItemClick);
            // 
            // barBtnCDisplay
            // 
            this.barBtnCDisplay.Caption = "单页显示(&S)";
            this.barBtnCDisplay.Id = 87;
            this.barBtnCDisplay.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.barBtnCDisplay.Name = "barBtnCDisplay";
            this.barBtnCDisplay.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCDisplay_ItemClick);
            // 
            // barBtnFloor
            // 
            this.barBtnFloor.Caption = "按楼层分类排序";
            this.barBtnFloor.Id = 88;
            this.barBtnFloor.Name = "barBtnFloor";
            this.barBtnFloor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnFloor_ItemClick);
            // 
            // barBtnRoomType
            // 
            this.barBtnRoomType.Caption = "按包厢分类排序";
            this.barBtnRoomType.Id = 89;
            this.barBtnRoomType.Name = "barBtnRoomType";
            this.barBtnRoomType.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnRoomType_ItemClick);
            // 
            // barBtnStatus
            // 
            this.barBtnStatus.Caption = "按餐台使用状态";
            this.barBtnStatus.Id = 90;
            this.barBtnStatus.Name = "barBtnStatus";
            this.barBtnStatus.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnStatus_ItemClick);
            // 
            // imgcolToolBar
            // 
            this.imgcolToolBar.ImageSize = new System.Drawing.Size(55, 55);
            this.imgcolToolBar.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgcolToolBar.ImageStream")));
            this.imgcolToolBar.Images.SetKeyName(0, "CheckIn.png");
            this.imgcolToolBar.Images.SetKeyName(1, "Trade.png");
            this.imgcolToolBar.Images.SetKeyName(2, "CheckOut.png");
            this.imgcolToolBar.Images.SetKeyName(3, "Reserve.png");
            this.imgcolToolBar.Images.SetKeyName(4, "Customer.png");
            this.imgcolToolBar.Images.SetKeyName(5, "VIP.png");
            this.imgcolToolBar.Images.SetKeyName(6, "Goods.png");
            this.imgcolToolBar.Images.SetKeyName(7, "Finance.png");
            this.imgcolToolBar.Images.SetKeyName(8, "Workers.png");
            this.imgcolToolBar.Images.SetKeyName(9, "WorkShift.png");
            this.imgcolToolBar.Images.SetKeyName(10, "Option.png");
            this.imgcolToolBar.Images.SetKeyName(11, "Sell.png");
            // 
            // imgOther
            // 
            this.imgOther.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgOther.ImageStream")));
            this.imgOther.TransparentColor = System.Drawing.Color.Transparent;
            this.imgOther.Images.SetKeyName(0, "49.ico");
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Id = -1;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Id = -1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Id = -1;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Id = -1;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barLinkContainerItem1
            // 
            this.barLinkContainerItem1.Id = -1;
            this.barLinkContainerItem1.Name = "barLinkContainerItem1";
            // 
            // tmrMain
            // 
            this.tmrMain.Enabled = true;
            this.tmrMain.Interval = 1000;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // imgcolMidbtn
            // 
            this.imgcolMidbtn.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgcolMidbtn.ImageStream")));
            this.imgcolMidbtn.Images.SetKeyName(0, "Untitled.ico");
            this.imgcolMidbtn.Images.SetKeyName(1, "viewmag.png.ico");
            this.imgcolMidbtn.Images.SetKeyName(2, "reload.ico");
            this.imgcolMidbtn.Images.SetKeyName(3, "Smile.gif");
            // 
            // imglstBuffetState
            // 
            this.imglstBuffetState.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstBuffetState.ImageStream")));
            this.imglstBuffetState.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstBuffetState.Images.SetKeyName(0, "bigfood.ico");
            this.imglstBuffetState.Images.SetKeyName(1, "NoUse.gif");
            this.imglstBuffetState.Images.SetKeyName(2, "Using.gif");
            this.imglstBuffetState.Images.SetKeyName(3, "Book.jpg");
            this.imglstBuffetState.Images.SetKeyName(4, "Dirty.jpg");
            this.imglstBuffetState.Images.SetKeyName(5, "无.png");
            // 
            // toolTipControllerMain
            // 
            this.toolTipControllerMain.AllowHtmlText = true;
            this.toolTipControllerMain.ImageList = this.imglstBuffetState;
            // 
            // popupMenuMain
            // 
            this.popupMenuMain.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnBuffetOpen),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnAddCon),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnBuffetBook),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnOver),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnSeach),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnBuffetStatus),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnExchange),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnTogether),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnBillO)});
            this.popupMenuMain.Manager = this.barManagerMain;
            this.popupMenuMain.Name = "popupMenuMain";
            // 
            // groupControlDetail
            // 
            this.groupControlDetail.Controls.Add(this.gridControlItem);
            this.groupControlDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlDetail.Location = new System.Drawing.Point(0, 0);
            this.groupControlDetail.Name = "groupControlDetail";
            this.groupControlDetail.Size = new System.Drawing.Size(990, 280);
            this.groupControlDetail.TabIndex = 0;
            this.groupControlDetail.Text = "详细消费项目";
            // 
            // gridControlItem
            // 
            this.gridControlItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlItem.Location = new System.Drawing.Point(2, 23);
            this.gridControlItem.MainView = this.gridViewMain;
            this.gridControlItem.MenuManager = this.barManagerMain;
            this.gridControlItem.Name = "gridControlItem";
            this.gridControlItem.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControlItem.Size = new System.Drawing.Size(986, 255);
            this.gridControlItem.TabIndex = 0;
            this.gridControlItem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
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
            this.DishName,
            this.DishType,
            this.Taste,
            this.IsPresent,
            this.Price,
            this.Num,
            this.Total,
            this.Date});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Silver;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.IsPresent;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition1.Expression = "[是否赠菜]";
            this.gridViewMain.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridViewMain.GridControl = this.gridControlItem;
            this.gridViewMain.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "菜品名称", null, "此类消费项数：{0}项"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "消费总价", null, "此类消费金额：{0} 元")});
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewMain.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewMain.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewMain.OptionsBehavior.Editable = false;
            this.gridViewMain.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridViewMain.OptionsPrint.EnableAppearanceOddRow = true;
            this.gridViewMain.OptionsPrint.ExpandAllDetails = true;
            this.gridViewMain.OptionsPrint.PrintDetails = true;
            this.gridViewMain.OptionsPrint.PrintFilterInfo = true;
            this.gridViewMain.OptionsPrint.PrintPreview = true;
            this.gridViewMain.OptionsPrint.UsePrintStyles = true;
            this.gridViewMain.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewMain.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewMain.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewMain.OptionsView.ShowFooter = true;
            this.gridViewMain.OptionsView.ShowGroupPanel = false;
            // 
            // DishName
            // 
            this.DishName.Caption = "菜品名称";
            this.DishName.FieldName = "菜品名称";
            this.DishName.Name = "DishName";
            this.DishName.SummaryItem.DisplayFormat = "共消费项数：{0}项";
            this.DishName.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            this.DishName.ToolTip = "菜品名称";
            this.DishName.Visible = true;
            this.DishName.VisibleIndex = 0;
            this.DishName.Width = 78;
            // 
            // DishType
            // 
            this.DishType.Caption = "菜品类别";
            this.DishType.FieldName = "菜品类别";
            this.DishType.Name = "DishType";
            this.DishType.SummaryItem.DisplayFormat = "共消费金额：{0} 元";
            this.DishType.SummaryItem.FieldName = "销售金额";
            this.DishType.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.DishType.ToolTip = "菜品类别";
            this.DishType.Visible = true;
            this.DishType.VisibleIndex = 1;
            this.DishType.Width = 100;
            // 
            // Taste
            // 
            this.Taste.Caption = "口味";
            this.Taste.FieldName = "口味";
            this.Taste.Name = "Taste";
            this.Taste.ToolTip = "口味";
            this.Taste.Visible = true;
            this.Taste.VisibleIndex = 2;
            this.Taste.Width = 74;
            // 
            // Price
            // 
            this.Price.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Price.AppearanceCell.Options.UseBackColor = true;
            this.Price.Caption = "单价";
            this.Price.DisplayFormat.FormatString = "c";
            this.Price.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Price.FieldName = "单价";
            this.Price.Name = "Price";
            this.Price.ToolTip = "单价";
            this.Price.Visible = true;
            this.Price.VisibleIndex = 4;
            this.Price.Width = 74;
            // 
            // Num
            // 
            this.Num.Caption = "数量";
            this.Num.FieldName = "数量";
            this.Num.Name = "Num";
            this.Num.ToolTip = "数量";
            this.Num.Visible = true;
            this.Num.VisibleIndex = 5;
            this.Num.Width = 54;
            // 
            // Total
            // 
            this.Total.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Total.AppearanceCell.Options.UseBackColor = true;
            this.Total.Caption = "此项消费总价";
            this.Total.DisplayFormat.FormatString = "c";
            this.Total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Total.FieldName = "销售金额";
            this.Total.Name = "Total";
            this.Total.ToolTip = "此项消费总价";
            this.Total.Visible = true;
            this.Total.VisibleIndex = 7;
            this.Total.Width = 78;
            // 
            // Date
            // 
            this.Date.Caption = "消费时间";
            this.Date.DisplayFormat.FormatString = "g";
            this.Date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Date.FieldName = "消费时间";
            this.Date.Name = "Date";
            this.Date.ToolTip = "消费时间";
            this.Date.Visible = true;
            this.Date.VisibleIndex = 6;
            this.Date.Width = 100;
            // 
            // groupControlMiddle
            // 
            this.groupControlMiddle.Controls.Add(this.btnShow);
            this.groupControlMiddle.Controls.Add(this.btnRefresh);
            this.groupControlMiddle.Controls.Add(this.btnCDisplay);
            this.groupControlMiddle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControlMiddle.Location = new System.Drawing.Point(0, 390);
            this.groupControlMiddle.Name = "groupControlMiddle";
            this.groupControlMiddle.ShowCaption = false;
            this.groupControlMiddle.Size = new System.Drawing.Size(990, 45);
            this.groupControlMiddle.TabIndex = 14;
            // 
            // btnShow
            // 
            this.btnShow.ImageIndex = 0;
            this.btnShow.ImageList = this.imgcolMidbtn;
            this.btnShow.Location = new System.Drawing.Point(282, 7);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(144, 30);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "单页显示(&S)";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageIndex = 2;
            this.btnRefresh.ImageList = this.imgcolMidbtn;
            this.btnRefresh.Location = new System.Drawing.Point(514, 7);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(144, 30);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "刷新所有(F5)";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCDisplay
            // 
            this.btnCDisplay.ImageIndex = 1;
            this.btnCDisplay.ImageList = this.imgcolMidbtn;
            this.btnCDisplay.Location = new System.Drawing.Point(50, 7);
            this.btnCDisplay.Name = "btnCDisplay";
            this.btnCDisplay.Size = new System.Drawing.Size(144, 30);
            this.btnCDisplay.TabIndex = 0;
            this.btnCDisplay.Text = "按楼层分类显示";
            this.btnCDisplay.Click += new System.EventHandler(this.btnCDisplay_Click);
            // 
            // xtraTabControlMain
            // 
            this.xtraTabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControlMain.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControlMain.MultiLine = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControlMain.Name = "xtraTabControlMain";
            this.xtraTabControlMain.Size = new System.Drawing.Size(990, 390);
            this.xtraTabControlMain.TabIndex = 12;
            // 
            // splitContainerControlMain
            // 
            this.splitContainerControlMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.splitContainerControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControlMain.Horizontal = false;
            this.splitContainerControlMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControlMain.Name = "splitContainerControlMain";
            this.splitContainerControlMain.Panel1.Controls.Add(this.xtraTabControlMain);
            this.splitContainerControlMain.Panel1.Controls.Add(this.groupControlMiddle);
            this.splitContainerControlMain.Panel1.Text = "Panel1";
            this.splitContainerControlMain.Panel2.Controls.Add(this.groupControlDetail);
            this.splitContainerControlMain.Panel2.Text = "Panel2";
            this.splitContainerControlMain.Size = new System.Drawing.Size(994, 725);
            this.splitContainerControlMain.SplitterPosition = 435;
            this.splitContainerControlMain.TabIndex = 16;
            this.splitContainerControlMain.Text = "splitContainerControl1";
            // 
            // popupMenuShowBuffet
            // 
            this.popupMenuShowBuffet.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnFloor),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRoomType),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnBuffetStatus)});
            this.popupMenuShowBuffet.Manager = this.barManagerMain;
            this.popupMenuShowBuffet.Name = "popupMenuShowBuffet";
            // 
            // popupMenuAll
            // 
            this.popupMenuAll.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barItemRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnCDisplay, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnFloor, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnRoomType),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnStatus)});
            this.popupMenuAll.Manager = this.barManagerMain;
            this.popupMenuAll.Name = "popupMenuAll";
            // 
            // frmBAMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 725);
            this.Controls.Add(this.splitContainerControlMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBAMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "餐饮点菜管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcolToolBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcolMidbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDetail)).EndInit();
            this.groupControlDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlMiddle)).EndInit();
            this.groupControlMiddle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlMain)).EndInit();
            this.splitContainerControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuShowBuffet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuAll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Timer tmrMain;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarLinkContainerItem barLinkContainerItem1;
        private System.Windows.Forms.ImageList imglstBuffetState;
        private System.Windows.Forms.ImageList imgOther;
        private DevExpress.Utils.ImageCollection imgcolToolBar;
        private DevExpress.Utils.ImageCollection imgcolMidbtn;
        private DevExpress.Utils.ToolTipController toolTipControllerMain;
        private DevExpress.XtraBars.BarButtonItem barBtnBuffetOpen;
        private DevExpress.XtraBars.PopupMenu popupMenuMain;
        private DevExpress.XtraBars.BarButtonItem barBtnOver;
        private DevExpress.XtraBars.BarButtonItem barBtnBuffetBook;
        private DevExpress.XtraBars.BarButtonItem barBtnBuffetStatus;
        private DevExpress.XtraBars.BarButtonItem barBtnSeach;
        private DevExpress.XtraBars.BarButtonItem barBtnAddCon;
        private DevExpress.XtraBars.BarButtonItem barBtnExchange;
        private DevExpress.XtraBars.BarButtonItem barBtnTogether;
        private DevExpress.XtraBars.BarButtonItem barBtnBillO;
        public DevExpress.XtraEditors.SplitContainerControl splitContainerControlMain;
        private DevExpress.XtraEditors.GroupControl groupControlMiddle;
        private DevExpress.XtraEditors.SimpleButton btnShow;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.GroupControl groupControlDetail;
        private DevExpress.XtraGrid.GridControl gridControlItem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraGrid.Columns.GridColumn DishName;
        private DevExpress.XtraGrid.Columns.GridColumn DishType;
        private DevExpress.XtraGrid.Columns.GridColumn Taste;
        private DevExpress.XtraGrid.Columns.GridColumn IsPresent;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn Price;
        private DevExpress.XtraGrid.Columns.GridColumn Num;
        private DevExpress.XtraGrid.Columns.GridColumn Total;
        private DevExpress.XtraGrid.Columns.GridColumn Date;
        public DevExpress.XtraBars.BarManager barManagerMain;
        private DevExpress.XtraBars.BarButtonItem btnFloor;
        private DevExpress.XtraBars.BarButtonItem btnRoomType;
        private DevExpress.XtraBars.BarButtonItem btnBuffetStatus;
        private DevExpress.XtraBars.PopupMenu popupMenuShowBuffet;
        private DevExpress.XtraBars.BarButtonItem barItemRefresh;
        private DevExpress.XtraBars.BarButtonItem barBtnCDisplay;
        private DevExpress.XtraBars.BarButtonItem barBtnFloor;
        private DevExpress.XtraBars.BarButtonItem barBtnRoomType;
        private DevExpress.XtraBars.BarButtonItem barBtnStatus;
        private DevExpress.XtraBars.PopupMenu popupMenuAll;
        public DevExpress.XtraEditors.SimpleButton btnCDisplay;
        public DevExpress.XtraTab.XtraTabControl xtraTabControlMain;
    }
}