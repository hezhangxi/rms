using System;
namespace CMS.Model
{
	/// <summary>
	/// 实体类ModelCMS_ConsumptionDish 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ModelCMS_ConsumptionDish
	{
		public ModelCMS_ConsumptionDish()
		{}
		#region Model
		private int _id;
		private string _markid;
		private int? _diskid;
		private int? _disknum;
		private bool _ispresent;
		private int? _tasteid;
		private string _description;
		private string _createperson;
		private DateTime? _createdate;
		private string _modifyperson;
		private DateTime? _modifydate;
		/// <summary>
		/// 点菜的ID
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 标识
		/// </summary>
		public string MarkID
		{
			set{ _markid=value;}
			get{return _markid;}
		}
		/// <summary>
		/// 菜品ID
		/// </summary>
		public int? DiskID
		{
			set{ _diskid=value;}
			get{return _diskid;}
		}
		/// <summary>
		/// 菜品数量
		/// </summary>
		public int? DiskNum
		{
			set{ _disknum=value;}
			get{return _disknum;}
		}
		/// <summary>
		/// 是否是赠菜
		/// </summary>
		public bool IsPresent
		{
			set{ _ispresent=value;}
			get{return _ispresent;}
		}
		/// <summary>
		/// 口味编号
		/// </summary>
		public int? TasteID
		{
			set{ _tasteid=value;}
			get{return _tasteid;}
		}
		/// <summary>
		/// 点菜描述
		/// </summary>
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
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

