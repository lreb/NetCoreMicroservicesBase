using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice.Core.Core.Etc
{
    /// <summary>
	/// Indicates the possible values for a transaction result
	/// </summary>
	/// 
	public enum Result
    {
        /// <summary>
        /// Error
        /// </summary>
        ERROR,
        /// <summary>
        /// Success
        /// </summary>
        SUCCESS,
        /// <summary>
        /// Warning
        /// </summary>
        WARNING
    }
    /// <summary>
    /// Used to set messages and share them through transactions
    /// </summary>
    public class MessageDetail
    {

        /// <summary>
        /// ERROR, SUCCESS, WARNING
        /// </summary>
        public Result type;
        /// <summary>
        /// Stores an ID for the transaction that was executed
        /// </summary>
        public String key;
        /// <summary>
        /// Contains the message result of tyhe transaction execution
        /// </summary>
        public String message;
        /// <summary>
        /// Contains the message detail result of tyhe transaction execution
        /// </summary>
        public String messageDetail;

        /// <summary>
        /// Default constructor
        /// </summary>
        public MessageDetail()
        {
        }

        /// <summary>
        /// Constructor with fields
        /// </summary>
        /// <param name="key">Message identifier. It can be a code, serial number, etc.</param>
        /// <param name="message">Actual message to store, in short format</param>
        /// <param name="messageDetail">Extended/detailed message. It can be an exception text</param>
        public MessageDetail(String key, String message, String messageDetail)
        {
            this.key = key;
            this.message = message;
            this.messageDetail = messageDetail;
        }

        /// <summary>
        /// Create a SUCCESS instance
        /// </summary>
        /// <param name="key">Message identifier. It can be a code, serial number, etc.</param>
        /// <param name="message">Actual message to store, in short format</param>
        /// <param name="messageDetail">Extended/detailed message. It can be an exception text</param>
        /// <returns>New Message Detail Instance</returns>
        public static MessageDetail CreateSuccessMessage(String key, String message, String messageDetail)
        {
            MessageDetail m = new MessageDetail(key, message, messageDetail);
            m.SetType(Result.SUCCESS);
            return m;
        }

        /// <summary>
        /// Create an ERROR instance
        /// </summary>
        /// <param name="key">Message identifier. It can be a code, serial number, etc.</param>
        /// <param name="message">Actual message to store, in short format</param>
        /// <param name="messageDetail">Extended/detailed message. It can be an exception text</param>
        /// <returns></returns>
        public static MessageDetail CreateErrorMessage(String key, String message, String messageDetail)
        {
            MessageDetail m = new MessageDetail(key, message, messageDetail);
            m.SetType(Result.ERROR);
            return m;
        }

        /// <summary>
        ///	Create a WARNING instance
        /// </summary>
        /// <param name="key">Message identifier. It can be a code, serial number, etc.</param>
        /// <param name="message">Actual message to store, in short format</param>
        /// <param name="messageDetail">Extended/detailed message. It can be an exception text</param>
        /// <returns></returns>
        public static MessageDetail CreateWarningMessage(String key, String message, String messageDetail)
        {
            MessageDetail m = new MessageDetail(key, message, messageDetail);
            m.SetType(Result.WARNING);
            return m;
        }

        /// <summary>
        /// Gets the message key / identifier. It can be a serial number, process,
        /// </summary>
        /// <returns>the key</returns>
        public String GetKey()
        {
            return key;
        }

        /// <summary>
        /// Gets the message. This message is intended to be a short description / code
        /// </summary>
        /// <returns>the message</returns>
        public String GetMessage()
        {
            return message;
        }

        /// <summary>
        /// Gets the detailed message description. It can be an exception message, a list of constraints that failed, etc.
        /// </summary>
        /// <returns>the detailed message</returns>
        public String GetMessageDetail()
        {
            return messageDetail;
        }
        /// <summary>
        ///	Gets the message type. It can be successful / error / warning 
        /// </summary>
        /// <returns>the message type</returns>
        public Result GetResultType()
        {
            return type;
        }

        /// <summary>
        ///	Sets the key 
        /// </summary>
        /// <param name="key">Value to set</param>
        public void SetKey(String key)
        {
            this.key = key;
        }

        /// <summary>
        ///	Sets the message 
        /// </summary>
        /// <param name="message">Value to set</param>
        public void SetMessage(String message)
        {
            this.message = message;
        }

        /// <summary>
        ///	Sets the message detail 
        /// </summary>
        /// <param name="messageDetail">Value to set</param>
        public void SetMessageDetail(String messageDetail)
        {
            this.messageDetail = messageDetail;
        }

        /// <summary>
        ///	Sets the message type 
        /// </summary>
        /// <param name="type">Value to set</param>
        public void SetType(Result type)
        {
            this.type = type;
        }

        /// <summary>
        ///	Evaluates if message is SUCCESS 
        /// </summary>
        /// <returns>True for successful messages. False otherwise</returns>
        public bool IsSuccess()
        {
            return type == Result.SUCCESS;
        }

        /// <summary>
        ///	Evaluates if message is ERROR 
        /// </summary>
        /// <returns>True for error messages. False otherwise</returns>
        public bool IsError()
        {
            return type == Result.ERROR;
        }

        /// <summary>
        ///	Evaluates if message is WARNING 
        /// </summary>
        /// <returns>True for warning messages. False otherwise</returns>
        public bool IsWarning()
        {
            return type == Result.WARNING;
        }

        /// <summary>
        ///	Creates serializable representation of the message 
        /// </summary>
        /// <returns>Message data as a String</returns>
        public String ToHtml()
        {
            String typeStr = "";
            switch (type)
            {
                case Result.SUCCESS:
                    typeStr = "SUCCESS";
                    break;
                case Result.ERROR:
                    typeStr = "ERROR";
                    break;
                case Result.WARNING:
                    typeStr = "WARNING";
                    break;
                default:
                    typeStr = "";
                    break;
            }
            return "<tr><td>" + typeStr + "</td><td>" + key + "</td><td>" + message + "</td><td>" + messageDetail + "</td>";
        }
    }
}
