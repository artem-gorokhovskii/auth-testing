using AuthTest.Config;
using AuthTest.Entity;
using AuthTest.Exceptions;
using AuthTest.Repository;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace AuthTest.Service
{
    public class AuthService : IAuthService
    {
        public string Auth(string login, string password)
        {
            var identity = GetIdentity(login, password);

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

            return encodedJwt;
        }

        private ClaimsIdentity GetIdentity(string login, string password)
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
            var claims = new List<Claim>
                {
                    new Claim("login", user.Login),
                    new Claim("role", user.Role.ToString())
                };
            ClaimsIdentity claimsIdentity = new ClaimsIdentity(
                claims,
                "Token",
                ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType
            );
            return claimsIdentity;
        }
    }
}
