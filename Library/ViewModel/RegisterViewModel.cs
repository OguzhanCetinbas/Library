using System.ComponentModel.DataAnnotations;

namespace Library.ViewModel;

public class RegisterViewModel
{
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; }
    
    [Required(ErrorMessage = "Email is required")]
    [EmailAddress]
    public string Email { get; set; }  
    
    [Required(ErrorMessage = "Password is required")]
    [StringLength(40,MinimumLength = 6,ErrorMessage = "Password must be between 6 and 40 characters")]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    [Compare("ConfirmPassword", ErrorMessage = "Passwords don't match")]
    public string Password { get; set; }
    
    [Required(ErrorMessage = "Confirm Password is required")]
    [Display(Name = "Confirm  Password")]
    public string ConfirmPassword { get; set; }
    
}