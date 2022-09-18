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

namespace pr1
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
        bool flag = false;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "1";

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "2";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "3";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "4";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "5";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "6";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "7";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "8";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "9";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "0";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            if (flag == false)
            {
                textBlock.Text += "+";
                flag = true;
            }
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            if (flag == false)
            {
                textBlock.Text += "-";
                flag = true;
            }
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            if (flag == false)
            {
                textBlock.Text += "*";
                flag = true;
            }
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            if (flag == false)
            {
                textBlock.Text += "/";
                flag = true;
            }
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "=";
            try
            {
                calculate();
            }
            catch
            {
                textBlock.Text = "Еррор! Работать отказывается!";
            }
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            textBlock.Text = "";
            flag = false;
        }
        private void calculate()
        {
            string str = textBlock.Text;
            string a="", b="", sign="", c="";
            char[] equal = str.ToArray();
            for(int i=0; i<equal.Length; i++)
            {
                if (equal[i]== '0' || equal[i] == '1' || equal[i] == '2' || equal[i] == '3' || equal[i] == '4' || 
                    equal[i] == '5' || equal[i] == '6' || equal[i] == '7' || equal[i] == '8' || equal[i] == '9')
                {
                    c += equal[i];
                }
                else
                {
                    if (equal[i] != '=')
                    {
                        sign = Convert.ToString(equal[i]);
                        a = c;
                        c = "";
                    }
                    
                    continue;
                }
            }
            b = c;
            switch (sign)
            {
                case "+": textBlock.Text += Convert.ToDouble(a) + Convert.ToDouble(b); break;
                case "-": textBlock.Text += Convert.ToDouble(a) - Convert.ToDouble(b); break;
                case "*": textBlock.Text += Convert.ToDouble(a) * Convert.ToDouble(b); break;
                case "/": textBlock.Text += Convert.ToDouble(a) / Convert.ToDouble(b); break;
            }

        }
    }
}
