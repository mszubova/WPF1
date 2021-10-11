﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace _8Ball
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

        private void Answer_Click(object sender, RoutedEventArgs e)
        {
            this.Cursor = Cursors.Wait;
            Thread.Sleep(TimeSpan.FromSeconds(1));
            txtAnswer.Text = AnswerGenerator.GetRandomAnswer();
            this.Cursor = null;
        }
        private void txtQuestion_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
    }
}
