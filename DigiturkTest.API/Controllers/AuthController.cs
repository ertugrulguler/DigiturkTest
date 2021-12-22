using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigiturkTest.Data.Concrete.Models.LoginModels;
using DigiturkTest.Service.Abstract;

namespace DigiturkTest.API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ILoginManager _loginManager;

        public AuthController(ILoginManager loginManager)
        {
            _loginManager = loginManager;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginRequestModel model)
        {
            var respose = await _loginManager.Login(model);
            if (!respose.IsSuccess)
                return Unauthorized();
            return Ok(respose);
        }
    }
}
