using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            if (args.Length >= 1 && args[0] == "-tom") {
                //インチからメートルへの対応表を出力
                PrintFeetToMeterList(1, 10);
            }
            else {
                //メートルからインチへの対応表を出力
                PrintMeterToFeetList(1, 10);
            }
        }

        //インチからメートルへの対応表を出力
        private static void PrintFeetToMeterList(int start, int stop) {
            for (int feet = 1; feet <= 10; feet++) {
                double meter = FeetConverter.ToMeter(feet);
                Console.WriteLine("{0} cm = {1:0.0000} m", feet, meter);
            }
        }

        //メートルからインチへの対応表を出力
        private static void PrintMeterToFeetList(int start, int stop) {
            for (int meter = 1; meter <= 10; meter++) {
                double feet = FeetConverter.fromMeter(meter);
                Console.WriteLine("{0} m = {1:0.0000} cm", meter, feet);
            }
        }
    }
}

