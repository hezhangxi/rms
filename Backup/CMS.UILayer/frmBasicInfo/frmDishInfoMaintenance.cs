using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using CMS.BULayer;
using DevExpress.XtraEditors;

namespace CMS.UILayer.frmBasicInfo
{
    public partial class frmDishInfoMaintenance :DevExpress.XtraEditors.XtraForm
    {
        BUCMS_ItemDetail myBUCMS_ItemDetail = new BUCMS_ItemDetail();
        BUCMS_DishServer myBUCMS_DishServer=new BUCMS_DishServer();
        DataTable myDataTable = null;
        string paramDishType = string.Empty;
        string paramField = string.Empty;

        object[] tempInfo = null;
        public frmDishInfoMaintenance()
        {
            InitializeComponent();
        }

        private void frmDishInfoMaintenance_Load(object sender, EventArgs e)
        {
            BindComoboxEdit();
            paramDishType = this.cmbeDishType.Text.Trim();
            this.cmbeDishType.Properties.NullText = "请选择…";
            BindGridControl(paramField,paramDishType);
        }

        #region private void BindComoboxEdit() 对ComoBoxEdit进行数据绑定
        /// <summary>
        /// 对cmbeDishType数据绑定
        /// </summary>
        private void BindComoboxEdit()
        {
            DataTable myDT = myBUCMS_ItemDetail.GetItemByType(VariedItemType.DishType);
            for (int i = 0; i < myDT.Rows.Count; i++)
            {
                if (Convert.ToInt32(myDT.Rows[i]["TypeID"]) == 1)
                {
                    cmbeDishType.Properties.Items.Add(myDT.Rows[i]["Name"].ToString());
                }
                else
                    return;
            }
            this.cmbeDishType.Properties.Items.Insert(0, "全部");
            cmbeDishType.SelectedIndex = 0;
        }
        #endregion

        private void BindGridControl(string paramField, string paramType)
        {
            if (paramType == "全部")
                myDataTable = myBUCMS_ItemDetail.GetOrder(true,string.Empty,string.Empty,false);
            else
                myDataTable = myBUCMS_ItemDetail.GetOrder(true, paramField, paramType, false);
            if (myDataTable.Rows.Count < 0)
                return;
            else
                this.grdctrlDishInfo.DataSource = myDataTable;
        }

        private void btnDishInfoAdd_Click(object sender, EventArgs e)
        {
            frmDishInfoOperate myfrmDishInfoOperate = new frmDishInfoOperate();
            paramField = string.Empty;
            if (myfrmDishInfoOperate.ShowDialog() == DialogResult.OK)
                BindGridControl(paramField,paramDishType);
        }

        private void btnDishInfoDele_Click(object sender, EventArgs e)
        {
            if (this.gridViewDishInfo.SelectedRowsCount <= 0)
            {
                XtraMessageBox.Show("请先选择要删除(&D)的项", "操作违规",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string tempID = this.gridViewDishInfo.GetFocusedRowCellValue("编号").ToString();
            DialogResult tempDialogResult = XtraMessageBox.Show("编号为："+tempID+"的菜品信息",
                "确定删除(&D)", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == tempDialogResult)
            {
                VariedEnum.OperatorStatus EnOperatorStatus;
                try
                {
                    EnOperatorStatus = myBUCMS_DishServer.Delete(tempID);
                    if (ClassAssist.CommonOperator.HandleOperatorEnum("删除(&D)", EnOperatorStatus))
                    {
                        BUT_SysLog.InsertSysLog(VariedEnum.LogType.系统事件, frmAssist.frmLogin.SysUser.UserID,
                            "成功删除(&D)了编号为：" + tempID + "的菜品信息");
                        paramField = string.Empty;
                        BindGridControl(paramField,paramDishType);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("请确定该条数据没用正在使用后重试", "删除(&D)失败",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnDishInfoAlter_Click(object sender, EventArgs e)
        {
            if (this.gridViewDishInfo.SelectedRowsCount <= 0)
            {
                XtraMessageBox.Show("请先选择要修改(&U)的项", "操作违规",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            tempInfo = ClassAssist.CommonOperator.GetGVSelectRowInfo(this.gridViewDishInfo);
            if (tempInfo != null)
            {
                frmDishInfoOperate myfrmDishInfoOperate = new frmDishInfoOperate(tempInfo);
                paramField = string.Empty;
                if (myfrmDishInfoOperate.ShowDialog() == DialogResult.OK)
                    BindGridControl(paramField, paramDishType);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //string paramSimpleSpell = this.txtSimpleSpell.Text.Trim();
            //string paramDishName = this.txtDishName.Text.Trim();
            //RBindGridControl(paramSimpleSpell,paramDishType);

        }

        private void RBindGridControl(string paramSimpleSpell, string paramDishType)
        {
            if(paramSimpleSpell.Length>0)
                myDataTable = myBUCMS_ItemDetail.GetOrder(true, "名称", paramSimpleSpell, false);
            else
                myDataTable = myBUCMS_ItemDetail.GetOrder(true, "助记符", paramDishType, false);
            if (myDataTable.Rows.Count < 0)
                return;
            else
                this.grdctrlDishInfo.DataSource = myDataTable;
        }

        private void cmbeDishType_SelectedIndexChanged(object sender, EventArgs e)
        {
            paramDishType = this.cmbeDishType.Text;
            paramField = "类别";
            BindGridControl(paramField,paramDishType);
        }


        //#region public DataTable GetAllColumns()  获得表中的所有字段
        ///// <summary>
        ///// 获得表中的所有字段
        ///// </summary>
        ///// <returns></returns>
        //private string[] GetAllColumns()
        //{
        //    DataTable tempDataTable = new DataTable();
        //    List<string> returnStringArrary = new List<string>();
        //    try
        //    {
        //        tempDataTable = dal.GetAllColumns();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    foreach (DataRow tempDataRow in tempDataTable.Rows)
        //    {
        //        returnStringArrary.Add(tempDataRow[0].ToString());
        //    }
        //    return returnStringArrary.ToArray();
        //}
        //#endregion

        //#region public DataTable GetOrderMemberInfo(string paramCondition) 超级模糊查询
        ///// <summary>
        ///// 超级模糊查询
        ///// </summary>
        ///// <param name="paramCondition">查询条件</param>
        ///// <returns></returns>
        //public DataTable GetOrder(string paramCondition)
        //{
        //    DataTable myDataTable = null;
        //    try
        //    {
        //        string[] TableColumnsText = GetAllColumns();
        //        myDataTable = dal.GetOrder(TableColumnsText, paramCondition);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return myDataTable;
        //}
        //#endregion

        private void txtDishName_EditValueChanged(object sender, EventArgs e)
        {
            string paramDishName = this.txtDishName.Text.Trim();
            myDataTable = myBUCMS_DishServer.GetOrder(paramDishName);
            this.grdctrlDishInfo.DataSource = myDataTable;
        }

        private void txtSimpleSpell_EditValueChanged(object sender, EventArgs e)
        {
            string paramSimpleSpell = this.txtSimpleSpell.Text.Trim();
            myDataTable = myBUCMS_DishServer.GetOrder(paramSimpleSpell);
            this.grdctrlDishInfo.DataSource = myDataTable;
        }

        private void txtDishID_EditValueChanged(object sender, EventArgs e)
        {
            string paramDishID = this.txtDishID.Text.Trim();
            myDataTable = myBUCMS_DishServer.GetOrder(true,"编号",paramDishID,true);
            this.grdctrlDishInfo.DataSource = myDataTable;
        }

        private void btnDishInfoOut_Click(object sender, EventArgs e)
        {
            try
            {
                ClassAssist.DataOperator.DataOut(this.gridViewDishInfo, "菜品详细信息");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }

        private void btnDishInfoPrint_Click(object sender, EventArgs e)
        {
            try
            {
                ClassAssist.DataOperator.DataPrint(this.grdctrlDishInfo, "菜品详细信息",null);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            myDataTable = myBUCMS_DishServer.GetOrder(true,string.Empty,string.Empty,false);
            this.grdctrlDishInfo.DataSource = myDataTable;
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
