using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmpireSecurityServices.Controllers
{
    public class ResponseController : Controller
    {
        //
        // GET: /Response/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Success(string pageType)
        {
            ViewBag.pageType = pageType;
            return View();
        }

        public ActionResult Failure()
        {
            return View();
        }
	}
}