using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

using DBUtility;
///
namespace CMS.DALayer
{
	/// <summary>
	/// 数据访问类DACMS_Equipment 
	/// </summary>
	public class DACMS_Equipment
	{
        public DataTable GetDataSource()
        {
            string sqlQuery = " SELECT * FROM [CMS_Equipment] WHERE 1=1";
            try
            {
                return DbHelperSQL.GetDataTable(sqlQuery);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

