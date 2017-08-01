using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TMS.Controllers
{
    public class LayoutController : Controller
    {
        public ActionResult FirstStyle()
        {
            return View();
        }

        public ActionResult SecondStyle()
        {
            return View();
        }

        public ActionResult ThirdStyle()
        {
            return View();
        }
    }
}