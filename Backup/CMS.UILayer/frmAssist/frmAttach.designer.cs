namespace CMS.UILayer.frmAssist
{
    partial class frmAttach
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改(&U)此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.listViewDatabase = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelect = new DevExpress.XtraEditors.SimpleButton();
            this.btnSure = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.txtPath = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPath.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "原文件名";
            this.columnHeader2.Width = 202;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "当前文件位置";
            this.columnHeader1.Width = 199;
            // 
            // listViewDatabase
            // 
            this.listViewDatabase.CheckBoxes = true;
            this.listViewDatabase.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewDatabase.FullRowSelect = true;
            this.listViewDatabase.GridLines = true;
            this.listViewDatabase.Location = new System.Drawing.Point(12, 60);
            this.listViewDatabase.Name = "listViewDatabase";
            this.listViewDatabase.Size = new System.Drawing.Size(417, 185);
            this.listViewDatabase.TabIndex = 9;
            this.listViewDatabase.UseCompatibleStateImageBehavior = false;
            this.listViewDatabase.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "请选择附加数据库的MDF文件";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(438, 30);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(85, 23);
            this.btnSelect.TabIndex = 12;
            this.btnSelect.Text = "浏览(&S)";
            this.btnSelect.ToolTip = "查找数据库文件(Alt+S)";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnSure
            // 
            this.btnSure.Location = new System.Drawing.Point(438, 174);
            this.btnSure.Name = "btnSure";
            this.btnSure.Size = new System.Drawing.Size(85, 23);
            this.btnSure.TabIndex = 13;
            this.btnSure.Text = "确定(&O)";
            this.btnSure.ToolTip = "确定附加数据库(Alt+O/Enter)";
            this.btnSure.Click += new System.EventHandler(this.btnSure_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(438, 222);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.ToolTip = "取消操作(Alt+C/Esc)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 32);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(417, 21);
            this.txtPath.TabIndex = 15;
            // 
            // frmAttach
            // 
            this.AcceptButton = this.btnSure;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(535, 261);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSure);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.listViewDatabase);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAttach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据库附加";
            ((System.ComponentModel.ISupportInitialize)(this.txtPath.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listViewDatabase;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnSelect;
        private DevExpress.XtraEditors.SimpleButton btnSure;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.TextEdit txtPath;
    }
}