namespace SP2025_Assignment3_2._0_MMcConnell.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string IMDBLink { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public string PosterUrl { get; set; }
        public virtual ICollection<MovieActor> MovieActors { get; set; }
    }

}
