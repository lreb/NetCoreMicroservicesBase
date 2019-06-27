using Microservice.Core.Interfaces.Common.Logger;
using System;
using System.Collections.Generic;
using System.Text;
using NLog;

namespace Microservice.Services.Common
{
    public class LoggerManager : ILoggerManager
    {
        private static ILogger logger = LogManager.GetCurrentClassLogger();
        public void LogDebug(string message)
        {
            logger.Debug(message);
        }

        public void LogDebug(Exception ex, string message)
        {
            logger.Debug(ex, message);
        }

        public void LogError(string message)
        {
            logger.Error(message);
        }

        public void LogError(Exception ex, string message)
        {
            logger.Error(ex, message);
        }

		public void LogFatal(string message)
		{
			logger.Fatal(message);
		}

		public void LogFatal(Exception ex, string message)
		{
			logger.Fatal(ex, message);
		}

		public void LogInfo(string message)
        {
            logger.Info(message);
        }

        public void LogInfo(Exception ex, string message)
        {
            logger.Info(ex, message);
        }

        public void LogWarn(string message)
        {
            logger.Warn(message);
        }

        public void LogWarn(Exception ex, string message)
        {
            logger.Warn(ex, message);
        }
    }
}
