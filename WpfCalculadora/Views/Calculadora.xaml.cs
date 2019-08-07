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

namespace WpfCalculadora.Views
{
    /// <summary>
    /// Interaction logic for Calculadora.xaml
    /// </summary>
    public partial class Calculadora : UserControl
    {
        double acumula = 0;
        string operacao = "";
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Sete_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "7";
            //Calculadora.Beep.Play();
        }

        private void Oito_Click_1(object sender, RoutedEventArgs e)
        {
            display.Text += "8";
        }

        private void Nove_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "9";
        }

        private void Quatro_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "4";
        }

        private void Cinco_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "5";
        }

        private void Seis_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "6";
        }

        private void Um_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "1";
        }

        private void Dois_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "2";
        }

        private void Tres_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "3";
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "0";
        }

        private void Mais_Click(object sender, RoutedEventArgs e)
        {
            if (operacao == "*" || operacao == "-" || operacao == "/")
            {
                operacao = "+";
            }
            else
            {
                acumula += double.Parse(display.Text);
                display.Text = "";
                operacao = "+";
            }
        }

        private void Igual_Click(object sender, RoutedEventArgs e)
        {
            if (operacao == "+")
            {
                acumula += double.Parse(display.Text);
                display.Text = acumula.ToString();
            }
            else if (operacao == "-")
            {
                acumula -= double.Parse(display.Text);
                display.Text = acumula.ToString();
            }
            else if (operacao == "*")
            {
                acumula *= double.Parse(display.Text);
                display.Text = acumula.ToString();
            }
            else if (operacao == "/")
            {
                if (double.Parse(display.Text) != 0)
                {
                    acumula /= double.Parse(display.Text);
                    display.Text = acumula.ToString();
                }
                else
                {
                    display.Text = "Dividindo por zero";
                }
            }
        }

        private void Virgula_Click(object sender, RoutedEventArgs e)
        {
            display.Text += ",";
        }

        private void Vezes_Click(object sender, RoutedEventArgs e)
        {
            if (operacao == "-" || operacao == "+" || operacao == "/")
            {
                operacao = "*";
            }
            else
            {
                acumula = double.Parse(display.Text);
                display.Text = "";
                operacao = "*";
            }
        }

        private void Divisao_Click(object sender, RoutedEventArgs e)
        {
            if (operacao == "*" || operacao == "+" || operacao == "-")
            {
                operacao = "/";
            }
            else
            {
                acumula = double.Parse(display.Text);
                display.Text = "";
                operacao = "/";
            }
        }

        private void MaisMenos_Click(object sender, RoutedEventArgs e)
        {
            double x = double.Parse(display.Text) * (-1);
            display.Text = x.ToString();
        }

        private void Reinicia_Click(object sender, RoutedEventArgs e)
        {
            display.Text = "";
            operacao = "";
        }

        private void ApagaMetade_Click(object sender, RoutedEventArgs e)
        {
            acumula = 0;
            display.Text = "";
        }
        private void inverso_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double d = double.Parse(display.Text);
                if (d == 0)
                {
                    display.Text = "Dividindo por zero!!!";
                }
                else
                {
                    d = 1 / d;
                    display.Text = d.ToString();
                }
            }
            catch (Exception)
            {

                for (int i = 0; i < 100000; i++)
                {
                    display.Text = "Para com isso pisicopata. ";
                    // em espera.
                }
                display.Text = "";

            }
        }

        private void Subtracao_Click(object sender, RoutedEventArgs e)
        {
            if (operacao == "*" || operacao == "+" || operacao == "/")
            {
                operacao = "-";
            }
            else
            {
                acumula = double.Parse(display.Text);
                display.Text = "";
                operacao = "-";
            }
        }

        private void Apaga_Click(object sender, RoutedEventArgs e)
        {
            if (display.Text.Length > 0)
            {
                display.Text = display.Text.Substring(0, display.Text.Length - 1);
            }
        }

        private void Display_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
