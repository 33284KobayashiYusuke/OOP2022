
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
            this.cbName = new System.Windows.Forms.ComboBox();
            this.cbCarName = new System.Windows.Forms.ComboBox();
            this.btPictureOpen = new System.Windows.Forms.Button();
            this.btOpen = new System.Windows.Forms.Button();
            this.btSeve = new System.Windows.Forms.Button();
            this.btPictureDelete = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btCorrect = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEnd = new System.Windows.Forms.Button();
            this.dgv_Parsons = new System.Windows.Forms.DataGridView();
            this.toyota = new System.Windows.Forms.RadioButton();
            this.nissann = new System.Windows.Forms.RadioButton();
            this.honnda = new System.Windows.Forms.RadioButton();
            this.subaru = new System.Windows.Forms.RadioButton();
            this.foreign_Car = new System.Windows.Forms.RadioButton();
            this.other = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pdPicture = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbReport = new System.Windows.Forms.TextBox();
            this.ofdFileOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.色設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cdColorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Parsons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdPicture)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbName
            // 
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(83, 70);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(274, 20);
            this.cbName.TabIndex = 0;
            // 
            // cbCarName
            // 
            this.cbCarName.FormattingEnabled = true;
            this.cbCarName.Location = new System.Drawing.Point(83, 153);
            this.cbCarName.MaximumSize = new System.Drawing.Size(274, 0);
            this.cbCarName.Name = "cbCarName";
            this.cbCarName.Size = new System.Drawing.Size(274, 20);
            this.cbCarName.TabIndex = 0;
            // 
            // btPictureOpen
            // 
            this.btPictureOpen.Location = new System.Drawing.Point(691, 25);
            this.btPictureOpen.Name = "btPictureOpen";
            this.btPictureOpen.Size = new System.Drawing.Size(83, 28);
            this.btPictureOpen.TabIndex = 1;
            this.btPictureOpen.Text = "開く";
            this.btPictureOpen.UseVisualStyleBackColor = true;
            this.btPictureOpen.Click += new System.EventHandler(this.btPictureOpen_Click);
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(-1, 389);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(78, 42);
            this.btOpen.TabIndex = 1;
            this.btOpen.Text = "開く";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // btSeve
            // 
            this.btSeve.Location = new System.Drawing.Point(-1, 453);
            this.btSeve.Name = "btSeve";
            this.btSeve.Size = new System.Drawing.Size(78, 38);
            this.btSeve.TabIndex = 1;
            this.btSeve.Text = "保存";
            this.btSeve.UseVisualStyleBackColor = true;
            this.btSeve.Click += new System.EventHandler(this.btSeve_Click);
            // 
            // btPictureDelete
            // 
            this.btPictureDelete.Location = new System.Drawing.Point(794, 25);
            this.btPictureDelete.Name = "btPictureDelete";
            this.btPictureDelete.Size = new System.Drawing.Size(83, 28);
            this.btPictureDelete.TabIndex = 1;
            this.btPictureDelete.Text = "削除";
            this.btPictureDelete.UseVisualStyleBackColor = true;
            this.btPictureDelete.Click += new System.EventHandler(this.btPictureDelete_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(643, 310);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(74, 29);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "追加";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btCorrect
            // 
            this.btCorrect.Location = new System.Drawing.Point(723, 310);
            this.btCorrect.Name = "btCorrect";
            this.btCorrect.Size = new System.Drawing.Size(74, 29);
            this.btCorrect.TabIndex = 1;
            this.btCorrect.Text = "修正";
            this.btCorrect.UseVisualStyleBackColor = true;
            this.btCorrect.Click += new System.EventHandler(this.btCorrect_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(805, 310);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(74, 29);
            this.btDelete.TabIndex = 1;
            this.btDelete.Text = "削除";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEnd
            // 
            this.btEnd.Location = new System.Drawing.Point(818, 567);
            this.btEnd.Name = "btEnd";
            this.btEnd.Size = new System.Drawing.Size(59, 28);
            this.btEnd.TabIndex = 1;
            this.btEnd.Text = "終了";
            this.btEnd.UseVisualStyleBackColor = true;
            this.btEnd.Click += new System.EventHandler(this.btEnd_Click);
            // 
            // dgv_Parsons
            // 
            this.dgv_Parsons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Parsons.Location = new System.Drawing.Point(83, 389);
            this.dgv_Parsons.Name = "dgv_Parsons";
            this.dgv_Parsons.RowTemplate.Height = 21;
            this.dgv_Parsons.Size = new System.Drawing.Size(714, 206);
            this.dgv_Parsons.TabIndex = 2;
            this.dgv_Parsons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Parsons_CellContentClick);
            // 
            // toyota
            // 
            this.toyota.AutoSize = true;
            this.toyota.Location = new System.Drawing.Point(83, 111);
            this.toyota.Name = "toyota";
            this.toyota.Size = new System.Drawing.Size(47, 16);
            this.toyota.TabIndex = 3;
            this.toyota.Text = "トヨタ";
            this.toyota.UseVisualStyleBackColor = true;
            // 
            // nissann
            // 
            this.nissann.AutoSize = true;
            this.nissann.Location = new System.Drawing.Point(145, 111);
            this.nissann.Name = "nissann";
            this.nissann.Size = new System.Drawing.Size(47, 16);
            this.nissann.TabIndex = 3;
            this.nissann.Text = "日産";
            this.nissann.UseVisualStyleBackColor = true;
            // 
            // honnda
            // 
            this.honnda.AutoSize = true;
            this.honnda.Location = new System.Drawing.Point(208, 111);
            this.honnda.Name = "honnda";
            this.honnda.Size = new System.Drawing.Size(51, 16);
            this.honnda.TabIndex = 3;
            this.honnda.Text = "ホンダ";
            this.honnda.UseVisualStyleBackColor = true;
            // 
            // subaru
            // 
            this.subaru.AutoSize = true;
            this.subaru.Location = new System.Drawing.Point(274, 111);
            this.subaru.Name = "subaru";
            this.subaru.Size = new System.Drawing.Size(52, 16);
            this.subaru.TabIndex = 3;
            this.subaru.Text = "スバル";
            this.subaru.UseVisualStyleBackColor = true;
            // 
            // foreign_Car
            // 
            this.foreign_Car.AutoSize = true;
            this.foreign_Car.Location = new System.Drawing.Point(344, 111);
            this.foreign_Car.Name = "foreign_Car";
            this.foreign_Car.Size = new System.Drawing.Size(59, 16);
            this.foreign_Car.TabIndex = 3;
            this.foreign_Car.Text = "外国車";
            this.foreign_Car.UseVisualStyleBackColor = true;
            // 
            // other
            // 
            this.other.AutoSize = true;
            this.other.Location = new System.Drawing.Point(408, 111);
            this.other.Name = "other";
            this.other.Size = new System.Drawing.Size(54, 16);
            this.other.TabIndex = 3;
            this.other.Text = "その他";
            this.other.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "日付:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(83, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(274, 19);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "記録者:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "メーカー:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "車名:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(606, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "画像:";
            // 
            // pdPicture
            // 
            this.pdPicture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pdPicture.Location = new System.Drawing.Point(608, 56);
            this.pdPicture.Name = "pdPicture";
            this.pdPicture.Size = new System.Drawing.Size(269, 247);
            this.pdPicture.TabIndex = 6;
            this.pdPicture.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "記事一覧:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "レポート:";
            // 
            // tbReport
            // 
            this.tbReport.Location = new System.Drawing.Point(83, 202);
            this.tbReport.Multiline = true;
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(476, 153);
            this.tbReport.TabIndex = 7;
            // 
            // ofdFileOpenDialog
            // 
            this.ofdFileOpenDialog.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(891, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開くToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.toolStripSeparator1,
            this.色設定ToolStripMenuItem,
            this.toolStripSeparator2,
            this.終了ToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル(&F)";
            this.ファイルToolStripMenuItem.Click += new System.EventHandler(this.ファイルToolStripMenuItem_Click);
            // 
            // 開くToolStripMenuItem
            // 
            this.開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            this.開くToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.開くToolStripMenuItem.Text = "開く...";
            this.開くToolStripMenuItem.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.保存ToolStripMenuItem.Text = "保存...";
            // 
            // 色設定ToolStripMenuItem
            // 
            this.色設定ToolStripMenuItem.Name = "色設定ToolStripMenuItem";
            this.色設定ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.色設定ToolStripMenuItem.Text = "色設定";
            this.色設定ToolStripMenuItem.Click += new System.EventHandler(this.色設定ToolStripMenuItem_Click);
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.終了ToolStripMenuItem.Text = "終了";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // cdColorDialog
            // 
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 607);
            this.Controls.Add(this.tbReport);
            this.Controls.Add(this.pdPicture);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.other);
            this.Controls.Add(this.foreign_Car);
            this.Controls.Add(this.honnda);
            this.Controls.Add(this.subaru);
            this.Controls.Add(this.nissann);
            this.Controls.Add(this.toyota);
            this.Controls.Add(this.dgv_Parsons);
            this.Controls.Add(this.btSeve);
            this.Controls.Add(this.btEnd);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btPictureDelete);
            this.Controls.Add(this.btCorrect);
            this.Controls.Add(this.btPictureOpen);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.cbCarName);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Parsons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdPicture)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.ComboBox cbCarName;
        private System.Windows.Forms.Button btPictureOpen;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btSeve;
        private System.Windows.Forms.Button btPictureDelete;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btCorrect;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEnd;
        private System.Windows.Forms.DataGridView dgv_Parsons;
        private System.Windows.Forms.RadioButton toyota;
        private System.Windows.Forms.RadioButton nissann;
        private System.Windows.Forms.RadioButton honnda;
        private System.Windows.Forms.RadioButton subaru;
        private System.Windows.Forms.RadioButton foreign_Car;
        private System.Windows.Forms.RadioButton other;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pdPicture;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbReport;
        private System.Windows.Forms.OpenFileDialog ofdFileOpenDialog;
        private System.Windows.Forms.SaveFileDialog sfdSaveDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開くToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 色設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.ColorDialog cdColorDialog;
    }
}

