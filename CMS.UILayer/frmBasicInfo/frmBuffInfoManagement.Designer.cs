namespace CMS.UILayer.frmBasicInfo
{
    partial class frmBuffInfoManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuffInfoManagement));
            this.tbctrl = new DevExpress.XtraTab.XtraTabControl();
            this.TabPageRoomInfo = new DevExpress.XtraTab.XtraTabPage();
            this.grdctrlRoomInfo = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.RoomID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RoomName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RoomFloorAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AirConditionWhether = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FanWhether = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TVWhether = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DVDWhether = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OtherEquipment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RoomDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RoomInfoCreatePerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RoomInfoCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RoomInfoModifyPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RoomInfoModifyDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RoomInfoID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TabPageBuffInfo = new DevExpress.XtraTab.XtraTabPage();
            this.grdctrlBuffInfo = new DevExpress.XtraGrid.GridControl();
            this.gridViewBuffInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BuffID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BuffName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ContainPeople = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RoomAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FloorAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BuffStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InfoNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreatePerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ModifyPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ModifyDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnBuffInfoAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnBuffInfoeBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnBuffInfoPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnBuffInfoOut = new DevExpress.XtraEditors.SimpleButton();
            this.btnBuffInfoAlter = new DevExpress.XtraEditors.SimpleButton();
            this.btnBuffInfoDele = new DevExpress.XtraEditors.SimpleButton();
            this.imglstBuffetState = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbctrl)).BeginInit();
            this.tbctrl.SuspendLayout();
            this.TabPageRoomInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdctrlRoomInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.TabPageBuffInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdctrlBuffInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBuffInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbctrl
            // 
            this.tbctrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbctrl.Location = new System.Drawing.Point(0, 0);
            this.tbctrl.Name = "tbctrl";
            this.tbctrl.SelectedTabPage = this.TabPageRoomInfo;
            this.tbctrl.Size = new System.Drawing.Size(656, 471);
            this.tbctrl.TabIndex = 22;
            this.tbctrl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabPageRoomInfo,
            this.TabPageBuffInfo});
            this.tbctrl.SelectedPageChanging += new DevExpress.XtraTab.TabPageChangingEventHandler(this.tbctrl_SelectedPageChanging);
            // 
            // TabPageRoomInfo
            // 
            this.TabPageRoomInfo.Controls.Add(this.grdctrlRoomInfo);
            this.TabPageRoomInfo.Name = "TabPageRoomInfo";
            this.TabPageRoomInfo.Size = new System.Drawing.Size(649, 441);
            this.TabPageRoomInfo.Tag = "1";
            this.TabPageRoomInfo.Text = "包厢信息管理";
            // 
            // grdctrlRoomInfo
            // 
            this.grdctrlRoomInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdctrlRoomInfo.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grdctrlRoomInfo.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grdctrlRoomInfo.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grdctrlRoomInfo.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grdctrlRoomInfo.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grdctrlRoomInfo.Location = new System.Drawing.Point(0, 0);
            this.grdctrlRoomInfo.MainView = this.gridView1;
            this.grdctrlRoomInfo.Name = "grdctrlRoomInfo";
            this.grdctrlRoomInfo.Size = new System.Drawing.Size(649, 441);
            this.grdctrlRoomInfo.TabIndex = 1;
            this.grdctrlRoomInfo.UseEmbeddedNavigator = true;
            this.grdctrlRoomInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridView1.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView1.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridView1.Appearance.Empty.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.gridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridView1.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.gridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridView1.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridView1.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridView1.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gridView1.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Purple;
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Purple;
            this.gridView1.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(50)))), ((int)(((byte)(178)))));
            this.gridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.gridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView1.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.gridView1.Appearance.Preview.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.Preview.ForeColor = System.Drawing.Color.Purple;
            this.gridView1.Appearance.Preview.Options.UseBackColor = true;
            this.gridView1.Appearance.Preview.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseForeColor = true;
            this.gridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridView1.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(10)))), ((int)(((byte)(138)))));
            this.gridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.VertLine.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.RoomID,
            this.RoomName,
            this.RoomFloorAddress,
            this.AirConditionWhether,
            this.FanWhether,
            this.TVWhether,
            this.DVDWhether,
            this.OtherEquipment,
            this.RoomDescription,
            this.RoomInfoCreatePerson,
            this.RoomInfoCreateDate,
            this.RoomInfoModifyPerson,
            this.RoomInfoModifyDate,
            this.RoomInfoID});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(1152, 432, 208, 170);
            this.gridView1.GridControl = this.grdctrlRoomInfo;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsPrint.EnableAppearanceOddRow = true;
            this.gridView1.OptionsPrint.ExpandAllDetails = true;
            this.gridView1.OptionsPrint.PrintDetails = true;
            this.gridView1.OptionsPrint.PrintFilterInfo = true;
            this.gridView1.OptionsPrint.UsePrintStyles = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            // 
            // RoomID
            // 
            this.RoomID.AppearanceCell.Options.UseTextOptions = true;
            this.RoomID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RoomID.Caption = "包厢编号";
            this.RoomID.FieldName = "包厢编号";
            this.RoomID.Name = "RoomID";
            this.RoomID.ToolTip = "包厢编号";
            this.RoomID.Visible = true;
            this.RoomID.VisibleIndex = 0;
            this.RoomID.Width = 72;
            // 
            // RoomName
            // 
            this.RoomName.Caption = "包厢名称";
            this.RoomName.FieldName = "包厢名称";
            this.RoomName.Name = "RoomName";
            this.RoomName.ToolTip = "包厢名称";
            this.RoomName.Visible = true;
            this.RoomName.VisibleIndex = 1;
            this.RoomName.Width = 91;
            // 
            // RoomFloorAddress
            // 
            this.RoomFloorAddress.Caption = "所在楼层";
            this.RoomFloorAddress.FieldName = "包厢所在楼层";
            this.RoomFloorAddress.Name = "RoomFloorAddress";
            this.RoomFloorAddress.ToolTip = "包厢所在楼层";
            this.RoomFloorAddress.Visible = true;
            this.RoomFloorAddress.VisibleIndex = 2;
            this.RoomFloorAddress.Width = 94;
            // 
            // AirConditionWhether
            // 
            this.AirConditionWhether.AppearanceCell.Options.UseTextOptions = true;
            this.AirConditionWhether.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.AirConditionWhether.Caption = "空调";
            this.AirConditionWhether.FieldName = "有无空调";
            this.AirConditionWhether.Name = "AirConditionWhether";
            this.AirConditionWhether.ToolTip = "有无空调";
            this.AirConditionWhether.Visible = true;
            this.AirConditionWhether.VisibleIndex = 3;
            this.AirConditionWhether.Width = 50;
            // 
            // FanWhether
            // 
            this.FanWhether.AppearanceCell.Options.UseTextOptions = true;
            this.FanWhether.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FanWhether.Caption = "电扇";
            this.FanWhether.FieldName = "有无电扇";
            this.FanWhether.Name = "FanWhether";
            this.FanWhether.ToolTip = "有无电扇";
            this.FanWhether.Visible = true;
            this.FanWhether.VisibleIndex = 4;
            this.FanWhether.Width = 50;
            // 
            // TVWhether
            // 
            this.TVWhether.AppearanceCell.Options.UseTextOptions = true;
            this.TVWhether.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TVWhether.Caption = "电视机";
            this.TVWhether.FieldName = "有无电视机";
            this.TVWhether.Name = "TVWhether";
            this.TVWhether.ToolTip = "有无电视机";
            this.TVWhether.Visible = true;
            this.TVWhether.VisibleIndex = 5;
            this.TVWhether.Width = 50;
            // 
            // DVDWhether
            // 
            this.DVDWhether.AppearanceCell.Options.UseTextOptions = true;
            this.DVDWhether.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DVDWhether.Caption = "DVD";
            this.DVDWhether.FieldName = "有无DVD";
            this.DVDWhether.Name = "DVDWhether";
            this.DVDWhether.ToolTip = "有无DVD";
            this.DVDWhether.Visible = true;
            this.DVDWhether.VisibleIndex = 6;
            this.DVDWhether.Width = 50;
            // 
            // OtherEquipment
            // 
            this.OtherEquipment.Caption = "其他设备";
            this.OtherEquipment.FieldName = "其他设备";
            this.OtherEquipment.Name = "OtherEquipment";
            this.OtherEquipment.ToolTip = "其他设备";
            this.OtherEquipment.Visible = true;
            this.OtherEquipment.VisibleIndex = 7;
            this.OtherEquipment.Width = 120;
            // 
            // RoomDescription
            // 
            this.RoomDescription.Caption = "包厢描述";
            this.RoomDescription.FieldName = "包厢描述";
            this.RoomDescription.Name = "RoomDescription";
            this.RoomDescription.ToolTip = "包厢描述";
            this.RoomDescription.Visible = true;
            this.RoomDescription.VisibleIndex = 8;
            this.RoomDescription.Width = 240;
            // 
            // RoomInfoCreatePerson
            // 
            this.RoomInfoCreatePerson.Caption = "创建人";
            this.RoomInfoCreatePerson.FieldName = "创建人";
            this.RoomInfoCreatePerson.Name = "RoomInfoCreatePerson";
            this.RoomInfoCreatePerson.ToolTip = "创建人";
            this.RoomInfoCreatePerson.Visible = true;
            this.RoomInfoCreatePerson.VisibleIndex = 9;
            // 
            // RoomInfoCreateDate
            // 
            this.RoomInfoCreateDate.Caption = "创建时间";
            this.RoomInfoCreateDate.DisplayFormat.FormatString = "g";
            this.RoomInfoCreateDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.RoomInfoCreateDate.FieldName = "创建日期";
            this.RoomInfoCreateDate.GroupFormat.FormatString = "d";
            this.RoomInfoCreateDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.RoomInfoCreateDate.Name = "RoomInfoCreateDate";
            this.RoomInfoCreateDate.ToolTip = "创建时间";
            this.RoomInfoCreateDate.Visible = true;
            this.RoomInfoCreateDate.VisibleIndex = 10;
            this.RoomInfoCreateDate.Width = 120;
            // 
            // RoomInfoModifyPerson
            // 
            this.RoomInfoModifyPerson.Caption = "修改人";
            this.RoomInfoModifyPerson.DisplayFormat.FormatString = "g";
            this.RoomInfoModifyPerson.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.RoomInfoModifyPerson.FieldName = "修改人";
            this.RoomInfoModifyPerson.Name = "RoomInfoModifyPerson";
            this.RoomInfoModifyPerson.ToolTip = "修改人";
            this.RoomInfoModifyPerson.Visible = true;
            this.RoomInfoModifyPerson.VisibleIndex = 11;
            this.RoomInfoModifyPerson.Width = 49;
            // 
            // RoomInfoModifyDate
            // 
            this.RoomInfoModifyDate.Caption = "修改时间";
            this.RoomInfoModifyDate.DisplayFormat.FormatString = "g";
            this.RoomInfoModifyDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.RoomInfoModifyDate.FieldName = "修改日期";
            this.RoomInfoModifyDate.GroupFormat.FormatString = "d";
            this.RoomInfoModifyDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.RoomInfoModifyDate.Name = "RoomInfoModifyDate";
            this.RoomInfoModifyDate.ToolTip = "修改时间";
            this.RoomInfoModifyDate.Visible = true;
            this.RoomInfoModifyDate.VisibleIndex = 12;
            this.RoomInfoModifyDate.Width = 128;
            // 
            // RoomInfoID
            // 
            this.RoomInfoID.Caption = "设备编号";
            this.RoomInfoID.FieldName = "设备编号";
            this.RoomInfoID.Name = "RoomInfoID";
            this.RoomInfoID.Width = 63;
            // 
            // TabPageBuffInfo
            // 
            this.TabPageBuffInfo.Controls.Add(this.grdctrlBuffInfo);
            this.TabPageBuffInfo.Name = "TabPageBuffInfo";
            this.TabPageBuffInfo.Size = new System.Drawing.Size(649, 441);
            this.TabPageBuffInfo.Tag = "2";
            this.TabPageBuffInfo.Text = "餐台信息管理";
            // 
            // grdctrlBuffInfo
            // 
            this.grdctrlBuffInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdctrlBuffInfo.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grdctrlBuffInfo.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grdctrlBuffInfo.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grdctrlBuffInfo.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grdctrlBuffInfo.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grdctrlBuffInfo.Location = new System.Drawing.Point(0, 0);
            this.grdctrlBuffInfo.MainView = this.gridViewBuffInfo;
            this.grdctrlBuffInfo.Name = "grdctrlBuffInfo";
            this.grdctrlBuffInfo.Size = new System.Drawing.Size(649, 441);
            this.grdctrlBuffInfo.TabIndex = 0;
            this.grdctrlBuffInfo.UseEmbeddedNavigator = true;
            this.grdctrlBuffInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBuffInfo});
            // 
            // gridViewBuffInfo
            // 
            this.gridViewBuffInfo.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewBuffInfo.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewBuffInfo.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewBuffInfo.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gridViewBuffInfo.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridViewBuffInfo.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridViewBuffInfo.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridViewBuffInfo.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewBuffInfo.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gridViewBuffInfo.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewBuffInfo.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gridViewBuffInfo.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridViewBuffInfo.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridViewBuffInfo.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridViewBuffInfo.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewBuffInfo.Appearance.Empty.Options.UseBackColor = true;
            this.gridViewBuffInfo.Appearance.EvenRow.BackColor = System.Drawing.Color.Silver;
            this.gridViewBuffInfo.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.gridViewBuffInfo.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewBuffInfo.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewBuffInfo.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridViewBuffInfo.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridViewBuffInfo.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewBuffInfo.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.gridViewBuffInfo.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewBuffInfo.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewBuffInfo.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewBuffInfo.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridViewBuffInfo.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridViewBuffInfo.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridViewBuffInfo.Appearance.FilterPanel.BackColor = System.Drawing.Color.Black;
            this.gridViewBuffInfo.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewBuffInfo.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewBuffInfo.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewBuffInfo.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridViewBuffInfo.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridViewBuffInfo.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gridViewBuffInfo.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridViewBuffInfo.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gridViewBuffInfo.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Purple;
            this.gridViewBuffInfo.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridViewBuffInfo.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridViewBuffInfo.Appearance.FocusedRow.BackColor = System.Drawing.Color.Purple;
            this.gridViewBuffInfo.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(50)))), ((int)(((byte)(178)))));
            this.gridViewBuffInfo.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewBuffInfo.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewBuffInfo.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewBuffInfo.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.gridViewBuffInfo.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridViewBuffInfo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewBuffInfo.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridViewBuffInfo.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridViewBuffInfo.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewBuffInfo.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewBuffInfo.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewBuffInfo.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewBuffInfo.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridViewBuffInfo.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridViewBuffInfo.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridViewBuffInfo.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewBuffInfo.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewBuffInfo.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridViewBuffInfo.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridViewBuffInfo.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridViewBuffInfo.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridViewBuffInfo.Appearance.GroupPanel.BackColor = System.Drawing.Color.Black;
            this.gridViewBuffInfo.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridViewBuffInfo.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewBuffInfo.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewBuffInfo.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewBuffInfo.Appearance.GroupPanel.Options.UseFont = true;
            this.gridViewBuffInfo.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridViewBuffInfo.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewBuffInfo.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.gridViewBuffInfo.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridViewBuffInfo.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridViewBuffInfo.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gridViewBuffInfo.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridViewBuffInfo.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewBuffInfo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewBuffInfo.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewBuffInfo.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridViewBuffInfo.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewBuffInfo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewBuffInfo.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewBuffInfo.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewBuffInfo.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewBuffInfo.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewBuffInfo.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewBuffInfo.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridViewBuffInfo.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridViewBuffInfo.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gridViewBuffInfo.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewBuffInfo.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gridViewBuffInfo.Appearance.OddRow.Options.UseBackColor = true;
            this.gridViewBuffInfo.Appearance.OddRow.Options.UseForeColor = true;
            this.gridViewBuffInfo.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.gridViewBuffInfo.Appearance.Preview.BackColor2 = System.Drawing.Color.White;
            this.gridViewBuffInfo.Appearance.Preview.ForeColor = System.Drawing.Color.Purple;
            this.gridViewBuffInfo.Appearance.Preview.Options.UseBackColor = true;
            this.gridViewBuffInfo.Appearance.Preview.Options.UseForeColor = true;
            this.gridViewBuffInfo.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridViewBuffInfo.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridViewBuffInfo.Appearance.Row.Options.UseBackColor = true;
            this.gridViewBuffInfo.Appearance.Row.Options.UseForeColor = true;
            this.gridViewBuffInfo.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridViewBuffInfo.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewBuffInfo.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridViewBuffInfo.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(10)))), ((int)(((byte)(138)))));
            this.gridViewBuffInfo.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewBuffInfo.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewBuffInfo.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewBuffInfo.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewBuffInfo.Appearance.VertLine.Options.UseBackColor = true;
            this.gridViewBuffInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.BuffID,
            this.BuffName,
            this.ContainPeople,
            this.RoomAddress,
            this.FloorAddress,
            this.BuffStatus,
            this.InfoNote,
            this.CreatePerson,
            this.CreateDate,
            this.ModifyPerson,
            this.ModifyDate});
            this.gridViewBuffInfo.GridControl = this.grdctrlBuffInfo;
            this.gridViewBuffInfo.Name = "gridViewBuffInfo";
            this.gridViewBuffInfo.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewBuffInfo.OptionsBehavior.Editable = false;
            this.gridViewBuffInfo.OptionsPrint.EnableAppearanceOddRow = true;
            this.gridViewBuffInfo.OptionsPrint.ExpandAllDetails = true;
            this.gridViewBuffInfo.OptionsPrint.PrintDetails = true;
            this.gridViewBuffInfo.OptionsPrint.PrintFilterInfo = true;
            this.gridViewBuffInfo.OptionsPrint.PrintPreview = true;
            this.gridViewBuffInfo.OptionsPrint.UsePrintStyles = true;
            this.gridViewBuffInfo.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewBuffInfo.OptionsView.ColumnAutoWidth = false;
            this.gridViewBuffInfo.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewBuffInfo.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewBuffInfo.DoubleClick += new System.EventHandler(this.gridViewBuffInfo_DoubleClick);
            // 
            // BuffID
            // 
            this.BuffID.AppearanceCell.Options.UseTextOptions = true;
            this.BuffID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.BuffID.Caption = "餐台编号";
            this.BuffID.FieldName = "餐台编号";
            this.BuffID.Name = "BuffID";
            this.BuffID.ToolTip = "餐台编号";
            this.BuffID.Visible = true;
            this.BuffID.VisibleIndex = 0;
            this.BuffID.Width = 74;
            // 
            // BuffName
            // 
            this.BuffName.Caption = "餐台名称";
            this.BuffName.FieldName = "餐台名称";
            this.BuffName.Name = "BuffName";
            this.BuffName.ToolTip = "餐台名称";
            this.BuffName.Visible = true;
            this.BuffName.VisibleIndex = 1;
            this.BuffName.Width = 87;
            // 
            // ContainPeople
            // 
            this.ContainPeople.AppearanceCell.Options.UseTextOptions = true;
            this.ContainPeople.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ContainPeople.Caption = "可容纳人数";
            this.ContainPeople.DisplayFormat.FormatString = "{0}人";
            this.ContainPeople.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ContainPeople.FieldName = "可容纳人数";
            this.ContainPeople.Name = "ContainPeople";
            this.ContainPeople.ToolTip = "可容纳人数";
            this.ContainPeople.Visible = true;
            this.ContainPeople.VisibleIndex = 2;
            this.ContainPeople.Width = 80;
            // 
            // RoomAddress
            // 
            this.RoomAddress.Caption = "所在包厢";
            this.RoomAddress.FieldName = "所在包厢";
            this.RoomAddress.Name = "RoomAddress";
            this.RoomAddress.ToolTip = "所在包厢";
            this.RoomAddress.Visible = true;
            this.RoomAddress.VisibleIndex = 3;
            this.RoomAddress.Width = 92;
            // 
            // FloorAddress
            // 
            this.FloorAddress.Caption = "所在楼层";
            this.FloorAddress.FieldName = "所在楼层";
            this.FloorAddress.Name = "FloorAddress";
            this.FloorAddress.ToolTip = "所在楼层";
            this.FloorAddress.Visible = true;
            this.FloorAddress.VisibleIndex = 4;
            this.FloorAddress.Width = 81;
            // 
            // BuffStatus
            // 
            this.BuffStatus.Caption = "使用状态";
            this.BuffStatus.FieldName = "使用状态";
            this.BuffStatus.Name = "BuffStatus";
            this.BuffStatus.ToolTip = "使用状态";
            this.BuffStatus.Visible = true;
            this.BuffStatus.VisibleIndex = 5;
            this.BuffStatus.Width = 83;
            // 
            // InfoNote
            // 
            this.InfoNote.Caption = "信息备注";
            this.InfoNote.FieldName = "信息备注";
            this.InfoNote.Name = "InfoNote";
            this.InfoNote.ToolTip = "信息备注";
            this.InfoNote.Visible = true;
            this.InfoNote.VisibleIndex = 6;
            this.InfoNote.Width = 240;
            // 
            // CreatePerson
            // 
            this.CreatePerson.Caption = "创建人";
            this.CreatePerson.FieldName = "创建人";
            this.CreatePerson.Name = "CreatePerson";
            this.CreatePerson.ToolTip = "创建人";
            this.CreatePerson.Visible = true;
            this.CreatePerson.VisibleIndex = 7;
            // 
            // CreateDate
            // 
            this.CreateDate.Caption = "创建时间";
            this.CreateDate.DisplayFormat.FormatString = "g";
            this.CreateDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.CreateDate.FieldName = "创建日期";
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ToolTip = "创建时间";
            this.CreateDate.Visible = true;
            this.CreateDate.VisibleIndex = 8;
            this.CreateDate.Width = 116;
            // 
            // ModifyPerson
            // 
            this.ModifyPerson.Caption = "修改人";
            this.ModifyPerson.FieldName = "修改人";
            this.ModifyPerson.Name = "ModifyPerson";
            this.ModifyPerson.ToolTip = "修改人";
            this.ModifyPerson.Visible = true;
            this.ModifyPerson.VisibleIndex = 9;
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
            this.ModifyDate.VisibleIndex = 10;
            this.ModifyDate.Width = 165;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnBuffInfoAdd);
            this.groupControl2.Controls.Add(this.btnBuffInfoeBack);
            this.groupControl2.Controls.Add(this.btnBuffInfoPrint);
            this.groupControl2.Controls.Add(this.btnBuffInfoOut);
            this.groupControl2.Controls.Add(this.btnBuffInfoAlter);
            this.groupControl2.Controls.Add(this.btnBuffInfoDele);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl2.Location = new System.Drawing.Point(656, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(144, 471);
            this.groupControl2.TabIndex = 21;
            this.groupControl2.Text = "操作区";
            // 
            // btnBuffInfoAdd
            // 
            this.btnBuffInfoAdd.Location = new System.Drawing.Point(35, 45);
            this.btnBuffInfoAdd.Name = "btnBuffInfoAdd";
            this.btnBuffInfoAdd.Size = new System.Drawing.Size(75, 30);
            this.btnBuffInfoAdd.TabIndex = 18;
            this.btnBuffInfoAdd.Text = "添加(&A)";
            this.btnBuffInfoAdd.Click += new System.EventHandler(this.btnBuffInfoAdd_Click);
            // 
            // btnBuffInfoeBack
            // 
            this.btnBuffInfoeBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBuffInfoeBack.Location = new System.Drawing.Point(35, 405);
            this.btnBuffInfoeBack.Name = "btnBuffInfoeBack";
            this.btnBuffInfoeBack.Size = new System.Drawing.Size(75, 30);
            this.btnBuffInfoeBack.TabIndex = 19;
            this.btnBuffInfoeBack.Text = "返回(&B)";
            this.btnBuffInfoeBack.ToolTip = "返回系统主界面(Alt+B/Esc)";
            // 
            // btnBuffInfoPrint
            // 
            this.btnBuffInfoPrint.Location = new System.Drawing.Point(35, 333);
            this.btnBuffInfoPrint.Name = "btnBuffInfoPrint";
            this.btnBuffInfoPrint.Size = new System.Drawing.Size(75, 30);
            this.btnBuffInfoPrint.TabIndex = 19;
            this.btnBuffInfoPrint.Tag = "包厢信息管理";
            this.btnBuffInfoPrint.Text = "打印(&P)";
            this.btnBuffInfoPrint.ToolTip = "数据打印(Alt+P)";
            this.btnBuffInfoPrint.Click += new System.EventHandler(this.btnBuffInfoPrint_Click);
            // 
            // btnBuffInfoOut
            // 
            this.btnBuffInfoOut.Location = new System.Drawing.Point(35, 261);
            this.btnBuffInfoOut.Name = "btnBuffInfoOut";
            this.btnBuffInfoOut.Size = new System.Drawing.Size(75, 30);
            this.btnBuffInfoOut.TabIndex = 19;
            this.btnBuffInfoOut.Tag = "包厢信息管理";
            this.btnBuffInfoOut.Text = "导出(&O)";
            this.btnBuffInfoOut.ToolTip = "数据导出(Alt+O)";
            this.btnBuffInfoOut.Click += new System.EventHandler(this.btnBuffInfoOut_Click);
            // 
            // btnBuffInfoAlter
            // 
            this.btnBuffInfoAlter.Location = new System.Drawing.Point(35, 189);
            this.btnBuffInfoAlter.Name = "btnBuffInfoAlter";
            this.btnBuffInfoAlter.Size = new System.Drawing.Size(75, 30);
            this.btnBuffInfoAlter.TabIndex = 19;
            this.btnBuffInfoAlter.Text = "修改(&U)";
            this.btnBuffInfoAlter.Click += new System.EventHandler(this.btnBuffInfoAlter_Click);
            // 
            // btnBuffInfoDele
            // 
            this.btnBuffInfoDele.Location = new System.Drawing.Point(35, 117);
            this.btnBuffInfoDele.Name = "btnBuffInfoDele";
            this.btnBuffInfoDele.Size = new System.Drawing.Size(75, 30);
            this.btnBuffInfoDele.TabIndex = 19;
            this.btnBuffInfoDele.Text = "删除(&D)";
            this.btnBuffInfoDele.Click += new System.EventHandler(this.btnBuffInfoDele_Click);
            // 
            // imglstBuffetState
            // 
            this.imglstBuffetState.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstBuffetState.ImageStream")));
            this.imglstBuffetState.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstBuffetState.Images.SetKeyName(0, "bigfood.ico");
            this.imglstBuffetState.Images.SetKeyName(1, "NoUse.gif");
            this.imglstBuffetState.Images.SetKeyName(2, "Using.gif");
            this.imglstBuffetState.Images.SetKeyName(3, "Dirty.jpg");
            this.imglstBuffetState.Images.SetKeyName(4, "Book.jpg");
            this.imglstBuffetState.Images.SetKeyName(5, "无.png");
            // 
            // frmBuffInfoManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.tbctrl);
            this.Controls.Add(this.groupControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBuffInfoManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "餐台信息管理";
            this.Load += new System.EventHandler(this.frmBuffInfoManagement_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBuffInfoManagement_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tbctrl)).EndInit();
            this.tbctrl.ResumeLayout(false);
            this.TabPageRoomInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdctrlRoomInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.TabPageBuffInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdctrlBuffInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBuffInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdctrlBuffInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewBuffInfo;
        private DevExpress.XtraGrid.Columns.GridColumn BuffID;
        private DevExpress.XtraGrid.Columns.GridColumn BuffName;
        private DevExpress.XtraGrid.Columns.GridColumn ContainPeople;
        private DevExpress.XtraGrid.Columns.GridColumn RoomAddress;
        private DevExpress.XtraGrid.Columns.GridColumn FloorAddress;
        private DevExpress.XtraGrid.Columns.GridColumn BuffStatus;
        private DevExpress.XtraGrid.Columns.GridColumn InfoNote;
        private DevExpress.XtraGrid.Columns.GridColumn CreatePerson;
        private DevExpress.XtraGrid.Columns.GridColumn CreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn ModifyPerson;
        private DevExpress.XtraGrid.Columns.GridColumn ModifyDate;
        private System.Windows.Forms.ImageList imglstBuffetState;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnBuffInfoAdd;
        private DevExpress.XtraEditors.SimpleButton btnBuffInfoeBack;
        private DevExpress.XtraEditors.SimpleButton btnBuffInfoPrint;
        private DevExpress.XtraEditors.SimpleButton btnBuffInfoOut;
        private DevExpress.XtraEditors.SimpleButton btnBuffInfoAlter;
        private DevExpress.XtraEditors.SimpleButton btnBuffInfoDele;
        private DevExpress.XtraTab.XtraTabControl tbctrl;
        private DevExpress.XtraTab.XtraTabPage TabPageRoomInfo;
        private DevExpress.XtraTab.XtraTabPage TabPageBuffInfo;
        private DevExpress.XtraGrid.GridControl grdctrlRoomInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn RoomID;
        private DevExpress.XtraGrid.Columns.GridColumn RoomName;
        private DevExpress.XtraGrid.Columns.GridColumn RoomFloorAddress;
        private DevExpress.XtraGrid.Columns.GridColumn RoomDescription;
        private DevExpress.XtraGrid.Columns.GridColumn AirConditionWhether;
        private DevExpress.XtraGrid.Columns.GridColumn FanWhether;
        private DevExpress.XtraGrid.Columns.GridColumn TVWhether;
        private DevExpress.XtraGrid.Columns.GridColumn DVDWhether;
        private DevExpress.XtraGrid.Columns.GridColumn RoomInfoCreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn RoomInfoModifyPerson;
        private DevExpress.XtraGrid.Columns.GridColumn RoomInfoModifyDate;
        private DevExpress.XtraGrid.Columns.GridColumn RoomInfoCreatePerson;
        private DevExpress.XtraGrid.Columns.GridColumn OtherEquipment;
        private DevExpress.XtraGrid.Columns.GridColumn RoomInfoID;
    }
}