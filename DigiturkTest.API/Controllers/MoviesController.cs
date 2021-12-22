using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigiturkTest.Service.Abstract;
using Microsoft.AspNetCore.Authorization;

namespace DigiturkTest.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieManager _movieManager;
        public MoviesController(IMovieManager movieManager)
        {
            _movieManager = movieManager;
        }
        [HttpGet("GetAllMovies")]
        public async Task<IActionResult> GetAllMovies()
        {
            var movies = await _movieManager.GetAllAsync();
            return Ok(movies);
        }
    }
}
