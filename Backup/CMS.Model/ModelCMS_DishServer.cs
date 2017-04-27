using System;
namespace CMS.Model
{
	/// <summary>
	/// 实体类ModelCMS_DishServer 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ModelCMS_DishServer
	{
		public ModelCMS_DishServer()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _mnemonicsymbol;
		private int? _dishtypeid;
		private decimal? _cost;
		private string _measuringunit;
		private decimal? _price;
		private decimal? _commission;
		private int? _stockgoodsid;
		private string _infonote;
		private string _createperson;
		private DateTime? _createdate;
		private string _modifyperson;
		private DateTime? _modifydate;
		/// <summary>
		/// 菜品ID
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 菜名
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 助记符
		/// </summary>
		public string MnemonicSymbol
		{
			set{ _mnemonicsymbol=value;}
			get{return _mnemonicsymbol;}
		}
		/// <summary>
		/// 菜品类别编号
		/// </summary>
		public int? DishTypeID
		{
			set{ _dishtypeid=value;}
			get{return _dishtypeid;}
		}
		/// <summary>
		/// 菜品成本
		/// </summary>
		public decimal? Cost
		{
			set{ _cost=value;}
			get{return _cost;}
		}
		/// <summary>
		/// 计量单位
		/// </summary>
		public string MeasuringUnit
		{
			set{ _measuringunit=value;}
			get{return _measuringunit;}
		}
		/// <summary>
		/// 菜品价格
		/// </summary>
		public decimal? Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 提成
		/// </summary>
		public decimal? Commission
		{
			set{ _commission=value;}
			get{return _commission;}
		}
		/// <summary>
		/// 当前可用数量
		/// </summary>
		public int? StockGoodsID
		{
			set{ _stockgoodsid=value;}
			get{return _stockgoodsid;}
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

