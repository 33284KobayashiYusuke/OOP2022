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
using Color = System.Drawing.Color;

namespace CarReportSystem {
    public partial class Form1 : Form {
        BindingList<CarReport> listPerson = new BindingList<CarReport>();
        Settings settings = Settings.getInstance();
        
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
            
            
            DataRow newRow = infosys202226DataSet.CarReportDB.NewRow();
            newRow[1] = dateTimePicker1.Text;
            newRow[2] = cbName.Text;
            newRow[3] = GetRadioGroup();
            newRow[4] = cbCarName.Text;
            newRow[5] = tbReport.Text;
            newRow[6] = pdPicture.Image;
            //データセットへ新しいレコードを追加
            infosys202226DataSet.CarReportDB.Rows.Add(newRow);
            //データベース更新
            this.carReportDBTableAdapter.Update(this.infosys202226DataSet.CarReportDB);

            dgv_Parsons.Rows[dgv_Parsons.RowCount + 1].Selected = true;
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
            carReportDBBindingSource.RemoveAt(carReportDBDataGridView.CurrentRow.Index);
            EnabledCheck();//マスク処理呼び出し
        }
        private void EnabledCheck() {
           // btCorrect.Enabled = btDelete.Enabled = listPerson.Count() > 0 ? true : false;

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
            // TODO: このコード行はデータを 'infosys202226DataSet.CarReportDB' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportDBTableAdapter.Fill(this.infosys202226DataSet.CarReportDB);
           
            EnabledCheck();//マスク処理呼び出し
            try {
                using (var reader = XmlReader.Create("settings.xml")) {

                    var serializer = new XmlSerializer(typeof(Settings));
                    var settings = serializer.Deserialize(reader) as Settings;
                    BackColor = Color.FromArgb(settings.MainFormColor);
                }
            }
            catch (Exception) {
            }
        } 

        private void 色設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (cdColorDialog.ShowDialog() == DialogResult.OK) {
                this.BackColor = cdColorDialog.Color;
                settings.MainFormColor = cdColorDialog.Color.ToArgb();
            }
        }

        private void carReportDBBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202226DataSet);

        }

        private void btConnect_Click(object sender, EventArgs e) {
            this.carReportDBTableAdapter.Fill(this.infosys202226DataSet.CarReportDB);

        }

        private void btUpdate_Click(object sender, EventArgs e) {
            carReportDBDataGridView.CurrentRow.Cells[1].Value = dateTimePicker1.Text;
            carReportDBDataGridView.CurrentRow.Cells[2].Value = cbName.Text;
            carReportDBDataGridView.CurrentRow.Cells[3].Value = GetRadioGroup();
            carReportDBDataGridView.CurrentRow.Cells[4].Value = cbCarName.Text;
            carReportDBDataGridView.CurrentRow.Cells[5].Value = tbReport.Text;
            carReportDBDataGridView.CurrentRow.Cells[6].Value = ImageToByteArray(pdPicture.Image);

            //データセットの中をデータベースへ反映（保存）
            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202226DataSet);
        }
        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b) {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }
    }
}


