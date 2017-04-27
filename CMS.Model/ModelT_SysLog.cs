using System;
namespace CMS.Model
{
	/// <summary>
	/// 实体类ModelT_SysLog 。(属性说明自动提取数据库字段的描述信息)
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
		/// 日志ID
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 日志类型
		/// </summary>
		public int? LogType
		{
			set{ _logtype=value;}
			get{return _logtype;}
		}
		/// <summary>
		/// 操作员ID
		/// </summary>
		public int? OperatorID
		{
			set{ _operatorid=value;}
			get{return _operatorid;}
		}
		/// <summary>
		/// 操作详细描述
		/// </summary>
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
		}
		/// <summary>
		/// 记录时间
		/// </summary>
		public DateTime? RecordDate
		{
			set{ _recorddate=value;}
			get{return _recorddate;}
		}
		#endregion Model

	}
}

