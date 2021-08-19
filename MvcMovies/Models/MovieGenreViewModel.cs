using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovies.Models
{
    public class MovieGenreViewModel 
    {
        public List<Movie> Movies { get; set; }
        public string  Search { get; set; }

        public string Genre { get; set; }
        
        //public string Rating { get; set; }

        public SelectList  Genres { get; set; }

    }
}
