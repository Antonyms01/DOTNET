using Microsoft.AspNetCore.Mvc;
using WebApplication3.Service;

namespace WebApplication3.Controllers
{
    public class DeptController : Controller
    {
        Iservice db;
        public DeptController(Iservice s)
        {
            db = s;
        }
        public IActionResult Index()
        {
    
            var a = db.GetDepts();
            return View(a);
        }

        public IActionResult IDetails(int id)
        {
            return View(db.Getid(id));
        }
        public IActionResult IDetails1(int id)
        {
            return View(db.Getid(id));
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
