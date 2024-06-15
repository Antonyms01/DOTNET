using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class SessionController : Controller
    {
        const string SessionName = "_Name";
        const string SessionAge = "_Age";
        public IActionResult Index()
        {
            if(HttpContext.Session.GetString(SessionName) != null)
            {
                ViewBag.Name=HttpContext.Session.GetString(SessionName);
                ViewBag.Age = HttpContext.Session.GetString(SessionAge);
                ViewData["Message"] = "Hey Folks !!!.";
                return View();

            }
            return RedirectToAction(nameof(Create));
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(UserLog data)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    HttpContext.Session.SetString(SessionName, data.Email);
                    HttpContext.Session.SetString(SessionAge, "24");


                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult Delete()
        {
            HttpContext.Session.Remove(SessionName);
            HttpContext.Session.Clear();

            return View("Create");
        }

        public ActionResult Display()
        {
            return View();
        }
    }
}
