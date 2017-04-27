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
        #region 变量定义
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
            this.Text = "修改员工信息";
            this.btnSave.Text = "修  改";
            this.lblPerson.Text = "修改人:";
            this.lblDate.Text = "修改时间:";
            paramValue = paramID;
            BindEmployee(paramValue);
        }
        /// <summary>
        /// 添加之后初始化控件值
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
            this.txtAddress.Text = "暂无";
            this.txtCreatePerson.Text = frmLogin.SysUser.UserName;
            this.txtCreateDate.Text = DateTime.Now.ToString();
            this.txtInfoNote.Text = "暂无";
        }

        /// <summary>
        /// 单击修改之后，页面加载绑定文本框的值
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

                    //绑定图片
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
        /// 整理人：桂书丛
        /// 整理时间：2013-02-06
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
        /// 整理人：桂书丛
        /// 整理时间：2013-02-06
        private void LoadDefaultImage()
        {
            string tempImagePath = Application.StartupPath + "\\Employee\\" + "Default.JPG";
            Image tempImage = Image.FromFile(tempImagePath);
            this.ptePhoto.Image = tempImage;
        }

        /// <summary>
        /// Binds the pos ID value.
        /// </summary>
        /// 整理人：桂书丛
        /// 整理时间：2013-02-06
        private void BindPosIDValue()
        {
            myDataTable = myBUCMS_DPInfo.GetAllPos();
            this.txtPosID.Properties.DataSource = myDataTable;
            this.txtPosID.ItemIndex = 0;

            //CommonOperator.DataBindingLookUpEdit(this.txtPosID, myDataTable, "Name", "ID", true);
        }

        /// <summary>
        /// 绑定年龄控件
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
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("员工姓名不能为空！");
                txtName.Focus();
                txtName.SelectAll();
            }
            else if (txtIDCardNum.Text.Trim().Length == 0 || txtIDCardNum.Text == "0")
            {
                XtraMessageBox.Show("请输入身份证！");
                txtIDCardNum.Focus();
                txtIDCardNum.SelectAll();
            }
            else if (txtTelPhone.Text.Trim().Length == 0 || txtTelPhone.Text == "0")
            {
                XtraMessageBox.Show("请输入联系电话！");
                txtTelPhone.Focus();
                txtTelPhone.SelectAll();
            }
            else if (txtPosID.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("请输入职位名称！");
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
        /// 修改员工信息
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
                //        XtraMessageBox.Show("该员工的身份证号已存在，请从新输入！");
                //        this.txtIDCardNum.Text = "";
                //        this.txtIDCardNum.Focus();
                //        this.txtIDCardNum.SelectAll();
                //        return;
                //    }
                //    if (myDataRow["TelPhone"].ToString() == myModelCMS_Employee.TelPhone)
                //    {
                //        XtraMessageBox.Show("输入的电话号码已存在，请从新输入！");
                //        this.txtTelPhone.Text = "";
                //        this.txtTelPhone.Focus();
                //        this.txtTelPhone.SelectAll();
                //        return;
                //    }
                //}
                #endregion
                EnOperatorStatus = myBUCMS_Employee.Update(myModelCMS_Employee);
                if (ClassAssist.CommonOperator.HandleOperatorEnum("员工信息修改", EnOperatorStatus))
                {
                    BUT_SysLog.InsertSysLog(VariedEnum.LogType.数据操作, frmAssist.frmLogin.SysUser.UserID, "成功修改了员工信息");
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 将获得的员工信息添加到数据库中
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
                        XtraMessageBox.Show("员工姓名已存在，请从新输入！");
                        this.txtName.Text = "";
                        this.txtName.Focus();
                        this.txtName.SelectAll();
                        return;
                    }
                    if (myDataRow["IDCardNum"].ToString() == myModelCMS_Employee.IDCardNum)
                    {
                        XtraMessageBox.Show("该员工的身份证号已存在，请从新输入！");
                        this.txtIDCardNum.Text = "";
                        this.txtIDCardNum.Focus();
                        this.txtIDCardNum.SelectAll();
                        return;
                    }
                    if (myDataRow["TelPhone"].ToString() == myModelCMS_Employee.TelPhone)
                    {
                        XtraMessageBox.Show("输入的电话号码已存在，请从新输入！");
                        this.txtTelPhone.Text = "";
                        this.txtTelPhone.Focus();
                        this.txtTelPhone.SelectAll();
                        return;
                    }
                }
                EnOperatorStatus = myBUCMS_Employee.Insert(myModelCMS_Employee);
                if (ClassAssist.CommonOperator.HandleOperatorEnum("员工信息添加", EnOperatorStatus))
                {
                    ClearText();
                    frmAddEmployee_Load(null, null);
                    BUT_SysLog.InsertSysLog(VariedEnum.LogType.数据操作, frmAssist.frmLogin.SysUser.UserID, "成功添加了员工信息");
                    //this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 获得数据
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
                //将图片保存到debug中
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