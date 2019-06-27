using Microservice.Core.Core.Etc;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Microservice.Core.Core.Service
{
    /// <summary>
    /// Common interface for all services that retrieve data
    /// <p>Provides retrieve methods to extract data, either by list or entity, using filters</p>
    /// </summary>
    /// <typeparam name="T">Entity Class to be implemented by interface</typeparam>
    /// <typeparam name="K">Parameter Class to be implemented by interface</typeparam>
    /// <typeparam name="L">Class that represents entity's ID</typeparam>
    public interface IRetrieveService<T, K, L>
    {
        /// <summary>
        /// Retrieves a list of objects from database, using a filter, wrapping the result in a ResultNotifier object
        /// </summary>
        /// <param name="filter">Entity class as filter</param>
        /// <param name="param">Additional parameters for method</param>
        /// <returns>Result with execution result plus a list of entities found</returns>
        TransactionResult RetrieveResult(T filter, K param);
        /// <summary>
        /// Retrieves a list of objects from database, using a filter, wrapping the result in a ResultNotifier object
        /// </summary>
        /// <param name="filter">Entity class as filter</param>
        /// <returns>Result with execution result plus a list of entities found</returns>
        TransactionResult RetrieveResult(T filter);
        /// <summary>
        /// Retrieves a list of objects from database, using a filter
        /// </summary>
        /// <param name="filter">Entity class as filter</param>
        /// <param name="param">Additional parameters for method</param>
        /// <returns>All objects on entity</returns>
        ICollection<T> GetEntityList(T filter, K param);
        /// <summary>
        /// Retrieves a list of objects from database, using a filter
        /// </summary>
        /// <param name="filter">Entity class as filter</param>
        /// <returns>All objects on entity</returns>
        ICollection<T> GetEntityList(T filter);
        /// <summary>
        /// Retrieves an entity, using a filter
        /// </summary>
        /// <param name="filter">Entity class as filter</param>
        /// <param name="param">Additional parameters for method</param>
        /// <returns>The entity found</returns>
        T GetEntity(T filter, K param);
        /// <summary>
        /// Retrieves an entity, using a filter
        /// </summary>
        /// <param name="filter">Entity class as filter</param>
        /// <returns>The entity found</returns>
        T GetEntity(T filter);
        /// <summary>
        /// Retrieves an entity, using its identifier
        /// </summary>
        /// <param name="id">Entity identifier</param>
        /// <returns>The entity found</returns>
        T GetEntity(L id);

        TransactionResult RetrieveResult(Expression<Func<T, bool>> filter, K param);
        TransactionResult RetrieveResult(Expression<Func<T, bool>> filter);
    }
}
