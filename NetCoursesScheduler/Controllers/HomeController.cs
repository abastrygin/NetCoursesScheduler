using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NetCoursesScheduler.Models;
using System.ComponentModel.DataAnnotations;

namespace NetCoursesScheduler.Controllers
{
    public class HomeController : Controller
    {

          private SchedulerDBEntities _db = new SchedulerDBEntities();

        // GET: Home
        public ActionResult Index()
        {
            return View(_db.Events.ToList());
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create([Bind(Exclude = "Id")] Event newEvent)
        {
            if (!ModelState.IsValid)

                return View();

            _db.Events.Add(newEvent);

            _db.SaveChanges();

            return RedirectToAction("Index");

        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            Event editEvent = _db.Events.Where(w => w.Id == id).First();
       
            return View(editEvent);
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(Event eventOnEdit)
        {
            _db.Entry(eventOnEdit).State = System.Data.Entity.EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            Event deleteEvent = _db.Events.Where(w => w.Id == id).First();
            return View(deleteEvent);
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(Event deleteEvent)
        {
            _db.Entry(deleteEvent).State = System.Data.Entity.EntityState.Deleted;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
