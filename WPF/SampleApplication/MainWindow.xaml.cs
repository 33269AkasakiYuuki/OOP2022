﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SampleApplication {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            seasonComboBox.SelectedIndex = getSeasonIndex;
        }

        private int getSeasonIndex() {
            var today = DateTime.Now;
            int ret =((int)today.Month)/3-1
            return ret;
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e) {
            checkTextBoxBlock.Text = "チェック済み";
        }

        private void checkBox_Unchecked(object sender, RoutedEventArgs e) {
            checkTextBoxBlock.Text = "未チェック";
        }

        private void redRadioButton_Checked(object sender, RoutedEventArgs e) {
            colorTextBok.Text = "赤";
        }

        private void yellRadioButton_Checked(object sender, RoutedEventArgs e) {
            colorTextBok.Text = "黄";
        }

        private void blueRadioButton_Checked(object sender, RoutedEventArgs e) {
            colorTextBok.Text = "青";
        }

        private void seasonComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            seasonTextBlock.Text = (string)((ComboBoxItem)
                seasonComboBox.SelectedItem).Content;
        }
    }
}
