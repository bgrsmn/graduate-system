using MezunSistemi.Data;
using MezunSistemi.Data.Model;
using MezunSistemi.Data.UnitOfWork;
using System.Web.Mvc;

namespace MezunSistemi.Controllers
{
    public class PozisyonController : Controller
    {

        UnitOfWork unitOfWork;

        public PozisyonController()
        {

            unitOfWork = new UnitOfWork();

        }

        public ActionResult Index()
        {
            var Pozısyonlar = unitOfWork.GetRepository<Pozisyon>().GetAll();
            return View(Pozısyonlar);
        }

        public RedirectToRouteResult Ekle()
        {
            Context context = new Context();

            Pozisyon Pozısyonlar = new Pozisyon()
            {  
                Ad="SeniorDeveloper",
                Etıket="TeamLead",
                Acıklama="Proje Yöneticisi"
            };

            context.Pozısyonlar.Add(Pozısyonlar);
            context.SaveChanges();


            return RedirectToAction("Index", "Pozisyon");
        }
    }
}