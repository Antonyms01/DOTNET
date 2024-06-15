using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    //[Route("[Controller]/[action]")]
    public class CookieController : Controller
    {

        [Route("Cookie/Inbox")]
        public IActionResult Index()
        {
            var CookieValue = Request.Cookies["Ukey"]?.ToString();
            ViewBag.CookieValue = CookieValue;
            return View("Index");
        }

        [Route("Cookie/Login")]
        public IActionResult Create()
        {
            UserLog obj = null;
            var CookieValue = Request.Cookies["Ukey"]?.ToString();
            if (CookieValue != null)
            {
                obj = new UserLog();
                obj.Email = CookieValue;
            }

            return View("Create",obj);

        }

       



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserLog data)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (data.Remember == true)
                    {
                        CookieOptions options = new CookieOptions();
                        options.Expires = DateTime.Now.AddDays(7);
                        Response.Cookies.Append("Ukey", data.Email, options);
                    }
                }

                return RedirectToAction("Inbox");
            }
            catch
            {
                return View();
            }
        }
    }
}
