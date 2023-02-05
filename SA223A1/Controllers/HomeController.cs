using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SA223A1.Controllers
{
    public class HomeController : Controller
    {
        // Reference to the data manager
        private Manager m = new Manager();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "WEB524 Winter 2023.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact me.";

            return View();
        }
    }
}