using System;
namespace CMS.Model
{
	/// <summary>
	/// ʵ����ModelCMS_Stock ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class ModelCMS_Stock
	{
		public ModelCMS_Stock()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _supplier;
		private string _specifications;
		private decimal? _price;
        private decimal? _total;
		private int? _number;
		private string _infonote;
		private int? _handlespeopleid;
		/// <summary>
		/// �����Ʒ���
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
		/// <summary>
		/// ��Ӧ��
		/// </summary>
		public string Supplier
		{
			set{ _supplier=value;}
			get{return _supplier;}
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
		/// ��Ʒ����
		/// </summary>
		public decimal? Price
		{
			set{ _price=value;}
			get{return _price;}
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
		/// ��Ʒ������
		/// </summary>
		public int? Number
		{
			set{ _number=value;}
			get{return _number;}
		}
		/// <summary>
		/// ��Ʒ��Ϣ��ע
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
		#endregion Model

	}
}

