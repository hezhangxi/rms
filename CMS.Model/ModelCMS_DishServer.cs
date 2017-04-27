using System;
namespace CMS.Model
{
	/// <summary>
	/// ʵ����ModelCMS_DishServer ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class ModelCMS_DishServer
	{
		public ModelCMS_DishServer()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _mnemonicsymbol;
		private int? _dishtypeid;
		private decimal? _cost;
		private string _measuringunit;
		private decimal? _price;
		private decimal? _commission;
		private int? _stockgoodsid;
		private string _infonote;
		private string _createperson;
		private DateTime? _createdate;
		private string _modifyperson;
		private DateTime? _modifydate;
		/// <summary>
		/// ��ƷID
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
		/// ���Ƿ�
		/// </summary>
		public string MnemonicSymbol
		{
			set{ _mnemonicsymbol=value;}
			get{return _mnemonicsymbol;}
		}
		/// <summary>
		/// ��Ʒ�����
		/// </summary>
		public int? DishTypeID
		{
			set{ _dishtypeid=value;}
			get{return _dishtypeid;}
		}
		/// <summary>
		/// ��Ʒ�ɱ�
		/// </summary>
		public decimal? Cost
		{
			set{ _cost=value;}
			get{return _cost;}
		}
		/// <summary>
		/// ������λ
		/// </summary>
		public string MeasuringUnit
		{
			set{ _measuringunit=value;}
			get{return _measuringunit;}
		}
		/// <summary>
		/// ��Ʒ�۸�
		/// </summary>
		public decimal? Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// ���
		/// </summary>
		public decimal? Commission
		{
			set{ _commission=value;}
			get{return _commission;}
		}
		/// <summary>
		/// ��ǰ��������
		/// </summary>
		public int? StockGoodsID
		{
			set{ _stockgoodsid=value;}
			get{return _stockgoodsid;}
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

