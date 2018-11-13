using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IoT_Test.ClientWebApp.Controllers
{
    public class HomeController : Controller
    {
        private AppDatabase dbContext;

        public HomeController()
        {
            dbContext = new AppDatabase();
        }

        public ActionResult Index()
        {
            var messages = dbContext.Messages.ToList();
            return Json(messages, JsonRequestBehavior.AllowGet);
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