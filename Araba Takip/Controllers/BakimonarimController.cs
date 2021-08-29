using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;

namespace Araba_Takip.Controllers
{
    public class BakimonarimController : Controller
    {
        // GET: Bakimonarim


        BakimManager bam = new BakimManager(new EfBakimDal());
        AracTaManager aracm = new AracTaManager(new EfAractaDal());
        public ActionResult Bakim()
        {
            var degerler = bam.GetList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult BakimEkle()
        {
            List<SelectListItem> valueId = (from x in aracm.GetList()
                                            select new SelectListItem
                                            {
                                                Text = x.Arac_Plakasi,
                                                Value = x.AracId.ToString()
                                            }).ToList();
            ViewBag.vlc = valueId;
            return View();
        }
        [HttpPost]
        public ActionResult BakimEkle(BakimOnarim p)
        {
            bam.BakimAdd(p);
            return RedirectToAction("Bakim");
        }
        public ActionResult BakimDelete(int id)
        {
            var bakim = bam.GetById(id);
            bam.BakimDelete(bakim);
            return RedirectToAction("Bakim");
        }
        [HttpGet]
        public ActionResult BakimUpdate(int id)
        {
            var bakim = bam.GetById(id);
            return View(bakim);
        }
        [HttpPost]
        public ActionResult BakimUpdate(BakimOnarim p)
        {
            bam.BakimUpdate(p);
            return RedirectToAction("Bakim");
        }


        public ActionResult JBakimEkle(BakimOnarim p)
        {
            bam.BakimAdd(p);
            return RedirectToAction("Bakim");
        }
    }
}