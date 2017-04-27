namespace CMS.UILayer.frmGeneralTool
{
    partial class frmDataMaintenance
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tabCon = new DevExpress.XtraTab.XtraTabControl();
            this.tabDataBeiFen = new DevExpress.XtraTab.XtraTabPage();
            this.txtBakeUpPath = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnBackUpSearchOpen = new DevExpress.XtraEditors.SimpleButton();
            this.btnBackUP = new DevExpress.XtraEditors.SimpleButton();
            this.tabpagHuanyuan = new DevExpress.XtraTab.XtraTabPage();
            this.txtRecoverPath = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnRecoverFile = new DevExpress.XtraEditors.SimpleButton();
            this.btnRecover = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tabCon)).BeginInit();
            this.tabCon.SuspendLayout();
            this.tabDataBeiFen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBakeUpPath.Properties)).BeginInit();
            this.tabpagHuanyuan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRecoverPath.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(14, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(390, 34);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "温馨提示:为了预防您宝贵的数据因各种难预料的原因而丢失,请\r\n定期备份您的数据,当意外发生时您可以及时恢复数据!";
            // 
            // tabCon
            // 
            this.tabCon.Location = new System.Drawing.Point(12, 60);
            this.tabCon.Name = "tabCon";
            this.tabCon.SelectedTabPage = this.tabDataBeiFen;
            this.tabCon.Size = new System.Drawing.Size(392, 151);
            this.tabCon.TabIndex = 1;
            this.tabCon.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabDataBeiFen,
            this.tabpagHuanyuan});
            // 
            // tabDataBeiFen
            // 
            this.tabDataBeiFen.Controls.Add(this.txtBakeUpPath);
            this.tabDataBeiFen.Controls.Add(this.labelControl4);
            this.tabDataBeiFen.Controls.Add(this.btnExit);
            this.tabDataBeiFen.Controls.Add(this.btnBackUpSearchOpen);
            this.tabDataBeiFen.Controls.Add(this.btnBackUP);
            this.tabDataBeiFen.Name = "tabDataBeiFen";
            this.tabDataBeiFen.Size = new System.Drawing.Size(385, 121);
            this.tabDataBeiFen.Text = "数据备份";
            // 
            // txtBakeUpPath
            // 
            this.txtBakeUpPath.Location = new System.Drawing.Point(25, 39);
            this.txtBakeUpPath.Name = "txtBakeUpPath";
            this.txtBakeUpPath.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtBakeUpPath.Size = new System.Drawing.Size(252, 21);
            this.txtBakeUpPath.TabIndex = 10;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(25, 19);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(72, 14);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "数据备份到：";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(195, 84);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(64, 24);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "返回(&B)";
            this.btnExit.ToolTip = "返回主菜单(Alt+B/Esc)";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBackUpSearchOpen
            // 
            this.btnBackUpSearchOpen.Location = new System.Drawing.Point(283, 38);
            this.btnBackUpSearchOpen.Name = "btnBackUpSearchOpen";
            this.btnBackUpSearchOpen.Size = new System.Drawing.Size(64, 24);
            this.btnBackUpSearchOpen.TabIndex = 0;
            this.btnBackUpSearchOpen.Text = "浏览(&L)";
            this.btnBackUpSearchOpen.ToolTip = "选中备份位置(Alt+L)";
            this.btnBackUpSearchOpen.Click += new System.EventHandler(this.btnBackUpSearchOpen_Click);
            // 
            // btnBackUP
            // 
            this.btnBackUP.Location = new System.Drawing.Point(25, 84);
            this.btnBackUP.Name = "btnBackUP";
            this.btnBackUP.Size = new System.Drawing.Size(64, 24);
            this.btnBackUP.TabIndex = 0;
            this.btnBackUP.Text = "备份(&B)";
            this.btnBackUP.ToolTip = "确定备份(Alt+B)";
            this.btnBackUP.Click += new System.EventHandler(this.btnBackUP_Click);
            // 
            // tabpagHuanyuan
            // 
            this.tabpagHuanyuan.Controls.Add(this.txtRecoverPath);
            this.tabpagHuanyuan.Controls.Add(this.labelControl5);
            this.tabpagHuanyuan.Controls.Add(this.btnRecoverFile);
            this.tabpagHuanyuan.Controls.Add(this.btnRecover);
            this.tabpagHuanyuan.Controls.Add(this.btnCancle);
            this.tabpagHuanyuan.Name = "tabpagHuanyuan";
            this.tabpagHuanyuan.Size = new System.Drawing.Size(385, 121);
            this.tabpagHuanyuan.Text = "数据还原";
            // 
            // txtRecoverPath
            // 
            this.txtRecoverPath.Location = new System.Drawing.Point(25, 39);
            this.txtRecoverPath.Name = "txtRecoverPath";
            this.txtRecoverPath.Size = new System.Drawing.Size(252, 21);
            this.txtRecoverPath.TabIndex = 11;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(25, 19);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(84, 14);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "还原数据文件：";
            // 
            // btnRecoverFile
            // 
            this.btnRecoverFile.Location = new System.Drawing.Point(283, 38);
            this.btnRecoverFile.Name = "btnRecoverFile";
            this.btnRecoverFile.Size = new System.Drawing.Size(64, 24);
            this.btnRecoverFile.TabIndex = 4;
            this.btnRecoverFile.Text = "浏览(&L)";
            this.btnRecoverFile.ToolTip = "选泽要还原的数据(Alt+L)";
            this.btnRecoverFile.Click += new System.EventHandler(this.btnRecoverFile_Click);
            // 
            // btnRecover
            // 
            this.btnRecover.Location = new System.Drawing.Point(25, 84);
            this.btnRecover.Name = "btnRecover";
            this.btnRecover.Size = new System.Drawing.Size(64, 23);
            this.btnRecover.TabIndex = 4;
            this.btnRecover.Text = "还原(&R)";
            this.btnRecover.ToolTip = "确定还原(Alt+R)";
            this.btnRecover.Click += new System.EventHandler(this.btnRecover_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(196, 84);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(64, 23);
            this.btnCancle.TabIndex = 3;
            this.btnCancle.Text = "返回(&B)";
            this.btnCancle.ToolTip = "返回主菜单(Alt+B)";
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(26, 224);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(323, 14);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "★温馨小提示：默认时当前日期为备份文件名，扩展名为.bak";
            // 
            // frmDataMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 253);
            this.Controls.Add(this.tabCon);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDataMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据维护";
            ((System.ComponentModel.ISupportInitialize)(this.tabCon)).EndInit();
            this.tabCon.ResumeLayout(false);
            this.tabDataBeiFen.ResumeLayout(false);
            this.tabDataBeiFen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBakeUpPath.Properties)).EndInit();
            this.tabpagHuanyuan.ResumeLayout(false);
            this.tabpagHuanyuan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRecoverPath.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabControl tabCon;
        private DevExpress.XtraTab.XtraTabPage tabDataBeiFen;
        private DevExpress.XtraTab.XtraTabPage tabpagHuanyuan;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnBackUP;
        private DevExpress.XtraEditors.SimpleButton btnRecover;
        private DevExpress.XtraEditors.SimpleButton btnCancle;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtBakeUpPath;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnBackUpSearchOpen;
        private DevExpress.XtraEditors.TextEdit txtRecoverPath;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnRecoverFile;
    }
}