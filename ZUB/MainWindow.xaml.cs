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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ZUB
{
    public partial class MainWindow : Window
    {
        private void ChangeEffectEnter1()
        {
            rectangle1.Fill = new SolidColorBrush(Color.FromRgb(90, 180, 255));
            rectangle1.Stroke = new SolidColorBrush(Color.FromRgb(90, 180, 255));
        }

        private void ChangeEffectLeave1()
        {
            rectangle1.Fill = new SolidColorBrush(Color.FromRgb(118, 205, 216));
            rectangle1.Stroke = new SolidColorBrush(Color.FromRgb(118, 205, 216));
        }

        private void ChangeEffectEnter2()
        {
            rectangle2.Fill = new SolidColorBrush(Color.FromRgb(90, 180, 255));
            rectangle2.Stroke = new SolidColorBrush(Color.FromRgb(90, 180, 255));
        }

        private void ChangeEffectLeave2()
        {
            rectangle2.Fill = new SolidColorBrush(Color.FromRgb(118, 205, 216));
            rectangle2.Stroke = new SolidColorBrush(Color.FromRgb(118, 205, 216));
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, MouseEventArgs e) { ChangeEffectEnter1(); }
        private void button1_MouseLeave(object sender, MouseEventArgs e) { ChangeEffectLeave1(); }
        private void button2_MouseEnter(object sender, MouseEventArgs e) { ChangeEffectEnter2(); }
        private void button2_MouseLeave(object sender, MouseEventArgs e) { ChangeEffectLeave2(); }
        private void button1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ZUBGeometry zubGeometry = new ZUBGeometry();
            zubGeometry.Show();
            this.Close();
        }

        private void button2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ZUBCheckup zubCheck = new ZUBCheckup();
            zubCheck.Show();
        }       


    }
}
