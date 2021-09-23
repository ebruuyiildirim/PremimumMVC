using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PremimumMVC.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            
            return View();
            
        }
        public ActionResult İletisim()
        {
            return View();
        }

        public ActionResult Destek()
        {
            return View();
        }
        public ActionResult Blog()
        {
            return View();
        }

        public ActionResult Ozellikler()
        {
            return View();
        }
    }
}