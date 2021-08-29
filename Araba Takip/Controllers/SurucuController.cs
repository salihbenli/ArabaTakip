using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;

namespace Araba_Takip.Controllers
{
    public class SurucuController : Controller
    {
        // GET: Surucu
        SurucuManager surum = new SurucuManager(new EfSurucuDal());
        AracTaManager aracm = new AracTaManager(new EfAractaDal());
        public ActionResult Surucu()
        {
            var degerler = surum.GetList();
            return View(degerler);
        }
        
        [HttpGet]
        public ActionResult SurucuEkle()
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
        public ActionResult SurucuEkle(SurucuDetay p)
        {
            surum.SurucuAdd(p);
            return RedirectToAction("Surucu");
        }
        public ActionResult SurucuDelete(int id)
        {
            var surucuDel = surum.GetById(id);
            surum.SurucuDelete(surucuDel);
            return RedirectToAction("Surucu");
        }
        [HttpGet]
        public ActionResult SurucuUpdate(int id)
        {
            var surucu = surum.GetById(id);
            return View(surucu);
        }
        [HttpPost]
        public ActionResult SurucuUpdate(SurucuDetay p)
        {
            surum.SurucuUpdate(p);
            return RedirectToAction("Surucu");
        }
    }
}