using System;
namespace CMS.Model
{
	/// <summary>
	/// ʵ����ModelT_User ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class ModelT_User
	{
		public ModelT_User()
		{}
		#region Model
		private int _id;
		private string _username;
		private string _userpwd;
		private int _userrightid;
		private string _createperson;
		private DateTime? _createdate;
		private string _modifyperson;
		private DateTime? _modifydate;
		private string _infonote;
		/// <summary>
		/// �û�ID
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// �û�����
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// �û�����
		/// </summary>
		public string UserPWD
		{
			set{ _userpwd=value;}
			get{return _userpwd;}
		}
		/// <summary>
		/// �û���ɫ����
		/// </summary>
		public int UserRightID
		{
			set{ _userrightid=value;}
			get{return _userrightid;}
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
		/// ��������
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
		/// �޸�(&U)����
		/// </summary>
		public DateTime? ModifyDate
		{
			set{ _modifydate=value;}
			get{return _modifydate;}
		}
		/// <summary>
		/// ��Ϣ��ע
		/// </summary>
		public string InfoNote
		{
			set{ _infonote=value;}
			get{return _infonote;}
		}
		#endregion Model

	}
}

