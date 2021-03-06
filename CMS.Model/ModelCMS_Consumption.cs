using System;
namespace CMS.Model
{
	/// <summary>
	/// 实体类ModelCMS_Consumption 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ModelCMS_Consumption
	{
		public ModelCMS_Consumption()
		{}
		#region Model
		private int _id;
		private int _stockgoodsid;
		private int? _number;
		private DateTime? _outdate;
		private string _infonote;
		private int? _handlespeopleid;
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
		/// 库存商品ID
		/// </summary>
		public int StockGoodsID
		{
			set{ _stockgoodsid=value;}
			get{return _stockgoodsid;}
		}
		/// <summary>
		/// 出库商品数量
		/// </summary>
		public int? Number
		{
			set{ _number=value;}
			get{return _number;}
		}
		/// <summary>
		/// 出库时间
		/// </summary>
		public DateTime? OutDate
		{
			set{ _outdate=value;}
			get{return _outdate;}
		}
		/// <summary>
		/// 出库商品备注
		/// </summary>
		public string InfoNote
		{
			set{ _infonote=value;}
			get{return _infonote;}
		}
		/// <summary>
		/// 经手人姓名
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

