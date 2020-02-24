using ClientSideValidations_Jquery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ClientSideValidations_Jquery.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Kullanicilar kullanici)
        {
            if (ModelState.IsValid)
            {
                return View("Index");
            }
            else
            {
                return View("Index", kullanici);
            }
        }
    }
}