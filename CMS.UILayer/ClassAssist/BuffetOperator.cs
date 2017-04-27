using System;
using System.Collections.Generic;
using System.Text;

using CMS.Model;
using CMS.BULayer;
using System.Windows.Forms;
using DevExpress.XtraEditors;
namespace CMS.UILayer.ClassAssist
{
    /// <summary>
    /// 餐台操作常用方法
    /// </summary>
    /// 创建人：桂书丛
    /// 创建日期：2013-02-27
    public class BuffetOperator
    {
        #region private private ModelCMS_Buffets GetBuffetModel(ListViewItem paramListViewItem) 由一个餐台得到其具体实例
        /// <summary>
        /// 由一个餐台得到其具体实例
        /// </summary>
        /// <param name="paramListViewItem">餐台控件</param>
        public static ModelCMS_Buffets GetBuffetModel(ListViewItem paramListViewItem)
        {
            ModelCMS_Buffets returnModelCMS_Buffets = new ModelCMS_Buffets();
            ListViewItem tempaListViewItem = paramListViewItem;
            try
            {
                if (tempaListViewItem.Name == string.Empty)
                {
                    returnModelCMS_Buffets.StateID = Convert.ToInt32(VariedEnum.BuffetStatus.未定义);
                    return returnModelCMS_Buffets;
                }
                returnModelCMS_Buffets.ID = Convert.ToInt32(tempaListViewItem.Name);
                returnModelCMS_Buffets.Name = tempaListViewItem.Text;
                returnModelCMS_Buffets.AccommodateNum = Convert.ToInt32(tempaListViewItem.SubItems["AccommodateNum"].Text);
                returnModelCMS_Buffets.RoomTypeID = Convert.ToInt32(tempaListViewItem.SubItems["RoomTypeID"].Text);
                returnModelCMS_Buffets.StateID = Convert.ToInt32(tempaListViewItem.SubItems["StateID"].Text);
                returnModelCMS_Buffets.MarkID = tempaListViewItem.SubItems["MarkID"].Text;
                returnModelCMS_Buffets.InfoNote = tempaListViewItem.SubItems["InfoNote"].Text;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "GetBuffetModel");
            }
            return returnModelCMS_Buffets;
        }
        #endregion

        #region private void ShowBuffetInfo() 根据餐台控件获得餐台信息
        /// <summary>
        /// 根据餐台控件获得餐台信息
        /// </summary>
        /// <param name="paramModelCMS_Buffets">The param model CM s_ buffets.</param>
        /// <param name="paramDislayControls">The param dislay controls.</param>
        public static void ShowBuffetInfo(ModelCMS_Buffets paramModelCMS_Buffets,Control[] paramDislayControls)
        {
            if (paramModelCMS_Buffets == null)
                return;
            try
            {
                LabelControl ID = (LabelControl)paramDislayControls[0];
                LabelControl Name = (LabelControl)paramDislayControls[1];
                LabelControl AvaNum = (LabelControl)paramDislayControls[2];
                LabelControl Status = (LabelControl)paramDislayControls[3];
                LabelControl InfoNote = (LabelControl)paramDislayControls[4];
                ID.Text = paramModelCMS_Buffets.ID.ToString();
                Name.Text = paramModelCMS_Buffets.Name;
                AvaNum.Text = paramModelCMS_Buffets.AccommodateNum.ToString();
                VariedEnum.BuffetStatus CurrentBuffetStatus = (VariedEnum.BuffetStatus)paramModelCMS_Buffets.StateID;
                Status.Text = CurrentBuffetStatus.ToString();
                InfoNote.Text = paramModelCMS_Buffets.InfoNote;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "InitedBuffetDate");
            }
        }
        #endregion

        #region public static bool UpdateBuffetInfo(ListViewItem paramBuffetControl,VariedEnum.BuffetStatus paramBuffetStatus,string paramMarkID) 更新餐台信息
        /// <summary>
        /// 更新餐台信息
        /// </summary>
        /// <param name="paramBuffetControl">餐台控件</param>
        /// <param name="paramBuffetStatus">餐台状态</param>
        /// <param name="paramMarkID">订单号</param>
        /// <returns></returns>
        /// 创建人：桂书丛
        /// 创建日期：2013-2-28
        public static bool UpdateBuffetInfo(ListViewItem paramBuffetControl,VariedEnum.BuffetStatus paramBuffetStatus,string paramMarkID)
        {
            try
            {
                ModelCMS_Buffets tempModelCMS_Buffets = new ModelCMS_Buffets();
                paramBuffetControl.ImageIndex = Convert.ToInt32(paramBuffetStatus);
                paramBuffetControl.SubItems["StateID"].Text = Convert.ToInt32(paramBuffetStatus).ToString();
                if(paramMarkID.Length!=0)
                    paramBuffetControl.SubItems["MarkID"].Text = paramMarkID;
                tempModelCMS_Buffets = GetBuffetModel(paramBuffetControl);
                tempModelCMS_Buffets.ModifyPerson = frmAssist.frmLogin.SysUser.UserName;
                tempModelCMS_Buffets.ModifyDate = DateTime.Now;
                if (new BUCMS_Buffets().Update(tempModelCMS_Buffets) == VariedEnum.OperatorStatus.Successed)
                    return true;
                else
                    return false;
            }
            catch
            {
                XtraMessageBox.Show("下面的操作可能会出错，请谨慎操作", "发生未知错误",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion
    }
}
