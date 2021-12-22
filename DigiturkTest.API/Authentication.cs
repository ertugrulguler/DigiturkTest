
using Microsoft.AspNetCore.Mvc.Filters;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Principal;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace DigiturkTest.API
{
    public class Authentication:IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
           
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            //var token = context.HttpContext.Request.Headers["token"];
            //var tokenHandler = new JwtSecurityTokenHandler();
            //var validationParameters = new TokenValidationParameters()
            //{
            //    ValidateLifetime = false, // Because there is no expiration in the generated token
            //    ValidateAudience = false, // Because there is no audiance in the generated token
            //    ValidateIssuer = false,   // Because there is no issuer in the generated token
            //    ValidIssuer = "Sample",
            //    ValidAudience = "Sample",
            //    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("deneme"))
            //}

            //SecurityToken validatedToken;
            //IPrincipal principal = tokenHandler.ValidateToken(authToken, validationParameters, out validatedToken);
            //return true; 
        }
    }
}