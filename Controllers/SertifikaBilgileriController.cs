using MezunSistemi.Data;
using MezunSistemi.Data.Model;
using MezunSistemi.Data.UnitOfWork;
using System;
using System.Web.Mvc;

namespace MezunSistemi.Controllers
{

    public class SertifikaBilgileriController : Controller
    {

        UnitOfWork unitOfWork;

        public SertifikaBilgileriController()
        {

            unitOfWork = new UnitOfWork();

        }

        public ActionResult Index()
        {
            var sertifikabilgileri = unitOfWork.GetRepository<SertifikaBilgileri>().GetAll();
            return View(sertifikabilgileri);
        }

        public RedirectToRouteResult Ekle()
        {
            Context context = new Context();

            SertifikaBilgileri sertifikaBilgileri = new SertifikaBilgileri()
            {            
                Ad="SiberGüvenlik",
                Acıklama="EtikHackerlık",
                Tarıh= DateTime.Now,
                GecerlılıkSuresı=DateTime.Now

            };

            context.SertıfıkaBılgılerı.Add(sertifikaBilgileri);
            context.SaveChanges();


            return RedirectToAction("Index", "SertifikaBilgileri");
        }
    }
}


