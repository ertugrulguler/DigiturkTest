using DigiturkTest.Data.Abstract;

namespace DigiturkTest.Data.Concrete.Entity
{
    public class User:EntityBase,IEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
    }
}