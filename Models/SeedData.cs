using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace movieMvc.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "A Clockwork Orange",
                        ReleaseDate = DateTime.Parse("1979-2-12"),
                        Genre = "Dark Comedy/Horror/Thriller",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M
                    },

                    new Movie
                    {
                        Title = "Excision",
                        ReleaseDate = DateTime.Parse("2015-2-23"),
                        Genre = "Horror/Satire",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Apocolypse Now",
                        ReleaseDate = DateTime.Parse("1972-4-15"),
                        Genre = "American War/Drama/Thriller/Psychological Horror",
                        Price = 3.99M
                    },
                    new Movie
                    {
                        Title = "Pulp Fiction",
                        ReleaseDate = DateTime.Parse("1995-2-12"),
                        Genre = "Dark Comedy/Thriller/Action",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "trash humpers ",
                        ReleaseDate = DateTime.Parse("2015-3-13"),
                        Genre = "Psychological Horror/Found Footage",
                        Price = 8.99M
                    },

                    new Movie
                    {
                        Title = "Fraud",
                        ReleaseDate = DateTime.Parse("2018-12-23"),
                        Genre = "Horror/Found Footage/Indie",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Apocolypse Now",
                        ReleaseDate = DateTime.Parse("1972-4-15"),
                        Genre = "American War/Drama/Thriller/Psychological Horror",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}