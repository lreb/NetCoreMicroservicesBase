using Microservice.Core.Core.Etc;
using Microservice.Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice.Core.Core.Service
{
    public abstract class BaseService
    {
        private ConfigMap initParams;
        private bool autoCommit;
        //private DbContext _context;

        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseService()
        {
            this.autoCommit = true;
            //this._context = context;
            //resultMessage = new ResultMessage();

        }
        /// <summary>
        /// Validates parameters used by service methods.Parameters are represented by InputParam class and they can be wither optional or mandatory
        /// </summary>
        /// <param name="paramList">Parameter list to validate</param>
        /// <param name="param">Parameters given to service to be validated</param>
        public void Support(ICollection<InputParam> paramList, ConfigMap param)
        {
            Object para;

            if (paramList != null && paramList.Count > 0)
            {
                foreach (InputParam s in paramList)
                {
                    para = param != null && param.ContainsKey(s.GetKey()) ? param[s.GetKey()] : null;
                    if (s.GetClass() == "".GetType() && para != null && Convert.ToString(para).Length == 0) //((String)para).Length == 0)
                    {
                        throw new SupportException("--SupportValidationFailed> Empty value for parameter: " + s);
                    }
                    if (s.IsMandatory() && para == null)
                    {
                        throw new SupportException("--SupportValidationFailed> Mandatory parameter missing: " + s);
                    }
                    else if (!s.IsMandatory() && param.ContainsKey(s.GetKey()) && para == null)
                    {
                        throw new SupportException("--SupportValidationFailed> Optional parameter value not defined: " + s);
                    }
                    else if (para != null && (s.GetType() != null && para.GetType() != s.GetClass()))
                    {
                        throw new SupportException("--SupportValidationFailed> Invalid type for parameter " + s + ". Expected " + s.GetType() + " Found: " + param.Get(s.GetKey(), "").GetType());
                    }
                }
            }
        }
        /// <summary>
        /// Adds an InputParam instance to a given list, with mandatory flag set to true
        /// </summary>
        /// <param name="list">Parameter list to validate</param>
        /// <param name="key">Parameter Name</param>
        /// <param name="type">Parameter Class Type</param>
        public void CreateMandatoryParam(List<InputParam> list, String key, Type type)
        {

            list.Add(InputParam.CreateMandatoryParam(key, type));
        }
        /// <summary>
        /// Adds an InputParam instance to a given list, with mandatory flag set to false
        /// </summary>
        /// <param name="list">Parameter list to validate</param>
        /// <param name="key">Parameter Name</param>
        /// <param name="type">Parameter Class Type</param>
        public void CreateOptionalParam(List<InputParam> list, String key, Type type)
        {
            list.Add(InputParam.CreateOptionalParam(key, type));
        }
        /// <summary>
        /// Adds an InputParam instance to a given list, with Class type set to String and mandatory flag set to true
        /// </summary>
        /// <param name="list">Parameter list to validate</param>
        /// <param name="key">Parameter Name</param>
        public void CreateMandatoryParam(List<InputParam> list, String key)
        {
            list.Add(InputParam.CreateMandatoryParam(key));
        }
        /// <summary>
        /// Adds an InputParam instance to a given list, with Class type set to String and mandatory flag set to false
        /// </summary>
        /// <param name="list">Parameter list to validate</param>
        /// <param name="key">Parameter Name</param>
        public void CreateOptionalParam(List<InputParam> list, String key)
        {
            list.Add(InputParam.CreateOptionalParam(key));
        }
        /// <summary>
        /// Creates parameter list for each method
        /// </summary>
        /// <param name="methodName">Method identifier</param>
        /// <returns>Parameter list created</returns>
        protected List<InputParam> GetParamList(String methodName)
        {
            return null;
        }
        /// <summary>
        /// Creates parameter list for all service
        /// </summary>
        /// <returns>Parameter list created</returns>
        protected List<InputParam> GetParamList()
        {
            return null;
        }
        /// <summary>
        /// Creates initial parameter list for service
        /// </summary>
        /// <returns>Parameter list created</returns>
        protected List<InputParam> GetInitParamList()
        {
            return null;
        }
        /// <summary>
        /// Creates parameter list for all service
        /// </summary>
        /// <returns>Parameter list created</returns>
        public ConfigMap GetInitParams()
        {
            return this.initParams;
        }
        /// <summary>
        /// Set Inti params
        /// </summary>
        /// <param name="initParams">The initParams to set</param>
        public void SetInitParams(ConfigMap initParams)
        {
            this.initParams = initParams;
        }

        /**
     * Gets the auto commit flag
     * 
     * @return the autoCommit
     */
        public bool IsAutoCommit()
        {
            return autoCommit;
        }

        /**
         * Sets the auto commit flag
         * 
         * @param autoCommit the autoCommit to set
         */
        public void SetAutoCommit(bool autoCommit)
        {
            this.autoCommit = autoCommit;
        }

        /*public DbContextTransaction GetOpenSession()
         {
             return null;
         }*/
    }
}
