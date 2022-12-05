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
    public partial class ZUBGraf : Window
    {
        int z1, z2;
        double m;
        private void ShowGrafic()
        {
            try
            {
                canvas1.Children.Clear();
                double kx = 0.5, ky = 0.01;
                double y, betta = 0, dbetta = 0.1;
                int x0 = 30, y0 = 182; 
                while (betta <= 15)
                {
                    Line line1 = new Line();
                    line1.Stroke = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                    line1.StrokeThickness = 1;
                    y = (z1 + z2) * m / (2 * Math.Cos(betta));
                    betta += dbetta; 
                    int xe = (int)(kx * betta);
                    int ye = (int)(int)(ky * y);
                    line1.X1 = x0; 
                    line1.Y1 = y0;
                    line1.X2 = x0 + xe;
                    line1.Y2 = y0 - ye;
                    x0 += xe;
                    y0 -= ye;
                    canvas1.Children.Add(line1);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            } 
        }

        public ZUBGraf()
        {
            InitializeComponent();
        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (textBox1 != null) m = double.Parse(textBox1.Text);  
            z1 = (int)((Slider)sender).Value;
            if (textBox2 != null) textBox2.Text = "" + z1;
            ShowGrafic(); 
        }

        private void slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (textBox1 != null) m = double.Parse(textBox1.Text);  
            z2 = (int)((Slider)sender).Value;
            if (textBox3 != null) textBox3.Text = "" + z2;
            ShowGrafic();  
        }
    }
}
