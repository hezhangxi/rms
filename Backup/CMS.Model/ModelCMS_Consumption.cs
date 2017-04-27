using System;
namespace CMS.Model
{
	/// <summary>
	/// ʵ����ModelCMS_Consumption ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
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
		/// �����ƷID
		/// </summary>
		public int StockGoodsID
		{
			set{ _stockgoodsid=value;}
			get{return _stockgoodsid;}
		}
		/// <summary>
		/// ������Ʒ����
		/// </summary>
		public int? Number
		{
			set{ _number=value;}
			get{return _number;}
		}
		/// <summary>
		/// ����ʱ��
		/// </summary>
		public DateTime? OutDate
		{
			set{ _outdate=value;}
			get{return _outdate;}
		}
		/// <summary>
		/// ������Ʒ��ע
		/// </summary>
		public string InfoNote
		{
			set{ _infonote=value;}
			get{return _infonote;}
		}
		/// <summary>
		/// ����������
		/// </summary>
		public int? HandlesPeopleID
		{
			set{ _handlespeopleid=value;}
			get{return _handlespeopleid;}
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

