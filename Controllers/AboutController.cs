using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_Trip_Project.Models.Siniflar;
namespace Travel_Trip_Project.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        Context c = new Context();
        public ActionResult Index()
        {
            var dgr = c.Hakkimizdas.ToList();
            return View(dgr);
        }
    }
}