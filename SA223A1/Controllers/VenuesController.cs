using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SA223A1.Controllers
{
    public class VenuesController : Controller
    {
        private Manager m = new Manager();

        // GET: Venues
        public ActionResult Index()
        {
            return View(m.VenueGetAll());
        }

        // GET: Venues/Details/5
        public ActionResult Details(int? id)
        {
            return View();
        }

        // GET: Venues/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Venues/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Venues/Edit/5
        public ActionResult Edit(int? id)
        {
            return View();
        }

        // POST: Venues/Edit/5
        [HttpPost]
        public ActionResult Edit(int? id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Venues/Delete/5
        public ActionResult Delete(int? id)
        {
            return View();
        }

        // POST: Venues/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
