using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_Trip_Project.Models.Siniflar;

namespace Travel_Trip_Project.Controllers
{
    public class HomeController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            
            var dgr = c.Blogs.Take(4).ToList();
            return View(dgr);

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

        public PartialViewResult Partial1() {
            var dgr = c.Blogs.ToList();
            return PartialView(dgr);
        }
        public PartialViewResult Partial2() {
            var dgr = c.Blogs.Take(3).ToList();
            return PartialView(dgr);
        }
        public PartialViewResult Partial3() {
            var dgr = c.Blogs.Take(3).OrderByDescending(x => x.ID).ToList();
            return PartialView(dgr);
        }
    }
}