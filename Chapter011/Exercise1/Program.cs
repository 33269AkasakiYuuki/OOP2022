﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            var file = "sports.xml";
            Exercise1_1(file);
            Console.WriteLine();
            Exercise1_2(file);
            Console.WriteLine();
            Exercise1_3(file);
            Console.WriteLine();

            var newfile = "sports.xml";
            //Exercise1_4(file, newfile);

            // これは確認用
            var text = File.ReadAllText(newfile);
            Console.WriteLine(text);
        }

        private static void Exercise1_1(string file) {

            //匿名クラス　P284
            var xdoc = XDocument.Load(file);
            var samplets = xdoc.Root.Elements()
                .Select(x => new {
                    Name = (string)x.Element("name"),
                    Teammembers = (string)x.Element("teammembers"),
                });
            foreach (var sample in samplets) {
                Console.WriteLine("{0} {1}", sample.Name, sample.Teammembers);
            }
        }

        private static void Exercise1_2(string file) {

            //匿名クラス(最初にプレーされた年の若い順と合わせて競技名)
            var xdoc = XDocument.Load(file);
            var sports = xdoc.Root.Elements().Select(x => new {
                Firstplayed = x.Element("firstplayed").Value,
                Name = x.Element("name").Attribute("kanji").Value
            }).OrderBy(x=> int.Parse(x.Firstplayed));
            foreach (var sport in sports) {
                Console.WriteLine("{0}({1})", sport.Name, sport.Firstplayed);
            }
        }

        private static void Exercise1_3(string file) {
            var xdoc = XDocument.Load(file);
            var sport = xdoc.Root.Elements().Select(x => new {
                Name = x.Element("name").Value,
                Teammembers = x.Element("teammembers").Value
            }).OrderByDescending(x => int.Parse(x.Teammembers)).FirstOrDefault();

            Console.WriteLine("{0}({1}人)", sport.Name,sport.Teammembers);
        }

        private static void Exercise1_4(string file, string newfile) {
            var xdoc = XDocument.Load(file);
            var element = new XElement("ballsport",
                new XElement("name", "サッカー", new XAttribute("kanji", "蹴球")),
                new XElement("teammembers","11"),
                new XElement("firstplayed", "1863"));

            xdoc.Root.Add(element);

            xdoc.Save(newfile);
        }
    }
}
