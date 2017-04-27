using System;
namespace CMS.Model
{
	/// <summary>
	/// ʵ����ModelCMS_RetreatDishes ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class ModelCMS_RetreatDishes
	{
		public ModelCMS_RetreatDishes()
		{}
		#region Model
		private int _id;
		private int? _dishid;
		private int? _dishnum;
		private int? _causeid;
		private string _infonote;
		private string _createperson;
		private DateTime? _retreatdate;
		/// <summary>
		/// �˲˼�¼ID
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// ���˲�ƷID
		/// </summary>
		public int? DishID
		{
			set{ _dishid=value;}
			get{return _dishid;}
		}
		/// <summary>
		/// �˲�����
		/// </summary>
		public int? DishNum
		{
			set{ _dishnum=value;}
			get{return _dishnum;}
		}
		/// <summary>
		/// �˲�ԭ����
		/// </summary>
		public int? CauseID
		{
			set{ _causeid=value;}
			get{return _causeid;}
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
		/// ������
		/// </summary>
		public string CreatePerson
		{
			set{ _createperson=value;}
			get{return _createperson;}
		}
		/// <summary>
		/// �˲�ʱ��
		/// </summary>
		public DateTime? RetreatDate
		{
			set{ _retreatdate=value;}
			get{return _retreatdate;}
		}
		#endregion Model

	}
}

