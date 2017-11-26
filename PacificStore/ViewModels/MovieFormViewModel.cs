using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using PacificStore.Models;

namespace PacificStore.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        [Required]
        public DateTime? ReleaseDate { get; set; }
        
        [Display(Name = "Number in Stock")]
        [Range(0, 20)]
        [Required]
        public int? NumberInStock { get; set; }

        [Display(Name = "Genre")]
        public byte? GenreId { get; set; }

        public string Title => (Id != 0) ? "Edit Movie" : "New Movie";


    }
}