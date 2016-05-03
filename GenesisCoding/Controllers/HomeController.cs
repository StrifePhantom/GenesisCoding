using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GenesisCoding.Controllers
{
    public class HomeController : ApplicationBaseController
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

        public ActionResult HomePage()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult OverView()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Variables()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Operators()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult DescisionMaking()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Loops()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Baseball()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Pencil()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}