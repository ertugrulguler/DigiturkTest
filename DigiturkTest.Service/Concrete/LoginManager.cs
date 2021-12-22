using System.IdentityModel.Tokens.Jwt;
using System.Threading.Tasks;
using DigiturkTest.Common;
using DigiturkTest.Common.Helper;
using DigiturkTest.Data.Concrete.Models.LoginModels;
using DigiturkTest.Service.Abstract;
using Microsoft.Extensions.Options;

namespace DigiturkTest.Service.Concrete
{
    public class LoginManager : ILoginManager
    {
        private readonly AppSettings _appSettings;

        public LoginManager(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }
      
        public async Task<LoginResponseModel> Login(LoginRequestModel model)
        {
            if (string.IsNullOrEmpty(model.Password) || string.IsNullOrEmpty(model.Username))
                return new LoginResponseModel() { IsSuccess = false, Token = null };

            var validUser = ValidUser(model.Username, model.Password);
            if (validUser)
            {
                
                var token = new TokenHelper(_appSettings).CreateToken(model.Username, model.Password);
                return new LoginResponseModel() { IsSuccess = true, Token = token };
            }

            return new LoginResponseModel() { IsSuccess = false, Token = null };
        }



        public bool ValidUser(string username, string password)
        {
            if (username == "deneme" && password == "1111")
                return true;
            return false;
        }
    }
}