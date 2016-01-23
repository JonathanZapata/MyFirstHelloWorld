using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyFistHelloWorld.Models;

namespace MyFistHelloWorld.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult DisplayCustomer(Customer objCustomer)
        {
            //Parte inicial de pruebas
            //Customer objCustomer = new Customer();
            //objCustomer.Code = "0010";
            //objCustomer.Name = "Ronal Mamani";
            //objCustomer.Amount = 34;

            //Segunda parte de pruebas
            //Customer objCustomer = new Customer();
            //objCustomer.Code = Request.Form["customercod"].ToString();
            //objCustomer.Name = Request.Form["customerman"].ToString();
            //objCustomer.Amount = Convert.ToInt32( Request.Form["customeramo"]);

            //return View("DisplayCustomer",objCustomer );
            return View(objCustomer);
        }

        public ActionResult FillCustomer()
        {
            return View();
        }
    }
}