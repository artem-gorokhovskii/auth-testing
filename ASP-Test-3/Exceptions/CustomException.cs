using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ASP_Test_3.Exceptions
{
    [Serializable]
    public class CustomException : ApplicationException
    {
        protected int statusCode = (int)HttpStatusCode.InternalServerError;
        protected string errorCode = "UNHANDLED_ERROR";

        public CustomException() : base() { }
        public CustomException(string message) : base(message) { }
        public CustomException(string message, Exception e) : base(message, e) { }

        public int StatusCode => statusCode;
        public string ErrorCode => errorCode;
    }
}
