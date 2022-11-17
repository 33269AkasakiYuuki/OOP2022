using Newtonsoft.Json;
using System;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace WeatherApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btWeatherGet_Click(object sender, EventArgs e) {
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };

            var dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_week/130000.json");

            var json = JsonConvert.DeserializeObject<Rootobject>(dString);

            //tbWeatherInfo.Text = json.text;

            //string textValue = tbarea.Text;

            //tbWeatherInfo.Text = textValue;

            Console.WriteLine("発表者");
            Console.WriteLine("　" + json.publishingOffice);
            Console.WriteLine("報告日時");
            Console.WriteLine("　" + json.reportDatetime);
            Console.WriteLine("対象地域");
            Console.WriteLine("　" + json.targetArea);
            Console.WriteLine("ヘッドライン");
            Console.WriteLine("　" + json.headlineText);
            Console.WriteLine("詳細");
            Console.WriteLine("　" + json.text);

            Console.WriteLine("概況");
            Console.WriteLine(Environment.NewLine[0]);
            Console.WriteLine("今日の天気");
            Console.WriteLine(Environment.NewLine[1]);
            /*Console.WriteLine("明日の天気");
            Console.WriteLine(Environment.NewLine[2]);
            Console.WriteLine("明後日の天気");
            Console.WriteLine(Environment.NewLine[3]);*/

            
            tbWeatherInfo.Text = json.text;
        }
    }
}
