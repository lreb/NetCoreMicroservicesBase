using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;

namespace Microservice.Core.Core.Dao
{
    /// <summary>
    /// Common interface for all services that retrieve, save or update data
    /// <p>Provides retrieve methods to extract data, either by list or entity, using filters</p>
    /// </summary>
    /// <typeparam name="T">Incomming datra Class to be implemented by interface</typeparam>
    /// <typeparam name="L">Outgoing data Class to be implemented by interface</typeparam>
    /// <typeparam name="K">Parameter Class to be implemented by interface</typeparam>
    public interface ICrudDao<T, K, L>
    {

        /// <summary>
        /// Retrieves a list of objects from database, using a filter
        /// </summary>
        /// <param name="filter">Entity class as filter</param>
        /// <param name="param">Additional parameters for method</param>
        /// <returns>All objects on entity</returns>
        ICollection<T> GetEntityList(T filter, L param);
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
        T GetEntity(T filter, L param);
        /// <summary>
        /// Retrieves an entity, using a filter
        /// </summary>
        /// <param name="filter">Entity class as filter</param>
        /// <returns></returns>
        T GetEntity(T filter);
        /// <summary>
        /// Retrieves an entity, using a filter
        /// </summary>
        /// <param name="filter">Entity class as filter</param>
        /// <returns></returns>
        T GetEntity(K id);

        /**
         * Updates a list of objects into database
         * 
         * @param list List of objects to save, based on implementation
         * @return Execution results
         */
        ICollection<T> UpdateEntityList(Collection<T> list);

        /**
         * Updates an object into database
         * 
         * @param t Object to save, based on implementation
         * @return Execution results
         */
        T UpdateEntity(T t);

        /**
         * Updates a list of objects into database, using filters to affect multiple rows
         * 
         * @param filterList List of pair objects that define the filter/values
         * @return Execution results
         */
        ICollection<T> UpdateEntityRange(Collection<T[]> filterList);

        /**
         * Updates a list of objects into database, using a filter to affect multiple rows
         * 
         * @param filter Objects that define the filter/range
         * @param values Object to use to retrieve values, 
         *               used to update all records found in filterList
         * @param params Parameters for method
         * @return Execution results
         */
        ICollection<T> UpdateEntityRange(T filter, T values, L param);

        /**
         * Updates a list of objects into database, using a filter to affect multiple rows
         * 
         * @param filter Objects that define the filter/range
         * @param values Object to use to retrieve values, 
         *               used to update all records found in filterList
         *               @return Execution results
         */
        ICollection<T> UpdateEntityRange(T filter, T values);


        /**
         * Updates entities in database, using a range
         * 
         * @param filter Criteria list with filter and values
         * @return Records updated count
         * @return Execution results
         */
        ICollection<T> UpdateRange(Expression<Func<T, Boolean>> filter);

        /**
         * Updates entities in database, using a range
         * 
         * @param filter Criteria list with filter and values
         * @param params Additional parameters for method
         * @return Records updated count
         */
        ICollection<T> UpdateRange(Expression<Func<T, Boolean>> filter, L param);
        /**
     * Delete entity from database
     * 
     * @param id Entity identifier
     * @throws Exception Hibernate/SQL Exception
     */
        Boolean DeleteEntity(K id);

        /**
         * Saves a list of objects into database
         * 
         * @param list List of objects to save, based on implementation
         * @return method execution result 
         */
        ICollection<T> SaveEntityList(Collection<T> list);

        /**
         * Saves an object into database
         * 
         * @param t Object to save, based on implementation
         * @return method execution result
         */
        T SaveEntity(T t);

        List<Expression<Func<T, Boolean>>> GetPredicates(T filter);

    }
}
