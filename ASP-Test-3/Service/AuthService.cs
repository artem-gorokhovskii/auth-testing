using AuthTest.Config;
using AuthTest.Entity;
using AuthTest.Exceptions;
using AuthTest.Repository;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace AuthTest.Service
{
    public class AuthService : IAuthService
    {
        public string Auth(string login, string password)
        {
            UserRepository userRepository = new UserRepository();
            User user = userRepository.GetUser(login);
            if (user == null)
            {
                throw new BadRequestException("Login or password are incorrect");
            }
            
            if (user.Password != password)
            {
                throw new BadRequestException("Login or password are incorrect");
            }

            var now = DateTime.UtcNow;
            // создаем JWT-токен
            var jwt = new JwtSecurityToken(
                    issuer: TokenConfig.ISSUER,
                    audience: TokenConfig.AUDIENCE,
                    notBefore: now,
                    claims: identity.Claims,
                    expires: now.Add(TimeSpan.FromMinutes(TokenConfig.LIFETIME)),
                    signingCredentials: new SigningCredentials(TokenConfig.SYMMETRIC_KEY, SecurityAlgorithms.HmacSha256));
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);
        }

        private Exception UnauthorizedException()
        {
            throw new NotImplementedException();
        }
    }
}
