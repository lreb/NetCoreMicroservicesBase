using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice.Core.Core.Service
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T">Return Type</typeparam>
    /// <typeparam name="K">Object to execute SP</typeparam>
    /// <typeparam name="L">Configuration</typeparam>
    public interface IStoreProcedureService<T, K, L>
    {
        /**
         * Saves an object into database
         * 
         * @param t Object to save, based on implementation
         * @param param Parameters for method
         * @return method execution result 
         */
        T ExecuteSP(K t, L param);

        /**
         * Saves an object into database
         * 
         * @param t Object to save, based on implementation
         * @return method execution result
         */
        T ExecuteSP(K t);
    }
}
