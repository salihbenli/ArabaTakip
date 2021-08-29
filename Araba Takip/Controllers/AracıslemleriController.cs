using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using FluentValidation.Results;

namespace Araba_Takip.Controllers
{
    public class AracıslemleriController : Controller
    {
        // GET: Aracıslemleri

        AracIsManager arm = new AracIsManager(new EfAracisDal());
        AracTaManager aracm = new AracTaManager(new EfAractaDal());

        public ActionResult AracIslemleri()
        {
            var aracList = arm.GetList();
            return View(aracList);
        }

        [HttpGet]
        public ActionResult IslemEkle()
        {
            List<SelectListItem> valueId = (from x in aracm.GetList()
                                            select new SelectListItem
                                            {
                                                Text = x.Arac_Plakasi,
                                                Value = x.AracId.ToString()
                                            }).ToList() ;
            ViewBag.vlc = valueId;
            return View();
        }
        [HttpPost]
        public ActionResult IslemEkle(AracIslemleri p)
        {
            //plaka zorunluluğu getiriyor.
            AracısValidator aracısValidator = new AracısValidator();
            ValidationResult result = aracısValidator.Validate(p);
            if (result.IsValid)
            {
                arm.AracısAdd(p);
                return RedirectToAction("AracIslemleri");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public ActionResult IslemDelete(int id)
        {
            var aracIslem = arm.GetById(id);
            arm.IslemDelete(aracIslem);
            return RedirectToAction("AracIslemleri");
        }
        [HttpGet]
        public ActionResult IslemUpdate(int id)
        {
            var aracIslem = arm.GetById(id);
            return View(aracIslem);
        }
        [HttpPost]
        public ActionResult IslemUpdate(AracIslemleri p)
        {
            arm.IslemUpdate(p);
            return RedirectToAction("AracIslemleri");
        }
    }
}