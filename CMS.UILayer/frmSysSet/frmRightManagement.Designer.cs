namespace CMS.UILayer.frmSysSet
{
    partial class frmRightManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRightManagement));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.tvwModule = new System.Windows.Forms.TreeView();
            this.imgTree = new System.Windows.Forms.ImageList(this.components);
            this.splitContainerControlRight = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControlInfo = new DevExpress.XtraEditors.GroupControl();
            this.gridControlRight = new DevExpress.XtraGrid.GridControl();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RightName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreatePerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ModifyPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ModifyDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.groupControlBottom = new DevExpress.XtraEditors.GroupControl();
            this.lblModuleNum = new DevExpress.XtraEditors.LabelControl();
            this.btnBackR = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnDel = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.meDesc = new DevExpress.XtraEditors.MemoEdit();
            this.lblDesc = new DevExpress.XtraEditors.LabelControl();
            this.txtHref = new DevExpress.XtraEditors.TextEdit();
            this.lblHref = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlRight)).BeginInit();
            this.splitContainerControlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInfo)).BeginInit();
            this.groupControlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlBottom)).BeginInit();
            this.groupControlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHref.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.tvwModule);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControlRight);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(838, 561);
            this.splitContainerControl1.SplitterPosition = 592;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // tvwModule
            // 
            this.tvwModule.CheckBoxes = true;
            this.tvwModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwModule.ImageIndex = 0;
            this.tvwModule.ImageList = this.imgTree;
            this.tvwModule.Location = new System.Drawing.Point(0, 0);
            this.tvwModule.Name = "tvwModule";
            this.tvwModule.SelectedImageIndex = 0;
            this.tvwModule.Size = new System.Drawing.Size(240, 561);
            this.tvwModule.TabIndex = 0;
            this.tvwModule.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvwModule_AfterCheck);
            this.tvwModule.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwModule_AfterSelect);
            // 
            // imgTree
            // 
            this.imgTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgTree.ImageStream")));
            this.imgTree.TransparentColor = System.Drawing.Color.Transparent;
            this.imgTree.Images.SetKeyName(0, "");
            this.imgTree.Images.SetKeyName(1, "");
            this.imgTree.Images.SetKeyName(2, "");
            this.imgTree.Images.SetKeyName(3, "");
            this.imgTree.Images.SetKeyName(4, "");
            // 
            // splitContainerControlRight
            // 
            this.splitContainerControlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControlRight.Horizontal = false;
            this.splitContainerControlRight.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControlRight.Name = "splitContainerControlRight";
            this.splitContainerControlRight.Panel1.Controls.Add(this.groupControlInfo);
            this.splitContainerControlRight.Panel1.Text = "Panel1";
            this.splitContainerControlRight.Panel2.Controls.Add(this.groupControl4);
            this.splitContainerControlRight.Panel2.Text = "Panel2";
            this.splitContainerControlRight.Size = new System.Drawing.Size(592, 561);
            this.splitContainerControlRight.SplitterPosition = 340;
            this.splitContainerControlRight.TabIndex = 0;
            this.splitContainerControlRight.Text = "splitContainerControl2";
            // 
            // groupControlInfo
            // 
            this.groupControlInfo.Controls.Add(this.gridControlRight);
            this.groupControlInfo.Controls.Add(this.groupControlBottom);
            this.groupControlInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlInfo.Location = new System.Drawing.Point(0, 0);
            this.groupControlInfo.Name = "groupControlInfo";
            this.groupControlInfo.Size = new System.Drawing.Size(592, 340);
            this.groupControlInfo.TabIndex = 0;
            this.groupControlInfo.Text = "权限信息浏览";
            // 
            // gridControlRight
            // 
            this.gridControlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlRight.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlRight.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlRight.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlRight.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlRight.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlRight.Location = new System.Drawing.Point(2, 23);
            this.gridControlRight.MainView = this.gridViewMain;
            this.gridControlRight.Name = "gridControlRight";
            this.gridControlRight.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit1,
            this.repositoryItemDateEdit1});
            this.gridControlRight.Size = new System.Drawing.Size(588, 215);
            this.gridControlRight.TabIndex = 0;
            this.gridControlRight.UseEmbeddedNavigator = true;
            this.gridControlRight.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            this.gridControlRight.DoubleClick += new System.EventHandler(this.gridControlRight_DoubleClick);
            // 
            // gridViewMain
            // 
            this.gridViewMain.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridViewMain.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gridViewMain.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridViewMain.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewMain.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridViewMain.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridViewMain.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridViewMain.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridViewMain.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridViewMain.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gridViewMain.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridViewMain.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridViewMain.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridViewMain.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridViewMain.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridViewMain.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridViewMain.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gridViewMain.Appearance.Empty.Options.UseBackColor = true;
            this.gridViewMain.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gridViewMain.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewMain.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridViewMain.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridViewMain.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridViewMain.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gridViewMain.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridViewMain.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewMain.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridViewMain.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridViewMain.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridViewMain.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridViewMain.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gridViewMain.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewMain.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridViewMain.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridViewMain.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gridViewMain.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridViewMain.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gridViewMain.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridViewMain.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridViewMain.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridViewMain.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gridViewMain.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewMain.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewMain.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewMain.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridViewMain.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gridViewMain.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridViewMain.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewMain.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridViewMain.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridViewMain.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridViewMain.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewMain.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridViewMain.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridViewMain.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewMain.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridViewMain.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridViewMain.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridViewMain.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridViewMain.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridViewMain.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridViewMain.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridViewMain.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridViewMain.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridViewMain.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gridViewMain.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridViewMain.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewMain.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridViewMain.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridViewMain.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridViewMain.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewMain.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewMain.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridViewMain.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gridViewMain.Appearance.GroupRow.Options.UseFont = true;
            this.gridViewMain.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridViewMain.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridViewMain.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gridViewMain.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridViewMain.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewMain.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridViewMain.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewMain.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridViewMain.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewMain.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gridViewMain.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gridViewMain.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewMain.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewMain.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gridViewMain.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridViewMain.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridViewMain.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewMain.Appearance.OddRow.Options.UseBackColor = true;
            this.gridViewMain.Appearance.OddRow.Options.UseForeColor = true;
            this.gridViewMain.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gridViewMain.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gridViewMain.Appearance.Preview.Options.UseBackColor = true;
            this.gridViewMain.Appearance.Preview.Options.UseForeColor = true;
            this.gridViewMain.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridViewMain.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridViewMain.Appearance.Row.Options.UseBackColor = true;
            this.gridViewMain.Appearance.Row.Options.UseForeColor = true;
            this.gridViewMain.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridViewMain.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridViewMain.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gridViewMain.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewMain.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewMain.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewMain.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gridViewMain.Appearance.VertLine.Options.UseBackColor = true;
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.RightName,
            this.CreatePerson,
            this.CreateDate,
            this.ModifyPerson,
            this.ModifyDate});
            this.gridViewMain.GridControl = this.gridControlRight;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewMain.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewMain.OptionsBehavior.Editable = false;
            this.gridViewMain.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridViewMain.OptionsPrint.ExpandAllDetails = true;
            this.gridViewMain.OptionsPrint.PrintDetails = true;
            this.gridViewMain.OptionsPrint.PrintFilterInfo = true;
            this.gridViewMain.OptionsPrint.PrintPreview = true;
            this.gridViewMain.OptionsPrint.UsePrintStyles = true;
            this.gridViewMain.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewMain.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gridViewMain.OptionsSelection.MultiSelect = true;
            this.gridViewMain.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewMain.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewMain.OptionsView.ShowGroupPanel = false;
            this.gridViewMain.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridViewMain_SelectionChanged);
            // 
            // ID
            // 
            this.ID.Caption = "权限编号";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.ToolTip = "权限编号";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            // 
            // RightName
            // 
            this.RightName.Caption = "权限名称";
            this.RightName.FieldName = "NAME";
            this.RightName.Name = "RightName";
            this.RightName.ToolTip = "权限名称";
            this.RightName.Visible = true;
            this.RightName.VisibleIndex = 1;
            // 
            // CreatePerson
            // 
            this.CreatePerson.Caption = "创建人";
            this.CreatePerson.FieldName = "CREATEPERSON";
            this.CreatePerson.Name = "CreatePerson";
            this.CreatePerson.ToolTip = "创建人";
            this.CreatePerson.Visible = true;
            this.CreatePerson.VisibleIndex = 2;
            // 
            // CreateDate
            // 
            this.CreateDate.Caption = "创建时间";
            this.CreateDate.FieldName = "CREATEDATE";
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ToolTip = "创建时间";
            this.CreateDate.Visible = true;
            this.CreateDate.VisibleIndex = 3;
            // 
            // ModifyPerson
            // 
            this.ModifyPerson.Caption = "修改(&U)人";
            this.ModifyPerson.FieldName = "MODIFYPERSON";
            this.ModifyPerson.Name = "ModifyPerson";
            this.ModifyPerson.ToolTip = "修改(&U)人";
            this.ModifyPerson.Visible = true;
            this.ModifyPerson.VisibleIndex = 4;
            // 
            // ModifyDate
            // 
            this.ModifyDate.Caption = "修改(&U)时间";
            this.ModifyDate.FieldName = "MODIFYDATE";
            this.ModifyDate.Name = "ModifyDate";
            this.ModifyDate.ToolTip = "修改(&U)时间";
            this.ModifyDate.UnboundExpression = "[暂无]";
            this.ModifyDate.Visible = true;
            this.ModifyDate.VisibleIndex = 5;
            // 
            // repositoryItemHyperLinkEdit1
            // 
            this.repositoryItemHyperLinkEdit1.AutoHeight = false;
            this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // groupControlBottom
            // 
            this.groupControlBottom.Controls.Add(this.lblModuleNum);
            this.groupControlBottom.Controls.Add(this.btnBackR);
            this.groupControlBottom.Controls.Add(this.btnSave);
            this.groupControlBottom.Controls.Add(this.btnAdd);
            this.groupControlBottom.Controls.Add(this.btnDel);
            this.groupControlBottom.Controls.Add(this.btnUpdate);
            this.groupControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControlBottom.Location = new System.Drawing.Point(2, 238);
            this.groupControlBottom.Name = "groupControlBottom";
            this.groupControlBottom.Size = new System.Drawing.Size(588, 100);
            this.groupControlBottom.TabIndex = 1;
            this.groupControlBottom.Text = "信息操作";
            // 
            // lblModuleNum
            // 
            this.lblModuleNum.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleNum.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblModuleNum.Appearance.Options.UseFont = true;
            this.lblModuleNum.Appearance.Options.UseForeColor = true;
            this.lblModuleNum.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblModuleNum.Location = new System.Drawing.Point(2, 81);
            this.lblModuleNum.Name = "lblModuleNum";
            this.lblModuleNum.Size = new System.Drawing.Size(170, 17);
            toolTipTitleItem1.Text = "餐饮管理系统";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "当前系统用户权限可访问的模块数";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.lblModuleNum.SuperTip = superToolTip1;
            this.lblModuleNum.TabIndex = 15;
            this.lblModuleNum.Text = "此权限共可访问：42个模块";
            // 
            // btnBackR
            // 
            this.btnBackR.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBackR.Location = new System.Drawing.Point(481, 38);
            this.btnBackR.Name = "btnBackR";
            this.btnBackR.Size = new System.Drawing.Size(75, 30);
            this.btnBackR.TabIndex = 1;
            this.btnBackR.Text = "返回(&B)";
            this.btnBackR.ToolTip = "返回系统主界面(Alt+B/Esc)";
            this.btnBackR.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(25, 38);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.ToolTip = "保存用户权限信息(Alt+S/Enter)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(139, 38);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "添加(&A)";
            this.btnAdd.ToolTip = "添加用户权限(Alt+A)";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(253, 38);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 30);
            this.btnDel.TabIndex = 0;
            this.btnDel.Text = "删除(&D)";
            this.btnDel.ToolTip = "删除用户权限(Alt+D)";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(367, 38);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 30);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "修改(&U)";
            this.btnUpdate.ToolTip = "修改用户权限(Alt+U)";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupControl4
            // 
            this.groupControl4.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl4.Appearance.Options.UseBackColor = true;
            this.groupControl4.Controls.Add(this.meDesc);
            this.groupControl4.Controls.Add(this.lblDesc);
            this.groupControl4.Controls.Add(this.txtHref);
            this.groupControl4.Controls.Add(this.lblHref);
            this.groupControl4.Controls.Add(this.txtName);
            this.groupControl4.Controls.Add(this.lblName);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl4.Location = new System.Drawing.Point(0, 0);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(592, 215);
            this.groupControl4.TabIndex = 17;
            this.groupControl4.Text = "详细信息";
            // 
            // meDesc
            // 
            this.meDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.meDesc.Location = new System.Drawing.Point(93, 140);
            this.meDesc.Name = "meDesc";
            this.meDesc.Size = new System.Drawing.Size(442, 44);
            this.meDesc.TabIndex = 14;
            // 
            // lblDesc
            // 
            this.lblDesc.Location = new System.Drawing.Point(27, 142);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(60, 14);
            this.lblDesc.TabIndex = 13;
            this.lblDesc.Text = "模块描述：";
            // 
            // txtHref
            // 
            this.txtHref.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHref.Location = new System.Drawing.Point(93, 92);
            this.txtHref.Name = "txtHref";
            this.txtHref.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtHref.Properties.Appearance.Options.UseBackColor = true;
            this.txtHref.Properties.ReadOnly = true;
            this.txtHref.Size = new System.Drawing.Size(442, 21);
            this.txtHref.TabIndex = 7;
            // 
            // lblHref
            // 
            this.lblHref.Location = new System.Drawing.Point(27, 95);
            this.lblHref.Name = "lblHref";
            this.lblHref.Size = new System.Drawing.Size(60, 14);
            this.lblHref.TabIndex = 6;
            this.lblHref.Text = "模块链接：";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(93, 46);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtName.Properties.Appearance.Options.UseBackColor = true;
            this.txtName.Properties.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(442, 21);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(27, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 14);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "模块名称：";
            // 
            // frmRightManagement
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBackR;
            this.ClientSize = new System.Drawing.Size(838, 561);
            this.Controls.Add(this.splitContainerControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Money Twins";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRightManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统用户权限设置";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlRight)).EndInit();
            this.splitContainerControlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInfo)).EndInit();
            this.groupControlInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlBottom)).EndInit();
            this.groupControlBottom.ResumeLayout(false);
            this.groupControlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHref.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.TreeView tvwModule;
        private System.Windows.Forms.ImageList imgTree;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.MemoEdit meDesc;
        private DevExpress.XtraEditors.LabelControl lblDesc;
        private DevExpress.XtraEditors.TextEdit txtHref;
        private DevExpress.XtraEditors.LabelControl lblHref;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControlRight;
        private DevExpress.XtraEditors.GroupControl groupControlInfo;
        private DevExpress.XtraGrid.GridControl gridControlRight;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDel;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn RightName;
        private DevExpress.XtraGrid.Columns.GridColumn CreatePerson;
        private DevExpress.XtraGrid.Columns.GridColumn CreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn ModifyPerson;
        private DevExpress.XtraGrid.Columns.GridColumn ModifyDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnBackR;
        private DevExpress.XtraEditors.LabelControl lblModuleNum;
        private DevExpress.XtraEditors.GroupControl groupControlBottom;

    }
}