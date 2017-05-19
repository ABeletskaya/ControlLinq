using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace control2
{
    class Program
    {
        /*1.Выберите все книги, в названии которых есть слово LINQ и год издания високосный. 

2.Дан массив книг books. Сколько книг написал каждый автор (получить последовательность пар: автор – число книг)?

3. Дан массив целых двузначных чисел.
Упорядочить их по возрастанию старшего разряда, а затем по убыванию младшего, например, { 14, 12, 23, 20, 33, 32 }. 

4. Задан список. Оставить в нем только уникальные элементы. 
Для этого объявить статический метод void Unique<T>(T list),
который получает обобщенный список и убирает из него все вхождения элемента, кроме первого. */


        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
            { new Book { Name = "Liq", Year = 2000, AuthorID =1 },
             new Book { Name = "Linq", Year = 2004, AuthorID =1 },
              new Book { Name = "Linq", Year = 2001, AuthorID =2 },
               new Book { Name = "Liq", Year = 2010, AuthorID = 3 },

            };

            List<Author> autors = new List<Author>
            {
                new Author {Name = "Serj", AuthorID = 1 },
                new Author {Name = "Belka", AuthorID = 2 },
                new Author {Name = "Bob", AuthorID = 3 }

            };


            Console.WriteLine("1:");
            var query = books.Where(x => x.Name.ToLower().Contains("LINQ".ToLower()) && (x.Year % 4 == 0 && x.Year % 100 != 0));
            Console.WriteLine(string.Join("\n", query));

            Console.WriteLine("\n2:");
            var query2 = books.GroupBy(Book => Book.Name, (author, book) =>
           new {
               Key = author,
               Count = book.Count(),
               });

            foreach (var item in query2)
            {
                Console.WriteLine($"{item.Key} - {item.Count}");
            }
            
           
            Console.WriteLine("\n3:");
            //int[] mass = new int[] { 32, 33, 10, 19, 28, 65 };
            // int[] mass = new int[] { 22, 23, 28, 81, 80, 88 };
            int[] mass = new int[] { 33, 14, 20, 32, 23, 12 };
            int[] mass2 = new int[] { 33, 14, 20, 32, 23, 12, 33, 33, 12, 14, 20, 20, 20 };
            var query3 = mass.OrderByDescending(x => x % 10).OrderBy(x => x / 10);
            Console.WriteLine(string.Join(", ", query3));

            Console.WriteLine("\n4:");
            Unique<int>(mass2);

        }


        static void Unique<T>( params T[] list)
        { 
            var queryUnic = list.Distinct();
            Console.WriteLine(string.Join(", ", queryUnic));
        }
    }
}
