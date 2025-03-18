using System.ComponentModel.DataAnnotations.Schema;

namespace SP2025_Assignment3_2._0_MMcConnell.Models
{
    public class MovieActor
    {
        public int Id { get; set; }
        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        [ForeignKey("Actor")]
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
    }

}
