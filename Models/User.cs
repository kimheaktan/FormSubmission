using System.ComponentModel.DataAnnotations;
namespace formSubmission.Models
{
    public class User
    {
        [Required(ErrorMessage = "First Name is Required")]
        [MinLength(3, ErrorMessage = "First Name has to be at least 3 characters")]
        [Display(Name = "First Name")]

        public string FirstName {get;set;}
        
        [Required(ErrorMessage = "Last Name is Required")]
        [MinLength(3)]
        public string LastName {get;set;}

        // [Required(ErrorMessage = "Age is Required")]
        [Required]
        // [RegularExpression("^\\d+$", ErrorMessage = "Must be a Positive")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a valid age.")]
        public int Age {get;set;}
        
        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress]
        public string Email{get;set;}

        [Required(ErrorMessage = "Password is Required")]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password{get;set;}
    }
}