using System;
namespace CMS.Model
{
	/// <summary>
	/// 实体类ModelCMS_InGoods 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ModelCMS_InGoods
	{
		public ModelCMS_InGoods()
		{}
		#region Model
		private int _id;
		private string _name;
        private string _serialnumber;
		private string _specifications;
        private decimal? _total;
		private int? _number;
		private decimal? _price;
		private string _supplier;
		private int? _handlespeopleid;
		private DateTime? _indate;
		private string _infonote;
		private string _modifyperson;
		private DateTime? _modifydate;
		/// <summary>
		/// 商品ID
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

        public string SerialNumber
        {
            set { _serialnumber = value; }
            get { return _serialnumber; }
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
        /// 商品总价
        /// </summary>
        public decimal? Total
        {
            set { _total = value; }
            get { return _total; }
        }

		/// <summary>
		/// 入库数量
		/// </summary>
		public int? Number
		{
			set{ _number=value;}
			get{return _number;}
		}
		/// <summary>
		/// 商品入库单价
		/// </summary>
		public decimal? Price
		{
			set{ _price=value;}
			get{return _price;}
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
		/// 接收人ID
		/// </summary>
		public int? HandlesPeopleID
		{
			set{ _handlespeopleid=value;}
			get{return _handlespeopleid;}
		}
		/// <summary>
		/// 入库时间
		/// </summary>
		public DateTime? InDate
		{
			set{ _indate=value;}
			get{return _indate;}
		}
		/// <summary>
		/// 入库备注
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

