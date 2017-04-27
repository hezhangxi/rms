using System;
namespace CMS.Model
{
	/// <summary>
	/// ʵ����ModelCMS_VIPClient ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class ModelCMS_VIPClient
	{
		public ModelCMS_VIPClient()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _sex;
		private string _telphone;
		private int? _viptypeid;
		private string _position;
		private string _depname;
		private string _address;
		private bool _isclient;
		private decimal? _vipcost;
		private string _infonote;
		private string _createperson;
		private DateTime? _createdate;
        private DateTime _rechargedate;
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
		/// ����
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TelPhone
		{
			set{ _telphone=value;}
			get{return _telphone;}
		}
		/// <summary>
		/// VIP������
		/// </summary>
		public int? VIPTypeID
		{
			set{ _viptypeid=value;}
			get{return _viptypeid;}
		}
		/// <summary>
		/// ְλ
		/// </summary>
		public string Position
		{
			set{ _position=value;}
			get{return _position;}
		}
		/// <summary>
		/// ��λ����
		/// </summary>
		public string DepName
		{
			set{ _depname=value;}
			get{return _depname;}
		}
		/// <summary>
		/// ��ַ
		/// </summary>
		public string Address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// �Ƿ�Ϊ�ͻ�
		/// </summary>
		public bool IsClient
		{
			set{ _isclient=value;}
			get{return _isclient;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? VIPCost
		{
			set{ _vipcost=value;}
			get{return _vipcost;}
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
		/// ����ʱ��
		/// </summary>
		public DateTime? CreateDate
		{
			set{ _createdate=value;}
			get{return _createdate;}
		}

        /// <summary>
        /// ����ֵʱ��
        /// </summary>
        public DateTime RechargeDate
        {
            set { _rechargedate = value; }
            get { return _rechargedate; }
        }
		/// <summary>
		/// 
		/// </summary>
		public string ModifyPerson
		{
            set { _modifyperson = value; }
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

