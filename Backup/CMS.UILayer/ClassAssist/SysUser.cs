
//******************************************************************************************************
//** Copyright (C) 2010-2013 重大网络教育学院
//** 创建人：桂书丛
//** 类名称\文件名：UserInfo
//** 类功能：存储系统用户信息
//** 描 述：存储系统用户的所有信息
//** 创建日期：2013-1-14
//** 修改(&U)人：桂书丛
//** 修改(&U)日期：2013-1-14
//** 整理日期：2013-1-14
//******************************************************************************************************

using System;
using System.Collections.Generic;
using System.Text;

using CMS.BULayer;
using System.Data;
namespace CMS.UILayer.ClassAssist
{
    public class SysUser
    {
        public SysUser(string paramUserName,string paramUserPWD)
        {
            this._username = paramUserName;
            this._userpwd = paramUserPWD;
            GetUserOtherInfo();
        }

        #region 用户属性
        private int _userid = -5;
        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserID
        {
            get
            {
                return _userid;
            }
            set
            {
                _userid = value;
            }
        }

        private string _username = string.Empty;
        /// <summary>
        /// 用户名称
        /// </summary>
        public string UserName
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }

        private string _userpwd = string.Empty;
        /// <summary>
        /// 用户密码
        /// </summary>
        public string UserPWD
        {
            get
            {
                return _userpwd;
            }
            set
            {
                _userpwd = value;
            }
        }

        private int _userrightid = -5;
        /// <summary>
        /// 用户权限ID
        /// </summary>
        public int UserRightID
        {
            get
            {
                return _userrightid;
            }
            set
            {
                _userrightid = value;
            }
        }

        private string _userright = string.Empty;
        /// <summary>
        /// 用户权限
        /// </summary>
        public string UserRight
        {
            get
            {
                return _userright;
            }
            set
            {
                _userright = value;
            }
        }

        /// <summary>
        /// 用户可使用的模块
        /// </summary>
        public DataTable UserModule
        {
            get
            {
                try
                {
                    DataTable tempDataTable = new BUT_Module().GetUserModule(_userrightid.ToString());
                    return tempDataTable;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        #endregion

        #region private void GetUserOtherInfo() 根据用户基本信息获得用户其他信息
        /// <summary>
        /// 根据用户基本信息获得用户其他信息
        /// </summary>
        private void GetUserOtherInfo()
        {
            BUT_User tempBUUser = new BUT_User();
            try
            {
                this._userid = tempBUUser.GetUserIDByName(_username);
                this._userrightid = tempBUUser.GetUserRightID(_username, _userpwd);
                this._userright = tempBUUser.GetUserRight(_username, _userpwd);
            }
            catch { }
        }
        #endregion
    }
}
