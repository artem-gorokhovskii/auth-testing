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
        private static SymmetricSecurityKey symmetricKey = null;
        public static string ISSUER = "AuthTestServer";
        public static string AUDIENCE = "AuthTestClient";
        public static int LIFETIME = 10; // in minutes
        public static SymmetricSecurityKey SYMMETRIC_KEY {
            get {
                if (symmetricKey != null) return symmetricKey;

                string path = Path.GetFullPath(Path.Combine(
                    "Secret",
                    "TokenSecret.txt"
                ));

                symmetricKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(File.ReadAllText(path)));

                return symmetricKey;
            }
        }
    }
}
