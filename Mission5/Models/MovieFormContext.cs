using System;
using Microsoft.EntityFrameworkCore;

namespace Mission5.Models
{
    public class MovieFormContext : DbContext
    {
        //Constructor
        public MovieFormContext(DbContextOptions<MovieFormContext> options) : base(options)
        {
            //leave blank for now
        }

        public DbSet<FormResponses> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }

        //Seeding the data 

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName="Action/Adventure" },
                new Category { CategoryId = 2, CategoryName = "Fantasy/Adventure" },
                new Category { CategoryId = 3, CategoryName = "Comedy" },
                new Category { CategoryId = 4, CategoryName = "Comedy/Adventure" },
                new Category { CategoryId = 5, CategoryName = "Drama" },
                new Category { CategoryId = 6, CategoryName = "Family" },
                new Category { CategoryId = 7, CategoryName = "Family/Drama" },
                new Category { CategoryId = 8, CategoryName = "Horror/Suspense" },
                new Category { CategoryId = 9, CategoryName = "Miscellaneous" },
                new Category { CategoryId = 10, CategoryName = "Television" },
                new Category { CategoryId = 11, CategoryName = "VHS" }

            );

            mb.Entity<FormResponses>().HasData(

                new FormResponses
                {
                    MovieId = 1,
                    CategoryId = 7, //"Family/Drama"
                    Title = "We Bought a Zoo",
                    Year = 2011,
                    Director = "Cameron Crowe",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "Haylee",
                    Notes = "Brought us together"
                },
                new FormResponses
                {
                    MovieId = 2,
                    CategoryId = 2, //"Fantasy/Adventure"
                    Title = "Harry Potter and the Order of the Phoenix",
                    Year = 2007,
                    Director = "David Yates",
                    Rating = "PG - 13",
                    Edited = false,
                    LentTo = "Nobody",
                    Notes = "Best HP movie"
                },
                new FormResponses
                {
                    MovieId = 3,
                    CategoryId = 4, //"Comedy/Adventure"
                    Title = "The Secret Life of Walter Mitty",
                    Year = 2013,
                    Director = "Ben Stiller",
                    Rating = "PG",
                    Edited = true,
                    LentTo = "Haylee",
                    Notes = "So funny"
                },
                new FormResponses
                {
                    MovieId = 4,
                    CategoryId = 1, //"Action/Adventure"
                    Title = "Spider-Man: No Way Home",
                    Year = 2021,
                    Director = "Jon Watts",
                    Rating = "PG - 13",
                    Edited = true,
                    LentTo = "The world",
                    Notes = "Best Spiderman movie"
                }
            );
        }

    }
}

