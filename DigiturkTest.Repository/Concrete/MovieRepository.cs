using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DigiturkTest.Common.Helper;
using DigiturkTest.Data.Concrete.Entity;
using DigiturkTest.Data.Enums;
using DigiturkTest.Repository.Abstract;

namespace DigiturkTest.Repository.Concrete
{
    public class MovieRepository:IMovieRepository
    {
        public async Task<List<Movie>> GetAllAsync()
        {
            return FakeDataHelper.GetAllMovies();
        }

        public Task<Movie> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Movie> GetByFilterAsync(Expression<Func<Movie, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Movie>> GetMoviesByCategoryAsync(CategoryTypes category)
        {
            return FakeDataHelper.GetMoviesByCategory(category);
        }
    }
}