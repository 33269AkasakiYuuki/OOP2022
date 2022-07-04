using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            var file = "sample.xml";
            Exercise1_1(file);
            Console.WriteLine();
            Exercise1_2(file);
            Console.WriteLine();
            Exercise1_3(file);
            Console.WriteLine();

            var newfile = "sports.xml";
            Exercise1_4(file, newfile);
        }

        private static void Exercise1_1(string file) {

            //匿名クラス　P284
            var xdoc = XDocument.Load("Sample.xml");
            var samplets = xdoc.Root.Elements()
                .Select(x => new {
                    Name = (string)x.Element("name"),
                    Teammembers = (string)x.Element("teammembers"),
                });
            foreach (var sample in samplets) {
                Console.WriteLine("{0} {1}",sample.Name,sample.Teammembers);
            }
        }

        private static void Exercise1_2(string file) {

            //匿名クラス(最初にプレーされた年の若い順と合わせて競技名)
            var xdoc = XDocument.Load("Sample.xml");
            
            foreach (var sample in xdoc.Root.Elements()) {
                var xname = sample.Element("name");
                XAttribute xkanji = xname.Attribute("xkanji");
                Console.WriteLine("{0}", xname.Value);
            }
        }

        private static void Exercise1_3(string file) {
        }

        private static void Exercise1_4(string file, string newfile) {
        }
    }
}
