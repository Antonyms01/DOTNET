﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class EmpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            return View();
        }
    }
}
