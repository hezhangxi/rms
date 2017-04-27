
//******************************************************************************************************
//** Copyright (C) 2010-2013 重大网络教育学院
//** 创建人：桂书丛
//** 类名称\文件名：frmDinegRegister
//** 类功能：点菜窗体
//** 描 述：餐饮管理系统主窗体 点菜窗体
//** 创建日期：2013-1-27
//** 修改(&U)人：桂书丛
//** 修改(&U)日期：2013-2-3
//** 整理日期：2013-2-3
//******************************************************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using CMS.BULayer;
using CMS.Model;
using System.Threading;
using DevExpress.XtraGrid.Views.Grid;
namespace CMS.UILayer.frmBCarryOut
{
    /// <summary>
    /// 菜品消费窗体
    /// </summary>
    /// 创建人：桂书丛
    /// 创建日期：2013-02-23
    public partial class frmDineRegister : DevExpress.XtraEditors.XtraForm
    {
        #region 变量定义
        private ModelCMS_ConsumptionReg myModelCMS_ConsumptionReg = new ModelCMS_ConsumptionReg();      //消费注册信息实体
        private ModelCMS_Buffets myModelCMS_Buffets = new ModelCMS_Buffets();                           //餐台信息实体
        private BUCMS_DishServer myBUDishServer = new BUCMS_DishServer();                               //菜品信息操作实例
        private DataTable ChoosedDataTable = new DataTable();                                           //添加(&A)的物品信息虚拟表
        private ListViewItem BuffetControl;                                                             //餐台信息控件
        private BUCMS_ConsumptionDish myBUConsumnptionDish = new BUCMS_ConsumptionDish();               //消费菜品操作实体
        private string MarkID = string.Empty;                                                           //账单编号
        private string ChoosedID = string.Empty;                                                           //所选商品ID
        private int ChoosedNum = -5;                                                                       //所选商品的数量
        private bool IsOver = false;                                                                    //是否结束点菜
        private bool IsRetreatDishes = false;                                                           //是否有退菜
        #endregion

        #region 构造函数
        /// <summary>
        /// Initializes a new instance of the <see cref="frmDineRegister"/> class.
        /// </summary>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-23
        public frmDineRegister()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 重载构造函数
        /// </summary>
        /// <param name="paramConsumptionReg">The param consumption reg.</param>
        /// <param name="paramBuffetControl">The param buffet control.</param>
        public frmDineRegister(ListViewItem paramBuffetControl,ModelCMS_ConsumptionReg paramConsumptionReg)
        {
            InitializeComponent();
            this.lblID.Text = paramConsumptionReg.BuffetsID.ToString();
            this.myModelCMS_ConsumptionReg = paramConsumptionReg;
            this.BuffetControl = paramBuffetControl;
            this.MarkID = paramConsumptionReg.MarkID;
            this.btnSubmint.Enabled = false;
            InitializeControls();
        }

        /// <summary>
        /// 重载构造函数
        /// </summary>
        /// <param name="paramBuffetControl">The param buffet control.</param>
        public frmDineRegister(ListViewItem paramBuffetControl)
        {
            InitializeComponent();
            this.myModelCMS_Buffets = ClassAssist.BuffetOperator.GetBuffetModel(paramBuffetControl);
            this.lblID.Text = myModelCMS_Buffets.ID.ToString();
            this.Text = "增加消费";
            this.MarkID = myModelCMS_Buffets.MarkID;
            this.BuffetControl = paramBuffetControl;
            InitializeControls();
            LoadBillInfo();
        }
        #endregion

        #region private DataTable GetInitedData() 获得一个初始化的数据集
        /// <summary>
        /// 获得一个初始化的数据集
        /// </summary>
        /// <returns></returns>
        private DataTable GetInitedData()
        {
            DataTable ListDataTable = new DataTable("ListTable");
            ListDataTable.BeginInit();
            AddColumn(ListDataTable, "ID", typeof(int),true);
            AddColumn(ListDataTable, "Name", typeof(string),false);
            AddColumn(ListDataTable, "TasteID", typeof(int),false);
            AddColumn(ListDataTable, "Num", typeof(int),false);
            AddColumn(ListDataTable, "Price", typeof(decimal),false);
            AddColumn(ListDataTable, "Total", typeof(decimal),false);
            AddColumn(ListDataTable, "IsPresent",typeof(bool),false);
            ListDataTable.EndInit();

            return ListDataTable;
        }
        #endregion

        #region private void AddColumn(DataTable paramDataTable, string paramColumnName, System.Type paramType,bool IsUnique) 为虚拟表添加(&A)列
        /// <summary>
        /// 为虚拟表添加(&A)列 
        /// </summary>
        /// <param name="paramDataTable">要添加(&A)列的虚拟表</param>
        /// <param name="paramColumnName">列名称</param>
        /// <param name="paramType">列的数据类型</param>
        /// <param name="IsUnique">是否是主键</param>
        private void AddColumn(DataTable paramDataTable, string paramColumnName, System.Type paramType,bool IsUnique)
        {
            DataColumn tempDataColumn;
            tempDataColumn = new DataColumn(paramColumnName, paramType);
            tempDataColumn.Caption = paramColumnName;
            tempDataColumn.AllowDBNull = !IsUnique;
            tempDataColumn.Unique=IsUnique;
            paramDataTable.Columns.Add(tempDataColumn);
            if (IsUnique == true)
            {
                DataColumn[] tempPrimaryKey = new DataColumn[1];
                tempPrimaryKey[0] = tempDataColumn;
                paramDataTable.PrimaryKey = tempPrimaryKey;
            }
        }
        #endregion

        #region private void InitializeControls(string paramBuffetsID) 初始化控件
        /// <summary>
        /// 初始化控件
        /// </summary>
        private void InitializeControls()
        {
            try
            {
                ChoosedDataTable = GetInitedData();
                DisplayBuffetInfo();
                BindingControls();
                DataTable tempDataTable = myBUDishServer.GetOrder(true,string.Empty,string.Empty,false);
                this.gridControlDish.DataSource = tempDataTable;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,"Inited");
            }
        }
        #endregion

        #region private void LoadBillInfo() 加载上次的消费信息
        /// <summary>
        /// 加载上次的消费信息
        /// </summary>
        private void LoadBillInfo()
        {
            try
            {
                DataTable targetDataTable = myBUConsumnptionDish.GetOrder(true,"MarkID",this.MarkID,false);
                LoadAllBill(targetDataTable);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        
        /// <summary>
        /// 加载所有的菜品信息
        /// </summary>
        /// <param name="paramDataTable">The param data table.</param>
        /// <returns></returns>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-25
        private bool LoadAllBill(DataTable paramDataTable)
        {
            if (paramDataTable.Rows.Count <= 0)
                return false;
            foreach (DataRow tempDataRow in paramDataTable.Rows)
            {
                object[] tempRowContent = new object[7];
                if (tempDataRow["菜品编号"].ToString() == string.Empty)
                    return false;
                tempRowContent[0] = tempDataRow["菜品编号"];                                        //ID
                tempRowContent[1] = tempDataRow["菜品名称"];                                        //Name
                tempRowContent[2] = tempDataRow["口味编号"];                                        //TasteID
                tempRowContent[3] = tempDataRow["数量"];                                            //Num
                tempRowContent[4] = tempDataRow["单价"];                                            //Price
                tempRowContent[5] = tempDataRow["销售金额"];                                        //Total
                tempRowContent[6] = tempDataRow["是否赠菜"];                                        //IsPresent
                ChoosedDataTable.Rows.Add(tempRowContent);
            }
            this.gridControlList.DataSource = ChoosedDataTable;
            return true;
        }
        #endregion

        #region private void BindingControls() 数据绑定控件
        /// <summary>
        /// 数据绑定控件
        /// </summary>
        private void BindingControls()
        {
            BUCMS_ItemDetail tempBUCMSItemDetail=new BUCMS_ItemDetail();
            try
            {
                DataTable tempDataTable = tempBUCMSItemDetail.GetItemByType(VariedItemType.DishType);
                ClassAssist.CommonOperator.DataBindingLookUpEdit(lupType,tempDataTable,"Name","ID",true);
                tempDataTable = tempBUCMSItemDetail.GetItemByType(VariedItemType.TasteType);
                rilupTaste.DataSource = tempDataTable;
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region private void DisplayBuffetInfo() 显示餐台信息
        /// <summary>
        /// 显示餐台信息
        /// </summary>
        private void DisplayBuffetInfo()
        {
            Control[] tempShowControl = new Control[5];
            tempShowControl[0] = this.lblID;
            tempShowControl[1] = this.lblName;
            tempShowControl[2] = this.lblStatus;
            tempShowControl[3] = this.lblStatus;
            tempShowControl[4] = this.lblInfoNote;
            ClassAssist.BuffetOperator.ShowBuffetInfo(myModelCMS_Buffets, tempShowControl);
        }
        #endregion

        #region private void chkGroup_CheckedChanged(object sender, EventArgs e) 分组复选框点击状态改变
        /// <summary>
        /// 分组复选框点击状态改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkGroup_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGroup.Checked == true)
            {
                gridViewMain.Columns[2].GroupIndex = gridViewMain.SortInfo.GroupCount;
                chkExpand.Visible = true;
            }
            else
            {
                gridViewMain.Columns[2].GroupIndex = -1;
                chkExpand.Visible = false;
            }
        }
        #endregion

        #region private void FillChoosedInfo() 添加(&A)选取的商品信息到显示界面
        /// <summary>
        /// 添加(&A)选取的商品信息到显示界面
        /// </summary>
        private void FillChoosedInfo()
        {
            try
            {
                DataRow targetDataRow = this.gridViewMain.GetFocusedDataRow();                                                  //得到选定的商品信息数据
                if (ReduceOriginalInfo() == false)
                    return;
                DataRow tempDataRow = ChoosedDataTable.Rows.Find(targetDataRow["编号"]);                //在已选的数据中查找指定的数据
                if (tempDataRow != null)                                                                //如果所选的消费项目中已包含待插入的项
                {
                    tempDataRow["Num"] = Convert.ToInt32(tempDataRow["Num"]) + this.speNum.Value;
                    if (Convert.ToBoolean(tempDataRow["IsPresent"]) == true)                            //如果此菜为赠菜
                        tempDataRow["Total"] = 0;
                    else
                        tempDataRow["Total"] = Convert.ToDecimal(tempDataRow["Price"]) * Convert.ToInt32(tempDataRow["Num"]);
                    this.gridControlList.DataSource = ChoosedDataTable;
                    return;
                }
                else
                    AddOneRecordToChoosedDataTable(targetDataRow);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
       
        /// <summary>
        /// 减少原商品的库存量
        /// </summary>
        /// <returns></returns>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-25
        private bool ReduceOriginalInfo()
        {
            decimal tempSurplusNum = Convert.ToInt32(gridViewMain.GetFocusedRowCellValue(this.AvNum)) - this.speNum.Value;  //得到更新后的库存
            this.gridViewMain.SetFocusedRowCellValue(this.AvNum, tempSurplusNum);
            string tempStockGoodsID = gridViewMain.GetFocusedDataRow()["关联商品编号"].ToString();
            DataTable tempDataTable = this.gridControlDish.DataSource as DataTable;
            if (tempDataTable == null)
                return false;
            foreach (DataRow tempDataRow in tempDataTable.Rows)
            {
                if (tempStockGoodsID == tempDataRow["关联商品编号"].ToString())
                    tempDataRow["当前库存"] = tempSurplusNum;
            }
            this.gridControlDish.Refresh();
            return true;
        }

        #region private void AddOneRecordToChoosedDataTable(DataRow paramDataRow) 向虚拟表中增加一条记录
        /// <summary>
        /// 向虚拟表中增加一条记录
        /// </summary>
        /// <param name="paramDataRow">The param data row.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-2-25
        private void AddOneRecordToChoosedDataTable(DataRow paramDataRow)
        {
            object[] tempRowContent = new object[7];
            tempRowContent[0] = paramDataRow["编号"];                                               //虚拟表中的ID列
            tempRowContent[1] = paramDataRow["名称"];                                               //虚拟表中的Name列
            tempRowContent[2] = VariedDefault.DefaultTasteID;                                       //虚拟表中的TasteID列
            tempRowContent[3] = this.speNum.Value;                                                  //虚拟表中的Num列
            tempRowContent[4] = paramDataRow["单价"];                                               //虚拟表中的Price列
            tempRowContent[5] = Convert.ToDecimal(paramDataRow["单价"]) * this.speNum.Value;        //虚拟表中的Total列
            tempRowContent[6] = false;                                                              //虚拟表中的IsPresent列
            ChoosedDataTable.Rows.Add(tempRowContent);
            this.gridControlList.DataSource = ChoosedDataTable;
        }
        #endregion

        #endregion

        #region private bool AddconsumnptionDish(ModelCMS_ConsumnptionDish paramConsumnptionDish) 添加(&A)消费记录
        /// <summary>
        /// 添加(&A)消费记录
        /// </summary>
        /// <param name="paramConsumnptionDish"></param>
        /// <returns></returns>
        private bool AddconsumnptionDish(ModelCMS_ConsumptionDish paramConsumnptionDish)
        {
            if (paramConsumnptionDish == null)
                return false;
            VariedEnum.OperatorStatus tempOperatorStatus;
            try
            {
                tempOperatorStatus = myBUConsumnptionDish.Insert(paramConsumnptionDish);
                if (tempOperatorStatus == VariedEnum.OperatorStatus.Successed)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            return true;
        }
        #endregion

        #region private ModelCMS_ConsumnptionDish GetConsumnptionDishModel(DataRow paramDataRow) 根据数据集获得消费记录实例
        /// <summary>
        /// 根据数据集获得消费记录实例
        /// </summary>
        /// <param name="paramDataRow"></param>
        /// <returns></returns>
        private ModelCMS_ConsumptionDish GetConsumnptionDishModel(DataRow paramDataRow)
        {
            ModelCMS_ConsumptionDish tempConsumnptionDish = new ModelCMS_ConsumptionDish();
            try
            {
                tempConsumnptionDish.MarkID = this.MarkID;
                tempConsumnptionDish.DiskID=Convert.ToInt32(paramDataRow["ID"]);
                tempConsumnptionDish.DiskNum = Convert.ToInt32(paramDataRow["Num"]);
                tempConsumnptionDish.IsPresent = Convert.ToBoolean(paramDataRow["IsPresent"]);
                tempConsumnptionDish.TasteID = Convert.ToInt32(paramDataRow["TasteID"]);
                tempConsumnptionDish.Description = "暂无";
                tempConsumnptionDish.CreateDate = DateTime.Now;
                tempConsumnptionDish.CreatePerson = frmAssist.frmLogin.SysUser.UserName;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                return null;
            }
            return tempConsumnptionDish;
        }
        #endregion

        #region private void UpdateChoosedInfo(int paramRowID) 更新选取的商品信息
        /// <summary>
        /// 更新选取的商品信息
        /// </summary>
        private void UpdateChoosedInfo(DataRow paramDataRow)
        {
            try
            {
                DataRow tempDataRow = ChoosedDataTable.Rows.Find(paramDataRow["ID"]);
                if (tempDataRow == null)
                    return;
                tempDataRow["TasteID"] = paramDataRow["TasteID"];
                tempDataRow["Num"] = paramDataRow["Num"];
                tempDataRow["IsPresent"] = paramDataRow["IsPresent"];
                if (Convert.ToBoolean(tempDataRow["IsPresent"]) == true)
                    tempDataRow["Total"] = 0;
                else
                    tempDataRow["Total"] = Convert.ToDecimal(tempDataRow["Price"]) * Convert.ToInt32(paramDataRow["Num"]);
                this.gridControlList.Refresh();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region private void MoveChoosedInfo() 从显示界面减少选取的商品信息
        /// <summary>
        /// 从显示界面减少选取的商品信息
        /// </summary>
        private void MoveChoosedInfo()
        {
            try
            {
                DataRow targetDataRow = this.gridViewListMain.GetFocusedDataRow();              //目标数据行，消费列表中获得焦点的行
                DataRow delDataRow=this.ChoosedDataTable.Rows.Find(targetDataRow["ID"]);        //在添加(&A)的物品信息虚拟表中查找并获得指定的数据行
                if (UpdateOriginalInfo(delDataRow["ID"].ToString(), 1,false) == false)
                    return;
                if (Convert.ToInt32(targetDataRow["Num"]) > 1)                                  //如果此项消费数量大于1
                {   
                    targetDataRow["Num"] = Convert.ToInt32(targetDataRow["Num"]) - 1;
                    if (Convert.ToBoolean(targetDataRow["IsPresent"]) == true)
                        targetDataRow["Total"] = 0;
                    else
                        targetDataRow["Total"] = Convert.ToDecimal(targetDataRow["Price"]) * Convert.ToInt32(targetDataRow["Num"]);
                }
                else
                {
                    if (delDataRow != null)                                                         //如果所选消费项目含有目标项目
                        ChoosedDataTable.Rows.Remove(delDataRow);
                }
                this.gridControlList.Refresh();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region private bool UpdateOriginalInfo(string paramID,int paramBackNum,bool IsUpdate) 更新原商品信息
        /// <summary>
        /// 更新原商品信息
        /// </summary>
        /// <param name="paramID">商品ID</param>
        /// <param name="paramBackNum">返回(&B)的数量</param>
        /// <param name="IsUpdate">是否更新到数据库</param>
        /// <returns></returns>
        /// 创建人：桂书丛
        /// 创建日期：2013-2-25
        private bool UpdateOriginalInfo(string paramID,int paramBackNum,bool IsUpdate)
        {
            try
            {
                if (paramID == string.Empty)
                    return false;
                DataTable tempDataTable = this.gridControlDish.DataSource as DataTable;
                if (tempDataTable == null)
                    return false;
                foreach (DataRow tempDataRowFirst in tempDataTable.Rows)
                {
                    if (tempDataRowFirst["编号"].ToString() == paramID)
                    {
                        string tempStockGoodsID = tempDataRowFirst["关联商品编号"].ToString();
                        foreach (DataRow tempDataRowTwo in tempDataTable.Rows)
                        {
                            if (tempStockGoodsID == tempDataRowTwo["关联商品编号"].ToString())
                                tempDataRowTwo["当前库存"] = Convert.ToInt32(tempDataRowTwo["当前库存"]) + paramBackNum;
                        }
                        if (IsUpdate == true)
                            new BUCMS_Stock().UpdateStock(tempStockGoodsID, "Number", tempDataRowFirst["当前库存"].ToString());
                    }
                }
                this.gridControlDish.RefreshDataSource();                                       //刷新数据源
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region 按钮事件

        /// <summary>
        /// Handles the Click event of the btnAdd control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-2-25
        private void btnAdd_Click(object sender, EventArgs e)
        {
            gridControlDish_DoubleClick(sender, e);
            this.speNum.Value = 1;
        }

        /// <summary>
        /// 结束点菜
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-23
        private void btnOver_Click(object sender, EventArgs e)
        {
            //if (this.ChoosedDataTable.Rows.Count <= 0)
            //    return;
            int tempResult = 0;
            try
            {
                if (myBUConsumnptionDish.Delete(this.MarkID) != VariedEnum.OperatorStatus.Successed)
                    return;
                foreach (DataRow tempDataRow in this.ChoosedDataTable.Rows)
                {
                    ModelCMS_ConsumptionDish tempConsumnptionDish = GetConsumnptionDishModel(tempDataRow);
                    if (AddconsumnptionDish(tempConsumnptionDish))
                    {
                        if (UpdateOriginalInfo(tempDataRow["ID"].ToString(), 0,true) == true)         //更新商品库存信息
                            tempResult++;
                    }
                }
                if (tempResult == ChoosedDataTable.Rows.Count)
                {
                    this.IsOver = true;
                    if (chkPrint.Checked == true)
                        ClassAssist.DataOperator.DataPrint(gridControlList, "菜品信息", this);
                    if (this.Owner != null)
                            ((Form)Owner).Close();
                }
                else
                    XtraMessageBox.Show("下面的操作可能会出错，请谨慎", "发生未知错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        #region private void btnBack_Click(object sender, EventArgs e)  Handles the Click event of the btnBack control.
        /// <summary>
        /// 退菜
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-2-25
        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                object tempID = this.gridViewListMain.GetFocusedRowCellValue(this.ListID);
                if (tempID == null)
                {
                    XtraMessageBox.Show("请先选择要退的消费项目", "退菜失败");
                    return;
                }
                DataRow delDataRow = this.ChoosedDataTable.Rows.Find(tempID);
                if (delDataRow != null)                         //如果所选消费项目含有目标项目
                {
                    if (Convert.ToInt32(delDataRow["Num"]) >= 1)
                    {
                        frmBackResult myfrmBackResult = new frmBackResult(delDataRow);
                        if (myfrmBackResult.ShowDialog() == DialogResult.OK)
                        {
                            int tempQuitNum = frmBackResult.QuitNum;
                            if (UpdateOriginalInfo(delDataRow["ID"].ToString(), tempQuitNum,true) == true)
                            {
                                int tempLastNum = Convert.ToInt32(delDataRow["Num"]) - tempQuitNum;
                                if (tempLastNum >= 1)
                                {
                                    delDataRow["Num"] = tempLastNum;
                                    delDataRow["Total"] = Convert.ToDecimal(delDataRow["Price"]) * tempLastNum;
                                }
                                else
                                    ChoosedDataTable.Rows.Remove(delDataRow);
                                this.IsRetreatDishes = true;
                            }
                        }
                    }
                    this.gridControlList.Refresh();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        #endregion

        /// <summary>
        /// 赠菜按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGive_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow targetDataRow = this.gridViewListMain.GetFocusedDataRow();
                if (targetDataRow == null)
                {
                    XtraMessageBox.Show("请先选择要赠送的菜", "赠菜菜失败");
                    return;
                }
                DataRow delDataRow = this.ChoosedDataTable.Rows.Find(targetDataRow["ID"]);
                delDataRow["IsPresent"] = true;
                if (Convert.ToBoolean(delDataRow["IsPresent"]) == true)
                    delDataRow["Total"] = 0;
                this.gridControlList.DataSource = ChoosedDataTable;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,"赠菜");
            }
        }

        /// <summary>
        /// 结账
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-23
        private void btnSubmint_Click(object sender, EventArgs e)
        {
            try
            {
                frmBCarryOut.frmCheckOut myfrmCheckOut = new CMS.UILayer.frmBCarryOut.frmCheckOut(BuffetControl);
                myfrmCheckOut.Show();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 催菜
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-25
        private void btnHurry_Click(object sender, EventArgs e)
        {
            frmOther.frmProcess myfrmProcess = new CMS.UILayer.frmOther.frmProcess();
            //string tempName = this.gridViewListMain.GetFocusedDisplayText(this.ListName);
            //if (tempName == string.Empty)
            //{
            //    myfrmProcess.TitleText = "正在催菜";
            //}
            myfrmProcess.TitleText = "正在催菜";
            if (myfrmProcess.ShowDialog() == DialogResult.OK)
                XtraMessageBox.Show("催菜成功，请稍等……", "恭喜！");
        }
        #endregion

        #region 其他事件

        /// <summary>
        /// Handles the DoubleClick event of the gridControlDish control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-2-25
        private void gridControlDish_DoubleClick(object sender, EventArgs e)
        {
            if (this.txtName.Text.Length <= 0)
                return;
            if (this.gridViewMain.DataRowCount <= 0)
                return;
            int tempAvNum = Convert.ToInt32(this.gridViewMain.GetFocusedRowCellDisplayText(this.AvNum));
            decimal tempCurrentNum = this.speNum.Value;
            if (tempAvNum == 0)
            {
                XtraMessageBox.Show("库存量不足,请通知尽快进货", "无法消费", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (tempAvNum <= tempCurrentNum)
            {
                if (XtraMessageBox.Show("库存量将不足", "是否消费此项？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
            }
            FillChoosedInfo();
        }

        /// <summary>
        /// Handles the EditValueChanged event of the lupType control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-2-25
        private void lupType_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                string tempType = this.lupType.Text.Trim();
                if (tempType.Length == 0)
                    return;
                DataTable tempDataTable = new BUCMS_DishServer().GetOrder(true, "[类别]", tempType, false);
                this.gridControlDish.DataSource = tempDataTable;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handles the TextChanged event of the mruID control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-2-25
        private void mruID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string tempCondition = this.mruIDOrSymbol.Text.Trim();
                if (tempCondition.Length == 0)
                    return;
                DataTable tempDataTable = new BUCMS_DishServer().GetOrder(tempCondition);
                this.gridControlDish.DataSource = tempDataTable;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "ODOrSymbol");
            }
        }

        /// <summary>
        /// Handles the SelectionChanged event of the gridViewMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.Data.SelectionChangedEventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-2-25
        private void gridViewMain_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            string strDishName = this.gridViewMain.GetFocusedRowCellDisplayText(this.DishName);
            this.txtName.Text = strDishName;
        }

        /// <summary>
        /// Handles the MouseDown event of the gridViewListMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-27
        private void gridViewListMain_MouseDown(object sender, MouseEventArgs e)
        {
            string tempID = this.gridViewListMain.GetFocusedRowCellDisplayText(this.ListID);
            if (tempID != string.Empty)
            {
                this.ChoosedID = tempID;
                int tempNum = Convert.ToInt32(this.gridViewListMain.GetFocusedRowCellDisplayText(this.Num));
                this.ChoosedNum = tempNum;
            }
        }

        /// <summary>
        /// Handles the CellValueChanged event of the gridViewListMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-2-25
        private void gridViewListMain_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            DataRow tempDataRow = gridViewListMain.GetFocusedDataRow();
            UpdateChoosedInfo(tempDataRow);
            if (this.ChoosedID != this.gridViewListMain.GetFocusedRowCellDisplayText(this.ListID))
                return;
            if (e.Column == this.Num)
            {
                int tempBackNum=this.ChoosedNum-Convert.ToInt32(e.Value);
                UpdateOriginalInfo(this.ChoosedID, tempBackNum, false);
            }
        }

        /// <summary>
        /// Handles the FormClosing event of the frmDineRegister control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.FormClosingEventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-2-25
        private void frmDineRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.IsRetreatDishes == true)
            {
                XtraMessageBox.Show("此次点菜含有退菜，如不满意请重新点菜", "抱歉，系统将自动结束点菜");
                e.Cancel = true;
                this.IsRetreatDishes = false;
                btnOver_Click(sender, e);
            }
            if (this.IsOver == false)
            {
                if (XtraMessageBox.Show("退出前还未结束此次的点菜", "是否要结束点菜？", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    e.Cancel = true;
                    this.IsOver = true;
                    btnOver_Click(sender, e);
                }
            }
        }

        /// <summary>
        /// Handles the KeyDown event of the gridControlDish control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.KeyEventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-2-25
        private void gridControlDish_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                gridControlDish_DoubleClick(null, null);
        }
        /// <summary>
        /// Handles the CheckedChanged event of the chkExpand control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-25
        private void chkExpand_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExpand.Checked == true)
                this.gridViewMain.CollapseAllGroups();
            else
                this.gridViewMain.ExpandAllGroups();
        }

        /// <summary>
        /// Handles the DoubleClick event of the gridControlList control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-2-25
        private void gridControlList_DoubleClick(object sender, EventArgs e)
        {
            MoveChoosedInfo();
        }
        #endregion
    }
}