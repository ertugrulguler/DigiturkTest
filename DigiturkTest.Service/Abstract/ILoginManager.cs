using System.Threading.Tasks;
using DigiturkTest.Data.Concrete.Models.LoginModels;

namespace DigiturkTest.Service.Abstract
{
    public interface ILoginManager
    {
        Task<LoginResponseModel> Login(LoginRequestModel model);
    }
}