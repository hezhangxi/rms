using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.CommonLayer
{
    /// <summary>
    /// 判断字符串类型的类
    /// </summary>
    public class CheckString
    {
        #region public static bool IsNum(string paramString) 判断字符串是否为纯数字字符串
        /// <summary>
        /// 判断字符串是否为纯数字字符串
        /// </summary>
        /// <param name="paramString">需判断的字符串</param>
        /// <returns>true:是纯数字字符串;false:不是纯数字字符串</returns>
        public static bool IsNum(string paramString)
        {
            foreach (char i in paramString)
            {
                if (i < '0' || i > '9')
                {
                    return false;
                }
            }
            return true;
        } 
        #endregion

        #region public static bool IsChinese(string paramString) 判断字符串是否为纯汉字
        /// <summary>
        /// 判断字符串是否为纯汉字
        /// </summary>
        /// <param name="paramString">>需判断的字符串</param>
        /// <returns>true:是中文字符串;false:不是中文字符串</returns>
        public static bool IsChinese(string paramString)
        {
            foreach (char c in paramString)
            {
                int i = (int)c;
                if (i < 0x4E00 || i > 0x9fa5)
                {
                    return false;
                }
            }
            return true;
        } 
        #endregion

        #region public static bool ContanctChinese(string paramString) 判断字符串中是否包含汉字
        /// <summary>
        /// 判断字符串中是否包含汉字
        /// </summary>
        /// <param name="paramString">需判断的字符串</param>
        /// <returns>true:包含汉字|false:不包含汉字</returns>
        public static bool ContanctChinese(string paramString)
        {
            int num = 0;
            foreach (char c in paramString)
            {
                int i = (int)c;
                if (i > 0x4E00 && i < 0x9fa5)
                {
                    num++;
                }
            }
            if (num > 0)
            {
                return true;
            }
            return false;
        } 
        #endregion
    }
}
