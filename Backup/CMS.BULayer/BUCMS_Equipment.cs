using System;
using System.Data;
using System.Collections.Generic;
using CMS.DALayer;
using CMS.Model;
namespace CMS.BULayer
{
	/// <summary>
	/// ÒµÎñÂß¼­ÀàBUCMS_Equipment   
	/// </summary>
	public class BUCMS_Equipment
	{
		private readonly DACMS_Equipment dal=new DACMS_Equipment();

        public DataTable GetDataSource()
        {
            try
            {
                return dal.GetDataSource();
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
    }
}

