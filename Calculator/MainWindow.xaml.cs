﻿using System;
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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            // Get Value
            int value = Convert.ToInt32(inputVariable.Text.ToString());

            // Converstion logic
            string binary = Convert.ToString(value, 2);
            string hex = value.ToString("X");
            string oct = Convert.ToString(value, 8);


            // Replace output
            BinOutput.Text = binary;
            hexOutput.Text = hex;
            OctOutput.Text = oct;

        }

        private void inputVariable_GotFocus(object sender, RoutedEventArgs e)
        {
            inputVariable.Text = string.Empty;
        }
    }
}
