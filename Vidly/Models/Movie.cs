using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Genre Genre { get; set; }
        [Required]
        public int GenreId { get; set; }
        [Required]
        public string ReleaseDate { get; set; }

        [Required]
        public string DateAdded { get; set; }

        [Required]
        public int NumberInStock { get; set; }



    }
}