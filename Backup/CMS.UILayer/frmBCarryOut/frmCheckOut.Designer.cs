namespace CMS.UILayer.frmBCarryOut
{
    partial class frmCheckOut
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.IsPresent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblInfoNote = new DevExpress.XtraEditors.LabelControl();
            this.lblStatus = new DevExpress.XtraEditors.LabelControl();
            this.lblANum = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControlDetail = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.txtPayMoney = new DevExpress.XtraEditors.CalcEdit();
            this.lupPayType = new DevExpress.XtraEditors.LookUpEdit();
            this.spDisCount = new DevExpress.XtraEditors.SpinEdit();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.chkPrintList = new DevExpress.XtraEditors.CheckEdit();
            this.chkPrintBill = new DevExpress.XtraEditors.CheckEdit();
            this.btnOutList = new DevExpress.XtraEditors.SimpleButton();
            this.btnOutBill = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.txtShouldPay = new DevExpress.XtraEditors.TextEdit();
            this.txtChangeMoney = new DevExpress.XtraEditors.TextEdit();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnCheckOut = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalAmount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.chkVIP = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.Assistor = new DevExpress.XtraEditors.LabelControl();
            this.lblBillInfoNote = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.lblCustomerNum = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.lblBillID = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gridControlItem = new DevExpress.XtraGrid.GridControl();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DishName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DishType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Taste = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Date = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDetail)).BeginInit();
            this.groupControlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPayMoney.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupPayType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDisCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkPrintList.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPrintBill.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShouldPay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChangeMoney.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkVIP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
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
            this.IsPresent.Width = 83;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lblInfoNote);
            this.groupControl1.Controls.Add(this.lblStatus);
            this.groupControl1.Controls.Add(this.lblANum);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.lblName);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.lblID);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(865, 73);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "餐台基本信息";
            // 
            // lblInfoNote
            // 
            this.lblInfoNote.Location = new System.Drawing.Point(772, 37);
            this.lblInfoNote.Name = "lblInfoNote";
            this.lblInfoNote.Size = new System.Drawing.Size(48, 14);
            this.lblInfoNote.TabIndex = 1;
            this.lblInfoNote.Text = "经济实惠";
            // 
            // lblStatus
            // 
            this.lblStatus.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblStatus.Appearance.Options.UseForeColor = true;
            this.lblStatus.Location = new System.Drawing.Point(564, 37);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(36, 14);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "未使用";
            // 
            // lblANum
            // 
            this.lblANum.Location = new System.Drawing.Point(410, 37);
            this.lblANum.Name = "lblANum";
            this.lblANum.Size = new System.Drawing.Size(26, 14);
            this.lblANum.TabIndex = 0;
            this.lblANum.Text = "12人";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(681, 37);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(84, 14);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "餐台信息备注：";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(498, 37);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(60, 14);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "使用状态：";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(332, 37);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(72, 14);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "可容纳人数：";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(230, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 14);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "普通餐桌";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(164, 37);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 14);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "餐台名称：";
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(91, 37);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(14, 14);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "24";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(25, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "餐台编号：";
            // 
            // groupControlDetail
            // 
            this.groupControlDetail.Controls.Add(this.groupControl3);
            this.groupControlDetail.Controls.Add(this.groupControl2);
            this.groupControlDetail.Controls.Add(this.gridControlItem);
            this.groupControlDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlDetail.Location = new System.Drawing.Point(0, 73);
            this.groupControlDetail.Name = "groupControlDetail";
            this.groupControlDetail.Size = new System.Drawing.Size(865, 476);
            this.groupControlDetail.TabIndex = 2;
            this.groupControlDetail.Text = "此餐台详细消费信息";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.txtPayMoney);
            this.groupControl3.Controls.Add(this.lupPayType);
            this.groupControl3.Controls.Add(this.spDisCount);
            this.groupControl3.Controls.Add(this.groupControl4);
            this.groupControl3.Controls.Add(this.labelControl16);
            this.groupControl3.Controls.Add(this.labelControl13);
            this.groupControl3.Controls.Add(this.labelControl15);
            this.groupControl3.Controls.Add(this.txtShouldPay);
            this.groupControl3.Controls.Add(this.txtChangeMoney);
            this.groupControl3.Controls.Add(this.btnBack);
            this.groupControl3.Controls.Add(this.btnCheckOut);
            this.groupControl3.Controls.Add(this.labelControl14);
            this.groupControl3.Controls.Add(this.txtTotalAmount);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Controls.Add(this.chkVIP);
            this.groupControl3.Controls.Add(this.labelControl2);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl3.Location = new System.Drawing.Point(230, 23);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(633, 173);
            this.groupControl3.TabIndex = 10;
            this.groupControl3.Text = "账单操作";
            // 
            // txtPayMoney
            // 
            this.txtPayMoney.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            65536});
            this.txtPayMoney.Location = new System.Drawing.Point(80, 104);
            this.txtPayMoney.Name = "txtPayMoney";
            this.txtPayMoney.Properties.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.txtPayMoney.Properties.Appearance.Options.UseForeColor = true;
            this.txtPayMoney.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPayMoney.Size = new System.Drawing.Size(203, 21);
            this.txtPayMoney.TabIndex = 14;
            this.txtPayMoney.EditValueChanged += new System.EventHandler(this.txtPayMoney_EditValueChanged);
            this.txtPayMoney.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtPayMoney_EditValueChanging);
            // 
            // lupPayType
            // 
            this.lupPayType.Location = new System.Drawing.Point(250, 64);
            this.lupPayType.Name = "lupPayType";
            this.lupPayType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupPayType.Size = new System.Drawing.Size(218, 21);
            this.lupPayType.TabIndex = 13;
            // 
            // spDisCount
            // 
            this.spDisCount.EditValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spDisCount.Location = new System.Drawing.Point(250, 28);
            this.spDisCount.Name = "spDisCount";
            this.spDisCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spDisCount.Properties.DisplayFormat.FormatString = "{0}折";
            this.spDisCount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spDisCount.Properties.EditFormat.FormatString = "{0}折";
            this.spDisCount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spDisCount.Properties.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.spDisCount.Properties.Mask.EditMask = "n";
            this.spDisCount.Properties.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spDisCount.Size = new System.Drawing.Size(100, 21);
            this.spDisCount.TabIndex = 12;
            this.spDisCount.ToolTip = "消费总结金额打折";
            this.spDisCount.EditValueChanged += new System.EventHandler(this.spDisCount_EditValueChanged);
            this.spDisCount.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.spDisCount_EditValueChanging);
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.chkPrintList);
            this.groupControl4.Controls.Add(this.chkPrintBill);
            this.groupControl4.Controls.Add(this.btnOutList);
            this.groupControl4.Controls.Add(this.btnOutBill);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl4.Location = new System.Drawing.Point(482, 23);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.ShowCaption = false;
            this.groupControl4.Size = new System.Drawing.Size(149, 148);
            this.groupControl4.TabIndex = 10;
            this.groupControl4.Text = "groupControl4";
            // 
            // chkPrintList
            // 
            this.chkPrintList.Location = new System.Drawing.Point(8, 81);
            this.chkPrintList.Name = "chkPrintList";
            this.chkPrintList.Properties.Caption = "结账后打印(&P)消费列表 ";
            this.chkPrintList.Size = new System.Drawing.Size(129, 19);
            this.chkPrintList.TabIndex = 2;
            // 
            // chkPrintBill
            // 
            this.chkPrintBill.Location = new System.Drawing.Point(8, 114);
            this.chkPrintBill.Name = "chkPrintBill";
            this.chkPrintBill.Properties.Caption = "结账后打印(&P)账单信息";
            this.chkPrintBill.Size = new System.Drawing.Size(129, 19);
            this.chkPrintBill.TabIndex = 2;
            // 
            // btnOutList
            // 
            this.btnOutList.Location = new System.Drawing.Point(10, 45);
            this.btnOutList.Name = "btnOutList";
            this.btnOutList.Size = new System.Drawing.Size(129, 23);
            this.btnOutList.TabIndex = 11;
            this.btnOutList.Text = "导出消费列表(&L)";
            this.btnOutList.ToolTip = "导出消费列表(Alt+L)";
            this.btnOutList.Click += new System.EventHandler(this.btnOutList_Click);
            // 
            // btnOutBill
            // 
            this.btnOutBill.Location = new System.Drawing.Point(8, 7);
            this.btnOutBill.Name = "btnOutBill";
            this.btnOutBill.Size = new System.Drawing.Size(129, 23);
            this.btnOutBill.TabIndex = 11;
            this.btnOutBill.Text = "导出账单信息(&B)";
            this.btnOutBill.ToolTip = "导出账单信息(Alt+B)";
            this.btnOutBill.Click += new System.EventHandler(this.btnOutBill_Click);
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(14, 68);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(60, 14);
            this.labelControl16.TabIndex = 5;
            this.labelControl16.Text = "应收金额：";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(184, 66);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(60, 14);
            this.labelControl13.TabIndex = 5;
            this.labelControl13.Text = "支付方式：";
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(184, 32);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(60, 14);
            this.labelControl15.TabIndex = 5;
            this.labelControl15.Text = "整体打折：";
            // 
            // txtShouldPay
            // 
            this.txtShouldPay.EditValue = "￥145.5";
            this.txtShouldPay.Location = new System.Drawing.Point(80, 64);
            this.txtShouldPay.Name = "txtShouldPay";
            this.txtShouldPay.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtShouldPay.Properties.Appearance.Options.UseForeColor = true;
            this.txtShouldPay.Properties.DisplayFormat.FormatString = "c1";
            this.txtShouldPay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtShouldPay.Properties.ReadOnly = true;
            this.txtShouldPay.Size = new System.Drawing.Size(84, 21);
            this.txtShouldPay.TabIndex = 3;
            this.txtShouldPay.ToolTip = "消费总金额";
            // 
            // txtChangeMoney
            // 
            this.txtChangeMoney.EditValue = "￥0";
            this.txtChangeMoney.Location = new System.Drawing.Point(384, 104);
            this.txtChangeMoney.Name = "txtChangeMoney";
            this.txtChangeMoney.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtChangeMoney.Properties.Appearance.Options.UseForeColor = true;
            this.txtChangeMoney.Properties.DisplayFormat.FormatString = "c1";
            this.txtChangeMoney.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtChangeMoney.Properties.Mask.EditMask = "c";
            this.txtChangeMoney.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtChangeMoney.Properties.ReadOnly = true;
            this.txtChangeMoney.Size = new System.Drawing.Size(84, 21);
            this.txtChangeMoney.TabIndex = 3;
            this.txtChangeMoney.ToolTip = "消费总金额";
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(322, 139);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(146, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "返回(&B)";
            this.btnBack.ToolTip = "返回系统住界面(Alt+B/Esc)";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(14, 139);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(146, 23);
            this.btnCheckOut.TabIndex = 9;
            this.btnCheckOut.Text = "结账(&P)";
            this.btnCheckOut.ToolTip = "确定消费并付款(Alt+P/Enter)";
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(322, 107);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(56, 14);
            this.labelControl14.TabIndex = 5;
            this.labelControl14.Text = "找     零：";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.EditValue = "￥145.5";
            this.txtTotalAmount.Location = new System.Drawing.Point(80, 28);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtTotalAmount.Properties.Appearance.Options.UseForeColor = true;
            this.txtTotalAmount.Properties.DisplayFormat.FormatString = "c1";
            this.txtTotalAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotalAmount.Properties.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(84, 21);
            this.txtTotalAmount.TabIndex = 3;
            this.txtTotalAmount.ToolTip = "消费总金额";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(14, 32);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(60, 14);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "消费金额：";
            // 
            // chkVIP
            // 
            this.chkVIP.Location = new System.Drawing.Point(401, 31);
            this.chkVIP.Name = "chkVIP";
            this.chkVIP.Properties.Caption = "VIP消费";
            this.chkVIP.Size = new System.Drawing.Size(67, 19);
            this.chkVIP.TabIndex = 2;
            this.chkVIP.CheckedChanged += new System.EventHandler(this.chkVIP_CheckedChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 106);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "实收金额：";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.Assistor);
            this.groupControl2.Controls.Add(this.lblBillInfoNote);
            this.groupControl2.Controls.Add(this.labelControl11);
            this.groupControl2.Controls.Add(this.labelControl17);
            this.groupControl2.Controls.Add(this.lblCustomerNum);
            this.groupControl2.Controls.Add(this.labelControl10);
            this.groupControl2.Controls.Add(this.lblBillID);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl2.Location = new System.Drawing.Point(2, 23);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(222, 173);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "账单信息";
            // 
            // Assistor
            // 
            this.Assistor.Location = new System.Drawing.Point(84, 104);
            this.Assistor.Name = "Assistor";
            this.Assistor.Size = new System.Drawing.Size(24, 14);
            this.Assistor.TabIndex = 0;
            this.Assistor.Text = "张三";
            // 
            // lblBillInfoNote
            // 
            this.lblBillInfoNote.Location = new System.Drawing.Point(84, 139);
            this.lblBillInfoNote.Name = "lblBillInfoNote";
            this.lblBillInfoNote.Size = new System.Drawing.Size(24, 14);
            this.lblBillInfoNote.TabIndex = 0;
            this.lblBillInfoNote.Text = "暂无";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(23, 138);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(60, 14);
            this.labelControl11.TabIndex = 0;
            this.labelControl11.Text = "消费备注：";
            // 
            // labelControl17
            // 
            this.labelControl17.Location = new System.Drawing.Point(23, 104);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(48, 14);
            this.labelControl17.TabIndex = 0;
            this.labelControl17.Text = "服务员：";
            // 
            // lblCustomerNum
            // 
            this.lblCustomerNum.Location = new System.Drawing.Point(89, 70);
            this.lblCustomerNum.Name = "lblCustomerNum";
            this.lblCustomerNum.Size = new System.Drawing.Size(19, 14);
            this.lblCustomerNum.TabIndex = 0;
            this.lblCustomerNum.Text = "5人";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(23, 70);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(60, 14);
            this.labelControl10.TabIndex = 0;
            this.labelControl10.Text = "宾客人数：";
            // 
            // lblBillID
            // 
            this.lblBillID.Location = new System.Drawing.Point(84, 35);
            this.lblBillID.Name = "lblBillID";
            this.lblBillID.Size = new System.Drawing.Size(84, 14);
            this.lblBillID.TabIndex = 0;
            this.lblBillID.Text = "201302051145";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(23, 36);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 14);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "账单编号：";
            // 
            // gridControlItem
            // 
            this.gridControlItem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControlItem.Location = new System.Drawing.Point(2, 196);
            this.gridControlItem.MainView = this.gridViewMain;
            this.gridControlItem.Name = "gridControlItem";
            this.gridControlItem.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControlItem.Size = new System.Drawing.Size(861, 278);
            this.gridControlItem.TabIndex = 3;
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
            this.gridViewMain.ChildGridLevelName = "MarkID";
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
            this.DishType.SummaryItem.FieldName = "销售金额";
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
            this.Total.VisibleIndex = 7;
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
            // frmCheckOut
            // 
            this.AcceptButton = this.btnCheckOut;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(865, 549);
            this.Controls.Add(this.groupControlDetail);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCheckOut";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "宾客结账";
            this.Load += new System.EventHandler(this.frmCheckOut_Load);
            this.Shown += new System.EventHandler(this.frmCheckOut_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDetail)).EndInit();
            this.groupControlDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPayMoney.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupPayType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDisCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkPrintList.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPrintBill.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShouldPay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChangeMoney.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkVIP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lblInfoNote;
        private DevExpress.XtraEditors.LabelControl lblStatus;
        private DevExpress.XtraEditors.LabelControl lblANum;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControlDetail;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.CheckEdit chkVIP;
        private DevExpress.XtraEditors.TextEdit txtTotalAmount;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.SimpleButton btnCheckOut;
        private DevExpress.XtraEditors.TextEdit txtShouldPay;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtChangeMoney;
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
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lblCustomerNum;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl lblBillID;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl Assistor;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.CheckEdit chkPrintBill;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.CheckEdit chkPrintList;
        private DevExpress.XtraEditors.LabelControl lblBillInfoNote;
        private DevExpress.XtraEditors.SimpleButton btnOutList;
        private DevExpress.XtraEditors.SimpleButton btnOutBill;
        private DevExpress.XtraEditors.SpinEdit spDisCount;
        private DevExpress.XtraEditors.LookUpEdit lupPayType;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.CalcEdit txtPayMoney;

    }
}