using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._02._2020
{
    class MyUniverseInit : IDatabaseInitializer<UniversityEntities>
    {
        public void InitializeDatabase(UniversityEntities ctx)
        {
            List<Specialization> specializations = new List<Specialization>
                {
                    new Specialization
                    {
                       Name = "Mathematic"
                    },
                    new Specialization
                    {
                        Name = "Speaker"
                    },
                    new Specialization
                    {
                        Name = "Mibip"
                    },
                    new Specialization
                    {
                        Name = "Programing"
                    }
                };
            var res = ctx.Specializations.AddRange(specializations).ToArray();
            res[0].Subjects.Add(new Subject() { AmountOfHour = 120, Name = "Predmet1" });
            res[0].Subjects.Add(new Subject() { AmountOfHour = 100, Name = "Predmet2" });
            res[2].Subjects.Add(new Subject() { AmountOfHour = 50, Name = "Predmet3" });
            res[3].Subjects.Add(new Subject() { AmountOfHour = 80, Name = "Predmet4" });
            res[0].Subjects.Add(new Subject() { AmountOfHour = 90, Name = "Predmet5" });
            res[1].Subjects.Add(new Subject() { AmountOfHour = 110, Name = "Predmet6" });
            res[1].Subjects.Add(new Subject() { AmountOfHour = 100, Name = "Predmet7" });
            res[0].Subjects.Add(new Subject() { AmountOfHour = 120, Name = "Predmet8" });
            res[2].Subjects.Add(new Subject() { AmountOfHour = 120, Name = "Predmet9" });
            res[3].Subjects.Add(new Subject() { AmountOfHour = 120, Name = "Predmet10" });
            res[3].Subjects.Add(new Subject() { AmountOfHour = 120, Name = "Predmet11" });
            ctx.SaveChanges();
        }
    }
    class UniverseInit : DropCreateDatabaseIfModelChanges<UniversityEntities>
    {
        protected override void Seed(UniversityEntities ctx)
        {
            List<Specialization> specializations = new List<Specialization>
                {
                    new Specialization
                    {
                       Name = "Mathematic"
                    },
                    new Specialization
                    {
                        Name = "Speaker"
                    },
                    new Specialization
                    {
                        Name = "Mibip"
                    },
                    new Specialization
                    {
                        Name = "Programing"
                    }
                };
            var res = ctx.Specializations.AddRange(specializations).ToArray();
            res[0].Subjects.Add(new Subject() { AmountOfHour = 120, Name = "Predmet1" });
            res[0].Subjects.Add(new Subject() { AmountOfHour = 100, Name = "Predmet2" });
            res[2].Subjects.Add(new Subject() { AmountOfHour = 50, Name = "Predmet3" });
            res[3].Subjects.Add(new Subject() { AmountOfHour = 80, Name = "Predmet4" });
            res[0].Subjects.Add(new Subject() { AmountOfHour = 90, Name = "Predmet5" });
            res[1].Subjects.Add(new Subject() { AmountOfHour = 110, Name = "Predmet6" });
            res[1].Subjects.Add(new Subject() { AmountOfHour = 100, Name = "Predmet7" });
            res[0].Subjects.Add(new Subject() { AmountOfHour = 120, Name = "Predmet8" });
            res[2].Subjects.Add(new Subject() { AmountOfHour = 120, Name = "Predmet9" });
            res[3].Subjects.Add(new Subject() { AmountOfHour = 120, Name = "Predmet10" });
            res[3].Subjects.Add(new Subject() { AmountOfHour = 120, Name = "Predmet11" });
            ctx.SaveChanges();
        }
    }
}
