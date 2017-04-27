using System;
namespace CMS.Model
{
	/// <summary>
	/// ʵ����ModelCMS_BuffetBooking ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class ModelCMS_BuffetBooking
	{
		public ModelCMS_BuffetBooking()
		{}
		#region Model
		private int _id;
		private int? _buffetsid;
		private string _cname;
		private string _ctelphone;
        private string _transactor;
		private int? _cnum;
		private DateTime? _bookdate;
		private DateTime? _overduttime;
		private string _infonote;
		private string _modifyperson;
		private DateTime? _modifydate;
		/// <summary>
		/// Ԥ����̨ID
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// ҪԤ���Ĳ�̨
		/// </summary>
		public int? BuffetsID
		{
			set{ _buffetsid=value;}
			get{return _buffetsid;}
		}
		/// <summary>
		/// Ԥ��������
		/// </summary>
		public string CName
		{
			set{ _cname=value;}
			get{return _cname;}
		}
		/// <summary>
		/// Ԥ���˵绰
		/// </summary>
		public string CTelPhone
		{
			set{ _ctelphone=value;}
			get{return _ctelphone;}
		}
		/// <summary>
		/// ������
		/// </summary>
        public string Transactor
		{
            set { _transactor = value; }
            get { return _transactor; }
		}
		/// <summary>
		/// ��������
		/// </summary>
		public int? CNum
		{
			set{ _cnum=value;}
			get{return _cnum;}
		}
		/// <summary>
		/// Ԥ��ʱ��
		/// </summary>
		public DateTime? BooKDate
		{
			set{ _bookdate=value;}
			get{return _bookdate;}
		}
		/// <summary>
		/// ʧЧʱ��
		/// </summary>
		public DateTime? OverduTtime
		{
			set{ _overduttime=value;}
			get{return _overduttime;}
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

