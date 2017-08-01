using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TMS.Controllers
{
    public class CarController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UploadQty()
        {
            return View();
        }

    }
}