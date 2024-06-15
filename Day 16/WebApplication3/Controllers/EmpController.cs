using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;
using WebApplication3.Service;

namespace WebApplication3.Controllers
{
    public class EmpController : Controller
    {
        Iservice db;
        public EmpController(Iservice s) 
        {
            db = s;
        }

        DbContext db = new DbContext();
        
        public IActionResult Index()
        {
            //var query = from Emp in Emps join Depts in db.Dept
            //ViewBag.
            //var a=db.GetEmps();
            //SqlService.disp();
            //ViewBag.Message = (from e in 
            //                  join d in dept on e.Deptid equals d.Deptid
            //                  select new { Name = e.Name, Id = e.Id, DeptName = d.DeptName }).;



            return View();
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Emp emp)
        {
           
                if(ModelState.IsValid)
                {
                    var model = db.Addemp(emp);
                    return RedirectToAction(nameof(Index));
                }
                
           
            return View();
        }

        public ActionResult Edit(int id)
        {
            var model = db.Getid(id);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public ActionResult Edit(Emp emp)
        {
            try
            {
                var model = db.Update(emp);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            var model = db.Getid(id);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        //[ActionName("Delete")]

        public ActionResult Delete(Emp emp)
        {
            try
            {
                var model = db.Delete(emp);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



    }
}
