using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice.Core.Core.Etc
{
    public class TransactionResult
    {
        /// <summary>
        /// ERROR, SUCCESS, WARNING
        /// </summary>
        public Result _code;
        /// <summary>
        /// Contains the message result of tyhe transaction execution
        /// </summary>
        public String _message;
        /// <summary>
        /// Stores an ID for the transaction that was executed
        /// </summary>
        public String _eventId;
        /// <summary>
        /// Stores the data (object) result of the transaction execution
        /// </summary>
        public Object _data;
        /// <summary>
        /// Is true if transaction execution succeed
        /// </summary>
        public Boolean _success;
        /// <summary>
        /// Is true if transaction execution fails
        /// </summary>
        public Boolean _fail;
        /// <summary>
        /// Is true if transaction execution partial succeeds
        /// </summary>
        public Boolean _warning;
        /// <summary>
        /// Collection of detailed messages
        /// </summary>
        public ICollection<MessageDetail> _messageDetail;

        /// <summary>
        /// 
        /// </summary>
        public TransactionResult()
        {
        }

        /// <summary>
        ///	Constructor with code and message. It is private to enforce the factory method usage 
        /// </summary>
        /// <param name="code">Service call code. It can be SUCCESS/WARNING/FAIL</param>
        /// <param name="message">Service call message</param>
        private TransactionResult(Result code, String message)
        {
            this._code = code;
            this._message = message;

            switch (this._code)
            {
                case Result.ERROR:
                    this._fail = true;
                    this._success = false;
                    this._warning = false;
                    break;
                case Result.SUCCESS:
                    this._fail = false;
                    this._success = true;
                    this._warning = false;
                    break;
                case Result.WARNING:
                    this._fail = false;
                    this._success = false;
                    this._warning = true;
                    break;
            }
        }

        /// <summary>
        ///	Constructor with code and message. It is private to enforce the factory method usage 
        /// </summary>
        /// <param name="code">Service call code. It can be SUCCESS/WARNING/FAIL</param>
        /// <param name="message">Service call message</param>
        /// <param name="data">Service call resultData</param>
        private TransactionResult(Result code, String message, Object data)
        {
            this._code = code;
            this._message = message;
            this._data = data;

            switch (this._code)
            {
                case Result.ERROR:
                    this._fail = true;
                    this._success = false;
                    this._warning = false;
                    break;
                case Result.SUCCESS:
                    this._fail = false;
                    this._success = true;
                    this._warning = false;
                    break;
                case Result.WARNING:
                    this._fail = false;
                    this._success = false;
                    this._warning = true;
                    break;
            }
        }

        /// <summary>
        /// Constructor with code, message and event id. It is private to enforce the factory method usage
        /// </summary>
        /// <param name="code">Service call code. It can be SUCCESS/WARNING/FAIL</param>
        /// <param name="message">Service call message</param>
        /// <param name="eventId">Service call id</param>
        private TransactionResult(Result code, String message, String eventId)
        {
            this._code = code;
            this._message = message;
            this._eventId = eventId;

            switch (this._code)
            {
                case Result.ERROR:
                    this._fail = true;
                    this._success = false;
                    this._warning = false;
                    break;
                case Result.SUCCESS:
                    this._fail = false;
                    this._success = true;
                    this._warning = false;
                    break;
                case Result.WARNING:
                    this._fail = false;
                    this._success = false;
                    this._warning = true;
                    break;
            }
        }

        /// <summary>
        /// Constructor with code, message, event id and resultData. It is private to enforce the factory method usage
        /// </summary>
        /// <param name="code">Service call code. It can be SUCCESS/WARNING/FAIL</param>
        /// <param name="message">Service call message</param>
        /// <param name="eventId">Service call id</param>
        /// <param name="data">Service call resultData</param>
        private TransactionResult(Result code, String message, String eventId, Object data)
        {
            this._code = code;
            this._message = message;
            this._eventId = eventId;
            this._data = data;

            switch (this._code)
            {
                case Result.ERROR:
                    this._fail = true;
                    this._success = false;
                    this._warning = false;
                    break;
                case Result.SUCCESS:
                    this._fail = false;
                    this._success = true;
                    this._warning = false;
                    break;
                case Result.WARNING:
                    this._fail = false;
                    this._success = false;
                    this._warning = true;
                    break;
            }
        }

        /// <summary>
        /// Creates a new service call instance with SUCCESS code
        /// </summary>
        /// <param name="message">Successful message to return</param>
        /// <returns>New instance</returns>
        public static TransactionResult CreateSuccessStatus(String message)
        {
            return new TransactionResult(Result.SUCCESS, message);
        }

        /// <summary>
        /// Creates a new service call instance with SUCCESS code
        /// </summary>
        /// <param name="message">Successful message to return</param>
        /// <param name="data">Service call resultData</param>
        /// <returns>New instance</returns>
        public static TransactionResult CreateSuccessStatus(String message, Object data)
        {
            return new TransactionResult(Result.SUCCESS, message, data);
        }

        /// <summary>
        /// Creates a new service call instance with FAIL code
        /// </summary>
        /// <param name="message">Fail message to return</param>
        /// <returns>New instance</returns>
        public static TransactionResult CreateFailStatus(String message)
        {
            return new TransactionResult(Result.ERROR, message);
        }

        /// <summary>
        /// Creates a new service call instance with ERROR code
        /// </summary>
        /// <param name="message">Fail message to return</param>
        /// <param name="messageDetails">List of details</param>
        /// <returns>New Instance</returns>
        public static TransactionResult CreateFailStatus(String message, List<MessageDetail> messageDetails)
        {
            return new TransactionResult(Result.ERROR, message);
        }

        /// <summary>
        /// Creates a new service call instance with WARNING code
        /// </summary>
        /// <param name="message">Warning message to return</param>
        /// <returns>New instance</returns>
        public static TransactionResult CreateWarningStatus(String message)
        {
            return new TransactionResult(Result.WARNING, message);
        }

        /// <summary>
        ///	Creates a new service call instance with WARNING code 
        /// </summary>
        /// <param name="message">Warning message to return</param>
        /// <param name="resultData">New instance</param>
        /// <returns></returns>
        public static TransactionResult CreateWarningStatus(String message, Object resultData)
        {
            return new TransactionResult(Result.WARNING, message, resultData);
        }

        /// <summary>
        /// Creates a new service call instance using a Result Type class to define its code
        /// </summary>
        /// <param name="result">Result Type instance</param>
        /// <param name="message">Service call message to return</param>
        /// <returns>New instance</returns>
        public static TransactionResult CreateStatus(ResultType result, String message)
        {
            return CreateStatus(result, message, "");
        }

        /// <summary>
        ///	Creates a new service call instance using a Result Type class to define its code 
        /// </summary>
        /// <param name="result">Result Type instance</param>
        /// <param name="message">Service call message to return</param>
        /// <param name="resultData"></param>
        /// <returns>New instance</returns>
        public static TransactionResult CreateStatus(ResultType result, String message, Object resultData)
        {
            return CreateStatus(result, message, "", resultData);
        }

        /// <summary>
        /// Creates a new service call instance using a Result Type class to define its code
        /// </summary>
        /// <param name="result">Result Type instance</param>
        /// <param name="message">Service call message to return</param>
        /// <param name="eventId">Service result event id</param>
        /// <returns>New instance</returns>
        public static TransactionResult CreateStatus(ResultType result, String message, String eventId)
        {
            Result code = 0;
            if (result == ResultType.SUCCESS)
            {
                code = Result.SUCCESS;
            }
            else if (result == ResultType.WARNING)
            {
                code = Result.WARNING;
            }
            else if (result == ResultType.ERROR)
            {
                code = Result.ERROR;
            }
            return new TransactionResult(code, message, eventId);
        }

        /// <summary>
        ///	Defines possible message status 
        /// </summary>
        public enum ResultType
        {
            /// <summary>
            /// 
            /// </summary>
            SUCCESS,
            /// <summary>
            /// 
            /// </summary>
            ERROR,
            /// <summary>
            /// 
            /// </summary>
            WARNING,
            /// <summary>
            /// 
            /// </summary>
            NONE,
            /// <summary>
            /// 
            /// </summary>
            INFO
        };

        /// <summary>
        ///	Creates a new service call instance using a Result Type class to define its code 
        /// </summary>
        /// <param name="result">Result Type instance</param>
        /// <param name="message">Service call message to return</param>
        /// <param name="eventId">Service result event id</param>
        /// <param name="resultData"></param>
        /// <returns>New instance</returns>
        public static TransactionResult CreateStatus(ResultType result, String message, String eventId, Object resultData)
        {
            Result code = 0;
            if (result == ResultType.SUCCESS)
            {
                code = Result.SUCCESS;
            }
            else if (result == ResultType.WARNING)
            {
                code = Result.WARNING;
            }
            else if (result == ResultType.ERROR)
            {
                code = Result.ERROR;
            }
            return new TransactionResult(code, message, eventId, resultData);
        }

        /// <summary>
        ///	Gets the service call code 
        /// </summary>
        /// <returns>the code</returns>
        public Result GetCode()
        {
            return _code;
        }
        /// <summary>
        /// Sets the service call code
        /// <p>
        /// FAIL - 0
        /// </p>
        /// <p>
        /// SUCCESS - 1
        /// </p>
        /// <p>
        /// WARNING - 2
        /// </p>
        /// </summary>
        /// <param name="code">value to set</param>
        public void SetCode(Result code)
        {
            this._code = code;
        }

        /// <summary>
        /// Gets the service call message
        /// </summary>
        /// <returns>the message</returns>
        public String GetMessage()
        {
            return this._message;
        }

        /// <summary>
        ///	sets the service call message 
        /// </summary>
        /// <param name="message">value to set</param>
        public void SetMessage(String message)
        {
            this._message = message;
        }
        /// <summary>
        /// Gets the service call detail message list
        /// </summary>
        /// <returns>the detailed message list</returns>
        public ICollection<MessageDetail> GetMessageDetail()
        {
            return this._messageDetail;
        }
        /// <summary>
        /// Sets the service call detailed message list
        /// </summary>
        /// <param name="messageDetail">Value to set</param>
        public void SetMessageDetail(List<MessageDetail> messageDetail)
        {
            this._messageDetail = messageDetail;
        }

        /// <summary>
        /// Allows to add a Message Detail to a TransactionResult
        /// </summary>
        /// <param name="messageDetail">MessageDetail object</param>
        public void AddMessageDetail(MessageDetail messageDetail)
        {
            if (null == this._messageDetail)
            {
                this._messageDetail = new List<MessageDetail>();

            }
            this._messageDetail.Add(messageDetail);
        }

        /// <summary>
        /// Get event id
        /// </summary>
        /// <returns>eventId</returns>
        public String GetEventId()
        {
            return this._eventId;
        }

        /// <summary>
        /// Set event ID
        /// </summary>
        /// <param name="eventId">EventId to set</param>
        public void SetEventId(String eventId)
        {
            this._eventId = eventId;
        }

        /// <summary>
        /// Method to return the data
        /// </summary>
        /// <returns>The result Data</returns>
        public Object GetData()
        {
            return this._data;
        }
    }
}
