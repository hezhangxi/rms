using System;
namespace CMS.Model
{
	/// <summary>
	/// 实体类ModelCMS_RetreatDishes 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ModelCMS_RetreatDishes
	{
		public ModelCMS_RetreatDishes()
		{}
		#region Model
		private int _id;
		private int? _dishid;
		private int? _dishnum;
		private int? _causeid;
		private string _infonote;
		private string _createperson;
		private DateTime? _retreatdate;
		/// <summary>
		/// 退菜记录ID
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 所退菜品ID
		/// </summary>
		public int? DishID
		{
			set{ _dishid=value;}
			get{return _dishid;}
		}
		/// <summary>
		/// 退菜数量
		/// </summary>
		public int? DishNum
		{
			set{ _dishnum=value;}
			get{return _dishnum;}
		}
		/// <summary>
		/// 退菜原因编号
		/// </summary>
		public int? CauseID
		{
			set{ _causeid=value;}
			get{return _causeid;}
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
		/// 创建人
		/// </summary>
		public string CreatePerson
		{
			set{ _createperson=value;}
			get{return _createperson;}
		}
		/// <summary>
		/// 退菜时间
		/// </summary>
		public DateTime? RetreatDate
		{
			set{ _retreatdate=value;}
			get{return _retreatdate;}
		}
		#endregion Model

	}
}

