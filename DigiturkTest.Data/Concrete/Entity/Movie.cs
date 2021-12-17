using System.Collections.Generic;
using DigiturkTest.Data.Abstract;

namespace DigiturkTest.Data.Concrete.Entity
{
    public class Movie : EntityBase, IEntity
    {
        public string Name { get; set; }
        public string Duration { get; set; }
        public string BannerImageUrl { get; set; }
        public List<Actor> Actors { get; set; }
        public List<Category> Categories { get; set; }
    }
}