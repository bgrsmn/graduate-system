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
    public class EğitimBilgileriController : Controller
    {



        UnitOfWork unitOfWork;

        public EğitimBilgileriController()
        {

            unitOfWork = new UnitOfWork();

        }

        public ActionResult Index()
        {
            var EgıtımBılgılerı = unitOfWork.GetRepository<EğitimBilgileri>().GetAll();
            return View(EgıtımBılgılerı);
        }
        public RedirectToRouteResult Ekle()
        {
            Context context = new Context();

            EğitimBilgileri EğitimBilgileri = new EğitimBilgileri()
            {
                Okul="Ktü",
                MezunıyetTarıhı =DateTime.Now,
                Bolumu="BilgisayarMühendisliği",
                Ortalama="2"
            };

            context.EgıtımBılgılerı.Add(EğitimBilgileri);
            context.SaveChanges();


            return RedirectToAction("Index", "EğitimBilgileri");
        }
    }
}