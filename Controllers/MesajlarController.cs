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
    public class MesajlarController : Controller
    {
        UnitOfWork unitOfWork;

        public MesajlarController()
        {

            unitOfWork = new UnitOfWork();

        }

        public ActionResult Index()
        {
            var mesajlar = unitOfWork.GetRepository<Mesajlar>().GetAll();
            return View(mesajlar);
        }

        public RedirectToRouteResult Ekle()
        {
            Context context = new Context();

            Mesajlar mesajlar = new Mesajlar()
            {
               

                Icerık="Merhabalar",
                Tarıh=DateTime.Now,
                Saat=22
                

            };

            context.Mesajlar.Add(mesajlar);
            context.SaveChanges();


            return RedirectToAction("Index", "Mesajlar");
        }
    }
}