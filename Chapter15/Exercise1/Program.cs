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
            var max = Library.Books.Max(b => b.Price);
            var selected = Library.Books
                .Where(b => b.Price == max);
            
            foreach(var book in selected) {
                Console.WriteLine($"発行年:{book.PublishedYear} カテゴリ:{book.CategoryId} 価格:{book.Price} タイトル:{book.Title} ");
            }
        }

        private static void Exercise1_3() {
            var query = Library.Books.GroupBy(b => b.PublishedYear);

            foreach(var item in query.OrderBy(b => b.Key)) {
                Console.WriteLine("{0}年　{1}冊", item.Key, item.Count());
            }
        }

        private static void Exercise1_4() {
            var selected = Library.Books
                .Join(Library.Categories,           
                        book => book.CategoryId,    
                        category => category.Id,   
                        (book, category) => new {
                            book.Title,
                            book.PublishedYear,
                            book.Price,
                            CategoryName = category.Name
                        })
                .OrderByDescending(b => b.PublishedYear)
                .ThenByDescending(b => b.Price);
            foreach(var book in selected) {
                Console.WriteLine($"{book.PublishedYear} {book.Price} {book.Title} ({book.CategoryName}) ");
                
            }
        }

        private static void Exercise1_5() {

        }

        private static void Exercise1_6() {
        }

        private static void Exercise1_7() {
        }

        private static void Exercise1_8() {
        }
    }
}
