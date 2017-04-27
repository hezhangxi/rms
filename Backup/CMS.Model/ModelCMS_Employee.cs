using System;
namespace CMS.Model
{
	/// <summary>
	/// 实体类ModelCMS_Employee 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ModelCMS_Employee
	{
		public ModelCMS_Employee()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _sex;
        private int? _age;
        private string _degree;
        private DateTime? _birthdate;
		private int? _posid;
        private DateTime? _entrydate;
		private int? _stateid;
        private string _photo;
		private string _telphone;
		private string _idcardnum;
		private string _address;
		private string _infonote;
		private string _createperson;
		private DateTime? _createdate;
		private string _modifyperson;
		private DateTime? _modifydate;
		/// <summary>
		/// 员工编号
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 员工姓名
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 员工性别
		/// </summary>
		public string Sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
        /// <summary>
        /// 年龄
        /// </summary>
        public int? Age
        {
            set { _age = value; }
            get { return _age; }
        }
        /// <summary>
        /// 学历
        /// </summary>
        public string Degree
        {
            set { _degree = value; }
            get { return _degree; }
        }
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime? BirthDate
        {
            set { _birthdate = value; }
            get { return _birthdate; }
        }
		/// <summary>
		/// 员工职位ID
		/// </summary>
		public int? PosID
		{
			set{ _posid=value;}
			get{return _posid;}
		}
        /// <summary>
        /// 入职时间
        /// </summary>
        public DateTime? EntryDate
        {
            set { _entrydate = value; }
            get { return _entrydate; }
        }
		/// <summary>
		/// 员工工作状态ID
		/// </summary>
		public int? StateID
		{
			set{ _stateid=value;}
			get{return _stateid;}
		}
		/// <summary>
		/// 员工照片
		/// </summary>
		public string Photo
		{
			set{ _photo=value;}
			get{return _photo;}
		}
		/// <summary>
		/// 电话号码
		/// </summary>
		public string TelPhone
		{
			set{ _telphone=value;}
			get{return _telphone;}
		}
		/// <summary>
		/// 身份证号码
		/// </summary>
		public string IDCardNum
		{
			set{ _idcardnum=value;}
			get{return _idcardnum;}
		}
		/// <summary>
		/// 家庭住址
		/// </summary>
		public string Address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 员工信息备注
		/// </summary>
		public string InfoNote
		{
			set{ _infonote=value;}
			get{return _infonote;}
		}
		/// <summary>
		/// 创建人
		/// </summary>
		public string CreatePerson
		{
			set{ _createperson=value;}
			get{return _createperson;}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? CreateDate
		{
			set{ _createdate=value;}
			get{return _createdate;}
		}
		/// <summary>
		/// 修改(&U)人
		/// </summary>
		public string ModifyPerson
		{
			set{ _modifyperson=value;}
			get{return _modifyperson;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ModifyDate
		{
			set{ _modifydate=value;}
			get{return _modifydate;}
		}
		#endregion Model

	}
}

