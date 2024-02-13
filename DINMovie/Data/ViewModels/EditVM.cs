using System.ComponentModel.DataAnnotations;

namespace DINMovie.Data.ViewModels
{
    public class EditVM
    {
        [Display(Name = "Full name")]
        [Required(ErrorMessage = "Full name is required")]
        public string FullName { get; set; }

        [Display(Name = "Email address")]
        [Required(ErrorMessage = "Email address is required")]
        public string EmailAddress { get; set; }
    }
}
