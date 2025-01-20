using Microsoft.AspNetCore.Identity;

namespace Library.Models;

public class Users :IdentityUser
{
    public string FullName { get; set; }
    public string? RefreshToken { get; set; }
    public DateTime? RefreshTokenExpiryTime { get; set; }
    
}