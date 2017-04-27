
//******************************************************************************************************
//** Copyright (C) 2010-2013 重大网络教育学院
//** 创建人：桂书丛
//** 类名称\文件名：frmMain
//** 类功能：系统主窗体
//** 描 述：餐饮管理系统主窗体
//** 创建日期：2013-1-14
//** 修改(&U)人：桂书丛
//** 修改(&U)日期：2013-1-27
//** 整理日期：2013-1-27
//******************************************************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using CMS.BULayer;
using CMS.Model;
using CMS.CommonLayer;

namespace CMS.UILayer.frmAssist
{
    /// <summary>
    /// 系统主窗体
    /// </summary>
    /// 创建人：桂书丛
    /// 创建日期：2013-02-23
    public partial class frmBAMain : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="frmMain"/> class.
        /// </summary>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-23
        public frmBAMain()
        {
            InitializeComponent();
            btnRefresh_Click(null,null);
        }

        #region 变量定义
        public static bool IsRefresh = false;                                           //是否刷新餐台状态
        private BUCMS_ItemDetail myBUCMSItemDetail = new BUCMS_ItemDetail();            //详细项目信息操作集
        private BUCMS_Buffets myBUBuffets = new BUCMS_Buffets();                        //餐台信息操作集

        private VariedEnum.BuffetStatus StatusEnum;                                     //餐台使用状态
        private ListViewItem BuffetControl = null;                                      //当前活动餐台控件
        private bool IsShowOnePage = false;                                             //当前主界面是分页显示还是单页显示，fale为分页
        private string DisplayModel = "Floor";                                          //主界面餐台分类查看类型，默认为按楼层
        #endregion

        #region 窗体事件
        /// <summary>
        /// Handles the Tick event of the tmrMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void tmrMain_Tick(object sender, EventArgs e)
        {
            if (IsRefresh == true)
            {
                btnRefresh_Click(null, null);
                IsRefresh = false;
            }
            //获得当前日期、时间、星期
            string strCurrentTime = DateTime.Now.ToString("yyyy年M月d日 HH:mm:ss dddd");
            string tempText="CMS 独立营业模式------当前时间：";
            this.Text = tempText + strCurrentTime;
        }
        #endregion

        #region private void AddFloorInfo() 生成各楼层的TabPage，并添加到TabControl
        /// <summary>
        /// 生成各楼层的TabPage，并添加到TabControl
        /// </summary>
        private void AddFloorInfo()
        {
            this.xtraTabControlMain.TabPages.Clear();
            try
            {
                DataTable FloorInfo = myBUCMSItemDetail.GetItemByType(VariedItemType.RoomFloor);
                for (int i = 0; i < FloorInfo.Rows.Count; i++)
                {
                    DevExpress.XtraTab.XtraTabPage tbPageNew = new DevExpress.XtraTab.XtraTabPage();
                    tbPageNew.Name = FloorInfo.Rows[i]["ID"].ToString();
                    tbPageNew.Text = FloorInfo.Rows[i]["Name"].ToString();
                    tbPageNew.Tooltip = FloorInfo.Rows[i]["Description"].ToString();
                    this.xtraTabControlMain.TabPages.Add(tbPageNew);
                    AddRoomInfo(tbPageNew);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,"Floor");
            }
        }
        #endregion

        #region private void AddBuffetsStatus() 生成餐台使用状态TabPage，并添加到TabControl
        /// <summary>
        /// 生成餐台使用状态TabPage，并添加到TabControl
        /// </summary>
        private void AddBuffetsStatus()
        {
            this.xtraTabControlMain.TabPages.Clear();
            try
            {
                DataTable BuffetStatus = myBUCMSItemDetail.GetItemByType(VariedItemType.BuffetStatus);
                for (int i = 0; i < BuffetStatus.Rows.Count; i++)
                {
                    DevExpress.XtraTab.XtraTabPage tbPageNew = new DevExpress.XtraTab.XtraTabPage();
                    tbPageNew.Name = BuffetStatus.Rows[i]["ID"].ToString();
                    tbPageNew.Text = BuffetStatus.Rows[i]["Name"].ToString();
                    tbPageNew.Tooltip = BuffetStatus.Rows[i]["Description"].ToString();
                    this.xtraTabControlMain.TabPages.Add(tbPageNew);
                    AddBuffetsInfo(tbPageNew,"Status");
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Floor");
            }
        }
        #endregion

        #region private void AddRoomInfo(……) 添加包厢信息
        /// <summary>
        /// 生成包厢信息TabPage，并添加到TabControl
        /// </summary>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-24
        private void AddRoomInfo()
        {
            this.xtraTabControlMain.TabPages.Clear();
            try
            {
                DataTable RoomInfo = new BUCMS_RoomType().GetOrder(false, string.Empty, string.Empty, false);
                if (RoomInfo.Rows.Count <= 0)
                {
                    XtraMessageBox.Show("未安排包厢","暂无法营业……",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
                for (int i = 0; i < RoomInfo.Rows.Count; i++)
                {
                    DevExpress.XtraTab.XtraTabPage tbPageNew = new DevExpress.XtraTab.XtraTabPage();
                    tbPageNew.Name = RoomInfo.Rows[i]["ID"].ToString();
                    tbPageNew.Text = RoomInfo.Rows[i]["Name"].ToString();
                    tbPageNew.Tooltip = RoomInfo.Rows[i]["Description"].ToString();
                    this.xtraTabControlMain.TabPages.Add(tbPageNew);
                    AddBuffetsInfo(tbPageNew,"Room");
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Room");
            }
        }
        /// <summary>
        /// 添加包厢信息
        /// </summary>
        /// <param name="paramTabPage"></param>
        private void AddRoomInfo(DevExpress.XtraTab.XtraTabPage paramTabPage)
        {
            BUCMS_RoomType myBURoomType = new BUCMS_RoomType();
            try
            { 
                ListView tempListView = GetInitedBuffet(paramTabPage.Text);
                DataTable RoomInfo = myBURoomType.GetOrder(false,"FloorID",paramTabPage.Name,false);
                if (RoomInfo.Rows.Count <= 0)
                {
                    paramTabPage.Tooltip = "此楼层暂未安排包厢";
                }
                paramTabPage.Controls.Add(tempListView);
                tempListView.Dock = DockStyle.Fill;
                for (int i = 0; i < RoomInfo.Rows.Count; i++)
                {
                    ListViewGroup tempListViewGroup = new ListViewGroup();
                    tempListViewGroup.Name = RoomInfo.Rows[i]["ID"].ToString();
                    tempListViewGroup.Header= RoomInfo.Rows[i]["Name"].ToString()+"        备注：";
                    tempListViewGroup.Header += RoomInfo.Rows[i]["Description"].ToString();
                    tempListViewGroup.Tag = RoomInfo.Rows[i]["EquipmentID"];
                    tempListView.Groups.Add(tempListViewGroup);
                    AddBuffetsInfo(tempListViewGroup);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,"Room");
            }
        }
        #endregion

        #region private void AddBuffetsInfo(……) 添加餐台信息
        /// <summary>
        /// 添加餐台信息
        /// </summary>
        /// <param name="paramTabPage">The param tab page.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-24
        private void AddBuffetsInfo(DevExpress.XtraTab.XtraTabPage paramTabPage,string paramFlages)
        {
            try
            {
                ListView tempListView = GetInitedBuffet(paramTabPage.Text);
                DataTable BuffetInfo=new DataTable();
                if (paramFlages == "Status")
                    BuffetInfo = myBUBuffets.GetOrder(false, "StateID", paramTabPage.Name, false);
                else
                    BuffetInfo = myBUBuffets.GetOrder(false,"RoomTypeID",paramTabPage.Name,false);
                if (BuffetInfo.Rows.Count <= 0)
                {
                    paramTabPage.Tooltip = "当前无满足条件的餐台";
                }
                paramTabPage.Controls.Add(tempListView);
                tempListView.Dock = DockStyle.Fill;
                if (BuffetInfo.Rows.Count <= 0)
                {
                    ListViewItem tempListViewItem = GetInitedBuffetControl(null);
                    tempListView.Items.Add(tempListViewItem);
                }
                foreach (DataRow tempDataRow in BuffetInfo.Rows)
                {
                    ListViewItem tempListViewItem = GetInitedBuffetControl(tempDataRow);
                    tempListView.Items.Add(tempListViewItem);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Buffet");
            }
        }

        /// <summary>
        /// 添加餐台信息
        /// </summary>
        /// <param name="paramListViewGroup">The param list view group.</param>
        private void AddBuffetsInfo(ListViewGroup paramListViewGroup)
        {
            BUCMS_Buffets myBUBuffets = new BUCMS_Buffets();
            try
            {
                DataTable BuffetsInfo = myBUBuffets.GetOrder(false,"RoomTypeID",paramListViewGroup.Name,false);
                if (BuffetsInfo.Rows.Count <= 0)
                {
                    ListViewItem tempListViewItem = GetInitedBuffetControl(null);
                    paramListViewGroup.Header += "餐台";
                    tempListViewItem.Group = paramListViewGroup;
                    paramListViewGroup.ListView.Items.Add(tempListViewItem);
                }
                foreach (DataRow tempDataRow in BuffetsInfo.Rows)
                {
                    ListViewItem tempListViewItem = GetInitedBuffetControl(tempDataRow);
                    tempListViewItem.Group = paramListViewGroup;
                    paramListViewGroup.ListView.Items.Add(tempListViewItem);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,"Buffets");
            }
        }
        #endregion

        #region private ListViewItem GetInitedBuffetControl(DataRow paramDataRow) 由一个餐台数据实体得到一个具体的餐台控件
        /// <summary>
        /// 由一个餐台数据实体得到一个具体的餐台控件
        /// </summary>
        /// <param name="paramDataRow"></param>
        private ListViewItem GetInitedBuffetControl(DataRow paramDataRow)
        {
            ListViewItem returnListViewItem = new ListViewItem();
            if (paramDataRow == null)
            {
                returnListViewItem.Name = string.Empty;
                returnListViewItem.Text = "暂无餐台";
                returnListViewItem.ImageIndex = 5;
                ListViewItem.ListViewSubItem tempSubItem = new ListViewItem.ListViewSubItem();
                tempSubItem.Name = "StateID";
                tempSubItem.Text = Convert.ToInt32(VariedEnum.BuffetStatus.未定义).ToString();
                returnListViewItem.SubItems.Add(tempSubItem);
                return returnListViewItem;
            }
            DataTable tempDataTable=paramDataRow.Table;
            try
            {
                FillItemToolTip(returnListViewItem, paramDataRow);
                for (int i = 0; i < tempDataTable.Columns.Count; i++)
                {
                    if (i == 0)
                    {
                        returnListViewItem.Name = paramDataRow["ID"].ToString();
                        returnListViewItem.Text = paramDataRow["Name"].ToString();
                        returnListViewItem.ImageIndex = Convert.ToInt32(paramDataRow["STATEID"]);
                    }
                    ListViewItem.ListViewSubItem tempSubItem = new ListViewItem.ListViewSubItem();
                    tempSubItem.Name = tempDataTable.Columns[i].Caption;
                    tempSubItem.Text = paramDataRow[i].ToString().Trim();
                    returnListViewItem.SubItems.Add(tempSubItem);
                }
                GetBuffetBookData(returnListViewItem);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            return returnListViewItem;
        }

        /// <summary>
        /// 获得餐台预定数据集
        /// </summary>
        /// <param name="paramBuffetControl">The param buffet control.</param>
        /// 整理人：桂书丛
        /// 整理时间：2013-03-02
        private void GetBuffetBookData(ListViewItem paramBuffetControl)
        {
            if (Convert.ToInt32(paramBuffetControl.SubItems["StateID"].Text) != Convert.ToInt32(VariedEnum.BuffetStatus.预定))
                return;
            try
            {
                string tempBuffetID = paramBuffetControl.Name;
                DataTable tempBuffetBookInfo = null;
                tempBuffetBookInfo = new BUCMS_BuffetBooking().GetOrder(false, "[BuffetsID]", tempBuffetID, false);
                if (tempBuffetBookInfo != null&&tempBuffetBookInfo.Rows.Count > 0)
                    paramBuffetControl.Tag = tempBuffetBookInfo.Rows[0];
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region private void FillItemToolTip(ListViewItem paramLVItem, DataRow paramDataRow) 填充餐台注释信息
        /// <summary>
        /// 填充餐台注释信息
        /// </summary>
        /// <param name="paramLVItem">The param LV item.</param>
        /// <param name="paramDataRow">The param data row.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-24
        private void FillItemToolTip(ListViewItem paramLVItem, DataRow paramDataRow)
        {
            string tempItemToolTip = string.Empty;
            DataTable tempDataTable=paramDataRow.Table;
            for (int i = 0; i < tempDataTable.Columns.Count; i++)
            {
                switch (tempDataTable.Columns[i].Caption)
                {
                    case "ID":
                        tempItemToolTip += "餐台编号:" + paramDataRow[i].ToString().Trim() +Environment.NewLine;
                        break;
                    case "Name":
                        tempItemToolTip += "餐台名称:" + paramDataRow[i].ToString().Trim() + Environment.NewLine;
                        break;
                    case "AccommodateNum":
                        tempItemToolTip += "共可容纳:" + paramDataRow[i].ToString().Trim() +"人"+ Environment.NewLine;
                        break;
                    case "StateID":
                        tempItemToolTip += "当前使用状态：" + ((VariedEnum.BuffetStatus)paramDataRow[i]).ToString() + Environment.NewLine;
                        break;
                    case "InfoNote":
                        tempItemToolTip += "餐台备注：" + paramDataRow[i].ToString();
                        break;
                    default: break;
                }
            }
            paramLVItem.ToolTipText = tempItemToolTip;
        }
        #endregion

        #region private void FillAllValues(ListView paramListView) 给所有可用的变量赋值
        /// <summary>
        /// 给所有可用的变量赋值
        /// </summary>
        /// <param name="paramListView">当前活动的ListView控件</param>
        private void FillAllValues(ListView paramListView)
        {
            try
            {
                ListView tempListView = paramListView;
                if (tempListView != null && tempListView.SelectedItems.Count > 0)
                {
                    this.BuffetControl = tempListView.SelectedItems[0];
                    int StatusNum = Convert.ToInt32(BuffetControl.SubItems["StateID"].Text);
                    this.StatusEnum = (VariedEnum.BuffetStatus)StatusNum;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region private void GetConsumptionInfo(string paramMarkID) 获得消费详细信息
        /// <summary>
        /// 获得消费详细信息
        /// </summary>
        /// <param name="paramMarkID"></param>
        private void GetConsumptionInfo(string paramMarkID)
        {
            try
            {
                DataTable tempDataTable = new BUCMS_ConsumptionDish().GetOrder(true,"MarkID", paramMarkID,false);
                groupControlDetail.Text = "此餐台详细消费项目------------当前餐台服务员：[" + tempDataTable.Rows[0]["服务员"].ToString()+"]";
                this.gridControlItem.DataSource = tempDataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region private ListView GetInitedBuffets() 获得显示餐台信息的控件
        /// <summary>
        /// 获得显示餐台信息的控件
        /// </summary>
        /// <returns></returns>
        private ListView GetInitedBuffet(string paramName)
        {
            ListView templistView = new ListView();
            templistView.Name = paramName;
            templistView.Dock = System.Windows.Forms.DockStyle.Fill;
            templistView.View = View.LargeIcon;
            templistView.SmallImageList = this.imglstBuffetState;
            templistView.LargeImageList = this.imglstBuffetState;
            templistView.Location = new System.Drawing.Point(0, 0);
            templistView.MultiSelect = false;
            templistView.Size = new System.Drawing.Size(788, 344);
            templistView.LargeImageList = this.imglstBuffetState;
            templistView.ShowItemToolTips = true;
            templistView.TabIndex = 5;
            templistView.UseCompatibleStateImageBehavior = false;
            templistView.DoubleClick += new EventHandler(templistView_DoubleClick);
            templistView.Click += new EventHandler(templistView_Click);
            templistView.SelectedIndexChanged += new EventHandler(templistView_SelectedIndexChanged);
            templistView.KeyDown += new KeyEventHandler(templistView_KeyDown);
            templistView.MouseUp+=new MouseEventHandler(templistView_MouseUp);
           
            return templistView;
        }

        /// <summary>
        /// Handles the KeyDown event of the templistView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.KeyEventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-25
        void templistView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                templistView_DoubleClick(sender,null);
        }

        #endregion

        #region 餐台控件事件

        /// <summary>
        /// Handles the SelectedIndexChanged event of the templistView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-24
        void templistView_SelectedIndexChanged(object sender, EventArgs e)
        {
            templistView_Click(sender, e);
        }

        /// <summary>
        /// Handles the Click event of the templistView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-24
        void templistView_Click(object sender, EventArgs e)
        {
            try
            {
                ListView tempListView = ((ListView)sender);
                if (tempListView == null)
                    return;
                FillAllValues(tempListView);
                string tempMarkID = string.Empty;
                //ShowDetailInfo(this.myModelCMS_Buffets);
                if (StatusEnum==VariedEnum.BuffetStatus.占用)
                {
                    tempMarkID = this.BuffetControl.SubItems["MarkID"].Text;
                    GetConsumptionInfo(tempMarkID);
                }
                else
                {
                    this.gridControlItem.DataSource = null;
                    groupControlDetail.Text = "此餐台暂无任何消费项目";
                }
            }
            catch(Exception ex)
            {
                BUT_SysLog.InsertSysLog(ex,frmLogin.SysUser.UserID);
            }
        }

        /// <summary>
        /// 餐台双击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void templistView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ListView tempListView = ((ListView)sender);
                FillAllValues(tempListView);
                switch (StatusEnum)
                {
                    case VariedEnum.BuffetStatus.未定义:
                        XtraMessageBox.Show("此餐台尚未添加，暂时无法使用", "抱歉,暂无法使用",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case VariedEnum.BuffetStatus.空闲:
                        barBtnBuffetOpen_ItemClick(null, null);
                        break;
                    case VariedEnum.BuffetStatus.预定:
                        barBtnBuffetOpen_ItemClick(null, null);
                        break;
                    case VariedEnum.BuffetStatus.占用:
                        barBtnAddCon_ItemClick(null,null);
                        break;
                    case VariedEnum.BuffetStatus.脏台:
                        XtraMessageBox.Show("此餐台为脏台,要使用请先更改其使用状态", "抱歉,暂无法使用",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        break;
                    default: XtraMessageBox.Show("系统暂定义的餐台使用状态", "错误提示",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void templistView_MouseUp(object sender, MouseEventArgs e)
        {
            ListView tempListView = (ListView)sender;
            FillAllValues(tempListView);
            if (e.Button == MouseButtons.Right)
            {
                //设置餐台图ListView右键弹出菜单
                Point point = ((ListView)sender).PointToClient(MousePosition);
                ListViewItem item = ((ListView)sender).GetItemAt(point.X, point.Y);
                if (item == null)
                {
                    popupMenuAll.ShowPopup(Control.MousePosition);
                    return;
                }
                InitPopmenuByState(this.StatusEnum);
                popupMenuMain.ShowPopup(Control.MousePosition);
            }
        }
        #endregion

        #region private void InitPopmenuByState(VariedEnum.BuffetStatus paramBuffetStatus) 初始化显示右键菜单
        /// <summary>
        /// 初始化显示右键菜单
        /// </summary>
        /// <param name="paramBuffetStatus">The param buffet status.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-28
        private void InitPopmenuByState(VariedEnum.BuffetStatus paramBuffetStatus)
        {
            for (int i = 0; i < this.popupMenuMain.ItemLinks.Count; i++)
                OperatorPopupMenuItemLinks(this.popupMenuMain.ItemLinks[i].Item, true);
            switch (paramBuffetStatus)
            {
                case VariedEnum.BuffetStatus.空闲:
                    OperatorPopupMenuItemLinks(this.barBtnBuffetOpen, false);               //开餐台
                    OperatorPopupMenuItemLinks(this.barBtnBuffetBook, false);               //餐台预定
                    OperatorPopupMenuItemLinks(this.barBtnSeach,false);                     //预定查询
                    this.barBtnBuffetStatus.Caption = "变为脏台";
                    OperatorPopupMenuItemLinks(this.barBtnBuffetStatus,false);              //餐台状态
                    break;
                case VariedEnum.BuffetStatus.占用:
                    OperatorPopupMenuItemLinks(this.barBtnAddCon, false);                   //增加消费
                    OperatorPopupMenuItemLinks(this.barBtnOver, false);                     //结账
                    OperatorPopupMenuItemLinks(this.barBtnSeach, false);                    //预定查询
                    OperatorPopupMenuItemLinks(this.barBtnTogether, false);                 //账单合并
                    OperatorPopupMenuItemLinks(this.barBtnBillO, false);                    //账单拆分
                    break;
                case VariedEnum.BuffetStatus.预定:
                    OperatorPopupMenuItemLinks(this.barBtnBuffetOpen, false);               //开餐台
                    OperatorPopupMenuItemLinks(this.barBtnSeach, false);                    //预定查询
                    this.barBtnBuffetStatus.Caption = "变为空闲餐台";
                    OperatorPopupMenuItemLinks(this.barBtnBuffetStatus, false);             //餐台状态
                    break;
                case VariedEnum.BuffetStatus.脏台:
                    OperatorPopupMenuItemLinks(this.barBtnBuffetOpen, false);               //开餐台
                    OperatorPopupMenuItemLinks(this.barBtnSeach, false);                    //预定查询
                    this.barBtnBuffetStatus.Caption = "变为空闲餐台";
                    OperatorPopupMenuItemLinks(this.barBtnBuffetStatus, false);             //餐台状态
                    break;
                default: break;
            }
        }
        #endregion

        #region private void OperatorPopupMenuItemLinks(object paramTargetItem,bool IsFrozen) 操作菜单显示项
        /// <summary>
        /// 操作菜单显示项
        /// </summary>
        /// <param name="paramTargetItem">The param target item.</param>
        /// <param name="IsFrozen">是否冰冻</param>
        private void OperatorPopupMenuItemLinks(object paramTargetItem, bool IsFrozen)
        {
            if (paramTargetItem != null)
            {
                BarButtonItem tempBarButtonItem = (BarButtonItem)paramTargetItem;
                tempBarButtonItem.Enabled = !IsFrozen;
                if (IsFrozen == true)
                {
                    tempBarButtonItem.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
                    tempBarButtonItem.Appearance.Options.UseFont = true;
                }
                else
                {
                    tempBarButtonItem.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
                    tempBarButtonItem.Appearance.ForeColor = Color.Blue;
                    tempBarButtonItem.Appearance.Options.UseFont = true;
                }
            }
        }
        #endregion

        #region  private void DisplayAllInOnePage()  单页显示
        /// <summary>
        /// 单页显示
        /// </summary>
        private void DisplayAllInOnePage()
        {
            this.xtraTabControlMain.TabPages.Clear();
            BUCMS_RoomType myBURoomType = new BUCMS_RoomType();
            try
            {
                ListView tempListView = GetInitedBuffet("全部");
                DataTable RoomInfo = myBURoomType.GetOrder(false,string.Empty,string.Empty,false);
                DevExpress.XtraTab.XtraTabPage tbPageNew = new DevExpress.XtraTab.XtraTabPage();
                tbPageNew.Name = "All";
                tbPageNew.Text = "所有餐台信息";
                tbPageNew.Tooltip = "全部的餐台信息";
                this.xtraTabControlMain.TabPages.Add(tbPageNew);
                tbPageNew.Controls.Add(tempListView);
                for (int i = 0; i < RoomInfo.Rows.Count; i++)
                {
                    ListViewGroup tempListViewGroup = new ListViewGroup();
                    tempListViewGroup.Name = RoomInfo.Rows[i]["ID"].ToString();
                    tempListViewGroup.Header = RoomInfo.Rows[i]["Name"].ToString() + "        备注：";
                    tempListViewGroup.Header += RoomInfo.Rows[i]["Description"].ToString();
                    tempListViewGroup.Tag = RoomInfo.Rows[i]["EquipmentID"];
                    tempListView.Groups.Add(tempListViewGroup);
                    AddBuffetsInfo(tempListViewGroup);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Floor");
            }
        }
        #endregion

        #region 主界面中央按钮事件
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShow_Click(object sender, EventArgs e)
        {
            if (btnShow.Text == "单页显示(&S)")
            {
                DisplayAllInOnePage();
                this.IsShowOnePage = true;
                btnShow.Text = "分页显示(&P)";
                barBtnCDisplay.Caption = "分页显示(&P)";
            }
            else
            {
                if (this.DisplayModel == "Floor")
                    AddFloorInfo();
                else if (this.DisplayModel == "Status")
                    AddBuffetsStatus();
                else if (this.DisplayModel == "Room")
                    AddRoomInfo();
                this.IsShowOnePage = false;
                btnShow.Text = "单页显示(&S)";
                barBtnCDisplay.Caption = "单页显示(&S)";
            }
        }

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (this.IsShowOnePage == false)
            {
                if (this.DisplayModel == "Floor")
                    AddFloorInfo();
                else if (this.DisplayModel == "Status")
                    AddBuffetsStatus();
                else if (this.DisplayModel == "Room")
                    AddRoomInfo();
            }
            else
                DisplayAllInOnePage();
            templistView_Click(sender, e);
        }

        /// <summary>
        /// 分类显示方式
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-24
        private void btnCDisplay_Click(object sender, EventArgs e)
        {
            Point ControlLeftButtom = new Point(0, this.btnCDisplay.Height);
            Point ShowLocation = this.btnCDisplay.PointToScreen(ControlLeftButtom);
            this.popupMenuShowBuffet.ShowPopup(ShowLocation);
        }
        #endregion

        #region 餐台右键快捷菜单
        /// <summary>
        /// 开餐台
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barBtnBuffetOpen_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                 if (StatusEnum == VariedEnum.BuffetStatus.预定)
                 {
                     frmBCarryOut.frmScheduledDeterminee myfrmScheduledDeterminee = new CMS.UILayer.frmBCarryOut.frmScheduledDeterminee(BuffetControl.Tag);
                     if (myfrmScheduledDeterminee.ShowDialog() == DialogResult.OK)
                     {
                         frmBCarryOut.frmBuffetRegister myfrmBuffetRegister = new frmBCarryOut.frmBuffetRegister(BuffetControl);
                         myfrmBuffetRegister.Show();
                     }
                     else
                         return;
                 }
                else if (StatusEnum == VariedEnum.BuffetStatus.空闲)
                {
                    frmBCarryOut.frmBuffetRegister myfrmBuffetRegister = new frmBCarryOut.frmBuffetRegister(BuffetControl);
                    myfrmBuffetRegister.Show();
                }
                else
                    XtraMessageBox.Show("餐台当前状态为:" + StatusEnum.ToString(), "抱歉,暂无法开台", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,"开餐台");
            }
        }

        /// <summary>
        /// 结账
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barBtnOver_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (StatusEnum == VariedEnum.BuffetStatus.占用)
                {
                    frmBCarryOut.frmCheckOut myfrmCheckOut = new CMS.UILayer.frmBCarryOut.frmCheckOut(BuffetControl);
                    myfrmCheckOut.Show();
                }
                else
                    XtraMessageBox.Show("餐台当前状态为:" + StatusEnum.ToString(), "抱歉,暂无法结账", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,"结账");
            }
        }

        /// <summary>
        /// 增加消费
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barBtnAddCon_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (StatusEnum == VariedEnum.BuffetStatus.占用)
                {
                    frmBCarryOut.frmDineRegister myfrmDineRegister = new CMS.UILayer.frmBCarryOut.frmDineRegister(BuffetControl);
                    myfrmDineRegister.Show();
                }
                else
                    XtraMessageBox.Show("餐台当前状态为:" + StatusEnum.ToString(), "抱歉,暂无法增加消费", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,"增加消费");
            }
        }

        /// <summary>
        /// 餐台预定
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-25
        private void barBtnBuffetBook_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (StatusEnum == VariedEnum.BuffetStatus.空闲)
                {
                    frmBCarryOut.frmBuffetBook myfrmBuffetBook = new CMS.UILayer.frmBCarryOut.frmBuffetBook(this.BuffetControl);
                    myfrmBuffetBook.ShowDialog();
                }
                else
                    XtraMessageBox.Show("餐台当前状态为:" + StatusEnum.ToString(), "抱歉,暂无法预定", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,"餐台预定");
            }
        }

        /// <summary>
        /// 更改餐台状态
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        private void barBtnBuffetStatus_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.barBtnBuffetStatus.Caption == "变为空闲餐台")
                ClassAssist.BuffetOperator.UpdateBuffetInfo(this.BuffetControl, VariedEnum.BuffetStatus.空闲, string.Empty);
            else
                ClassAssist.BuffetOperator.UpdateBuffetInfo(this.BuffetControl,VariedEnum.BuffetStatus.脏台,string.Empty);
        }

        /// <summary>
        /// 预定信息查询
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建时间：2013-03-03
        private void barBtnSeach_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBCarryOut.frmBuffetBookSearch myfrmBuffetBookSearch = new CMS.UILayer.frmBCarryOut.frmBuffetBookSearch();
            myfrmBuffetBookSearch.ShowDialog();
        }
        #endregion

        #region 分类显示的快捷菜单
        /// <summary>
        /// 按楼层分类查看
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-24
        private void btnFloor_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddFloorInfo();
            this.DisplayModel = "Floor";
            this.btnCDisplay.Text = "按楼层分类查看";
        }

        /// <summary>
        /// 按餐台使用状态
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-24
        public void btnBuffetStatus_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddBuffetsStatus();
            this.DisplayModel = "Status";
            this.btnCDisplay.Text = "按餐台使用状态";
        }

        /// <summary>
        /// 按包厢类型
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-24
        private void btnRoomType_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddRoomInfo();
            this.DisplayModel = "Room";
            this.btnCDisplay.Text = "按包厢分类查看";

        }
        #endregion

        #region 所有功能右键菜单
        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-24
        private void barItemRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            btnRefresh_Click(sender, e);
        }

        /// <summary>
        /// 分页显示
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-24
        private void barBtnCDisplay_ItemClick(object sender, ItemClickEventArgs e)
        {
            btnShow_Click(sender, e);
        }

        /// <summary>
        /// 按楼层分类显示
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-24
        private void barBtnFloor_ItemClick(object sender, ItemClickEventArgs e)
        {
            btnFloor_ItemClick(sender, e);
        }

        /// <summary>
        /// 按包厢类型
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-24
        private void barBtnRoomType_ItemClick(object sender, ItemClickEventArgs e)
        {
            btnRoomType_ItemClick(sender,e);
        }

        /// <summary>
        /// 餐台使用状态
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        /// 创建人：桂书丛
        /// 创建日期：2013-02-24
        private void barBtnStatus_ItemClick(object sender, ItemClickEventArgs e)
        {
            btnBuffetStatus_ItemClick(sender,e);
        }
        #endregion
    }
}