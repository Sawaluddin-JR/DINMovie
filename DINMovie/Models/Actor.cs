using System.ComponentModel.DataAnnotations;

namespace DINMovie.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture URL")]
        public string ProfilPictureURL { get; set; }
        [Display(Name = "FullName")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //Relationship
        public List<ActorMovie> ActorMovies { get; set; }
    }
}
