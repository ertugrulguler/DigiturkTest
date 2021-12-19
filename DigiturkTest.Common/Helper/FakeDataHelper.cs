using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using DigiturkTest.Data.Concrete.Entity;

namespace DigiturkTest.Common.Helper
{
    public class FakeDataHelper
    {
        public static List<Movie> GetAllMovies()
        {
            var movies = new List<Movie>();
            for (var i = 0; i < 10; i++)
            {
                var actors = new List<Actor>();
                var categories = new List<Category>();
                var movie = new Movie()
                {
                    Id = i + 1,
                    BannerImageUrl = FakeData.NetworkData.GetDomain(),
                    CreatedDate = FakeData.DateTimeData.GetDatetime(),
                    ModifiedDate = FakeData.DateTimeData.GetDatetime(),
                    Duration = FakeData.NumberData.GetNumber().ToString(),
                    Name = FakeData.NameData.GetCompanyName(),
                    IsDeleted = false,
                };
                for (var j = 0; j < 3; j++)
                {
                    var actor = new Actor()
                    {
                        Age = FakeData.NumberData.GetNumber(),
                        Country = FakeData.PlaceData.GetCountry(),
                        CreatedDate = FakeData.DateTimeData.GetDatetime(),
                        Gender = FakeData.BooleanData.GetBoolean(),
                        Id = j+1,
                        IsDeleted = false,
                        ModifiedDate = FakeData.DateTimeData.GetDatetime(),
                        Name = FakeData.NameData.GetFirstName(),
                        Surname = FakeData.NameData.GetSurname()
                    };
                    actors.Add(actor);

                    var category = new Category()
                    {
                        CreatedDate = FakeData.DateTimeData.GetDatetime(),
                        Id = j + 1,
                        IsDeleted = false,
                        ModifiedDate = FakeData.DateTimeData.GetDatetime(),
                        Name = FakeData.TextData.GetAlphaNumeric(10)
                    };

                    categories.Add(category);
                }

                movie.Actors = actors;
                movie.Categories = categories;
                movies.Add(movie);
            }

            return movies;
        }
    }
}