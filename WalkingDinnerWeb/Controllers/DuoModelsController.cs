using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WalkingDinnerWeb.DAL;
using WalkingDinnerWeb.Models;
using Microsoft.AspNet.Identity;

namespace WalkingDinnerWeb.Controllers
{
    public class DuoModelsController : Controller
    {
        private WalkingDinnerContext db = new WalkingDinnerContext();

        // GET: DuoModels
        public async Task<ActionResult> Index()
        {
            return View(await db.Duos.ToListAsync());
        }

        // GET: DuoModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DuoModel duoModel = await db.Duos.FindAsync(id);
            if (duoModel == null)
            {
                return HttpNotFound();
            }
            return View(duoModel);
        }

        // GET: DuoModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DuoModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,FirstNameOne,LastNameOne,InsertionOne,FirstNameTwo,LastNameTwo,InsertionTwo,StreetName,HouseNumber,PostalCode,City,PhoneNumber,Email,Dietary,IBan")] DuoModel duoModel)
        {
            //TODO: manage id and userId
            if (ModelState.IsValid)
            {
                duoModel.UserId = User.Identity.GetUserId();
                db.Duos.Add(duoModel);            
                await db.SaveChangesAsync();
                return RedirectToAction("Index","Home");
            }
            return View(duoModel);
        }

        // GET: DuoModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DuoModel duoModel = await db.Duos.FindAsync(id);
            if (duoModel == null)
            {
                return HttpNotFound();
            }
            return View(duoModel);
        }

        // POST: DuoModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,FirstNameOne,LastNameOne,InsertionOne,FirstNameTwo,LastNameTwo,InsertionTwo,StreetName,HouseNumber,PostalCode,City,PhoneNumber,Email,Dietary")] DuoModel duoModel)
        {
            //TODO: manage id and userId
            if (ModelState.IsValid)
            {
                db.Entry(duoModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(duoModel);
        }

        // GET: DuoModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DuoModel duoModel = await db.Duos.FindAsync(id);
            if (duoModel == null)
            {
                return HttpNotFound();
            }
            return View(duoModel);
        }

        // POST: DuoModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            DuoModel duoModel = await db.Duos.FindAsync(id);
            db.Duos.Remove(duoModel);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        //Action Result for displaying the Profile from The User
        public ActionResult myProfile()
        {
            var currentUserId = User.Identity.GetUserId();
            var profile = db.Duos.Where(d => d.UserId == currentUserId).FirstOrDefault();
            return View(profile);
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
