namespace CMS.UILayer.frmBasicInfo
{
    partial class frmBuffInfoOperate
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
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.spinEditPeopleContain = new DevExpress.XtraEditors.SpinEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblFloor = new DevExpress.XtraEditors.LabelControl();
            this.EditEquipmentID = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.txtInfoNote = new DevExpress.XtraEditors.MemoEdit();
            this.EditRoomTypeID = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDate = new DevExpress.XtraEditors.TextEdit();
            this.txtPerson = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.lblPerson = new DevExpress.XtraEditors.LabelControl();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.txtFloor = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditPeopleContain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditEquipmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInfoNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditRoomTypeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFloor.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnBack);
            this.groupControl2.Controls.Add(this.btnSave);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl2.Location = new System.Drawing.Point(375, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(137, 340);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "操作区";
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(28, 125);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 30);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "返回(&B)";
            this.btnBack.ToolTip = "返回主界面(Alt+B/Esc)";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(28, 39);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 30);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.ToolTip = "保存用户信息(Alt+S/Enter)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // spinEditPeopleContain
            // 
            this.spinEditPeopleContain.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditPeopleContain.Location = new System.Drawing.Point(296, 36);
            this.spinEditPeopleContain.Name = "spinEditPeopleContain";
            this.spinEditPeopleContain.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEditPeopleContain.Properties.DisplayFormat.FormatString = "{0}人";
            this.spinEditPeopleContain.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinEditPeopleContain.Properties.MaxValue = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.spinEditPeopleContain.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditPeopleContain.Size = new System.Drawing.Size(59, 21);
            this.spinEditPeopleContain.TabIndex = 11;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtFloor);
            this.groupControl1.Controls.Add(this.lblFloor);
            this.groupControl1.Controls.Add(this.EditEquipmentID);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.EditRoomTypeID);
            this.groupControl1.Controls.Add(this.spinEditPeopleContain);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtDate);
            this.groupControl1.Controls.Add(this.txtPerson);
            this.groupControl1.Controls.Add(this.txtName);
            this.groupControl1.Controls.Add(this.lblDate);
            this.groupControl1.Controls.Add(this.lblPerson);
            this.groupControl1.Controls.Add(this.lblName);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(375, 340);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "信息显示区 ";
            // 
            // lblFloor
            // 
            this.lblFloor.Location = new System.Drawing.Point(26, 121);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(60, 14);
            this.lblFloor.TabIndex = 16;
            this.lblFloor.Text = "楼层信息：";
            // 
            // EditEquipmentID
            // 
            this.EditEquipmentID.AllowDrop = true;
            this.EditEquipmentID.Location = new System.Drawing.Point(92, 165);
            this.EditEquipmentID.Name = "EditEquipmentID";
            this.EditEquipmentID.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.EditEquipmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EditEquipmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Condition", "空调", 69, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Fan", "电扇", 58, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TV", "电视机", 82, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DVD", "DVD"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Other", "其他设备")});
            this.EditEquipmentID.Properties.DisplayFormat.FormatString = "第{0}种设备配置";
            this.EditEquipmentID.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.EditEquipmentID.Properties.DisplayMember = "ID";
            this.EditEquipmentID.Properties.ValueMember = "ID";
            this.EditEquipmentID.Size = new System.Drawing.Size(263, 21);
            this.EditEquipmentID.TabIndex = 15;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(28, 168);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 14);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "包厢设备：";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.txtInfoNote);
            this.groupControl3.Location = new System.Drawing.Point(26, 197);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(329, 64);
            this.groupControl3.TabIndex = 13;
            this.groupControl3.Text = "信息备注";
            // 
            // txtInfoNote
            // 
            this.txtInfoNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInfoNote.Location = new System.Drawing.Point(2, 23);
            this.txtInfoNote.Name = "txtInfoNote";
            this.txtInfoNote.Size = new System.Drawing.Size(325, 39);
            this.txtInfoNote.TabIndex = 2;
            // 
            // EditRoomTypeID
            // 
            this.EditRoomTypeID.AllowDrop = true;
            this.EditRoomTypeID.Location = new System.Drawing.Point(92, 79);
            this.EditRoomTypeID.Name = "EditRoomTypeID";
            this.EditRoomTypeID.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.EditRoomTypeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EditRoomTypeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("包厢名称", "包厢名称", 58, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("包厢所在楼层", "包厢所在楼层", 82, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("包厢描述", "包厢描述", 58, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("有无空调", "空调", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("有无电扇", "电扇", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("有无电视机", "电视机", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("有无DVD", "DVD", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("其他设备", "其他设备", 58, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.EditRoomTypeID.Properties.DisplayMember = "包厢名称";
            this.EditRoomTypeID.Properties.ValueMember = "包厢编号";
            this.EditRoomTypeID.Size = new System.Drawing.Size(263, 21);
            this.EditRoomTypeID.TabIndex = 12;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(26, 82);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(60, 14);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "包厢类型：";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(233, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "容纳人数：";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(90, 307);
            this.txtDate.Name = "txtDate";
            this.txtDate.Properties.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(263, 21);
            this.txtDate.TabIndex = 1;
            // 
            // txtPerson
            // 
            this.txtPerson.Location = new System.Drawing.Point(92, 271);
            this.txtPerson.Name = "txtPerson";
            this.txtPerson.Properties.ReadOnly = true;
            this.txtPerson.Size = new System.Drawing.Size(263, 21);
            this.txtPerson.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(92, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(81, 21);
            this.txtName.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(26, 310);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(60, 14);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "创建时间：";
            // 
            // lblPerson
            // 
            this.lblPerson.Location = new System.Drawing.Point(26, 274);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(48, 14);
            this.lblPerson.TabIndex = 0;
            this.lblPerson.Text = "创建人：";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(26, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 14);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "餐台名称：";
            // 
            // txtFloor
            // 
            this.txtFloor.Location = new System.Drawing.Point(92, 118);
            this.txtFloor.Name = "txtFloor";
            this.txtFloor.Size = new System.Drawing.Size(263, 21);
            this.txtFloor.TabIndex = 17;
            // 
            // frmBuffInfoOperate
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(512, 340);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBuffInfoOperate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "餐台信息管理";
            this.Load += new System.EventHandler(this.frmBuffInfoOperate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spinEditPeopleContain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditEquipmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtInfoNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditRoomTypeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFloor.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.MemoEdit txtInfoNote;
        private DevExpress.XtraEditors.TextEdit txtDate;
        private DevExpress.XtraEditors.TextEdit txtPerson;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraEditors.LabelControl lblPerson;
        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SpinEdit spinEditPeopleContain;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LookUpEdit EditRoomTypeID;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl lblFloor;
        private DevExpress.XtraEditors.LookUpEdit EditEquipmentID;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtFloor;

    }
}