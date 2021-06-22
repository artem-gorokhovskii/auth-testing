using System;
using System.Net;

namespace AuthTest.Exceptions
{
    public class BadRequestException : CustomException
    {
        public BadRequestException() : base()
        {
            errorCode = "BAD_REQUEST";
            statusCode = (int)HttpStatusCode.BadRequest;
        }
        public BadRequestException(string message) : base(message)
        {
            errorCode = "BAD_REQUEST";
            statusCode = (int)HttpStatusCode.BadRequest;
        }
        public BadRequestException(string message, Exception e) : base(message, e)
        {
            errorCode = "BAD_REQUEST";
            statusCode = (int)HttpStatusCode.BadRequest;
        }
    }
}
