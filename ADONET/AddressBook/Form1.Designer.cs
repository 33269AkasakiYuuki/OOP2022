
namespace AddressBook {
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
            this.components = new System.ComponentModel.Container();
            this.addressTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.addressTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infosys202223DataSet = new AddressBook.infosys202223DataSet();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbMemo = new System.Windows.Forms.TextBox();
            this.btUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAdd = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btImageOpen = new System.Windows.Forms.Button();
            this.btImageClear = new System.Windows.Forms.Button();
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.btNameSearch = new System.Windows.Forms.Button();
            this.tbSearchName = new System.Windows.Forms.TextBox();
            this.addressTableTableAdapter = new AddressBook.infosys202223DataSetTableAdapters.AddressTableTableAdapter();
            this.tableAdapterManager = new AddressBook.infosys202223DataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.接続ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.終了xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.バージョン情報ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.addressTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202223DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addressTableDataGridView
            // 
            this.addressTableDataGridView.AllowUserToAddRows = false;
            this.addressTableDataGridView.AllowUserToDeleteRows = false;
            this.addressTableDataGridView.AutoGenerateColumns = false;
            this.addressTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addressTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewImageColumn1});
            this.addressTableDataGridView.DataSource = this.addressTableBindingSource;
            this.addressTableDataGridView.Location = new System.Drawing.Point(13, 301);
            this.addressTableDataGridView.MultiSelect = false;
            this.addressTableDataGridView.Name = "addressTableDataGridView";
            this.addressTableDataGridView.ReadOnly = true;
            this.addressTableDataGridView.RowTemplate.Height = 21;
            this.addressTableDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.addressTableDataGridView.Size = new System.Drawing.Size(814, 220);
            this.addressTableDataGridView.TabIndex = 1;
            this.addressTableDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.addressTableDataGridView_DataError);
            this.addressTableDataGridView.Click += new System.EventHandler(this.addressTableDataGridView_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn3.HeaderText = "Address";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Tel";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tel";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Mail";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mail";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Memo";
            this.dataGridViewTextBoxColumn6.HeaderText = "Memo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Image";
            this.dataGridViewImageColumn1.HeaderText = "Image";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // addressTableBindingSource
            // 
            this.addressTableBindingSource.DataMember = "AddressTable";
            this.addressTableBindingSource.DataSource = this.infosys202223DataSet;
            // 
            // infosys202223DataSet
            // 
            this.infosys202223DataSet.DataSetName = "infosys202223DataSet";
            this.infosys202223DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(98, 45);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(283, 19);
            this.tbName.TabIndex = 2;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(98, 77);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(357, 19);
            this.tbAddress.TabIndex = 3;
            // 
            // tbTel
            // 
            this.tbTel.Location = new System.Drawing.Point(98, 107);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(258, 19);
            this.tbTel.TabIndex = 4;
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(98, 141);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(327, 19);
            this.tbMail.TabIndex = 5;
            // 
            // tbMemo
            // 
            this.tbMemo.Location = new System.Drawing.Point(98, 178);
            this.tbMemo.Multiline = true;
            this.tbMemo.Name = "tbMemo";
            this.tbMemo.Size = new System.Drawing.Size(413, 67);
            this.tbMemo.TabIndex = 6;
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(718, 271);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(109, 24);
            this.btUpdate.TabIndex = 7;
            this.btUpdate.Text = "更新";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "Memo";
            // 
            // tbAdd
            // 
            this.tbAdd.Location = new System.Drawing.Point(599, 243);
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(109, 24);
            this.tbAdd.TabIndex = 14;
            this.tbAdd.Text = "追加";
            this.tbAdd.UseVisualStyleBackColor = true;
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(514, 44);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(309, 196);
            this.pbImage.TabIndex = 15;
            this.pbImage.TabStop = false;
            // 
            // btImageOpen
            // 
            this.btImageOpen.Location = new System.Drawing.Point(622, 12);
            this.btImageOpen.Name = "btImageOpen";
            this.btImageOpen.Size = new System.Drawing.Size(85, 23);
            this.btImageOpen.TabIndex = 16;
            this.btImageOpen.Text = "開く...";
            this.btImageOpen.UseVisualStyleBackColor = true;
            this.btImageOpen.Click += new System.EventHandler(this.btImageOpen_Click);
            // 
            // btImageClear
            // 
            this.btImageClear.Location = new System.Drawing.Point(714, 11);
            this.btImageClear.Name = "btImageClear";
            this.btImageClear.Size = new System.Drawing.Size(75, 23);
            this.btImageClear.TabIndex = 17;
            this.btImageClear.Text = "×";
            this.btImageClear.UseVisualStyleBackColor = true;
            this.btImageClear.Click += new System.EventHandler(this.btImageClear_Click);
            // 
            // ofdImage
            // 
            this.ofdImage.FileName = "openFileDialog1";
            // 
            // btNameSearch
            // 
            this.btNameSearch.Location = new System.Drawing.Point(18, 262);
            this.btNameSearch.Name = "btNameSearch";
            this.btNameSearch.Size = new System.Drawing.Size(75, 23);
            this.btNameSearch.TabIndex = 18;
            this.btNameSearch.Text = "名前検索";
            this.btNameSearch.UseVisualStyleBackColor = true;
            this.btNameSearch.Click += new System.EventHandler(this.btNameSearch_Click);
            // 
            // tbSearchName
            // 
            this.tbSearchName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbSearchName.Location = new System.Drawing.Point(99, 253);
            this.tbSearchName.Name = "tbSearchName";
            this.tbSearchName.Size = new System.Drawing.Size(270, 31);
            this.tbSearchName.TabIndex = 19;
            // 
            // addressTableTableAdapter
            // 
            this.addressTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AddressTableTableAdapter = this.addressTableTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = AddressBook.infosys202223DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(718, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 22);
            this.button1.TabIndex = 20;
            this.button1.Text = "クリア";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.接続ToolStripMenuItem,
            this.ヘルプToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(839, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 接続ToolStripMenuItem
            // 
            this.接続ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btConnect,
            this.終了xToolStripMenuItem});
            this.接続ToolStripMenuItem.Name = "接続ToolStripMenuItem";
            this.接続ToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.接続ToolStripMenuItem.Text = "ファイル";
            this.接続ToolStripMenuItem.Click += new System.EventHandler(this.接続ToolStripMenuItem_Click);
            // 
            // btConnect
            // 
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(180, 22);
            this.btConnect.Text = "データベース接続";
            // 
            // 終了xToolStripMenuItem
            // 
            this.終了xToolStripMenuItem.Name = "終了xToolStripMenuItem";
            this.終了xToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.終了xToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.終了xToolStripMenuItem.Text = "終了";
            // 
            // ヘルプToolStripMenuItem
            // 
            this.ヘルプToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.バージョン情報ToolStripMenuItem});
            this.ヘルプToolStripMenuItem.Name = "ヘルプToolStripMenuItem";
            this.ヘルプToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.ヘルプToolStripMenuItem.Text = "ヘルプ";
            // 
            // バージョン情報ToolStripMenuItem
            // 
            this.バージョン情報ToolStripMenuItem.Name = "バージョン情報ToolStripMenuItem";
            this.バージョン情報ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.バージョン情報ToolStripMenuItem.Text = "バージョン情報";
            this.バージョン情報ToolStripMenuItem.Click += new System.EventHandler(this.バージョン情報ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 533);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbSearchName);
            this.Controls.Add(this.btNameSearch);
            this.Controls.Add(this.btImageClear);
            this.Controls.Add(this.btImageOpen);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.tbAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.tbMemo);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.tbTel);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.addressTableDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addressTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202223DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private infosys202223DataSet infosys202223DataSet;
        private System.Windows.Forms.BindingSource addressTableBindingSource;
        private infosys202223DataSetTableAdapters.AddressTableTableAdapter addressTableTableAdapter;
        private infosys202223DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView addressTableDataGridView;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbMemo;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button tbAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btImageOpen;
        private System.Windows.Forms.Button btImageClear;
        private System.Windows.Forms.OpenFileDialog ofdImage;
        private System.Windows.Forms.Button btNameSearch;
        private System.Windows.Forms.TextBox tbSearchName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 接続ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btConnect;
        private System.Windows.Forms.ToolStripMenuItem 終了xToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem バージョン情報ToolStripMenuItem;
    }
}

