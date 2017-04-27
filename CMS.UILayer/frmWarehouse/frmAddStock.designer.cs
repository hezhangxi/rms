namespace CMS.UILayer.frmWarehouse
{
    partial class frmAddStock
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
            this.lbcInfoNote = new DevExpress.XtraEditors.MemoEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labOne = new DevExpress.XtraEditors.LabelControl();
            this.txtSpecifications = new DevExpress.XtraEditors.ComboBoxEdit();
            this.toolTip = new DevExpress.Utils.ToolTipController(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.lbcInfoNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpecifications.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbcInfoNote
            // 
            this.lbcInfoNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbcInfoNote.EditValue = "暂无";
            this.lbcInfoNote.Location = new System.Drawing.Point(2, 23);
            this.lbcInfoNote.Name = "lbcInfoNote";
            this.lbcInfoNote.Size = new System.Drawing.Size(190, 43);
            this.lbcInfoNote.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(91, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(126, 21);
            this.txtName.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(144, 147);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消(&C)";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(25, 147);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "确定(&O)";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(25, 44);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 14);
            this.labelControl3.TabIndex = 79;
            this.labelControl3.Text = "商品单位：";
            // 
            // labOne
            // 
            this.labOne.Location = new System.Drawing.Point(25, 12);
            this.labOne.Name = "labOne";
            this.labOne.Size = new System.Drawing.Size(60, 14);
            this.labOne.TabIndex = 77;
            this.labOne.Text = "商品名称：";
            // 
            // txtSpecifications
            // 
            this.txtSpecifications.EditValue = "斤";
            this.txtSpecifications.Location = new System.Drawing.Point(91, 41);
            this.txtSpecifications.Name = "txtSpecifications";
            this.txtSpecifications.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSpecifications.Properties.Items.AddRange(new object[] {
            "斤",
            "量",
            "吨"});
            this.txtSpecifications.Size = new System.Drawing.Size(126, 21);
            this.txtSpecifications.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lbcInfoNote);
            this.groupControl1.Location = new System.Drawing.Point(25, 73);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(194, 68);
            this.groupControl1.TabIndex = 85;
            this.groupControl1.Text = "货物备注";
            // 
            // frmAddStock
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(250, 182);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.txtSpecifications);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加库存商品";
            ((System.ComponentModel.ISupportInitialize)(this.lbcInfoNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpecifications.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit lbcInfoNote;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labOne;
        private DevExpress.XtraEditors.ComboBoxEdit txtSpecifications;
        private DevExpress.Utils.ToolTipController toolTip;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}