
//******************************************************************************************************
//** Copyright (C) 2010-2013 重大网络教育学院
//** 创建人：桂书丛
//** 类名称\文件名：SysExamine
//** 类功能:系统检测
//** 描 述：系统检测
//** 创建日期：2013-1-30
//** 修改(&U)人：桂书丛
//** 修改(&U)日期：2013-1-30
//** 整理日期：2013-1-30
//******************************************************************************************************

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using DBUtility;
using System.Data.SqlClient;
namespace CMS.UILayer.ClassAssist
{
    /// <summary>
    /// 系统检测
    /// </summary>
    public class SysExamine
    {
        private static DbOperator myDBOperator = new DbOperator();
        private static string ConnectionString = PubConstant.ConnectionString;

        public static bool SqlSet()
        {
            bool ReturnValue = false;
            try
            {
                SqlConnection mySqlConnection = new SqlConnection(ConnectionString);
                mySqlConnection.Open();
                mySqlConnection.Close();
                ReturnValue = true;
            }
            catch 
            {

                ReturnValue = false;
            }
            return ReturnValue;
        }

        /// <summary>
        /// 检测系统运行必要条件
        /// </summary>
        /// <returns></returns>
        public static bool SysDBExam(Form paramOperatorForm)
        {
            try
            {
               

                if (myDBOperator.InspectSqlserver() == false)
                {
                    XtraMessageBox.Show("您当前系统中没有安装Microsoft SQL Server,暂无法运行本系统", "系统检测提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                //if (myDBOperator.InspectDatabase("CMS") == false)
                //if (false)
                //{
                //    XtraMessageBox.Show("检测到您系统中不存在数据库：CMS,请附加后再试", "系统检测提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    frmAssist.frmAttach myfrmAttach = new CMS.UILayer.frmAssist.frmAttach();
                //    if (myfrmAttach.ShowDialog() == DialogResult.OK)
                //        return true;
                //    else
                //        return false;
                //}
                if (!SqlSet())
                {
                    DialogResult myDialogResult = XtraMessageBox.Show("是否尝试系统数据配置？", "系统数据未准备好", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (myDialogResult == DialogResult.No)
                        Application.ExitThread();
                    else
                    {
                        frmGeneralTool.SysDataConfig mySysDataConfig = new CMS.UILayer.frmGeneralTool.SysDataConfig();
                        mySysDataConfig.Owner = paramOperatorForm;
                        if (mySysDataConfig.ShowDialog() == DialogResult.OK)
                            return false;
                        else
                            Application.ExitThread();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
