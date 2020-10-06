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
    public class ÇalışmaAlanlarıController : Controller
    {

        UnitOfWork unitOfWork;

        public ÇalışmaAlanlarıController()
        {

            unitOfWork = new UnitOfWork();

        }

        public ActionResult Index()
        {
            var çalışmaAlanları = unitOfWork.GetRepository<ÇalışmaAlanları>().GetAll();
            return View(çalışmaAlanları);
        }

        public RedirectToRouteResult Ekle()
        {
            Context context = new Context();

            ÇalışmaAlanları çalışmaAlanları = new ÇalışmaAlanları()
            {
               
                Ad="YapayZeka",
                Etiket="DerinÖğrenme",
                Acıklama="Düşünebilen Robotlar"

            };

            context.CalısmaAlanları.Add(çalışmaAlanları);
            context.SaveChanges();


            return RedirectToAction("Index", "ÇalışmaBilgileri");
        }
    }
}