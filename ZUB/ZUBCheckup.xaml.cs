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

namespace ZUB
{

    public partial class ZUBCheckup : Window
    {
        public ZUBCheckup()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, MouseEventArgs e)
        {
            rectangle1.Fill = new SolidColorBrush(Color.FromRgb(90, 180, 255));
            rectangle1.Stroke = new SolidColorBrush(Color.FromRgb(90, 180, 255));
        }

        private void button1_MouseLeave(object sender, MouseEventArgs e)
        {
            rectangle1.Fill = new SolidColorBrush(Color.FromRgb(118, 205, 216));
            rectangle1.Stroke = new SolidColorBrush(Color.FromRgb(118, 205, 216));
        }

        private void button1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                double t = double.Parse(textBox1.Text);
                int z = int.Parse(textBox2.Text);
                double m = double.Parse(textBox3.Text);
                double sigma = double.Parse(textBox4.Text);
                double sigma0 = 2 * t / (0.7 * z * m * m * z * 0.02 * 1000);
                if (sigma0 <= sigma)
                    MessageBox.Show("Условия прочности выполняются!");
                else
                    MessageBox.Show("Условия прочности не выполняются!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
