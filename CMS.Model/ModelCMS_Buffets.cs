using System;
namespace CMS.Model
{
	/// <summary>
	/// ʵ����ModelCMS_Buffets ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class ModelCMS_Buffets
	{
		public ModelCMS_Buffets()
		{}
		#region Model
		private int _id;
		private string _name;
		private int? _accommodatenum;
		private int? _roomtypeid;
		private int _stateid;
		private string _markid;
		private string _infonote;
		private string _createperson;
		private DateTime? _createdate;
		private string _modifyperson;
		private DateTime? _modifydate;
		/// <summary>
		/// ��̨ID
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// ��̨����
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// ����������
		/// </summary>
		public int? AccommodateNum
		{
			set{ _accommodatenum=value;}
			get{return _accommodatenum;}
		}
		/// <summary>
		/// ����������
		/// </summary>
		public int? RoomTypeID
		{
			set{ _roomtypeid=value;}
			get{return _roomtypeid;}
		}
		/// <summary>
		/// ��̨״̬
		/// </summary>
		public int StateID
		{
			set
            { _stateid=value;}
			get{return _stateid;}
		}
		/// <summary>
		/// �˵����
		/// </summary>
		public string MarkID
		{
			set{ _markid=value;}
			get{return _markid;}
		}
		/// <summary>
		/// ��̨��Ϣ��ע
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

