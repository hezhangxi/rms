using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace CMS.UILayer.frmAssist
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool IsCreatedNew; //返回(&B)是否赋予了使用线程的互斥体初始所属权 
            Mutex ExeInstance = new Mutex(true, "MutexName", out IsCreatedNew); //同步基元变量 
            //加载皮肤
            if (!DevExpress.Skins.SkinManager.AllowFormSkins)
            {
                DevExpress.Skins.SkinManager.EnableFormSkins();
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Black");
            }
            if (IsCreatedNew) //赋予了线程初始所属权，也就是首次使用互斥体 
            {
                //将DevExpress控件汉化
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh-CHS");
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                try
                {
                    Application.Run(new frmLogin());
                    ExeInstance.ReleaseMutex();
                }
                catch
                {
                    Application.ExitThread();
                }
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("系统中已经有一个实例在运行！", "系统提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
