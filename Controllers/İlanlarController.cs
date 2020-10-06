using MezunSistemi.Data;
using MezunSistemi.Data.Model;
using MezunSistemi.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MezunSistemi.Controllers
{
    public class İlanlarController : Controller
    {
        UnitOfWork unitOfWork;

        public İlanlarController()
        {

            unitOfWork = new UnitOfWork();

        }

        public ActionResult Index()
        {
            var ilanlar = unitOfWork.GetRepository<İlanlar>().GetAll();
            return View(ilanlar);
        }

        public RedirectToRouteResult Ekle()
        {
            Context context = new Context();

            İlanlar ilanlar = new İlanlar()
            {
              
                Baslık="Rtük SoftwareDeveloper",
                Acıklama="Deneyimli yazılımcılar aranıyor",
                IlanTarıhı=DateTime.Now,
                GecerlılıkSuresı=DateTime.Now,
                Tür="İş",
                Sure=DateTime.Now,
                Donem="YazDönemi"
            };

            context.Ilanlar.Add(ilanlar);
            context.SaveChanges();


            return RedirectToAction("Index", "Firma");
        }
    }
}