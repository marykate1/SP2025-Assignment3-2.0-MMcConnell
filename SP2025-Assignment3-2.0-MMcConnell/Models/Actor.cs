namespace SP2025_Assignment3_2._0_MMcConnell.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string IMDBLink { get; set; }
        public string PhotoUrl { get; set; }

        // Navigation property to link actors to movies
        public virtual ICollection<MovieActor> MovieActors { get; set; }
    }

}
