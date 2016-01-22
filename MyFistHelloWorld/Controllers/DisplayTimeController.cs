using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFistHelloWorld.Controllers
{
    public class DisplayTimeController : Controller
    {
        // GET: DisplayTime
        public ActionResult Index()
        {
            ViewData["CurrentTime"] = DateTime.Now.ToString(CultureInfo.CurrentCulture);
            return View();
        }
    }
}