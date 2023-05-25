using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SporcuWeb.Models;

namespace SporcuWeb.Controllers
{
    public class EgitmenlerController : Controller
    {
        // GET: Egitmenler
        Model1Container1 db = new Model1Container1();
        public ActionResult Index()
        {
            return View(db.EgitmenlerBilgiSet.ToList());
        }
        [HttpGet]
        public ActionResult Yeni()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Yeni(EgitmenlerBilgi Kaydet)
        {
            db.EgitmenlerBilgiSet.Add(Kaydet);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Yenile(int id)
        {
            using(Model1Container1 db=new Model1Container1())
            {
                return View(db.EgitmenlerBilgiSet.Where(x => x.EgitmenNo == id).FirstOrDefault());
            }
        }
        [HttpPost]
        public ActionResult Yenile(int id,EgitmenlerBilgi yenile)
        {
            using(Model1Container1 db=new Model1Container1())
            {
                db.Entry(yenile).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }
        public ActionResult Sil(int id)
        {
            using(Model1Container1 db=new Model1Container1())
            {
                return View(db.EgitmenlerBilgiSet.Where(x => x.EgitmenNo == id).FirstOrDefault());
            }
        }
        [HttpPost]
        public ActionResult Sil(int id,EgitmenlerBilgi sil)
        {
            using (Model1Container1 db = new Model1Container1())
            {
                sil = db.EgitmenlerBilgiSet.Where(x => x.EgitmenNo == id).FirstOrDefault();
                db.EgitmenlerBilgiSet.Remove(sil);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }
}