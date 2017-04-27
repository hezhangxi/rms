using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CMS.BULayer;
using CMS.Model;
using DevExpress.XtraEditors;

namespace CMS.UILayer.frmEmployee
{
    public partial class frmAdd : DevExpress.XtraEditors.XtraForm
    {
        BUCMS_DPInfo myBUCMS_DPInfo = new BUCMS_DPInfo();
        ModelCMS_DPInfo myModelCMS_DPInfo = new ModelCMS_DPInfo();
        DataTable myDataTable = new DataTable();
        DataRow myDataRow = null;
        public frmAdd()
        {
            InitializeComponent();
        }

        public frmAdd(DataRow paramDataRow)
        {
            InitializeComponent();
            myDataRow = paramDataRow;
            UpdateControls();
        }

        #region  private void UpdateControls()初始化修改窗体
        /// <summary>
        /// 初始化修改窗体
        /// </summary>
        private void UpdateControls()
        {
            this.Text = "修改部门信息";
            this.lblDate.Text ="修改人";
            this.lblPerson.Text = "修改时间";
            this.txtNameDep.Text = myDataRow["Name"].ToString();
            this.medDescription.Text = myDataRow["Description"].ToString();
        }
        #endregion

        private void frmAdd_Load(object sender, EventArgs e)
        {
            this.txtPerson.Text = frmAssist.frmLogin.SysUser.UserName;
            this.txtDate.Text = DateTime.Now.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(this.Text=="添加新部门")
            {
                if (!CheckDepName())
                    return;
                if (!Add())
                    return;
            }
            if(this.Text=="修改部门信息")
            {
                if (CheckIsUpdate()) //如果做了修改
                {
                    if(this.txtNameDep.Text.Trim().ToString()!=myDataRow["Name"].ToString()) //当修改了名称后
                    {
                    if (!CheckDepName())
                        return;
                    }
                     if (!UpdateToLog())
                        return;
                }
                else
                    return;
            }
        }

        #region 添加部门

        #region private bool CheckDepName()检测部门名称是否正确(包括是否存在)
        /// <summary>
        /// 检测部门名称是否正确(包括是否存在)
        /// </summary>
        /// <returns></returns>
        private bool CheckDepName()
        {
            string DepName = this.txtNameDep.Text.Trim().ToString();
            if(DepName.Length==0)
            {
                XtraMessageBox.Show("部门名称不能为空!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtNameDep.Focus();
                this.txtNameDep.SelectAll();
                return false;
            }
            try
            {
                myDataTable = myBUCMS_DPInfo.GetOrder(false,"Name",DepName,false);
                if(myDataTable.Rows.Count>0)
                {
                    XtraMessageBox.Show("这个部门名称已经存在!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtNameDep.Focus();
                    this.txtNameDep.SelectAll();
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true; 
               
        }
        #endregion

        #region private bool Add()添加部门(日志)
        /// <summary>
        /// 添加部门（日志）
        /// </summary>
        /// <returns></returns>
        private bool Add()
        {
          if(ClassAssist.CommonOperator.HandleOperatorEnum("添加部门",AddInto()))
          {
              BUT_SysLog.InsertSysLog(VariedEnum.LogType.数据操作, frmAssist.frmLogin.SysUser.UserID,
                 "成功注册了一个新会员");
              this.DialogResult = DialogResult.OK;
          }
          return true;
        }
        #endregion

        #region  private VariedEnum.OperatorStatus AddInto()插入
        /// <summary>
        /// 插入
        /// </summary>
        /// <returns></returns>
        private VariedEnum.OperatorStatus AddInto()
        {
            myModelCMS_DPInfo.Name = this.txtNameDep.Text.Trim().ToString();
            myModelCMS_DPInfo.CreatePerson = this.txtPerson.Text.Trim().ToString();
            myModelCMS_DPInfo.CreateDate = DateTime.Now; ;
            myModelCMS_DPInfo.Description = this.medDescription.Text.Trim().ToString();
            myModelCMS_DPInfo.SubID = 0;
            return myBUCMS_DPInfo.Insert(myModelCMS_DPInfo);
        }
        #endregion

        #endregion 添加部门

        #region 修改部门信息

        #region private bool CheckIsUpdate()检测是否做了改动
        /// <summary>
        /// 检测是否做了改动
        /// </summary>
        /// <returns></returns>
        private bool CheckIsUpdate()
        {
            string DepName = this.txtNameDep.Text.Trim().ToString();
            string Descripion = this.medDescription.Text.Trim().ToString();
            if(DepName==myDataRow["Name"].ToString())
            {
                if(Descripion==myDataRow["Description"].ToString())
                {
                    XtraMessageBox.Show("您未做任何修改!","注意",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    this.txtNameDep.Focus();
                    this.txtNameDep.SelectAll();
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region private bool UpdateToLog()修改信息(写入日志)
        /// <summary>
        /// 修改信息(写入日志)
        /// </summary>
        /// <returns></returns>
        private bool UpdateToLog()
        {
            if (ClassAssist.CommonOperator.HandleOperatorEnum("部门信息修改", UpdateDep()))
            {
                BUT_SysLog.InsertSysLog(VariedEnum.LogType.数据操作, frmAssist.frmLogin.SysUser.UserID,
                    "成功修改了一条部门信息");
                this.DialogResult = DialogResult.OK;
            }
            return true;
        }
        #endregion

        #region private VariedEnum.OperatorStatus UpdateDep()更新数据
        /// <summary>
        /// 更新数据
        /// </summary>
        /// <returns></returns>
        private VariedEnum.OperatorStatus UpdateDep()
        {
            myModelCMS_DPInfo.Name = this.txtNameDep.Text.Trim().ToString();
            myModelCMS_DPInfo.Description=this.medDescription.Text.Trim().ToString();
            myModelCMS_DPInfo.ID=Convert.ToInt32(myDataRow["ID"].ToString());
            myModelCMS_DPInfo.SubID = 0;//部门的SubID全是0
            myModelCMS_DPInfo.ModifyPerson = this.txtPerson.Text.ToString();
            myModelCMS_DPInfo.ModifyDate = DateTime.Now;
            return myBUCMS_DPInfo.Update(myModelCMS_DPInfo);
        }
        #endregion

        #endregion 修改部门信息

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
