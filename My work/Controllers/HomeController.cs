using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using My_work.Models;

namespace My_work.Controllers
{
    public class HomeController : Controller
    {
        public static ProductDetails productInfo = new ProductDetails();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Gallery()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }
        public ActionResult ContactUs()
        {
            return View();
        }
        public ActionResult Product()
        {
            return View();
        }
        public ActionResult Products(string ItemNum)
        {
            productInfo.ProInfo();
            return View(productInfo.getProInfo(ItemNum));
        }



        public ActionResult ProductDetails()
        {

            productInfo.ProInfo();
            return View(productInfo.pro);

           
        }



    }
}