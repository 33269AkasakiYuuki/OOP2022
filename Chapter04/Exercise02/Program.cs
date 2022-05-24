using Exercise01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            /*var ym = new YearMonth(1995, 12);

            var check = ym.Is21Century;
            var test = ym.Add0neMonth();

            Console.WriteLine(ym);*/

            //4.2.1
            var ymCollection = new YearMonth[] {
                new YearMonth(1999,1),
                new YearMonth(2002,9),
                new YearMonth(2004,9),
                new YearMonth(1998,4),
                new YearMonth(2011,3),  //最後のカンマは付けておく(P103)
             };

            //4.2.2
            Exercise02_2(ymCollection);
                Console.WriteLine("--------");


            //4.2.4
            Exercise02_4(ymCollection);
                Console.WriteLine("--------");
            

            //4.2.5
            Exercise02_5(ymCollection);
                Console.WriteLine("--------");

            //おまけ
            Exercise02_6(ymCollection);
        }

       
        //4.2.3
        //最初に見つかった21世紀のオブジェクトを返す
        //見つからない場合はnullを返す
        static YearMonth FindFirst21C(YearMonth[] yms) {
            foreach (var ym in yms) {
                if (ym.Is21Century) {
                    return ym;
                }
            }
            return null;
        }

        private static void Exercise02_2(YearMonth[] ymCollection) {
            foreach (var ym in ymCollection) {
                Console.WriteLine(ym);
            }
        }

        private static void Exercise02_4(YearMonth[] ymCollection) {
            var yearmonth = FindFirst21C(ymCollection);

            if (yearmonth != null) {
                Console.WriteLine(yearmonth);
            }
            else {
                Console.WriteLine("21世紀のデータはありません");
            }
        }

        private static void Exercise02_5(YearMonth[] ymCollection) {
            var array = ymCollection.Select(ym => ym.Add0neMonth()).ToArray();
            foreach (var ym in array) {
                Console.WriteLine(ym);
            }
        }

        private static void Exercise02_6(YearMonth[] ymCollection) {
            foreach (var ym in ymCollection.OrderByDescending(ym => ym.Year)) {
                Console.WriteLine(ym);
            }
        }
    }
}
