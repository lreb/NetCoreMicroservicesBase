using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Microservice.Core.Exceptions
{
    /// <summary>
    /// 
    /// </summary>
    public class MoreThanOneRowFoundException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the System.NotImplementedException class with default properties.
        /// </summary>
        public MoreThanOneRowFoundException() : base()
        {
        }
        //
        // Summary:
        //     Initializes a new instance of the System.NotImplementedException class with a
        //     specified error message.
        //
        // Parameters:
        //   message:
        //     The error message that explains the reason for the exception.
        public MoreThanOneRowFoundException(string message) : base(message)
        {

        }
        //
        // Summary:
        //     Initializes a new instance of the System.NotImplementedException class with a
        //     specified error message and a reference to the inner exception that is the cause
        //     of this exception.
        //
        // Parameters:
        //   message:
        //     The error message that explains the reason for the exception.
        //
        //   inner:
        //     The exception that is the cause of the current exception. If the inner parameter
        //     is not null, the current exception is raised in a catch block that handles the
        //     inner exception.
        public MoreThanOneRowFoundException(string message, Exception inner) : base(message, inner)
        {

        }

        /// <summary>
        /// Create the exception from serialized data.
        /// Usual scenario is when exception is occured somewhere on the remote workstation
        /// and we have to re-create/re-throw the exception on the local machine
        /// </summary>
        /// <param name="info">Serialization info</param>
        /// <param name="context">Serialization context</param>
        protected MoreThanOneRowFoundException(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
}
