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

namespace x
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void MathMy()
        {
            try
            {
                if (A.Text.Contains('.') || B.Text.Contains('.') || C.Text.Contains('.'))
                {
                    A.Text = A.Text.Replace('.', ',');
                    B.Text = B.Text.Replace('.', ',');
                    C.Text = C.Text.Replace('.', ',');
                }

                for (int i = 0; i < 3; i++)
                {
                    if (A.Text.Length == 0) A.Text = "0";
                    else if (B.Text.Length == 0) B.Text = "0";
                    else if (C.Text.Length == 0) C.Text = "0";
                     
                }

                double a = double.Parse(A.Text); 
                double b = double.Parse(B.Text);
                double c = double.Parse(C.Text);
                double x1,x2;

                if (a == 0 && b == 0 && c == 0) 
                { 
                    
                    A.Text = "";
                    B.Text = "";
                    C.Text = "";
                    Message();
                }
                
                double D = b * b - 4 * a * c;
                if (D < 0) MessageBox.Show("Корней нет");
                else if (D == 0) 
                {   x1 = (-b) / (2 * a);
                    x1 = Math.Round(x1,6);
                    X2.Text = "";
                    X1.Text = x1.ToString();
                }
                else if (D > 0)
                {
                    x1 = ((-b) + Math.Sqrt(D)) / (2 * a);
                    x1 = Math.Round(x1,2);
                    X1.Text = x1.ToString();
                    x2 = ((-b) - Math.Sqrt(D)) / (2 * a);
                    x2 = Math.Round(x2,2);
                    X2.Text = x2.ToString();
                }
            }
            catch
            {
                Message();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MathMy();
        }

        private void Message()
        {
            MessageBox.Show("Неправильные входные данные", "Ошибочка");
        }
    }
}
