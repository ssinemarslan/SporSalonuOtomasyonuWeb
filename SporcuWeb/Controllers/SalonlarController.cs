using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SporcuWeb.Models;

namespace SporcuWeb.Controllers
{
    public class SalonlarController : Controller
    {
        // GET: Salonlar
        Model1Container1 db=new Model1Container1();
        public ActionResult Index()
        {
            return View(db.SalonlarBilgiSet.ToList());
        }
        [HttpGet]
        public ActionResult Yeni()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Yeni(SalonlarBilgi Kaydet)
        {
            db.SalonlarBilgiSet.Add(Kaydet);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Yenile(int id)
        {
            using (Model1Container1 db = new Model1Container1())
            {
                return View(db.SalonlarBilgiSet.Where(x => x.SalonNo == id).FirstOrDefault());
            }
        }
        [HttpPost]
        public ActionResult Yenile(int id, SalonlarBilgi yenile)
        {
            using (Model1Container1 db = new Model1Container1())
            {
                db.Entry(yenile).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }
        public ActionResult Sil(int id)
        {
            using (Model1Container1 db = new Model1Container1())
            {
                return View(db.SalonlarBilgiSet.Where(x => x.SalonNo == id).FirstOrDefault());
            }
        }
        [HttpPost]
        public ActionResult Sil(int id, SalonlarBilgi sil)
        {
            using (Model1Container1 db = new Model1Container1())
            {
                sil = db.SalonlarBilgiSet.Where(x => x.SalonNo == id).FirstOrDefault();
                db.SalonlarBilgiSet.Remove(sil);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }
}
