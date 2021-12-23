using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigiturkTest.Data.Concrete.Entity;
using DigiturkTest.Data.Enums;
using DigiturkTest.Service.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using NLog;

namespace DigiturkTest.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieManager _movieManager;
        private readonly IMemoryCache _memoryCache;
        //private readonly ILogger<MoviesController> _logger;
        private readonly string movieCacheKey = "movieCacheKey";
        private readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public MoviesController(IMovieManager movieManager, IMemoryCache memoryCache)
        {
            _movieManager = movieManager;
            _memoryCache = memoryCache;
        }
        [HttpGet("GetAllMovies")]
        public async Task<IActionResult> GetAllMovies()
        {
            _logger.Info("GetAllMovies started");
            List<Movie> movies = null;
            if (_memoryCache.TryGetValue(movieCacheKey, out movies))
            {
                return Ok(movies);
            }

            movies = await _movieManager.GetAllAsync();
            _logger.Info("Chaching starting for Movies");

            _memoryCache.Set(movieCacheKey, movies, new MemoryCacheEntryOptions()
            {

                AbsoluteExpiration = DateTimeOffset.Now.AddHours(1),
                Priority = CacheItemPriority.Normal
            });

            return Ok(movies);
        }

        [HttpGet("GetMoviesByCategory")]
        public async Task<IActionResult> GetMoviesByCategory(CategoryTypes category)
        {
            var movies = await _movieManager.GetMoviesByCategoryAsync(category);
            return Ok(movies);
        }
    }
}
