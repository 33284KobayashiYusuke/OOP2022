using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0603 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        //ボタンクリックイベントハンドラ
        private void btPush_Click(object sender, EventArgs e) {

            int valueLeft;
            int valueRight;
            int valueAnser;

            valueLeft = int.Parse(input1.Text);
            valueRight = int.Parse(input2.Text);

            valueAnser = valueLeft + valueRight;

            answer.Text = valueAnser.ToString();
          
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void input1_TextChanged(object sender, EventArgs e) {

        }
    }
}
