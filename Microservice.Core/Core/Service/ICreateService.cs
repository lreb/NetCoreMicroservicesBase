using Microservice.Core.Core.Etc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice.Core.Core.Service
{
    public interface ICreateService<T, K>
    {
        /**
     * Saves a list of objects into database
     * 
     * @param list List of objects to save, based on implementation
     * @param param Parameters for method
     * @return method execution result
     */
        TransactionResult SaveEntityList(ICollection<T> list, K param);

        /**
         * Saves a list of objects into database
         * 
         * @param list List of objects to save, based on implementation
         * @return method execution result 
         */
        TransactionResult SaveEntityList(ICollection<T> list);

        /**
         * Saves an object into database
         * 
         * @param t Object to save, based on implementation
         * @param param Parameters for method
         * @return method execution result 
         */
        TransactionResult SaveEntity(T t, K param);

        /**
         * Saves an object into database
         * 
         * @param t Object to save, based on implementation
         * @return method execution result
         */
        TransactionResult SaveEntity(T t);

        //int GetSequence(string sequenceName);
    }
}
