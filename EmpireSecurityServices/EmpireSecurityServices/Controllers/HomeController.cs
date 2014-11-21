using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmpireSecurityServices.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "ESS | Home";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "ESS | About Us";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Title = "ESS | Contact Us";

            return View();
        }

        //[HttpPost]
        //public ActionResult Contact()
        //{
        //    return RedirectToAction("Contact");
        //}

        public ActionResult Services()
        {
            ViewBag.Title = "ESS | Services";
            return View();
        }

        public ActionResult Career()
        {
            ViewBag.Title = "ESS | Career";
            return View();
        }

        [HttpPost]
        public ActionResult Career(HttpPostedFileBase file)
        {
            return RedirectToAction("Career");
        }
    }
}