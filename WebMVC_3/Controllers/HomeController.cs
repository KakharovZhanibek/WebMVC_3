using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVC_3.Models;

namespace WebMVC_3.Controllers
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

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpGet]
        public ActionResult Du1()
        {
            return View();
        }
        [HttpPost]
        public void Du1(City city)
        {
            int id = city.Id;
            string name = city.Name;
        }
        public ActionResult dU2()
        {
            City city = new City { Id = 3, Name = "Madrid" };
            return View(city);
        }
        [HttpGet]
        public ActionResult Du3()
        {
            City city = new City { Id = 6, Name = "Sidney" };
            return View(city);
        }
        [HttpPost]
        public void Du3(City city)
        {
            int id = city.Id;
            string name = city.Name;
        }
        public ActionResult Partial()
        {
            return View();
        }
        [HttpGet]
        public ActionResult HelperTest()
        {
            return View();
        }
    }
}