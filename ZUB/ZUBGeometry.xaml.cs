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
    public partial class ZUBGeometry : Window
    {
        public ZUBGeometry()
        {
            InitializeComponent();
        }
        private void label14_MouseEnter(object sender, MouseEventArgs e)
        {
            rectangle1.Fill = new SolidColorBrush(Color.FromRgb(90, 180, 255));
            rectangle1.Stroke = new SolidColorBrush(Color.FromRgb(90, 180, 255));
        }
        private void label14_MouseLeave(object sender, MouseEventArgs e)
        {
            rectangle1.Fill = new SolidColorBrush(Color.FromRgb(118, 205, 216));
            rectangle1.Stroke = new SolidColorBrush(Color.FromRgb(118, 205, 216));
        }
        private void label14_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                double m = double.Parse(Module.Text);
                int zcol1 = int.Parse(z1.Text);
                int zcol2 = int.Parse(z2.Text);
                double b1 = double.Parse(B1.Text);
                double b2 = double.Parse(B2.Text);
                double grad = double.Parse(Gradus.Text);
                double min = double.Parse(Minuty.Text);
                double sec = double.Parse(Secundy.Text);
                double gradpol = grad + (min / 60) + (sec / 3600);
                double sher = double.Parse(Sherohovat.Text);
                double n = double.Parse(N.Text);
                double res = double.Parse(Resurs.Text);

                double a = ((zcol1 + zcol2)*m)/(2* Math.Cos(gradpol*Math.PI/180));
                double d1 = zcol1 * m / Math.Cos(gradpol*Math.PI/180);
                double d2 = zcol2 * m / Math.Cos(gradpol*Math.PI/180);
                double u = zcol2 / zcol1;
                double da1 = d1 + 2 * m;
                double da2 = d2 + 2 * m;
                double df1 = d1 - 2 * m;
                double df2 = d2 - 2 * m;
                double sn = Math.PI * m / 2;

                ZUBGeometryI zubGeometryI = new ZUBGeometryI();
                zubGeometryI.Show();
                zubGeometryI.textBlock1.Text = String.Format(
                    "Модуль = {0:f3} мм\nКоличество зубьев шестерни = {1}\nКоличество зубьев колеса = {2}\n"
                    + "Ширина зубчатого венца шестерни = {3:f3} мм\nШирина зубчатого венца колеса = {4:f3} мм\nУгол наклона зуба = {5} град. {6} мин. {7} сек.\n" 
                    + "Межосевое расстояние = {8:f3} мм\nДелительный диаметр шестерни = {9:f3} мм\nДелительный диаметр колеса = {10:f3} мм\n"
                    + "Передаточное число = {11:f3}\nДиаметр вершин зубьев шестерни = {12:f3} мм\nДиаметр вершин зубьев колеса = {13:f3} мм\n"
                    + "Диаметр впадин зубьев шестерни = {14:f3} мм\nДиаметр впадин зубьев колеса = {15:f3} мм\n"
                    + "Нормальная толщина зуба = {16:f3} мм\n", m, zcol1, zcol2, b1, b2, grad, min, sec, a, d1, d2, u, da1, da2, df1, df2, sn);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); } 
        }

        private void button4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ZUBGraf graf = new ZUBGraf();
            graf.Show();
        }

        private void button4_MouseEnter(object sender, MouseEventArgs e)
        {
            rectangle2.Fill = new SolidColorBrush(Color.FromRgb(90, 180, 255));
            rectangle2.Stroke = new SolidColorBrush(Color.FromRgb(90, 180, 255));
        }

        private void button4_MouseLeave(object sender, MouseEventArgs e)
        {
            rectangle2.Fill = new SolidColorBrush(Color.FromRgb(118, 205, 216));
            rectangle2.Stroke = new SolidColorBrush(Color.FromRgb(118, 205, 216));
        }
    }
}
