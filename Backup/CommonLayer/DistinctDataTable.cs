using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace CMS.CommonLayer
{
    public class DistinctDataTable
    {
        /// <summary>  
        /// 获取对固定列不重复的新DataTable  
        /// </summary>  
        /// <param name="dt">含有重复数据的DataTable</param>  
        /// <param name="colName">需要验证重复的列名</param>  
        /// <returns>新的DataTable，colName列不重复，表格式保持不变</returns>  
        public static DataTable GetDistinctTable(DataTable dt, string colName)  
        {  
            DataView dv = dt.DefaultView;  
            DataTable dtCardNo = dv.ToTable(true, colName);  
            DataTable Pointdt = new DataTable();  
            Pointdt = dv.ToTable();  
            Pointdt.Clear();
            for (int i = 0; i < dtCardNo.Rows.Count; i++)
            {
                DataRow dr = dt.Select(colName + " = '" + dtCardNo.Rows[i][0].ToString() + "'")[0];
                Pointdt.Rows.Add(dr.ItemArray);
            }
            return Pointdt;  
        }  
    }
}
