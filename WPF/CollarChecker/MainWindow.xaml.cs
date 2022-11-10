using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CollarChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {

        List<MyColor> colorList = new List<MyColor>();
        MyColor myColor = new MyColor();
        public MainWindow() {
            InitializeComponent();

            DataContext = GetColorList();
        }

        /// <summary>
        /// すべての色を取得するメソッド
        /// </summary>
        /// <returns></returns>
        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            setColor();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            setColor(); //起動時に初期状態の設定値（R:0 G:0 B:0）から色を設定
        }

        //テキストボックスの値を元に色を設定
        private void setColor() {
            var r = byte.Parse(rValue.Text);
            var g = byte.Parse(gValue.Text);
            var b = byte.Parse(bValue.Text);
            colorArea.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var mycolor = (MyColor)((ComboBox)sender).SelectedItem;

            rSlider.Value = mycolor.Color.R;
            gSlider.Value = mycolor.Color.G;
            bSlider.Value = mycolor.Color.B;
            setColor();
        }

        private void stockButton_Click(object sender, RoutedEventArgs e) {
            //stockList.Items.Add(" R: "+ rValue.Text +" G: "+ gValue.Text +" B: "+ bValue.Text);

            MyColor stColor = new MyColor();
            var r = byte.Parse(rValue.Text);
            var g = byte.Parse(gValue.Text);
            var b = byte.Parse(bValue.Text);

            stColor.Color = Color.FromRgb(r, g, b);

            var colorName = ((IEnumerable<MyColor>)DataContext)
                .Where(c => c.Color.R == stColor.Color.R &&
                             c.Color.G == stColor.Color.G &&
                             c.Color.B == stColor.Color.B).FirstOrDefault();

            stockList.Items.Insert(0, colorName?.Name ?? " R: " + r + " G: " + g + " B: " + b);
            colorList.Insert(0, stColor);
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e) {
            //選択項目がない場合は処理せず戻し
            if (stockList.SelectedItems.Count == 0) {
                stockList.Items.RemoveAt(0);
            }
            return;
            //stockList.Items.RemoveAt(stockList.SelectedIndex);
        }

        private void stockList_SelectionChanged(object sender, SelectedCellsChangedEventArgs e) {
            rSlider.Value = colorList[stockList.SelectedIndex].Color.R;
            gSlider.Value = colorList[stockList.SelectedIndex].Color.G;
            bSlider.Value = colorList[stockList.SelectedIndex].Color.B;
            setColor();
        }
    }

    /// <summary>
    /// 色と色名を保持するクラス
    /// </summary>
    public class MyColor {
        public Color Color { get; set; }
        public string Name { get; set; }
    }
}