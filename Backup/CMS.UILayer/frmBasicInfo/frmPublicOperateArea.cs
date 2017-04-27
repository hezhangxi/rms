using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using CMS.Model;
using CMS.BULayer;
namespace CMS.UILayer.frmBasicInfo
{
    public partial class frmPublicOperateArea : DevExpress.XtraEditors.XtraForm
    {
        private BUCMS_ItemDetail myBUCMS_ItemDetail = new BUCMS_ItemDetail();
        private VariedEnum.ItemType PublicOperator;
        private int ItemID = -5;

        public frmPublicOperateArea()
        {
            InitializeComponent();
        }

        public frmPublicOperateArea(VariedEnum.ItemType paramItemType)
        {
            InitializeComponent();
            this.PublicOperator = paramItemType;
            this.txtCreateDate.Text = DateTime.Now.ToString();
            this.txtCreatePerson.Text = frmAssist.frmLogin.SysUser.UserName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="frmPublicOperateArea"/> class.
        /// </summary>
        /// <param name="paramItemType">Type of the param item.</param>
        /// <param name="paramInfo">The param info.</param>
        /// <remarks></remarks>
        public frmPublicOperateArea(VariedEnum.ItemType paramItemType, object[] paramInfo)
        {
            InitializeComponent();
            PublicOperator = paramItemType;
            this.txtCreateDate.Text = DateTime.Now.ToString();
            this.txtCreatePerson.Text = frmAssist.frmLogin.SysUser.UserName;
            this.lblPerson.Text = "修改(&U)人：";
            this.lblDate.Text = "修改(&U)时间：";
            try
            {
                if (paramInfo.Length > 0)
                {
                    this.Text = "信息修改(&U)";
                    FillInfo(paramInfo);
                    this.btnSave.Click -= this.btnSave_Click;
                    this.btnSave.Click += this.btnRSave_Click;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void FillInfo(object[] paramInfo)
        {
            try
            {
                ItemID = Convert.ToInt16(paramInfo[0]);
                this.txtName.Text = paramInfo[2].ToString();
                this.txtDescription.Text = paramInfo[3].ToString();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "mmm");
            }
        }


        private bool CheckInput()
        {
            string Name = this.txtName.Text.Trim();
            if (Name.Length == 0)
            {
                XtraMessageBox.Show("请输入新项目名称", "信息输入不完整",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtName.Focus();
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
                if (!CheckInput())
                    return;
                VariedEnum.OperatorStatus EnOperatorStatus;
                try
                {
                    EnOperatorStatus = myBUCMS_ItemDetail.Insert(GetModel());
                    if (ClassAssist.CommonOperator.HandleOperatorEnum("项目类别添加(&A)", EnOperatorStatus))
                    {
                        BUT_SysLog.InsertSysLog(VariedEnum.LogType.数据操作, frmAssist.frmLogin.SysUser.UserID,
                            "成功添加(&A)了一条项目类别信息");
                        this.DialogResult = DialogResult.OK;
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
        }
        private void btnRSave_Click(object sender, EventArgs e)
        {
            try
            {
                VariedEnum.OperatorStatus EnOperatorStatus;
                //EnOperatorStatus = myBUCMS_ItemDetail.Update(GetModel());//使用存储过程
                EnOperatorStatus = myBUCMS_ItemDetail.Update(GetModel());
                if (ClassAssist.CommonOperator.HandleOperatorEnum("菜品类别修改(&U)", EnOperatorStatus))
                {
                    BUT_SysLog.InsertSysLog(VariedEnum.LogType.数据操作, frmAssist.frmLogin.SysUser.UserID,
                        "成功修改(&U)了一条菜品类别信息");
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private ModelCMS_ItemDetail GetModel()
        {
            try
            {
                ModelCMS_ItemDetail tempModelCMS_ItemDetail = new ModelCMS_ItemDetail();
                tempModelCMS_ItemDetail.ID = this.ItemID;
                tempModelCMS_ItemDetail.Name = this.txtName.Text.Trim();
                tempModelCMS_ItemDetail.TypeID = Convert.ToInt32(PublicOperator);
                tempModelCMS_ItemDetail.Description = this.txtDescription.Text.Trim();
                tempModelCMS_ItemDetail.CreateDate = tempModelCMS_ItemDetail.ModifyDate = DateTime.Now;
                tempModelCMS_ItemDetail.CreatePerson = tempModelCMS_ItemDetail.ModifyPerson = frmAssist.frmLogin.SysUser.UserName;
                return tempModelCMS_ItemDetail;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            return null;
        }

        private void frmPublicOperateArea_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.txtName.Text = string.Empty;
            this.txtDescription.Text = string.Empty;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}