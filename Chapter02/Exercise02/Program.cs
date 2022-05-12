using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        //コマンドライン引数
        static void Main(string[] args) {
            if (args.Length >= 1 && args[0] == "-tom") {
                //インチからメートルへの対応表を出力
                PrintInchoMeterList(1, 10);
            }
            else if(args.Length >= 1 && args[0] == "-toi"){ 
                //メートルからインチへの対応表を出力
                PrintMeterToInchList(1, 10);
            }
        }

        //インチからメートルへの対応表を出力
        private static void PrintInchoMeterList(int start, int stop) {
            for (int Inch = 1; Inch <= 10; Inch++) {
                double meter = InchConverter.ToMeter(Inch);
                Console.WriteLine("{0} cm = {1:0.0000} m", Inch, meter);
            }
        }

        //メートルからインチへの対応表を出力
        private static void PrintMeterToInchList(int start, int stop) {
            for (int meter = 1; meter <= 10; meter++) {
                double Inch= InchConverter.fromMeter(meter);
                Console.WriteLine("{0} m = {1:0.0000}　inch", meter, Inch);
            }
        }
    }
}

