using System;
namespace CMS.Model
{
	/// <summary>
	/// 实体类ModelCMS_ConsumptionReg 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ModelCMS_ConsumptionReg
	{
		public ModelCMS_ConsumptionReg()
		{}
		#region Model
		private int _id;
		private int? _customernum;
		private int? _buffetsid;
		private int? _employeeid;
		private int? _typeid;
		private bool _ispaied;
		private decimal? _totalamount;
		private int? _paytypeid;
		private string _markid;
		private bool _isvip;
		private int? _vipid;
		private string _description;
		private string _createperson;
		private DateTime? _createdate;
		private string _modifyperson;
		private DateTime? _modifydate;
		/// <summary>
		/// ID
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// ?来宾数量
		/// </summary>
		public int? CustomerNum
		{
			set{ _customernum=value;}
			get{return _customernum;}
		}
		/// <summary>
		/// 桌台编号
		/// </summary>
		public int? BuffetsID
		{
			set{ _buffetsid=value;}
			get{return _buffetsid;}
		}
		/// <summary>
		/// 服务员工ID
		/// </summary>
		public int? EmployeeID
		{
			set{ _employeeid=value;}
			get{return _employeeid;}
		}
		/// <summary>
		/// 消费方式
		/// </summary>
		public int? TypeID
		{
			set{ _typeid=value;}
			get{return _typeid;}
		}
		/// <summary>
		/// 是否付账
		/// </summary>
		public bool IsPaied
		{
			set{ _ispaied=value;}
			get{return _ispaied;}
		}
		/// <summary>
		/// 消费总金额
		/// </summary>
		public decimal? TotalAmount
		{
			set{ _totalamount=value;}
			get{return _totalamount;}
		}
		/// <summary>
		/// 支付方式
		/// </summary>
		public int? PayTypeID
		{
			set{ _paytypeid=value;}
			get{return _paytypeid;}
		}
		/// <summary>
		/// 标识ID（用于联系注册登记表和点菜表）
		/// </summary>
		public string MarkID
		{
			set{ _markid=value;}
			get{return _markid;}
		}
		/// <summary>
		/// 是否是VIP消费
		/// </summary>
		public bool IsVIP
		{
			set{ _isvip=value;}
			get{return _isvip;}
		}
		/// <summary>
		/// VIP编号
		/// </summary>
		public int? VIPID
		{
			set{ _vipid=value;}
			get{return _vipid;}
		}
		/// <summary>
		/// 描述
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

