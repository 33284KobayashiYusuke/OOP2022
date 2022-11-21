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
        private void Form1_Load(object sender, EventArgs e) {

            StreamReader sr = new StreamReader(@"C:\Users\infosys\source\repos\OOP2022\Chapter14\WeatherApp\areacode.csv", System.Text.Encoding.GetEncoding("shift_jis"));
            String line = sr.ReadLine();

            while (!sr.EndOfStream) {
                cbAreaSelection.Items.Add(line);
                line = sr.ReadLine();
            }

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
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };
            switch (cbAreaSelection.Text) {
                case "宗谷地方,011000":
                    var area1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/011000.json");
                    var json1 = JsonConvert.DeserializeObject<_011000>(area1);
                    tbAreaInfo.Text = json1.text;
                    break;
                case "上川・留萌地方,012000":
                    var area2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/012000.json");
                    var json2 = JsonConvert.DeserializeObject<_012000>(area2);
                    tbAreaInfo.Text = json2.text;
                    break;
                case "網走・北見・紋別地方,013000":
                    var area3 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/013000.json");
                    var json3 = JsonConvert.DeserializeObject<_013000>(area3);
                    tbAreaInfo.Text = json3.text;
                    break;
                case "十勝地方,014030":
                    var area4 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/014100.json");
                    var json4 = JsonConvert.DeserializeObject<_014100>(area4);
                    tbAreaInfo.Text = json4.text;
                    break;
                case "釧路・根室地方,014100":
                    var area5 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/014100.json");
                    var json5 = JsonConvert.DeserializeObject<_014100>(area5);
                    tbAreaInfo.Text = json5.text;
                    break;
                case "胆振・日高地方,015000":
                    var area6 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/015000.json");
                    var json6 = JsonConvert.DeserializeObject<_015000>(area6);
                    tbAreaInfo.Text = json6.text;
                    break;
                case "石狩・空知・後志地方,016000":
                    var area7 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/016000.json");
                    var json7 = JsonConvert.DeserializeObject<_016000>(area7);
                    tbAreaInfo.Text = json7.text;
                    break;
                case "渡島・檜山地方,017000":
                    var area8 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/017000.json");
                    var json8 = JsonConvert.DeserializeObject<_017000>(area8);
                    tbAreaInfo.Text = json8.text;
                    break;
                case "青森県,020000":
                    var area9 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/020000.json");
                    var json9 = JsonConvert.DeserializeObject<_020000>(area9);
                    tbAreaInfo.Text = json9.text;
                    break;
                case "岩手県,030000":
                    var area10 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/030000.json");
                    var json10 = JsonConvert.DeserializeObject<_030000>(area10);
                    tbAreaInfo.Text = json10.text;
                    break;
                case "宮城県,040000":
                    var area11 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/040000.json");
                    var json11 = JsonConvert.DeserializeObject<_040000>(area11);
                    tbAreaInfo.Text = json11.text;
                    break;
                case "秋田県,050000":
                    var area12 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/050000.json");
                    var json12 = JsonConvert.DeserializeObject<_050000>(area12);
                    tbAreaInfo.Text = json12.text;
                    break;
                case "山形県,060000":
                    var area13 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/060000.json");
                    var json13 = JsonConvert.DeserializeObject<_060000>(area13);
                    tbAreaInfo.Text = json13.text;
                    break;
                case "福島県,070000":
                    var area = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/070000.json");
                    var json = JsonConvert.DeserializeObject<_070000>(area);
                    tbAreaInfo.Text = json.text;
                    break;
                case "茨城県,080000":
                    var area14 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/080000.json");
                    var json14 = JsonConvert.DeserializeObject<_080000>(area14);
                    tbAreaInfo.Text = json14.text;
                    break;
                case "栃木県,090000":
                    var area15 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/090000.json");
                    var json15 = JsonConvert.DeserializeObject<_090000>(area15);
                    tbAreaInfo.Text = json15.text;
                    break;
                case "群馬県,100000":
                    var area16 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/100000.json");
                    var json16 = JsonConvert.DeserializeObject<_100000>(area16);
                    tbAreaInfo.Text = json16.text;
                    break;
                case "埼玉県,110000":
                    var area17 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/110000.json");
                    var json17 = JsonConvert.DeserializeObject<_110000>(area17);
                    tbAreaInfo.Text = json17.text;
                    break;
                case "千葉県,120000":
                    var area18 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/120000.json");
                    var json18 = JsonConvert.DeserializeObject<_120000>(area18);
                    tbAreaInfo.Text = json18.text;
                    break;
                case "東京都,130000":
                    var area19 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/130000.json");
                    var json19 = JsonConvert.DeserializeObject<_130000>(area19);
                    tbAreaInfo.Text = json19.text;
                    break;
                case "神奈川県,140000":
                    var area20 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/140000.json");
                    var json20 = JsonConvert.DeserializeObject<_140000>(area20);
                    tbAreaInfo.Text = json20.text;
                    break;
                case "山梨県,190000":
                    var area21 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/190000.json");
                    var json21 = JsonConvert.DeserializeObject<_190000>(area21);
                    tbAreaInfo.Text = json21.text;
                    break;
                case "長野県,200000":
                    var area22 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/200000.json");
                    var json22 = JsonConvert.DeserializeObject<_200000>(area22);
                    tbAreaInfo.Text = json22.text;
                    break;
                case "岐阜県,210000":
                    var area23 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/210000.json");
                    var json23 = JsonConvert.DeserializeObject<_210000>(area23);
                    tbAreaInfo.Text = json23.text;
                    break;
                case "静岡県,220000":
                    var area24 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/220000.json");
                    var json24 = JsonConvert.DeserializeObject<_220000>(area24);
                    tbAreaInfo.Text = json24.text;
                    break;
                case "愛知県,230000":
                    var area25 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/230000.json");
                    var json25 = JsonConvert.DeserializeObject<_230000>(area25);
                    tbAreaInfo.Text = json25.text;
                    break;
                case "三重県,240000":
                    var area26 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/240000.json");
                    var json26 = JsonConvert.DeserializeObject<_240000>(area26);
                    tbAreaInfo.Text = json26.text;
                    break;
                case "新潟県,150000":
                    var area27 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/150000.json");
                    var json27 = JsonConvert.DeserializeObject<_150000>(area27);
                    tbAreaInfo.Text = json27.text;
                    break;
                case "富山県,160000":
                    var area28 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/160000.json");
                    var json28 = JsonConvert.DeserializeObject<_160000>(area28);
                    tbAreaInfo.Text = json28.text;
                    break;
                case "石川県,170000":
                    var area29 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/170000.json");
                    var json29 = JsonConvert.DeserializeObject<_170000>(area29);
                    tbAreaInfo.Text = json29.text;
                    break;
                case "福井県,180000":
                    var area30 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/180000.json");
                    var json30 = JsonConvert.DeserializeObject<_180000>(area30);
                    tbAreaInfo.Text = json30.text;
                    break;
                case "滋賀県,250000":
                    var area31 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/250000.json");
                    var json31 = JsonConvert.DeserializeObject<_250000>(area31);
                    tbAreaInfo.Text = json31.text;
                    break;
                case "京都府,260000":
                    var area32 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/260000.json");
                    var json32 = JsonConvert.DeserializeObject<_260000>(area32);
                    tbAreaInfo.Text = json32.text;
                    break;
                case "大阪府,270000":
                    var area33 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/270000.json");
                    var json33 = JsonConvert.DeserializeObject<_270000>(area33);
                    tbAreaInfo.Text = json33.text;
                    break;
                case "兵庫県,280000":
                    var area34 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/280000.json");
                    var json34 = JsonConvert.DeserializeObject<_280000>(area34);
                    tbAreaInfo.Text = json34.text;
                    break;
                case "奈良県,290000":
                    var area35 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/290000.json");
                    var json35 = JsonConvert.DeserializeObject<_290000>(area35);
                    tbAreaInfo.Text = json35.text;
                    break;
                case "和歌山県,300000":
                    var area36 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/300000.json");
                    var json36 = JsonConvert.DeserializeObject<_300000>(area36);
                    tbAreaInfo.Text = json36.text;
                    break;
                case "鳥取県,310000":
                    var area37 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/310000.json");
                    var json37 = JsonConvert.DeserializeObject<_310000>(area37);
                    tbAreaInfo.Text = json37.text;
                    break;
                case "島根県,320000":
                    var area38 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/320000.json");
                    var json38 = JsonConvert.DeserializeObject<_320000>(area38);
                    tbAreaInfo.Text = json38.text;
                    break;
                case "岡山県,330000":
                    var area39 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/330000.json");
                    var json39 = JsonConvert.DeserializeObject<_330000>(area39);
                    tbAreaInfo.Text = json39.text;
                    break;
                case "広島県,340000":
                    var area40 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/340000.json");
                    var json40 = JsonConvert.DeserializeObject<_340000>(area40);
                    tbAreaInfo.Text = json40.text;
                    break;
                case "徳島県,360000":
                    var area41 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/360000.json");
                    var json41 = JsonConvert.DeserializeObject<_360000>(area41);
                    tbAreaInfo.Text = json41.text;
                    break;
                case "香川県,370000":
                    var area42 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/370000.json");
                    var json42 = JsonConvert.DeserializeObject<_370000>(area42);
                    tbAreaInfo.Text = json42.text;
                    break;
                case "愛媛県,380000":
                    var area43 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/380000.json");
                    var json43 = JsonConvert.DeserializeObject<_380000>(area43);
                    tbAreaInfo.Text = json43.text;
                    break;
                case "高知県,390000":
                    var area44 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/390000.json");
                    var json44 = JsonConvert.DeserializeObject<_390000>(area44);
                    tbAreaInfo.Text = json44.text;
                    break;
                case "山口県,350000":
                    var area45 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/350000.json");
                    var json45 = JsonConvert.DeserializeObject<_350000>(area45);
                    tbAreaInfo.Text = json45.text;
                    break;
                case "福岡県,400000":
                    var area46 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/400000.json");
                    var json46 = JsonConvert.DeserializeObject<_400000>(area46);
                    tbAreaInfo.Text = json46.text;
                    break;
                case "佐賀県,410000":
                    var area47 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/410000.json");
                    var json47 = JsonConvert.DeserializeObject<_410000>(area47);
                    tbAreaInfo.Text = json47.text;
                    break;
                case "長崎県,420000":
                    var area48 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/420000.json");
                    var json48 = JsonConvert.DeserializeObject<_420000>(area48);
                    tbAreaInfo.Text = json48.text;
                    break;
                case "熊本県,430000":
                    var area49 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/430000.json");
                    var json49 = JsonConvert.DeserializeObject<_430000>(area49);
                    tbAreaInfo.Text = json49.text;
                    break;
                case "大分県,440000":
                    var area50 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/440000.json");
                    var json50 = JsonConvert.DeserializeObject<_440000>(area50);
                    tbAreaInfo.Text = json50.text;
                    break;
                case "宮崎県,450000":
                    var area51 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/450000.json");
                    var json51 = JsonConvert.DeserializeObject<_450000>(area51);
                    tbAreaInfo.Text = json51.text;
                    break;
                case "奄美地方,460040":
                    var area52 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/460040.json");
                    var json52 = JsonConvert.DeserializeObject<_460040>(area52);
                    tbAreaInfo.Text = json52.text;
                    break;
                case "鹿児島県（奄美地方除く）,460100":
                    var area53 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/460100.json");
                    var json53 = JsonConvert.DeserializeObject<_460100>(area53);
                    tbAreaInfo.Text = json53.text;
                    break;
                case "沖縄本島地方,471000":
                    var area54 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/471000.json");
                    var json54 = JsonConvert.DeserializeObject<_471000>(area54);
                    tbAreaInfo.Text = json54.text;
                    break;
                case "大東島地方,472000":
                    var area55 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/472000.json");
                    var json55 = JsonConvert.DeserializeObject<_472000>(area55);
                    tbAreaInfo.Text = json55.text;
                    break;
                case "宮古島地方,473000":
                    var area56 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/473000.json");
                    var json56 = JsonConvert.DeserializeObject<_473000>(area56);
                    tbAreaInfo.Text = json56.text;
                    break;
                case "八重山地方,474000":
                    var area57 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/474000.json");
                    var json57 = JsonConvert.DeserializeObject<_474000>(area57);
                    tbAreaInfo.Text = json57.text;
                    break;
              
            }
        }

        private void cbAreaSelection_Click(object sender, EventArgs e) {

        }

        private void btWeatherImageGet_Click(object sender, EventArgs e) {

            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };
            //var dString = wc.DownloadString(cbAreaSelection.);
            //var json = JsonConvert.DeserializeObject<Rootobject>(dString);

            pbImage.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
        }

       

    
    }
}
