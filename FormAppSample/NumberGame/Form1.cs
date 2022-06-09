using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGame {
    public partial class Form1 : Form {

        //乱数オブジェクト生成
        private Random rand = new Random();

        //乱数保存用
        private int randomNumder;

        public Form1() {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e) {
            //乱数取得
            randomNumder = rand.Next(1,(int)maxNum.Value);
            this.Text = randomNumder.ToString();
        }

        //判定ボタンイベントハンドラ
        private void judge_Click(object sender, EventArgs e) {
            //入力した値とあらかじめ取得した乱数を比較し結果を表示
            if (randomNumder == Number.Value) {
                toolStripStatusLabel1.Text = "正解";
            }
            else if (randomNumder > Number.Value) {
                toolStripStatusLabel1
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
            
        } 
    }
}
