using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFistHelloWorld.Controllers
{
    public class SiteController : Controller
    {
        // GET: Site
        public ActionResult GoToHome()
        {
            return View("Home");
        }

        public ActionResult AboutUs()
        {
            return View("About");
        }

        public ActionResult SeeProduct()
        {
            return View("Product");
        }
    }
}