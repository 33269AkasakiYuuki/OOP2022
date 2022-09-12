
namespace CarReportSystem {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.recorder = new System.Windows.Forms.ComboBox();
            this.tbcomboBox2 = new System.Windows.Forms.ComboBox();
            this.btOpen = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btAddPerson = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.btPictureOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(62, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 19);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // recorder
            // 
            this.recorder.FormattingEnabled = true;
            this.recorder.Location = new System.Drawing.Point(62, 66);
            this.recorder.Name = "recorder";
            this.recorder.Size = new System.Drawing.Size(236, 20);
            this.recorder.TabIndex = 1;
            // 
            // tbcomboBox2
            // 
            this.tbcomboBox2.FormattingEnabled = true;
            this.tbcomboBox2.Location = new System.Drawing.Point(62, 135);
            this.tbcomboBox2.Name = "tbcomboBox2";
            this.tbcomboBox2.Size = new System.Drawing.Size(236, 20);
            this.tbcomboBox2.TabIndex = 1;
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(12, 303);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(44, 35);
            this.btOpen.TabIndex = 2;
            this.btOpen.Text = "開く...";
            this.btOpen.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "保存...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btAddPerson
            // 
            this.btAddPerson.Location = new System.Drawing.Point(457, 242);
            this.btAddPerson.Name = "btAddPerson";
            this.btAddPerson.Size = new System.Drawing.Size(75, 23);
            this.btAddPerson.TabIndex = 2;
            this.btAddPerson.Text = "追加";
            this.btAddPerson.UseVisualStyleBackColor = true;
            this.btAddPerson.Click += new System.EventHandler(this.btAddPerson_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(624, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "削除";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(554, 242);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "修正";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(651, 242);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 2;
            this.button6.Text = "削除";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(633, 491);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(93, 23);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "終了";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(62, 104);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 16);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "トヨタ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(180, 104);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(51, 16);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "ホンダ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(121, 104);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(47, 16);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "日産";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(243, 104);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(52, 16);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "スバル";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(307, 104);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(59, 16);
            this.radioButton5.TabIndex = 3;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "外国車";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // pbPicture
            // 
            this.pbPicture.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbPicture.Location = new System.Drawing.Point(476, 40);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(235, 182);
            this.pbPicture.TabIndex = 6;
            this.pbPicture.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(62, 279);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(664, 194);
            this.dataGridView1.TabIndex = 1;
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbAddress.Location = new System.Drawing.Point(62, 168);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(377, 105);
            this.tbAddress.TabIndex = 2;
            // 
            // btPictureOpen
            // 
            this.btPictureOpen.Location = new System.Drawing.Point(533, 11);
            this.btPictureOpen.Name = "btPictureOpen";
            this.btPictureOpen.Size = new System.Drawing.Size(75, 23);
            this.btPictureOpen.TabIndex = 2;
            this.btPictureOpen.Text = "開く...";
            this.btPictureOpen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "日付：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "記録者：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "メーカー：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "車名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "レポート：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "記事一覧";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(464, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "画像：";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(378, 104);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(54, 16);
            this.radioButton6.TabIndex = 14;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "その他";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 527);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btPictureOpen);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btAddPerson);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.tbcomboBox2);
            this.Controls.Add(this.recorder);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbAddress);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox recorder;
        private System.Windows.Forms.ComboBox tbcomboBox2;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btAddPerson;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Button btPictureOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

