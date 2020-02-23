using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._02._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            DataClasses1DataContext c = new DataClasses1DataContext();

            var res1 = c.Books.Where(q => q.Pages_count > 100);
            foreach (var i in res1)
            {
                Console.WriteLine(i.Book_Name+"|"+i.Pages_count);
            }
            Console.WriteLine("--------------------------------------------------------");
            var res2 = c.Books.Where(q=>q.Book_Name[0] =='A'|| q.Book_Name[0]=='a');
            foreach (var i in res2)
            {
                Console.WriteLine(i.Book_Name + "|" + i.Pages_count);
            }
            Console.WriteLine("--------------------------------------------------------");
            var res3 = c.Books.Where(q => q.Authors.Author_Name == "BORIS" /*William Shakespeare == BORIS*/);
            foreach (var i in res3)
            {
                Console.WriteLine(i.Book_Name + "|" + i.Pages_count);
            }
            Console.WriteLine("--------------------------------------------------------");
            var res4 = c.Books.Where(q => q.Languages.Countries.Country== "UKRAINE");
            foreach (var i in res4)
            {
                Console.WriteLine(i.Book_Name + "|" + i.Pages_count);
            }
            Console.WriteLine("--------------------------------------------------------");
            var res5 = c.Books.Where(q => q.Book_Name.Length<10);
            foreach (var i in res5)
            {
                Console.WriteLine(i.Book_Name + "|" + i.Pages_count);
            }
            Console.WriteLine("--------------------------------------------------------");
            var res6 = c.Books.Where(q => q.Pages_count==c.Books.Max(w=>w.Pages_count)&&q.Languages.Countries.Country!="USA");
            foreach (var i in res6)
            {
                Console.WriteLine(i.Book_Name + "|" + i.Pages_count);
            }
            Console.WriteLine("--------------------------------------------------------");
            var res7 = c.Authors.Where(q=>q.Books.Count==c.Books.GroupBy(w=>w.Author_Id).Min(e=>e.Key));
            foreach (var i in res7)
            {
                Console.WriteLine(i.Author_Name + "|" + i.Author_Surname);
            }
            Console.WriteLine("--------------------------------------------------------");
            var res8 = c.Books.Where(q => q.Languages.Countries.Country!="USA").Distinct().OrderBy(w=>w.Authors.Author_Name);
            foreach (var i in res8)
            {
                Console.WriteLine(i.Authors.Author_Name);
            }
            ////////////////Console.WriteLine("--------------------------------------------------------");
            ////////////////var res9 = c.Books.Where(w=>w.Author_Id==c.Books.Max(q=>q.Authors).Id).First();
            ////////////////    Console.WriteLine(res9.Languages.Countries.Country);

        }
    }
}
/*
 Використовуючи LINQ виконати деякі операції по відношенню до бази даних
Library, створену в рамках минулих занять:
1. Вибрати всі книги, кількість сторінок в яких більше 100
2. Вибрати всі книги, ім’я яких починається на літеру ‘А’ або ‘а’
3. Вибрати всі книги автора William Shakespeare
4. Вибрати всі книги українських авторів
5. Вибрати всі книги, ім’я в яких складається менше ніж з 10-ти символів
6. Вибрати книгу з максимальною кількістю сторінок не американського автора
7. Вибрати автора, який має найменше книг в базі даних
8. Вибрати імена всіх авторів, крім американських, розташованих в алфавітному
порядку
9. Вибрати країну, авторів якої є найбільше в базі
     */
