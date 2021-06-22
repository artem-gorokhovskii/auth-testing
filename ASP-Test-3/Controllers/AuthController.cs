using AuthTest.Entity;
using AuthTest.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        public string Auth([FromBody] Credentials credentials)
        {
            AuthService authService = new AuthService();
            return authService.Auth(credentials.Login, credentials.Password);
        }
    }
}
