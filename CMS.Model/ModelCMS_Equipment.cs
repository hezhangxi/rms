using System;
namespace CMS.Model
{
	/// <summary>
	/// 实体类ModelCMS_Equipment 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ModelCMS_Equipment
	{
		public ModelCMS_Equipment()
		{}
		#region Model
		private int _id;
		private bool _condition;
		private bool _fan;
		private bool _tv;
		private bool _dvd;
		private string _other;
		private string _createperson;
		private DateTime? _createdate;
		private string _modifyperson;
		private DateTime? _modifydate;
		/// <summary>
		/// 包厢设备ID
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 是否有空调
		/// </summary>
		public bool Condition
		{
			set{ _condition=value;}
			get{return _condition;}
		}
		/// <summary>
		/// 是否有风扇
		/// </summary>
		public bool Fan
		{
			set{ _fan=value;}
			get{return _fan;}
		}
		/// <summary>
		/// 是否有彩电
		/// </summary>
		public bool TV
		{
			set{ _tv=value;}
			get{return _tv;}
		}
		/// <summary>
		/// 是否有DVD
		/// </summary>
		public bool DVD
		{
			set{ _dvd=value;}
			get{return _dvd;}
		}
		/// <summary>
		/// 其他备注设备
		/// </summary>
		public string Other
		{
			set{ _other=value;}
			get{return _other;}
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

