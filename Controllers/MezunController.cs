using MezunSistemi.Data;
using MezunSistemi.Data.Model;
using MezunSistemi.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MezunSistemi.Controllers
{
    public class MezunController : Controller
    {



        UnitOfWork unitOfWork;

        public MezunController()
        {

            unitOfWork = new UnitOfWork();

        }

        public ActionResult Index()
        {
            dynamic mymodel = new ExpandoObject();
            mymodel.Mezunlar = unitOfWork.GetRepository<Mezun>().GetAll();
            mymodel.Firmalar = unitOfWork.GetRepository<Firma>().GetAll();
            return View(mymodel);
        }

        [HttpPost]
        public JsonResult EkleJson(string mznAd)
        {
            Mezun mznn = new Mezun();
            mznn.Ad = mznAd;
            var eklenenMzn = unitOfWork.GetRepository<Mezun>().Add(mznn);
            unitOfWork.SaveChanges();
            return Json(
                new
                {
                    Result = new
                    {                  
                        Ad = eklenenMzn.Ad,
                        Soyad = eklenenMzn.Soyad,
                        Tel = eklenenMzn.Tel,
                        Eposta = eklenenMzn.Eposta,
                        Id = eklenenMzn.Id,
                        Firma = eklenenMzn.Firma,
                        Pozısyon = eklenenMzn.Pozısyon,
                        CalısmaAlanları = eklenenMzn.CalısmaAlanları,
                        YabancıDil = eklenenMzn.YabancıDil
                    },JsonRequestBehavior.AllowGet
                }
                );
        }

        [HttpPost]
        public JsonResult GuncelleJson(int mznId,string mznAd)
        {

            var mezun = unitOfWork.GetRepository<Mezun>().GetById(mznId);
            mezun.Ad = mznAd;
            var durum= unitOfWork.SaveChanges();
            if (durum > 0) return Json("1");
            return Json("0");

        }
        [HttpPost]
        public JsonResult SilJson(int mznId)
        {

            unitOfWork.GetRepository<Mezun>().Delete(mznId);          
            var durum = unitOfWork.SaveChanges();
            if (durum > 0) return Json("1");
            return Json("0");

        }



    }
      
}