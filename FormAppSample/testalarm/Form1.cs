using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testalarm {
    public partial class Form1 : Form {
        Timer timer;
        Label timeLabel;
        DateTime dt;

        public Form1() {
            InitializeComponent();
            this.Size = new Size(300, 300);
            this.Load += Form1_Load;
        }
        private void Form1_Load(object sender, EventArgs e) {
            timeLabel = new Label();
            timeLabel.Location = new Point(10, 10);
            timeLabel.AutoSize = true;
            dt = DateTime.Now;
            timeLabel.Text = string.Format("日時\r\n{0:0000}/{1:00}/{2:00} {3:00}:{4:00}:{5:00}", dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second);
     
            timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Tick += Timer_Tick;


            this.Controls.Add(timeLabel);
        }


        private void Timer_Tick(object sender, EventArgs e) {
            dt = DateTime.Now;
            timeLabel.Text = string.Format("日時\r\n{0:0000}/{1:00}/{2:00} {3:00}:{4:00}:{5:00}", dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second);
        }
    }
}