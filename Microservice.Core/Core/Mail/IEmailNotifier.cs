using Microservice.Core.Core.Etc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice.Core.Core.Mail
{
    /// <summary>
    /// Provide methods to send mail messages
    /// </summary>
    /// <typeparam name="T">Class with results to be included in mail message</typeparam>
    /// <typeparam name="K">Class with additional parameters needed to send emails</typeparam>
    public interface IEmailNotifier<T, K>
    {
        /// <summary>
        /// Constructor with server and sender address
        /// </summary>
        /// <param name="server">Email server address/name</param>
        /// <param name="fromAddress">Email address that will send the messages</param>
        /// <returns>IEmailNotifier Instance</returns>
        IEmailNotifier<T, K> CreateInstance(String server, String fromAddress);
        /// <summary>
        /// Sends an email message
        /// </summary>
        /// <param name="recipientList">Comma separated address list</param>
        /// <param name="subject">Message subject</param>
        /// <param name="messageText">Message body</param>
        /// <returns>Email processing result. It may be used to evaluate if the message was successfully sent</returns>
        TransactionResult SendMail(String recipientList, String subject, String messageText);
        /// <summary>
        /// Comma separated address list
        /// </summary>
        /// <param name="recipientList">Comma separated address list</param>
        /// <param name="subject">Message subject</param>
        /// <param name="messageHeader">Message header for text body</param>
        /// <param name="messageText">Message body</param>
        /// <param name="messageTrailer">Message text to append to the end of body message</param>
        /// <returns>Email processing result. It may be used to evaluate if the message was successfully sent</returns>
        TransactionResult SendMail(String recipientList, String subject, String messageHeader, String messageText, String messageTrailer);
        /// <summary>
        /// Comma separated address list
        /// </summary>
        /// <param name="recipientList">Comma separated address list</param>
        /// <param name="subject">Message subject</param>
        /// <param name="messageHeader">Message header for text body</param>
        /// <param name="messageText">Message body</param>
        /// <param name="messageTrailer">Message text to append to the end of body message</param>
        /// <param name="messageDetail">Message List to be added to message</param>
        /// <returns>Email processing result. It may be used to evaluate if the message was successfully sent</returns>
        TransactionResult SendMail(String recipientList, String subject, String messageHeader, String messageText, String messageTrailer, T messageDetail);
        /// <summary>
        /// Sends email, using a result message class and configuration parameters
        /// </summary>
        /// <param name="messageText">Message to send</param>
        /// <param name="messageDetail">Message List to be added to message</param>
        /// <param name="param">Parameter class container with email information (address list, subject, etc)</param>
        /// <returns>Email processing result. It may be used to evaluate if the message was successfully sent</returns>
        TransactionResult SendMail(String messageText, T messageDetail, K param);
    }
}
