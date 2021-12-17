using System;

namespace DigiturkTest.Data.Concrete.Entity
{
    public class EntityBase
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}