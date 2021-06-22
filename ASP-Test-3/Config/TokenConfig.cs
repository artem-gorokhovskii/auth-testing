using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthTest.Config
{
    public class TokenConfig
    {
        static TokenConfig()
        {
            string symmetricKey = File.ReadAllText(Path.Combine(
                Directory.GetParent(Environment.CurrentDirectory).ToString(),
                "Secret",
                "TokenSecret.txt"
            ));
            SYMMETRIC_KEY = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(symmetricKey));
        }

        public static string ISSUER = "MyAuthServer";
        public static string AUDIENCE = "MyAuthClient";
        public static int LIFETIME = 1;
        public static SymmetricSecurityKey SYMMETRIC_KEY = null;
    }
}
