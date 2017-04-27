
//******************************************************************************************************
//** Copyright (C) 2010-2013 重大网络教育学院
//** 创建人：桂书丛
//** 类名称\文件名：BUUser
//** 类功能：提供对用户信息操作的逻辑处理方法
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
using CMS.DALayer;
using CMS.Model;
namespace CMS.BULayer
{
    public class BUT_User
    {
        private readonly DAT_User dal = new DAT_User();

        #region public DataTable GetAllUserInfo()  获得所有用户的信息
        /// <summary>
        /// 获得所有用户的信息
        /// </summary>
        /// <returns>存储用户信息的DataSet</returns>
        public DataTable GetAllUserInfo()
        {
            DataTable myDataTable = null;
            try
            {
                myDataTable = dal.GetAllUserInfo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return myDataTable;
        }
        #endregion

        #region  public VariedEnum.UserLoginStatus CheckLogin(string paramUserName, string paramPassword) 检测用户登陆
        /// <summary>
        /// 检测用户登陆
        /// </summary>
        /// <param name="paramUserName">用户名称</param>
        /// <param name="paramPassword">用户密码</param>
        /// <returns>用户登陆状态</returns>
        public VariedEnum.UserLoginStatus CheckLogin(string paramUserName, string paramPWD)
         {
            int intTempValue = 0;
            SqlParameter[] mySqlParameter = new SqlParameter[3];
            mySqlParameter[0] = new SqlParameter("@UserName", SqlDbType.NVarChar, 20);
            mySqlParameter[0].Value = paramUserName;
            mySqlParameter[1] = new SqlParameter("@UserPWD", SqlDbType.NVarChar, 20);
            mySqlParameter[1].Value = paramPWD;
            mySqlParameter[2] = new SqlParameter("@ReturnValue", SqlDbType.Int);
            mySqlParameter[2].Direction = ParameterDirection.Output;
            try
            {
                dal.CheckLogin("proc_SysLogin", mySqlParameter);
                intTempValue = (int)mySqlParameter[2].Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            switch (intTempValue)
            {
                case 0: return VariedEnum.UserLoginStatus.DotExistUser;
                case -100: return VariedEnum.UserLoginStatus.PasswordError;
                case 100: return VariedEnum.UserLoginStatus.Successed;
                default: return VariedEnum.UserLoginStatus.UnknowError;
            }
        }
        #endregion

        #region public string GetUserPWD(int paramUserID) 根据用户ID获得用户密码
        /// <summary>
        /// 根据用户ID获得用户密码
        /// </summary>
        /// <param name="paramUserID">用户ID</param>
        /// <returns></returns>
        public string GetUserPWD(int paramUserID)
        {
            object returnObjectValue = null;
            SqlParameter[] mySqlParameter = new SqlParameter[1];
            mySqlParameter[0] = new SqlParameter("@UserID", SqlDbType.Int);
            mySqlParameter[0].Value = paramUserID;
            try
            {
                returnObjectValue = dal.GetUserPWD("proc_GetUserPWD", mySqlParameter);
                return returnObjectValue.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region public string UpdateUserInfo(ModelT_User paramModelT_User) 更新用户信息
        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <param name="paramModelT_User">用户实体</param>
        /// <returns></returns>
        public VariedEnum.OperatorStatus UpdateUserInfo(ModelT_User paramModelT_User)
        {
            object returnObjectValue = null;
            SqlParameter[] mySqlParameter = new SqlParameter[5];
            mySqlParameter[0] = new SqlParameter("@ID", SqlDbType.Int);
            mySqlParameter[0].Value = paramModelT_User.ID;
            mySqlParameter[1] = new SqlParameter("@UserName", SqlDbType.NVarChar,20);
            mySqlParameter[1].Value = paramModelT_User.UserName;
            mySqlParameter[2] = new SqlParameter("@UserPWD", SqlDbType.NVarChar,20);
            mySqlParameter[2].Value = paramModelT_User.UserPWD;
            mySqlParameter[3] = new SqlParameter("@UserRightID", SqlDbType.Int);
            mySqlParameter[3].Value = paramModelT_User.UserRightID;
            mySqlParameter[4] = new SqlParameter("@ModifyPerson", SqlDbType.NVarChar,20);
            mySqlParameter[4].Value = paramModelT_User.ModifyPerson;
            try
            {
                returnObjectValue = dal.UpdateUserInfo("proc_UpdateUser", mySqlParameter);
                if (Convert.ToInt32(returnObjectValue) > 0)
                    return VariedEnum.OperatorStatus.Successed;
                else
                    return VariedEnum.OperatorStatus.Failed;
            }
            catch (Exception ex)
            {
                return VariedEnum.OperatorStatus.UnknowError;
                throw ex;
            }
        }
        #endregion

        #region  public VariedEnum.OperatorStatus AddUserInfo(ModelT_User paramModelT_User) 新建用户
        /// <summary>
        /// 新建用户
        /// </summary>
        /// <param name="paramUserInfo">用户实体</param>
        /// <returns>影响的行数</returns>
        public VariedEnum.OperatorStatus AddUserInfo(ModelT_User paramModelT_User)
        {
            object returnObjectValue = null;
            SqlParameter[] mySqlParameter = new SqlParameter[4];
            mySqlParameter[0] = new SqlParameter("@UserName", SqlDbType.NVarChar, 20);
            mySqlParameter[0].Value = paramModelT_User.UserName;
            mySqlParameter[1] = new SqlParameter("@UserPWD", SqlDbType.NVarChar, 20);
            mySqlParameter[1].Value = paramModelT_User.UserPWD;
            mySqlParameter[2] = new SqlParameter("@UserRightID", SqlDbType.Int);
            mySqlParameter[2].Value = paramModelT_User.UserRightID;
            mySqlParameter[3] = new SqlParameter("@CreatePerson", SqlDbType.NVarChar, 20);
            mySqlParameter[3].Value = paramModelT_User.CreatePerson;
            try
            {
                returnObjectValue = dal.UpdateUserInfo("proc_T_UserInsert", mySqlParameter);
                if (Convert.ToInt32(returnObjectValue) > 0)
                    return VariedEnum.OperatorStatus.Successed;
                else
                    return VariedEnum.OperatorStatus.Failed;
            }
            catch (Exception ex)
            {
                return VariedEnum.OperatorStatus.UnknowError;
                throw ex;
            }
        }
        #endregion

        #region  public VariedEnum.OperatorStatus  DeleteUser(string paramID) 根据用户ID删除(&D)用户
        /// <summary>
        /// 根据用户ID删除(&D)用户
        /// </summary>
        /// <param name="paramID">用户ID</param>
        /// <returns>影响的行数</returns>
        public VariedEnum.OperatorStatus DeleteUser(string paramID)
        {
            int tempIntValue = -100;
            try
            {
                tempIntValue = dal.DeleteUser(paramID);
                if (tempIntValue > 0)
                    return VariedEnum.OperatorStatus.Successed;
                else
                    return VariedEnum.OperatorStatus.Failed; 
            }
            catch (Exception ex)
            {
                //return VariedEnum.OperatorStatus.UnknowError;
                throw ex;
            }         
        }
        #endregion

        #region public string GetUserRight(string paramUserName, string paramUserPassword) 得到用户权限
        /// <summary>
        /// 得到用户权限
        /// </summary>
        /// <param name="paramUserName">用户名称</param>
        /// <param name="UserPassword">用户密码</param>
        /// <returnsL>用户权限</returnsL>
        public string GetUserRight(string paramUserName, string paramUserPassword)
        {
            object returnObjectValue = null;
            SqlParameter[] mySqlParameter = new SqlParameter[2];
            mySqlParameter[0] = new SqlParameter("@UserName", SqlDbType.NVarChar, 20);
            mySqlParameter[0].Value = paramUserName;
            mySqlParameter[1] = new SqlParameter("@UserPWD", SqlDbType.NVarChar, 20);
            mySqlParameter[1].Value = paramUserPassword;
            try
            {
                returnObjectValue = dal.GetUserRight("proc_GetUserRight", mySqlParameter);
                return returnObjectValue.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region public int GetUserRightID(string paramUserName, string paramPassword) 得到用户权限ID
        /// <summary>
        /// 得到用户权限ID
        /// </summary>
        /// <param name="paramUserName">用户名称</param>
        /// <param name="paramPassword">用户密码</param>
        /// <returns>object</returns>
        public int GetUserRightID(string paramUserName, string paramPassword)
        {
            object tempObjectValue = null;
            int returnIntValue = -5;
            try
            {
                tempObjectValue = dal.GetUserRightID(paramUserName, paramPassword);
                if (tempObjectValue != null)
                    returnIntValue = Convert.ToInt32(tempObjectValue);
            }
            catch (Exception ex)
            {
                return returnIntValue;
                throw ex;
            }
            return returnIntValue;
        }
        #endregion

        #region  int string GetUserIDByName(string paramUserName) 根据用户的名称得到用户ID
        /// <summary>
        /// 根据用户的名称得到用户ID
        /// </summary>
        /// <param name="paramUserName">用户名称</param>
        /// <returns>影响的行数</returns>
        public int GetUserIDByName(string paramUserName)
        {
            int tempIntValue = -5;
            try
            {
                tempIntValue = dal.GetUserIDByName(paramUserName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            if (tempIntValue > 0)
                return tempIntValue;
            else
                return 0;
        }
        #endregion

    }
}
