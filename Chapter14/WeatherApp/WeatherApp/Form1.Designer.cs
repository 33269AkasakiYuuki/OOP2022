
namespace WeatherApp {
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
            this.btWeatherGet = new System.Windows.Forms.Button();
            this.tbWeatherInfo2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbWeatherInfo1 = new System.Windows.Forms.TextBox();
            this.tbWeatherInfo3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbWeatherInfo4 = new System.Windows.Forms.TextBox();
            this.tbWeatherInfo5 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btWeatherGet
            // 
            this.btWeatherGet.AllowDrop = true;
            this.btWeatherGet.Location = new System.Drawing.Point(10, 341);
            this.btWeatherGet.Name = "btWeatherGet";
            this.btWeatherGet.Size = new System.Drawing.Size(74, 41);
            this.btWeatherGet.TabIndex = 0;
            this.btWeatherGet.Text = "取得";
            this.btWeatherGet.UseVisualStyleBackColor = true;
            this.btWeatherGet.Click += new System.EventHandler(this.btWeatherGet_Click);
            // 
            // tbWeatherInfo2
            // 
            this.tbWeatherInfo2.AllowDrop = true;
            this.tbWeatherInfo2.Location = new System.Drawing.Point(90, 58);
            this.tbWeatherInfo2.Multiline = true;
            this.tbWeatherInfo2.Name = "tbWeatherInfo2";
            this.tbWeatherInfo2.Size = new System.Drawing.Size(89, 24);
            this.tbWeatherInfo2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "ヘッドライン";
            // 
            // tbWeatherInfo1
            // 
            this.tbWeatherInfo1.AllowDrop = true;
            this.tbWeatherInfo1.Location = new System.Drawing.Point(90, 10);
            this.tbWeatherInfo1.Multiline = true;
            this.tbWeatherInfo1.Name = "tbWeatherInfo1";
            this.tbWeatherInfo1.Size = new System.Drawing.Size(61, 26);
            this.tbWeatherInfo1.TabIndex = 5;
            // 
            // tbWeatherInfo3
            // 
            this.tbWeatherInfo3.AllowDrop = true;
            this.tbWeatherInfo3.Location = new System.Drawing.Point(90, 88);
            this.tbWeatherInfo3.Multiline = true;
            this.tbWeatherInfo3.Name = "tbWeatherInfo3";
            this.tbWeatherInfo3.Size = new System.Drawing.Size(89, 24);
            this.tbWeatherInfo3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "発表者";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "報告日時";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "対象地域";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "詳細";
            // 
            // tbWeatherInfo4
            // 
            this.tbWeatherInfo4.AllowDrop = true;
            this.tbWeatherInfo4.Location = new System.Drawing.Point(90, 128);
            this.tbWeatherInfo4.Multiline = true;
            this.tbWeatherInfo4.Name = "tbWeatherInfo4";
            this.tbWeatherInfo4.Size = new System.Drawing.Size(151, 45);
            this.tbWeatherInfo4.TabIndex = 11;
            // 
            // tbWeatherInfo5
            // 
            this.tbWeatherInfo5.AllowDrop = true;
            this.tbWeatherInfo5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbWeatherInfo5.Location = new System.Drawing.Point(90, 179);
            this.tbWeatherInfo5.Multiline = true;
            this.tbWeatherInfo5.Name = "tbWeatherInfo5";
            this.tbWeatherInfo5.Size = new System.Drawing.Size(151, 204);
            this.tbWeatherInfo5.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Location = new System.Drawing.Point(365, 7);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 45);
            this.textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.AllowDrop = true;
            this.textBox2.Location = new System.Drawing.Point(365, 80);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 45);
            this.textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.AllowDrop = true;
            this.textBox3.Location = new System.Drawing.Point(365, 149);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(151, 45);
            this.textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.AllowDrop = true;
            this.textBox4.Location = new System.Drawing.Point(365, 218);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(151, 45);
            this.textBox4.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "概況";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(296, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 12);
            this.label7.TabIndex = 19;
            this.label7.Text = "明日の天気";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(284, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "明後日の天気";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(296, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "今日の天気";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 394);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbWeatherInfo5);
            this.Controls.Add(this.tbWeatherInfo4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbWeatherInfo3);
            this.Controls.Add(this.tbWeatherInfo1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbWeatherInfo2);
            this.Controls.Add(this.btWeatherGet);
            this.Name = "Form1";
            this.Text = "天気アプリ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btWeatherGet;
        private System.Windows.Forms.TextBox tbWeatherInfo2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbWeatherInfo1;
        private System.Windows.Forms.TextBox tbWeatherInfo3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbWeatherInfo4;
        private System.Windows.Forms.TextBox tbWeatherInfo5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

