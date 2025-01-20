using Library.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Library.Utility;

public class AppDbContext : IdentityDbContext<Users>
{
       

    public AppDbContext(DbContextOptions options) : base(options)
    {
        
    }
    
    public DbSet<BooksCategory> BooksCategories { get; set; }
    public DbSet<Books> Books { get; set; }
    
}