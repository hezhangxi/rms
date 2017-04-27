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

namespace CMS.UILayer.frmVIPClient
{
    public partial class frmVIPInformation : DevExpress.XtraEditors.XtraForm
    {
        BUCMS_VIPClient myBUCMS_VIPClient = new BUCMS_VIPClient();
        string MruValue = null; //按条件查询的第二条件值
        public frmVIPInformation()
        {
            InitializeComponent();
        }

        private void frmVIPInformation_Load(object sender, EventArgs e)
        {
            InitializeControls();//绑定数据到表格
            BindingToSerach();//绑定数据到查询条件
            DateControlVisible(false);
            LookUpEdit(false);
            this.cmbField.SelectedIndex = 6;
            this.dateStart.Visible = true;
            this.dateEnd.Visible = true;
            this.lblFrom.Visible = true;
        }

        #region   private void BindingToSerach()绑定数据到查询条件的控件
        /// <summary>
        /// 绑定数据到查询条件的控件
        /// </summary>
        private void BindingToSerach()
        {
            DataTable myDataTable = new DataTable();
            try
            {
                //会员卡要从VIPType表中获取
                BUCMS_VIPType myBUCMS_VIPType = new BUCMS_VIPType();
                myDataTable = myBUCMS_VIPType.GetOrder(false,string.Empty,string.Empty,false);
                this.lupVIPType.Properties.DataSource = myDataTable;
                this.lupVIPType.ItemIndex = 0;
                this.lupVIPType.Properties.DisplayMember = "Name";
                //创建人要到User表中获取
                BUT_User myBUT_User = new BUT_User();
                myDataTable = myBUT_User.GetAllUserInfo();
                this.lupCreatePerson.Properties.DataSource = myDataTable;
                this.lupCreatePerson.ItemIndex = 0;
                this.lupCreatePerson.Properties.DisplayMember = "USERNAME";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region public void InitializeControls()绑定数据到gridControl表格
        /// <summary>
        /// 绑定数据到gridControl表格
        /// </summary>
        public void InitializeControls()
        {
            try
            {
                DataTable myDataTable = myBUCMS_VIPClient.GetOrderVIPClient(false,string.Empty,string.Empty);
                this.gridControlMain.DataSource = myDataTable;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }

        }
        #endregion

        private void btnRegisterNewVIP_Click(object sender, EventArgs e)//注册会员
        {
            frmRegisterNewVIP myfrmRegisterNewVIP = new frmRegisterNewVIP();
           if( myfrmRegisterNewVIP.ShowDialog()==DialogResult.OK)
               InitializeControls();
        }

        private void btnUpdateVIPInfo_Click(object sender, EventArgs e)//修改会员信息
        {
            if(this.gridViewOne.SelectedRowsCount<=0)//如果一行都没有选中
            {
                XtraMessageBox.Show("请选择要修改的项!", "注意:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //object[] tempInfo =ClassAssist.CommonOperator.GetGVSelectRowInfo(this.gridViewOne);//选中行的数据;
            DataRow tempDataRow = this.gridViewOne.GetFocusedDataRow();
            string  VIPName = this.txtVIPName.Text.Trim().ToString();
            frmRegisterNewVIP myfrmRegisterNewVIP = new frmRegisterNewVIP(tempDataRow,VIPName);
            if (myfrmRegisterNewVIP.ShowDialog() == DialogResult.OK)
                InitializeControls();
        }

        private void btnVIPCost_Click(object sender, EventArgs e)
        {
            if (this.gridViewOne.SelectedRowsCount <= 0)//如果一行都没有选中
            {
                XtraMessageBox.Show("请选择要修改的项!", "注意:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataRow tempDataRow = this.gridViewOne.GetFocusedDataRow();
            object  VIPName = this.txtVIPName.Text.ToString();
            object VIPDiscount = this.txtVIPDiscount.Text.ToString();
            frmPutInCost myfrmPutInCost = new frmPutInCost(tempDataRow, VIPName, VIPDiscount);
            if(myfrmPutInCost.ShowDialog()==DialogResult.OK)
                InitializeControls();
        }

        /// <summary>
        /// Handles the SelectionChanged event of the gridViewOne control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.Data.SelectionChangedEventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-01
        private void gridViewOne_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)//选中一行时发生
        {
            DataRow tempDataRow = this.gridViewOne.GetFocusedDataRow();//取出选中行的原始数据(在数据库中的)(数据库中的数据不一定全在控件中显示)
            if (tempDataRow == null)
                return;
            string myVIPID = tempDataRow["VIPTypeID"].ToString();
            BUCMS_VIPType myBUCMS_VIPType = new BUCMS_VIPType();
            try
            {
                this.txtVIPCost.EditValue = tempDataRow["VIPCost"];
                DataTable myDataTable = myBUCMS_VIPType.GetOrder(false,"ID",myVIPID,false);
                this.txtVIPName.Text = myDataTable.Rows[0]["Name"].ToString();
                this.txtVIPDiscount.EditValue = myDataTable.Rows[0]["Discount"];
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the btnDeleteVIP control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-01
        private void btnDeleteVIP_Click(object sender, EventArgs e)//删除
        {
            if(this.gridViewOne.SelectedRowsCount<=0)
            {
                XtraMessageBox.Show("请选择要删除的项!","注意",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            string VIPClientID = this.gridViewOne.GetFocusedRowCellValue("ID").ToString();
            DialogResult myDialogResult = XtraMessageBox.Show("编号为"+VIPClientID+"的会员","确定删除",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(DialogResult.Yes==myDialogResult)
            {
                VariedEnum.OperatorStatus EnOperatorStatus;
                try
                {
                    EnOperatorStatus = myBUCMS_VIPClient.Delete(VIPClientID);
                    if(ClassAssist.CommonOperator.HandleOperatorEnum("删除",EnOperatorStatus))
                    {
                        BUT_SysLog.InsertSysLog(VariedEnum.LogType.系统事件, frmAssist.frmLogin.SysUser.UserID,"成功删除了编号为" + VIPClientID + "的会员!");
                        InitializeControls();
                    }
                }
                catch
                {
                    XtraMessageBox.Show("请确定此条数据不正在被使用后重试", "删除失败",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        /// <summary>
        /// 打印(&P)
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-01
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                ClassAssist.DataOperator.DataPrint(this.gridControlMain, "会员信息",null);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 导出(&O)
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-01
        private void btnOut_Click(object sender, EventArgs e)
        {
            try
            {
                ClassAssist.DataOperator.DataOut(this.gridViewOne, "会员信息");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 返回(&B)
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-01
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region  查询

        /// <summary>
        /// 第一条件改变(combox的值改变时)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbField_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tempStringField = this.cmbField.Text.Trim();
            if(tempStringField=="会员编号")
            {
                ModeQueryInit("mruID");
                return;
            }
            if(tempStringField=="会员姓名")
            {
                ModeQueryInit("mruName");
                return;
            }
            if (tempStringField == "会员电话")
            {
                ModeQueryInit("mruPhone");
                return;
            }
            if (tempStringField == "会员卡类型")
            {
                ModeQueryInit("lupVIPType");
                return;
            }
            if (tempStringField == "当前职位")
            {
                ModeQueryInit("mruPosition");
                return;
            }
            if (tempStringField == "创建人")
            {
                ModeQueryInit("lupCreatePerson");
                return;
            }
            if (tempStringField == "创建时间")
            {
                ModeQueryInit("dateStart");
                return;
            }
        }
      
        #region ModeQueryInit(string paramType)显示/隐藏控件
        /// <summary>
        /// 隐藏/显示控件
        /// </summary>
        /// <param name="paramType"></param>
        private void ModeQueryInit(string paramType)
        {
            switch (paramType)
            {
                case "mruID": DateControlVisible(false);
                    LookUpEdit(false);
                    this.mruID.Visible = true;
                    break;
                case "mruName": DateControlVisible(false);
                    LookUpEdit(false);
                    this.mruName.Visible = true;
                    break;
                case "mruPhone": DateControlVisible(false);
                    LookUpEdit(false);
                    this.mruPhone.Visible = true;
                    break;
                case "lupVIPType": DateControlVisible(false);
                    LookUpEdit(false);
                    this.lupVIPType.Visible = true;
                    this.lupVIPType.ItemIndex = 0;
                    break;
                case "mruPosition": DateControlVisible(false);
                    LookUpEdit(false);
                    this.mruPosition.Visible = true;
                    break;
                case "lupCreatePerson": DateControlVisible(false);
                    LookUpEdit(false);
                    this.lupCreatePerson.Visible = true;
                    this.lupCreatePerson.ItemIndex = 0;
                    break;
                case "dateStart": DateControlVisible(true);
                    LookUpEdit(false);
                    this.dateStart.Visible = true;
                    break;
                default: DateControlVisible(false);
                    LookUpEdit(false);
                    //this.txtLogID.Visible = true;
                    break;
            }
        }
        #endregion

        #region DateControlVisible(bool paramDisplayOrNot)显示/隐藏时间控件
        /// <summary>
        /// 隐藏/显示时间控件
        /// </summary>
        /// <param name="paramDisplayOrNot"></param>
        private void DateControlVisible(bool paramDisplayOrNot)
        {
            this.dateStart.Visible = paramDisplayOrNot;
            this.lblFrom.Visible = paramDisplayOrNot;
            this.dateEnd.Visible = paramDisplayOrNot;
        }
        #endregion

        #region LookUpEdit(bool paramDisplayOrNot) 隐藏/显示其他LookUpEdit控件
        /// <summary>
        /// 隐藏/显示其他LookUpEdit控件
        /// </summary>
        /// <param name="paramDisplayOrNot"></param>
        private void LookUpEdit(bool paramDisplayOrNot)
        {
            this.mruID.Visible = paramDisplayOrNot;
            this.mruName.Visible = paramDisplayOrNot;
            this.mruPhone.Visible = paramDisplayOrNot;
            this.lupVIPType.Visible = paramDisplayOrNot;
            this.mruPosition.Visible = paramDisplayOrNot;
            this.lupCreatePerson.Visible = paramDisplayOrNot;
        }
        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string FieldName = this.cmbField.Text.Trim().ToString();
            if(FieldName=="创建时间")
            {
                DateSearch();
                return;
            }
            if(FieldName=="会员卡类型")
            {
                SearchVIPType();
                return;
            }
            string tempSecondContidion = SecondContidion(FieldName);
            try
            {
                DataTable myDataTable = new DataTable();
                myDataTable = myBUCMS_VIPClient.GetOrderVIPClient(false, tempSecondContidion, MruValue);
                this.gridControlMain.DataSource = myDataTable;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        #region DateSearch()时间查询
        /// <summary>
        /// 时间查询
        /// </summary>
        private void DateSearch()
        {
            DateTime TimeStart = Convert.ToDateTime(this.dateStart.EditValue);
            DateTime TimeEnd = Convert.ToDateTime(this.dateEnd.EditValue);
            DataTable myDataTable=new DataTable();
            try
            {
                myDataTable = myBUCMS_VIPClient.GetOrderVIPClientOnDate(false, "CreateDate",TimeStart,TimeEnd);
                this.gridControlMain.DataSource = myDataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region  private string SecondContidion() 获得第二查询条件字段
        /// <summary>
        /// 获得第二查询条件字段
        /// </summary>
        /// <returns></returns>
        private string SecondContidion(string paramSecondCondition)
        {
            string returnStringConditon = string.Empty;
            switch (paramSecondCondition)
            {
                case "编号": returnStringConditon ="ID";
                    MruValue = this.mruID.Text.ToString();
                    break;
                case "姓名": returnStringConditon ="Name";
                    MruValue = this.mruName.Text.ToString();
                    break;
                case "电话": returnStringConditon = "TelPhone";
                    MruValue = this.mruPhone.Text.ToString();
                    break;
                case "职位": returnStringConditon = "Position";
                    MruValue = this.mruPosition.Text.ToString();
                    break;
                case "创建人": returnStringConditon ="CreatePerson";
                    MruValue = this.lupCreatePerson.Text.ToString();
                    break;
                default: 
                    break;
            }
            return returnStringConditon;
        }
        #endregion

        #region private void SearchVIPType()按会员卡查询
        /// <summary>
        /// 按会员卡查询
        /// </summary>
        private void SearchVIPType()
        {
            string  VIPTypeID =this.lupVIPType.EditValue.ToString();
            try
            {
                DataTable myDataTable = new DataTable();
                myDataTable = myBUCMS_VIPClient.GetOrderVIPClient(false, "VIPTypeID", VIPTypeID);
                this.gridControlMain.DataSource = myDataTable;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void btnAll_Click(object sender, EventArgs e)
        {
            InitializeControls();
        }

        #endregion

        /// <summary>
        /// Handles the EditValueChanged event of the txtVIPCost control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-01
        private void txtVIPCost_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                double tempDiscount = Convert.ToDouble(this.txtVIPDiscount.EditValue);
                double tempVIPCost = Convert.ToDouble(this.txtVIPCost.EditValue);
                this.txtOverCash.EditValue = tempVIPCost / (tempDiscount * 0.1);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }
    }
}
