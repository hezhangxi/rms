using System;
namespace CMS.Model
{
	/// <summary>
	/// ʵ����ModelCMS_ReturnGoods ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class ModelCMS_ReturnGoods
	{
		public ModelCMS_ReturnGoods()
		{}
		#region Model
		private int _id;
		private int _goodsborrowid;
		private int? _number;
		private DateTime? _returntime;
		private string _infonote;
		private int? _handlespeopleid;
		private string _modifyperson;
		private DateTime? _modifydate;
		/// <summary>
		/// �����ƷID
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// �����ƷID
		/// </summary>
		public int GoodsBorrowID
		{
			set{ _goodsborrowid=value;}
			get{return _goodsborrowid;}
		}
		/// <summary>
		/// �黹��Ʒ����
		/// </summary>
		public int? Number
		{
			set{ _number=value;}
			get{return _number;}
		}
		/// <summary>
		/// �黹��Ʒ��ʱ��
		/// </summary>
		public DateTime? ReturnTime
		{
			set{ _returntime=value;}
			get{return _returntime;}
		}
		/// <summary>
		/// ��Ϣ��ע
		/// </summary>
		public string InfoNote
		{
			set{ _infonote=value;}
			get{return _infonote;}
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

