
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;



namespace CarReportSystem {
    public partial class Form1 : Form {

        //設定情報保存用オブジェクト
        Settings settings = Settings.getInstancne();

        private void carReportBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202223DataSet);
        }

        int mode = 0;
        public Form1() {
            InitializeComponent();
        }
        //追加
        private void btAdd_Click(object sender, EventArgs e) {
            if (String.IsNullOrWhiteSpace(tbReport.Text) && String.IsNullOrWhiteSpace(tbAuthor.Text) && String.IsNullOrWhiteSpace(tbCarName.Text)) {
                MessageBox.Show("未入力の項目があります。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else {

                DataRow newRow = infosys202223DataSet.CarReportDB.NewRow();
                newRow[1] = tbDate.Value;
                newRow[2] = tbAuthor.Text;
                newRow[3] = GetRadioButtonGroup();
                newRow[4] = tbCarName.Text;
                newRow[5] = tbReport.Text;
                newRow[6] = ImageToByteArray(pbPicture.Image);

                //データセットへ新しいレコードを追加

                infosys202223DataSet.CarReportDB.Rows.Add(newRow);

                //データベース更新
                this.carReportDBTableAdapter.Update(this.infosys202223DataSet.CarReportDB);

                setCbAuther(tbAuthor.Text);
                setCbCarName(tbCarName.Text);
                tbDate.Value = DateTime.Today;
            }

        }

        //コンボボックスに記録者名を登録する（重複なし）
        private void setCbAuther(string Name) {
            if (!tbAuthor.Items.Contains(Name)) {
                tbAuthor.Items.Add(Name);
            }
        }

        //コンボボックスに車名を登録する（重複なし）
        private void setCbCarName(string Name) {
            if (!tbCarName.Items.Contains(Name)) {
                tbCarName.Items.Add(Name);
            }
        }

        //ラジオボタンにセットされている値を取り出す
        private string GetRadioButtonGroup() {
            if (rbToyota.Checked) {
                return "トヨタ";
            }

            if (rbNissan.Checked) { 
                return "日産";
            }

            if (rbHonda.Checked) {
                return "ホンダ";
            }

            if (rbSubaru.Checked) {
                return "スバル";
            }

            if (rbForeignCar.Checked) {
                return "外国車";
            }
            
            return "その他";
        }

        //添付画像削除
        private void btPictureClear_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        //画像ファイルを開く
        private void btPictureOpen_Click(object sender, EventArgs e) {
            if (ofdPictureOpen.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdPictureOpen.FileName);
            }
        }

        //アプリケーションの終了
        private void btExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        //削除
        private void btDelete_Click(object sender, EventArgs e) {

            //データセットのレコードを削除
            infosys202223DataSet.CarReportDB.Rows.RemoveAt(DataGridView.CurrentRow.Index);
            
            //データベース更新
            this.carReportDBTableAdapter.Update(this.infosys202223DataSet.CarReportDB);
        }

        //修正
        private void btFix_Click(object sender, EventArgs e) {
            if (String.IsNullOrWhiteSpace(tbReport.Text) && String.IsNullOrWhiteSpace(tbAuthor.Text) && String.IsNullOrWhiteSpace(tbCarName.Text)) {
                MessageBox.Show("未入力の項目があります。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataGridView.CurrentRow.Cells[1].Value = tbDate.Value;
            DataGridView.CurrentRow.Cells[2].Value = tbAuthor.Text;
            DataGridView.CurrentRow.Cells[3].Value = GetRadioButtonGroup();
            DataGridView.CurrentRow.Cells[4].Value = tbCarName.Text;
            DataGridView.CurrentRow.Cells[5].Value = tbReport.Text;
            DataGridView.CurrentRow.Cells[6].Value = ImageToByteArray(pbPicture.Image);
            DataGridView.Refresh();//データグリッドビュー修正
            setCbAuther(tbAuthor.Text);
            setCbCarName(tbCarName.Text);
            tbDate.Value = DateTime.Now;
            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202223DataSet);
        }

        //色設定
        private void btColorSetting_Click(object sender, EventArgs e) {
            if (colorDialog1.ShowDialog() == DialogResult.OK) {
                BackColor = colorDialog1.Color;
                settings.MainFormColor = BackColor.ToArgb();  //設定オブジェクトにセット
            }
        }

        //フォームを閉じたときの処理
        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {

            using (var color = XmlWriter.Create("settings.xml")) {
                var serializer = new XmlSerializer(settings.GetType());
                serializer.Serialize(color, settings);
            }
        }

        //フォームをロードしたときの処理
        private void Form1_Load(object sender, EventArgs e) {

            //設定ファイルを逆シリアル化（P307）して背景の色を設定
            try {
                using (var reader = XmlReader.Create("settings.xml")) {
                    var serializer = new XmlSerializer(typeof(Settings));
                    settings = serializer.Deserialize(reader) as Settings;
                    SetStyle(ControlStyles.SupportsTransparentBackColor, true);
                    BackColor = Color.FromArgb(settings.MainFormColor);
                }
            }
            catch(Exception){}
            finally {}
        }

        //画像サイズ変更
        private void btModeSelect_Click(object sender, EventArgs e) {
            pbPicture.SizeMode = (PictureBoxSizeMode)mode;
            mode = mode < 4 ? ++mode : 0;
        }

        //データベース接続
        private void btConnect_Click(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202223DataSet.CarReport' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportDBTableAdapter.Fill(this.infosys202223DataSet.CarReportDB);
        }

        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b) {
            try {
                ImageConverter imgconv = new ImageConverter();
                Image img = (Image)imgconv.ConvertFrom(b);
                return img;
            }
            catch {
                return null;
            }
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }

        //エラー回避
        private void dgvCarReport_DataError(object sender, DataGridViewDataErrorEventArgs e) {



        }

       //バージョン情報        private void btVersion_Click(object sender, EventArgs e) {new Version().ShowDialog();        }

       private void dgvCarReport_Click(object sender, EventArgs e) {
            if (DataGridView.CurrentRow == null) return;

            //データグリッドビューの選択レコードを各テキストボックスへ設定
            try {
                tbDate.Value = (DateTime)DataGridView.CurrentRow.Cells[1].Value;
            }
            catch{
                tbAuthor.Text = DataGridView.CurrentRow.Cells[2].Value.ToString();
            }
            switch (DataGridView.CurrentRow.Cells[3].Value){
                case "トヨタ":
                    rbToyota.Checked = true;
                    break;
                case "日産":
                    rbNissan.Checked = true;
                    break;
                case "ホンダ":    
                    rbHonda.Checked = true; 
                    break;   
                case "スバル": 
                    rbSubaru.Checked = true; 
                    break;    
                case "外国車":   
                    rbForeignCar.Checked = true;    
                    break;   
                default:
                    rbOther.Checked = true;
                    break;          
            }

            tbCarName.Text = DataGridView.CurrentRow.Cells[4].Value.ToString();
            tbReport.Text = DataGridView.CurrentRow.Cells[5].Value.ToString();
            if (!(DataGridView.CurrentRow.Cells[6].Value is DBNull)) {
                pbPicture.Image = ByteArrayToImage((byte[])DataGridView.CurrentRow.Cells[6].Value);
            }
            else {
                pbPicture.Image = null;
            }
        }

        private void DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e) {

        }
    }
}