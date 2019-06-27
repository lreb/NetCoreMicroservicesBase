using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice.Core.Interfaces.Common.Logger
{
    public interface ILoggerManager
    {
        void LogInfo(string message);
        void LogInfo(Exception ex, string message);
        void LogWarn(string message);
        void LogWarn(Exception ex, string message);
        void LogDebug(string message);
        void LogDebug(Exception ex, string message);
        void LogError(string message);
        void LogError(Exception ex, string message);
		void LogFatal(string message);
		void LogFatal(Exception ex, string message);
	}
}
