using Microservice.Core.Core.Etc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice.Core.Core.Service
{
    /// <summary>
    /// Common interface for all services that update data
    /// Provides methods to update data, either by list or by entity, using filters
    /// </summary>
    /// <typeparam name="T">Entity Class to be implemented by interface</typeparam>
    /// <typeparam name="K">Parameter Class to be implemented by interface</typeparam>
    public interface IUpdateService<T, K>
    {

        /// <summary>
        /// Updates a list of objects into database
        /// </summary>
        /// <param name="list">List of objects to save, based on implementation</param>
        /// <param name="param">Parameters for method</param>
        /// <returns>Execution results</returns>
        TransactionResult UpdateEntityList(ICollection<T> list, K param);

        /// <summary>
        /// Updates a list of objects into database
        /// </summary>
        /// <param name="list">List of objects to save, based on implementation</param>
        /// <returns>Execution results</returns>
        TransactionResult UpdateEntityList(ICollection<T> list);

        /// <summary>
        /// Updates an object into database
        /// </summary>
        /// <param name="t">Object to save, based on implementation</param>
        /// <param name="param">Parameters for method</param>
        /// <returns>Execution results</returns>
        TransactionResult UpdateEntity(T t, K param);


        /// <summary>
        /// Updates an object into database
        /// </summary>
        /// <param name="t">Object to save, based on implementation</param>
        /// <returns>Execution results</returns>
        TransactionResult UpdateEntity(T t);
    }
}
