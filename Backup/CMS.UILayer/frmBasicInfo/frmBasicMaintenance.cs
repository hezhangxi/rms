//************************************************************************************************
//** Copyright (c) 2013-2013 �ش��������ѧԺ
//** �����ˣ������
//** ������\�ļ�����frmBasicMaintenance
//** �๦�ܣ�������Ϣά��
//** �� ������������ϵͳ������Ϣά��
//** �������ڣ�2013-2-14
//** �޸��ˣ������
//** �޸����ڣ�2013-2-14
//** �������ڣ�2013-2-14
//************************************************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CMS.BULayer;

namespace CMS.UILayer.frmBasicInfo
{
    public partial class frmBasicMaintenance : DevExpress.XtraEditors.XtraForm
    {
        BUCMS_ItemDetail myBUCMS_ItemDetail = new BUCMS_ItemDetail();
        DataTable myDT = new DataTable();
        int ID = 0;
        object[] tempInfo = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="frmBasicMaintenance"/> class.
        /// </summary>
        /// <remarks></remarks>
        public frmBasicMaintenance()
        {
            InitializeComponent();
            this.tbctrl.SelectedTabPageIndex = 1;
            //InitializeControls();
        }

        /// <summary>
        /// Handles the Load event of the frmBasicMaintenance control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void frmBasicMaintenance_Load(object sender, EventArgs e)
        {
            this.tbctrl.SelectedTabPageIndex = 0;
        }

        #region tbctrl_SelectedPageChanging GridControl�е����ݰ�
        /// <summary>
        /// GridControl�е����ݰ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbctrl_SelectedPageChanging(object sender, DevExpress.XtraTab.TabPageChangingEventArgs e)
        {
            try
            {
                string ItemType = e.Page.Tag.ToString();
                DataTable tempDataTable = myBUCMS_ItemDetail.GetItemByType(ItemType);
                foreach (Control tempControl in e.Page.Controls)
                {
                    if (tempControl.GetType() == typeof(DevExpress.XtraGrid.GridControl))
                        ((DevExpress.XtraGrid.GridControl)tempControl).DataSource = tempDataTable;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region private void RefreshData(DevExpress.XtraTab.XtraTabPage paramPage)���µ�ǰҳ����
        /// <summary>
        /// ���µ�ǰҳ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshData()
        {
            string ItemType = string.Empty;
            try
            {
                DevExpress.XtraTab.XtraTabPage tempTabPage = this.tbctrl.SelectedTabPage;
                if (tempTabPage != null)
                    ItemType = tempTabPage.Tag.ToString();
                DataTable tempDataTable = myBUCMS_ItemDetail.GetItemByType(ItemType);
                foreach (Control tempControl in tempTabPage.Controls)
                {
                    if (tempControl.GetType() == typeof(DevExpress.XtraGrid.GridControl))
                        ((DevExpress.XtraGrid.GridControl)tempControl).DataSource = tempDataTable;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        #endregion



        #region private void LoadDishType() ��grictrlDishType�������ݰ�
        /// <summary>
        /// grictrlDishType������
        /// </summary>
        private void LoadDishType()
        {
            myDT = myBUCMS_ItemDetail.GetItemByType(VariedItemType.DishType);
            grictrlDishType.DataSource = myDT;
        }
        #endregion


        //***************************��Ӱ�ť�ĵ����¼�*************************************//

        #region btnDishTypeAdd_Click��Ʒ�������Ӱ�ť�ĵ����¼�
        /// <summary>
        /// ��Ʒ�������Ӱ�ť�ĵ����¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDishTypeAdd_Click(object sender, EventArgs e)
        {
            frmPublicOperateArea myfrmPublicOperateArea = new frmPublicOperateArea(VariedEnum.ItemType.DishType);
            if (myfrmPublicOperateArea.ShowDialog() == DialogResult.OK)
                LoadDishType();
        }
        #endregion

        #region btnDishTasteAdd_Click ��Ʒ��ζ����Ӱ�ť�ĵ����¼�
        /// <summary>
        /// ��Ʒ��ζ����Ӱ�ť�ĵ����¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDishTasteAdd_Click(object sender, EventArgs e)
        {
            frmPublicOperateArea myfrmPublicOperateArea = new frmPublicOperateArea(VariedEnum.ItemType.TasteType);
            if (myfrmPublicOperateArea.ShowDialog() == DialogResult.OK)
                RefreshData();
        }
        #endregion

        #region btnQuitReasonAdd_Click�˲�ԭ������Ӱ�ť�ĵ����¼�
        /// <summary>
        /// �˲�ԭ������Ӱ�ť�ĵ����¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitReasonAdd_Click(object sender, EventArgs e)
        {
            frmPublicOperateArea myfrmPublicOperateArea = new frmPublicOperateArea(VariedEnum.ItemType.BackResult);
            if (myfrmPublicOperateArea.ShowDialog() == DialogResult.OK)
                RefreshData();
        }
        #endregion

        #region btnWorkStatusAdd_Click ��̨ʹ��״̬����Ӱ�ť�ĵ����¼�
        /// <summary>
        /// ��̨ʹ��״̬�а�ť�ĵ����¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWorkStatusAdd_Click(object sender, EventArgs e)
        {
            frmPublicOperateArea myfrmPublicOperateArea = new frmPublicOperateArea(VariedEnum.ItemType.WorkStatus);
            if (myfrmPublicOperateArea.ShowDialog() == DialogResult.OK)
                RefreshData();
        }
        #endregion

        #region btnRoomFloorAdd_Click Ա������״̬����Ӱ�ť�ĵ����¼�
        /// <summary>
        /// ���������а�ť�ĵ����¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRoomFloorAdd_Click(object sender, EventArgs e)
        {
            frmPublicOperateArea myfrmPublicOperateArea = new frmPublicOperateArea(VariedEnum.ItemType.RoomFloor);
            if (myfrmPublicOperateArea.ShowDialog() == DialogResult.OK)
                RefreshData();
        }
        #endregion

        #region btnPayTypeAdd_Click ֧����ʽ�е���Ӱ�ť�ĵ����¼�
        /// <summary>
        /// ֧����ʽ�е���Ӱ�ť�ĵ����¼�
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnPayTypeAdd_Click(object sender, EventArgs e)
        {
            frmPublicOperateArea myfrmPublicOperateArea = new frmPublicOperateArea(VariedEnum.ItemType.PayType);
            if (myfrmPublicOperateArea.ShowDialog() == DialogResult.OK)
                RefreshData();
        }
        #endregion



        //***************************ɾ����ť�ĵ����¼�*************************************//


        #region btnDishTypeDele_Click ��Ʒ�����ɾ����ť�ĵ����¼�
        /// <summary>
        /// ��Ʒ�����ɾ����ť�ĵ����¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDishTypeDele_Click(object sender, EventArgs e)
        {
            if (this.gridViewDishType.SelectedRowsCount <= 0)
            {
                XtraMessageBox.Show("����ѡ��Ҫɾ������", "����Υ��",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string tempID = this.gridViewDishType.GetFocusedRowCellValue("ID").ToString();
            DialogResult tempDialogResult = XtraMessageBox.Show("���Ϊ��" + tempID + "����Ŀ��Ϣ",
                "ȷ��ɾ��", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == tempDialogResult)
            {
                VariedEnum.OperatorStatus EnOperatorStatus;
                try
                {
                    EnOperatorStatus = myBUCMS_ItemDetail.Delete(tempID);
                    if (ClassAssist.CommonOperator.HandleOperatorEnum("ɾ��", EnOperatorStatus))
                    {
                        BUT_SysLog.InsertSysLog(VariedEnum.LogType.ϵͳ�¼�, frmAssist.frmLogin.SysUser.UserID,
                            "�ɹ�ɾ���˱��Ϊ��" + tempID + "����Ŀ��Ϣ");
                        LoadDishType();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("��ȷ����������û������ʹ�ú�����", "ɾ��ʧ��",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        #endregion

        #region btnDishTasteDele_Click ��Ʒ��ζ��ɾ����ť�ĵ����¼�
        /// <summary>
        /// ��Ʒ��ζ��ɾ����ť�ĵ����¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDishTasteDele_Click(object sender, EventArgs e)
        {
            if (this.gridViewDishTaste.SelectedRowsCount <= 0)
            {
                XtraMessageBox.Show("����ѡ��Ҫɾ������", "����Υ��",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string tempID = this.gridViewDishTaste.GetFocusedRowCellValue("ID").ToString();
            DialogResult tempDialogResult = XtraMessageBox.Show("���Ϊ��" + tempID + "����Ŀ��Ϣ",
                "ȷ��ɾ��", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == tempDialogResult)
            {
                VariedEnum.OperatorStatus EnOperatorStatus;
                try
                {
                    EnOperatorStatus = myBUCMS_ItemDetail.Delete(tempID);
                    if (ClassAssist.CommonOperator.HandleOperatorEnum("ɾ��", EnOperatorStatus))
                    {
                        BUT_SysLog.InsertSysLog(VariedEnum.LogType.ϵͳ�¼�, frmAssist.frmLogin.SysUser.UserID,
                            "�ɹ�ɾ���˱��Ϊ��" + tempID + "����Ŀ��Ϣ");
                        RefreshData();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("��ȷ����������û������ʹ�ú�����", "ɾ��ʧ��",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        #endregion

        #region btnQuitReasonDele_Click �˲�ԭ����ɾ����ť�ĵ����¼�
        /// <summary>
        /// �˲�ԭ����ɾ����ť�ĵ����¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitReasonDele_Click(object sender, EventArgs e)
        {
            if (this.gridViewQuitReason.SelectedRowsCount <= 0)
            {
                XtraMessageBox.Show("����ѡ��Ҫɾ������", "����Υ��",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string tempID = this.gridViewQuitReason.GetFocusedRowCellValue("ID").ToString();
            DialogResult tempDialogResult = XtraMessageBox.Show("���Ϊ��" + tempID + "����Ŀ��Ϣ",
                "ȷ��ɾ��", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == tempDialogResult)
            {
                VariedEnum.OperatorStatus EnOperatorStatus;
                try
                {
                    EnOperatorStatus = myBUCMS_ItemDetail.Delete(tempID);
                    if (ClassAssist.CommonOperator.HandleOperatorEnum("ɾ��", EnOperatorStatus))
                    {
                        BUT_SysLog.InsertSysLog(VariedEnum.LogType.ϵͳ�¼�, frmAssist.frmLogin.SysUser.UserID,
                            "�ɹ�ɾ���˱��Ϊ��" + tempID + "����Ŀ��Ϣ");
                        RefreshData();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("��ȷ����������û������ʹ�ú�����", "ɾ��ʧ��",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        #endregion

        #region btnWorkStatusDele_Click ����״̬��ɾ����ť�ĵ����¼�
        /// <summary>
        /// ����״̬��ɾ����ť�ĵ����¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWorkStatusDele_Click(object sender, EventArgs e)
        {
            if (this.gridViewStaffWorkStatus.SelectedRowsCount <= 0)
            {
                XtraMessageBox.Show("����ѡ��Ҫɾ������", "����Υ��",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string tempID = this.gridViewStaffWorkStatus.GetFocusedRowCellValue("ID").ToString();
            DialogResult tempDialogResult = XtraMessageBox.Show("���Ϊ��" + tempID + "����Ŀ��Ϣ",
                "ȷ��ɾ��", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == tempDialogResult)
            {
                VariedEnum.OperatorStatus EnOperatorStatus;
                try
                {
                    EnOperatorStatus = myBUCMS_ItemDetail.Delete(tempID);
                    if (ClassAssist.CommonOperator.HandleOperatorEnum("ɾ��", EnOperatorStatus))
                    {
                        BUT_SysLog.InsertSysLog(VariedEnum.LogType.ϵͳ�¼�, frmAssist.frmLogin.SysUser.UserID,
                            "�ɹ�ɾ���˱��Ϊ��" + tempID + "����Ŀ��Ϣ");
                        RefreshData();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("��ȷ����������û������ʹ�ú�����", "ɾ��ʧ��",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        #endregion

        #region btnRoomFloorDele_Click ����¥����ɾ����ť�ĵ����¼�
        /// <summary>
        /// ����¥����ɾ����ť�ĵ����¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRoomFloorDele_Click(object sender, EventArgs e)
        {
            if (this.gridViewRoomFloor.SelectedRowsCount <= 0)
            {
                XtraMessageBox.Show("����ѡ��Ҫɾ������", "����Υ��",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string tempID = this.gridViewRoomFloor.GetFocusedRowCellValue("ID").ToString();
            DialogResult tempDialogResult = XtraMessageBox.Show("���Ϊ��" + tempID + "����Ŀ��Ϣ",
                "ȷ��ɾ��", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == tempDialogResult)
            {
                VariedEnum.OperatorStatus EnOperatorStatus;
                try
                {
                    EnOperatorStatus = myBUCMS_ItemDetail.Delete(tempID);
                    if (ClassAssist.CommonOperator.HandleOperatorEnum("ɾ��", EnOperatorStatus))
                    {
                        BUT_SysLog.InsertSysLog(VariedEnum.LogType.ϵͳ�¼�, frmAssist.frmLogin.SysUser.UserID,
                            "�ɹ�ɾ���˱��Ϊ��" + tempID + "����Ŀ��Ϣ");
                        RefreshData();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("��ȷ����������û������ʹ�ú�����", "ɾ��ʧ��",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        #endregion

        #region btnPayTypeDele_Click ֧����ʽ��ɾ����ť�ĵ����¼�
        /// <summary>
        /// ֧����ʽ��ɾ����ť�ĵ����¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPayTypeDele_Click(object sender, EventArgs e)
        {
            if (this.gridViewPayType.SelectedRowsCount <= 0)
            {
                XtraMessageBox.Show("����ѡ��Ҫɾ������", "����Υ��",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string tempID = this.gridViewPayType.GetFocusedRowCellValue("ID").ToString();
            DialogResult tempDialogResult = XtraMessageBox.Show("���Ϊ��" + tempID + "����Ŀ��Ϣ",
                "ȷ��ɾ��", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == tempDialogResult)
            {
                VariedEnum.OperatorStatus EnOperatorStatus;
                try
                {
                    EnOperatorStatus = myBUCMS_ItemDetail.Delete(tempID);
                    if (ClassAssist.CommonOperator.HandleOperatorEnum("ɾ��", EnOperatorStatus))
                    {
                        BUT_SysLog.InsertSysLog(VariedEnum.LogType.ϵͳ�¼�, frmAssist.frmLogin.SysUser.UserID,
                            "�ɹ�ɾ���˱��Ϊ��" + tempID + "����Ŀ��Ϣ");
                        RefreshData();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("��ȷ����������û������ʹ�ú�����", "ɾ��ʧ��",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        #endregion




        //***************************�޸İ�ť�ĵ����¼�*************************************//

        #region btnDishTypeAlter_Click ��Ʒ������޸İ�ť�ĵ����¼�
        /// <summary>
        /// ��Ʒ������޸İ�ť�ĵ����¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDishTypeAlter_Click(object sender, EventArgs e)
        {
            if (this.gridViewDishType.SelectedRowsCount <= 0)
            {
                XtraMessageBox.Show("����ѡ��Ҫ�޸ĵ���", "����Υ��",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            tempInfo = ClassAssist.CommonOperator.GetGVSelectRowInfo(this.gridViewDishType);
            if (tempInfo != null)
            {
                frmPublicOperateArea myfrmPublicOperateArea = new frmPublicOperateArea(VariedEnum.ItemType.DishType, tempInfo);
                if (myfrmPublicOperateArea.ShowDialog() == DialogResult.Cancel)
                    RefreshData();
            }
        }

        #endregion

        #region btnDishTasteAlter_Click ��Ʒ��ζ���޸İ�ť�ĵ����¼�
        /// <summary>
        /// ��Ʒ��ζ���޸İ�ť�ĵ����¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDishTasteAlter_Click(object sender, EventArgs e)
        {
            if (this.gridViewDishTaste.SelectedRowsCount < 0)
                XtraMessageBox.Show("��ѡ��Ҫ�޸ĵ���", "����Υ��",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            tempInfo = ClassAssist.CommonOperator.GetGVSelectRowInfo(this.gridViewDishTaste);
            if (tempInfo != null)
            {
                frmPublicOperateArea myfrmPublicOperateArea = new frmPublicOperateArea(VariedEnum.ItemType.TasteType, tempInfo);
                if (myfrmPublicOperateArea.ShowDialog() == DialogResult.Cancel)
                    RefreshData();
            }

        }

        #endregion

        #region btnQuitReasonAlter_Click �˲�ԭ�����޸İ�ť�ĵ����¼�
        /// <summary>
        /// ��Ʒ�˲�ԭ�����޸İ�ť�ĵ����¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitReasonAlter_Click(object sender, EventArgs e)
        {
            if (this.gridViewQuitReason.SelectedRowsCount < 0)
            {
                XtraMessageBox.Show("��ѡ��Ҫ�޸ĵ���", "����Υ��",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            tempInfo = ClassAssist.CommonOperator.GetGVSelectRowInfo(this.gridViewQuitReason);
            if (tempInfo != null)
            {
                frmPublicOperateArea myfrmPublicOperateArea = new frmPublicOperateArea(VariedEnum.ItemType.BackResult, tempInfo);
                if (myfrmPublicOperateArea.ShowDialog() == DialogResult.Cancel)
                    RefreshData();
            }
        }

        #endregion

        #region btnWorkStatusAlter_Click Ա������״̬���޸İ�ť�ĵ����¼�
        /// <summary>
        /// Ա������״̬���޸İ�ť�ĵ����¼�
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnWorkStatusAlter_Click(object sender, EventArgs e)
        {
            if (this.gridViewStaffWorkStatus.SelectedRowsCount < 0)
            {
                XtraMessageBox.Show("��ѡ��Ҫ�޸ĵ���", "����Υ��",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            tempInfo = ClassAssist.CommonOperator.GetGVSelectRowInfo(this.gridViewStaffWorkStatus);
            if (tempInfo != null)
            {
                frmPublicOperateArea myfrmPublicOperateArea = new frmPublicOperateArea(VariedEnum.ItemType.WorkStatus, tempInfo);
                if (myfrmPublicOperateArea.ShowDialog() == DialogResult.Cancel)
                    RefreshData();
            }
        }
        #endregion

        #region btnRoomFloorAlter_Click ����¥�����޸İ�ť�ĵ����¼�
        /// <summary>
        /// ����¥�����޸İ�ť�ĵ����¼�
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnRoomFloorAlter_Click(object sender, EventArgs e)
        {
            if (this.gridViewRoomFloor.SelectedRowsCount < 0)
            {
                XtraMessageBox.Show("��ѡ��Ҫ�޸ĵ���", "����Υ��",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            tempInfo = ClassAssist.CommonOperator.GetGVSelectRowInfo(this.gridViewRoomFloor);
            if (tempInfo != null)
            {
                frmPublicOperateArea myfrmPublicOperateArea = new frmPublicOperateArea(VariedEnum.ItemType.RoomFloor, tempInfo);
                if (myfrmPublicOperateArea.ShowDialog() == DialogResult.Cancel)
                    RefreshData();
            }
        }
        #endregion

        #region btnPayTypeAlter_Click ֧����ʽ���޸İ�ť�ĵ����¼�
        /// <summary>
        /// ֧����ʽ���޸İ�ť�ĵ����¼�
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnPayTypeAlter_Click(object sender, EventArgs e)
        {
            if (this.gridViewPayType.SelectedRowsCount < 0)
            {
                XtraMessageBox.Show("��ѡ��Ҫ�޸ĵ���", "����Υ��",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            tempInfo = ClassAssist.CommonOperator.GetGVSelectRowInfo(this.gridViewPayType);
            if (tempInfo != null)
            {
                frmPublicOperateArea myfrmPublicOperateArea = new frmPublicOperateArea(VariedEnum.ItemType.PayType, tempInfo);
                if (myfrmPublicOperateArea.ShowDialog() == DialogResult.Cancel)
                    RefreshData();
            }
        }
        #endregion


        //***************************���ذ�ť�ĵ����¼�*************************************//


        #region btnDishTypeBack_Click ��Ʒ����з��ذ�ť�ĵ����¼�
        /// <summary>
        /// ��Ʒ����з��ذ�ť�ĵ����¼�
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnDishTypeBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            return;
        }
        #endregion



        //***************************���õĴ���*************************************//


        #region private void AlterOtherInstall(string paramOtherInstallNum, string paramOtherInstall)�޸�����������ѡ�еļ�¼
        /// <summary>
        /// �޸�����������ѡ�еļ�¼
        /// </summary>
        /// <param name="paramOtherInstallNum"></param>
        /// <param name="paramOtherInstall"></param>
        private void AlterOtherInstall(string paramOtherInstallNum, string paramOtherInstall)
        {
            int returnValue5 = myBUCMS_ItemDetail.RAlterOtherInstall(paramOtherInstallNum, paramOtherInstall);
            if (returnValue5 > 0)
            {
                MessageBox.Show("�޸ĳɹ���");
                return;
            }
        }
        #endregion

        #region //private void BindComoboxEdit() ��ComoBoxEdit�������ݰ�
        /// <summary>
        /// ��cmbeDishType���ݰ�
        /// </summary>
        //private void BindComoboxEdit()
        //{
        //    myDT = myBUCMS_ItemDetail.GetCMBEInfo();
        //    this.cmbeDishType.Properties.NullText = "��ѡ��";

        //    for (int i = 0; i < myDT.Rows.Count; i++)
        //    {
        //        if (Convert.ToInt32(myDT.Rows[i]["TypeID"])==1)
        //        {
        //            cmbeDishType.Properties.Items.Add(myDT.Rows[i]["Name"].ToString());
        //        }
        //        else
        //        {
        //            return;
        //        }
        //        switch (Convert.ToInt32(myDT.Rows[i]["TypeID"]))
        //        {
        //            case 1:
        //                cmbeDishType.Properties.Items.Add(myDT.Rows[i]["Name"].ToString());
        //                break;
        //            case 2:
        //                cmbeDishTaste.Properties.Items.Add(myDT.Rows[i]["Name"].ToString());
        //                break;
        //            case 3:
        //                cmbeQuitReason.Properties.Items.Add(myDT.Rows[i]["Name"].ToString());
        //                break;
        //            case 4:
        //                cmbeBuffetState.Properties.Items.Add(myDT.Rows[i]["Name"].ToString());
        //                break;
        //            case 5:
        //                cmbeOtherSetup.Properties.Items.Add(myDT.Rows[i]["Name"].ToString());
        //                break;
        //            default:
        //                return;
        //        }
        //    }
        //}
        #endregion

        #region private void DeleBuffState(string paramBuffStateNum)ɾ����̨ʹ��״̬��ѡ�еļ�¼
        ///// <summary>
        ///// ɾ����̨ʹ��״̬��ѡ�еļ�¼
        ///// </summary>
        ///// <param name="paramBuffStateNum"></param>
        ///// <param name="paramBuffState"></param>
        //private void DeleBuffState(string paramBuffStateNum)
        //{
        //    int returnValue4 = myBUCMS_ItemDetail.RDeleBuffState(paramBuffStateNum);
        //    if (returnValue4 > 0)
        //    {
        //        MessageBox.Show("ɾ���ɹ���");
        //        return;
        //    }
        //}
        #endregion

        #region btnBuffStateDele_Click ����������ɾ����ť�ĵ����¼�
        ///// <summary>
        ///// ����������ɾ����ť�ĵ����¼�
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        private void btnOtherInstallDele_Click(object sender, EventArgs e)
        {
            //    string paramOtherInstallNum = this.txtOtherInstallNum.Text.Trim();
            //    if (paramOtherInstallNum.Length == 0)
            //    {
            //        MessageBox.Show("��ѡ��Ҫɾ���ļ�¼��");
            //    }
            //    else
            //    {
            //        //����Ӹ����壬��ʾȷ��Ҫɾ��������¼�𣿷�Ļ�ȡ��ɾ��
            //        DeleOtherInstall(paramOtherInstallNum);
            //    }
            //    LoadOtherInstall();
        }
        #endregion

        #region btnBuffStateAlter_Click ��̨ʹ��״̬���޸İ�ť�ĵ����¼�
        /// <summary>
        /// ��̨ʹ��״̬���޸İ�ť�ĵ����¼�
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        private void btnBuffStateAlter_Click(object sender, EventArgs e)
        {
            //    string paramBuffStateNum = this.txtBuffStateNum.Text.Trim();
            //    string paramBuffState = this.txtBuffState.Text.Trim();
            //    if (paramBuffStateNum.Length == 0 || paramBuffState.Length == 0)
            //    {
            //        MessageBox.Show("��ѡ��Ҫ�޸ĵļ�¼��");
            //    }
            //    else
            //    {
            //        AlterBuffState(paramBuffStateNum, paramBuffState);
            //    }
            //    LoadBuffState();
        }
        #endregion

        private void btnDishTypeOut_Click(object sender, EventArgs e)
        {
            try
            {
                DevExpress.XtraEditors.SimpleButton tempBtn = (DevExpress.XtraEditors.SimpleButton)sender;
                if (tempBtn == null)
                    return;
                string tempItem = tempBtn.Tag.ToString();
                foreach (Control tempControl in this.tbctrl.SelectedTabPage.Controls)
                {
                    if (tempControl.GetType() == typeof(DevExpress.XtraGrid.GridControl))
                    {
                        DevExpress.XtraGrid.GridControl tempGridControl = (DevExpress.XtraGrid.GridControl)tempControl;
                        DevExpress.XtraGrid.Views.Grid.GridView tempGrid = tempGridControl.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
                        ClassAssist.DataOperator.DataOut(tempGrid, tempItem);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }

        private void btnDishTypePrint_Click(object sender, EventArgs e)
        {
            try
            {
                DevExpress.XtraEditors.SimpleButton tempBtn = (DevExpress.XtraEditors.SimpleButton)sender;
                if (tempBtn == null)
                    return;
                string tempItem = tempBtn.Tag.ToString();
                foreach (Control tempControl in this.tbctrl.SelectedTabPage.Controls)
                {
                    if (tempControl.GetType() == typeof(DevExpress.XtraGrid.GridControl))
                    {
                        DevExpress.XtraGrid.GridControl tempGridControl = (DevExpress.XtraGrid.GridControl)tempControl;
                        ClassAssist.DataOperator.DataPrint(tempGridControl, tempItem,null);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }

        #region private void AlterBuffState(string paramBuffStateNum, string paramBuffState)�޸Ĳ�̨ʹ��״̬��ѡ�еļ�¼
        ///// <summary>
        ///// �޸Ĳ�̨ʹ��״̬��ѡ�еļ�¼
        ///// </summary>
        ///// <param name="paramBuffStateNum"></param>
        ///// <param name="paramBuffState"></param>
        //private void AlterBuffState(string paramBuffStateNum, string paramBuffState)
        //{
        //    int returnValue4 = myBUCMS_ItemDetail.RAlterBuffState(paramBuffStateNum, paramBuffState);
        //    if (returnValue4 > 0)
        //    {
        //        MessageBox.Show("�޸ĳɹ���");
        //        return;
        //    }
        //}
        #endregion
    }
}