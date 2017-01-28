using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Passwords_ASP.NET.Models;

namespace Passwords_ASP.NET.Controllers
{
    public class HomeController : Controller
    {
        SiteContext db = new SiteContext();

        public ActionResult Index()
        {
            IEnumerable<Site> sites = db.Sites;
            ViewBag.Sites = sites;

            return View();
        }

        public ActionResult AddSite(Site site)
        {
            db.Sites.Add(site);
            db.SaveChanges();

            return RedirectToAction("Index");            
        }
        
        [HttpPost]
        public ActionResult DeleteSite(int id)
        {
            Site site = db.Sites.Where(s => s.Id == id).FirstOrDefault();
            
            db.Sites.Remove(site);
            db.SaveChanges();
            
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult EditSite(Site site)
        {
            db.Entry(site).State = EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}