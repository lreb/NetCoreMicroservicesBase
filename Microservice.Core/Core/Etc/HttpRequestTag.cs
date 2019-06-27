using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice.Core.Core.Etc
{
    public static class HttpRequestTag
    {
        public const string INVALID_HTTP_TYPE = "INVALID_HTTP_TYPE";
        public const string INVALID_URL = "INVALID_URL";
        public const string HTTP_REQUEST_TYPE = "HTTP_REQUEST_TYPE";
        public const string HTTP_RETRIEVE_REQUEST = "HTTP_RETRIEVE_REQUEST";
        public const string HTTP_BODY_TYPE = "HTTP_BODY_TYPE";
        public const string HTTP_BODY_TYPE_XML = "HTTP_BODY_TYPE_XML";
        public const string HTTP_BODY_TYPE_JSON = "HTTP_BODY_TYPE_JSON";
        public const string HTTP_BODY_TYPE_APP_FORM_URL_ENCODED = "HTTP_BODY_TYPE_APP_FORM_URL_ENCODED";
        public const string HTTP_BODY_MESSAGE = "HTTP_BODY_MESSAGE";
        public const string HTTP_GET = "HTTP_GET";
        public const string HTTP_POST = "HTTP_POST";
        public const string HTTP_PUT = "HTTP_PUT";
        public const string HTTP_DELETE = "HTTP_DELETE";
        public const string URL = "URL";
        public const string SUCCESS_CODE = "SUCCESS_CODE";
        public const string STATUS_CODE = "STATUS_CODE";
        public const string HTTP_HEAD = "HTTP_HEAD";
        public const string HTTP_PARAMETERS = "HTTP_PARAMETERS";
        public const string HTTP_XML = "HTTP_XML";
        public const string HTTP_USER = "Http_User";
        public const string HTTP_PASSWORD = "Http_Password";
        public const string HTTP_PROTOCOL = "Http_Protocol";
        public const string HTTP_DOMAIN = "Http_Domain";
        public const string HTTP_PORT = "Http_Port";
        public const string HTTP_PATH = "HTTP_PATH";
        public const string XML_XSD_FILE_REQUEST = "XML_XSD_FILE_REQUEST";
        public const string XML_VALIDATE_REQUEST = "XML_VALIDATE_REQUEST";
        public const string XML_VALIDATE_WITH_XSD_REQUEST = "XML_VALIDATE_WITH_XSD_REQUEST";
        public const string XML_XSD_FILE_RESPONSE = "XML_XSD_FILE_RESPONSE";
        public const string XML_CLASS_RESPONSE = "XML_CLASS_RESPONSE";
        public const string XML_VALIDATE_RESPONSE = "XML_VALIDATE_RESPONSE";
        public const string XML_VALIDATE_WITH_XSD_RESPONSE = "XML_VALIDATE_WITH_XSD_RESPONSE";
        public const int SERVER_DOWN = -1;
    }
}
