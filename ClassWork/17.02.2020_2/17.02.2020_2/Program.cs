using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._02._2020_2
{
    class Program
    {
        static void Main(string[] args)
        {
            LIBRARYEntities ctx = new LIBRARYEntities();

            //T1(ctx);

            //T2(ctx);

            //T3(ctx);


            ctx.SaveChanges();
            ctx.Dispose();
        }
        static void T1(LIBRARYEntities ctx)
        {
            var r = ctx.Books.Where(q => q.Pages_count > 100);
            foreach (var i in r)
            {
                Console.WriteLine(i.Id + "|" + i.Language_id + "|" + i.Pages_count + "|" + i.Book_Name + "|" + i.Author_Id);
            }
        }
        static void T2(LIBRARYEntities ctx)
        {
            var r = ctx.Books.Where(q=> q.Book_Name.StartsWith("A")|| q.Book_Name.StartsWith("a"));

            foreach (var i in r)
            {
                Console.WriteLine(i.Id + "|" + i.Language_id + "|" + i.Pages_count + "|" + i.Book_Name + "|" + i.Author_Id);
            }
        }
        static void T3(LIBRARYEntities ctx)
        {
            var r = ctx.Books.Where(q => q.Book_Name.Length<10);

            foreach (var i in r)
            {
                Console.WriteLine(i.Id + "|" + i.Language_id + "|" + i.Pages_count + "|" + i.Book_Name + "|" + i.Author_Id);
            }
        }

        static void T4(LIBRARYEntities ctx)
        {
            var r = from book in ctx.Books join author in ctx.Authors on  book.Author_Id equals author.Id

            foreach (var i in r)
            {
                Console.WriteLine(i.Id + "|" + i.Language_id + "|" + i.Pages_count + "|" + i.Book_Name + "|" + i.Author_Id);
            }
        }

        static void T5(LIBRARYEntities ctx)
        {
            //var r = ctx.Books.Where(q => q.Language_id);

            //foreach (var i in r)
            //{
            //    Console.WriteLine(i.Id + "|" + i.Language_id + "|" + i.Pages_count + "|" + i.Book_Name + "|" + i.Author_Id);
            //}
        }
    }

    /*
     Вибрати всі книги, кількість сторінок в яких більше 100
    Вибрати всі книги, ім‘я яких починається на літеру ‘А’ або ‘а’
    Вибрати всі книги, ім’я в яких складається менше ніж з 10-ти символів
    Вибрати всі книги автора William Shakespeare
    Вибрати всі книги українських авторів 
    Вибрати книгу з максимальною кількістю сторінок не американського автора
    Вибрати автора, який має найменше книг в базі даних
    Вибрати імена всіх авторів, крім американських, розташованих в алфавітному порядку
    Вибрати країну, авторів якої є найбільше в базі
     */
}
