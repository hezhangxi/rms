using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

using DBUtility;
using CMS.Model;
///
namespace CMS.DALayer
{
	/// <summary>
	/// 数据访问类DACMS_PaymentsDetail 
	/// </summary>
    public class DACMS_PaymentsDetail : IDALayer<ModelCMS_PaymentsDetail>
    {
        #region 定义变量
        int returnIntValue = -5;
        #endregion

        #region IDALayer<ModelCMS_PaymentsDetail> 成员

        public DataTable GetOrder(bool IsView, string paramField, string paramContent, bool IsFuzzy)
        {
            DataTable myDataTable = null;
            string SqlQuery = " SELECT * FROM  ";
            if (IsView == false)
                SqlQuery += " [CMS_PaymentsDetail] ";
            else
                SqlQuery += "[View_FinanceManagement]";
            if (paramField.Length != 0)
            {
                if (IsFuzzy == false)
                    SqlQuery += " WHERE " + paramField + " = '" + paramContent + "'";
                else
                    SqlQuery += " WHERE " + paramField + " LIKE '" + paramContent + "'";
            }
            try
            {
                myDataTable = DbHelperSQL.GetDataTable(SqlQuery);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return myDataTable;
        }

        public DataTable GetOrder(bool IsView, string paramField, DateTime paramStart, DateTime paramEnd)
        {
            DataTable myDataTable = null;
            string SqlQuery = " SELECT * FROM  ";
            if (IsView == false)
                SqlQuery += " [CMS_PaymentsDetail] ";
            else
                SqlQuery += " [View_FinanceManagement] ";
            if (paramField.Length != 0)
            {
                SqlQuery += "WHERE " + paramField + " BETWEEN '" + paramStart + "' AND '" + paramEnd + "'";
            }
            try
            {
                myDataTable = DbHelperSQL.GetDataTable(SqlQuery);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return myDataTable;
        }

        public int Update(ModelCMS_PaymentsDetail model)
        {
            string sqlQuery = " UPDATE [CMS_PaymentsDetail]"
                              + " SET [PaymentTypeID] = "+model.PaymentTypeID
                              + ",[Amount] = "+model.Amount
                              + ",[HandlesPeopleID] = "+model.HandlesPeopleID
                              + ",[InfoNote] = '" + model.InfoNote + "',"
                              + "[ModifyPerson] = '" + model.ModifyPerson + "',"
                              + "[ModifyDate] = '" + model.ModifyDate + "'"
                              + "WHERE [ID]=" + model.ID;
            try
            {
                returnIntValue = DbHelperSQL.ExecuteNonQuery(sqlQuery);
                return returnIntValue;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Insert(ModelCMS_PaymentsDetail model)
        {
            string SqlQuery = " INSERT INTO [CMS_PaymentsDetail] "
                + "([PaymentTypeID]"
                + ",[Amount]"
                + ",[HandlesPeopleID]"
                + ",[InfoNote]"
                + ",[CreatePerson]"
                + ",[CreateDate]"
                + " ) VALUES ("
                + "" + model.PaymentTypeID + ""
                + "," + model.Amount + ""
                + "," + model.HandlesPeopleID + ""
                + ",'" + model.InfoNote + "'"
                + ",'" + model.CreatePerson + "'"
                + ",'" + model.CreateDate + "')";
            try
            {
                returnIntValue = DbHelperSQL.ExecuteNonQuery(SqlQuery);
                return returnIntValue;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Delete(string paramID)
        {
            string sqlQuery = " DELETE FROM [CMS_PaymentsDetail] WHERE [ID]=" + paramID;
            try
            {
                returnIntValue = DbHelperSQL.ExecuteNonQuery(sqlQuery);
                return returnIntValue;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}

