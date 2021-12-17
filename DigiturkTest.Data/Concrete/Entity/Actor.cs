using DigiturkTest.Data.Abstract;

namespace DigiturkTest.Data.Concrete.Entity
{
    public class Actor:EntityBase,IEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Gender { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
    }
}