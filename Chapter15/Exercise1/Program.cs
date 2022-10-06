using Chapter15;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var max = Library.Books
                             .Max(x => x.Title.Length);
            var book = Library.Books
                              .First(b => b.Title.Length == max);
            Console.WriteLine(book);
          
        }

        private static void Exercise1_3() {
            var book = Library.Books
                              .GroupBy(b => b.PublishedYear);
                           
            foreach(var books in book.OrderBy(b => b.Key)) {
                Console.WriteLine("{0}年{1}冊",books.Key,books.Count());
            }
        }

        private static void Exercise1_4() {
            var books = Library.Books
                              .OrderByDescending(b => b.PublishedYear)
                              .ThenByDescending(b => b.Price)
                              .Join(Library.Categories,
                                book => book.CategoryId,
                                category => category.Id,
                                (book, category) => new {
                                    Title = book.Title,
                                    Category = category.Name,
                                    PublishedYear = book.PublishedYear,
                                    Price = book.Price
                                });
            foreach(var book in books) {
                Console.WriteLine($"{book.PublishedYear}年,{book.Title},{book.Price},({book.Category})");
            }
        }

        private static void Exercise1_5() {
            var books = Library.Books
                              .Where(b => b.PublishedYear == 2016)
                              .Join(Library.Categories,
                                book => book.CategoryId,
                                category => category.Id,
                                (book, category) => category.Name)
                              .Distinct();
            foreach (var book in books) {
                Console.WriteLine(book);
            }
        }

        private static void Exercise1_6() {
            //var group = Library.Books
            //                   .GroupBy(b => b.CategoryId)
            //                   .OrderBy(x => x.Key)
            //                   .Join(Library.Categories,
            //                    book => book.Key,
            //                    category => category.Id,
            //                    (book, category) => new {
            //                        Title = book.Title,

            //                    });
            //foreach (var books in group) {
            //    Console.WriteLine($"{books}");
            //    foreach (var b in group) {
            //        Console.WriteLine($"   {b.}");
            //    }
            //}
        }

        private static void Exercise1_7() {
          //  var book = Library.Books
                              
        }

        private static void Exercise1_8() {

        }
    }
}
