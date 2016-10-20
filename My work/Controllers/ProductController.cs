using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using My_work.Models;

namespace My_work.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            /*Products prod = new Products()
            {
                ProductName = "",
                ProductDiscription = "",
                ProPrice =0.0,
                ItemNumber = 0
                
                
            };*/
            return View();
        }
    }
}