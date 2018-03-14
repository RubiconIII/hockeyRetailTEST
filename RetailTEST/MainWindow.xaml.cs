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

namespace RetailTEST
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox != null && textBox1 != null) 
            {
                int textBoxNum = int.Parse(textBox.Text);
                int textBox1Num = int.Parse(textBox1.Text);
                int userInputSum = textBoxNum + textBox1Num;
                MessageBox.Show("Sum of your numbers: " + userInputSum);
            }
            else
            {
                
                MessageBox.Show("Please insert two integers into the text boxes.");
            }
        }

        private void crashButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NullReferenceException();
        }
    }
}
