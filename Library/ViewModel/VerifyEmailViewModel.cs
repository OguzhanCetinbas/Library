using System.ComponentModel.DataAnnotations;

namespace Library.ViewModel;

public class VerifyEmailViewModel
{
    [Required(ErrorMessage = "Email is required")]
    [EmailAddress]
    public string Email { get; set; }  
}