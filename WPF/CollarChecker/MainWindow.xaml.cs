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
        MyColor mycolor;
        List<MyColor> colorList = new List<MyColor>();

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
            label1.Background = new SolidColorBrush(color);
        }

        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void sl_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            SetCollar();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            sl1.Value = ((MyColor)((ComboBox)sender).SelectedItem).Color.R;
            sl2.Value = ((MyColor)((ComboBox)sender).SelectedItem).Color.G;
            sl3.Value = ((MyColor)((ComboBox)sender).SelectedItem).Color.B;
            SetCollar();
        }

        private void StockButton_Click(object sender, RoutedEventArgs e) {
            StockList.Items.Add("R:" + Rtext.Text + "G:" + Gtext.Text + "B:" + Btext.Text);

            MyColor stColor = new MyColor();
            byte r = byte.Parse(Rtext.Text);
            byte g = byte.Parse(Gtext.Text);
            byte b = byte.Parse(Btext.Text);

            stColor.Color = Color.FromRgb(r, g, b);
            var colorName = ((IEnumerable<MyColor>)DataContext)
                                .Where(c => c.Color.R == stColor.Color.R &&
                                            c.Color.G == stColor.Color.G &&
                                            c.Color.B == stColor.Color.B).FirstOrDefault();

            StockList.Items.Insert(0,colorName?.Name ?? "R:" + Rtext.Text + "G:" + Gtext.Text + "B:" + Btext);
           
            colorList.Insert(0,stColor);
        }
        private void stockList_SelectionChanged(object sender,SelectionChangedEventArgs e) {
            sl1.Value = colorList[StockList.SelectedIndex].Color.R;
            sl2.Value = colorList[StockList.SelectedIndex].Color.G;
            sl3.Value = colorList[StockList.SelectedIndex].Color.B;
            SetCollar();
        }

        public class MyColor {
            public Color Color { get; set; }
            public string Name { get; set; }

        }

        private void deleteButton_Click(object sender, RoutedEventArgs e) {
            StockList.Items.Clear();
        }
    }
}
