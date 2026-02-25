using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace Lesson02_Startup.Controllers
{
    public class Exercise01Controller : Controller
    {
        

        public ActionResult Index()
        {
            // create a new product object with instance name glass
            Product glass = new Product("Wine glass", 160.50);
            glass.ImageUrl = "grandcru.jpg";
            ViewBag.Glass = glass;

            Product bin = new Product("bin", 100);
            bin.ImageUrl = "bin.jpg";
            ViewBag.Bin = bin;

            Product knife = new Product("Knife", 250,"st_knife.jpg","sensei");
            ViewBag.Knife = knife;
            
            
            return View();
        }

    }
}
