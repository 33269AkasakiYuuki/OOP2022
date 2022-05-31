﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";

            Exercise3_1(text);
            Console.WriteLine("-----");

            Exercise3_2(text);
            Console.WriteLine("-----");

            Exercise3_3(text);
            Console.WriteLine("-----");

            Exercise3_4(text);
            Console.WriteLine("-----");

            Exercise3_5(text);
        }

        private static void Exercise3_1(string text) {
            int spaces = text.Count(c => c ==' ');
            Console.WriteLine("空白数:{0}", spaces);
        }

        private static void Exercise3_2(string text) {
            var replaced = text.Replace("big", "small");
            Console.WriteLine(replaced);
        }

        private static void Exercise3_3(string text) {
            int count = text.Split(' ').Length;
            Console.WriteLine("単語:{0}",count);
        }

        private static void Exercise3_4(string text) {
            text.Split(' ').Where(word => word.Length <= 4).
                ToList().ForEach(word => Console.WriteLine(word));
        }

        private static void Exercise3_5(string text) {
            /* var s = text.Split(' ');
             var sd = new StringBuilder();
             foreach (var word in s) {
                 sd.Append(word);
             }
             var ss = sd.ToString();
             Console.WriteLine(ss);*/

            var array = text.Split(' ').ToArray();
            if (array.Length>0) {
                var sd = new StringBuilder(array[0]);
                
                foreach (var word in array.Skip(1)) {
                    sd.Append(' ');
                    sd.Append(word);
                }

                var str = sd.ToString();
                Console.WriteLine(str);
            }
        
        }
    }
}