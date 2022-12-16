using Newtonsoft.Json;
using System;
using System.IO;
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

            /*//概況
            Console.WriteLine(Environment.NewLine[0]);
            //今日の天気
            Console.WriteLine(Environment.NewLine[0]);
            //明日の天気
            Console.WriteLine(Environment.NewLine[0]);
            //明後日の天気
            Console.WriteLine(Environment.NewLine[1]);*/
        }

        private void Form1_Load(object sender, EventArgs e) {
            tbWeatherInfo3.Items.Add("宗谷地方");
            tbWeatherInfo3.Items.Add("上川・留萌地方");
            tbWeatherInfo3.Items.Add("網走・北見・紋別地方");
            tbWeatherInfo3.Items.Add("十勝地方");
            tbWeatherInfo3.Items.Add("釧路・根室地方");
            tbWeatherInfo3.Items.Add("胆振・日高地方");
            tbWeatherInfo3.Items.Add("石狩・空知・後志地方");
            tbWeatherInfo3.Items.Add("渡島・檜山地方");
            tbWeatherInfo3.Items.Add("青森県");
            tbWeatherInfo3.Items.Add("岩手県");
            tbWeatherInfo3.Items.Add("宮城県");
            tbWeatherInfo3.Items.Add("秋田県");
            tbWeatherInfo3.Items.Add("山形県");
            tbWeatherInfo3.Items.Add("福島県");
            tbWeatherInfo3.Items.Add("茨城県");
            tbWeatherInfo3.Items.Add("栃木県");
            tbWeatherInfo3.Items.Add("群馬県");
            tbWeatherInfo3.Items.Add("埼玉県");
            tbWeatherInfo3.Items.Add("東京都");
            tbWeatherInfo3.Items.Add("神奈川県");
            tbWeatherInfo3.Items.Add("山梨県");
            tbWeatherInfo3.Items.Add("長野県");
            tbWeatherInfo3.Items.Add("岐阜県");
            tbWeatherInfo3.Items.Add("静岡県");
            tbWeatherInfo3.Items.Add("愛知県");
            tbWeatherInfo3.Items.Add("三重県");
            tbWeatherInfo3.Items.Add("新潟県");
            tbWeatherInfo3.Items.Add("富山県");
            tbWeatherInfo3.Items.Add("石川県");
            tbWeatherInfo3.Items.Add("福井県");
            tbWeatherInfo3.Items.Add("滋賀県");
            tbWeatherInfo3.Items.Add("京都府");
            tbWeatherInfo3.Items.Add("大阪府");
            tbWeatherInfo3.Items.Add("兵庫県");
            tbWeatherInfo3.Items.Add("奈良県");
            tbWeatherInfo3.Items.Add("和歌山県");
            tbWeatherInfo3.Items.Add("鳥取県");
            tbWeatherInfo3.Items.Add("島根県");
            tbWeatherInfo3.Items.Add("岡山県");
            tbWeatherInfo3.Items.Add("広島県");
            tbWeatherInfo3.Items.Add("徳島県");
            tbWeatherInfo3.Items.Add("香川県");
            tbWeatherInfo3.Items.Add("愛媛県");
            tbWeatherInfo3.Items.Add("高知県");
            tbWeatherInfo3.Items.Add("山口県");
            tbWeatherInfo3.Items.Add("福岡県");
            tbWeatherInfo3.Items.Add("佐賀県");
            tbWeatherInfo3.Items.Add("長崎県");
            tbWeatherInfo3.Items.Add("熊本県");
            tbWeatherInfo3.Items.Add("大分県");
            tbWeatherInfo3.Items.Add("宮崎県");
            tbWeatherInfo3.Items.Add("奄美地方");
            tbWeatherInfo3.Items.Add("鹿児島県（奄美地方除く）");
            tbWeatherInfo3.Items.Add("沖縄本島地方");
            tbWeatherInfo3.Items.Add("大東島地方");
            tbWeatherInfo3.Items.Add("宮古島地方");
            tbWeatherInfo3.Items.Add("八重山地方");

            string filePath = @"\\172.16.45.1\学生共有\#infosys2022\オブジェクト指向プログラミング\３期目\天気アプリ\areacode.csv";
            // StreamReaderクラスをインスタンス化
            StreamReader reader = new StreamReader(filePath, Encoding.GetEncoding("UTF-8"));
            // 最後まで読み込む
            while (reader.Peek() >= 0) {
                // 読み込んだ文字列をカンマ区切りで配列に格納
                string[] cols = reader.ReadLine().Split(',');
                for (int n = 1; n < cols.Length; n++) {
                    // 表示
                    comboBox1.Items.Add(cols[n] + ", ");
                }
                Console.ReadLine();
            }
            reader.Close();
        }
    }
}
