using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BestMovies.Models
{
    public class MovieCreateEditModel
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Name")]
        public string Title { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        [DisplayName("Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        [Range(1, 20)]
        [DisplayName("Number in Stock")]
        public int NumberInStock { get; set; }

        [Required]
        [RegularExpression("[A-Z][a-z][^a-z]*[0-9]{3}$")]
        public string Password { get; set; }

        [Compare("Password")]
        [DisplayName("Retype the password")]
        public string RepeatedPassword { get; set; }

        public IEnumerable<string> Genres { get; set; }
    }
}