using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SporcuWeb.Models;

namespace SporcuWeb.Controllers
{
    public class SporcularController : Controller
    {
        // GET: Sporcular
        Model1Container1 db = new Model1Container1();
        public ActionResult Index()
        {
            return View(db.SporcularBilgiSet.ToList());
        }
        [HttpGet]
        public ActionResult Yeni()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Yeni(SporcularBilgi Kaydet)
        {
            db.SporcularBilgiSet.Add(Kaydet);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Yenile(int id)
        {
            using(Model1Container1 db=new Model1Container1())
            {
                return View(db.SporcularBilgiSet.Where(x => x.SporcuNo == id).FirstOrDefault());

            }
        }
        [HttpPost]
        public ActionResult Yenile(int id, SporcularBilgi yenile)
        {
            using (Model1Container1 db = new Model1Container1())
            {
                db.Entry(yenile).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }


        }
        [HttpGet]
        public ActionResult Sil(int id)
        {
            using (Model1Container1 db = new Model1Container1())
            {
                return View(db.SporcularBilgiSet.Where(x => x.SporcuNo == id).FirstOrDefault());
            }
        }
        [HttpPost]
        public ActionResult Sil(int id, SporcularBilgi sil)
        {
            using (Model1Container1 db = new Model1Container1())
            {
                sil = db.SporcularBilgiSet.Where(x => x.SporcuNo == id).FirstOrDefault();
                db.SporcularBilgiSet.Remove(sil);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }

    }
}