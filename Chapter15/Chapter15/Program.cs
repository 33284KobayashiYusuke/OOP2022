using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("出力したい西暦を入力(終了:-1)");
            var years = new List<int>();
            while (true) {
                if (years.Contains(-1)) {
                    break;
                }
                else {
                    years.Add(int.Parse(Console.ReadLine()));
                }
            }
            Console.Write("昇順:1 降順:2 :");
            var sort = int.Parse(Console.ReadLine());

            IEnumerable<Book> books;
            if(sort == 1) {
               books = Library.Books
                              .Where(b => years.Contains(b.PublishedYear))
                               .OrderBy(b => b.PublishedYear );
            }
            else {
                books = Library.Books
                               .Where(b => years.Contains(b.PublishedYear))
                                .OrderByDescending(b => b.PublishedYear);
            }
            foreach (var book in books) {
                Console.WriteLine(book);
            }
            Console.WriteLine();
            var groups = Library.Books;

        }


        //P375から
    }
}

