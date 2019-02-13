using System.ComponentModel.DataAnnotations;

namespace login_reg.Models
{
    public class User
    {
        [Required]
        [MinLength(2)]
        [Display(Name = "First Name:")]
        public string fname {get; set;}
        [Required]
        [MinLength(2)]
        [Display(Name = "Last Name:")]
        public string lname {get; set;}
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address:")]
        public string email {get; set;}
        [Required]
        [MinLength(8)]
        [Display(Name = "Password:")]

        public string password {get; set;}
        [Required]
        [Compare(nameof(password))]
        [Display(Name = "Confirm Password:")]
        public string cpassword {get; set;}

        public User ()
        {

        }
    }
}