
namespace Sample0607 {
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
            this.btRamdom = new System.Windows.Forms.Button();
            this.Number = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            this.SuspendLayout();
            // 
            // btRamdom
            // 
            this.btRamdom.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btRamdom.Location = new System.Drawing.Point(544, 59);
            this.btRamdom.Name = "btRamdom";
            this.btRamdom.Size = new System.Drawing.Size(151, 50);
            this.btRamdom.TabIndex = 0;
            this.btRamdom.Text = "乱数取得";
            this.btRamdom.UseVisualStyleBackColor = true;
            this.btRamdom.Click += new System.EventHandler(this.btRamdom_Click);
            // 
            // Number
            // 
            this.Number.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Number.Location = new System.Drawing.Point(56, 38);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(461, 71);
            this.Number.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // nudMax
            // 
            this.nudMax.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudMax.Location = new System.Drawing.Point(186, 279);
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(246, 71);
            this.nudMax.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(75, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "最小値";
            // 
            // nudMin
            // 
            this.nudMin.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudMin.Location = new System.Drawing.Point(186, 202);
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(246, 71);
            this.nudMin.TabIndex = 1;
            this.nudMin.ValueChanged += new System.EventHandler(this.nudMin_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(75, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "最大値";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(809, 509);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudMin);
            this.Controls.Add(this.nudMax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.btRamdom);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "乱数アプリ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRamdom;
        private System.Windows.Forms.NumericUpDown Number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.Label label4;
    }
}

