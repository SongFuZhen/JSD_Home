using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TMS.Controllers
{
    public class OrderController : Controller
    {
        public ActionResult FSOrder()
        {
            return View();
        }

        public ActionResult SSOrder()
        {
            return View();
        }

    }
}