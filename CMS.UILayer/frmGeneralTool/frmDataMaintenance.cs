using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DBUtility;
using CMS.BULayer;
namespace CMS.UILayer.frmGeneralTool
{
    /// <summary>
    /// 数据维护
    /// </summary>
    /// 修改(&U)人：桂书丛
    /// 修改(&U)时间：2013-03-02
    public partial class frmDataMaintenance : DevExpress.XtraEditors.XtraForm
    {
        //VariedEnum.OperatorStatus IsSuceed = VariedEnum.OperatorStatus.UnknowError;
        /// <summary>
        /// Initializes a new instance of the <see cref="frmDataMaintenance"/> class.
        /// </summary>
        /// 修改(&U)人：桂书丛
        /// 修改(&U)时间：2013-03-02
        public frmDataMaintenance()
        {
            InitializeComponent();
        }

        private void btnBackUpSearchOpen_Click(object sender, EventArgs e)   //(浏览)备份
        {
            SaveFileDialog mySaveFileDialog = new SaveFileDialog();
            mySaveFileDialog.AddExtension = true;
            mySaveFileDialog.Title = "数据备份到";
            mySaveFileDialog.Filter = "备份文件(*.bak)|*.bak|所有文件(*.*)|*.*";
            mySaveFileDialog.DefaultExt = "*.bak";
            mySaveFileDialog.FileName = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString();
            if( mySaveFileDialog.ShowDialog() == DialogResult.OK)
                this.txtBakeUpPath.Text = mySaveFileDialog.FileName;
        }

        private void btnBackUP_Click(object sender, EventArgs e)             //备份
        {
            string BackUPPathName = this.txtBakeUpPath.Text.Trim().ToString();
            if (BackUPPathName.Length == 0)
            {
                XtraMessageBox.Show("备份路径不能为空!","注意",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                this.txtBakeUpPath.Focus();
                this.txtBakeUpPath.SelectAll();
                return;
            }
            if (!CheckPath(BackUPPathName))
             {
                 XtraMessageBox.Show("备份路径不正确,请重新输入!","注意",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                 this.txtBakeUpPath.Focus();
                 this.txtBakeUpPath.SelectAll();
                 return;
             }
            if (BackUPData(BackUPPathName))
            { 
                XtraMessageBox.Show("成功备份到："+BackUPPathName, "恭喜");
                BUT_SysLog.InsertSysLog(VariedEnum.LogType.数据操作, frmAssist.frmLogin.SysUser.UserID, "成功备份系统数据到：" + BackUPPathName);
            }
        }

        #region private bool BackUPData(string paramBakeUpFilePath) 备份数据
        /// <summary>
        /// 备份数据
        /// </summary>
        /// <returns></returns>
        private bool BackUPData(string paramBakeUpFilePath)
        {
            try
            {
                if (new DbOperator().DataBaseBackUp(paramBakeUpFilePath))
                {
                    return true;
                }
                else
                {
                    this.txtBakeUpPath.Focus();
                    this.txtBakeUpPath.SelectAll();
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
                return false;
            } 
        }
        #endregion

        #region  private bool CheckBackUPPath(string paramPath)检测路径输入是否正确(备份和还原公用)
        /// <summary>
        /// 检测路径输入是否正确(备份和还原公用)
        /// </summary>
        /// <returns></returns>
        private bool CheckPath(string paramPath)
        {
            //string BackUPPathName = this.txtBakeUpPath.Text.Trim().ToString();
            string DiskStrA = "CDEFGHIJK";
            string DiskStra = "cdefghijk";
            if (paramPath.Length >= 4) //至少四位
            {
                string FirstChar = paramPath.Substring(0, 1);
                if (DiskStrA.IndexOf(FirstChar) >= 0 || DiskStra.IndexOf(FirstChar) >= 0) //看第一个字符是否盘符
                {
                    string SecondChar = paramPath.Substring(1, 2);
                    if (SecondChar == ":\\")
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        #endregion

        private void btnRecoverFile_Click(object sender, EventArgs e)        //(浏览)还原
        {
            OpenFileDialog myOpenFileDialog = new OpenFileDialog();
            myOpenFileDialog.Title = "打开备份文件";
            myOpenFileDialog.Filter = "备份文件(*.bak)|*.bak|所有文件(*.*)|*.*";
            if( myOpenFileDialog.ShowDialog()==DialogResult.OK)
                this.txtRecoverPath.Text = myOpenFileDialog.FileName;
        }

        private void btnRecover_Click(object sender, EventArgs e)            //还原
        {
            string RecoverPath = this.txtRecoverPath.Text.Trim().ToString();
            if (RecoverPath.Length == 0)
            {
                XtraMessageBox.Show("还原路径不能为空!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtRecoverPath.Focus();
                this.txtRecoverPath.Select();
                return;
            }
            if (!CheckPath(RecoverPath))
            {
                XtraMessageBox.Show("还原输入路径不正确,请重新输入!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtRecoverPath.Focus();
                this.txtRecoverPath.SelectAll();
                return;
            }
            if (RecoverData(RecoverPath))
            {
                XtraMessageBox.Show("成功还原" + RecoverPath + "处的数据!", "恭喜");
                BUT_SysLog.InsertSysLog(VariedEnum.LogType.数据操作, frmAssist.frmLogin.SysUser.UserID, "成功还原" + RecoverPath + "处的数据!");
            }
        }

        #region  private bool RecoverData(string paramRecoverFilePath)还原数据
        /// <summary>
        /// 还原数据
        /// </summary>
        /// <returns></returns>
        private bool RecoverData(string paramRecoverFilePath)
        {
            try
            {
                if (DbOperator.DataBaseRecover(paramRecoverFilePath))
                {
                    return true;
                }
                else
                {
                    XtraMessageBox.Show("还原数据失败，请重新选择数据备份文件","抱歉",MessageBoxButtons.OK);
                    this.txtRecoverPath.Focus();
                    this.txtRecoverPath.SelectAll();
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
                
            } 
            return false;
        }
        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
