using System.Collections.Generic;
using System.Threading.Tasks;
using DigiturkTest.Data.Concrete.Entity;
using DigiturkTest.Data.Enums;

namespace DigiturkTest.Repository.Abstract
{
    public interface IMovieRepository:IBaseRepository<Movie>
    {
        Task<List<Movie>> GetMoviesByCategoryAsync(CategoryTypes category); 

    }
}