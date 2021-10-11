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

namespace Option_10
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
            Random random = new Random();
            int i = random.Next(10, 50);
            textBox1.Text = i.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int j = int.Parse(textBox1.Text);
            int firstNumber = j / 10 % 10;
            int secondNumber = j % 10;
            int Enter = firstNumber + secondNumber;
            textBox2.Text = Enter.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int j = int.Parse(textBox1.Text);
            int firstNumber = j / 10 % 10;
            int secondNumber = j % 10;
            int Enter = firstNumber * secondNumber;
            textBox3.Text = Enter.ToString();
        }
    }
}
