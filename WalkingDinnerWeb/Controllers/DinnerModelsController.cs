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
        public async Task<ActionResult> Create([Bind(Include = "Id,DinnerName,StartTime,PrepTime,NumOfRounds,Parallel")] DinnerModel dinnerModel)
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
        public async Task<ActionResult> Edit([Bind(Include = "Id,DinnerName,StartTime,PrepTime,NumOfRounds,Parallel")] DinnerModel dinnerModel)
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


        // GET: DinnerModels/MakeRounds/5
        [HttpGet]
        public async Task<ActionResult> MakeRounds(int? id)
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

            //make rounds here
            var participants = dinnerModel.Participants.ToList();
            switch (dinnerModel.NumOfRounds)
            {
                case 2:
                    /* Masks for 2x2+
                     * +0, +1
                     */
                    //TODO: Make exceptions for indivisible amounts of participants
                    int width = participants.Count / 2;
                    DuoModel[,] participantGrid = new DuoModel[2, width];
                    for (int i = 0; i < participants.Count; i++)
                    {
                        if (i % 2 == 0)
                        {
                            participantGrid[0, i / 2] = participants[i];
                        }
                        else
                        {
                            participantGrid[1, i / 2] = participants[i];
                        }
                    }

                    for (int i = 0; i < dinnerModel.NumOfRounds; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            var round = new RoundModel { RoundNumber = i + 1, RoundName = "a", DinnerId = dinnerModel, StartTime = DateTime.Now, EndTime = DateTime.Now };
                            if (i == 0)
                            {
                                //first round so +0
                                round.HostId = participantGrid[0, j];
                                round.Participants.Add(participantGrid[0, j]);
                                round.Dietary.Add(participantGrid[0, j].Dietary);
                                round.Participants.Add(participantGrid[1, j]);
                                round.Dietary.Add(participantGrid[1, j].Dietary);
                            }
                            else if (i == 1)
                            {
                                //second round so +1
                                if(j < width-1)
                                {
                                    round.Participants.Add(participantGrid[0, j]);
                                    round.Dietary.Add(participantGrid[0, j].Dietary);
                                    round.HostId = participantGrid[1, j+1];
                                    round.Participants.Add(participantGrid[1, j+1]);
                                    round.Dietary.Add(participantGrid[1, j+1].Dietary);
                                }
                                else
                                {
                                    round.Participants.Add(participantGrid[0, j]);
                                    round.Dietary.Add(participantGrid[0, j].Dietary);
                                    round.HostId = participantGrid[1, 0];
                                    round.Participants.Add(participantGrid[1, 0]);
                                    round.Dietary.Add(participantGrid[1, 0].Dietary);
                                }
                            }
                            db.Rounds.Add(round);
                        }
                    }

                    break;
                case 3:
                    /* Masks for 3x3+
                     * +0, +1, +n-1 -> for n-1 times -1
                     */
                    throw new NotImplementedException();
                    break;
                case 4:
                    /* Masks for 4x4 +
                     * +0, +1, +2 + 1 - 2, +3 - 2 + 1
                     * +0, +2 - 1 + 2, +1 + 2 - 1, +n - 1-> for n - 1 times - 1
                     */
                    throw new NotImplementedException();
                    break;
                default:
                    throw new NotImplementedException();
                    break;
            }
            dinnerModel.roundsMade = true;

            db.SaveChanges();

            return RedirectToAction("Index", "RoundModels", null);
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
