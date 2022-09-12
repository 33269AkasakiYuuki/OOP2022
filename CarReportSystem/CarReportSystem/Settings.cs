using CarReportSystem.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem {
    //設定情報
   public class Settings {

        private static Settings settings;

        //コンストラクタ
        public Settings() { }

        public static Settings getInstancne() {
            if (settings == null) {
                settings = new Settings();
            }
            return settings;
        }

        public int MainFormColor { get; set; }
    }
    
}
