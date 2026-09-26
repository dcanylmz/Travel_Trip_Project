using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_Trip_Project.Models.Siniflar;

namespace Travel_Trip_Project.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default

        public ActionResult Index()
        {
            
            return View();
        }
        public ActionResult About()
        {

            return View();

        }
    }
}