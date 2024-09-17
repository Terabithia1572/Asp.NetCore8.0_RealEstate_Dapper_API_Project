using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Tools
{
    public class JWTTokenGenerator
    {
        public static TokenResponseViewModel GenerateToken(GetCheckAppUserViewModel getCheckAppUserViewModel)
        {
            var claims =new List<Claim>();
            if (!string.IsNullOrWhiteSpace(getCheckAppUserViewModel.Role))
                claims.Add(new Claim(ClaimTypes.Role, getCheckAppUserViewModel.Role));
            claims.Add(new Claim(ClaimTypes.NameIdentifier, getCheckAppUserViewModel.ID.ToString()));

            if (!string.IsNullOrWhiteSpace(getCheckAppUserViewModel.Username))
                claims.Add(new Claim("Username", getCheckAppUserViewModel.Username));


            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JWTTokenDefaults.Key));
            var signinCredentials = new SigningCredentials(key,SecurityAlgorithms.HmacSha256);
            var expireDate=DateTime.UtcNow.AddDays(JWTTokenDefaults.Expire);
            JwtSecurityToken token = new JwtSecurityToken(issuer: JWTTokenDefaults.ValidIssuer, audience: JWTTokenDefaults.ValidAudience, claims: claims, notBefore: DateTime.UtcNow, expires: expireDate, signingCredentials: signinCredentials);

            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            return new TokenResponseViewModel(tokenHandler.WriteToken(token), expireDate);

        }
    }
}
