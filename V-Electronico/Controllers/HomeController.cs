using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace V_Electronico.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult ManagerCustomer()
        {
            return View();
        }
        public ActionResult ManagerCustomerV2()
        {
            return View();
        }
        public ActionResult Customers()
        {
            return View();
        }
        public ActionResult ManagerCustomerV3()
        {
            return View();
        }
    }
}