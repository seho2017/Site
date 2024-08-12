using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StaticWebSitesi.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [Route("Hakkimizda")]
        public ActionResult Hakkimizda()
        {
            return View();
        }
        [Route("Ürünler")]
        public ActionResult Ürünler()
        {
            return View();
        }
        [Route("Magaza")]
        public ActionResult Mağaza()
        {
            return View();
        }
    }
}