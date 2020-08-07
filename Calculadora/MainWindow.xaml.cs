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

namespace Calculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private string calculo = "";
        private bool coma = false;
        private double num1 = 0;
        private double num2 = 0;
        private double contDecimal = 1;
        

        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            if(calculo == "")
            {
                if (coma)
                {
                    num1 += 0 / (Math.Pow(10,contDecimal));
                    contDecimal++;
                    numero1.Text = num1.ToString() + ",0";
                }
                else
                {
                    num1 = (num1 * 10) + 0;
                    numero1.Text = num1.ToString();
                }   
            }
            else
            {
                if (coma)
                {
                    num2 += 0 / (Math.Pow(10, contDecimal));
                    contDecimal++;
                    numero2.Text = num2.ToString() + ",0";
                }
                else
                {
                    num2 = (num2 * 10) + 0;
                    numero2.Text = num2.ToString();
                }
            }
        }

        private void Button_Click_Coma(object sender, RoutedEventArgs e)
        {
            coma = true;
            if (calculo == "")
            {
                numero1.Text = num1.ToString() + ",";
            }
            else
            {
                numero2.Text = num2.ToString() + ",";
            }
        }

        private void Button_Click_Suma(object sender, RoutedEventArgs e)
        {
            calculo = "+";
            contDecimal = 1;
            coma = false;
            cuenta.Text = "+";
        }

        private void Button_Click_Igual(object sender, RoutedEventArgs e)
        {
            
            switch (calculo)
            {
                case "+":
                    numero1.Text = "";
                    cuenta.Text = "";
                    numero2.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    numero1.Text = "";
                    cuenta.Text = "";
                    numero2.Text = (num1 - num2).ToString();
                    break;
                case "*":
                    numero1.Text = "";
                    cuenta.Text = "";
                    numero2.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    numero1.Text = "";
                    cuenta.Text = "";
                    numero2.Text = (num1 / num2).ToString();
                    break;
                case "R":
                    numero1.Text = "";
                    cuenta.Text = "";
                    numero2.Text = Math.Sqrt(num2).ToString();
                    break;
                case "%":
                    numero1.Text = "";
                    cuenta.Text = "";
                    numero2.Text = ((num1 * num2)/100).ToString();
                    break;
            }

            calculo = "";
            coma = false;
            num1 = 0;
            num2 = 0;
            contDecimal = 1;
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (calculo == "")
            {
                if (coma)
                {
                    num1 += 1 / (Math.Pow(10, contDecimal));
                    contDecimal++;
                    numero1.Text = num1.ToString();
                }
                else
                {
                    num1 = (num1 * 10) + 1;
                    numero1.Text = num1.ToString();
                }
            }
            else
            {
                if (coma)
                {
                    num2 += 1 / (Math.Pow(10, contDecimal));
                    contDecimal++;
                    numero2.Text = num2.ToString();
                }
                else
                {
                    num2 = (num2 * 10) + 1;
                    numero2.Text = num2.ToString();
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (calculo == "")
            {
                if (coma)
                {
                    num1 += 2 / (Math.Pow(10, contDecimal));
                    contDecimal++;
                    numero1.Text = num1.ToString();
                }
                else
                {
                    num1 = (num1 * 10) + 2;
                    numero1.Text = num1.ToString();
                }
            }
            else
            {
                if (coma)
                {
                    num2 += 2 / (Math.Pow(10, contDecimal));
                    contDecimal++;
                    numero2.Text = num2.ToString();
                }
                else
                {
                    num2 = (num2 * 10) + 2;
                    numero2.Text = num2.ToString();
                }
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (calculo == "")
            {
                if (coma)
                {
                    num1 += 3 / (Math.Pow(10, contDecimal));
                    contDecimal++;
                    numero1.Text = num1.ToString();
                }
                else
                {
                    num1 = (num1 * 10) + 3;
                    numero1.Text = num1.ToString();
                }
            }
            else
            {
                if (coma)
                {
                    num2 += 3 / (Math.Pow(10, contDecimal));
                    contDecimal++;
                    numero2.Text = num2.ToString();
                }
                else
                {
                    num2 = (num2 * 10) + 3;
                    numero2.Text = num2.ToString();
                }
            }
        }

        private void Button_Click_Resta(object sender, RoutedEventArgs e)
        {
            calculo = "-";
            contDecimal = 1;
            coma = false;
            cuenta.Text = "-";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (calculo == "")
            {
                if (coma)
                {
                    num1 += 4 / (Math.Pow(10, contDecimal));
                    contDecimal++;
                    numero1.Text = num1.ToString();
                }
                else
                {
                    num1 = (num1 * 10) + 4;
                    numero1.Text = num1.ToString();
                }
            }
            else
            {
                if (coma)
                {
                    num2 += 4 / (Math.Pow(10, contDecimal));
                    contDecimal++;
                    numero2.Text = num2.ToString();
                }
                else
                {
                    num2 = (num2 * 10) + 4;
                    numero2.Text = num2.ToString();
                }
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (calculo == "")
            {
                if (coma)
                {
                    num1 += 5 / (Math.Pow(10, contDecimal));
                    contDecimal++;
                    numero1.Text = num1.ToString();
                }
                else
                {
                    num1 = (num1 * 10) + 5;
                    numero1.Text = num1.ToString();
                }
            }
            else
            {
                if (coma)
                {
                    num2 += 5 / (Math.Pow(10, contDecimal));
                    contDecimal++;
                    numero2.Text = num2.ToString();
                }
                else
                {
                    num2 = (num2 * 10) + 5;
                    numero2.Text = num2.ToString();
                }
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (calculo == "")
            {
                if (coma)
                {
                    num1 += 6 / (Math.Pow(10, contDecimal));
                    contDecimal++;
                    numero1.Text = num1.ToString();
                }
                else
                {
                    num1 = (num1 * 10) + 6;
                    numero1.Text = num1.ToString();
                }
            }
            else
            {
                if (coma)
                {
                    num2 += 6 / (Math.Pow(10, contDecimal));
                    contDecimal++;
                    numero2.Text = num2.ToString();
                }
                else
                {
                    num2 = (num2 * 10) + 6;
                    numero2.Text = num2.ToString();
                }
            }
        }

        private void Button_Click_Multiplicar(object sender, RoutedEventArgs e)
        {
            calculo = "*";
            contDecimal = 1;
            coma = false;
            cuenta.Text = "*";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (calculo == "")
            {
                if (coma)
                {
                    num1 += 7 / (Math.Pow(10, contDecimal));
                    contDecimal++;
                    numero1.Text = num1.ToString();
                }
                else
                {
                    num1 = (num1 * 10) + 7;
                    numero1.Text = num1.ToString();
                }
            }
            else
            {
                if (coma)
                {
                    num2 += 7 / (Math.Pow(10, contDecimal));
                    contDecimal++;
                    numero2.Text = num2.ToString();
                }
                else
                {
                    num2 = (num2 * 10) + 7;
                    numero2.Text = num2.ToString();
                }
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (calculo == "")
            {
                if (coma)
                {
                    num1 += 8 / (Math.Pow(10, contDecimal));
                    contDecimal++;
                    numero1.Text = num1.ToString();
                }
                else
                {
                    num1 = (num1 * 10) + 8;
                    numero1.Text = num1.ToString();
                }
            }
            else
            {
                if (coma)
                {
                    num2 += 8 / (Math.Pow(10, contDecimal));
                    contDecimal++;
                    numero2.Text = num2.ToString();
                }
                else
                {
                    num2 = (num2 * 10) + 8;
                    numero2.Text = num2.ToString();
                }
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (calculo == "")
            {
                if (coma)
                {
                    num1 += 9 / (Math.Pow(10, contDecimal));
                    contDecimal++;
                    numero1.Text = num1.ToString();
                }
                else
                {
                    num1 = (num1 * 10) + 9;
                    numero1.Text = num1.ToString();
                }
            }
            else
            {
                if (coma)
                {
                    num2 += 9 / (Math.Pow(10, contDecimal));
                    contDecimal++;
                    numero2.Text = num2.ToString();
                }
                else
                {
                    num2 = (num2 * 10) + 9;
                    numero2.Text = num2.ToString();
                }
            }
        }

        private void Button_Click_Division(object sender, RoutedEventArgs e)
        {
            calculo = "/";
            contDecimal = 1;
            coma = false;
            cuenta.Text = "/";
        }

        private void Button_Click_Porcentaje(object sender, RoutedEventArgs e)
        {
            calculo = "%";
            contDecimal = 1;
            coma = false;
            cuenta.Text = "%";
        }

        private void Button_Click_Borrar(object sender, RoutedEventArgs e)
        {
            if (calculo == "")
            {
                num1 = Convert.ToDouble((num1.ToString()).Remove((num1.ToString()).Length - 1));
                numero1.Text = num1.ToString();
            }
            else
            {
                num2 = Convert.ToDouble((num2.ToString()).Remove((num2.ToString()).Length - 1));
                numero2.Text = num2.ToString();
            }
        }

        private void Button_Click_C(object sender, RoutedEventArgs e)
        {
            calculo = "";
            coma = false;
            num1 = 0;
            num2 = 0;
            contDecimal = 1;
            cuenta.Text = "";
            numero1.Text = "";
            numero2.Text = "0";
        }

        private void Button_Click_RaizCuadrada(object sender, RoutedEventArgs e)
        {
            calculo = "R";
            contDecimal = 1;
            coma = false;
            cuenta.Text = "√";
            numero1.Text = "";
        }
    }
}
