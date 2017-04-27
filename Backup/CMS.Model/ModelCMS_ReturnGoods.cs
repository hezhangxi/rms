using System;
namespace CMS.Model
{
	/// <summary>
	/// 实体类ModelCMS_ReturnGoods 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ModelCMS_ReturnGoods
	{
		public ModelCMS_ReturnGoods()
		{}
		#region Model
		private int _id;
		private int _goodsborrowid;
		private int? _number;
		private DateTime? _returntime;
		private string _infonote;
		private int? _handlespeopleid;
		private string _modifyperson;
		private DateTime? _modifydate;
		/// <summary>
		/// 借出商品ID
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 借出商品ID
		/// </summary>
		public int GoodsBorrowID
		{
			set{ _goodsborrowid=value;}
			get{return _goodsborrowid;}
		}
		/// <summary>
		/// 归还商品数量
		/// </summary>
		public int? Number
		{
			set{ _number=value;}
			get{return _number;}
		}
		/// <summary>
		/// 归还商品的时间
		/// </summary>
		public DateTime? ReturnTime
		{
			set{ _returntime=value;}
			get{return _returntime;}
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
		/// 经手人ID
		/// </summary>
		public int? HandlesPeopleID
		{
			set{ _handlespeopleid=value;}
			get{return _handlespeopleid;}
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

