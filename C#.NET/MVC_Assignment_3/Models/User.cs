using System.ComponentModel.DataAnnotations;
namespace MVC_Assignment_3.Models
{
    public class User
    {
        public int Id {  get; set; }
        [Required(ErrorMessage ="Name is Required")]

        public string? Name { get; set; }
        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress(ErrorMessage = "Enter valid email")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters")]

        public string? Password { get; set; }
        [Required(ErrorMessage = "Confirm Password is Required")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string? ConfirmPassword { get; set; }
    }
}
