using System;
namespace CMS.Model
{
	/// <summary>
	/// ʵ����ModelT_SysLog ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class ModelT_SysLog
	{
		public ModelT_SysLog()
		{}
		#region Model
		private int _id;
		private int? _logtype;
		private int? _operatorid;
		private string _description;
		private DateTime? _recorddate;
		/// <summary>
		/// ��־ID
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// ��־����
		/// </summary>
		public int? LogType
		{
			set{ _logtype=value;}
			get{return _logtype;}
		}
		/// <summary>
		/// ����ԱID
		/// </summary>
		public int? OperatorID
		{
			set{ _operatorid=value;}
			get{return _operatorid;}
		}
		/// <summary>
		/// ������ϸ����
		/// </summary>
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
		}
		/// <summary>
		/// ��¼ʱ��
		/// </summary>
		public DateTime? RecordDate
		{
			set{ _recorddate=value;}
			get{return _recorddate;}
		}
		#endregion Model

	}
}

