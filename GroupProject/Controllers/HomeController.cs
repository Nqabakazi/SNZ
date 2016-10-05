using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GroupProject.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }
        public ActionResult Catalog()
        {
            return View();
        }
        public ActionResult Product()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}