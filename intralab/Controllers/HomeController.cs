using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace intralab.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Ваш вектор в цифровом мире";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Связаться с нами можно любым удобным для вас способом:";

            return View();
        }
    }
}