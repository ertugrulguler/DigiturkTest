using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using DigiturkTest.Data.Abstract;
using DigiturkTest.Data.Enums;

namespace DigiturkTest.Data.Concrete.Entity
{
    public class Movie : EntityBase, IEntity
    {
        public string Name { get; set; }
        public string Duration { get; set; }
        public string BannerImageUrl { get; set; }
        public string Location { get; set; }
        public List<Actor> Actors { get; set; }
        public int MovieCategoryId { get; set; }
    }
}