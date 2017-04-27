
//******************************************************************************************************
//** Copyright (C) 2010-2013 �ش��������ѧԺ
//** �����ˣ������
//** ������\�ļ�����frmMain
//** �๦�ܣ�ϵͳ������
//** �� ������������ϵͳ������
//** �������ڣ�2013-1-14
//** �޸�(&U)�ˣ������
//** �޸�(&U)���ڣ�2013-1-27
//** �������ڣ�2013-1-27
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
    /// ϵͳ������
    /// </summary>
    /// �����ˣ������
    /// �������ڣ�2013-02-23
    public partial class frmBAMain : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="frmMain"/> class.
        /// </summary>
        /// �����ˣ������
        /// �������ڣ�2013-02-23
        public frmBAMain()
        {
            InitializeComponent();
            btnRefresh_Click(null,null);
        }

        #region ��������
        public static bool IsRefresh = false;                                           //�Ƿ�ˢ�²�̨״̬
        private BUCMS_ItemDetail myBUCMSItemDetail = new BUCMS_ItemDetail();            //��ϸ��Ŀ��Ϣ������
        private BUCMS_Buffets myBUBuffets = new BUCMS_Buffets();                        //��̨��Ϣ������

        private VariedEnum.BuffetStatus StatusEnum;                                     //��̨ʹ��״̬
        private ListViewItem BuffetControl = null;                                      //��ǰ���̨�ؼ�
        private bool IsShowOnePage = false;                                             //��ǰ�������Ƿ�ҳ��ʾ���ǵ�ҳ��ʾ��faleΪ��ҳ
        private string DisplayModel = "Floor";                                          //�������̨����鿴���ͣ�Ĭ��Ϊ��¥��
        #endregion

        #region �����¼�
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
            //��õ�ǰ���ڡ�ʱ�䡢����
            string strCurrentTime = DateTime.Now.ToString("yyyy��M��d�� HH:mm:ss dddd");
            string tempText="CMS ����Ӫҵģʽ------��ǰʱ�䣺";
            this.Text = tempText + strCurrentTime;
        }
        #endregion

        #region private void AddFloorInfo() ���ɸ�¥���TabPage������ӵ�TabControl
        /// <summary>
        /// ���ɸ�¥���TabPage������ӵ�TabControl
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

        #region private void AddBuffetsStatus() ���ɲ�̨ʹ��״̬TabPage������ӵ�TabControl
        /// <summary>
        /// ���ɲ�̨ʹ��״̬TabPage������ӵ�TabControl
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

        #region private void AddRoomInfo(����) ��Ӱ�����Ϣ
        /// <summary>
        /// ���ɰ�����ϢTabPage������ӵ�TabControl
        /// </summary>
        /// �����ˣ������
        /// �������ڣ�2013-02-24
        private void AddRoomInfo()
        {
            this.xtraTabControlMain.TabPages.Clear();
            try
            {
                DataTable RoomInfo = new BUCMS_RoomType().GetOrder(false, string.Empty, string.Empty, false);
                if (RoomInfo.Rows.Count <= 0)
                {
                    XtraMessageBox.Show("δ���Ű���","���޷�Ӫҵ����",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
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
        /// ��Ӱ�����Ϣ
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
                    paramTabPage.Tooltip = "��¥����δ���Ű���";
                }
                paramTabPage.Controls.Add(tempListView);
                tempListView.Dock = DockStyle.Fill;
                for (int i = 0; i < RoomInfo.Rows.Count; i++)
                {
                    ListViewGroup tempListViewGroup = new ListViewGroup();
                    tempListViewGroup.Name = RoomInfo.Rows[i]["ID"].ToString();
                    tempListViewGroup.Header= RoomInfo.Rows[i]["Name"].ToString()+"        ��ע��";
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

        #region private void AddBuffetsInfo(����) ��Ӳ�̨��Ϣ
        /// <summary>
        /// ��Ӳ�̨��Ϣ
        /// </summary>
        /// <param name="paramTabPage">The param tab page.</param>
        /// �����ˣ������
        /// �������ڣ�2013-02-24
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
                    paramTabPage.Tooltip = "��ǰ�����������Ĳ�̨";
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
        /// ��Ӳ�̨��Ϣ
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
                    paramListViewGroup.Header += "��̨";
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

        #region private ListViewItem GetInitedBuffetControl(DataRow paramDataRow) ��һ����̨����ʵ��õ�һ������Ĳ�̨�ؼ�
        /// <summary>
        /// ��һ����̨����ʵ��õ�һ������Ĳ�̨�ؼ�
        /// </summary>
        /// <param name="paramDataRow"></param>
        private ListViewItem GetInitedBuffetControl(DataRow paramDataRow)
        {
            ListViewItem returnListViewItem = new ListViewItem();
            if (paramDataRow == null)
            {
                returnListViewItem.Name = string.Empty;
                returnListViewItem.Text = "���޲�̨";
                returnListViewItem.ImageIndex = 5;
                ListViewItem.ListViewSubItem tempSubItem = new ListViewItem.ListViewSubItem();
                tempSubItem.Name = "StateID";
                tempSubItem.Text = Convert.ToInt32(VariedEnum.BuffetStatus.δ����).ToString();
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
        /// ��ò�̨Ԥ�����ݼ�
        /// </summary>
        /// <param name="paramBuffetControl">The param buffet control.</param>
        /// �����ˣ������
        /// ����ʱ�䣺2013-03-02
        private void GetBuffetBookData(ListViewItem paramBuffetControl)
        {
            if (Convert.ToInt32(paramBuffetControl.SubItems["StateID"].Text) != Convert.ToInt32(VariedEnum.BuffetStatus.Ԥ��))
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

        #region private void FillItemToolTip(ListViewItem paramLVItem, DataRow paramDataRow) ����̨ע����Ϣ
        /// <summary>
        /// ����̨ע����Ϣ
        /// </summary>
        /// <param name="paramLVItem">The param LV item.</param>
        /// <param name="paramDataRow">The param data row.</param>
        /// �����ˣ������
        /// �������ڣ�2013-02-24
        private void FillItemToolTip(ListViewItem paramLVItem, DataRow paramDataRow)
        {
            string tempItemToolTip = string.Empty;
            DataTable tempDataTable=paramDataRow.Table;
            for (int i = 0; i < tempDataTable.Columns.Count; i++)
            {
                switch (tempDataTable.Columns[i].Caption)
                {
                    case "ID":
                        tempItemToolTip += "��̨���:" + paramDataRow[i].ToString().Trim() +Environment.NewLine;
                        break;
                    case "Name":
                        tempItemToolTip += "��̨����:" + paramDataRow[i].ToString().Trim() + Environment.NewLine;
                        break;
                    case "AccommodateNum":
                        tempItemToolTip += "��������:" + paramDataRow[i].ToString().Trim() +"��"+ Environment.NewLine;
                        break;
                    case "StateID":
                        tempItemToolTip += "��ǰʹ��״̬��" + ((VariedEnum.BuffetStatus)paramDataRow[i]).ToString() + Environment.NewLine;
                        break;
                    case "InfoNote":
                        tempItemToolTip += "��̨��ע��" + paramDataRow[i].ToString();
                        break;
                    default: break;
                }
            }
            paramLVItem.ToolTipText = tempItemToolTip;
        }
        #endregion

        #region private void FillAllValues(ListView paramListView) �����п��õı�����ֵ
        /// <summary>
        /// �����п��õı�����ֵ
        /// </summary>
        /// <param name="paramListView">��ǰ���ListView�ؼ�</param>
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

        #region private void GetConsumptionInfo(string paramMarkID) ���������ϸ��Ϣ
        /// <summary>
        /// ���������ϸ��Ϣ
        /// </summary>
        /// <param name="paramMarkID"></param>
        private void GetConsumptionInfo(string paramMarkID)
        {
            try
            {
                DataTable tempDataTable = new BUCMS_ConsumptionDish().GetOrder(true,"MarkID", paramMarkID,false);
                groupControlDetail.Text = "�˲�̨��ϸ������Ŀ------------��ǰ��̨����Ա��[" + tempDataTable.Rows[0]["����Ա"].ToString()+"]";
                this.gridControlItem.DataSource = tempDataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region private ListView GetInitedBuffets() �����ʾ��̨��Ϣ�Ŀؼ�
        /// <summary>
        /// �����ʾ��̨��Ϣ�Ŀؼ�
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
        /// �����ˣ������
        /// �������ڣ�2013-02-25
        void templistView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                templistView_DoubleClick(sender,null);
        }

        #endregion

        #region ��̨�ؼ��¼�

        /// <summary>
        /// Handles the SelectedIndexChanged event of the templistView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// �����ˣ������
        /// �������ڣ�2013-02-24
        void templistView_SelectedIndexChanged(object sender, EventArgs e)
        {
            templistView_Click(sender, e);
        }

        /// <summary>
        /// Handles the Click event of the templistView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// �����ˣ������
        /// �������ڣ�2013-02-24
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
                if (StatusEnum==VariedEnum.BuffetStatus.ռ��)
                {
                    tempMarkID = this.BuffetControl.SubItems["MarkID"].Text;
                    GetConsumptionInfo(tempMarkID);
                }
                else
                {
                    this.gridControlItem.DataSource = null;
                    groupControlDetail.Text = "�˲�̨�����κ�������Ŀ";
                }
            }
            catch(Exception ex)
            {
                BUT_SysLog.InsertSysLog(ex,frmLogin.SysUser.UserID);
            }
        }

        /// <summary>
        /// ��̨˫��
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
                    case VariedEnum.BuffetStatus.δ����:
                        XtraMessageBox.Show("�˲�̨��δ��ӣ���ʱ�޷�ʹ��", "��Ǹ,���޷�ʹ��",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case VariedEnum.BuffetStatus.����:
                        barBtnBuffetOpen_ItemClick(null, null);
                        break;
                    case VariedEnum.BuffetStatus.Ԥ��:
                        barBtnBuffetOpen_ItemClick(null, null);
                        break;
                    case VariedEnum.BuffetStatus.ռ��:
                        barBtnAddCon_ItemClick(null,null);
                        break;
                    case VariedEnum.BuffetStatus.��̨:
                        XtraMessageBox.Show("�˲�̨Ϊ��̨,Ҫʹ�����ȸ�����ʹ��״̬", "��Ǹ,���޷�ʹ��",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        break;
                    default: XtraMessageBox.Show("ϵͳ�ݶ���Ĳ�̨ʹ��״̬", "������ʾ",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                //���ò�̨ͼListView�Ҽ������˵�
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

        #region private void InitPopmenuByState(VariedEnum.BuffetStatus paramBuffetStatus) ��ʼ����ʾ�Ҽ��˵�
        /// <summary>
        /// ��ʼ����ʾ�Ҽ��˵�
        /// </summary>
        /// <param name="paramBuffetStatus">The param buffet status.</param>
        /// �����ˣ������
        /// �������ڣ�2013-02-28
        private void InitPopmenuByState(VariedEnum.BuffetStatus paramBuffetStatus)
        {
            for (int i = 0; i < this.popupMenuMain.ItemLinks.Count; i++)
                OperatorPopupMenuItemLinks(this.popupMenuMain.ItemLinks[i].Item, true);
            switch (paramBuffetStatus)
            {
                case VariedEnum.BuffetStatus.����:
                    OperatorPopupMenuItemLinks(this.barBtnBuffetOpen, false);               //����̨
                    OperatorPopupMenuItemLinks(this.barBtnBuffetBook, false);               //��̨Ԥ��
                    OperatorPopupMenuItemLinks(this.barBtnSeach,false);                     //Ԥ����ѯ
                    this.barBtnBuffetStatus.Caption = "��Ϊ��̨";
                    OperatorPopupMenuItemLinks(this.barBtnBuffetStatus,false);              //��̨״̬
                    break;
                case VariedEnum.BuffetStatus.ռ��:
                    OperatorPopupMenuItemLinks(this.barBtnAddCon, false);                   //��������
                    OperatorPopupMenuItemLinks(this.barBtnOver, false);                     //����
                    OperatorPopupMenuItemLinks(this.barBtnSeach, false);                    //Ԥ����ѯ
                    OperatorPopupMenuItemLinks(this.barBtnTogether, false);                 //�˵��ϲ�
                    OperatorPopupMenuItemLinks(this.barBtnBillO, false);                    //�˵����
                    break;
                case VariedEnum.BuffetStatus.Ԥ��:
                    OperatorPopupMenuItemLinks(this.barBtnBuffetOpen, false);               //����̨
                    OperatorPopupMenuItemLinks(this.barBtnSeach, false);                    //Ԥ����ѯ
                    this.barBtnBuffetStatus.Caption = "��Ϊ���в�̨";
                    OperatorPopupMenuItemLinks(this.barBtnBuffetStatus, false);             //��̨״̬
                    break;
                case VariedEnum.BuffetStatus.��̨:
                    OperatorPopupMenuItemLinks(this.barBtnBuffetOpen, false);               //����̨
                    OperatorPopupMenuItemLinks(this.barBtnSeach, false);                    //Ԥ����ѯ
                    this.barBtnBuffetStatus.Caption = "��Ϊ���в�̨";
                    OperatorPopupMenuItemLinks(this.barBtnBuffetStatus, false);             //��̨״̬
                    break;
                default: break;
            }
        }
        #endregion

        #region private void OperatorPopupMenuItemLinks(object paramTargetItem,bool IsFrozen) �����˵���ʾ��
        /// <summary>
        /// �����˵���ʾ��
        /// </summary>
        /// <param name="paramTargetItem">The param target item.</param>
        /// <param name="IsFrozen">�Ƿ����</param>
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

        #region  private void DisplayAllInOnePage()  ��ҳ��ʾ
        /// <summary>
        /// ��ҳ��ʾ
        /// </summary>
        private void DisplayAllInOnePage()
        {
            this.xtraTabControlMain.TabPages.Clear();
            BUCMS_RoomType myBURoomType = new BUCMS_RoomType();
            try
            {
                ListView tempListView = GetInitedBuffet("ȫ��");
                DataTable RoomInfo = myBURoomType.GetOrder(false,string.Empty,string.Empty,false);
                DevExpress.XtraTab.XtraTabPage tbPageNew = new DevExpress.XtraTab.XtraTabPage();
                tbPageNew.Name = "All";
                tbPageNew.Text = "���в�̨��Ϣ";
                tbPageNew.Tooltip = "ȫ���Ĳ�̨��Ϣ";
                this.xtraTabControlMain.TabPages.Add(tbPageNew);
                tbPageNew.Controls.Add(tempListView);
                for (int i = 0; i < RoomInfo.Rows.Count; i++)
                {
                    ListViewGroup tempListViewGroup = new ListViewGroup();
                    tempListViewGroup.Name = RoomInfo.Rows[i]["ID"].ToString();
                    tempListViewGroup.Header = RoomInfo.Rows[i]["Name"].ToString() + "        ��ע��";
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

        #region ���������밴ť�¼�
        /// <summary>
        /// ��ʾ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShow_Click(object sender, EventArgs e)
        {
            if (btnShow.Text == "��ҳ��ʾ(&S)")
            {
                DisplayAllInOnePage();
                this.IsShowOnePage = true;
                btnShow.Text = "��ҳ��ʾ(&P)";
                barBtnCDisplay.Caption = "��ҳ��ʾ(&P)";
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
                btnShow.Text = "��ҳ��ʾ(&S)";
                barBtnCDisplay.Caption = "��ҳ��ʾ(&S)";
            }
        }

        /// <summary>
        /// ˢ��
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
        /// ������ʾ��ʽ
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// �����ˣ������
        /// �������ڣ�2013-02-24
        private void btnCDisplay_Click(object sender, EventArgs e)
        {
            Point ControlLeftButtom = new Point(0, this.btnCDisplay.Height);
            Point ShowLocation = this.btnCDisplay.PointToScreen(ControlLeftButtom);
            this.popupMenuShowBuffet.ShowPopup(ShowLocation);
        }
        #endregion

        #region ��̨�Ҽ���ݲ˵�
        /// <summary>
        /// ����̨
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barBtnBuffetOpen_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                 if (StatusEnum == VariedEnum.BuffetStatus.Ԥ��)
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
                else if (StatusEnum == VariedEnum.BuffetStatus.����)
                {
                    frmBCarryOut.frmBuffetRegister myfrmBuffetRegister = new frmBCarryOut.frmBuffetRegister(BuffetControl);
                    myfrmBuffetRegister.Show();
                }
                else
                    XtraMessageBox.Show("��̨��ǰ״̬Ϊ:" + StatusEnum.ToString(), "��Ǹ,���޷���̨", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,"����̨");
            }
        }

        /// <summary>
        /// ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barBtnOver_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (StatusEnum == VariedEnum.BuffetStatus.ռ��)
                {
                    frmBCarryOut.frmCheckOut myfrmCheckOut = new CMS.UILayer.frmBCarryOut.frmCheckOut(BuffetControl);
                    myfrmCheckOut.Show();
                }
                else
                    XtraMessageBox.Show("��̨��ǰ״̬Ϊ:" + StatusEnum.ToString(), "��Ǹ,���޷�����", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,"����");
            }
        }

        /// <summary>
        /// ��������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barBtnAddCon_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (StatusEnum == VariedEnum.BuffetStatus.ռ��)
                {
                    frmBCarryOut.frmDineRegister myfrmDineRegister = new CMS.UILayer.frmBCarryOut.frmDineRegister(BuffetControl);
                    myfrmDineRegister.Show();
                }
                else
                    XtraMessageBox.Show("��̨��ǰ״̬Ϊ:" + StatusEnum.ToString(), "��Ǹ,���޷���������", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,"��������");
            }
        }

        /// <summary>
        /// ��̨Ԥ��
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        /// �����ˣ������
        /// �������ڣ�2013-02-25
        private void barBtnBuffetBook_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (StatusEnum == VariedEnum.BuffetStatus.����)
                {
                    frmBCarryOut.frmBuffetBook myfrmBuffetBook = new CMS.UILayer.frmBCarryOut.frmBuffetBook(this.BuffetControl);
                    myfrmBuffetBook.ShowDialog();
                }
                else
                    XtraMessageBox.Show("��̨��ǰ״̬Ϊ:" + StatusEnum.ToString(), "��Ǹ,���޷�Ԥ��", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,"��̨Ԥ��");
            }
        }

        /// <summary>
        /// ���Ĳ�̨״̬
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        private void barBtnBuffetStatus_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.barBtnBuffetStatus.Caption == "��Ϊ���в�̨")
                ClassAssist.BuffetOperator.UpdateBuffetInfo(this.BuffetControl, VariedEnum.BuffetStatus.����, string.Empty);
            else
                ClassAssist.BuffetOperator.UpdateBuffetInfo(this.BuffetControl,VariedEnum.BuffetStatus.��̨,string.Empty);
        }

        /// <summary>
        /// Ԥ����Ϣ��ѯ
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        /// �����ˣ������
        /// ����ʱ�䣺2013-03-03
        private void barBtnSeach_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBCarryOut.frmBuffetBookSearch myfrmBuffetBookSearch = new CMS.UILayer.frmBCarryOut.frmBuffetBookSearch();
            myfrmBuffetBookSearch.ShowDialog();
        }
        #endregion

        #region ������ʾ�Ŀ�ݲ˵�
        /// <summary>
        /// ��¥�����鿴
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        /// �����ˣ������
        /// �������ڣ�2013-02-24
        private void btnFloor_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddFloorInfo();
            this.DisplayModel = "Floor";
            this.btnCDisplay.Text = "��¥�����鿴";
        }

        /// <summary>
        /// ����̨ʹ��״̬
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        /// �����ˣ������
        /// �������ڣ�2013-02-24
        public void btnBuffetStatus_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddBuffetsStatus();
            this.DisplayModel = "Status";
            this.btnCDisplay.Text = "����̨ʹ��״̬";
        }

        /// <summary>
        /// ����������
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        /// �����ˣ������
        /// �������ڣ�2013-02-24
        private void btnRoomType_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddRoomInfo();
            this.DisplayModel = "Room";
            this.btnCDisplay.Text = "���������鿴";

        }
        #endregion

        #region ���й����Ҽ��˵�
        /// <summary>
        /// ˢ��
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        /// �����ˣ������
        /// �������ڣ�2013-02-24
        private void barItemRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            btnRefresh_Click(sender, e);
        }

        /// <summary>
        /// ��ҳ��ʾ
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        /// �����ˣ������
        /// �������ڣ�2013-02-24
        private void barBtnCDisplay_ItemClick(object sender, ItemClickEventArgs e)
        {
            btnShow_Click(sender, e);
        }

        /// <summary>
        /// ��¥�������ʾ
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        /// �����ˣ������
        /// �������ڣ�2013-02-24
        private void barBtnFloor_ItemClick(object sender, ItemClickEventArgs e)
        {
            btnFloor_ItemClick(sender, e);
        }

        /// <summary>
        /// ����������
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        /// �����ˣ������
        /// �������ڣ�2013-02-24
        private void barBtnRoomType_ItemClick(object sender, ItemClickEventArgs e)
        {
            btnRoomType_ItemClick(sender,e);
        }

        /// <summary>
        /// ��̨ʹ��״̬
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        /// �����ˣ������
        /// �������ڣ�2013-02-24
        private void barBtnStatus_ItemClick(object sender, ItemClickEventArgs e)
        {
            btnBuffetStatus_ItemClick(sender,e);
        }
        #endregion
    }
}