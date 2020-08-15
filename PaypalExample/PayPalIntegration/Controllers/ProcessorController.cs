using PayPalIntegration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PayPalIntegration.Controllers
{
    public class ProcessorController : Controller
    {
        [HttpPost]
        public ActionResult PaypalResponse(PaypalResponseModel model ,string purchaseType)
        {
            if (!string.IsNullOrEmpty(model.PayerId))
                return RedirectToAction("Index", "Home");
            else
                return View();
        }
    }
}