namespace CMS.UILayer.frmOther
{
    partial class frmProcess
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
            this.lblDisplay = new System.Windows.Forms.Label();
            this.tmrProcess = new System.Windows.Forms.Timer(this.components);
            this.pgbProcess = new DevExpress.XtraEditors.ProgressBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.pgbProcess.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.ForeColor = System.Drawing.Color.Red;
            this.lblDisplay.Location = new System.Drawing.Point(13, 6);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(147, 14);
            this.lblDisplay.TabIndex = 1;
            this.lblDisplay.Text = "请等待，数据正在导出……";
            // 
            // tmrProcess
            // 
            this.tmrProcess.Enabled = true;
            this.tmrProcess.Tick += new System.EventHandler(this.tmrProcess_Tick);
            // 
            // pgbProcess
            // 
            this.pgbProcess.Location = new System.Drawing.Point(16, 31);
            this.pgbProcess.Name = "pgbProcess";
            this.pgbProcess.Properties.ShowTitle = true;
            this.pgbProcess.Properties.StartColor = System.Drawing.Color.Empty;
            this.pgbProcess.Size = new System.Drawing.Size(384, 25);
            this.pgbProcess.TabIndex = 2;
            // 
            // frmProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 75);
            this.Controls.Add(this.pgbProcess);
            this.Controls.Add(this.lblDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProcess";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据正在导出……";
            this.Load += new System.EventHandler(this.frmProcess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pgbProcess.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Timer tmrProcess;
        private DevExpress.XtraEditors.ProgressBarControl pgbProcess;
    }
}