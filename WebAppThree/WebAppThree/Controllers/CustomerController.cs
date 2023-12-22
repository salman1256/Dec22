using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppThree.Models;

namespace WebAppThree.Controllers
{
    public class CustomerController : Controller
    {
        static List<Customer> listCustomer = new List<Customer>()
       {
           new Customer{Id=1,Name="Sam",City="Delhi",OdLimit=990000},
            new Customer{Id=2,Name="Rohit",City="Mumbai",OdLimit=650000},
             new Customer{Id=3,Name="Vini",City="Pune",OdLimit=850000},
              new Customer{Id=4,Name="Arsh",City="Dehradoon",OdLimit=950000},
               new Customer{Id=5,Name="Shweta",City="Delhi",OdLimit=750000},
                new Customer{Id=6,Name="Danish",City="Jammu",OdLimit=820000},
                 new Customer{Id=7,Name="Ruhee",City="Srinagar",OdLimit=950000},
                  new Customer{Id=8,Name="Garima",City="Noida",OdLimit=8650000},
       };
        // GET: Customer
        public ActionResult Display()
        {
           
            return View(listCustomer);
        }
        [HttpGet]
        public ActionResult Create()
        {
            Customer customer 
                = new Customer();

            return View(customer);
        }
        [HttpPost]
        public ActionResult Create(Customer cust)
        {
            if(ModelState.IsValid)
            {
                listCustomer.Add(cust);
                return RedirectToAction("Display");
            }

            return View();
        }

    }
}