using PayPalIntegration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PayPalIntegration.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Button()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Redirecto(string _ref)
        {
            if (!string.IsNullOrEmpty(_ref))
            {
                ViewBag.Test = "HOLA MUNDO";
                Respuesta res = new Respuesta()
                {
                    Referencia = "Home/Redirecto?referencia=" + _ref
                };
                return Json(res, JsonRequestBehavior.AllowGet);
            }
            return View();
        }

    }
}