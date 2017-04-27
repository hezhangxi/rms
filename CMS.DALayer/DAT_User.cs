
//******************************************************************************************************
//** Copyright (C) 2010-2013 重大网络教育学院
//** 创建人：桂书丛
//** 类名称\文件名：DAUser
//** 类功能：提供对用户信息操作的底层方法
//** 描 述：包括基本的增、删、查、改（所有关于用户数据库操作的方法）
//** 创建日期：2013-1-14
//** 修改(&U)人：桂书丛
//** 修改(&U)日期：2013-1-14
//** 整理日期：2013-1-14
//******************************************************************************************************

using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using DBUtility;
namespace CMS.DALayer
{
    /// <summary>
    /// 数据访问类DAT_User 
    /// </summary>
    public class DAT_User
    {
        #region public DataTable GetAllUserInfo()  获得所有用户的信息
        /// <summary>
        /// 获得所有用户的信息
        /// </summary>
        /// <returns>存储用户信息的DataSet</returns>
        public DataTable GetAllUserInfo()
        {
            DataTable myDataTable = null;
            string SqlQuery = " SELECT [U].[ID],[U].[USERNAME],[P].[NAME],[U].[CREATEPERSON],[U].[CREATEDATE], "
                +" [U].[MODIFYPERSON],[U].[MODIFYDATE] FROM [T_USER] AS [U] INNER JOIN [T_RIGHT] AS [P] ON "
                +" [U].[USERRIGHTID] = [P].[ID] ";
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
        #endregion

        #region public object CheckLogin(string paramStoredProcName, params SqlParameter[] paramParameters) 检测用户登录
        /// <summary>
        /// 检测用户登录
        /// </summary>
        ///<param name="paramParameters">存储过程所需参数</param>
        ///<param name="paramStoredProcName">存储过程名称</param>
        public object CheckLogin(string paramStoredProcName, params SqlParameter[] paramParameters)
        {
            object returnObjectValue = null;
            try
            {
                DbHelperSQL.ExecNonReturnProc(paramStoredProcName, paramParameters);
                return returnObjectValue;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }
        #endregion

        #region public object GetUserRight(string paramStoredProcName, params SqlParameter[] paramParameters) 得到用户权限
        /// <summary>
        /// 得到用户权限
        /// </summary>
        ///<param name="paramParameters">存储过程所需参数</param>
        ///<param name="paramStoredProcName">存储过程名称</param>
        public object GetUserRight(string paramStoredProcName, params SqlParameter[] paramParameters)
        {
            object returnObjectValue = null;
            try
            {
                returnObjectValue = DbHelperSQL.ExecReturnSingleProc(paramStoredProcName, paramParameters);
                return returnObjectValue;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }
        #endregion

        #region public object GetUserRightID(string paramUserName, string paramPassword) 得到用户权限ID
        /// <summary>
        /// 得到用户权限ID
        /// </summary>
        /// <param name="paramUserName">用户名称</param>
        /// <param name="paramPassword">用户密码</param>
        /// <returns>object</returns>
        public object GetUserRightID(string paramUserName, string paramPassword)
        {
            object returnObjectValue = null;
            string SqlQuery = " SELECT [USERRIGHTID] FROM [T_USER] WHERE "
                + " [USERNAME]='" + paramUserName + "' AND [USERPWD]='" + paramPassword + "' ";
            try
            {
                returnObjectValue = DbHelperSQL.ExecuteScalar(SqlQuery);
                return returnObjectValue;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }
        #endregion

        #region public object GetUserPWD(string paramStoredProcName, params SqlParameter[] paramParameters) 获得用户密码
        /// <summary>
        /// 获得用户密码
        /// </summary>
        /// <param name="paramStoredProcName">存储过程名称</param>
        /// <param name="paramParameters">存储过程所需参数</param>
        /// <returns></returns>
        public object GetUserPWD(string paramStoredProcName, params SqlParameter[] paramParameters)
        {
            object returnObjectValue = null;
            try
            {
                returnObjectValue = DbHelperSQL.ExecReturnSingleProc(paramStoredProcName, paramParameters);
                return returnObjectValue;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }
        #endregion

        #region public object UpdateUserInfo(string paramStoredProcName, params SqlParameter[] paramParameters) 更新用户信息
        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <param name="paramStoredProcName">存储过程名称</param>
        /// <param name="paramParameters">存储过程所需参数</param>
        /// <returns></returns>
        public object UpdateUserInfo(string paramStoredProcName, params SqlParameter[] paramParameters)
        {
            object returnObjectValue = null;
            try
            {
                returnObjectValue = DbHelperSQL.ExecReturnSingleProc(paramStoredProcName, paramParameters);
                return returnObjectValue;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }
        #endregion

        #region public object AddUserInfo(string paramStoredProcName, params SqlParameter[] paramParameters) 添加用户信息
        /// <summary>
        /// 添加用户信息
        /// </summary>
        /// <param name="paramStoredProcName">存储过程名称</param>
        /// <param name="paramParameters">存储过程所需参数</param>
        /// <returns></returns>
        public object AddUserInfo(string paramStoredProcName, params SqlParameter[] paramParameters)
        {
            object returnObjectValue = null;
            try
            {
                returnObjectValue = DbHelperSQL.ExecReturnSingleProc(paramStoredProcName, paramParameters);
                return returnObjectValue;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }
        #endregion

        #region  public int GetUserIDByName(string paramUserName) 根据用户的名称得到用户ID
        /// <summary>
        /// 根据用户的名称得到用户ID
        /// </summary>
        /// <param name="paramUserName">用户名称</param>
        /// <returns>影响的行数</returns>
        public int GetUserIDByName(string paramUserName)
        {
            object tempObjectValue = null;
            string SqlQuery = " SELECT [ID] FROM [T_USER] WHERE [USERNAME]='" + paramUserName + "'";
            try
            {
                tempObjectValue = DbHelperSQL.ExecuteScalar(SqlQuery);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            if (tempObjectValue != null)
                return Convert.ToInt32(tempObjectValue);
            else
                return -5;
        }
        #endregion

        #region  public int DeleteUser(int paramID) 根据用户ID删除(&D)用户
        /// <summary>
        /// 根据用户ID删除(&D)用户
        /// </summary>
        /// <param name="paramID">用户ID</param>
        /// <returns>影响的行数</returns>
        public int DeleteUser(string paramID)
        {
            int returnIntValue = 0;
            string SqlQuery = " DELETE [T_USER] WHERE [ID] = " + paramID + " ";
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
        #endregion
    }
}
