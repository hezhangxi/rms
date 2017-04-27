using System;
namespace CMS.Model
{
	/// <summary>
	/// ʵ����ModelCMS_PaymentsDetail ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
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
		/// ��֧��ϸID
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// ��֧����ID
		/// </summary>
		public int? PaymentTypeID
		{
			set{ _paymenttypeid=value;}
			get{return _paymenttypeid;}
		}
		/// <summary>
		/// ���
		/// </summary>
		public decimal? Amount
		{
			set{ _amount=value;}
			get{return _amount;}
		}
		/// <summary>
		/// ������ID
		/// </summary>
		public int? HandlesPeopleID
		{
			set{ _handlespeopleid=value;}
			get{return _handlespeopleid;}
		}
		/// <summary>
		/// ��ע
		/// </summary>
		public string InfoNote
		{
			set{ _infonote=value;}
			get{return _infonote;}
		}
		/// <summary>
		/// ������
		/// </summary>
		public string CreatePerson
		{
			set{ _createperson=value;}
			get{return _createperson;}
		}
		/// <summary>
		/// ����ʱ��
		/// </summary>
		public DateTime? CreateDate
		{
			set{ _createdate=value;}
			get{return _createdate;}
		}
		/// <summary>
		/// �޸�(&U)��
		/// </summary>
		public string ModifyPerson
		{
			set{ _modifyperson=value;}
			get{return _modifyperson;}
		}
		/// <summary>
		/// �޸�(&U)ʱ��
		/// </summary>
		public DateTime? ModifyDate
		{
			set{ _modifydate=value;}
			get{return _modifydate;}
		}
		#endregion Model

	}
}

