using BarangayBagbag.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BarangayBagbag.Controllers
{
    public class LoginController : Controller
    {
        DBContext dbContext = new DBContext();

        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View(new UserCredential());
        }

        [HttpPost]
        public ActionResult Index(UserCredential userCredential, string returnUrl) { 
        
            var isUserFound = dbContext.UserCredentials.Any(user => user.username == userCredential.username && user.password == userCredential.password);

            if (isUserFound)
            {
                if (returnUrl != null)
                {
                    FormsAuthentication.SetAuthCookie(userCredential.username, false);
                    return Redirect(returnUrl);
                }
                else
                {
                    return RedirectToAction("Index", "Admin");
                }
            }

            ModelState.AddModelError("", "Invalid username or password.");
            return View(userCredential);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }
    }
}