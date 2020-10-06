using MezunSistemi.Data;
using MezunSistemi.Data.Model;
using MezunSistemi.Data.UnitOfWork;
using System;
using System.Web.Mvc;

namespace MezunSistemi.Controllers
{
    public class ÇalışmaBilgileriController : Controller
    {

        UnitOfWork unitOfWork;

        public ÇalışmaBilgileriController()
        {

            unitOfWork = new UnitOfWork();

        }

        public ActionResult Index()
        {
            var CalısmaBılgılerı = unitOfWork.GetRepository<ÇalışmaBilgileri>().GetAll();
            return View(CalısmaBılgılerı);
        }

        public RedirectToRouteResult Ekle()
        {
            Context context = new Context();

            ÇalışmaBilgileri CalısmaBılgılerı = new ÇalışmaBilgileri()
            {
               BaslangıcTarıhı=DateTime.Now,
               CıkısTarıhı=DateTime.Now
            };

            context.CalısmaBılgılerı.Add(CalısmaBılgılerı);
            context.SaveChanges();


            return RedirectToAction("Index", "ÇalışmaBilgileri");
        }
    }
}