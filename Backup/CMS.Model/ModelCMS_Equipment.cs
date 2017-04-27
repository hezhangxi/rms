using System;
namespace CMS.Model
{
	/// <summary>
	/// ʵ����ModelCMS_Equipment ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class ModelCMS_Equipment
	{
		public ModelCMS_Equipment()
		{}
		#region Model
		private int _id;
		private bool _condition;
		private bool _fan;
		private bool _tv;
		private bool _dvd;
		private string _other;
		private string _createperson;
		private DateTime? _createdate;
		private string _modifyperson;
		private DateTime? _modifydate;
		/// <summary>
		/// �����豸ID
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// �Ƿ��пյ�
		/// </summary>
		public bool Condition
		{
			set{ _condition=value;}
			get{return _condition;}
		}
		/// <summary>
		/// �Ƿ��з���
		/// </summary>
		public bool Fan
		{
			set{ _fan=value;}
			get{return _fan;}
		}
		/// <summary>
		/// �Ƿ��вʵ�
		/// </summary>
		public bool TV
		{
			set{ _tv=value;}
			get{return _tv;}
		}
		/// <summary>
		/// �Ƿ���DVD
		/// </summary>
		public bool DVD
		{
			set{ _dvd=value;}
			get{return _dvd;}
		}
		/// <summary>
		/// ������ע�豸
		/// </summary>
		public string Other
		{
			set{ _other=value;}
			get{return _other;}
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

