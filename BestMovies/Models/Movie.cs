﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BestMovies.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [DisplayName("Name")]
        [Required]
        public string Title { get; set; }

        [Required]
        public virtual Genre Genre { get; set; }

        [DisplayName("Release Date")]
        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public DateTime AddedOn { get; set; }

        [DisplayName("Number in Stock")]
        [Required]
        public int NumberInStock { get; set; }
    }
}