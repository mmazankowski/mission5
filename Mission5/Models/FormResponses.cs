using System;
using System.ComponentModel.DataAnnotations;
namespace Mission5.Models
{
    public class FormResponses
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [Required(ErrorMessage = "Don't forget to pick a category!")]
        //public string Category { get; set; }
        //build foreign key relationship
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Required(ErrorMessage = "Don't forget to add a title!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Don't forget to add a year!")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Don't forget to add a director!")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Don't forget to choose a rating!")]
        public string Rating { get; set; }

        public bool Edited { get; set; }

        public string LentTo { get; set; }

        [MaxLength(25)]
        public string Notes { get; set; }
    }
}

