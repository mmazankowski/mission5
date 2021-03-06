// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission5.Models;

namespace Mission5.Migrations
{
    [DbContext(typeof(MovieFormContext))]
    partial class MovieFormContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission5.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Action/Adventure"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Fantasy/Adventure"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Comedy/Adventure"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Family"
                        },
                        new
                        {
                            CategoryId = 7,
                            CategoryName = "Family/Drama"
                        },
                        new
                        {
                            CategoryId = 8,
                            CategoryName = "Horror/Suspense"
                        },
                        new
                        {
                            CategoryId = 9,
                            CategoryName = "Miscellaneous"
                        },
                        new
                        {
                            CategoryId = 10,
                            CategoryName = "Television"
                        },
                        new
                        {
                            CategoryId = 11,
                            CategoryName = "VHS"
                        });
                });

            modelBuilder.Entity("Mission5.Models.FormResponses", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            CategoryId = 7,
                            Director = "Cameron Crowe",
                            Edited = false,
                            LentTo = "Haylee",
                            Notes = "Brought us together",
                            Rating = "PG",
                            Title = "We Bought a Zoo",
                            Year = 2011
                        },
                        new
                        {
                            MovieId = 2,
                            CategoryId = 2,
                            Director = "David Yates",
                            Edited = false,
                            LentTo = "Nobody",
                            Notes = "Best HP movie",
                            Rating = "PG - 13",
                            Title = "Harry Potter and the Order of the Phoenix",
                            Year = 2007
                        },
                        new
                        {
                            MovieId = 3,
                            CategoryId = 4,
                            Director = "Ben Stiller",
                            Edited = true,
                            LentTo = "Haylee",
                            Notes = "So funny",
                            Rating = "PG",
                            Title = "The Secret Life of Walter Mitty",
                            Year = 2013
                        },
                        new
                        {
                            MovieId = 4,
                            CategoryId = 1,
                            Director = "Jon Watts",
                            Edited = true,
                            LentTo = "The world",
                            Notes = "Best Spiderman movie",
                            Rating = "PG - 13",
                            Title = "Spider-Man: No Way Home",
                            Year = 2021
                        });
                });

            modelBuilder.Entity("Mission5.Models.FormResponses", b =>
                {
                    b.HasOne("Mission5.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
