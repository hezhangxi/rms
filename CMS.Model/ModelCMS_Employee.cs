using System;
namespace CMS.Model
{
	/// <summary>
	/// ʵ����ModelCMS_Employee ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class ModelCMS_Employee
	{
		public ModelCMS_Employee()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _sex;
        private int? _age;
        private string _degree;
        private DateTime? _birthdate;
		private int? _posid;
        private DateTime? _entrydate;
		private int? _stateid;
        private string _photo;
		private string _telphone;
		private string _idcardnum;
		private string _address;
		private string _infonote;
		private string _createperson;
		private DateTime? _createdate;
		private string _modifyperson;
		private DateTime? _modifydate;
		/// <summary>
		/// Ա�����
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// Ա������
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// Ա���Ա�
		/// </summary>
		public string Sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
        /// <summary>
        /// ����
        /// </summary>
        public int? Age
        {
            set { _age = value; }
            get { return _age; }
        }
        /// <summary>
        /// ѧ��
        /// </summary>
        public string Degree
        {
            set { _degree = value; }
            get { return _degree; }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public DateTime? BirthDate
        {
            set { _birthdate = value; }
            get { return _birthdate; }
        }
		/// <summary>
		/// Ա��ְλID
		/// </summary>
		public int? PosID
		{
			set{ _posid=value;}
			get{return _posid;}
		}
        /// <summary>
        /// ��ְʱ��
        /// </summary>
        public DateTime? EntryDate
        {
            set { _entrydate = value; }
            get { return _entrydate; }
        }
		/// <summary>
		/// Ա������״̬ID
		/// </summary>
		public int? StateID
		{
			set{ _stateid=value;}
			get{return _stateid;}
		}
		/// <summary>
		/// Ա����Ƭ
		/// </summary>
		public string Photo
		{
			set{ _photo=value;}
			get{return _photo;}
		}
		/// <summary>
		/// �绰����
		/// </summary>
		public string TelPhone
		{
			set{ _telphone=value;}
			get{return _telphone;}
		}
		/// <summary>
		/// ���֤����
		/// </summary>
		public string IDCardNum
		{
			set{ _idcardnum=value;}
			get{return _idcardnum;}
		}
		/// <summary>
		/// ��ͥסַ
		/// </summary>
		public string Address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// Ա����Ϣ��ע
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
		/// 
		/// </summary>
		public DateTime? ModifyDate
		{
			set{ _modifydate=value;}
			get{return _modifydate;}
		}
		#endregion Model

	}
}

