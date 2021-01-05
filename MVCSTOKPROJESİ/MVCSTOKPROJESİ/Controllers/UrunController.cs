using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSTOKPROJESİ.Models.Entity;

namespace MVCSTOKPROJESİ.Controllers
{
    public class UrunController : Controller
    {
        //
        // GET: /Urun/
        MVC_STOK_VERİTABANIEntities1 db = new MVC_STOK_VERİTABANIEntities1();
        public ActionResult Index()
        {
            var degerler = db.URUN_TABLOSU.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult UrunEkle()
        {
            List<SelectListItem> degerler = (from i in db.KATEGORI_TABLOSU.ToList()
                                             select new SelectListItem()
                                             {
                                                 Text = i.KATEGORIAD,
                                                 Value = i.KATEGORIID.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            return View();
        }
        [HttpPost]
        public ActionResult UrunEkle(URUN_TABLOSU p1)
        {
            var ktgr = db.KATEGORI_TABLOSU.Where(m => m.KATEGORIID == p1.KATEGORI_TABLOSU.KATEGORIID).FirstOrDefault();
            p1.KATEGORI_TABLOSU = ktgr;

            db.URUN_TABLOSU.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult SIL(int id) //burada  tanımladığımız actionresult ile silme işlemini yapıyoruz .
        {
            var urun = db.URUN_TABLOSU.Find(id);
            db.URUN_TABLOSU.Remove(urun);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
	}
}