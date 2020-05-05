
using Lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2.Controllers
{
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
        public ViewResult RegistrationForm(Employee emp)
        {
            //var x = ModelState;
             ModelContext cm = new ModelContext();
           
            if (ModelState.IsValid)
            {
                cm.Employees.Add(emp);
                cm.SaveChanges();
                TempData["Name"] = emp.Name;
                //em.Add(emp);
                return View("Welcome",emp);
            }
            return View();

        }
    }
}