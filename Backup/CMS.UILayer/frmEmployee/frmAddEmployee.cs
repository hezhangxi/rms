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
using CMS.UILayer.frmAssist;
using System.IO;
using CMS.UILayer.ClassAssist;

namespace CMS.UILayer.frmEmployee
{
    public partial class frmAddEmployee : DevExpress.XtraEditors.XtraForm
    {
        #region ��������
        ModelCMS_Employee myModelCMS_Employee = new ModelCMS_Employee();
        BUCMS_Employee myBUCMS_Employee = new BUCMS_Employee();
        BUCMS_DPInfo myBUCMS_DPInfo = new BUCMS_DPInfo();
        DataTable myDataTable = new DataTable();
        VariedEnum.OperatorStatus EnOperatorStatus;
        private static string paramPhName = "Default.jpg";
        private static string paramURL = string.Empty;
        private string paramValue = string.Empty;
        #endregion

        public frmAddEmployee()
        {
            InitializeComponent();
        }

        public frmAddEmployee(string paramID)
        {
            InitializeComponent();
            this.Text = "�޸�Ա����Ϣ";
            this.btnSave.Text = "��  ��";
            this.lblPerson.Text = "�޸���:";
            this.lblDate.Text = "�޸�ʱ��:";
            paramValue = paramID;
            BindEmployee(paramValue);
        }
        /// <summary>
        /// ���֮���ʼ���ؼ�ֵ
        /// </summary>
        private void ClearText()
        {
            this.txtName.Text = string.Empty;
            this.txtSex.SelectedIndex = 0;
            this.txtDegree.SelectedIndex = 0;
            this.txtAge.Text = "1";
            this.txtBirthDate.DateTime = Convert.ToDateTime("1980-01-01");
            this.txtEntryDate.DateTime = Convert.ToDateTime("1980-01-01");
            this.txtIDCardNum.Text = string.Empty;
            this.txtTelPhone.Text = string.Empty;
            this.txtAddress.Text = "����";
            this.txtCreatePerson.Text = frmLogin.SysUser.UserName;
            this.txtCreateDate.Text = DateTime.Now.ToString();
            this.txtInfoNote.Text = "����";
        }

        /// <summary>
        /// �����޸�֮��ҳ����ذ��ı����ֵ
        /// </summary>
        /// <param name="paraEmpValue"></param>
        private void BindEmployee(string paraEmpValue)
        {
            DataTable tempDataTable = myBUCMS_Employee.GetOrder(false, "ID", paraEmpValue, false);
            for (int i = 0; i < tempDataTable.Rows.Count; i++)
            {
                if (tempDataTable.Rows[i]["ID"].ToString() == paraEmpValue)
                {
                    this.txtName.Text = tempDataTable.Rows[i]["Name"].ToString();
                    this.txtSex.Text = tempDataTable.Rows[i]["Sex"].ToString();
                    this.txtDegree.Text = tempDataTable.Rows[i]["Degree"].ToString(); ;
                    this.txtAge.Text = tempDataTable.Rows[i]["Age"].ToString();
                    this.txtBirthDate.DateTime = Convert.ToDateTime(tempDataTable.Rows[i]["BirthDate"].ToString());
                    this.txtPosID.EditValue = tempDataTable.Rows[i]["PosID"];
                    this.txtEntryDate.DateTime = Convert.ToDateTime(tempDataTable.Rows[i]["EntryDate"].ToString());
                    this.txtIDCardNum.Text = tempDataTable.Rows[i]["IDCardNum"].ToString();
                    this.txtTelPhone.Text = tempDataTable.Rows[i]["TelPhone"].ToString();
                    this.txtAddress.Text = tempDataTable.Rows[i]["Address"].ToString();
                    this.txtCreatePerson.Text = tempDataTable.Rows[i]["CreatePerson"].ToString();
                    this.txtCreateDate.Text = tempDataTable.Rows[i]["CreateDate"].ToString();
                    this.txtInfoNote.Text = tempDataTable.Rows[i]["InfoNote"].ToString();

                    //��ͼƬ
                    string tempImagePath = Application.StartupPath + "\\Employee\\" +tempDataTable.Rows[i]["Photo"].ToString();
                    Image tempImage = Image.FromFile(tempImagePath);
                    this.ptePhoto.Image = tempImage;
                   
                    return;
                }
            }

        }

        /// <summary>
        /// Handles the Load event of the frmAddEmployee control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// �����ˣ������
        /// ����ʱ�䣺2013-02-06
        private void frmAddEmployee_Load(object sender, EventArgs e)
        {
            BindComBoxAndDateTime();
            BindPosIDValue();
            if (paramValue.Length ==0)
            {
                LoadDefaultImage(); 
            }
           
        }

        /// <summary>
        /// Loads the default image.
        /// </summary>
        /// �����ˣ������
        /// ����ʱ�䣺2013-02-06
        private void LoadDefaultImage()
        {
            string tempImagePath = Application.StartupPath + "\\Employee\\" + "Default.JPG";
            Image tempImage = Image.FromFile(tempImagePath);
            this.ptePhoto.Image = tempImage;
        }

        /// <summary>
        /// Binds the pos ID value.
        /// </summary>
        /// �����ˣ������
        /// ����ʱ�䣺2013-02-06
        private void BindPosIDValue()
        {
            myDataTable = myBUCMS_DPInfo.GetAllPos();
            this.txtPosID.Properties.DataSource = myDataTable;
            this.txtPosID.ItemIndex = 0;

            //CommonOperator.DataBindingLookUpEdit(this.txtPosID, myDataTable, "Name", "ID", true);
        }

        /// <summary>
        /// ������ؼ�
        /// </summary>
        private void BindComBoxAndDateTime()
        {
            //for (int i = 0; i < 100; i++)
            //{
            //    txtAge.Properties.Items.Add(i);
            //}
            this.txtCreatePerson.Text = frmLogin.SysUser.UserName;
            this.txtCreateDate.Text = DateTime.Now.ToString();
        }

        /// <summary>
        /// ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Ա����������Ϊ�գ�");
                txtName.Focus();
                txtName.SelectAll();
            }
            else if (txtIDCardNum.Text.Trim().Length == 0 || txtIDCardNum.Text == "0")
            {
                XtraMessageBox.Show("���������֤��");
                txtIDCardNum.Focus();
                txtIDCardNum.SelectAll();
            }
            else if (txtTelPhone.Text.Trim().Length == 0 || txtTelPhone.Text == "0")
            {
                XtraMessageBox.Show("��������ϵ�绰��");
                txtTelPhone.Focus();
                txtTelPhone.SelectAll();
            }
            else if (txtPosID.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("������ְλ���ƣ�");
                txtPosID.Focus();
                txtPosID.SelectAll();
            }
            else
            {
                myModelCMS_Employee = ObtainModelValue();
                if (paramValue.Length == 0)
                {
                    SaveEmployee(myModelCMS_Employee);
                }
                else
                {
                    UpdateEmployee(myModelCMS_Employee);
                }

            }
        }

        /// <summary>
        /// �޸�Ա����Ϣ
        /// </summary>
        private void UpdateEmployee(ModelCMS_Employee myModelCMS_Employee)
        {
            myDataTable = myBUCMS_Employee.GetOrder(false, string.Empty, string.Empty, false);
            try
            {
                #region
                //foreach (DataRow myDataRow in myDataTable.Rows)
                //{
                //    if (myDataRow["IDCardNum"].ToString() == myModelCMS_Employee.IDCardNum)
                //    {
                //        XtraMessageBox.Show("��Ա�������֤���Ѵ��ڣ���������룡");
                //        this.txtIDCardNum.Text = "";
                //        this.txtIDCardNum.Focus();
                //        this.txtIDCardNum.SelectAll();
                //        return;
                //    }
                //    if (myDataRow["TelPhone"].ToString() == myModelCMS_Employee.TelPhone)
                //    {
                //        XtraMessageBox.Show("����ĵ绰�����Ѵ��ڣ���������룡");
                //        this.txtTelPhone.Text = "";
                //        this.txtTelPhone.Focus();
                //        this.txtTelPhone.SelectAll();
                //        return;
                //    }
                //}
                #endregion
                EnOperatorStatus = myBUCMS_Employee.Update(myModelCMS_Employee);
                if (ClassAssist.CommonOperator.HandleOperatorEnum("Ա����Ϣ�޸�", EnOperatorStatus))
                {
                    BUT_SysLog.InsertSysLog(VariedEnum.LogType.���ݲ���, frmAssist.frmLogin.SysUser.UserID, "�ɹ��޸���Ա����Ϣ");
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ����õ�Ա����Ϣ��ӵ����ݿ���
        /// </summary>
        private void SaveEmployee(ModelCMS_Employee myModelCMS_Employee)
        {
            myDataTable = myBUCMS_Employee.GetOrder(false, string.Empty, string.Empty, false);
            try
            {
                foreach (DataRow myDataRow in myDataTable.Rows)
                {
                    if (myDataRow["IDCardNum"].ToString() == myModelCMS_Employee.IDCardNum)
                    {
                        XtraMessageBox.Show("Ա�������Ѵ��ڣ���������룡");
                        this.txtName.Text = "";
                        this.txtName.Focus();
                        this.txtName.SelectAll();
                        return;
                    }
                    if (myDataRow["IDCardNum"].ToString() == myModelCMS_Employee.IDCardNum)
                    {
                        XtraMessageBox.Show("��Ա�������֤���Ѵ��ڣ���������룡");
                        this.txtIDCardNum.Text = "";
                        this.txtIDCardNum.Focus();
                        this.txtIDCardNum.SelectAll();
                        return;
                    }
                    if (myDataRow["TelPhone"].ToString() == myModelCMS_Employee.TelPhone)
                    {
                        XtraMessageBox.Show("����ĵ绰�����Ѵ��ڣ���������룡");
                        this.txtTelPhone.Text = "";
                        this.txtTelPhone.Focus();
                        this.txtTelPhone.SelectAll();
                        return;
                    }
                }
                EnOperatorStatus = myBUCMS_Employee.Insert(myModelCMS_Employee);
                if (ClassAssist.CommonOperator.HandleOperatorEnum("Ա����Ϣ���", EnOperatorStatus))
                {
                    ClearText();
                    frmAddEmployee_Load(null, null);
                    BUT_SysLog.InsertSysLog(VariedEnum.LogType.���ݲ���, frmAssist.frmLogin.SysUser.UserID, "�ɹ������Ա����Ϣ");
                    //this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// �������
        /// </summary>
        private ModelCMS_Employee ObtainModelValue()
        {
            myModelCMS_Employee.Name = this.txtName.Text.Trim();
            myModelCMS_Employee.Sex = this.txtSex.Text.Trim();
            myModelCMS_Employee.Age = Convert.ToInt32(this.txtAge.Text.Trim());
            myModelCMS_Employee.Degree = this.txtDegree.Text.Trim();
            myModelCMS_Employee.BirthDate = Convert.ToDateTime(this.txtBirthDate.Text.Trim());
            myModelCMS_Employee.PosID = Convert.ToInt32(this.txtPosID.EditValue);
            myModelCMS_Employee.EntryDate = Convert.ToDateTime(this.txtEntryDate.Text.Trim());
            myModelCMS_Employee.TelPhone = this.txtTelPhone.Text.Trim();
            myModelCMS_Employee.IDCardNum = this.txtIDCardNum.Text.Trim();
            myModelCMS_Employee.StateID = VariedDefault.DefaultWorkState;
            myModelCMS_Employee.Photo = paramPhName;
            myModelCMS_Employee.Address = this.txtAddress.Text.Trim();
            myModelCMS_Employee.InfoNote = this.txtInfoNote.Text.Trim();
            if (paramValue.Length == 0)
            {
                myModelCMS_Employee.CreatePerson = frmLogin.SysUser.UserName;
                myModelCMS_Employee.CreateDate = Convert.ToDateTime(this.txtCreateDate.Text.Trim());
            }
            else
            {
                myModelCMS_Employee.ID = Convert.ToInt32(paramValue);
                myModelCMS_Employee.ModifyPerson = frmLogin.SysUser.UserName;
                myModelCMS_Employee.ModifyDate = Convert.ToDateTime(this.txtCreateDate.Text.Trim());
            }
            return myModelCMS_Employee;
        }

        private void labAddPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog myOpenFileDialog = new OpenFileDialog();
            myOpenFileDialog.Filter = "files (*.jpg)|*.jpg|files(*.gif)|*.gif|files(*.png)|*.png|All files(*.*)|*.*";
            if (myOpenFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.ptePhoto.Image = Image.FromFile(myOpenFileDialog.FileName);
                paramURL = myOpenFileDialog.FileName;
                paramPhName = myOpenFileDialog.SafeFileName;
                //��ͼƬ���浽debug��
                //string paramImgPath = Application.StartupPath + "\\Employee\\" + paramPhName;
                string paramImgPath = myOpenFileDialog.FileName;
                //openFileDialog openFileDialog1 = new openFileDialog();
                File.Copy(paramImgPath, Application.StartupPath + "\\Employee\\"+paramPhName);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }
    }
}