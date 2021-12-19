using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigiturkTest.Service.Abstract;

namespace DigiturkTest.API.Controllers
{
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
            var movies = _movieManager.GetAllAsync();
            return Ok(movies);
        }
    }
}
