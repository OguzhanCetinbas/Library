using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models;

public class BooksCategory
{  
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int BooksCategoryId { get; set; }
    
    [Display(Name = "Book Category")]
    public string BooksCategoryName { get; set; }
}