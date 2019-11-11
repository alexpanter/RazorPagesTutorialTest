using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; } // used as primary key for the database

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [DisplayFormat(DataFormatString = "{0:0.00}")] // 3,99 kr
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$",
            ErrorMessage = "Must begin with an upper-case letter, "
            + "and cannot contain any numbers.")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public string Rating { get; set; }
    }
}
