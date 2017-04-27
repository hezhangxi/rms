using System;
namespace CMS.Model
{
	/// <summary>
	/// 实体类ModelT_Right_Module_Map 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ModelT_Right_Module_Map
	{
		public ModelT_Right_Module_Map()
		{}
		#region Model
		private int _id;
		private int? _rightid;
		private int? _moduleid;
		private string _createperson;
		private DateTime? _createdate;
		private string _modifyperson;
		private DateTime? _modifydate;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 权限ID
		/// </summary>
		public int? RightID
		{
			set{ _rightid=value;}
			get{return _rightid;}
		}
		/// <summary>
		/// 模块ID
		/// </summary>
		public int? ModuleID
		{
			set{ _moduleid=value;}
			get{return _moduleid;}
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
		/// 修改(&U)日期
		/// </summary>
		public DateTime? ModifyDate
		{
			set{ _modifydate=value;}
			get{return _modifydate;}
		}
		#endregion Model

	}
}

