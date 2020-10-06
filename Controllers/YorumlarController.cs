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
    public class YorumlarController : Controller
    {
        UnitOfWork unitOfWork;

        public YorumlarController()
        {

            unitOfWork = new UnitOfWork();

        }

        public ActionResult Index()
        {
            var yorumlar = unitOfWork.GetRepository<Yorumlar>().GetAll();
            return View(yorumlar);
        }

        public RedirectToRouteResult Ekle()
        {
            Context context = new Context();

            Yorumlar yorumlar = new Yorumlar()
            {
                Yorum="Harika",
                Onay="Onaylandı",
            };

            context.Yorumlar.Add(yorumlar);
            context.SaveChanges();


            return RedirectToAction("Index", "Yorumlar");
        }
    }
}