using System;
using System.Data;
using System.Collections.Generic;
using CMS.DALayer;
using CMS.Model;
namespace CMS.BULayer
{
    /// <summary>
    /// ҵ���߼���BUCMS_VIPClient
    /// </summary>
    /// <remarks></remarks>
	public class BUCMS_VIPClient:IBULayer<ModelCMS_VIPClient>
	{
		private readonly DACMS_VIPClient dal=new DACMS_VIPClient();

        #region IBULayer<ModelCMS_VIPClient> ��Ա
        /// <summary>
        /// �����ֶ����ƺ��ֶ�ֵ���ָ�������ݣ���paramField��paramContent��Ϊ��ʱ��ʾ���ȫ������
        /// </summary>
        /// <param name="IsView">����Դ�Ǳ�����ͼ��false�Ǳ�</param>
        /// <param name="paramField">�ֶ�����</param>
        /// <param name="paramContent">�ֶ�����</param>
        /// <param name="IsFuzzy">�˲�ѯ�Ƿ���ģ��ѯ��false����</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public DataTable GetOrder(bool IsView, string paramField, string paramContent, bool IsFuzzy)
        {
            DataTable myDataTable = new DataTable();
            try
            {
              myDataTable=dal.GetOrder(IsView,paramField,paramContent,IsFuzzy);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return myDataTable;
        }

        /// <summary>
        /// �������ר�Ų�ѯ�ͻ�/��Ա��Ϣ����Ϊ��������Ϣ��һ�ű���
        /// </summary>
        /// <param name="IsClient"></param>
        /// <param name="paramField"></param>
        /// <param name="paramContent"></param>
        /// <returns></returns>
        public DataTable GetOrderVIPClient(bool IsClient, string paramField, string paramContent)
        {
            DataTable myDataTable = new DataTable();
            try
            {
                myDataTable = dal.GetOrderVIPClient(IsClient,paramField,paramContent);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return myDataTable;
        }

        /// <summary>
        /// ר�Ų�ѯ��Ա��Ϣ(Ҫ�õ������ѯ��Sql��䲻һ��)(������������ȫ����ѯ)
        /// </summary>
        /// <returns></returns>
        public DataTable VIPSearch(bool paramIsCondition, string paramFileName, string paramMarvalue)
        {
            DataTable myDataTable = new DataTable();
            try
            {
                myDataTable = dal.VIPSearch(paramIsCondition,paramFileName,paramMarvalue);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return myDataTable;
        }

        /// <summary>
        /// ר�Ų�ѯ��Ա��Ϣ(Ҫ�õ������ѯ��Sql��䲻һ��)��������ѯ
        /// </summary>
        /// <returns></returns>
        public DataTable VIPSearch(bool paramIsCondition, DateTime paramDateStart, DateTime paramDateEnd)
        {
            DataTable myDataTable = new DataTable();
            try
            {
                myDataTable = dal.VIPSearch(paramIsCondition, paramDateStart, paramDateEnd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return myDataTable;
        }

        /// <summary>
        /// ��ȡһ��
        /// </summary>
        /// <returns></returns>
        public DataTable GetOnlyOne(string paramFileName)
        {
            DataTable myDataTable = new DataTable();
            try
            {
                myDataTable = dal.GetOnlyOne(paramFileName);
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
        /// <remarks></remarks>
        public DataTable GetOrder(bool IsView, string paramField, DateTime paramStart, DateTime paramEnd)
        {
            DataTable myDataTable = new DataTable();
            try
            {
                myDataTable = dal.GetOrder(IsView,paramField,paramStart,paramEnd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return myDataTable;
        }

        /// <summary>
        /// ������ʱ��������ѯ��Ա/�ͻ���Ϣ
        /// </summary>
        /// <param name="IsClient"></param>
        /// <param name="paramStart"></param>
        /// <param name="paramEnd"></param>
        /// <returns></returns>
        public DataTable GetOrderVIPClientOnDate(bool IsClient,string paramField, DateTime paramStart, DateTime paramEnd)
        {
            DataTable myDataTable = new DataTable();
            try
            {
                myDataTable = dal.GetOrderVIPClientOnDate(IsClient, paramField, paramStart,paramEnd);
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
        /// <remarks></remarks>
        public VariedEnum.OperatorStatus Update(ModelCMS_VIPClient model)
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
        /// <param name="model">ʵ����ʵ��</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public VariedEnum.OperatorStatus Update(ModelCMS_VIPClient model,string param)
        {
            int tempIntValue = -5;
            try
            {
                tempIntValue = dal.Update(model,param);
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
        /// <param name="model">The model.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public VariedEnum.OperatorStatus Insert(ModelCMS_VIPClient model)
        {
            int tempIntValue = -8;
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
        /// <remarks></remarks>
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
    }
}

