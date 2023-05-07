using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using BankLogin.Models;

namespace BankLogin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            if (username == "Sayali" && password == "Sayali@123")
            {
                return RedirectToAction("RelationshipManegerLogin");
            }
            else if (username == "Sayali" && password == "Sayali123")
            {
                return RedirectToAction("OperationalManegerLogin");
            }
            else
            {
                return RedirectToAction("Register");
            }
        }
 
        public ActionResult RelationshipManegerLogin()
        {
            return View();
        }

        public ActionResult OperationalManegerLogin()
        {
            return View();
        }
        
        public ActionResult Register()
        {
            return View();
        }
    }
}