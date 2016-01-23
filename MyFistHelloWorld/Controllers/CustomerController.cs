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
        List<Customer> Customers = new List<Customer>() ;
        public CustomerController()
        {
            Customer obj1 = new Customer();
            obj1.Code = "11";
            obj1.Name = "Ronald";
            obj1.Amount = 30;
            Customers.Add(obj1);

            Customer obj2 = new Customer();
            obj2.Code = "12";
            obj2.Name = "Marcos";
            obj2.Amount = 26;
            Customers.Add(obj2);
        }
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

        [HttpGet]
        public ViewResult DisplayCustomer(int id)
        {
            Customer objCustomer = Customers[id];
            return View("DisplayCustomer",objCustomer);
        }

        public ActionResult FillCustomer()
        {
            return View();
        }
    }
}