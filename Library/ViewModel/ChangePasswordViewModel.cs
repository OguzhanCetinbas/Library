using System.ComponentModel.DataAnnotations;

namespace Library.ViewModel;

public class ChangePasswordViewModel
{
    [Required(ErrorMessage = "Email is required")]
    [EmailAddress]
    public string Email { get; set; }  
    
    
    [Required(ErrorMessage = "Password is required")]
    [StringLength(40,MinimumLength = 6,ErrorMessage = "Password must be between 6 and 40 characters")]
    [DataType(DataType.Password)]
    [Display(Name = "New Password")]
    [Compare("ConfirmNewPassword", ErrorMessage = "Passwords don't match")]
    public string NewPassword { get; set; }
    
    [Required(ErrorMessage = "Confirm Password is required")]
    [Display(Name = "Confirm New Password")]
    public string ConfirmNewPassword { get; set; }
}