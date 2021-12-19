using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DigiturkTest.Data.Concrete.Entity;
using DigiturkTest.Repository.Abstract;
using DigiturkTest.Service.Abstract;

namespace DigiturkTest.Service.Concrete
{
    public class MovieManager:IMovieManager
    {
        private readonly IMovieRepository _movieRepository;
        public MovieManager(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public async Task<List<Movie>> GetAllAsync()
        {
            return await _movieRepository.GetAllAsync();
        }

        public async Task<Movie> GetByIdAsync(int id)
        {
            return await _movieRepository.GetByIdAsync(id);
        }

        public async Task<Movie> GetByFilterAsync(Expression<Func<Movie, bool>> filter)
        {
            return await _movieRepository.GetByFilterAsync(filter);
        }
    }
}