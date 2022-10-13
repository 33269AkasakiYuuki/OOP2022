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
            var query = Library.Books
                .Where(b => b.PublishedYear == 2016)
                .Join(Library.Categories, book => book.CategoryId,
                category => category.Id,
                (book, category) => category.Name).Distinct();
            foreach(var name in query) {
                Console.WriteLine(name);
            }
        }

        private static void Exercise1_6() {
            var groups = Library.Books
                .Join(Library.Categories,
                        book => book.CategoryId,
                        category => category.Id,
                        (book, category)=> new {
                            book.Title,
                            book.PublishedYear,
                            book.Price,
                            CategoryName = category.Name
                       })      
                        .GroupBy(x => x.CategoryName)
                        .OrderBy(x => x.Key);

            foreach(var group in groups) {
                Console.WriteLine("#{0}",group.Key);
                foreach(var item in group) {
                    Console.WriteLine(" "+item.Title);
                }
            }
        }

        private static void Exercise1_7() {
            var categoryId = Library.Categories.Single(c => c.Name == "Development").Id;
            var groups = Library.Books
                                .Where(b => b.CategoryId == categoryId)
                                .GroupBy(b => b.PublishedYear)
                                .OrderBy(b => b.Key);
            foreach(var group in groups) {
                Console.WriteLine("#{0}", group.Key);
                foreach(var book in group) {
                    Console.WriteLine("{0}", book.Title);
                }
            }
        }

        private static void Exercise1_8() {
            var query = Library.Categories
                               .GroupJoin(Library.Books,
                                           c => c.Id,
                                           b => b.CategoryId,
                                          (c, b) => new {
                                              CategoryName = c.Name,
                                              count = b.Count()
                                          })
                               .Where(x => x.count >= 4);
            foreach(var category in query) {
                Console.WriteLine(category.CategoryName);
            }
        }
    }
}
