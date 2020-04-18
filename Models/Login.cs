using System.ComponentModel.DataAnnotations;

namespace simpleLoginRegistration.Models {
    public class LoginModel {

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Please enter valid email address.")]
        [Display(Name = "Email Address:")] 
        public string LoginEmail { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [MinLength(8, ErrorMessage = "Password needs to be at least 8 characters.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password:")] 
        public string LoginPassword { get; set; }
    }
}