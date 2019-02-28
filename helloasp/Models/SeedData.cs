using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace helloasp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new helloaspContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<helloaspContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                   return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "광무의 은밀한 생활 1",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Rating = "A"
                    },

                    new Movie
                    {
                        Title = "광무의 은밀한 생활 2",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Rating = "A"
                    },

                    new Movie
                    {
                        Title = "광무의 은밀한 생활 3",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Rating = "A"
                    },

                    new Movie
                    {
                        Title = "광무의 은밀한 생활 4",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M,
                        Rating = "A"
                    },

                    new Movie
                    {
                        Title="산기컴공",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M,
                        Rating = "A"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

