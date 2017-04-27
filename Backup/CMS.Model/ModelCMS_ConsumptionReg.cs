using System;
namespace CMS.Model
{
	/// <summary>
	/// ʵ����ModelCMS_ConsumptionReg ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
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
		/// ?��������
		/// </summary>
		public int? CustomerNum
		{
			set{ _customernum=value;}
			get{return _customernum;}
		}
		/// <summary>
		/// ��̨���
		/// </summary>
		public int? BuffetsID
		{
			set{ _buffetsid=value;}
			get{return _buffetsid;}
		}
		/// <summary>
		/// ����Ա��ID
		/// </summary>
		public int? EmployeeID
		{
			set{ _employeeid=value;}
			get{return _employeeid;}
		}
		/// <summary>
		/// ���ѷ�ʽ
		/// </summary>
		public int? TypeID
		{
			set{ _typeid=value;}
			get{return _typeid;}
		}
		/// <summary>
		/// �Ƿ���
		/// </summary>
		public bool IsPaied
		{
			set{ _ispaied=value;}
			get{return _ispaied;}
		}
		/// <summary>
		/// �����ܽ��
		/// </summary>
		public decimal? TotalAmount
		{
			set{ _totalamount=value;}
			get{return _totalamount;}
		}
		/// <summary>
		/// ֧����ʽ
		/// </summary>
		public int? PayTypeID
		{
			set{ _paytypeid=value;}
			get{return _paytypeid;}
		}
		/// <summary>
		/// ��ʶID��������ϵע��ǼǱ�͵�˱�
		/// </summary>
		public string MarkID
		{
			set{ _markid=value;}
			get{return _markid;}
		}
		/// <summary>
		/// �Ƿ���VIP����
		/// </summary>
		public bool IsVIP
		{
			set{ _isvip=value;}
			get{return _isvip;}
		}
		/// <summary>
		/// VIP���
		/// </summary>
		public int? VIPID
		{
			set{ _vipid=value;}
			get{return _vipid;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
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

