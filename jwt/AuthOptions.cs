using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace jwt
{
    public class AuthOptions
    {
        public const string ISSUER = "MyAuthServer";    // издатель токена
        public const string AUDIENCE = "MyAuthClient";  // потребитель токена
        const string KEY = "secretsecret_key43256";
        public const int LIFETIME = 60 * 24 * 30;
        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }
}
