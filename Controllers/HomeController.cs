using assignment3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace assignment3.Controllers
{
    
        public class HomeController : Controller
        {
            public ActionResult Index()
            {
               return View();
            }

            public ActionResult Tropical()
            {
                return View("Tropical");
            }
        public ActionResult Beach()
        {
            return View("Beach");
        }
        public ActionResult Mountain()
        {
            return View("Mountain");
        }
        public ActionResult Contact()
        {
            return View("Contact");
        }
        public ActionResult Aboutus()
        {
            return View("Aboutus");
        }
        public ActionResult Login()
        {
            return View("Login");
        }
    }
    }
