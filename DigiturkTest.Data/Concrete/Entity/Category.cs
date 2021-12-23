using System.Collections.Generic;
using DigiturkTest.Data.Abstract;
using DigiturkTest.Data.Enums;

namespace DigiturkTest.Data.Concrete.Entity
{
    public class Category:EntityBase,IEntity
    {
        public string Name { get; set; }
        public CategoryTypes CategoryType { get; set; }
        public int MovieCategoryId { get; set; }
    }
}