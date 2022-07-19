using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Media;

namespace CarReportSystem {
    public partial class Form1 : Form {
        BindingList<CarReport> listPerson = new BindingList<CarReport>();
        Settings settings = new Settings();
        
        public Form1() {
            InitializeComponent();
            dgv_Parsons.DataSource = listPerson;
        }

        private void btPictureOpen_Click(object sender, EventArgs e) {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                pdPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);
            }
        }

        private void btPictureDelete_Click(object sender, EventArgs e) {
            pdPicture.Image = null;
        }

        private void dgv_Parsons_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (dgv_Parsons.CurrentRow == null) return;

            int index = dgv_Parsons.CurrentRow.Index;

            cbName.Text = listPerson[index].Auther;
            tbReport.Text = listPerson[index].Report;
            cbCarName.Text = listPerson[index].CarName;
            pdPicture.Image = listPerson[index].Picture;
            dateTimePicker1.Value =
                listPerson[index].Date.Year > 1900 ? listPerson[index].Date : DateTime.Today;

            groupCheckBoxAllClear();

        }

        private void groupCheckBoxAllClear() {
            toyota.Checked = nissann.Checked = subaru.Checked = honnda.Checked = foreign_Car.Checked = other.Checked = false;
        }

        private CarReport.MakerGroup GetRadioGroup() {
            CarReport.MakerGroup Group = CarReport.MakerGroup.その他;
            if (toyota.Checked) {
                Group = CarReport.MakerGroup.トヨタ;
            }
            if (nissann.Checked) {
                Group = CarReport.MakerGroup.日産;
            }
            if (subaru.Checked) {
                Group = CarReport.MakerGroup.スバル;
            }
            if (honnda.Checked) {
                Group = CarReport.MakerGroup.ホンダ;
            }
            if (foreign_Car.Checked) {
                Group = CarReport.MakerGroup.外国車;
            }
            return Group;
        }

        private void btAdd_Click(object sender, EventArgs e) {
            //氏名が未入力なら登録しない
            if (String.IsNullOrWhiteSpace(cbName.Text)) {
                MessageBox.Show("記録者名が入力されていません");
                return;
            }
            CarReport newCarReport = new CarReport {
                Auther = cbName.Text,
                Report = tbReport.Text,
                CarName = cbCarName.Text,
                Picture = pdPicture.Image,
                Date = dateTimePicker1.Value,
                Maker = GetRadioGroup()

            };
            listPerson.Add(newCarReport);
            dgv_Parsons.Rows[dgv_Parsons.RowCount - 1].Selected = true;
            EnabledCheck();
        }

        private void btOpen_Click(object sender, EventArgs e) {

            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式で逆シリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(ofdFileOpenDialog.FileName, FileMode.Open, FileAccess.Read)) {
                        //逆シリアル化して読み込む
                        listPerson = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgv_Parsons.DataSource = null;
                        dgv_Parsons.DataSource = listPerson;
                    }

                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                cbName.Items.Clear();
                //コンボボックスへ登録
                foreach (var item in listPerson.Select(n => n.CarName)) {
                    setCbName(item);//存在する会社を登録

                }
            }
        }

        private void setCbName(string company) {

            if (!cbName.Items.Contains(company)) {
                //まだ登録されていなければ登録処理
                cbName.Items.Add(company);

            }
        }

        private void btDelete_Click(object sender, EventArgs e) {
            listPerson.RemoveAt(dgv_Parsons.CurrentRow.Index);
            EnabledCheck();//マスク処理呼び出し
        }
        private void EnabledCheck() {
            btCorrect.Enabled = btDelete.Enabled = listPerson.Count() > 0 ? true : false;

        }

        private void btSeve_Click(object sender, EventArgs e) {
            if (sfdSaveDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(sfdSaveDialog.FileName, FileMode.Create)) {
                        bf.Serialize(fs, listPerson);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btCorrect_Click(object sender, EventArgs e) {
            listPerson[dgv_Parsons.CurrentRow.Index].Date = dateTimePicker1.Value;
            listPerson[dgv_Parsons.CurrentRow.Index].Auther = cbName.Text;
            listPerson[dgv_Parsons.CurrentRow.Index].Maker = GetRadioGroup();
            listPerson[dgv_Parsons.CurrentRow.Index].CarName = cbCarName.Text;
            listPerson[dgv_Parsons.CurrentRow.Index].Report = tbReport.Text;
            listPerson[dgv_Parsons.CurrentRow.Index].Picture = pdPicture.Image;
            dgv_Parsons.Refresh(); //データグリッドビュー更新
        }

        private void btEnd_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        
        private void Form1_FormClosed(object outfile, FormClosedEventArgs e) {          
            using (var writer = XmlWriter.Create("settings.xml")) {
                var serializer = new XmlSerializer(settings.GetType());
                serializer.Serialize(writer, settings);
            }
        }

        private void Form1_Load(object outfile, EventArgs e) {
            using (var reader = XmlReader.Create("settings.xml")) {

                var serializer = new XmlSerializer(typeof(Settings));
                var settings = serializer.Deserialize(reader) as Settings;

                EnabledCheck();
            }
        }

        private void 色設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (cdColorDialog.ShowDialog() == DialogResult.OK) {
                this.BackColor = cdColorDialog.Color;
                settings.MainFormColor = "ddddddd";
            }
        }    
    }
}


