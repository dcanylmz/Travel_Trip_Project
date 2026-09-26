using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_Trip_Project.Models.Siniflar;

namespace Travel_Trip_Project.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        
        Context c = new Context();
        
        // GET: Admin
        public ActionResult Index()
        {
            var dgr = c.Blogs.ToList();
            return View(dgr);
        }
        [HttpGet]

        public ActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost]

        public ActionResult YeniBlog(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogSil(int id)
        {
            var b = c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogGetir(int id)
        {
            var bl = c.Blogs.Find(id);
            return View("BlogGetir", bl);
        }
        public ActionResult BlogGuncelle(Blog b)
        {
            var blg = c.Blogs.Find(b.ID);
            blg.Baslik = b.Baslik;
            blg.Tarih = b.Tarih;
            blg.BlogImage = b.BlogImage;
            blg.Aciklama = b.Aciklama;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YorumListesi()
        {
            var yorumlar = c.Yorumlars.ToList();
            return View(yorumlar);
        }
        public ActionResult YorumSil(int id)
        {
            var y = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(y);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        public ActionResult YorumGetir(int id)
        {
            var yg = c.Yorumlars.Find(id);
            return View("YorumGetir", yg);
        }
        public ActionResult YorumGuncelle(Yorumlar y)
        {
            var yg = c.Yorumlars.Find(y.ID);
            yg.KullaniciAdi = y.KullaniciAdi;
            yg.Mail= y.Mail;
            yg.Yorum = y.Yorum;
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
    }
}