using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            Book b1 = new Book{BookId = 101, Title = "Nigger"};
            ViewBag.Heading = "Khassi Kolony";
            return View(b1);
        }

        public IActionResult Details(int id) 
        {   
            return View();
        }
    }
}
