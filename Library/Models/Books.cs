using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models;

public class Books
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string? Barcode { get; set; }
    public string? BookName { get; set; }
    public string? Author { get; set; }
    public int? PageNumber { get; set; }
    public int? BooksCategoryId { get; set; }
    public string? Place { get; set; }
    public byte[]? Photo { get; set; }
    public string? Isbn { get; set; }
}