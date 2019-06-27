using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice.Core.Exceptions
{
    public class SupportException : Exception
    {
        public SupportException(string message) : base(message)
        {
        }
    }
}
