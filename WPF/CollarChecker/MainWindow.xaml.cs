﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Drawing;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Reflection;

namespace CollarChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        MyColor mycolor;
        

        public MainWindow() {
            InitializeComponent();
            DataContext = GetColorList(); //←追加
            
        }
        private void Window_Loaded(object sender, RoutedEventArgs e) {
            SetCollar();
        }

        private void SetCollar() {
            var rr = (byte)sl1.Value;
            var gg = (byte)sl2.Value;
            var bb = (byte)sl3.Value;

            Color color = Color.FromRgb(rr, gg, bb);
            SolidColorBrush colorBrush = new SolidColorBrush(color);
            label1.Background = colorBrush;
        }

        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void sl_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            SetCollar();
        }

        public class MyColor {
            public Color Color { get; set; }
            public string Name { get; set; }

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            //color = mycolor.Color;
            //name = mycolor.Name;

            sl1.Value = mycolor.Color.R;
            sl2.Value = mycolor.Color.G;
            sl3.Value = mycolor.Color.B;
            SetCollar();
        }


        private void StockButton_Click(object sender, RoutedEventArgs e) {
            var colorList = new List<MyColor>();
            StockList.Items.Add("R:" + Rtext.Text + "G:" + Gtext.Text + "B:" + Btext);

            MyColor stColor = new MyColor();
            byte r = byte.Parse(Rtext.Text);
            byte g = byte.Parse(Gtext.Text);
            byte b = byte.Parse(Btext.Text);

            stColor.Color = Color.FromRgb(r, g, b);
            colorList.Add(stColor);

        }
    }
}