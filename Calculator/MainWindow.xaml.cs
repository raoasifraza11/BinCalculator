using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
           
            try
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
            catch (Exception ex)
            {
                // exception handle here
            }

        }

        private void inputVariable_GotFocus(object sender, RoutedEventArgs e)
        {
            inputVariable.Text = string.Empty;
        }

        private void inputVariable_TextChanged(object sender, TextChangedEventArgs e)
        {
            inputVariable.Text = Regex.Replace(inputVariable.Text, "[^0-9]", "");
        }
        
    }
}
