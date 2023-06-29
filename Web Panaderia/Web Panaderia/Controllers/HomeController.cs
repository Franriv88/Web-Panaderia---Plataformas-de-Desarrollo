using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_Panaderia.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

       
         public ActionResult Login()
        {
            ViewBag.Message = "Your login page.";

            return View();
        }        
            
        public ActionResult Register()
        {
            ViewBag.Message = "Your register page.";

            return View();
        }



    }
}