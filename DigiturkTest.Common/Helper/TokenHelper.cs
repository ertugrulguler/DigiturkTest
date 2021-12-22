using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace DigiturkTest.Common.Helper
{
    public class TokenHelper
    {
        private  readonly AppSettings _appSettings;

        public TokenHelper(AppSettings appSettings)
        {
            _appSettings = appSettings;
        }
        public  SecurityToken CreateToken(string username, string password)
        {

            var tokenHandler = new JwtSecurityTokenHandler();
            //var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var key = Encoding.UTF8.GetBytes(_appSettings.Token.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(JwtRegisteredClaimNames.UniqueName, username),
                    new Claim(JwtRegisteredClaimNames.NameId, password),
                }),
                Issuer = _appSettings.Token.Issuer,
                Audience = _appSettings.Token.Audience,
                Expires = DateTime.UtcNow.AddDays(_appSettings.Token.Expires),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return token;
        }
    }
}