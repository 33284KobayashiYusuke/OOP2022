using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btWeatherGet_Click(object sender, EventArgs e) {

            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };
            var dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_week/130000.json");
            var json = JsonConvert.DeserializeObject<Rootobject>(dString);

            tbWeatherInfo.Text = json.text;

        }

        private void btAreaSelection_Click(object sender, EventArgs e) {

        }

        private void cbAreaSelection_Click(object sender, EventArgs e) {
         
            StreamReader sr = new StreamReader(@"C:\Users\infosys\source\repos\OOP2022\Chapter14\WeatherApp\areacode.csv",System.Text.Encoding.GetEncoding("shift_jis"));
            String line = sr.ReadLine();
           
            while (!sr.EndOfStream) {
                    cbAreaSelection.Items.Add(line);
                    line = sr.ReadLine();
            }
              
        }
    }
}
