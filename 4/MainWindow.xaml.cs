using System;
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

namespace _4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDouble = rateDollar* sumDollar;
            resSum.Text = resDouble.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double lateEuro = Convert.ToDouble(late.Text);
            double lumEuro = Convert.ToDouble(lum.Text);
            double resDouble = lateEuro* lumEuro;
            resLum.Text = resDouble.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double pateGrivna = Convert.ToDouble(pate.Text);
            double pumGrivna = Convert.ToDouble(pum.Text);
            double resDouble = pateGrivna* pumGrivna;
            resPum.Text = resDouble.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double gateDram = Convert.ToDouble(gate.Text);
            double gumDram = Convert.ToDouble(gum.Text);
            double resDouble = gateDram* gumDram;
            resGum.Text = resDouble.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double wateDum = Convert.ToDouble(wate.Text);
            double resDouble = wateDum*0.0254;
            resWum.Text = resDouble.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double qateDum = Convert.ToDouble(qate.Text);
            double resDouble = qateDum * 0.3048;
            resQum.Text = resDouble.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double tateDum = Convert.ToDouble(tate.Text);
            double resDouble = tateDum * 0.000621371;
            resTum.Text = resDouble.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double dateDum = Convert.ToDouble(date.Text);
            double resDouble = dateDum * 0.000937383;
            resDum.Text = resDouble.ToString();
        }
    }
}
