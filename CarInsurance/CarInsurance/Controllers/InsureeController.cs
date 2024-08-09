using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = GetQuote(insuree);
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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

        // GET: Insuree/Admin
        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
        }

        // Quote Calculation
        public decimal GetQuote(Insuree insuree)
        {

            // Start with £50
            decimal quoteTotal = 50;

            // Check age and add amount depending which category they fit into
            var today = DateTime.Today;

            int age = today.Year - insuree.DateOfBirth.Year;

            if(age <= 18)
            {
                quoteTotal += 100;
            }
            else if(age >= 19 && age <= 25)
            {
                quoteTotal += 50;
            }
            else
            {
                quoteTotal += 25;
            }

            // Check the cars year and add £25 if the car is before 2000 or after 2015
            if (insuree.CarYear < 2000 ||  insuree.CarYear > 2015)
            {
                quoteTotal += 25;
            }

            // Check the cars make and model and add to quote if criteria is hit
            if (insuree.CarMake == "Porsche" && insuree.CarModel == "911 Carrera")
            {
                quoteTotal += 50;
            }
            else if (insuree.CarMake == "Porsche")
            {
                quoteTotal += 25;
            }

            // Add £10 for every speeding ticket 
            quoteTotal += insuree.SpeedingTickets * 10;

            // If the user has ever had a DUI add 25%
            if (insuree.DUI == true)
            {
                quoteTotal *= 1.25M;
            }

            // If full coverage add 50%
            if (insuree.CoverageType == true)
            {
                quoteTotal *= 1.5M;
            }

            return insuree.Quote = quoteTotal;
        }
    }
}
