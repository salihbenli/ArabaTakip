using System.Web.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;

namespace Araba_Takip.Controllers
{
    public class AractanimlamaController : Controller
    {
        // GET: Aractanimlama

        AracTaManager aracm = new AracTaManager(new EfAractaDal());
        public ActionResult Aractanimla()
        {
            var degerler = aracm.GetList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult IslemEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult IslemEkle(AracTanimlama p)
        {
            aracm.AractaAdd(p);
            return RedirectToAction("Aractanimla");
        }
        public ActionResult IslemDelete(int id)
        {
            var aractaIslem = aracm.GetById(id);
            aracm.IslemDelete(aractaIslem);
            return RedirectToAction("Aractanimla");
        }
        [HttpGet]
        public ActionResult IslemUpdate(int id)
        {
            var aracIslem = aracm.GetById(id);
            return View(aracIslem);
        }
        [HttpPost]
        public ActionResult IslemUpdate(AracTanimlama p)
        {
            aracm.IslemtaUpdate(p);
            return RedirectToAction("Aractanimla");
        }
    }
}
