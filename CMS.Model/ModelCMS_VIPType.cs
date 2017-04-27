using System;
namespace CMS.Model
{
	/// <summary>
	/// ʵ����ModelCMS_VIPType ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class ModelCMS_VIPType
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelCMS_VIPType"/> class.
        /// </summary>
        /// �޸�(&U)�ˣ������
        /// �޸�(&U)ʱ�䣺2013-02-28
		public ModelCMS_VIPType()
		{}
		#region Model
		private int _id;
		private string _name;
		private decimal _discount;
		private string _description;
		private string _createperson;
		private DateTime _createdate;
		private string _modifyperson;
		private DateTime? _modifydate;
		/// <summary>
		/// ID
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
		/// ��Ա�Ż�
		/// </summary>
		public decimal Discount
		{
			set{ _discount=value;}
			get{return _discount;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CreatePerson
		{
			set{ _createperson=value;}
			get{return _createperson;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime CreateDate
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

