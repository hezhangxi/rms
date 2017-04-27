
//******************************************************************************************************
//** Copyright (C) 2010-2013 �ش��������ѧԺ
//** �����ˣ������
//** ������\�ļ�����frmUserManagement
//** �๦�ܣ��û�������
//** �� ������������ϵͳ�û�������
//** �������ڣ�2013-1-15
//** �޸��ˣ������
//** �޸����ڣ�2013-1-15
//** �������ڣ�2013-1-15
//******************************************************************************************************

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
namespace CMS.UILayer.frmSysSet
{
    public partial class frmUserManagement : DevExpress.XtraEditors.XtraForm
    {
        private BUT_User myBUUser = new BUT_User();

        /// <summary>
        /// Initializes a new instance of the <see cref="frmUserManagement"/> class.
        /// </summary>
        /// �����ˣ������
        /// ����ʱ�䣺2013-03-06
        public frmUserManagement()
        {
            InitializeComponent();
            InitializeControls();
        }

        #region private void InitializeControls() ��ʼ���ؼ�
        /// <summary>
        /// ��ʼ���ؼ�
        /// </summary>
        private void InitializeControls()
        {
            DataTable myDataTable = new DataTable();
            try
            {
                myDataTable = myBUUser.GetAllUserInfo();
                this.gridControlUser.DataSource = myDataTable;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmSysSet.frmUserAdd myfrmUserAdd = new frmUserAdd();
            if (myfrmUserAdd.ShowDialog() == DialogResult.OK)
                InitializeControls();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (this.gridViewMain.SelectedRowsCount <= 0)
            {
                XtraMessageBox.Show("����ѡ��Ҫɾ������", "����Υ��",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string tempID=this.gridViewMain.GetFocusedRowCellValue("ID").ToString();
            DialogResult tempDialogResult = XtraMessageBox.Show("���Ϊ��"+ tempID + "���û�","ȷ��ɾ����",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (DialogResult.Yes == tempDialogResult)
            {
                VariedEnum.OperatorStatus EnOperatorStatus;
                try
                {
                    EnOperatorStatus = myBUUser.DeleteUser(tempID);
                    if (ClassAssist.CommonOperator.HandleOperatorEnum("ɾ��", EnOperatorStatus))
                    {
                        BUT_SysLog.InsertSysLog(VariedEnum.LogType.ϵͳ�¼�, frmAssist.frmLogin.SysUser.UserID,"�ɹ�ɾ���˱��Ϊ��"+tempID+"��ϵͳ�û���Ϣ");
                        InitializeControls();
                    }
                }
                catch
                {
                    XtraMessageBox.Show("��ȷ���������ݲ����ڱ�ʹ�ú�����", "ɾ��ʧ��",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        /// <summary>
        /// �޸��û���Ϣ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.gridViewMain.SelectedRowsCount <= 0)
            {
                XtraMessageBox.Show("����ѡ��Ҫ�޸ĵ���", "����Υ��",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            object[] tempInfo = ClassAssist.CommonOperator.GetGVSelectRowInfo(this.gridViewMain);
            if (tempInfo != null)
            {
                if (new frmCertainPWD(Convert.ToInt32(tempInfo[0])).ShowDialog() != DialogResult.OK)
                    return;
                frmUserAdd myfrmUserAdd = new frmUserAdd(tempInfo);
                if (myfrmUserAdd.ShowDialog() == DialogResult.OK)
                    InitializeControls();
            }
        }

        /// <summary>
        /// Handles the DoubleClick event of the gridControlUser control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// �����ˣ������
        /// ����ʱ�䣺2013-03-06
        private void gridControlUser_DoubleClick(object sender, EventArgs e)
        {
            btnUpdate_Click(sender,e);
        }

        /// <summary>
        /// Handles the Click event of the btnBack control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// �����ˣ������
        /// ����ʱ�䣺2013-03-06
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the btnOut control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// �����ˣ������
        /// ����ʱ�䣺2013-03-06
        private void btnOut_Click(object sender, EventArgs e)
        {
            try
            {
                ClassAssist.DataOperator.DataOut(this.gridViewMain, "ϵͳ�û���Ϣ");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the btnPrint control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// �����ˣ������
        /// ����ʱ�䣺2013-03-06
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                ClassAssist.DataOperator.DataPrint(this.gridControlUser,"ϵͳ�û���Ϣ",null);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handles the KeyDown event of the gridControlUser control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.KeyEventArgs"/> instance containing the event data.</param>
        /// �����ˣ������
        /// ����ʱ�䣺2013-03-06
        private void gridControlUser_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                btnUpdate_Click(sender, e);
        }
    }
}