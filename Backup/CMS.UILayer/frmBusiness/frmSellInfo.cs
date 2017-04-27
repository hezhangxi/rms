 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CMS.BULayer;

namespace CMS.UILayer.frmBusiness
{
    /// <summary>
    /// 销售信息管理
    /// </summary>
    /// 整理人：桂书丛
    /// 整理时间：2013-02-04
    public partial class frmSellInfo : DevExpress.XtraEditors.XtraForm
    {
        #region 变量定义
        BUCMS_ConsumptionReg myBUCMS_ConsumptionReg = new BUCMS_ConsumptionReg();
        DataTable myDataTable = new DataTable();     //全部数据 (多次使用，请勿覆盖！)
        string FiledName = null;
        string FiledNameOnDish = null;
        #endregion 

        /// <summary>
        /// Initializes a new instance of the <see cref="frmSellInfo"/> class.
        /// </summary>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-04
        public frmSellInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the frmSellBill control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-04
        private void frmSellBill_Load(object sender, EventArgs e)
        {
            BindingGridControl();
            Bindinglup();
            HideControl();
            this.dateStart.Visible = true;
            this.lblFrom.Visible = true;
            this.dateEnd.Visible = true;
            this.MruIsVIP.SelectedIndex = 0;
            //HideControlDish();
            //BindInglupDish();
            //this.lupDishName.Visible = true;
        }

        #region private void Bindinglup()绑定数据到lup下拉框(按账单查询的)
        /// <summary>
        /// 绑定数据到lup下拉框（按账单查询的）
        /// </summary>
        private void Bindinglup()
        {
            DataTable LupDatatable = new DataTable();
            BUCMS_Buffets myBUCMS_Buffets=new BUCMS_Buffets();
            BUCMS_VIPType myBUCMS_VIPType=new BUCMS_VIPType();
            BUCMS_VIPClient myBUCMS_VIPClient=new BUCMS_VIPClient();
            BUCMS_Employee myBUCMS_Employee = new BUCMS_Employee();
            BUCMS_ItemDetail myBUCMS_ItemDetail =new BUCMS_ItemDetail();
            try
            {
                LupDatatable = myBUCMS_Buffets.GetOrder(false,string.Empty,string.Empty,false);
                this.lupTableName.Properties.DataSource = LupDatatable;
                this.lupTableName.ItemIndex = 0;
                LupDatatable = myBUCMS_VIPType.GetOrder(false,string.Empty,string.Empty,false);
                this.lupVIPType.Properties.DataSource = LupDatatable;
                this.lupVIPType.ItemIndex = 0;
                LupDatatable = myBUCMS_VIPClient.GetOrder(false,string.Empty,string.Empty,false);
                this.lupVIPClient.Properties.DataSource = LupDatatable;
                this.lupVIPClient.ItemIndex = 0;
                LupDatatable = myBUCMS_Employee.GetOrder(false,string.Empty,string.Empty,false);
                this.lupWaiter.Properties.DataSource = LupDatatable;
                this.lupWaiter.ItemIndex = 0;
                LupDatatable = myBUCMS_ItemDetail.GetItemByType(VariedItemType.PayType);
                this.lupPayment.Properties.DataSource = LupDatatable;
                this.lupPayment.ItemIndex = 0;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
        #endregion

        #region private void BindInglupDish() 绑定数据到lup下拉框(按菜品查询的)
         /// <summary>
         /// 绑定数据到lup下拉框(按菜品查询的)
         /// </summary>
        private void BindInglupDish()
        {
            DataTable tempDataTable = new DataTable();
            BUCMS_DishServer myBUCMS_DishServer = new BUCMS_DishServer();
            BUCMS_ItemDetail myBUCMS_ItemDetail = new BUCMS_ItemDetail();
            try
            {
                tempDataTable = myBUCMS_DishServer.GetOrder(false, string.Empty, string.Empty, false);
                this.lupDishName.Properties.DataSource = tempDataTable;
                this.lupDishName.ItemIndex = 0;

                tempDataTable = myBUCMS_ItemDetail.GetItemByType(VariedItemType.DishType);
                this.lupDishType.Properties.DataSource = tempDataTable;
                this.lupDishType.ItemIndex=0;

                tempDataTable = myBUCMS_ItemDetail.GetItemByType(VariedItemType.TasteType);
                this.lupTaste.Properties.DataSource = tempDataTable;
                this.lupTaste.ItemIndex = 0;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

        }
        #endregion

        #region private void BindingGridControl 绑定数据到GridControlMain(全部数据)
        /// <summary>
        /// 绑定数据到GridControlMain(全部数据)
        /// </summary>
        private void BindingGridControl ()
        {
            DataTable tempDataTable = new DataTable();
              try
               {
                   myDataTable = myBUCMS_ConsumptionReg.GetOrder(true,string.Empty,string.Empty,false);
                   tempDataTable = myDataTable.Clone();
                   int count = myDataTable.Rows.Count;
                   if(count > 0)
                   {
                       for (int i = 0; i < count-1; i++)
                   {
                       if (myDataTable.Rows[i]["账单编号"].ToString() != myDataTable.Rows[i + 1]["账单编号"].ToString())
                           tempDataTable.Rows.Add(myDataTable.Rows[i].ItemArray);
                   }
                   tempDataTable.Rows.Add(myDataTable.Rows[count-1].ItemArray);
                   for (int i = 0; i < tempDataTable.Rows.Count; i++)
                   {
                       if (tempDataTable.Rows[i]["Discount"].ToString().Length == 0)
                       {
                           tempDataTable.Rows[i]["Discount"] = "10";
                           tempDataTable.Rows[i]["会员姓名"] = "普通消费者";
                           tempDataTable.Rows[i]["Name"] = "无";
                       }
                   }
                   this.gridControlMain.DataSource = tempDataTable;
                   }
               }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        /// <summary>
        /// Handles the SelectionChanged event of the gridViewMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.Data.SelectionChangedEventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-04
        private void gridViewMain_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            //DataRow myDataRwo = this.gridViewMain.GetFocusedDataRow();//取出选中行的原始数据(在数据库中的)(数据库中的数据不一定全在控件中显示)
            //if (myDataRwo == null)
            //{
            //    this.gridControlDetailed.DataSource = null;
            //    return;
            //}
            //if(this.gridViewDish.getdat)
            DataRow myDataRwo = this.gridViewMain.GetFocusedDataRow();//原始数据
            string tempID = myDataRwo["账单编号"].ToString();
            DataTable tempDataTable = new DataTable();
            tempDataTable = myDataTable.Clone();
            int count = myDataTable.Rows.Count;
            for (int i = 0; i < count;i++ )
            {
                if(tempID==myDataTable.Rows[i]["账单编号"].ToString())
                {
                    tempDataTable.Rows.Add(myDataTable.Rows[i].ItemArray);
                }
            }
            this.gridControlDetailed.DataSource = tempDataTable;
        }

        #region  按账单查询
        //第一条件改变时
        private void cmbField_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CmFileName=this.cmbField.Text.Trim();
            switch(CmFileName)
            {
             case "账单编号" :
                   HideControl();
                   this.txtID.Visible=true;
                   this.txtID.Text = "";
                    FiledName="账单编号";
                   break;
               case "宾客人数":
                   HideControl();
                   this.txtID.Visible = true;
                   this.txtID.Text = "";
                   FiledName="宾客人数";
                   break;
               case "餐台名称":
                   HideControl();
                   this.lupTableName.Visible = true;
                  FiledName="餐台名称";
                   break;
               case "消费总额":
                   HideControl();
                   this.calCost.Visible = true;
                   FiledName="消费总额";
                   break;
               case "是否会员":
                   HideControl();
                   this.MruIsVIP.Visible = true;
                   FiledName="IsVIP";
                   break;
               case "会员姓名":
                   HideControl();
                   this.lupVIPClient.Visible = true;
                   FiledName = "会员姓名";
                   break;
               case "会员卡类型":
                   HideControl();
                   this.lupVIPType.Visible = true;
                   FiledName = "Name";
                   break;
               case "服务员":
                   HideControl();
                   this.lupWaiter.Visible = true;
                   FiledName = "服务员";
                   break;
               case "支付方式":
                   HideControl();
                   this.lupPayment.Visible = true;
                   FiledName = "支付方式";
                   break;
               case "消费日期":
                   HideControl();
                   this.dateStart.Visible = true;
                   this.lblFrom.Visible = true;
                   this.dateEnd.Visible = true;
                   break;
               default:
                   break;
            }
        }

        #region private void HideControl()隐藏控件
        /// <summary>
        /// 隐藏控件
        /// </summary>
        private void HideControl()
        {
            this.txtID.Visible = false;
            this.lupPayment.Visible = false;
            this.lupTableName.Visible = false;
            this.lupVIPClient.Visible = false;
            this.lupVIPType.Visible = false;
            this.lupWaiter.Visible = false;
            this.calCost.Visible = false;
            this.MruIsVIP.Visible = false;
            this.dateStart.Visible = false;
            this.lblFrom.Visible = false;
            this.dateEnd.Visible = false;
        }
        #endregion

        #region  private string GetMruValue(string paramCmFileName)获得第二条件
        /// <summary>
        /// 获得第二条件
        /// </summary>
        /// <param name="paramCmFileName"></param>
        /// <returns></returns>
        private string GetMruValue(string paramCmFileName)
        {
            switch (paramCmFileName)
            {
                case "账单编号":
                    return this.txtID.Text.Trim();
                case "宾客人数":
                    return this.txtID.Text.Trim();
                case "餐台名称":
                    return this.lupTableName.Text.Trim();
                case "消费总额":
                    //XtraMessageBox.Show(this.calCost.Text.Trim());
                    return this.calCost.Text.Trim();
                case "是否会员":
                    if (this.MruIsVIP.Text.Trim() == "是")
                        return "True";
                    else
                        return "False";
                case "会员姓名":
                    return this.lupVIPClient.Text.Trim();
                case "会员卡类型":
                    return this.lupVIPType.Text.Trim();
                case "服务员":
                   return this.lupWaiter.Text.Trim();
                case "支付方式":
                   return this.lupPayment.Text.Trim();
                default:
                    return null;
            }
        }
        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string CmFileName=this.cmbField.Text.Trim();
            if(CmFileName=="消费日期")
            {
                SearchDate();
                return;
            }
            string MarValue = GetMruValue(CmFileName);
            GetDataOnCondition(FiledName,MarValue);
            if (this.gridViewMain.SelectedRowsCount < 0)
                this.gridControlDetailed.DataSource = null;
        }

        #region private void SearchDate()按消费日期查询
        /// <summary>
        /// 按消费日期查询
        /// </summary>
        private void SearchDate()
        {
            DateTime DateStart = Convert.ToDateTime(this.dateStart.EditValue);
            DateTime DateEnd = Convert.ToDateTime(this.dateEnd.EditValue);
            DataTable myDT = new DataTable();
            DataTable tempDataTable = new DataTable();
            try
            {
                myDT = myBUCMS_ConsumptionReg.GetOrder(true,"消费时间" ,DateStart, DateEnd);
                tempDataTable = myDT.Clone();
                int count = myDT.Rows.Count;
                if (count > 0)
                {
                    for (int i = 0; i < count - 1; i++)
                    {
                        if (myDT.Rows[i]["账单编号"].ToString() != myDT.Rows[i + 1]["账单编号"].ToString())
                            tempDataTable.Rows.Add(myDT.Rows[i].ItemArray);
                    }
                    tempDataTable.Rows.Add(myDT.Rows[count - 1].ItemArray);
                    for (int i = 0; i < tempDataTable.Rows.Count; i++)
                    {
                        if (tempDataTable.Rows[i]["Discount"].ToString().Length == 0)
                        {
                            tempDataTable.Rows[i]["Discount"] = "10";
                            tempDataTable.Rows[i]["会员姓名"] = "普通消费者";
                            tempDataTable.Rows[i]["Name"] = "无";
                        }
                    }
                    this.gridControlMain.DataSource = tempDataTable;
                }
                else
                    this.gridControlMain.DataSource = null;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region  private void GetDataOnCondition(string paramFileName,string paramMarValue)根据条件获取数据
        /// <summary>
        /// 根据条件获取数据
        /// </summary>
        /// <param name="paramFileName"></param>
        /// <param name="paramMarValue"></param>
        /// <returns></returns>
        private void GetDataOnCondition(string paramFileName,string paramMarValue)
        {
            DataTable myDT = new DataTable();
            DataTable tempDataTable = new DataTable();
            try
            {
                myDT = myBUCMS_ConsumptionReg.GetOrder(true, paramFileName, paramMarValue, false);
                tempDataTable = myDT.Clone();
                int count = myDT.Rows.Count;
                if (count > 0)
                {
                    for (int i = 0; i < count - 1; i++)
                    {
                        if (myDT.Rows[i]["账单编号"].ToString() != myDT.Rows[i + 1]["账单编号"].ToString())
                            tempDataTable.Rows.Add(myDT.Rows[i].ItemArray);
                    }
                    tempDataTable.Rows.Add(myDT.Rows[count - 1].ItemArray);
                    for (int i = 0; i < tempDataTable.Rows.Count; i++)
                    {
                        if (tempDataTable.Rows[i]["Discount"].ToString().Length == 0)
                        {
                            tempDataTable.Rows[i]["Discount"] = "10";
                            tempDataTable.Rows[i]["会员姓名"] = "普通消费者";
                            tempDataTable.Rows[i]["Name"] = "无";
                        }
                    }
                    this.gridControlMain.DataSource = tempDataTable;
                }
                else 
                    this.gridControlMain.DataSource=null;
            }
                
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        /// <summary>
        /// Handles the Click event of the btnAll control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-04
        private void btnAll_Click(object sender, EventArgs e)
        {
            BindingGridControl();
        }

        /// <summary>
        /// Handles the Click event of the BtnDel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-04
        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (this.gridViewMain.SelectedRowsCount <= 0)
            {
                XtraMessageBox.Show("请选择要删除的项!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string DishID = this.gridViewMain.GetFocusedRowCellValue("账单编号").ToString();
            System.Windows.Forms.DialogResult myDialogResult = XtraMessageBox.Show("编号为" + DishID + "销售账单","确定删除？", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == myDialogResult)
            {
                VariedEnum.OperatorStatus EnOperatorStatus;
                try
                {
                    EnOperatorStatus = myBUCMS_ConsumptionReg.Delete(DishID);
                    if (ClassAssist.CommonOperator.HandleOperatorEnum("删除", EnOperatorStatus))
                    {
                        BUT_SysLog.InsertSysLog(VariedEnum.LogType.系统事件, frmAssist.frmLogin.SysUser.UserID,"成功删除了编号为" + DishID + "销售账单!");
                        BindingGridControl();
                    }
                }
                catch
                {
                    XtraMessageBox.Show("请确定此条数据不正在被使用后重试", "删除失败",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the btnClear control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-04
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (this.gridViewMain.SelectedRowsCount <= 0)
            {
                XtraMessageBox.Show("没有任何数据!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult myDialogResult = XtraMessageBox.Show("确定清空所有销售账单?","注意", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == myDialogResult)
            {
                VariedEnum.OperatorStatus EnOperatorStatus;
                try
                {
                    EnOperatorStatus = myBUCMS_ConsumptionReg.Delete();
                    if (ClassAssist.CommonOperator.HandleOperatorEnum("清空", EnOperatorStatus))
                    {
                        BUT_SysLog.InsertSysLog(VariedEnum.LogType.系统事件, frmAssist.frmLogin.SysUser.UserID,"成功清空了销售账单!");
                        //BindingGridControl();
                    }
                    this.gridControlMain.DataSource = null;
                }
                catch
                {
                    XtraMessageBox.Show("请确定数据不正在被使用后重试", "清空失败!",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the btnPrint control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-04
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                ClassAssist.DataOperator.DataPrint(this.gridControlMain, "账单信息", null);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the btnOut control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-04
        private void btnOut_Click(object sender, EventArgs e)
        {
            try
            {
                ClassAssist.DataOperator.DataOut(this.gridViewMain, "账单信息");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the btnBack control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-04
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion  按账单查询

        #region 按菜品查询

        #region private void HideControlDish()隐藏按菜品查询的控件
        /// <summary>
        /// 隐藏按菜品查询的控件
        /// </summary>
        private void HideControlDish()
        {
            this.lupDishName.Visible = false;
            this.lupDishType.Visible = false;
            this.lupTaste.Visible = false;
            this.mruIsGive.Visible = false;
            this.txtPriceCommission.Visible = false;
            this.calCostDish.Visible = false;

        }
        #endregion
        //第一条件改变时
        private void cmbFileNameDish_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FileNameDish = this.cmbFileNameDish.Text.Trim();
            switch (FileNameDish)
            {
                case "菜品名称":
                    HideControlDish();
                    this.lupDishName.Visible = true;
                    FiledNameOnDish = "菜品名称";
                    break;
                case "菜品类别":
                    HideControlDish();
                    this.lupDishType.Visible = true;
                    FiledNameOnDish = "菜品类别";
                    break;
                case "口味":
                    HideControlDish();
                    this.lupTaste.Visible = true;
                    FiledNameOnDish = "口味";
                    break;
                case "是否赠菜":
                    HideControlDish();
                    this.mruIsGive.Visible = true;
                    FiledNameOnDish = "消费总额";
                    break;
                case "单价":
                    HideControlDish();
                    this.txtPriceCommission.Visible = true;
                    FiledNameOnDish = "单价";
                    break;
    
                case "菜品提成":
                    HideControlDish();
                    this.txtPriceCommission.Visible = true;
                    FiledNameOnDish = "菜品提成";
                    break;
                case "销售金额":
                    HideControlDish();
                    this.calCostDish.Visible = true;
                    FiledNameOnDish = "消费销售金额";
                    break;
                default:
                    break;
            }
        }

        #region private string GetSecontLupValue(string paramCmFileNameDish)获取第二条件
        /// <summary>
        /// 获取第二条件
        /// </summary>
        /// <param name="paramCmFileNameDish"></param>
        /// <returns></returns>
        private string GetSecontLupValue(string paramCmFileNameDish)
        {
            switch (paramCmFileNameDish)
            {
                case "菜品名称":
                    return this.lupDishName.Text.Trim();
                case "菜品类别":
                    return this.lupDishType.Text.Trim();
                case "口味":
                   return this.lupTaste.Text.Trim();
                case "是否赠菜":
                   if (this.mruIsGive.Text.Trim() == "是")
                       return "True";
                   else
                       return "False";
                case "单价":
                   if (this.txtPriceCommission.Text.Length == 0)
                       return "0";
                   return this.txtPriceCommission.Text.Trim();
                case "菜品提成":
                   if (this.txtPriceCommission.Text.Length == 0)
                       return "0";
                   return this.txtPriceCommission.Text.Trim();
                case "销售金额":
                   if (this.calCostDish.Text.Length == 0)
                       return "0";
                   return this.calCostDish.Text.Trim();
                default:
                    return null;
            }
        }
        #endregion

        private void btnSearchDish_Click(object sender, EventArgs e)
        {
            string CmFileNameDish=this.cmbFileNameDish.Text;
            string LupValue=GetSecontLupValue(CmFileNameDish);
            GetDataOnCondition(CmFileNameDish,LupValue);
        }

        #region  private void GetDataOnDish(string paramDishFileName,string paramDishLupValue) 根据菜品条件查询数据
        /// <summary>
        /// 根据菜品条件查询数据
        /// </summary>
        /// <param name="paramDishFileName"></param>
        /// <param name="paramDishLupValue"></param>
        private void GetDataOnDish(string paramDishFileName,string paramDishLupValue)
        {
             DataTable DishDataTable = new DataTable();
             DataTable tempDataTable = new DataTable();
            try
            {
                DishDataTable = myBUCMS_ConsumptionReg.GetOrder(false, paramDishFileName, paramDishLupValue,false);
                tempDataTable = DishDataTable.Clone();
                int count = DishDataTable.Rows.Count;
                if (count > 0)
                {
                    for (int i = 0; i < count - 1; i++)
                    {
                        if (DishDataTable.Rows[i]["账单编号"].ToString() != DishDataTable.Rows[i + 1]["账单编号"].ToString())
                            tempDataTable.Rows.Add(myDataTable.Rows[i].ItemArray);
                    }
                    tempDataTable.Rows.Add(DishDataTable.Rows[count - 1].ItemArray);
                    for (int i = 0; i < tempDataTable.Rows.Count; i++)
                    {
                        if (tempDataTable.Rows[i]["Discount"].ToString().Length == 0)
                        {
                            tempDataTable.Rows[i]["Discount"] = "10";
                            tempDataTable.Rows[i]["会员姓名"] = "普通消费者";
                            tempDataTable.Rows[i]["Name"] = "无";
                        }
                    }
                    this.gridControlMain.DataSource = tempDataTable;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            BindingGridControl();
        }

        #endregion 按菜品查询

        /// <summary>
        /// Handles the SelectedPageChanged event of the xtraTabControl1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraTab.TabPageChangedEventArgs"/> instance containing the event data.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-06
        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (this.xtraTabControl1.SelectedTabPageIndex == 1)
            {
                BindInglupDish();
                HideControlDish();
                this.lupDishName.Visible = true;
            }
        }
    }
}