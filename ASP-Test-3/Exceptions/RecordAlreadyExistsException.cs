using System;
using System.Net;

namespace AuthTest.Exceptions
{
    public class RecordAlreadyExistsException : CustomException
    {
        public RecordAlreadyExistsException() : base()
        {
            errorCode = "RECORD_ALREADY_EXISTS";
            statusCode = (int)HttpStatusCode.BadRequest;
        }
        public RecordAlreadyExistsException(string message) : base(message)
        {
            errorCode = "RECORD_ALREADY_EXISTS";
            statusCode = (int)HttpStatusCode.BadRequest;
        }
        public RecordAlreadyExistsException(string message, Exception e) : base(message, e)
        {
            errorCode = "RECORD_ALREADY_EXISTS";
            statusCode = (int)HttpStatusCode.BadRequest;
        }
    }
}
