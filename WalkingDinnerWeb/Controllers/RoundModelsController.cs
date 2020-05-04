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
    public class RoundModelsController : Controller
    {
        private WalkingDinnerContext db = new WalkingDinnerContext();

        // GET: RoundModels
        public async Task<ActionResult> Index()
        {
            return View(await db.Rounds.ToListAsync());
        }

        // GET: RoundModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RoundModel roundModel = await db.Rounds.FindAsync(id);
            if (roundModel == null)
            {
                return HttpNotFound();
            }
            return View(roundModel);
        }

        //TODO: Make Create for RoundModel a backend-only thing

        // GET: RoundModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoundModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "RoundName,RoundNumber,StartTime,EndTime")] RoundModel roundModel)
        {
            //TODO: Manage Id
            if (ModelState.IsValid)
            {
                db.Rounds.Add(roundModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(roundModel);
        }

        // GET: RoundModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RoundModel roundModel = await db.Rounds.FindAsync(id);
            if (roundModel == null)
            {
                return HttpNotFound();
            }
            return View(roundModel);
        }

        // POST: RoundModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "RoundName,RoundNumber,StartTime,EndTime")] RoundModel roundModel)
        {
            //TODO: Manage Id
            if (ModelState.IsValid)
            {
                db.Entry(roundModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(roundModel);
        }

        // GET: RoundModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RoundModel roundModel = await db.Rounds.FindAsync(id);
            if (roundModel == null)
            {
                return HttpNotFound();
            }
            return View(roundModel);
        }

        // POST: RoundModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            RoundModel roundModel = await db.Rounds.FindAsync(id);
            db.Rounds.Remove(roundModel);
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
}
