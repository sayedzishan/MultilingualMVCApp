using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MultilingualMVCApp.Models;

namespace MultilingualMVCApp.Controllers
{
    public class HomeController : MyCommonController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Lang()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Lang(SignUp r)
        {
            return View(r);
        }
        public ActionResult ChangeLanguage(string lang)
        {
            new LangTrans().SetLanguage(lang);
            return RedirectToAction("Lang", "Home");
        }
    }
}