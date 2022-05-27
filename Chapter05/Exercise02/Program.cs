using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {

            var line = Console.ReadLine(); //数値　数字

            int num; //整数値を入れる変数を用意
            if (int.TryParse(line,out num)) {
                Console.WriteLine("{0:#,#}", num); //整数への変換成功
            }
            else {
                Console.WriteLine("数値文字列でありません"); //変数失敗
            }

        }
    }
}
