using System;
namespace CMS.Model
{
	/// <summary>
	/// 实体类ModelCMS_Buffets 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ModelCMS_Buffets
	{
		public ModelCMS_Buffets()
		{}
		#region Model
		private int _id;
		private string _name;
		private int? _accommodatenum;
		private int? _roomtypeid;
		private int _stateid;
		private string _markid;
		private string _infonote;
		private string _createperson;
		private DateTime? _createdate;
		private string _modifyperson;
		private DateTime? _modifydate;
		/// <summary>
		/// 餐台ID
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 餐台名称
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 可容纳人数
		/// </summary>
		public int? AccommodateNum
		{
			set{ _accommodatenum=value;}
			get{return _accommodatenum;}
		}
		/// <summary>
		/// 可容纳人数
		/// </summary>
		public int? RoomTypeID
		{
			set{ _roomtypeid=value;}
			get{return _roomtypeid;}
		}
		/// <summary>
		/// 餐台状态
		/// </summary>
		public int StateID
		{
			set
            { _stateid=value;}
			get{return _stateid;}
		}
		/// <summary>
		/// 账单编号
		/// </summary>
		public string MarkID
		{
			set{ _markid=value;}
			get{return _markid;}
		}
		/// <summary>
		/// 餐台信息备注
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

