using System;
namespace CMS.Model
{
	/// <summary>
	/// ʵ����ModelT_Right_Module_Map ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class ModelT_Right_Module_Map
	{
		public ModelT_Right_Module_Map()
		{}
		#region Model
		private int _id;
		private int? _rightid;
		private int? _moduleid;
		private string _createperson;
		private DateTime? _createdate;
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
		/// Ȩ��ID
		/// </summary>
		public int? RightID
		{
			set{ _rightid=value;}
			get{return _rightid;}
		}
		/// <summary>
		/// ģ��ID
		/// </summary>
		public int? ModuleID
		{
			set{ _moduleid=value;}
			get{return _moduleid;}
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
		/// �޸�(&U)����
		/// </summary>
		public DateTime? ModifyDate
		{
			set{ _modifydate=value;}
			get{return _modifydate;}
		}
		#endregion Model

	}
}

