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

namespace WalkingDinnerWeb.Controllers
{
    public class DinnerModelsController : Controller
    {
        private WalkingDinnerContext db = new WalkingDinnerContext();

        // GET: DinnerModels
        public async Task<ActionResult> Index()
        {
            return View(await db.Dinners.ToListAsync());
        }

        // GET: DinnerModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DinnerModel dinnerModel = await db.Dinners.FindAsync(id);
            if (dinnerModel == null)
            {
                return HttpNotFound();
            }
            return View(dinnerModel);
        }

        // GET: DinnerModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DinnerModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "DinnerName,StartTime,PrepTime,NumOfRounds,Parallel")] DinnerModel dinnerModel)
        {
            //TODO: Manage Id
            if (ModelState.IsValid)
            {
                db.Dinners.Add(dinnerModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(dinnerModel);
        }

        // GET: DinnerModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DinnerModel dinnerModel = await db.Dinners.FindAsync(id);
            if (dinnerModel == null)
            {
                return HttpNotFound();
            }
            return View(dinnerModel);
        }

        // POST: DinnerModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "DinnerName,StartTime,PrepTime,NumOfRounds,Parallel")] DinnerModel dinnerModel)
        {
            //TODO: manage Id
            if (ModelState.IsValid)
            {
                db.Entry(dinnerModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(dinnerModel);
        }

        // GET: DinnerModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DinnerModel dinnerModel = await db.Dinners.FindAsync(id);
            if (dinnerModel == null)
            {
                return HttpNotFound();
            }
            return View(dinnerModel);
        }

        // POST: DinnerModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            DinnerModel dinnerModel = await db.Dinners.FindAsync(id);
            db.Dinners.Remove(dinnerModel);
            await db.SaveChangesAsync();
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

    //TODO: Make Seed with Duos and Dinners
    //TODO: Make Duo for user when signing up
    //TODO: Make Duo editable for user
    //TODO: Make Duo able to sign up for a Dinner
    //TODO: Make Admin able to close signups for a dinner
    //TODO: Make Admin able to generate rounds for a dinner
    //TODO: Make Admin able to generate PDFs for participants
    //TODO: Make Admin able to generate
}
