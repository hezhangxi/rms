using System;
namespace CMS.Model
{
	/// <summary>
	/// ʵ����ModelCMS_InGoods ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
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
		/// ��ƷID
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// ��Ʒ����
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
		/// ��Ʒ���
		/// </summary>
		public string Specifications
		{
			set{ _specifications=value;}
			get{return _specifications;}
		}
        /// <summary>
        /// ��Ʒ�ܼ�
        /// </summary>
        public decimal? Total
        {
            set { _total = value; }
            get { return _total; }
        }

		/// <summary>
		/// �������
		/// </summary>
		public int? Number
		{
			set{ _number=value;}
			get{return _number;}
		}
		/// <summary>
		/// ��Ʒ��ⵥ��
		/// </summary>
		public decimal? Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// ��Ӧ��
		/// </summary>
		public string Supplier
		{
			set{ _supplier=value;}
			get{return _supplier;}
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
		/// ���ʱ��
		/// </summary>
		public DateTime? InDate
		{
			set{ _indate=value;}
			get{return _indate;}
		}
		/// <summary>
		/// ��ⱸע
		/// </summary>
		public string InfoNote
		{
			set{ _infonote=value;}
			get{return _infonote;}
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

