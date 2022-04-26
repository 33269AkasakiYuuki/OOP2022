using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    //フィートとメートルの単位変換クラス
    public static class FeetConverter {
        private const double retio = 0.3048; //定数retioを定義
        //public static readonly double retio = 0.3048; //←外部からもアクセスさせたい場合 

        //メートルからフィートを求める(静的メソッド)
        public static double fromMeter(double meter) {
            return meter / retio;
        }

        //フィートからメートルを求める(静的メソッド)
        public static double ToMeter(double feet) {
            return feet * retio;
        }
    }
}