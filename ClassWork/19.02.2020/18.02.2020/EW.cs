using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._02._2020
{
    class EW
    {
        public void Init()
        {
            Specialization[] res;
            using (UniversityEntities ctx = new UniversityEntities())
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
                res = ctx.Specializations.AddRange(specializations).ToArray();

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
        public void AddStudent()
        {
            using (UniversityEntities ctx = new UniversityEntities())
            {

                Student newStudent = new Student();
                Console.WriteLine("Enter student name ->");
                newStudent.Name = Console.ReadLine();
                Console.WriteLine("Enter surname ->");
                newStudent.Surname = Console.ReadLine();
                if (ctx.Students.FirstOrDefault(s => s.Name == newStudent.Name && s.Surname == newStudent.Surname) == null)
                {
                    Console.WriteLine("Enter Adress ->");
                    newStudent.Address = Console.ReadLine();
                    Console.WriteLine("Enter phone ->");
                    newStudent.Phone = Console.ReadLine();
                    Console.WriteLine("Enter specialization id ->");
                    newStudent.Specialization_Id = int.Parse(Console.ReadLine());
                    ctx.Students.Add(newStudent);
                    ctx.SaveChanges();
                }
                else
                {
                    Console.WriteLine("This student is now exist!");
                    return;
                }
            }
        }

        public void Read()
        {
            using (UniversityEntities ctx = new UniversityEntities())
            {
                ctx.Configuration.LazyLoadingEnabled = false;
                ctx.Entry(ctx.Students.FirstOrDefault()).Reference("Specialization").Load();
                var res = ctx.Students.OrderBy(q => q.Name);

                foreach (var i in res)
                {
                    Console.WriteLine(i.Id + " |" + i.Name + " |" + i.Surname + " |" + i.Phone+" |" + i.Specialization_Id+" |<>|"+i.Specialization.Name);

                }
            }
        }
        public void ShowStudentById(int Id)
        {
             using (UniversityEntities ctx = new UniversityEntities())
             {
                ctx.Configuration.LazyLoadingEnabled = false;
                ctx.Entry(ctx.Students.FirstOrDefault()).Reference("Specialization").Load();
                var res = ctx.Students.OrderBy(q => q.Name);

                foreach (var i in res)
                {
                    Console.WriteLine(i.Id + " |" + i.Name + " |" + i.Surname + " |" + i.Phone+" |" + i.Specialization_Id+" |<>|"+i.Specialization.Name);

                }
            }
        }
        public void T1()
        {
            using (UniversityEntities ctx = new UniversityEntities())
            {
                var res = ctx.Subjects.Include("Specialization");

                foreach (var i in res)
                {
                    Console.WriteLine(i.Name+i.AmountOfHour+" | "+i.Specialization.Name);
                }
            }
        }
        public void T2()
        {
            using (UniversityEntities ctx = new UniversityEntities())
            {
                var subject = ctx.Subjects.OrderBy(q => q.Name).FirstOrDefault();
                Console.WriteLine(subject.Name+subject.AmountOfHour);
            }
        }
        public void T3(string specialization= "Mathematic")
        {
            using (UniversityEntities ctx = new UniversityEntities())
            {
                var subject = ctx.Students.Where(q => q.Specialization.Name == specialization);
                foreach (var i in subject)
                {
                    Console.WriteLine(i.Name+" | "+ i.Surname + " | " + i.Phone + " | " + i.Specialization.Name);
                }
            }
        }
        public void T4(string specialization = "Mathematic")
        {
            using (UniversityEntities ctx = new UniversityEntities())
            {
                var subject = ctx.Specializations.OrderBy(q => q.Students.Count).Take(3);
                foreach (var i in subject)
                {
                    Console.WriteLine(i.Name);
                }
            }
        }
        /*
            Показати всі предмети включно з назвами спеціалізацій.
            Показати предмет, який знаходиться перший в алфавіті по назві, включно з його спеціалізацією.
            Показати список студентів спеціалізації, яку введе користувач (по імені).
            Показати перші TOP-3 спеціалізації по кількості студентів, також вивести їхній список студентів.
            Показати предмет, який триває найбільшу кількість годин, включаючи його спеціалізацію та студентів, які на ній навчаються.
            Показати інформацію про студентів, які проживають на вказаній адресі, включно з їхнім списком предметів.
         */
        public void T5()
        {
            using (UniversityEntities ctx = new UniversityEntities())
            {
                var r = ctx.Subjects.OrderBy(q => q.AmountOfHour).FirstOrDefault();
                Console.WriteLine(r.Name+"|"+r.Specialization.Name+r.Specialization_Id);
                foreach (var i in r.Specialization.Students)
                {
                    Console.WriteLine(i.Name+i.Phone+i.Surname);
                }
            }
        }
        public void T6(string address= "qwe")
        {
            using (UniversityEntities ctx = new UniversityEntities())
            {
                var r2 = ctx.Students.Where(q => q.Address == address);
                foreach (var i in r2)
                {
                    Console.Write(i.Name+" | "+i.Phone + " | " + i.Surname + " | " + i.Address);
                    foreach (var j in i.Specialization.Subjects)
                    {
                        Console.Write(" ||  " + j.Name);
                    }
                    Console.WriteLine("\n");
                }
            }
        }
        
    }
}
   
