using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task1.Controllers
{
    public class Employee
    {
        public string Name { get; set; }
        public string  Email { get; set; }
        public string Phone { get; set; }
        public bool WillAttend { get; set; }
    }
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

       
    }
}