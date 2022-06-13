﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class Form1 : Form
    {
        //住所データ管理用リスト
        BindingList<Person> listPerson = new BindingList<Person>();

        public Form1()
        {
            InitializeComponent();
            dgvPersons.DataSource = listPerson;
        }

        private void btPictureOpen_Click(object sender, EventArgs e)
        {
            if(ofdFileOpenDialog.ShowDialog() == DialogResult.OK)
            {
                pbPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);


            }
              
        }

        private void btAddPerson_Click(object sender, EventArgs e)
        {
            Person newPerson = new Person
            {
                Name = tbName.Text,
                MailAddress = tbMailAddress.Text,
                Address = tbAddress.Text,
                Company = tbCompany.Text,
                Picture = pbPicture.Image,
                listGroup = GetCheckBoxGroup(),
            };
            if(tbName.Text != "") {
                listPerson.Add(newPerson);
            }
            else {
                MessageBox.Show("名前を入力してください",
                "エラー",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Hand);
            }
            //追加ボタンが押されたら削除を有効にする
            if (dgvPersons != null) {
                btDelete.Enabled = true;
            }
            else {
                MessageBox.Show("",
                "エラー",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Hand);
            }


        }

        //チェックボックスにセットされている値をリストとして取り出す
        private List<Person.GroupType> GetCheckBoxGroup()
        {
            var listGroup = new List<Person.GroupType>();
            if (cbFamily.Checked)
            {
                listGroup.Add(Person.GroupType.家族);
            }
            if(cbFriend.Checked)
            {
                listGroup.Add(Person.GroupType.友人);
            }
            if (cbWork.Checked)
            {
                listGroup.Add(Person.GroupType.仕事);
            }
            if (cbOther.Checked)
            {
                listGroup.Add(Person.GroupType.その他);
            }
            return listGroup;
        }

        private void btPictureClear_Click(object sender, EventArgs e)
        {
            pbPicture.Image = null;
        }

        //データグリッドビューをクリックした時のイベントハンドラ
        private void dgvPersons_Click(object sender, EventArgs e)
        {
            if (dgvPersons.CurrentRow == null) return;

            int index = dgvPersons.CurrentRow.Index;

            tbName.Text = listPerson[index].Name;
            tbMailAddress.Text = listPerson[index].MailAddress;
            tbAddress.Text = listPerson[index].Address;
            tbCompany.Text = listPerson[index].Company;
            pbPicture.Image = listPerson[index].Picture;

            

            groupCheckBoxAllClear();    //グループチェックボックスをい一旦初期化

            foreach (var group in listPerson[index].listGroup)
            {
                switch (group)
                {
                    case Person.GroupType.家族:
                        cbFamily.Checked = true;
                        break;
                    case Person.GroupType.友人:
                        cbFriend.Checked = true;
                        break;
                    case Person.GroupType.仕事:
                        cbWork.Checked = true;
                        break;
                    case Person.GroupType.その他:
                        cbOther.Checked = true;
                        break;
                    default:
                        break;
                }
            }
        }

        //グループのチェックボックスをオールクリア
        private void groupCheckBoxAllClear()
        {
            cbFamily.Checked = cbFriend.Checked = cbWork.Checked = cbOther.Checked = false;
        }

        private void dgvPersons_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        //更新ボタンが押された時の処理
        private void btUpdate_Click(object sender, EventArgs e) {

          
            listPerson[dgvPersons.CurrentRow.Index].Name = tbName.Text;
            listPerson[dgvPersons.CurrentRow.Index].MailAddress = tbMailAddress.Text;
            listPerson[dgvPersons.CurrentRow.Index].Address = tbAddress.Text;
            listPerson[dgvPersons.CurrentRow.Index].Company = tbCompany.Text;
            listPerson[dgvPersons.CurrentRow.Index].Picture = pbPicture.Image;
            listPerson[dgvPersons.CurrentRow.Index].listGroup = GetCheckBoxGroup();

            dgvPersons.Refresh(); //データグリッドビュー更新



        }

        private void btDelete_Click_1(object sender, EventArgs e) {
            int index = dgvPersons.CurrentRow.Index;
            dgvPersons.Rows.RemoveAt(index);
            
        }

        private void Form1_Load(object sender, EventArgs e) {
            btDelete.Enabled = false;//削除ボタンをマスク
        
            }
        }
 }

