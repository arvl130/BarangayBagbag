using BarangayBagbag.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BarangayBagbag.Controllers
{
    [Authorize(Roles = "ADMIN")]
    public class ManageAnnouncementsController : Controller
    {
        DBContext dbContext = new DBContext();
        // GET: Admin
        public ActionResult Index()
        {
            var announcements = dbContext.Announcements.ToList();
            return View(announcements);
        }

        public ActionResult Details(int id)
        {
            var announcement = dbContext.Announcements.Find(id);
            return View(announcement);
        }

        public ActionResult Create()
        {
            return View(new Announcement());
        }

        public ActionResult Edit(int id)
        {
            var announcement = dbContext.Announcements.Find(id);
            return View(announcement);
        }

        public ActionResult Delete(int id)
        {
            var announcement = dbContext.Announcements.Find(id);
            return View(announcement);
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var patient = dbContext.Announcements.Find(id);
                dbContext.Announcements.Remove(patient);
                dbContext.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult Edit(int id, Announcement announcement)
        {
            try
            {
                dbContext.Entry(announcement).State = EntityState.Modified;
                dbContext.SaveChanges();

                return RedirectToAction("Details", new { Id = id });
            }
            catch
            {
                return View(announcement);
            }
        }

        [HttpPost]
        public ActionResult Create(Announcement announcement)
        {
            try
            {
                announcement.createdAt = DateTime.Now;
                dbContext.Announcements.Add(announcement);
                dbContext.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View(announcement);
            }
        }
    }
}