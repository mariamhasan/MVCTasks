using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task1.DAL;
using Task1.Models;

namespace Task1.Controllers
{
    public class EmployeeController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        // GET: Employee
        [HttpGet]
        public ViewResult Index()
        {
            return View(context.Employees.ToList());
        }

        [HttpGet]
        public ViewResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Employee employee)
        {
            if (ModelState.IsValid)
            {
                context.Employees.Add(employee);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}