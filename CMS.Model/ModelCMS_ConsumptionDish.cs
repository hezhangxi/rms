using System;
namespace CMS.Model
{
	/// <summary>
	/// ʵ����ModelCMS_ConsumptionDish ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class ModelCMS_ConsumptionDish
	{
		public ModelCMS_ConsumptionDish()
		{}
		#region Model
		private int _id;
		private string _markid;
		private int? _diskid;
		private int? _disknum;
		private bool _ispresent;
		private int? _tasteid;
		private string _description;
		private string _createperson;
		private DateTime? _createdate;
		private string _modifyperson;
		private DateTime? _modifydate;
		/// <summary>
		/// ��˵�ID
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// ��ʶ
		/// </summary>
		public string MarkID
		{
			set{ _markid=value;}
			get{return _markid;}
		}
		/// <summary>
		/// ��ƷID
		/// </summary>
		public int? DiskID
		{
			set{ _diskid=value;}
			get{return _diskid;}
		}
		/// <summary>
		/// ��Ʒ����
		/// </summary>
		public int? DiskNum
		{
			set{ _disknum=value;}
			get{return _disknum;}
		}
		/// <summary>
		/// �Ƿ�������
		/// </summary>
		public bool IsPresent
		{
			set{ _ispresent=value;}
			get{return _ispresent;}
		}
		/// <summary>
		/// ��ζ���
		/// </summary>
		public int? TasteID
		{
			set{ _tasteid=value;}
			get{return _tasteid;}
		}
		/// <summary>
		/// �������
		/// </summary>
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
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

