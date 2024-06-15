using Microsoft.AspNetCore.Mvc;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    public class EmpController : Controller
    {
        public Iservice i;

        public EmpController(Iservice data) {
            i = data;
        }
        public IActionResult Index()
        {
            var e = i.GetEmployee(2);
            return View(e);
        }
    }
}
