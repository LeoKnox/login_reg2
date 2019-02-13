using System.ComponentModel.DataAnnotations;

namespace logintwo.Models
{
    public class Logger
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address:")]
        public string lemail {get; set;}

        [Required]
        [MinLength(8)]
        [Display(Name = "Password")]
        public string lpassword {get; set;}

        public Logger ()
        {
        
        }
    }
}