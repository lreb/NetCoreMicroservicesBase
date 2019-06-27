using Microservice.Core.Interfaces.Common.Logger;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice.Services.Services
{
    public class Test
    {
        private ILoggerManager _logger;
        public Test(ILoggerManager logger)
        {
            _logger = logger;
        }
        
    }
}
