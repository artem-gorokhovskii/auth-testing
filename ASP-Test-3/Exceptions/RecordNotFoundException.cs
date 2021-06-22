using System;
using System.Net;

namespace AuthTest.Exceptions
{
    [Serializable]
    public class RecordNotFoundException : CustomException
    {
        public RecordNotFoundException() : base()
        {
            errorCode = "RECORD_NOT_FOUND";
            statusCode = (int)HttpStatusCode.NotFound;
        }
        public RecordNotFoundException(string message) : base(message)
        {
            errorCode = "RECORD_NOT_FOUND";
            statusCode = (int)HttpStatusCode.NotFound;
        }
        public RecordNotFoundException(string message, Exception e) : base(message, e)
        {
            errorCode = "RECORD_NOT_FOUND";
            statusCode = (int)HttpStatusCode.NotFound;
        }
    }
}
