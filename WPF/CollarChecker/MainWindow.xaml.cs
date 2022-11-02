using System;
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
        MyColor mycolor  

        public MainWindow() {
            InitializeComponent();
            DataContext = GetColorList(); //←追加
        }
        private void Window_Loaded(object sender, RoutedEventArgs e) {
            ChangeCollar();
        }

        private void ChangeCollar() {
            byte rr = (byte)sl1.Value;
            byte gg = (byte)sl2.Value;
            byte bb = (byte)sl3.Value;

            Color color = Color.FromRgb(rr, gg, bb);
            SolidColorBrush colorBrush = new SolidColorBrush(color);
            label1.Background = colorBrush;
        }

        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void sl_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            ChangeCollar();
        }

        public class MyColor {
            public Color Color { get; set; }
            public string Name { get; set; }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            //var color = mycolor.Color;
            //var name = mycolor.Name;
            sl1.Value = mycolor.Color.R;
            sl2.Value = mycolor.Color.G;
            sl3.Value = mycolor.Color.B;
        }

      
        private void StockButton_Click(object sender, RoutedEventArgs e) {

        }
    }
}
