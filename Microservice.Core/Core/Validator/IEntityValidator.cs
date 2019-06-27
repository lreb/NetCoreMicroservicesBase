using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice.Core.Core.Validator
{
    /// <summary>
    /// Provides methods to validate entities (data, constraints, etc.)
    /// <p>
    /// A validation implementation can use constraint validation classes 
    /// with XML constraint definitions, to enforce data integrity 
    /// prior sending entity to database
    /// </p>
    /// Also, a RetrieveService can be used to validate entity existence, uniqueness, etc
    /// </summary>
    /// <typeparam name="T">Entity Class to be implemented by interface</typeparam>
    /// <typeparam name="K">Parameter Class to be implemented by interface</typeparam>
    /// <typeparam name="L">Class that represents entity's ID</typeparam>
    public interface IEntityValidator<T, K, L>
    {

        /// <summary>
        /// Performs implementation class specific validations
        /// </summary>
        /// <param name="t">Implementation class to validate</param>
        /// <returns>Validation result, represented by Implementation Result Class</returns>
        K Validate(T t);


        /// <summary>
        /// Performs implementation class specific validations
        /// </summary>
        /// <param name="t">Implementation class to validate</param>
        /// <param name="l">Additional parameters for validations</param>
        /// <returns></returns>
        K Validate(T t, L l);
    }
}
