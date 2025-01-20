using Library.Utility;
using Library.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Library.Controllers;

public class BookController : Controller
{
    private readonly AppDbContext _context;


    public BookController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var BooksCategoryViewModel = new BooksCategoryViewModel
        {
            BooksCategory = _context.BooksCategories.ToList(),
            Books = _context.Books.OrderByDescending(c => c.Id).ToList()


        };
        return View(BooksCategoryViewModel);
    }
}