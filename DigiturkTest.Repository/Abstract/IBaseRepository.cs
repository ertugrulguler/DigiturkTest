using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DigiturkTest.Data.Abstract;

namespace DigiturkTest.Repository.Abstract
{
    public interface IBaseRepository<T> where T:class,IEntity,new()
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> GetByFilterAsync(Expression<Func<T, bool>> filter);
    }
}