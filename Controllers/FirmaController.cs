using MezunSistemi.Data;
using MezunSistemi.Data.Model;
using MezunSistemi.Data.UnitOfWork;
using System.Web.Mvc;

namespace MezunSistemi.Controllers
{
    public class FirmaController : Controller
    {
        UnitOfWork unitOfWork;

        public  FirmaController()
        {

            unitOfWork = new UnitOfWork();

        }

        public ActionResult Index()
        {
            var firmalar = unitOfWork.GetRepository<Firma>().GetAll();
            return View(firmalar);
        }

        [HttpGet]
        public RedirectToRouteResult Ekle(string ad, string alan,string tel,string mail,string sorumlu)
        {
            Context context = new Context();

            Firma firma = new Firma()
            {
                Ad = ad,
                Alan = alan,
                Tel = tel,
                Mail = mail,
                Sorumlu = sorumlu



            };

            context.Firmalar.Add(firma);
            context.SaveChanges();


            return RedirectToAction("Index", "Firma");
        }

        [HttpPost]
        public JsonResult GuncelleJson(int frmId, string frmAd, string frmAlan)
        {

            var frm = unitOfWork.GetRepository<Firma>().GetById(frmId);
            frm.Ad = frmAd;
            frm.Alan = frmAlan;
            var durum = unitOfWork.SaveChanges();
            if (durum > 0) return Json("1");
            return Json("0");

        }
        [HttpPost]
        public JsonResult SilJson(int frmId)
        {

            unitOfWork.GetRepository<Firma>().Delete(frmId);
            var durum = unitOfWork.SaveChanges();
            if (durum > 0) return Json("1");
            return Json("0");

        }
    }
}