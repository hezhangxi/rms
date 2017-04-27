using System;
namespace CMS.Model
{
	/// <summary>
	/// 实体类ModelCMS_VIPType 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ModelCMS_VIPType
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelCMS_VIPType"/> class.
        /// </summary>
        /// 修改(&U)人：桂书丛
        /// 修改(&U)时间：2013-02-28
		public ModelCMS_VIPType()
		{}
		#region Model
		private int _id;
		private string _name;
		private decimal _discount;
		private string _description;
		private string _createperson;
		private DateTime _createdate;
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
		/// 名称
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 会员优惠
		/// </summary>
		public decimal Discount
		{
			set{ _discount=value;}
			get{return _discount;}
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
		/// 
		/// </summary>
		public string CreatePerson
		{
			set{ _createperson=value;}
			get{return _createperson;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime CreateDate
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

