using System;
namespace CMS.Model
{
	/// <summary>
	/// 实体类ModelCMS_PaymentsDetail 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ModelCMS_PaymentsDetail
	{
		public ModelCMS_PaymentsDetail()
		{}
		#region Model
		private int _id;
		private int? _paymenttypeid;
		private decimal? _amount;
		private int? _handlespeopleid;
		private string _infonote;
		private string _createperson;
		private DateTime? _createdate;
		private string _modifyperson;
		private DateTime? _modifydate;
		/// <summary>
		/// 收支明细ID
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 收支类型ID
		/// </summary>
		public int? PaymentTypeID
		{
			set{ _paymenttypeid=value;}
			get{return _paymenttypeid;}
		}
		/// <summary>
		/// 金额
		/// </summary>
		public decimal? Amount
		{
			set{ _amount=value;}
			get{return _amount;}
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
		/// 备注
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

