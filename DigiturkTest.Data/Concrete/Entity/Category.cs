using DigiturkTest.Data.Abstract;

namespace DigiturkTest.Data.Concrete.Entity
{
    public class Category:EntityBase,IEntity
    {
        public string Name { get; set; }
    }
}