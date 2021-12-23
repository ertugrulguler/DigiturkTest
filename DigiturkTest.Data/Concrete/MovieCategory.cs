using DigiturkTest.Data.Abstract;
using DigiturkTest.Data.Concrete.Entity;

namespace DigiturkTest.Data.Concrete
{
    public class MovieCategory:EntityBase,IEntity
    {
        public string CategoryName { get; set; }
        public string MovieName { get; set; }
    }
}