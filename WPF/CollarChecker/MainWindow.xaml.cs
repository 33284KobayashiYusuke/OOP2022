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

namespace CollarChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();


        }

        private void ChangeCollar() {
            byte rr = (byte)sl1.Value;
            byte gg = (byte)sl2.Value;
            byte bb = (byte)sl3.Value;
            Color color = Color.FromRgb(rr, gg, bb);
            SolidColorBrush colorBrush = new SolidColorBrush(color);
            label1.Background = colorBrush;
        }

        private void sl1_ValueChanged(object sender,RoutedPropertyChangedEventArgs<double> e) {
            ChangeCollar();
        }
        private void sl2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            ChangeCollar();
        }
        private void sl3_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            ChangeCollar();
        }
    }
    public class MyColor {
        public Color Color { get; set; }
        public string Name { get; set; }
    }
}
