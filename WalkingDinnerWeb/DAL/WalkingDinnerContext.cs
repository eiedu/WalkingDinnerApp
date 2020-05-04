using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using WalkingDinnerWeb.Models;

namespace WalkingDinnerWeb.DAL
{
    public class WalkingDinnerContext : DbContext
    {
        public WalkingDinnerContext() :base("DefaultConnection")
        {
            //Database.SetInitializer(new DropCreateDatabaseAlways<WalkingDinnerContext>());
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<WalkingDinnerContext>());
        }
        public DbSet<DuoModel> Duos { get; set; }
        public DbSet<DinnerModel> Dinners { get; set; }
        public DbSet<RoundModel> Rounds { get; set; }

    }
}