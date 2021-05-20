using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxTestApp.Controllers
{
    public class AjaxTestController : Controller
    {
        // GET: AjaxTest
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FirstAjax()
        {
            return Json("Sachin", JsonRequestBehavior.AllowGet);
        }

    }
}