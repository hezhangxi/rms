namespace CMS.UILayer.frmOther
{
    partial class frmPrintSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintSet));
            this.chkFitToPageWidth = new System.Windows.Forms.CheckBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.gboxRowsToPrint = new System.Windows.Forms.GroupBox();
            this.rdoSelectedRows = new System.Windows.Forms.RadioButton();
            this.rdoAllRows = new System.Windows.Forms.RadioButton();
            this.lblColumnsToPrint = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chklst = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gboxRowsToPrint.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkFitToPageWidth
            // 
            this.chkFitToPageWidth.AutoSize = true;
            this.chkFitToPageWidth.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkFitToPageWidth.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkFitToPageWidth.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFitToPageWidth.Location = new System.Drawing.Point(180, 64);
            this.chkFitToPageWidth.Name = "chkFitToPageWidth";
            this.chkFitToPageWidth.Size = new System.Drawing.Size(78, 17);
            this.chkFitToPageWidth.TabIndex = 45;
            this.chkFitToPageWidth.Text = "适应页宽";
            this.chkFitToPageWidth.UseVisualStyleBackColor = true;
            // 
            // txtTitle
            // 
            this.txtTitle.AcceptsReturn = true;
            this.txtTitle.BackColor = System.Drawing.SystemColors.Window;
            this.txtTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTitle.Location = new System.Drawing.Point(3, 17);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTitle.Size = new System.Drawing.Size(170, 63);
            this.txtTitle.TabIndex = 43;
            // 
            // gboxRowsToPrint
            // 
            this.gboxRowsToPrint.Controls.Add(this.rdoSelectedRows);
            this.gboxRowsToPrint.Controls.Add(this.rdoAllRows);
            this.gboxRowsToPrint.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxRowsToPrint.Location = new System.Drawing.Point(177, 15);
            this.gboxRowsToPrint.Name = "gboxRowsToPrint";
            this.gboxRowsToPrint.Size = new System.Drawing.Size(173, 39);
            this.gboxRowsToPrint.TabIndex = 42;
            this.gboxRowsToPrint.TabStop = false;
            this.gboxRowsToPrint.Text = "打印(&P)行范围";
            // 
            // rdoSelectedRows
            // 
            this.rdoSelectedRows.AutoSize = true;
            this.rdoSelectedRows.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSelectedRows.Location = new System.Drawing.Point(94, 15);
            this.rdoSelectedRows.Name = "rdoSelectedRows";
            this.rdoSelectedRows.Size = new System.Drawing.Size(59, 16);
            this.rdoSelectedRows.TabIndex = 1;
            this.rdoSelectedRows.TabStop = true;
            this.rdoSelectedRows.Text = "选择行";
            this.rdoSelectedRows.UseVisualStyleBackColor = true;
            // 
            // rdoAllRows
            // 
            this.rdoAllRows.AutoSize = true;
            this.rdoAllRows.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAllRows.Location = new System.Drawing.Point(10, 15);
            this.rdoAllRows.Name = "rdoAllRows";
            this.rdoAllRows.Size = new System.Drawing.Size(59, 16);
            this.rdoAllRows.TabIndex = 0;
            this.rdoAllRows.TabStop = true;
            this.rdoAllRows.Text = "全部行";
            this.rdoAllRows.UseVisualStyleBackColor = true;
            // 
            // lblColumnsToPrint
            // 
            this.lblColumnsToPrint.AutoSize = true;
            this.lblColumnsToPrint.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumnsToPrint.Location = new System.Drawing.Point(5, 5);
            this.lblColumnsToPrint.Name = "lblColumnsToPrint";
            this.lblColumnsToPrint.Size = new System.Drawing.Size(125, 12);
            this.lblColumnsToPrint.TabIndex = 41;
            this.lblColumnsToPrint.Text = "选择要打印(&P)的信息列：";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.Control;
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnOK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.Location = new System.Drawing.Point(177, 223);
            this.btnOK.Name = "btnOK";
            this.btnOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnOK.Size = new System.Drawing.Size(81, 23);
            this.btnOK.TabIndex = 39;
            this.btnOK.Text = "打印(&P)";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.Location = new System.Drawing.Point(271, 223);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancel.Size = new System.Drawing.Size(78, 23);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chklst
            // 
            this.chklst.CheckOnClick = true;
            this.chklst.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklst.FormattingEnabled = true;
            this.chklst.Location = new System.Drawing.Point(4, 21);
            this.chklst.Name = "chklst";
            this.chklst.Size = new System.Drawing.Size(153, 228);
            this.chklst.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(177, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 35);
            this.label1.TabIndex = 46;
            this.label1.Text = "温馨提示：所选打印(&P)的列数将直接反映信息的打印(&P)质量";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(271, 223);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(78, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(177, 223);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(81, 23);
            this.button2.TabIndex = 39;
            this.button2.Text = "打印(&P)";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Location = new System.Drawing.Point(177, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 83);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "打印(&P)标题";
            // 
            // frmPrintSet
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(373, 259);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkFitToPageWidth);
            this.Controls.Add(this.gboxRowsToPrint);
            this.Controls.Add(this.lblColumnsToPrint);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.chklst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrintSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "打印(&P)设置";
            this.Load += new System.EventHandler(this.FormPrintSet_Load);
            this.gboxRowsToPrint.ResumeLayout(false);
            this.gboxRowsToPrint.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.CheckBox chkFitToPageWidth;
        internal System.Windows.Forms.TextBox txtTitle;
        internal System.Windows.Forms.GroupBox gboxRowsToPrint;
        internal System.Windows.Forms.RadioButton rdoSelectedRows;
        internal System.Windows.Forms.RadioButton rdoAllRows;
        internal System.Windows.Forms.Label lblColumnsToPrint;
        protected System.Windows.Forms.Button btnOK;
        protected System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.CheckedListBox chklst;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Button button1;
        protected System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}