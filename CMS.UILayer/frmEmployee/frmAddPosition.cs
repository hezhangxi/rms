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
    public partial class frmAddPosition : DevExpress.XtraEditors.XtraForm
    {
        BUCMS_DPInfo myBUCMS_DPInfo = new BUCMS_DPInfo();
        ModelCMS_DPInfo myModelCMS_DPInfo = new ModelCMS_DPInfo();
        DataTable myDataTable = new DataTable();
        DataRow myDataRow = null;
        int myDepID = 0;
        /// <summary>
        /// Initializes a new instance of the <see cref="frmAddPosition"/> class.
        /// </summary>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-06
        public frmAddPosition()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="frmAddPosition"/> class.
        /// </summary>
        /// <param name="paramDataRow">The param data row.</param>
        /// <param name="parammyDepID">The parammy dep ID.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-06
        public frmAddPosition(DataRow paramDataRow,int parammyDepID)
        {
            InitializeComponent();
            myDepID = parammyDepID;
            this.Text = "修改职位信息";
            this.lblPerson.Text = "修改人：";
            this.lblDate.Text = "修改时间：";
            this.txtNamePos.Text = paramDataRow["Name"].ToString();
            this.medDescription.Text=paramDataRow["Description"].ToString();
            myDataRow = paramDataRow;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="frmAddPosition"/> class.
        /// </summary>
        /// <param name="parammyDepID">The parammy dep ID.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-06
        public frmAddPosition(int parammyDepID)
        {
            InitializeComponent();
            myDepID = parammyDepID;
        }

        /// <summary>
        /// Handles the Load event of the frmAddPosition control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-06
        private void frmAddPosition_Load(object sender, EventArgs e)
        {
            BindingLupDep();
            this.txtPerson.Text = frmAssist.frmLogin.SysUser.UserName;
            this.txtDate.Text = DateTime.Now.ToString();
        }

        #region private void BindingLupDep()绑定部门信息
        /// <summary>
        /// 绑定部门信息
        /// </summary>
        private void BindingLupDep()
        {
            try
            {
                myDataTable = myBUCMS_DPInfo.GetOrder(false, "SubID", "0", false);
                this.lupDep.Properties.DataSource = myDataTable;
                this.lupDep.Properties.DisplayMember = "Name";
                this.lupDep.EditValue = myDepID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        /// <summary>
        /// Handles the Click event of the btnOK control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-06
        private void btnOK_Click(object sender, EventArgs e)
        {
            string NewPosName=this.txtNamePos.Text.Trim().ToString();
            if(this.Text=="添加新职位")
            {
                if (!CheckPosName())
                    return;
                if (!AddLog())
                    return;
            }
            if(this.Text=="修改职位信息")
            {
                if(!CheckIsUpdate())
                    return;
                //职位名称和所属部门只要改一个以上,就检测名称
                if (NewPosName != myDataRow["Name"].ToString() || Convert.ToInt32(this.lupDep.EditValue) != myDepID)
                {
                    if (!CheckPosName())
                        return;
                }
                if(!UpdateLog())
                {
                    return;
                }
            }
        }

        #region 添加职位

        #region private bool CheckPosName()检测职位名称
        /// <summary>
        /// 检测职位名称
        /// </summary>
        /// <returns></returns>
        private bool CheckPosName()
        {
            DataTable myDearDataTable=new DataTable();
            string PosName = this.txtNamePos.Text.Trim().ToString();
            if (PosName.Length == 0)
            {
                XtraMessageBox.Show("职位名称不能为空!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtNamePos.Focus();
                this.txtNamePos.SelectAll();
                return false;
            }
            try
            {
                string DepID = this.lupDep.EditValue.ToString();
                myDataTable = myBUCMS_DPInfo.GetOrder(false,"SubID",DepID,false);
                int Depcount=myDataTable.Rows.Count;
                for (int i = 0; i < Depcount;i++ )
                {
                    if(PosName==myDataTable.Rows[i]["Name"].ToString())
                    {
                        XtraMessageBox.Show("这个职位名称已经存在!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.txtNamePos.Focus();
                        this.txtNamePos.SelectAll();
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true; 
        }
        #endregion

        #region private bool AddLog()添加(日志)
        /// <summary>
        /// 添加(日志)
        /// </summary>
        /// <returns></returns>
        private bool AddLog()
        {
            if (ClassAssist.CommonOperator.HandleOperatorEnum("添加职位", AddPos()))
            {
                BUT_SysLog.InsertSysLog(VariedEnum.LogType.数据操作, frmAssist.frmLogin.SysUser.UserID,"成功注册了一个新职位");
                this.DialogResult = DialogResult.OK;
            }
            return true;
        }
        #endregion

        #region private VariedEnum.OperatorStatus AddPos()添加职位
        /// <summary>
        /// 添加职位
        /// </summary>
        /// <returns></returns>
        private VariedEnum.OperatorStatus AddPos()
        {
            myModelCMS_DPInfo.Name = this.txtNamePos.Text.Trim().ToString();
            myModelCMS_DPInfo.SubID =Convert.ToInt32( this.lupDep.EditValue);
            myModelCMS_DPInfo.Description = this.medDescription.Text.Trim().ToString();
            myModelCMS_DPInfo.CreatePerson = this.txtPerson.Text.ToString();
            myModelCMS_DPInfo.CreateDate = DateTime.Now;
            return myBUCMS_DPInfo.Insert(myModelCMS_DPInfo);
        }
        #endregion

        #endregion 添加职位

        #region  修改职位信息

        #region  private bool CheckIsUpdate() 检测是否做了改动
        /// <summary>
        /// 检测是否做了改动
        /// </summary>
        /// <returns></returns>
        private bool CheckIsUpdate()
        {
            string PosName = this.txtNamePos.Text.Trim().ToString();
            string PosDescription = this.medDescription.Text.Trim().ToString();
            if(PosName==myDataRow["Name"].ToString())
            {
                if(PosDescription==myDataRow["Description"].ToString())
                {
                    if(Convert.ToInt32( this.lupDep.EditValue)==myDepID)
                    {
                        XtraMessageBox.Show("您未做任何修改!","注意",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        this.txtNamePos.Focus();
                        this.txtNamePos.SelectAll();
                        return false;
                    }
                }
            }
            return true;
        }
        #endregion

        #region  private bool UpdateLog()修改(日志)
        /// <summary>
        /// 修改(日志)
        /// </summary>
        /// <returns></returns>
        private bool UpdateLog()
        {

            if (ClassAssist.CommonOperator.HandleOperatorEnum("职位信息修改", UpdatePos()))
            {
                BUT_SysLog.InsertSysLog(VariedEnum.LogType.数据操作, frmAssist.frmLogin.SysUser.UserID,"成功修改了一条职位信息");
                this.DialogResult = DialogResult.OK;
            }
            return true;
        }
        #endregion

        #region  private VariedEnum.OperatorStatus UpdatePos()修改
        /// <summary>
        /// 修改
        /// </summary>
        /// <returns></returns>
        private VariedEnum.OperatorStatus UpdatePos()
        {
            myModelCMS_DPInfo.Name = this.txtNamePos.Text.Trim().ToString();
            myModelCMS_DPInfo.Description = this.medDescription.Text.Trim().ToString();
            myModelCMS_DPInfo.ID = Convert.ToInt32(myDataRow["ID"].ToString());
            myModelCMS_DPInfo.SubID = Convert.ToInt32(this.lupDep.EditValue);
            myModelCMS_DPInfo.ModifyPerson = this.txtPerson.Text.ToString();
            myModelCMS_DPInfo.ModifyDate = DateTime.Now;
            return myBUCMS_DPInfo.Update(myModelCMS_DPInfo);
        }
        #endregion

        #endregion   修改职位信息

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
