using System;
using System.Data;
using System.Collections.Generic;
using CMS.DALayer;

using CMS.Model;
namespace CMS.BULayer
{
	/// <summary>
	/// ҵ���߼���BUCMS_RetreatDishes   
	/// </summary>
	public class BUCMS_RetreatDishes:IBULayer<ModelCMS_RetreatDishes>
	{
		private readonly DACMS_RetreatDishes dal=new DACMS_RetreatDishes();

        #region IBULayer<ModelCMS_RetreatDishes> ��Ա

        /// <summary>
        /// �����ֶ����ƺ��ֶ�ֵ���ָ�������ݣ���paramField��paramContent��Ϊ��ʱ��ʾ���ȫ������
        /// </summary>
        /// <param name="IsView">����Դ�Ǳ�����ͼ��false�Ǳ�</param>
        /// <param name="paramField">�ֶ�����</param>
        /// <param name="paramContent">�ֶ�����</param>
        /// <param name="IsFuzzy">�˲�ѯ�Ƿ���ģ��ѯ��false����</param>
        /// <returns></returns>
        /// �����ˣ������
        /// �������ڣ�2013-02-22
        public DataTable GetOrder(bool IsView, string paramField, string paramContent, bool IsFuzzy)
        {
            DataTable myDataTable = null;
            try
            {
                myDataTable = dal.GetOrder(IsView, paramField, paramContent, IsFuzzy);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return myDataTable;
        }


        /// <summary>
        /// �����ֶ����ƺ��ֶ�ֵ���ָ�������ݣ��˷������ʱ���ѯ
        /// </summary>
        /// <param name="IsView">����Դ�Ǳ�����ͼ��false�Ǳ�</param>
        /// <param name="paramField">�ֶ�����</param>
        /// <param name="paramStart">��ʼʱ��</param>
        /// <param name="paramEnd">����ʱ��</param>
        /// <returns></returns>
        /// �����ˣ������
        /// ����ʱ�䣺2013-2-23
        public DataTable GetOrder(bool IsView, string paramField, DateTime paramStart, DateTime paramEnd)
        {
            DataTable myDataTable = null;
            try
            {
                myDataTable = dal.GetOrder(IsView, paramField, paramStart, paramEnd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return myDataTable;
        }

        /// <summary>
        /// ����һ�����ݼ�¼
        /// </summary>
        /// <param name="model">ʵ����ʵ��</param>
        /// <returns></returns>
        /// �����ˣ������
        /// �������ڣ�2013-02-22
        public VariedEnum.OperatorStatus Update(ModelCMS_RetreatDishes model)
        {
            int tempIntValue = -5;
            try
            {
                tempIntValue = dal.Update(model);
                if (tempIntValue > 0)
                    return VariedEnum.OperatorStatus.Successed;
                else
                    return VariedEnum.OperatorStatus.Failed;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// ����һ�����ݼ�¼
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// �����ˣ������
        /// �������ڣ�2013-02-22
        public VariedEnum.OperatorStatus Insert(ModelCMS_RetreatDishes model)
        {
            int tempIntValue = -5;
            try
            {
                tempIntValue = dal.Insert(model);
                if (tempIntValue > 0)
                    return VariedEnum.OperatorStatus.Successed;
                else
                    return VariedEnum.OperatorStatus.Failed;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// ɾ��(&D)һ�����ݼ�¼
        /// </summary>
        /// <param name="paramID">��¼ID</param>
        /// <returns></returns>
        /// �����ˣ������
        /// �������ڣ�2013-02-23
        public VariedEnum.OperatorStatus Delete(string paramID)
        {
            int tempIntValue = -5;
            try
            {
                tempIntValue = dal.Delete(paramID);
                if (tempIntValue > 0)
                    return VariedEnum.OperatorStatus.Successed;
                else
                    return VariedEnum.OperatorStatus.Failed;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region public int ClearRetreatDishes() ��������˲˼�¼
        /// <summary>
        /// ��������˲˼�¼
        /// </summary>
        public int ClearRetreatDishes()
        {
            int returnIntValue = -5;
            try
            {
                returnIntValue = dal.ClearRetreatDishes();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return returnIntValue;
        }
        #endregion

        #region public DataTable GetOrder(string paramFileName,string paramMarValue) ��ѯ(��������)�������ֶβ�ѯ
        /// <summary>
        ///  ��ѯ(��������)�������ֶβ�ѯ
        /// </summary>
        /// <param name="paramFileName"></param>
        /// <param name="paramMarValue"></param>
        /// <returns></returns>
        public DataTable GetOrder(string paramFileName, string paramMarValue)
        {
            DataTable myDataTable = null;
            try
            {
                myDataTable = dal.GetOrder(paramFileName, paramMarValue);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return myDataTable;
        }
        #endregion

        #region public DataTable GetOrder(DateTime paramDateStart, DateTime paramDateEn) ��ѯ(��������)ר�Ű�ʱ���ѯ
        /// <summary>
        ///  ��ѯ(��������)ר�Ű�ʱ���ѯ
        /// </summary>
        /// <param name="paramFileName"></param>
        /// <param name="paramMarValue"></param>
        /// <returns></returns>
        public DataTable GetOrder(DateTime paramDateStart, DateTime paramDateEn)
        {
            DataTable myDataTable = null;
            try
            {
                myDataTable = dal.GetOrder(paramDateStart, paramDateEn);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return myDataTable;
        }
        #endregion
    }
}

