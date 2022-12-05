using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;

namespace ZUB
{
    public partial class ZUBGeometryI : Window
    {
        public ZUBGeometryI()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, MouseEventArgs e)
        {
            rectangle1.Fill = new SolidColorBrush(Color.FromRgb(255, 30, 30));
            rectangle1.Stroke = new SolidColorBrush(Color.FromRgb(255, 30, 30));
        }

        private void button1_MouseLeave(object sender, MouseEventArgs e)
        {
            rectangle1.Fill = new SolidColorBrush(Color.FromRgb(216, 50, 59));
            rectangle1.Stroke = new SolidColorBrush(Color.FromRgb(216, 50, 59));
        }

        private void button1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow Main = new MainWindow();
            Main.Show();
            this.Close();
        }

        private void canvas1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            if (saveFile.ShowDialog() == true)
                File.WriteAllText(saveFile.FileName, textBlock1.Text);
            this.Close();
        }

        private void canvas1_MouseEnter(object sender, MouseEventArgs e)
        {
            rectangle2.Fill = new SolidColorBrush(Color.FromRgb(255, 30, 30));
            rectangle2.Stroke = new SolidColorBrush(Color.FromRgb(255, 30, 30));
        }

        private void canvas1_MouseLeave(object sender, MouseEventArgs e)
        {
            rectangle2.Fill = new SolidColorBrush(Color.FromRgb(216, 50, 59));
            rectangle2.Stroke = new SolidColorBrush(Color.FromRgb(216, 50, 59));
        }
    }
}
