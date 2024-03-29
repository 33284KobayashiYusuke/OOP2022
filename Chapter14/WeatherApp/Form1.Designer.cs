﻿
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
            this.tbWeatherInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAreaInfo = new System.Windows.Forms.TextBox();
            this.cbAreaSelection = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btAreaSelection = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btWeatherImageGet = new System.Windows.Forms.Button();
            this.tbToday = new System.Windows.Forms.TextBox();
            this.btWeatherGet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tbWeatherInfo
            // 
            this.tbWeatherInfo.BackColor = System.Drawing.Color.AliceBlue;
            this.tbWeatherInfo.Location = new System.Drawing.Point(201, 327);
            this.tbWeatherInfo.Multiline = true;
            this.tbWeatherInfo.Name = "tbWeatherInfo";
            this.tbWeatherInfo.Size = new System.Drawing.Size(730, 93);
            this.tbWeatherInfo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label1.Location = new System.Drawing.Point(202, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "概況(7日間)";
            // 
            // tbAreaInfo
            // 
            this.tbAreaInfo.BackColor = System.Drawing.Color.AliceBlue;
            this.tbAreaInfo.Location = new System.Drawing.Point(201, 38);
            this.tbAreaInfo.Multiline = true;
            this.tbAreaInfo.Name = "tbAreaInfo";
            this.tbAreaInfo.Size = new System.Drawing.Size(726, 191);
            this.tbAreaInfo.TabIndex = 0;
            // 
            // cbAreaSelection
            // 
            this.cbAreaSelection.FormattingEnabled = true;
            this.cbAreaSelection.Location = new System.Drawing.Point(5, 79);
            this.cbAreaSelection.Name = "cbAreaSelection";
            this.cbAreaSelection.Size = new System.Drawing.Size(190, 20);
            this.cbAreaSelection.TabIndex = 5;
            this.cbAreaSelection.Click += new System.EventHandler(this.cbAreaSelection_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "地域選択";
            // 
            // btAreaSelection
            // 
            this.btAreaSelection.BackColor = System.Drawing.Color.Azure;
            this.btAreaSelection.Location = new System.Drawing.Point(5, 105);
            this.btAreaSelection.Name = "btAreaSelection";
            this.btAreaSelection.Size = new System.Drawing.Size(190, 43);
            this.btAreaSelection.TabIndex = 1;
            this.btAreaSelection.Text = "取得";
            this.btAreaSelection.UseVisualStyleBackColor = false;
            this.btAreaSelection.Click += new System.EventHandler(this.btAreaSelection_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label3.Location = new System.Drawing.Point(202, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "天気";
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(816, 116);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(101, 98);
            this.pbImage.TabIndex = 7;
            this.pbImage.TabStop = false;
            // 
            // btWeatherImageGet
            // 
            this.btWeatherImageGet.BackColor = System.Drawing.Color.Azure;
            this.btWeatherImageGet.Location = new System.Drawing.Point(101, 192);
            this.btWeatherImageGet.Name = "btWeatherImageGet";
            this.btWeatherImageGet.Size = new System.Drawing.Size(100, 37);
            this.btWeatherImageGet.TabIndex = 8;
            this.btWeatherImageGet.Text = "天気イメージ取得";
            this.btWeatherImageGet.UseVisualStyleBackColor = false;
            this.btWeatherImageGet.Click += new System.EventHandler(this.btWeatherImageGet_Click);
            // 
            // tbToday
            // 
            this.tbToday.Location = new System.Drawing.Point(64, 0);
            this.tbToday.Multiline = true;
            this.tbToday.Name = "tbToday";
            this.tbToday.Size = new System.Drawing.Size(125, 21);
            this.tbToday.TabIndex = 9;
            // 
            // btWeatherGet
            // 
            this.btWeatherGet.BackColor = System.Drawing.Color.Azure;
            this.btWeatherGet.Location = new System.Drawing.Point(7, 327);
            this.btWeatherGet.Name = "btWeatherGet";
            this.btWeatherGet.Size = new System.Drawing.Size(188, 41);
            this.btWeatherGet.TabIndex = 1;
            this.btWeatherGet.Text = "取得";
            this.btWeatherGet.UseVisualStyleBackColor = false;
            this.btWeatherGet.Click += new System.EventHandler(this.btWeatherGet_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "更新日時";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(966, 437);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbToday);
            this.Controls.Add(this.btWeatherImageGet);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAreaSelection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAreaSelection);
            this.Controls.Add(this.btWeatherGet);
            this.Controls.Add(this.tbAreaInfo);
            this.Controls.Add(this.tbWeatherInfo);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWeatherInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAreaInfo;
        private System.Windows.Forms.ComboBox cbAreaSelection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAreaSelection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btWeatherImageGet;
        private System.Windows.Forms.TextBox tbToday;
        private System.Windows.Forms.Button btWeatherGet;
        private System.Windows.Forms.Label label6;
    }
}

