
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
            this.btWeatherGet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAreaInfo = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cbAreaSelection = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btAreaSelection = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbWeatherInfo
            // 
            this.tbWeatherInfo.Location = new System.Drawing.Point(203, 34);
            this.tbWeatherInfo.Multiline = true;
            this.tbWeatherInfo.Name = "tbWeatherInfo";
            this.tbWeatherInfo.Size = new System.Drawing.Size(624, 189);
            this.tbWeatherInfo.TabIndex = 0;
            // 
            // btWeatherGet
            // 
            this.btWeatherGet.Location = new System.Drawing.Point(101, 34);
            this.btWeatherGet.Name = "btWeatherGet";
            this.btWeatherGet.Size = new System.Drawing.Size(96, 43);
            this.btWeatherGet.TabIndex = 1;
            this.btWeatherGet.Text = "取得";
            this.btWeatherGet.UseVisualStyleBackColor = true;
            this.btWeatherGet.Click += new System.EventHandler(this.btWeatherGet_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label1.Location = new System.Drawing.Point(198, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "概況(7日間)";
            // 
            // tbAreaInfo
            // 
            this.tbAreaInfo.Location = new System.Drawing.Point(203, 254);
            this.tbAreaInfo.Multiline = true;
            this.tbAreaInfo.Name = "tbAreaInfo";
            this.tbAreaInfo.Size = new System.Drawing.Size(624, 189);
            this.tbAreaInfo.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(203, 467);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(624, 189);
            this.textBox2.TabIndex = 0;
            // 
            // cbAreaSelection
            // 
            this.cbAreaSelection.FormattingEnabled = true;
            this.cbAreaSelection.Location = new System.Drawing.Point(7, 266);
            this.cbAreaSelection.Name = "cbAreaSelection";
            this.cbAreaSelection.Size = new System.Drawing.Size(190, 20);
            this.cbAreaSelection.TabIndex = 5;
            this.cbAreaSelection.Click += new System.EventHandler(this.cbAreaSelection_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label2.Location = new System.Drawing.Point(3, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "地域選択";
            // 
            // btAreaSelection
            // 
            this.btAreaSelection.Location = new System.Drawing.Point(101, 292);
            this.btAreaSelection.Name = "btAreaSelection";
            this.btAreaSelection.Size = new System.Drawing.Size(96, 43);
            this.btAreaSelection.TabIndex = 1;
            this.btAreaSelection.Text = "取得";
            this.btAreaSelection.UseVisualStyleBackColor = true;
            this.btAreaSelection.Click += new System.EventHandler(this.btAreaSelection_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label3.Location = new System.Drawing.Point(198, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "選択した地域の天気";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 893);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAreaSelection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAreaSelection);
            this.Controls.Add(this.btWeatherGet);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tbAreaInfo);
            this.Controls.Add(this.tbWeatherInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWeatherInfo;
        private System.Windows.Forms.Button btWeatherGet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAreaInfo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cbAreaSelection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAreaSelection;
        private System.Windows.Forms.Label label3;
    }
}

