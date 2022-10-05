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
                // base quote of $50 per month
                decimal quoteAmount = 50.00m;

                // calculate current age in years
                int age = DateTime.Now.Year - insuree.DateOfBirth.Year;
                // if insuree hasn't had their birthday yet this year, subtract one from age
                if (DateTime.Now.DayOfYear < insuree.DateOfBirth.DayOfYear)
                {
                    age -= 1;
                }
                // if age is 18 or under, add $100 to quote
                if (age <= 18)
                {
                    quoteAmount += 100.00m;
                }
                // if age is 19-25, add $50
                if (age >= 19 && age <= 25)
                {
                    quoteAmount += 50.00m;
                }
                // if age is 26 or greater, add $25
                if (age >= 26)
                {
                    quoteAmount += 25.00m;
                }

                // if car year is before 2000 or after 2015, add $25
                if (insuree.CarYear < 2000 || insuree.CarYear > 2015)
                {
                    quoteAmount += 25.00m;
                }

                // if car is a porsche, add $25, if model is 911 carrera, add another $25
                if (insuree.CarMake.ToLower() == "porsche")
                {
                    quoteAmount += 25.00m;
                    if (insuree.CarModel.ToLower() == "911 carrera")
                    {
                        quoteAmount += 25.00m;
                    }
                }

                // add $10 per speeding ticket
                quoteAmount += (insuree.SpeedingTickets * 10);
                
                // if user has had a DUI, add 25%
                if (insuree.DUI == true)
                {
                    quoteAmount *= 1.25m;
                }

                // if user wants full coverage, add 50%
                if (insuree.CoverageType == true)
                {
                    quoteAmount *= 1.5m;
                }

                insuree.Quote = quoteAmount;
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

        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
        }
    }
}
