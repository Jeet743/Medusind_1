using Assignment_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_1.Controllers
{
    public class AssignmentController : Controller
    {
        NorthwindEntities1 db = new NorthwindEntities1();
        // GET: Assignment
        public ActionResult Index()
        {
            return View(db.Customers.ToList());
        }

        public ActionResult CustomerResiding()
        {
            var res = from i in db.Customers
                      where i.Country == "Germany"
                      select i;

            return View(res);
        }

        public ActionResult GetData() 
        {
            var d = from i in db.Order
                      where i.OrderID == 10248
                      select i;

            return View(d); 
        }
    }
}