using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0607 {
    public partial class Form1 : Form {

        Random rand = new Random(); //乱数オブジェクト生成

        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
             /*if (int.Parse(tbNum2.Text) != 0) {
                 tbAns.Text = (int.Parse(tbNum1.Text) / int.Parse(tbNum2.Text)).ToString();
                 tbMod.Text = (int.Parse(tbNum1.Text) % int.Parse(tbNum2.Text)).ToString();
             }
             else {
                 MessageBox.Show("0で割り算できません", "エラー",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
             }

            if (nudNum2.Value !=0) {
                nudAns.Value = nudNum1.Value / nudNum2.Value;
                nudMod.Value = nudNum1.Value % nudNum2.Value;
            }
            else {
                MessageBox.Show("0で割り算できません", "エラー",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }*/


        }
        
        private void tbRandom_Click(object sender, EventArgs e) {
            //Number.Value = rand.Next(minValue: 1, maxValue: 7);
            Number.Value = rand.Next(minValue: (int)numericUpDown1.Value, maxValue: (int)numericUpDown2.Value+1);
        }

        //イベントハンドラ(起動時に一度だけ実行)
        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}
