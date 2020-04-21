using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNET_BoostrapCustomThemeDemo.Controllers
{
    public class MySampleController : Controller
    {
        //
        // GET: /MySample/

        public ActionResult MySampleAction()
        {
            ViewBag.Title = "SampleController";
            return View();
        }

    }
}
