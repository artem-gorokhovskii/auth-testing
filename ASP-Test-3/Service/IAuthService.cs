using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthTest.Service
{
    interface IAuthService
    {
        string Auth(string login, string password);
    }
}
