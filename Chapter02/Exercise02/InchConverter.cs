using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    //インチとメートルの単位変換クラス
    public static class InchConverter {
        private const double retio = 0.0254; //定数retioを定義
        //public static readonly double retio = 0.3048; //←外部からもアクセスさせたい場合 

        //メートルからインチを求める(静的メソッド)
        public static double fromMeter(double meter) {
            return meter / retio;
        }

        //インチからメートルを求める(静的メソッド)
        public static double ToMeter(double inch) {
            return inch * retio;
        }
    }
}
