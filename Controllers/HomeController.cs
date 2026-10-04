using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult VD1()
        {
            return View();
        }
        public ActionResult VD2()
        {
            return View();
        }
        public ActionResult VD3()
        {
            return View();
        }
        public ActionResult VD4()
        {
            return View();
        }
        public ActionResult VD5()
        {
            return View();
        }
        public ActionResult VD6()
        {
            return View();
        }
        public ActionResult VD7()
        {
            return View();
        }
        public ActionResult VD8()
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
    }
}