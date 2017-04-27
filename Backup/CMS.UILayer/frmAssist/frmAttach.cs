
//******************************************************************************************************
//** Copyright (C) 2010-2013 重大网络教育学院
//** 创建人：桂书丛
//** 类名称\文件名：frmAttach
//** 类功能:附加系统数据库
//** 描 述：附加系统数据库
//** 创建日期：2013-1-30
//** 修改(&U)人：桂书丛
//** 修改(&U)日期：2013-1-30
//** 整理日期：2013-1-30
//******************************************************************************************************

using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Win32;
using DBUtility;

namespace CMS.UILayer.frmAssist
{
    public partial class frmAttach : DevExpress.XtraEditors.XtraForm
    {
        public string MDFPath = null;
        public string LDFPath = null;
        public string LDFName = null;
        public string MDFName = null;
        private string GetLDFPath(string fileName)
        {
            int position = 0;
            for (int i = 0; i < fileName.Length; i++)
            {
                if (fileName[i] == '.')
                {
                    position = i;
                    break;
                }
            }
            return fileName.Remove(position).Insert(position, "_Log.LDF");
        }
        //private string GetFileName(string filename)
        //{
        //    string str = null;
        //    for (int i = 0; i < filename.Length;i++ )
        //    {
        //        if(filename[i]=='\\')
        //        {
        //            str = filename.Substring(i, filename.Length);
        //        }
        //    }
        //    return str;
        //}
        public frmAttach()
        {
            InitializeComponent();
        }

        private void InsertListView(string mdfPath, string ldfPath)
        {
            ListViewItem itemMDF = new ListViewItem();
            itemMDF.Text = MDFPath;
            itemMDF.Checked = true;
            itemMDF.SubItems.Add(MDFName);
            ListViewItem itemLDF = new ListViewItem();
            itemLDF.Text = LDFPath;
            itemLDF.Checked = true;
            itemLDF.SubItems.Add(LDFName);
            listViewDatabase.Items.Add(itemMDF);
            listViewDatabase.Items.Add(itemLDF);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            //Application.Restart();
        }
        private void btnSure_Click(object sender, EventArgs e)
        {
            try
            {
                if (MDFPath == "")
                {
                    MessageBox.Show("附加数据库不能为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DbOperator operate = new DbOperator();
                    operate.DatabaseName = "CMS";
                    operate.MDFPath = MDFPath;
                    operate.LDFPath = LDFPath;
                    operate.AttachDatabase();
                }
            }
            catch (Exception se)
            {
                MessageBox.Show(se.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            DevExpress.XtraEditors.XtraMessageBox.Show("系统数据库附加成功，请重启本系统","恭喜！");
            this.DialogResult = DialogResult.OK;
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "数据库文件(*.MDF)|*.MDF|数据库文件(*.LDF)|*.LDF";
            openFileDialog.FilterIndex = 0;
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = openFileDialog.FileName;
                    MDFPath = openFileDialog.FileName;
                    LDFPath = this.GetLDFPath(MDFPath);
                    MDFName = MDFPath.Substring(MDFPath.LastIndexOf("\\") + 1);
                    LDFName = LDFPath.Substring(LDFPath.LastIndexOf("\\") + 1);
                    this.InsertListView(MDFPath, LDFPath);
                }
            }
            catch (Exception se)
            {
                MessageBox.Show(se.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}