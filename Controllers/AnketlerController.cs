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
    public class AnketlerController : Controller
    {
        UnitOfWork unitOfWork;

        public AnketlerController()
        {

            unitOfWork = new UnitOfWork();

        }

        public ActionResult Index()
        {
            var anketler = unitOfWork.GetRepository<Anketler>().GetAll();
            return View(anketler);
        }

        public RedirectToRouteResult Ekle()
        {
            Context context = new Context();

            Anketler anketler = new Anketler()
            {
              
                AnketIcerıgı="Mezun Bilgileri"
            };

            context.Anketler.Add(anketler);
            context.SaveChanges();


            return RedirectToAction("Index", "Anketler");
        }
    }
}