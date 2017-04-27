using System;
namespace CMS.Model
{
	/// <summary>
	/// 实体类ModelCMS_Stock 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ModelCMS_Stock
	{
		public ModelCMS_Stock()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _supplier;
		private string _specifications;
		private decimal? _price;
        private decimal? _total;
		private int? _number;
		private string _infonote;
		private int? _handlespeopleid;
		/// <summary>
		/// 库存商品编号
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 商品名称
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 供应商
		/// </summary>
		public string Supplier
		{
			set{ _supplier=value;}
			get{return _supplier;}
		}
		/// <summary>
		/// 商品规格
		/// </summary>
		public string Specifications
		{
			set{ _specifications=value;}
			get{return _specifications;}
		}
		/// <summary>
		/// 商品单价
		/// </summary>
		public decimal? Price
		{
			set{ _price=value;}
			get{return _price;}
		}
        /// <summary>
        /// 商品总价
        /// </summary>
        public decimal? Total
        {
            set { _total = value; }
            get { return _total; }
        }
		/// <summary>
		/// 商品的数量
		/// </summary>
		public int? Number
		{
			set{ _number=value;}
			get{return _number;}
		}
		/// <summary>
		/// 商品信息备注
		/// </summary>
		public string InfoNote
		{
			set{ _infonote=value;}
			get{return _infonote;}
		}
		/// <summary>
		/// 接收人ID
		/// </summary>
		public int? HandlesPeopleID
		{
			set{ _handlespeopleid=value;}
			get{return _handlespeopleid;}
		}
		#endregion Model

	}
}

