using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PacificStore.Models;

namespace PacificStore.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movie { get; set; }
        public string Title => (Movie != null && Movie.Id != 0) ? "Edit Movie" : "New Movie";
    }
}