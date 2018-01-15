using CustomerProfile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerProfile.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Index");



        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            ViewData["Hello"] = "Response Data";

            return View("About");

        }

        public ActionResult Contact(CustomerProfileModel employee)
        {
            ViewBag.Message = "Your contact page.";

            switch (employee.FirstName)
            {
                case "Bob":
                    ViewData["EmployeeStatus"] = "Hired";
                    ViewData["EmployeePromoted"] = true;
                    break;
                default:
                    ViewData["EmployeeStatus"] = "Suspend";
                    ViewData["EmployeePromoted"] = false;
                    break;

            }
            return View();
        }
    }
}