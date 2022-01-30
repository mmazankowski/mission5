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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<FormResponses>().HasData(

                new FormResponses
                {
                    MovieId = 1,
                    Category = "Family/Drama",
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
                    Category = "Fantasy/Adventure",
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
                    Category = "Comedy/Adventure",
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
                    Category = "Action/Adventure",
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

