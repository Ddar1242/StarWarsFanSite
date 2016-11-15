using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StarWarsFanSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Movies()
        {
            ViewBag.Message = "Saga Biography";

            return View();
        }

        public ActionResult Characters()
        {
            ViewBag.Message = "Know your favourites";

            return View();
        }
    }
}