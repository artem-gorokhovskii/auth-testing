using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AuthTest.Exceptions
{
    public class UnauthorizedException : CustomException
    {
        public UnauthorizedException() : base()
        {
            errorCode = "UNAUTHORIZED";
            statusCode = (int)HttpStatusCode.Unauthorized;
        }
        public UnauthorizedException(string message) : base(message)
        {
            errorCode = "UNAUTHORIZED";
            statusCode = (int)HttpStatusCode.Unauthorized;
        }
        public UnauthorizedException(string message, Exception e) : base(message, e)
        {
            errorCode = "UNAUTHORIZED";
            statusCode = (int)HttpStatusCode.Unauthorized;
        }
    }
}
