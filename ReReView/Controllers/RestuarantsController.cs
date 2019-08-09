using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ReReView.DAL;
using System.Text;

namespace ReReView.Controllers
{
    public class RestuarantsController : Controller
    {
        private ReReViewContext db = new ReReViewContext();

        [HttpPost]
        public ActionResult Index(string searchRestrauntString, string countryType)
        {
            var countryTypes = from f in db.Restuarants select f;
            var restraunts = from r in db.Restuarants select r;
            if (!String.IsNullOrEmpty(searchRestrauntString))
            {
                restraunts = restraunts.Where(s => s.restaurantName.Contains(searchRestrauntString));
                
            }
            
            if (!String.IsNullOrEmpty(countryType))
            {
                restraunts = restraunts.Where(s => s._class.Contains(countryType));
            }
            return View(restraunts);
        }


        public ActionResult Index()
        {
            var countryTypes = from f in db.Restuarants select f;
            var restraunts = from r in db.Restuarants select r;
            //       if (!String.IsNullOrEmpty(searchRestrauntString))
            //       {
            //           restraunts = restraunts.Where(s => s.restaurantName.Contains(searchRestrauntString));
            //          restraunts = restraunts.Where(s => s._class.Contains(countryType));
            //       }
            return View(restraunts);
        }
        // GET: Restuarants/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Restuarant restuarant = db.Restuarants.Find(id);
            if (restuarant == null)
            {
                return HttpNotFound();
            }
            return View(restuarant);
        }

        // GET: Restuarants/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Restuarants/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "restaurantID,restaurantName,_class,star,openTime,closeTIme,priceRange")] Restuarant restuarant)
        {
            if (ModelState.IsValid)
            {
                db.Restuarants.Add(restuarant);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(restuarant);
        }

        // GET: Restuarants/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Restuarant restuarant = db.Restuarants.Find(id);
            if (restuarant == null)
            {
                return HttpNotFound();
            }
            return View(restuarant);
        }

        // POST: Restuarants/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "restaurantID,restaurantName,_class,star,openTime,closeTIme,priceRange")] Restuarant restuarant)
        {
            if (ModelState.IsValid)
            {
                db.Entry(restuarant).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(restuarant);
        }

        // GET: Restuarants/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Restuarant restuarant = db.Restuarants.Find(id);
            if (restuarant == null)
            {
                return HttpNotFound();
            }
            return View(restuarant);
        }

        // POST: Restuarants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Restuarant restuarant = db.Restuarants.Find(id);
            db.Restuarants.Remove(restuarant);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
