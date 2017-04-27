using System;
namespace CMS.Model
{
	/// <summary>
	/// 实体类ModelCMS_RoomType 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ModelCMS_RoomType
	{
		public ModelCMS_RoomType()
		{}
		#region Model
		private int _id;
		private string _name;
		private int? _floorid;
		private int? _equipmentid;
		private string _description;
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
		/// 包厢名称
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 所在楼层
		/// </summary>
		public int? FloorID
		{
			set{ _floorid=value;}
			get{return _floorid;}
		}
		/// <summary>
		/// 设备编号
		/// </summary>
		public int? EquipmentID
		{
			set{ _equipmentid=value;}
			get{return _equipmentid;}
		}
		/// <summary>
		/// 包厢描述
		/// </summary>
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
		}
		/// <summary>
		/// 创建人
		/// </summary>
		public string CreatePerson
		{
			set{ _createperson=value;}
			get{return _createperson;}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? CreateDate
		{
			set{ _createdate=value;}
			get{return _createdate;}
		}
		/// <summary>
		/// 修改(&U)人
		/// </summary>
		public string ModifyPerson
		{
			set{ _modifyperson=value;}
			get{return _modifyperson;}
		}
		/// <summary>
		/// 修改(&U)时间
		/// </summary>
		public DateTime? ModifyDate
		{
			set{ _modifydate=value;}
			get{return _modifydate;}
		}
		#endregion Model

	}
}

