using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook {
    public partial class Form1 : Form {

        //住所データ管理用リスト
        BindingList<Person> listPerson = new BindingList<Person>();

        public Form1() {
            InitializeComponent();
            dgvPersons.DataSource = listPerson;
        }

        private void btPictureOpen_Click(object sender, EventArgs e) {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);
            }  
        }

        private void btAddPerson_Click(object sender, EventArgs e) {
            Person newperson = new Person {
                Name = tbName.Text,
                MailAddress = tbMailAddress.Text,
                Address = tbAddress.Text,
                Company = tbCompany.Text,
                Picture = pbPicture.Image,
                listGroup = GetCheckBoxGroup(),
            };

            listPerson.Add(newperson);
        }

        //チェックボックスにセットされている値をリストとして取り出す
        private List<Person.GroupType> GetCheckBoxGroup() {
            var listGroup = new List<Person.GroupType>();
            if (cbFamily.Checked) {
                listGroup.Add(Person.GroupType.家族);
            }
            if (cbFamily.Checked) {
                listGroup.Add(Person.GroupType.友人);
            }
            if (cbFamily.Checked) {
                listGroup.Add(Person.GroupType.仕事);
            }
            if (cbFamily.Checked) {
                listGroup.Add(Person.GroupType.その他);

            }
            
            return listGroup;
        }

        private void btPictureClear_Click(object sender, EventArgs e) {
            pbPicture.Image = null;

        }

        //データグリッドビューをクリックしたときのイベントハンドラ
        private void dgvPersons_Click(object sender, EventArgs e) {
            int index = dgvPersons.CurrentRow.Index;
            /*データグリッドビューのインデックス0番の名前をテキストボックスに格納*/
            tbName.Text = listPerson[index].Name;
            tbMailAddress.Text = listPerson[index].MailAddress;
            tbAddress.Text = listPerson[index].Address;
            tbCompany.Text = listPerson[index].Company;
            pbPicture.Image = listPerson[index].Picture;

            foreach (var group in listPerson[index].listGroup) {
                switch (group) {
                    case Person.GroupType.家族:
                        break;
                    case Person.GroupType.友人:
                        break;
                    case Person.GroupType.仕事:
                        break;
                    case Person.GroupType.その他:
                        break;
                    default:
                        break;
                }
            }

             /* 選択されているインデックスを取得する

              インデックスが取得できたら、リスト(kistPerson)の該当するインデックスに
              アクセスし、リストの各項目を名テキストボックスへ表示する*/

        }
    }
}
