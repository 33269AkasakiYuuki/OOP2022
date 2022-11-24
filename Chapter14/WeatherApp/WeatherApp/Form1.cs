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

        private void button1_Click(object sender, EventArgs e) {

            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };

            string dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/130000.json");

            var json = JsonConvert.DeserializeObject<Rootobject>(dString);

            //発表者
            tbWeatherInfo1.Text = "　" + json.publishingOffice;
            //報告日時
            tbWeatherInfo2.Text = "　" + json.reportDatetime;
            //対象地域
            tbWeatherInfo3.Text = "　" + json.targetArea;
            //ヘッドライン
            tbWeatherInfo4.Text = "　" + json.headlineText;
            //詳細
            tbWeatherInfo5.Text = "　" + json.text;

            Console.WriteLine("概況");
            Console.WriteLine(Environment.NewLine[0]);
            Console.WriteLine("今日の天気");
            Console.WriteLine(Environment.NewLine[0]);
            Console.WriteLine("明日の天気");
            Console.WriteLine(Environment.NewLine[0]);
            Console.WriteLine("明後日の天気");
            Console.WriteLine(Environment.NewLine[1]);
        }
    }
}
