using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task1.Models;

namespace Task1.Controllers
{
    
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {

            return View();
        }

        [HttpPost]
        public ViewResult Index(Employee employee)
        {
            ViewBag.Name = employee.Name;
            if(employee != null && employee.Name != null)
            {
                return View("Thanks");
            }
            return View();         
        }

        public ViewResult About()
        {

            return View();
        }
        public PartialViewResult TestActionResult()
        {
            return PartialView("");
        }


    }
}