using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CMS.Model;
using CMS.BULayer;
using DevExpress.XtraEditors;

namespace CMS.UILayer.frmVIPClient
{
    /// <summary>
    /// 会员卡信息添加
    /// </summary>
    /// 整理人：桂书丛
    /// 整理时间：2013-02-01
    public partial class frmUpdateVIPCard : DevExpress.XtraEditors.XtraForm
    {
        public frmUpdateVIPCard()
        {
            InitializeComponent();
        }
        object[] myUpdateVIP; //全局变量，保存选中的那条数据。

        /// <summary>
        /// Initializes a new instance of the <see cref="frmUpdateVIPCard"/> class.
        /// </summary>
        /// <param name="tempInfo">The temp info.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-01
        public frmUpdateVIPCard(object[] tempInfo)
        {
            myUpdateVIP = tempInfo;
            InitializeComponent();
            InitializeControls(tempInfo);
        }

        #region private void InitializeControls(object[] tempInfo)把要修改的数据初始化到控件中
        /// <summary>
        /// 把要修改的数据初始化到控件中
        /// </summary>
        /// <param name="tempInfo"></param>
        private void InitializeControls(object[] tempInfo)
        {
             this.Text = "修改会员卡信息";
             this.txtVIPName.Text=tempInfo[1].ToString();
             this.speDiscount.Text = tempInfo[2].ToString();
             this.medDescription.Text = tempInfo[3].ToString();
             this.txtModifyPerson.Text = frmAssist.frmLogin.SysUser.UserName;
             this.txtModifyDate.Text = DateTime.Now.ToString();
        }
        #endregion

        /// <summary>
        /// Handles the Click event of the btnOK control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-01
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!CheckInPut())                  //检测输入是否正确
            {
                return;
            }
            if (this.Text == "修改会员卡信息")  //如果要修改会员卡信息
            {
                if (UpdateVIPInfo() == false)
                    return;
            }
            if (this.Text == "添加会员卡类别") //如果是添加会员卡类别
            {
                if (AddVIPType() == false)
                    return;
            }
        }

        #region private bool AddVIPType()如果是添加会员卡类别
        /// <summary>
        /// 如果是添加会员卡类别
        /// </summary>
        /// <returns></returns>
        private bool AddVIPType()
        {
            string VIPName = this.txtVIPName.Text.Trim();
            decimal Discount = Convert.ToDecimal(this.speDiscount.EditValue);
            //检测会员卡名称是否存在
            if (CheckOnlyVIPDiscount("Name", VIPName) == 1)
            {
                XtraMessageBox.Show("改会员卡已存在!");
                this.txtVIPName.Focus();
                this.txtVIPName.SelectAll();
                return false; ;
            }
            ////检测折扣是否存在
            //if (CheckOnlyVIPDiscount("Discount", Discount.ToString()) == 1)
            //{
            //    XtraMessageBox.Show("您设置的折扣已存在!");
            //    this.speDiscount.Focus();
            //    this.speDiscount.SelectAll();
            //    return false; ;
            //}
            if (ClassAssist.CommonOperator.HandleOperatorEnum("添加会员卡类别", Add()))
            {
                BUT_SysLog.InsertSysLog(VariedEnum.LogType.数据操作, frmAssist.frmLogin.SysUser.UserID,"成功添加了一条会员卡");
                this.DialogResult = DialogResult.OK;
            }
            return true;
        }
        #endregion

        #region private bool UpdateVIPInfo() 如果是修改会员信息
        /// <summary>
        /// 如果是修改会员信息
        /// </summary>
        /// <returns></returns>
        private bool UpdateVIPInfo()
        {
            string VIPName = this.txtVIPName.Text.Trim();
            string Discount = this.speDiscount.EditValue.ToString();
            if (myUpdateVIP[1].ToString() != VIPName)               //更改了会员卡名称要视具体情况来检测
            {
                if (CheckOnlyVIPDiscount("Name", VIPName) == 1)     //更改了会员卡必须要检测会员卡名称
                {
                    XtraMessageBox.Show("该会员卡已存在!");
                    this.txtVIPName.Focus();
                    this.txtVIPName.SelectAll();
                    return false; ;
                }
                if (myUpdateVIP[2].ToString() != Discount)          //如果更改了折扣要检测折扣
                {
                    if (CheckOnlyVIPDiscount("Discount", Discount) == 1)
                    {
                        XtraMessageBox.Show("您设置的折扣已存在!");
                        this.speDiscount.Focus();
                        this.speDiscount.SelectAll();
                        return false;
                    }
                }
            }
            if (myUpdateVIP[1].ToString() == VIPName)               //没有更改会员卡名称只检测折扣
            {
                if (CheckOnlyVIPDiscount("Discount", Discount) == 1)
                {
                    XtraMessageBox.Show("您设置的折扣已存在!");
                    this.speDiscount.Focus();
                    this.speDiscount.SelectAll();
                    return false;
                }
            }
            if (ClassAssist.CommonOperator.HandleOperatorEnum("会员卡信息修改", UpdateVIP()))
            {
                BUT_SysLog.InsertSysLog(VariedEnum.LogType.数据操作, frmAssist.frmLogin.SysUser.UserID,"成功修改了一条会员卡信息");
                this.DialogResult = DialogResult.OK;
            }
            return true;
        }
        #endregion

        #region private bool CheckInPut()检测输入是否正确
        /// <summary>
        /// 检测输入是否正确
        /// </summary>
        /// <returns></returns>
        private bool CheckInPut()
        {
            try
            {
                string VIPTypeName = this.txtVIPName.Text.Trim();
                string Discount = this.speDiscount.EditValue.ToString();
                string Description = this.medDescription.Text.Trim();
                if (VIPTypeName.Length == 0)
                {
                    XtraMessageBox.Show("会员卡名称不能为空!");
                    this.txtVIPName.Focus();
                    this.txtVIPName.SelectAll();
                    return false;
                }
                if (VIPTypeName.Length != 0 && Discount.Length == 0)
                {
                    XtraMessageBox.Show("折扣不能为空!");
                    this.speDiscount.Focus();
                    this.speDiscount.SelectAll();
                    return false;
                }
                if (this.Text == "修改会员卡信息") //只有修改会员卡信息的时候才判断
                {
                    if (VIPTypeName == myUpdateVIP[1].ToString())
                    {
                        if (Discount == myUpdateVIP[2].ToString())
                        {
                            if (Description == myUpdateVIP[3].ToString())
                            {
                                XtraMessageBox.Show("您未做任何修改!");
                                return false;
                            }
                        }
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region private bool CheckOnlyVIPDiscount()检测会员名和折扣是否唯一
        /// <summary>
        /// 检测会员名称和折扣是否唯一
        /// </summary>
        /// <returns></returns>
        private int CheckOnlyVIPDiscount(string paramFiledName, string paramVIPDiscount)
        {
            BUCMS_VIPType myBUCMS_VIPType = new BUCMS_VIPType();
            DataTable myDataTable = new DataTable();
            myDataTable = myBUCMS_VIPType.GetOrder(false, paramFiledName, paramVIPDiscount, false);
            if(myDataTable.Rows.Count>0)
            {
                return 1;//已存在改会员卡
            }
            return 0;
        }
        #endregion

        #region private VariedEnum.OperatorStatus Update()修改数据
        /// <summary>
        /// 修改数据
        /// </summary>
        /// <returns></returns>
        private VariedEnum.OperatorStatus UpdateVIP()
        {
            ModelCMS_VIPType myModelCMS_VIPType = new ModelCMS_VIPType();
            myModelCMS_VIPType.Name = this.txtVIPName.Text.Trim();
            myModelCMS_VIPType.Discount = Convert.ToDecimal(this.speDiscount.EditValue);
            myModelCMS_VIPType.Description = this.medDescription.Text.Trim();
            myModelCMS_VIPType.ID = Convert.ToInt32(myUpdateVIP[0]);
            myModelCMS_VIPType.ModifyPerson = this.txtModifyPerson.Text.Trim();
            myModelCMS_VIPType.ModifyDate = DateTime.Now;
            BUCMS_VIPType myBUCMS_VIPType=new BUCMS_VIPType();
            return myBUCMS_VIPType.Update(myModelCMS_VIPType);
        }
        #endregion

        #region private VariedEnum.OperatorStatus Add()添加数据
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <returns></returns>
        private VariedEnum.OperatorStatus Add()
        {
            try
            {
                ModelCMS_VIPType myModelCMS_VIPType = new ModelCMS_VIPType();
                myModelCMS_VIPType.Name = this.txtVIPName.Text.Trim();
                myModelCMS_VIPType.Discount = Convert.ToDecimal(this.speDiscount.EditValue);
                myModelCMS_VIPType.Description = this.medDescription.Text.Trim();
                myModelCMS_VIPType.ModifyPerson = this.txtModifyPerson.Text.Trim();
                myModelCMS_VIPType.ModifyDate = DateTime.Now;
                BUCMS_VIPType myBUCMS_VIPType = new BUCMS_VIPType();
                return myBUCMS_VIPType.Insert(myModelCMS_VIPType);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
                return VariedEnum.OperatorStatus.Failed;
            }
        }
        #endregion

        /// <summary>
        /// Handles the Load event of the frmUpdateVIPCard control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理日期：2013-3-1
        private void frmUpdateVIPCard_Load(object sender, EventArgs e)
        {
            this.txtModifyPerson.Text = frmAssist.frmLogin.SysUser.UserName;
            this.txtModifyDate.Text = DateTime.Now.ToString();
        }

        /// <summary>
        /// Handles the Click event of the btnExit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理日期：2013-3-1
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
