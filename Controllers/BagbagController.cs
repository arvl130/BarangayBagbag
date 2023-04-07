using BarangayBagbag.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BarangayBagbag.Controllers
{
    public class BagbagController : Controller
    {
        DBContext dbContext = new DBContext();

        // GET: Bagbag
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }
        public ActionResult Announcements()
        {
            var announcements = dbContext.Announcements.ToList();
            return View(announcements);
        }
    }
}