using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeGaverbeekProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Zuur()
        {
            return View();
        }
        public ActionResult Zuivel()
        {
            return View();
        }
        public ActionResult Vis()
        {
            return View();
        }
        public ActionResult Wijn()
        {
            return View();
        }
        public ActionResult Suiker()
        {
            return View();
        }
        public ActionResult Olie()
        {
            return View();
        }
        public ActionResult Beleg()
        {
            return View();
        }
        public ActionResult Conserven()
        {
            return View();
        }
        public ActionResult BakeOff()
        {
            return View();
        }
        public ActionResult NonFood()
        {
            return View();
        }
        public ActionResult Deegwaren()
        {
            return View();
        }
        public ActionResult Kruiden()
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