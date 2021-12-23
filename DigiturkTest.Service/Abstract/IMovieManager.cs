using System.Collections.Generic;
using System.Threading.Tasks;
using DigiturkTest.Data.Concrete.Entity;
using DigiturkTest.Data.Enums;

namespace DigiturkTest.Service.Abstract
{
    public interface IMovieManager:IBaseManager<Movie>
    {
        Task<List<Movie>> GetMoviesByCategoryAsync(CategoryTypes category); 
    }
}