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
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public partial class Form1 : Form {

        /*//設定情報保存用オブジェクト
        Settings settings = Settings.getInstancne();

        //カーレポート管理用リスト
        BindingList<Person> listPerson = new BindingList<Person>();

        //int mode = 0;*/
        public Form1() {
            InitializeComponent();
            //dataGridView1.DataSource = listPerson;
        }

        private void addressTableBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202223DataSet);
        }

        private void Form1_Load(object sender, EventArgs e) {

            /*EnabledCheck(); //マスク処理呼び出し

            try {
                //設定ファイルを逆シリアル化(p307)して背景の色を設定
                using (var reader = XmlReader.Create("settings.xml")) {
                    var serializer = new XmlSerializer(typeof(Settings));
                    settings = serializer.Deserialize(reader) as Settings;
                    BackColor = Color.FromArgb(settings.MainFormColor); //ARGBからColorオブジェクトへ変換
                }

            }
            catch (Exception) {

            }*/
        }

        private void dataGridView1_Click(object sender, EventArgs e) {
            if (dataGridView1 == null)
                return;

            //データグリッドビューの選択レコードを各テキストボックスへ設定
            tbDate.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbAuthor.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maker.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbCarName.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tbReport.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            

            //画像表示処理
            if (!(dataGridView1.CurrentRow.Cells[6].Value is DBNull))
                pbPicture.Image = ByteArrayToImage((byte[])dataGridView1.CurrentRow.Cells[6].Value);
            else
                pbPicture.Image = null;

            /*if (!DBNull.Value.Equals(addressTableDataGridView.CurrentRow.Cells[6].Value))
                pbImage.Image = ByteArrayToImage((byte[])addressTableDataGridView.CurrentRow.Cells[6].Value);*/
        }

        private void btUpdate_Click(object sender, EventArgs e) {

            //各テキストボックスからデータグリッドビューへ設定
            dataGridView1.CurrentRow.Cells[1].Value = tbDate.Text;
            dataGridView1.CurrentRow.Cells[2].Value = tbAuthor.Text;
            dataGridView1.CurrentRow.Cells[3].Value = maker.Text;
            dataGridView1.CurrentRow.Cells[4].Value = tbCarName.Text;
            dataGridView1.CurrentRow.Cells[5].Value = tbReport.Text;
            dataGridView1.CurrentRow.Cells[6].Value = ImageToByteArray(pbPicture.Image);

            //データセットの中をデータベースへ反映(保存)
            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202223DataSet);
        }

        private void btPictureOpen_Click(object sender, EventArgs e) {
            ofdImage.Filter = "画像ファイル(*.jpg; *.png; *.bmp)| *.jpg; *.png; *.bmp";
            if (ofdImage.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = System.Drawing.Image.FromFile(ofdImage.FileName);
            }
        }

        private void btImageClear_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b) {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }

        private void btExit_Click(object sender, EventArgs e) {
            //アプリケーションの終了
            Application.Exit();
        }

        /*private void 設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            //色設定ダイアログの表示
            if (cdColorSelect.ShowDialogResult.OK) {
                BackColor = cdColorSelect.Color; //背景変更
                settings.MainFormColor = cdColorSelect.Color.ToArgb();
            }
        }*/

        /*private void pbModeSelect_Click(object sender, EventArgs e) {
            pbPicture.SizeMode = (PictureBoxSizeMode)mode;
            mode = mode < 4 ? ++mode : 0;
        }*/

        /*private void Form1_FormClosed(object sender, EventArgs e) {
            //設定ファイルをシリアル化(p305)
            using(var writer = XmlWriter.Create("settings")) {
                var serializer = new XmlSerializer(settings.GetType());
                serializer.Serialize(writer, settings);
            }
        }*/

        


        private void btAddPerson_Click(object sender, EventArgs e) {

            DataRow newRow = infosys202223DataSet.CarReportDB.NewRow();
            newRow[1] = tbAuthor.Text;

            //データセットへ新しいレコードを追加
            infosys202223DataSet.CarReportDB.Rows.Add(newRow);

            //データベース更新
            this.addressTableTableAdapter.Update(this.infosys202223DataSet.CarReportDB);

            /*//氏名が未入力なら登録しない
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

            settbcomboBox2(tbcomboBox2.Text);*/
        }

        //エラー回避
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e) {
        }

        /*private void EnabledCheck() {
             throw new NotImplementedException();
         }

         private void settbcomboBox2(string text) {
             throw new NotImplementedException();
         }*/

        //コンボボックスに会社名を登録する(重複なし)
        /*private void setCbCompany(String company) {
            if (!tbAddress.Items.Contains(company)) {

                //まだ登録されていなければ登録処理
                tbAddress.Items.Add(tbAddress.Text);
            }

            //チェックボックスにセットされている値をリストとして取り出す
             List<Person.GroupType> GetCheckBoxGroup() {
                var listGroup = new List<Person.GroupType>();
                if (radioButton1.Checked) {
                    listGroup.Add(Person.GroupType.トヨタ);
                }
                if (radioButton1.Checked) {
                    listGroup.Add(Person.GroupType.日産);
                }
                if (radioButton1.Checked) {
                    listGroup.Add(Person.GroupType.ホンダ);
                }
                if (radioButton1.Checked) {
                    listGroup.Add(Person.GroupType.スバル);
                }
                if (radioButton1.Checked) {
                    listGroup.Add(Person.GroupType.外国車);
                }
                if (radioButton1.Checked) {
                    listGroup.Add(Person.GroupType.その他);
                }

                return listGroup;
            }*/

        /*private void btPictureClear_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }*/

        //データグリッドビューをクリックしたときのイベントハンドラ
        /*private void dgvPersons_Click(object sender, EventArgs e) {

            if (dataGridView1.CurrentRow == null) return;

            int index = dataGridView1.CurrentRow.Index;

            /*データグリッドビューのインデックス0番の名前をテキストボックスに格納*/
        /*recorder.Text = listPerson[index].Name;
        dateTimePicker1.Text = listPerson[index].MailAddress;
        tbcomboBox2.Text = listPerson[index].Address;
        tbAddress.Text = listPerson[index].Company;
        pbPicture.Image = listPerson[index].Picture;

        dtpRegistDate.Value =
            listPerson[index].Registration.Year > 1900 ? listPerson[index].Registration : DateTime.Today;

        NewMethod(index);

        //グループのチェックボックスをオールクリア
        private void groupChecjBoxAllClear() {
            radioButton3.Checked = radioButton3.Checked = radioButton2.Checked = radioButton4.Checked = radioButton5.Checked = radioButton6.Checked = false;
        }

        //更新ボタンが押された時の処理
        private void btUpdate_Click(object sender, EventArgs e) {
            listPerson[dataGridView1.CurrentRow.Index].Name = recorder.Text;
            listPerson[dataGridView1.CurrentRow.Index].MailAddress = dateTimePicker1.Text;
            listPerson[dataGridView1.CurrentRow.Index].Address = tbcomboBox2.Text;
            listPerson[dataGridView1.CurrentRow.Index].Company = tbAddress.Text;
            listPerson[dataGridView1.CurrentRow.Index].listGroup = GetCheckBoxGroup();
            listPerson[dataGridView1.CurrentRow.Index].Picture = pbPicture.Image;
            dataGridView1.Refresh();//データグリッドビュー更新
        }

        //削除ボタンが押された時の処理
        private void btDelete_Click(object sender, EventArgs e) {

            listPerson.RemoveAt(dgvPersons.CurrentRow.Index);
            EnabledCheck(); //マスク処理呼び出し
        }

        private void Form1_Load(object sender, EventArgs e) {
            EnabledCheck(); //マスク処理呼び出し
                            //背景色
                            //dgvPersons.RowsDefaultCellStyle.BackColor = Color.Bisque;
                            //奇数行
            dgvPersons.AlternatingRowsDefaultCellStyle.BackColor = Color.AntiqueWhite;
        }


        //保存ボタンのイベントハンドラ
        private void btSave_Click(object sender, EventArgs e) {
            if (sfdSaveDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(sfdSaveDialog.FileName, FileMode.Create)) {
                        bf.Serialize(fs, listPerson);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btOpen_Click(object sender, EventArgs e) {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式で逆シリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(ofdFileOpenDialog.FileName, FileMode.Open, FileAccess.Read)) {
                        //逆シリアル化して読み込む
                        listPerson = (BindingList<Person>)bf.Deserialize(fs);
                        dgvPersons.DataSource = null;
                        dgvPersons.DataSource = listPerson;
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                cbCompany.Items.Clear();    //コンボボックスのアイテム消去
                                            //コンボボックスへ新規登録
                foreach (var item in listPerson.Select(p => p.Company)) {
                    setCbCompany(item);//存在する会社を登録
                }
            }
            EnabledCheck(); //マスク処理呼び出し
        }
    }
}

private void NewMethod(int index) {
groupCheckBoxAllClear();    //グループチェックボックスを一旦初期化

foreach (var group in listPerson[index].listGroup) {
switch (group) {
    case Person.GroupType.トヨタ:
        cbFamily.Checked = true;
        break;
    case Person.GroupType.日産:
        cbFriend.Checked = true;
        break;
    case Person.GroupType.ホンダ:
        cbWork.Checked = true;
        break;
    case Person.GroupType.スバル:
        cbOther.Checked = true;
        break;
    case Person.GroupType.外国車:
        cbOther.Checked = true;
        break;
    case Person.GroupType.その他:
        cbOther.Checked = true;
        break;
    default:
        break;
}

NewMethod1(index);
}
}*/



        private void データベース接続ToolStripMenuItem_Click(object sender, EventArgs e) {
            this.CarReportDBTableAdapter.Fill(this.infosys202223DataSet.CarReportDB);
        }

        
    }
}