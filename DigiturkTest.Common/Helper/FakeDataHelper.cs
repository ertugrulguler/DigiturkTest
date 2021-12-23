using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using DigiturkTest.Data.Concrete;
using DigiturkTest.Data.Concrete.Entity;
using DigiturkTest.Data.Enums;

namespace DigiturkTest.Common.Helper
{
    public class FakeDataHelper
    {
        public static List<Movie> GetAllMovies()
        {
            var movies = new List<Movie>();
            //var categories = new List<Category>();
            for (var i = 0; i < 10; i++)
            {
                var movieCategory = new MovieCategory()
                {
                    CategoryName = FakeData.NameData.GetCompanyName(),
                    CreatedDate = FakeData.DateTimeData.GetDatetime(),
                    ModifiedDate = FakeData.DateTimeData.GetDatetime(),
                    Id = i + 1,
                    IsDeleted = false,
                    MovieName = FakeData.NameData.GetCompanyName()
                };
                var actors = new List<Actor>();
                var movie = new Movie()
                {
                    Id = i + 1,
                    BannerImageUrl = FakeData.NetworkData.GetDomain(),
                    CreatedDate = FakeData.DateTimeData.GetDatetime(),
                    ModifiedDate = FakeData.DateTimeData.GetDatetime(),
                    Duration = FakeData.NumberData.GetNumber().ToString(),
                    Name = FakeData.NameData.GetCompanyName(),
                    IsDeleted = false,
                    Location = @$"C:\deneme\movie{i}", //Videolar bir adresten (cdn vs.) çekiliyor diye düşünüyorum
                    MovieCategoryId = movieCategory.Id
                };

                //if (i % 2 == 0 && categories.Count<2)
                //{
                //    categories.Add(CategoryTypes.Action);
                //    categories.Add(CategoryTypes.Fear);
                //}
                //else if(categories.Count < 2)
                //{
                //    categories.Add(CategoryTypes.Comedy);
                //    categories.Add(CategoryTypes.Love);
                //}


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
                        Id = j + 1,
                        CategoryType = j % 2 == 0 ? CategoryTypes.Action : CategoryTypes.Comedy,
                        CreatedDate = FakeData.DateTimeData.GetDatetime(),
                        IsDeleted = false,
                        ModifiedDate = FakeData.DateTimeData.GetDatetime(),
                        MovieCategoryId = movieCategory.Id
                    };
                    //categories.Add(category);
                }

                movie.Actors = actors;
                movies.Add(movie);
            }

            return movies;
        }
        public static List<Movie> GetMoviesByCategory(CategoryTypes category)
        {
            var movies = new List<Movie>();
            var categories = new List<CategoryTypes>();
            for (var i = 0; i < 3; i++)
            {
                var actors = new List<Actor>();
                var movie = new Movie()
                {
                    Id = i + 1,
                    BannerImageUrl = FakeData.NetworkData.GetDomain(),
                    CreatedDate = FakeData.DateTimeData.GetDatetime(),
                    ModifiedDate = FakeData.DateTimeData.GetDatetime(),
                    Duration = FakeData.NumberData.GetNumber().ToString(),
                    Name = FakeData.NameData.GetCompanyName(),
                    Location = @$"C:\deneme\movie{i}", //Videolar bir adresten (cdn vs.) çekiliyor diye düşünüyorum
                    IsDeleted = false,
                };

                //switch (category)
                //{
                //    case CategoryTypes.Action: movie.Categories = new List<CategoryTypes>() {CategoryTypes.Action};
                //        break;
                //    case CategoryTypes.Comedy: movie.Categories = new List<CategoryTypes>() {CategoryTypes.Comedy };
                //        break;
                //    case CategoryTypes.Fear: movie.Categories = new List<CategoryTypes>() {CategoryTypes.Fear };
                //        break;
                //    case CategoryTypes.Love: movie.Categories = new List<CategoryTypes>() {CategoryTypes.Love };
                //        break;
                //}


                for (var j = 0; j < 3; j++)
                {
                    var actor = new Actor()
                    {
                        Age = FakeData.NumberData.GetNumber(),
                        Country = FakeData.PlaceData.GetCountry(),
                        CreatedDate = FakeData.DateTimeData.GetDatetime(),
                        Gender = FakeData.BooleanData.GetBoolean(),
                        Id = j + 1,
                        IsDeleted = false,
                        ModifiedDate = FakeData.DateTimeData.GetDatetime(),
                        Name = FakeData.NameData.GetFirstName(),
                        Surname = FakeData.NameData.GetSurname()
                    };
                    actors.Add(actor);
                }

                movie.Actors = actors;
                //movie.Categories = categories;
                movies.Add(movie);
            }

            return movies;
        }
    }
}