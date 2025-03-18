using System.ComponentModel.DataAnnotations.Schema;

namespace SP2025_Assignment3_2._0_MMcConnell.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public string IMDBLink { get; set; }
        public string PosterUrl { get; set; }  // Optional: For direct URL storage
        [NotMapped]
        public IFormFile PosterFile { get; set; }  // Optional: For file upload
        public string? PosterPath { get; set; }  // Stores the saved file path

        // Navigation property (if needed)
        public virtual ICollection<MovieActor> MovieActors { get; set; }
    }
}
