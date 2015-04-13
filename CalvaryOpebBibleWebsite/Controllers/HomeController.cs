using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalvaryOpebBibleWebsite.Controllers
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
        public ActionResult Ministries()
        {
            ViewBag.Message = "Your ministries description page.";

            return View();
        }
        public ActionResult Media()
        {
            ViewBag.Message = "Your media description page.";

            return View();
        }
        public ActionResult Calendar()
        {
            ViewBag.Message = "Your calendar description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}