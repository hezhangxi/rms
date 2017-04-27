namespace CMS.UILayer.frmFinance
{
    partial class frmInOutItemManagement
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
            this.btneInOutItemAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnInOutItemBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnInOutItemPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnInOutItemOut = new DevExpress.XtraEditors.SimpleButton();
            this.btnInOutItemAlter = new DevExpress.XtraEditors.SimpleButton();
            this.btnInOutItemDele = new DevExpress.XtraEditors.SimpleButton();
            this.grdctrlInOutItemInfo = new DevExpress.XtraGrid.GridControl();
            this.gridViewInOutItemInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ItemID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InfoNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreatePerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ModifyPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ModifyDate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdctrlInOutItemInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInOutItemInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btneInOutItemAdd);
            this.groupControl2.Controls.Add(this.btnInOutItemBack);
            this.groupControl2.Controls.Add(this.btnInOutItemPrint);
            this.groupControl2.Controls.Add(this.btnInOutItemOut);
            this.groupControl2.Controls.Add(this.btnInOutItemAlter);
            this.groupControl2.Controls.Add(this.btnInOutItemDele);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 297);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(756, 99);
            this.groupControl2.TabIndex = 24;
            this.groupControl2.Text = "操作区";
            // 
            // btneInOutItemAdd
            // 
            this.btneInOutItemAdd.Location = new System.Drawing.Point(35, 42);
            this.btneInOutItemAdd.Name = "btneInOutItemAdd";
            this.btneInOutItemAdd.Size = new System.Drawing.Size(75, 30);
            this.btneInOutItemAdd.TabIndex = 18;
            this.btneInOutItemAdd.Text = "添加(&A)";
            this.btneInOutItemAdd.Click += new System.EventHandler(this.btneInOutItemAdd_Click);
            // 
            // btnInOutItemBack
            // 
            this.btnInOutItemBack.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnInOutItemBack.Location = new System.Drawing.Point(620, 42);
            this.btnInOutItemBack.Name = "btnInOutItemBack";
            this.btnInOutItemBack.Size = new System.Drawing.Size(75, 30);
            this.btnInOutItemBack.TabIndex = 19;
            this.btnInOutItemBack.Text = "返回(&B)";
            this.btnInOutItemBack.ToolTip = "返回系统主界面(Alt+B/Esc)";
            // 
            // btnInOutItemPrint
            // 
            this.btnInOutItemPrint.Location = new System.Drawing.Point(503, 42);
            this.btnInOutItemPrint.Name = "btnInOutItemPrint";
            this.btnInOutItemPrint.Size = new System.Drawing.Size(75, 30);
            this.btnInOutItemPrint.TabIndex = 19;
            this.btnInOutItemPrint.Text = "打印(&P)";
            this.btnInOutItemPrint.ToolTip = "数据打印(Alt+P)";
            this.btnInOutItemPrint.Click += new System.EventHandler(this.btnInOutItemPrint_Click);
            // 
            // btnInOutItemOut
            // 
            this.btnInOutItemOut.Location = new System.Drawing.Point(386, 42);
            this.btnInOutItemOut.Name = "btnInOutItemOut";
            this.btnInOutItemOut.Size = new System.Drawing.Size(75, 30);
            this.btnInOutItemOut.TabIndex = 19;
            this.btnInOutItemOut.Text = "导出(&O)";
            this.btnInOutItemOut.ToolTip = "数据导出(Alt+O)";
            this.btnInOutItemOut.Click += new System.EventHandler(this.btnInOutItemOut_Click);
            // 
            // btnInOutItemAlter
            // 
            this.btnInOutItemAlter.Location = new System.Drawing.Point(269, 42);
            this.btnInOutItemAlter.Name = "btnInOutItemAlter";
            this.btnInOutItemAlter.Size = new System.Drawing.Size(75, 30);
            this.btnInOutItemAlter.TabIndex = 19;
            this.btnInOutItemAlter.Text = "修改(&U)";
            this.btnInOutItemAlter.Click += new System.EventHandler(this.btnInOutItemAlter_Click);
            // 
            // btnInOutItemDele
            // 
            this.btnInOutItemDele.Location = new System.Drawing.Point(152, 42);
            this.btnInOutItemDele.Name = "btnInOutItemDele";
            this.btnInOutItemDele.Size = new System.Drawing.Size(75, 30);
            this.btnInOutItemDele.TabIndex = 19;
            this.btnInOutItemDele.Text = "删除(&D)";
            this.btnInOutItemDele.Click += new System.EventHandler(this.btnInOutItemDele_Click);
            // 
            // grdctrlInOutItemInfo
            // 
            this.grdctrlInOutItemInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdctrlInOutItemInfo.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grdctrlInOutItemInfo.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grdctrlInOutItemInfo.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grdctrlInOutItemInfo.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grdctrlInOutItemInfo.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grdctrlInOutItemInfo.Location = new System.Drawing.Point(0, 0);
            this.grdctrlInOutItemInfo.MainView = this.gridViewInOutItemInfo;
            this.grdctrlInOutItemInfo.Name = "grdctrlInOutItemInfo";
            this.grdctrlInOutItemInfo.Size = new System.Drawing.Size(756, 299);
            this.grdctrlInOutItemInfo.TabIndex = 23;
            this.grdctrlInOutItemInfo.UseEmbeddedNavigator = true;
            this.grdctrlInOutItemInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewInOutItemInfo});
            // 
            // gridViewInOutItemInfo
            // 
            this.gridViewInOutItemInfo.ActiveFilterEnabled = false;
            this.gridViewInOutItemInfo.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewInOutItemInfo.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewInOutItemInfo.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewInOutItemInfo.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gridViewInOutItemInfo.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridViewInOutItemInfo.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridViewInOutItemInfo.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridViewInOutItemInfo.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewInOutItemInfo.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gridViewInOutItemInfo.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewInOutItemInfo.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gridViewInOutItemInfo.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridViewInOutItemInfo.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridViewInOutItemInfo.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridViewInOutItemInfo.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewInOutItemInfo.Appearance.Empty.Options.UseBackColor = true;
            this.gridViewInOutItemInfo.Appearance.EvenRow.BackColor = System.Drawing.Color.Silver;
            this.gridViewInOutItemInfo.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.gridViewInOutItemInfo.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewInOutItemInfo.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewInOutItemInfo.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridViewInOutItemInfo.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridViewInOutItemInfo.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewInOutItemInfo.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.gridViewInOutItemInfo.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewInOutItemInfo.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewInOutItemInfo.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewInOutItemInfo.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridViewInOutItemInfo.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridViewInOutItemInfo.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridViewInOutItemInfo.Appearance.FilterPanel.BackColor = System.Drawing.Color.Black;
            this.gridViewInOutItemInfo.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewInOutItemInfo.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewInOutItemInfo.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewInOutItemInfo.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridViewInOutItemInfo.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridViewInOutItemInfo.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gridViewInOutItemInfo.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridViewInOutItemInfo.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gridViewInOutItemInfo.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Purple;
            this.gridViewInOutItemInfo.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridViewInOutItemInfo.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridViewInOutItemInfo.Appearance.FocusedRow.BackColor = System.Drawing.Color.Purple;
            this.gridViewInOutItemInfo.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(50)))), ((int)(((byte)(178)))));
            this.gridViewInOutItemInfo.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewInOutItemInfo.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewInOutItemInfo.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewInOutItemInfo.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.gridViewInOutItemInfo.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridViewInOutItemInfo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewInOutItemInfo.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridViewInOutItemInfo.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridViewInOutItemInfo.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewInOutItemInfo.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewInOutItemInfo.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewInOutItemInfo.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewInOutItemInfo.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridViewInOutItemInfo.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridViewInOutItemInfo.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridViewInOutItemInfo.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewInOutItemInfo.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewInOutItemInfo.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridViewInOutItemInfo.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridViewInOutItemInfo.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridViewInOutItemInfo.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridViewInOutItemInfo.Appearance.GroupPanel.BackColor = System.Drawing.Color.Black;
            this.gridViewInOutItemInfo.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridViewInOutItemInfo.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewInOutItemInfo.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewInOutItemInfo.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewInOutItemInfo.Appearance.GroupPanel.Options.UseFont = true;
            this.gridViewInOutItemInfo.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridViewInOutItemInfo.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewInOutItemInfo.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.gridViewInOutItemInfo.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridViewInOutItemInfo.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridViewInOutItemInfo.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gridViewInOutItemInfo.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridViewInOutItemInfo.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewInOutItemInfo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewInOutItemInfo.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewInOutItemInfo.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridViewInOutItemInfo.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewInOutItemInfo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewInOutItemInfo.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewInOutItemInfo.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewInOutItemInfo.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewInOutItemInfo.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewInOutItemInfo.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewInOutItemInfo.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridViewInOutItemInfo.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridViewInOutItemInfo.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gridViewInOutItemInfo.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewInOutItemInfo.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gridViewInOutItemInfo.Appearance.OddRow.Options.UseBackColor = true;
            this.gridViewInOutItemInfo.Appearance.OddRow.Options.UseForeColor = true;
            this.gridViewInOutItemInfo.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.gridViewInOutItemInfo.Appearance.Preview.BackColor2 = System.Drawing.Color.White;
            this.gridViewInOutItemInfo.Appearance.Preview.ForeColor = System.Drawing.Color.Purple;
            this.gridViewInOutItemInfo.Appearance.Preview.Options.UseBackColor = true;
            this.gridViewInOutItemInfo.Appearance.Preview.Options.UseForeColor = true;
            this.gridViewInOutItemInfo.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridViewInOutItemInfo.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridViewInOutItemInfo.Appearance.Row.Options.UseBackColor = true;
            this.gridViewInOutItemInfo.Appearance.Row.Options.UseForeColor = true;
            this.gridViewInOutItemInfo.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridViewInOutItemInfo.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewInOutItemInfo.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridViewInOutItemInfo.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(10)))), ((int)(((byte)(138)))));
            this.gridViewInOutItemInfo.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewInOutItemInfo.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewInOutItemInfo.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewInOutItemInfo.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewInOutItemInfo.Appearance.VertLine.Options.UseBackColor = true;
            this.gridViewInOutItemInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ItemID,
            this.ItemType,
            this.ItemName,
            this.InfoNote,
            this.CreatePerson,
            this.CreateDate,
            this.ModifyPerson,
            this.ModifyDate});
            this.gridViewInOutItemInfo.GridControl = this.grdctrlInOutItemInfo;
            this.gridViewInOutItemInfo.Name = "gridViewInOutItemInfo";
            this.gridViewInOutItemInfo.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewInOutItemInfo.OptionsBehavior.Editable = false;
            this.gridViewInOutItemInfo.OptionsPrint.EnableAppearanceOddRow = true;
            this.gridViewInOutItemInfo.OptionsPrint.ExpandAllDetails = true;
            this.gridViewInOutItemInfo.OptionsPrint.PrintDetails = true;
            this.gridViewInOutItemInfo.OptionsPrint.PrintFilterInfo = true;
            this.gridViewInOutItemInfo.OptionsPrint.PrintPreview = true;
            this.gridViewInOutItemInfo.OptionsPrint.UsePrintStyles = true;
            this.gridViewInOutItemInfo.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewInOutItemInfo.OptionsView.ColumnAutoWidth = false;
            this.gridViewInOutItemInfo.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewInOutItemInfo.OptionsView.EnableAppearanceOddRow = true;
            // 
            // ItemID
            // 
            this.ItemID.AppearanceCell.Options.UseTextOptions = true;
            this.ItemID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ItemID.Caption = "项目编号";
            this.ItemID.FieldName = "ID";
            this.ItemID.Name = "ItemID";
            this.ItemID.ToolTip = "收支项目编号";
            this.ItemID.Visible = true;
            this.ItemID.VisibleIndex = 0;
            this.ItemID.Width = 68;
            // 
            // ItemType
            // 
            this.ItemType.AppearanceCell.Options.UseTextOptions = true;
            this.ItemType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ItemType.Caption = "项目类型";
            this.ItemType.FieldName = "Type";
            this.ItemType.Name = "ItemType";
            this.ItemType.ToolTip = "收支项目类型";
            this.ItemType.Visible = true;
            this.ItemType.VisibleIndex = 1;
            this.ItemType.Width = 76;
            // 
            // ItemName
            // 
            this.ItemName.Caption = "项目名称";
            this.ItemName.FieldName = "Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.ToolTip = "收支项目名称";
            this.ItemName.Visible = true;
            this.ItemName.VisibleIndex = 2;
            // 
            // InfoNote
            // 
            this.InfoNote.Caption = "信息备注";
            this.InfoNote.FieldName = "Description";
            this.InfoNote.Name = "InfoNote";
            this.InfoNote.ToolTip = "收支信息备注";
            this.InfoNote.Visible = true;
            this.InfoNote.VisibleIndex = 3;
            this.InfoNote.Width = 139;
            // 
            // CreatePerson
            // 
            this.CreatePerson.Caption = "创建人";
            this.CreatePerson.FieldName = "CreatePerson";
            this.CreatePerson.Name = "CreatePerson";
            this.CreatePerson.ToolTip = "创建人";
            this.CreatePerson.Visible = true;
            this.CreatePerson.VisibleIndex = 4;
            this.CreatePerson.Width = 64;
            // 
            // CreateDate
            // 
            this.CreateDate.Caption = "创建时间";
            this.CreateDate.DisplayFormat.FormatString = "g";
            this.CreateDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.CreateDate.FieldName = "CreateDate";
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ToolTip = "创建时间";
            this.CreateDate.Visible = true;
            this.CreateDate.VisibleIndex = 5;
            this.CreateDate.Width = 116;
            // 
            // ModifyPerson
            // 
            this.ModifyPerson.Caption = "修改人";
            this.ModifyPerson.FieldName = "ModifyPerson";
            this.ModifyPerson.Name = "ModifyPerson";
            this.ModifyPerson.ToolTip = "修改(&U)人";
            this.ModifyPerson.Visible = true;
            this.ModifyPerson.VisibleIndex = 6;
            // 
            // ModifyDate
            // 
            this.ModifyDate.Caption = "修改时间";
            this.ModifyDate.DisplayFormat.FormatString = "g";
            this.ModifyDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ModifyDate.FieldName = "ModifyDate";
            this.ModifyDate.Name = "ModifyDate";
            this.ModifyDate.ToolTip = "修改时间";
            this.ModifyDate.Visible = true;
            this.ModifyDate.VisibleIndex = 7;
            this.ModifyDate.Width = 152;
            // 
            // frmInOutItemManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 396);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.grdctrlInOutItemInfo);
            this.Name = "frmInOutItemManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "1";
            this.Text = "收支项目管理";
            this.Load += new System.EventHandler(this.frmInOutItemManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdctrlInOutItemInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInOutItemInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btneInOutItemAdd;
        private DevExpress.XtraEditors.SimpleButton btnInOutItemBack;
        private DevExpress.XtraEditors.SimpleButton btnInOutItemPrint;
        private DevExpress.XtraEditors.SimpleButton btnInOutItemOut;
        private DevExpress.XtraEditors.SimpleButton btnInOutItemAlter;
        private DevExpress.XtraEditors.SimpleButton btnInOutItemDele;
        private DevExpress.XtraGrid.GridControl grdctrlInOutItemInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewInOutItemInfo;
        private DevExpress.XtraGrid.Columns.GridColumn ItemID;
        private DevExpress.XtraGrid.Columns.GridColumn ItemName;
        private DevExpress.XtraGrid.Columns.GridColumn ItemType;
        private DevExpress.XtraGrid.Columns.GridColumn InfoNote;
        private DevExpress.XtraGrid.Columns.GridColumn CreatePerson;
        private DevExpress.XtraGrid.Columns.GridColumn CreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn ModifyPerson;
        private DevExpress.XtraGrid.Columns.GridColumn ModifyDate;
    }
}