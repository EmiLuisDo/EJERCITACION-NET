using System;
using Microsoft.AspNetCore.Mvc;

namespace Ken.Tutorial.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult index()
        {
            //return Content("Konichiwa mundo");
            ViewBag.ServerTime = DateTime.Now;
            return View("Time");
        }
    }
}