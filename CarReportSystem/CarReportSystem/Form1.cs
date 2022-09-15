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
using CarReportSystem.Properties;

namespace CarReportSystem {
    public partial class Form1 : Form {
      
        public Form1() {
            InitializeComponent();
            
        }

        private void btPictureOpen_Click(object sender, EventArgs e) {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                pdPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);
            }
        }

        private void btPictureDelete_Click(object sender, EventArgs e) {
            pdPicture.Image = null;
        }

        private void groupCheckBoxAllClear() {
            toyota.Checked = nissann.Checked = subaru.Checked = honnda.Checked = foreign_Car.Checked = other.Checked = false;
        }

        private string GetRadioGroup() {
            if (toyota.Checked) {
                return "トヨタ";
            }
            if (nissann.Checked) {
                return "日産";
            }
            if (subaru.Checked) {
                return "スバル";
            }
            if (honnda.Checked) {
                return "ホンダ";
            }
            if (foreign_Car.Checked) {
                return "外国車";
            }
            return "その他";
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

          //carReportDBDataGridView.Rows[carReportDBDataGridView.RowCount + 1].Selected = true;
            EnabledCheck();
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
        private void btEnd_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        
        private void Form1_FormClosed(object outfile, FormClosedEventArgs e) {          
           
        }

        private void Form1_Load(object outfile, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202226DataSet.CarReportDB' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportDBTableAdapter.Fill(this.infosys202226DataSet.CarReportDB);
            pdPicture.SizeMode = PictureBoxSizeMode.StretchImage;
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
                Settings.settings.MainFormColor = cdColorDialog.Color.ToArgb();
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

        private void btNameSerch_Click(object sender, EventArgs e) {
           carReportDBTableAdapter.FillBy(infosys202226DataSet.CarReportDB);
        }

        private void carReportDBDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e) {

        }
    }
}


