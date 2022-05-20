using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        public delegate bool Judgement(int value); //デリゲートの宣言

        static void Main(string[] args) {

            /* var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4};
             int count = Count(numbers, delegate (int n) { return n % 2 == 0; });
             int count = Count(numbers, n => n.ToString().Contains('1')); //ラムダ式を使った処理
             Console.WriteLine("個数:" + count);
             */

            var list = new List<string> {
               "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };

            /* var exitsts = list.Exists(s => s[0] == 'A');
             Console.WriteLine(exitsts);
            var name = list.Find(s => s.Length == 6);
            Console.WriteLine(name);*/
           // var names = list.FindAll(s => s.Length <= 5);
            //names.ForEach(Console.WriteLine);

            var removedCount = list.RemoveAll(s => s.Contains("on"));
            list.ForEach(s =>Console.WriteLine(s));
            /*foreach(var s in names) {
                Console.WriteLine(s);
            }*/
        }

        /*
        public static int Count(int[] numbers, Predicate<int> judge) {
            int count = 0;
            foreach(var n in numbers) {
                if (judge(n) == true) {
                    count++;
                }
            }
            return count;
        }*/
    }
}
