using System;
namespace CMS.Model
{
	/// <summary>
	/// 实体类ModelCMS_BuffetBooking 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ModelCMS_BuffetBooking
	{
		public ModelCMS_BuffetBooking()
		{}
		#region Model
		private int _id;
		private int? _buffetsid;
		private string _cname;
		private string _ctelphone;
        private string _transactor;
		private int? _cnum;
		private DateTime? _bookdate;
		private DateTime? _overduttime;
		private string _infonote;
		private string _modifyperson;
		private DateTime? _modifydate;
		/// <summary>
		/// 预定餐台ID
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 要预定的餐台
		/// </summary>
		public int? BuffetsID
		{
			set{ _buffetsid=value;}
			get{return _buffetsid;}
		}
		/// <summary>
		/// 预定人姓名
		/// </summary>
		public string CName
		{
			set{ _cname=value;}
			get{return _cname;}
		}
		/// <summary>
		/// 预定人电话
		/// </summary>
		public string CTelPhone
		{
			set{ _ctelphone=value;}
			get{return _ctelphone;}
		}
		/// <summary>
		/// 办理人
		/// </summary>
        public string Transactor
		{
            set { _transactor = value; }
            get { return _transactor; }
		}
		/// <summary>
		/// 宾客人数
		/// </summary>
		public int? CNum
		{
			set{ _cnum=value;}
			get{return _cnum;}
		}
		/// <summary>
		/// 预定时间
		/// </summary>
		public DateTime? BooKDate
		{
			set{ _bookdate=value;}
			get{return _bookdate;}
		}
		/// <summary>
		/// 失效时间
		/// </summary>
		public DateTime? OverduTtime
		{
			set{ _overduttime=value;}
			get{return _overduttime;}
		}
		/// <summary>
		/// 信息备注
		/// </summary>
		public string InfoNote
		{
			set{ _infonote=value;}
			get{return _infonote;}
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
		/// 修改(&U)时间
		/// </summary>
		public DateTime? ModifyDate
		{
			set{ _modifydate=value;}
			get{return _modifydate;}
		}
		#endregion Model

	}
}

