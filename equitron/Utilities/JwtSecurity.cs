
using Microsoft.IdentityModel.Tokens;
using System.Globalization;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Utilities
{
    public class JwtSecurity
    {
        private static readonly int _expirationTime = 30;

        public static string CreateToken(Guid id, string name, string email)
        {
            var expiration = DateTime.UtcNow.AddMinutes(_expirationTime);
            var token = CreateJwtSecurityToken(id, name, email, expiration, CreateCredentials());
            var tokenHandler = new JwtSecurityTokenHandler();
            return tokenHandler.WriteToken(token);
        }

        private static JwtSecurityToken CreateJwtSecurityToken(Guid id, string name, string email, DateTime expiration, SigningCredentials credentials)
        {
            var claims = CreateClaims(id, name, email);
            var token = new JwtSecurityToken(
                               issuer: "EquitronApiToken",
                                              audience: "EquitronApiToken",
                                                             claims: claims,
                                                                            expires: expiration,
                                                                                           signingCredentials: credentials
                                                                                                      );
            return token;
        }

        private static List<Claim> CreateClaims(Guid id, string name, string email)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, "EquitronApiToken"),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString(CultureInfo.InvariantCulture)),
                new Claim(ClaimTypes.NameIdentifier, id.ToString()),
                new Claim(ClaimTypes.Name, name),
                new Claim(ClaimTypes.Email, email)
            };
            return claims;
        }

        private static SigningCredentials CreateCredentials()
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("this is my custom Secret key for authentication"));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            return credentials;
        }
    }
}
