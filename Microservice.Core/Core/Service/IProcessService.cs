using Microservice.Core.Core.Etc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice.Core.Core.Service
{
    /// <summary>
    /// Common interface for all services that creates a process, using more than one Crud Services
    /// Provides a single method: execute, to create procedural services
    /// </summary>
    /// <typeparam name="T">Data to be processed</typeparam>
    /// <typeparam name="K">Additional parameters to execute method</typeparam>
    public interface IProcessService<T, K>
    {

        /// <summary>
        /// Performs a process execution, involving more than one CRUD service actions
        /// </summary>
        /// <param name="t">Data to be processed</param>
        /// <param name="k">Additional parameters to execute method</param>
        /// <returns>Process execution result</returns>
        TransactionResult Execute(T t, K param);

        void SetAutoCommit(bool value);

        /**
         * Gets the auto commit flag
         * @return the auto commit flag
         */
        bool IsAutoCommit();
    }
}
