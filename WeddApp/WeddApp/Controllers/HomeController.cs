using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WeddApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Location()
        {
            ViewBag.Message = "Location and Venue Information";

            return View();
        }

        public ActionResult TravelInfo()
        {
            ViewBag.Message = "Travel and Accommodation Information";

            return View();
        }

        public ActionResult ThingsToDo()
        {
            ViewBag.Message = "Things To Do";

            return View();
        }

        public ActionResult BranAng()
        {
            ViewBag.Message = "About Us";

            return View();
        }

        public ActionResult TheWedding()
        {
            ViewBag.Message = "The Wedding";

            return View();
        }

        public ActionResult Gifts()
        {
            ViewBag.Message = "Gift and Registry Information";

            return View();
        }

    }
}