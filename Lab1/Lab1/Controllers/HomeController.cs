using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1.Controllers
{
    public class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }

    }

    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }

        // GET: RegisterForm
        [HttpGet]
        public ViewResult RegistrationForm()
        {
            return View();
        }

        // Post: RegisterForm
        [HttpPost]
        public ViewResult RegistrationForm(Employee employee)
        {
            if (employee != null && employee.Email != null && employee.Name != null)
            {
                ViewBag.Name = employee.Name;
                return View("Welcome");
            }
            return View();
        }
    }
}