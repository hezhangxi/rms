namespace CMS.UILayer.frmVIPClient
{
    partial class frmSetVIP
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
            this.btnCancle = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VIPName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Discount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreatePerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ModifyPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ModifyDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControlOperator = new DevExpress.XtraEditors.GroupControl();
            this.btnDel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddNewVIP = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.groupControlData = new DevExpress.XtraEditors.GroupControl();
            this.btnOut = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlOperator)).BeginInit();
            this.groupControlOperator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlData)).BeginInit();
            this.groupControlData.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancle
            // 
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.Location = new System.Drawing.Point(559, 43);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 30);
            this.btnCancle.TabIndex = 2;
            this.btnCancle.Text = "返回(&B)";
            this.btnCancle.ToolTip = "返回系统主界面(Alt+B/Esc)";
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(135, 43);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 30);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "修改(&U)";
            this.btnUpdate.ToolTip = "修改会员卡信息(Alt+U)";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gridControlMain
            // 
            this.gridControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMain.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlMain.Location = new System.Drawing.Point(2, 23);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.Size = new System.Drawing.Size(665, 211);
            this.gridControlMain.TabIndex = 2;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.ID,
            this.VIPName,
            this.Discount,
            this.Description,
            this.CreatePerson,
            this.CreateDate,
            this.ModifyPerson,
            this.ModifyDate});
            this.gridViewMain.GridControl = this.gridControlMain;
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
            this.gridViewMain.OptionsView.ColumnAutoWidth = false;
            this.gridViewMain.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewMain.OptionsView.EnableAppearanceOddRow = true;
            // 
            // ID
            // 
            this.ID.Caption = "编号";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.ToolTip = "编号";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 46;
            // 
            // VIPName
            // 
            this.VIPName.Caption = "会员卡名称";
            this.VIPName.FieldName = "Name";
            this.VIPName.Name = "VIPName";
            this.VIPName.ToolTip = "会员卡名称";
            this.VIPName.Visible = true;
            this.VIPName.VisibleIndex = 1;
            this.VIPName.Width = 95;
            // 
            // Discount
            // 
            this.Discount.Caption = "折扣";
            this.Discount.DisplayFormat.FormatString = "{0}折";
            this.Discount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Discount.FieldName = "Discount";
            this.Discount.Name = "Discount";
            this.Discount.ToolTip = "折扣";
            this.Discount.Visible = true;
            this.Discount.VisibleIndex = 2;
            this.Discount.Width = 72;
            // 
            // Description
            // 
            this.Description.Caption = "描述";
            this.Description.FieldName = "Description";
            this.Description.Name = "Description";
            this.Description.ToolTip = "描述";
            this.Description.Visible = true;
            this.Description.VisibleIndex = 3;
            this.Description.Width = 188;
            // 
            // CreatePerson
            // 
            this.CreatePerson.Caption = "创建人";
            this.CreatePerson.FieldName = "CreatePerson";
            this.CreatePerson.Name = "CreatePerson";
            this.CreatePerson.Visible = true;
            this.CreatePerson.VisibleIndex = 4;
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
            this.CreateDate.Width = 151;
            // 
            // ModifyPerson
            // 
            this.ModifyPerson.Caption = "修改人";
            this.ModifyPerson.FieldName = "ModifyPerson";
            this.ModifyPerson.Name = "ModifyPerson";
            this.ModifyPerson.ToolTip = "修改人";
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
            this.ModifyDate.Width = 121;
            // 
            // groupControlOperator
            // 
            this.groupControlOperator.Controls.Add(this.btnOut);
            this.groupControlOperator.Controls.Add(this.btnDel);
            this.groupControlOperator.Controls.Add(this.btnAddNewVIP);
            this.groupControlOperator.Controls.Add(this.btnCancle);
            this.groupControlOperator.Controls.Add(this.btnPrint);
            this.groupControlOperator.Controls.Add(this.btnUpdate);
            this.groupControlOperator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControlOperator.Location = new System.Drawing.Point(0, 240);
            this.groupControlOperator.Name = "groupControlOperator";
            this.groupControlOperator.Size = new System.Drawing.Size(669, 100);
            this.groupControlOperator.TabIndex = 3;
            this.groupControlOperator.Text = "信息操作";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(241, 43);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 30);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "删除(&D)";
            this.btnDel.ToolTip = "会员卡";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAddNewVIP
            // 
            this.btnAddNewVIP.Location = new System.Drawing.Point(29, 43);
            this.btnAddNewVIP.Name = "btnAddNewVIP";
            this.btnAddNewVIP.Size = new System.Drawing.Size(75, 30);
            this.btnAddNewVIP.TabIndex = 0;
            this.btnAddNewVIP.Text = "添加(&A)";
            this.btnAddNewVIP.ToolTip = "添加会员卡信息(Alt+A)";
            this.btnAddNewVIP.Click += new System.EventHandler(this.btnAddNewVIP_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(453, 43);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 30);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "打印(&P)";
            this.btnPrint.ToolTip = "打印会员信息(Alt+P)";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupControlData
            // 
            this.groupControlData.Controls.Add(this.gridControlMain);
            this.groupControlData.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControlData.Location = new System.Drawing.Point(0, 0);
            this.groupControlData.Name = "groupControlData";
            this.groupControlData.Size = new System.Drawing.Size(669, 236);
            this.groupControlData.TabIndex = 4;
            this.groupControlData.Text = "现有会员卡";
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(347, 43);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(75, 29);
            this.btnOut.TabIndex = 4;
            this.btnOut.Text = "导出(&O)";
            this.btnOut.ToolTip = "信息导出(Alt+O)";
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // frmSetVIP
            // 
            this.AcceptButton = this.btnAddNewVIP;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancle;
            this.ClientSize = new System.Drawing.Size(669, 340);
            this.Controls.Add(this.groupControlData);
            this.Controls.Add(this.groupControlOperator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSetVIP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "会员卡信息设置";
            this.Load += new System.EventHandler(this.frmSetVIP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlOperator)).EndInit();
            this.groupControlOperator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlData)).EndInit();
            this.groupControlData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCancle;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraGrid.Columns.GridColumn VIPName;
        private DevExpress.XtraGrid.Columns.GridColumn Discount;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
        private DevExpress.XtraGrid.Columns.GridColumn ModifyPerson;
        private DevExpress.XtraGrid.Columns.GridColumn ModifyDate;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraEditors.GroupControl groupControlOperator;
        private DevExpress.XtraEditors.SimpleButton btnAddNewVIP;
        private DevExpress.XtraEditors.GroupControl groupControlData;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraGrid.Columns.GridColumn CreatePerson;
        private DevExpress.XtraGrid.Columns.GridColumn CreateDate;
        private DevExpress.XtraEditors.SimpleButton btnDel;
        private DevExpress.XtraEditors.SimpleButton btnOut;
    }
}