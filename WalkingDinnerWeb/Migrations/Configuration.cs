namespace WalkingDinnerWeb.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;
    using WalkingDinnerWeb.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WalkingDinnerWeb.DAL.WalkingDinnerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WalkingDinnerWeb.DAL.WalkingDinnerContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            var duoModels = new List<DuoModel>();
            #region DuoModels

            duoModels.Add(new DuoModel
            {
                City = "A",
                Dietary = "A",
                Email = "A@A.A",
                FirstNameOne = "A",
                FirstNameTwo = "A",
                HouseNumber = "A",
                IBan = "A",
                InsertionOne = "A",
                InsertionTwo = "A",
                LastNameOne = "A",
                LastNameTwo = "A",
                PhoneNumber = "0355423277",
                PostalCode = "1234 AB",
                StreetName = "A"
            }); 
            duoModels.Add(new DuoModel
            {
                City = "B",
                Dietary = "B",
                Email = "A@A.A",
                FirstNameOne = "B",
                FirstNameTwo = "B",
                HouseNumber = "B",
                IBan = "B",
                InsertionOne = "B",
                InsertionTwo = "B",
                LastNameOne = "B",
                LastNameTwo = "B",
                PhoneNumber = "0355423277",
                PostalCode = "1234 AB",
                StreetName = "B"
            }); 
            duoModels.Add(new DuoModel
            {
                City = "C",
                Dietary = "C",
                Email = "A@A.A",
                FirstNameOne = "C",
                FirstNameTwo = "C",
                HouseNumber = "C",
                IBan = "C",
                InsertionOne = "C",
                InsertionTwo = "C",
                LastNameOne = "C",
                LastNameTwo = "C",
                PhoneNumber = "0355423277",
                PostalCode = "1234 AB",
                StreetName = "C"
            });
            duoModels.Add(new DuoModel
            {
                City = "D",
                Dietary = "D",
                Email = "A@A.A",
                FirstNameOne = "D",
                FirstNameTwo = "D",
                HouseNumber = "D",
                IBan = "D",
                InsertionOne = "D",
                InsertionTwo = "D",
                LastNameOne = "D",
                LastNameTwo = "D",
                PhoneNumber = "0355423277",
                PostalCode = "1234 AB",
                StreetName = "D"
            });
            duoModels.Add(new DuoModel
            {
                City = "E",
                Dietary = "E",
                Email = "A@A.A",
                FirstNameOne = "E",
                FirstNameTwo = "E",
                HouseNumber = "E",
                IBan = "E",
                InsertionOne = "E",
                InsertionTwo = "E",
                LastNameOne = "E",
                LastNameTwo = "E",
                PhoneNumber = "0355423277",
                PostalCode = "1234 AB",
                StreetName = "E"
            });
            duoModels.Add(new DuoModel
            {
                City = "F",
                Dietary = "F",
                Email = "A@A.A",
                FirstNameOne = "F",
                FirstNameTwo = "F",
                HouseNumber = "F",
                IBan = "F",
                InsertionOne = "F",
                InsertionTwo = "F",
                LastNameOne = "F",
                LastNameTwo = "F",
                PhoneNumber = "0355423277",
                PostalCode = "1234 AB",
                StreetName = "F"
            });
            duoModels.Add(new DuoModel
            {
                City = "G",
                Dietary = "G",
                Email = "A@A.A",
                FirstNameOne = "G",
                FirstNameTwo = "G",
                HouseNumber = "G",
                IBan = "G",
                InsertionOne = "G",
                InsertionTwo = "G",
                LastNameOne = "G",
                LastNameTwo = "G",
                PhoneNumber = "0355423277",
                PostalCode = "1234 AB",
                StreetName = "G"
            });
            duoModels.Add(new DuoModel
            {
                City = "H",
                Dietary = "H",
                Email = "A@A.A",
                FirstNameOne = "H",
                FirstNameTwo = "H",
                HouseNumber = "H",
                IBan = "H",
                InsertionOne = "H",
                InsertionTwo = "H",
                LastNameOne = "H",
                LastNameTwo = "H",
                PhoneNumber = "0355423277",
                PostalCode = "1234 AB",
                StreetName = "H"
            });
            duoModels.Add(new DuoModel
            {
                City = "I",
                Dietary = "I",
                Email = "A@A.A",
                FirstNameOne = "I",
                FirstNameTwo = "I",
                HouseNumber = "I",
                IBan = "I",
                InsertionOne = "I",
                InsertionTwo = "I",
                LastNameOne = "I",
                LastNameTwo = "I",
                PhoneNumber = "0355423277",
                PostalCode = "1234 AB",
                StreetName = "I"
            });
            duoModels.Add(new DuoModel
            {
                City = "J",
                Dietary = "J",
                Email = "A@A.A",
                FirstNameOne = "J",
                FirstNameTwo = "J",
                HouseNumber = "J",
                IBan = "J",
                InsertionOne = "J",
                InsertionTwo = "J",
                LastNameOne = "J",
                LastNameTwo = "J",
                PhoneNumber = "0355423277",
                PostalCode = "1234 AB",
                StreetName = "J"
            });
            duoModels.Add(new DuoModel
            {
                City = "K",
                Dietary = "K",
                Email = "A@A.A",
                FirstNameOne = "K",
                FirstNameTwo = "K",
                HouseNumber = "K",
                IBan = "K",
                InsertionOne = "K",
                InsertionTwo = "K",
                LastNameOne = "K",
                LastNameTwo = "K",
                PhoneNumber = "0355423277",
                PostalCode = "1234 AB",
                StreetName = "K"
            });
            duoModels.Add(new DuoModel
            {
                City = "L",
                Dietary = "L",
                Email = "A@A.A",
                FirstNameOne = "L",
                FirstNameTwo = "L",
                HouseNumber = "L",
                IBan = "L",
                InsertionOne = "L",
                InsertionTwo = "L",
                LastNameOne = "L",
                LastNameTwo = "L",
                PhoneNumber = "0355423277",
                PostalCode = "1234 AB",
                StreetName = "L"
            });
            duoModels.Add(new DuoModel
            {
                City = "M",
                Dietary = "M",
                Email = "A@A.A",
                FirstNameOne = "M",
                FirstNameTwo = "M",
                HouseNumber = "M",
                IBan = "M",
                InsertionOne = "M",
                InsertionTwo = "M",
                LastNameOne = "M",
                LastNameTwo = "M",
                PhoneNumber = "0355423277",
                PostalCode = "1234 AB",
                StreetName = "M"
            });
            duoModels.Add(new DuoModel
            {
                City = "N",
                Dietary = "N",
                Email = "A@A.A",
                FirstNameOne = "N",
                FirstNameTwo = "N",
                HouseNumber = "N",
                IBan = "N",
                InsertionOne = "N",
                InsertionTwo = "N",
                LastNameOne = "N",
                LastNameTwo = "N",
                PhoneNumber = "0355423277",
                PostalCode = "1234 AB",
                StreetName = "N"
            });
            duoModels.Add(new DuoModel
            {
                City = "O",
                Dietary = "O",
                Email = "A@A.A",
                FirstNameOne = "O",
                FirstNameTwo = "O",
                HouseNumber = "O",
                IBan = "O",
                InsertionOne = "O",
                InsertionTwo = "O",
                LastNameOne = "O",
                LastNameTwo = "O",
                PhoneNumber = "0355423277",
                PostalCode = "1234 AB",
                StreetName = "O"
            });
            duoModels.Add(new DuoModel
            {
                City = "P",
                Dietary = "P",
                Email = "A@A.A",
                FirstNameOne = "P",
                FirstNameTwo = "P",
                HouseNumber = "P",
                IBan = "P",
                InsertionOne = "P",
                InsertionTwo = "P",
                LastNameOne = "P",
                LastNameTwo = "P",
                PhoneNumber = "0355423277",
                PostalCode = "1234 AB",
                StreetName = "P"
            });
            duoModels.Add(new DuoModel
            {
                City = "Q",
                Dietary = "Q",
                Email = "A@A.A",
                FirstNameOne = "Q",
                FirstNameTwo = "Q",
                HouseNumber = "Q",
                IBan = "Q",
                InsertionOne = "Q",
                InsertionTwo = "Q",
                LastNameOne = "Q",
                LastNameTwo = "Q",
                PhoneNumber = "0355423277",
                PostalCode = "1234 AB",
                StreetName = "Q"
            });
            duoModels.Add(new DuoModel
            {
                City = "R",
                Dietary = "R",
                Email = "A@A.A",
                FirstNameOne = "R",
                FirstNameTwo = "R",
                HouseNumber = "R",
                IBan = "R",
                InsertionOne = "R",
                InsertionTwo = "R",
                LastNameOne = "R",
                LastNameTwo = "R",
                PhoneNumber = "0355423277",
                PostalCode = "1234 AB",
                StreetName = "R"
            });
            duoModels.Add(new DuoModel
            {
                City = "S",
                Dietary = "S",
                Email = "A@A.A",
                FirstNameOne = "S",
                FirstNameTwo = "S",
                HouseNumber = "S",
                IBan = "S",
                InsertionOne = "S",
                InsertionTwo = "S",
                LastNameOne = "S",
                LastNameTwo = "S",
                PhoneNumber = "0355423277",
                PostalCode = "1234 AB",
                StreetName = "S"
            });
            duoModels.Add(new DuoModel
            {
                City = "T",
                Dietary = "T",
                Email = "A@A.A",
                FirstNameOne = "T",
                FirstNameTwo = "T",
                HouseNumber = "T",
                IBan = "T",
                InsertionOne = "T",
                InsertionTwo = "T",
                LastNameOne = "T",
                LastNameTwo = "T",
                PhoneNumber = "0355423277",
                PostalCode = "1234 AB",
                StreetName = "T"
            });
            duoModels.Add(new DuoModel
            {
                City = "U",
                Dietary = "U",
                Email = "A@A.A",
                FirstNameOne = "U",
                FirstNameTwo = "U",
                HouseNumber = "U",
                IBan = "U",
                InsertionOne = "U",
                InsertionTwo = "U",
                LastNameOne = "U",
                LastNameTwo = "U",
                PhoneNumber = "0355423277",
                PostalCode = "1234 AB",
                StreetName = "U"
            });
            duoModels.Add(new DuoModel
            {
                City = "V",
                Dietary = "V",
                Email = "A@A.A",
                FirstNameOne = "V",
                FirstNameTwo = "V",
                HouseNumber = "V",
                IBan = "V",
                InsertionOne = "V",
                InsertionTwo = "V",
                LastNameOne = "V",
                LastNameTwo = "V",
                PhoneNumber = "0355423277",
                PostalCode = "1234 AB",
                StreetName = "V"
            });
            duoModels.Add(new DuoModel
            {
                City = "W",
                Dietary = "W",
                Email = "A@A.A",
                FirstNameOne = "W",
                FirstNameTwo = "W",
                HouseNumber = "W",
                IBan = "W",
                InsertionOne = "W",
                InsertionTwo = "W",
                LastNameOne = "W",
                LastNameTwo = "W",
                PhoneNumber = "0355423277",
                PostalCode = "1234 AB",
                StreetName = "W"
            });
#endregion

            context.Duos.AddRange(duoModels);
            context.SaveChanges();

            var duos = context.Duos.ToList();
            
            var Dinners = new List<DinnerModel>();
            Dinners.Add(new DinnerModel
            {
                DinnerName = "Dinner A",
                NumOfRounds = 4,
                Parallel = 6,
                //Participants = duos,
                StartTime = DateTime.Now,
                PrepTime = DateTime.Now,
                Rounds = new List<RoundModel>()
            });
            Dinners.Add(new DinnerModel
            {
                DinnerName = "Dinner A",
                NumOfRounds = 3,
                Parallel = 8,
                //Participants = duos,
                StartTime = DateTime.Now,
                PrepTime = DateTime.Now,
                Rounds = new List<RoundModel>()
            });

            foreach (var dindin in Dinners)
            {
                context.Dinners.Add(dindin);
            }
            context.SaveChanges();

            Dinners = context.Dinners.ToList();
            using (StreamWriter sw = new StreamWriter(@"C:\Users\eiedu\source\repos\WalkingDinnerApp\WalkingDinnerWeb\Migrations\seedLog.txt"))
            {
                sw.WriteLine("I can swrite!");
                sw.Flush();
                foreach (var duo in duos)
                {
                    sw.WriteLine(duo.ToString());
                    sw.Flush();
                }
                foreach (var dinner in Dinners)
                {
                    sw.WriteLine(dinner.ToString());
                    sw.Flush();
                }
            }
            //TODO: make this an update operation
            foreach (var item in Dinners)
            {
                foreach (var duo in duos)
                {
                    item.Participants.Add(duo);
                }
            }

            context.Dinners.AddRange(Dinners);
            context.SaveChanges();
        }
    }
}
