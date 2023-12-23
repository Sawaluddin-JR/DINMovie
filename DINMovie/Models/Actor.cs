using System.ComponentModel.DataAnnotations;

namespace DINMovie.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string ProfilPictureUrl { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //Relationship
        public List<ActorMovie> ActorMovies { get; set; }
    }
}
