using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSTOKPROJESİ.Models.Entity;

namespace MVCSTOKPROJESİ.Controllers
{
    public class KategoriController : Controller
    {
        //
        // GET: /Kategori/
        MVC_STOK_VERİTABANIEntities1 db = new MVC_STOK_VERİTABANIEntities1();
        public ActionResult Index()
        {
            var degerler = db.KATEGORI_TABLOSU.ToList();//bu komut ile select komutuyla yaptığımız işlemi kısa bir şekilde yapmış olduk.
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniKategori()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniKategori(KATEGORI_TABLOSU p1) //burasını biz olusturduk yeni kategori ekleme butonunun olduğu kısmı yapmak için..
        {
            if (!ModelState.IsValid)
            {
                return View("YeniKategori");
            }
            db.KATEGORI_TABLOSU.Add(p1); //kategori tablosunu p1 değerini ekle
            db.SaveChanges();//değişiklikleri kaydet yapıyoruz  burada
            return View();
        }
        public ActionResult SIL(int id)
        {
            var kategori = db.KATEGORI_TABLOSU.Find(id);
            db.KATEGORI_TABLOSU.Remove(kategori);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult KategoriGetir(int id)
        {
            var ktgrr = db.KATEGORI_TABLOSU.Find(id);
            return View("KategoriGetir", ktgrr);
        }
        public ActionResult Guncelle(KATEGORI_TABLOSU p1)
        {
            var ktgr = db.KATEGORI_TABLOSU.Find(p1.KATEGORIID);
            ktgr.KATEGORIAD = p1.KATEGORIAD;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
	}
}