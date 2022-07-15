using AddressBook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {

        BindingList<Person> listPerson = new BindingList<Person>();

        public Form1() {
            InitializeComponent();
            dataGridView1.DataSource = listPerson;
        }

        private void btAddPerson_Click(object sender, EventArgs e) {
            //氏名が未入力なら登録しない
            if (String.IsNullOrWhiteSpace(recorder.Text)) {
                MessageBox.Show("氏名が入力されていません");
                return;
            }

            Person newPerson = new Person {
                Name = recorder.Text,
                MailAddress = dateTimePicker1.Text,
                Address = tbcomboBox2.Text,
                Company = tbAddress.Text,
                Picture = pbPicture.Image,
            };

            listPerson.Add(newPerson);
            dataGridView1.Rows[dataGridView1.RowCount - 1].Selected = true;

            EnabledCheck(); //マスク処理呼び出し

            settbcomboBox2(tbcomboBox2.Text);
        }

        
    }
}
