using System.Collections.Generic;

namespace Vidly.Models.ViewModel
{
    public class MovieViewModel
    {

        public Movie Movie { get; set; }
        public IEnumerable<Genre> Genres { get; set; }

    }
}