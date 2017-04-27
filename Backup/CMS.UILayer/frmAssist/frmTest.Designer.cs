namespace CMS.UILayer.frmAssist
{
    partial class frmTest
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("oppp");
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTest));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.templistView = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Namej = new System.Windows.Forms.ColumnHeader();
            this.AccommodateNum = new System.Windows.Forms.ColumnHeader();
            this.Status = new System.Windows.Forms.ColumnHeader();
            this.gridControlItem = new DevExpress.XtraGrid.GridControl();
            this.gridViewChild = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BillID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustorNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Assistor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DishName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DishType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Taste = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IsPresent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InfoNote = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewChild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // templistView
            // 
            this.templistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Namej,
            this.AccommodateNum,
            this.Status});
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGrouptest";
            this.templistView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            listViewItem1.Group = listViewGroup1;
            this.templistView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.templistView.Location = new System.Drawing.Point(12, 42);
            this.templistView.Name = "templistView";
            this.templistView.Size = new System.Drawing.Size(316, 221);
            this.templistView.TabIndex = 0;
            this.templistView.UseCompatibleStateImageBehavior = false;
            this.templistView.View = System.Windows.Forms.View.Details;
            this.templistView.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.templistView_ItemMouseHover);
            this.templistView.SelectedIndexChanged += new System.EventHandler(this.templistView_SelectedIndexChanged);
            this.templistView.MouseHover += new System.EventHandler(this.templistView_MouseHover);
            // 
            // ID
            // 
            this.ID.Text = "餐台编号";
            // 
            // Namej
            // 
            this.Namej.Text = "餐台名称";
            this.Namej.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Namej.Width = 100;
            // 
            // AccommodateNum
            // 
            this.AccommodateNum.Text = "可做人数";
            // 
            // Status
            // 
            this.Status.Text = "使用状态";
            // 
            // gridControlItem
            // 
            this.gridControlItem.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridViewChild;
            gridLevelNode1.RelationName = "MarkID";
            this.gridControlItem.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControlItem.Location = new System.Drawing.Point(0, 0);
            this.gridControlItem.MainView = this.gridViewMain;
            this.gridControlItem.Name = "gridControlItem";
            this.gridControlItem.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControlItem.Size = new System.Drawing.Size(634, 558);
            this.gridControlItem.TabIndex = 2;
            this.gridControlItem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewChild,
            this.gridViewMain});
            // 
            // gridViewChild
            // 
            this.gridViewChild.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.BillID,
            this.CustorNum,
            this.Assistor});
            this.gridViewChild.GridControl = this.gridControlItem;
            this.gridViewChild.Name = "gridViewChild";
            // 
            // BillID
            // 
            this.BillID.Caption = "账单编号";
            this.BillID.FieldName = "账单编号";
            this.BillID.Name = "BillID";
            this.BillID.Visible = true;
            this.BillID.VisibleIndex = 0;
            // 
            // CustorNum
            // 
            this.CustorNum.Caption = "宾客人数";
            this.CustorNum.FieldName = "宾客人数";
            this.CustorNum.Name = "CustorNum";
            this.CustorNum.Visible = true;
            this.CustorNum.VisibleIndex = 1;
            // 
            // Assistor
            // 
            this.Assistor.Caption = "服务员";
            this.Assistor.FieldName = "服务员";
            this.Assistor.Name = "Assistor";
            this.Assistor.Visible = true;
            this.Assistor.VisibleIndex = 2;
            // 
            // gridViewMain
            // 
            this.gridViewMain.Appearance.GroupFooter.Image = ((System.Drawing.Image)(resources.GetObject("gridViewMain.Appearance.GroupFooter.Image")));
            this.gridViewMain.Appearance.GroupFooter.Options.UseImage = true;
            this.gridViewMain.ChildGridLevelName = "MarkID";
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DishName,
            this.DishType,
            this.Taste,
            this.IsPresent,
            this.Price,
            this.Num,
            this.Total,
            this.Date,
            this.InfoNote});
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
            this.gridViewMain.OptionsPrint.EnableAppearanceOddRow = true;
            this.gridViewMain.OptionsPrint.ExpandAllDetails = true;
            this.gridViewMain.OptionsPrint.PrintDetails = true;
            this.gridViewMain.OptionsPrint.PrintFilterInfo = true;
            this.gridViewMain.OptionsPrint.PrintPreview = true;
            this.gridViewMain.OptionsPrint.UsePrintStyles = true;
            this.gridViewMain.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewMain.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewMain.OptionsView.ShowFooter = true;
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
            this.DishName.Width = 120;
            // 
            // DishType
            // 
            this.DishType.Caption = "菜品类别";
            this.DishType.FieldName = "菜品类别";
            this.DishType.Name = "DishType";
            this.DishType.SummaryItem.DisplayFormat = "共消费金额：{0} 元";
            this.DishType.SummaryItem.FieldName = "消费总价";
            this.DishType.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.DishType.ToolTip = "菜品类别";
            this.DishType.Visible = true;
            this.DishType.VisibleIndex = 1;
            this.DishType.Width = 135;
            // 
            // Taste
            // 
            this.Taste.Caption = "口味";
            this.Taste.FieldName = "口味";
            this.Taste.Name = "Taste";
            this.Taste.ToolTip = "口味";
            this.Taste.Visible = true;
            this.Taste.VisibleIndex = 2;
            this.Taste.Width = 83;
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
            this.IsPresent.Width = 83;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
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
            this.Price.Width = 61;
            // 
            // Num
            // 
            this.Num.Caption = "数量";
            this.Num.FieldName = "数量";
            this.Num.Name = "Num";
            this.Num.ToolTip = "数量";
            this.Num.Visible = true;
            this.Num.VisibleIndex = 5;
            this.Num.Width = 44;
            // 
            // Total
            // 
            this.Total.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Total.AppearanceCell.Options.UseBackColor = true;
            this.Total.Caption = "此项消费总价";
            this.Total.DisplayFormat.FormatString = "c";
            this.Total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Total.FieldName = "消费总价";
            this.Total.Name = "Total";
            this.Total.ToolTip = "此项消费总价";
            this.Total.Visible = true;
            this.Total.VisibleIndex = 8;
            this.Total.Width = 99;
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
            this.Date.Width = 128;
            // 
            // InfoNote
            // 
            this.InfoNote.Caption = "备注";
            this.InfoNote.FieldName = "备注";
            this.InfoNote.Name = "InfoNote";
            this.InfoNote.ToolTip = "备注";
            this.InfoNote.Visible = true;
            this.InfoNote.VisibleIndex = 7;
            this.InfoNote.Width = 87;
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 558);
            this.Controls.Add(this.gridControlItem);
            this.Controls.Add(this.templistView);
            this.Name = "frmTest";
            this.Text = "frmTest";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewChild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView templistView;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Namej;
        private System.Windows.Forms.ColumnHeader AccommodateNum;
        private System.Windows.Forms.ColumnHeader Status;
        private DevExpress.XtraGrid.GridControl gridControlItem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewChild;
        private DevExpress.XtraGrid.Columns.GridColumn BillID;
        private DevExpress.XtraGrid.Columns.GridColumn CustorNum;
        private DevExpress.XtraGrid.Columns.GridColumn Assistor;
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
        private DevExpress.XtraGrid.Columns.GridColumn InfoNote;



    }
}