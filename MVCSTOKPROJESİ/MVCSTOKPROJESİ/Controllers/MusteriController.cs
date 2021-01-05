using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSTOKPROJESİ.Models.Entity;

namespace MVCSTOKPROJESİ.Controllers
{
    public class MusteriController : Controller
    {
        //
        // GET: /Musteri/
        MVC_STOK_VERİTABANIEntities1 db = new MVC_STOK_VERİTABANIEntities1();
        public ActionResult Index()
        {
            var degerler = db.MUSTERI_TABLOSU.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult MusteriEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult MusteriEkle(MUSTERI_TABLOSU p1)
        {
            db.MUSTERI_TABLOSU.Add(p1);
            db.SaveChanges();
            return View();
        }
        public ActionResult SIL(int id)
        {
            var musteri = db.MUSTERI_TABLOSU.Find(id);
            db.MUSTERI_TABLOSU.Remove(musteri);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult MusteriGetir(int id)
        {
            var mus = db.MUSTERI_TABLOSU.Find(id);
            return View("MusteriGetir", mus);
        }
        public ActionResult Guncelle(MUSTERI_TABLOSU p1)
        {
            var musteri = db.MUSTERI_TABLOSU.Find(p1.MUSTERIID);
            musteri.MUSTERIAD = p1.MUSTERIAD;
            musteri.MUSTERISOYAD = p1.MUSTERISOYAD;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
	}
}