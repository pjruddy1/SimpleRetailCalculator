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
using System.Windows.Shapes;

namespace RetailPriceCalculator
{
    /// <summary>
    /// Interaction logic for HelpWindow.xaml
    /// </summary>
    public partial class HelpWindow : Window
    {
        public HelpWindow()
        {
            InitializeComponent();
        }

        private void IsChecked1(object sender, RoutedEventArgs e)
        {
            string message;
            message = "Please enter some message here.";

            Label_HelpLabel.Content = message;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void IsChecked2(object sender, RoutedEventArgs e)
        {
            string message;

            message = "Enter some message here.";

            Label_HelpLabel.Content = message;
        }

        private void Ischecked3(object sender, RoutedEventArgs e)
        {
            string message = "blah blah blah blahl";

            Label_HelpLabel.Content = message;
        }

        private void IsChecked4(object sender, RoutedEventArgs e)
        {
            string message = "this message is defferent then the rest and might have more to it.";

            Label_HelpLabel.Content = message;
        }

        private void IsChecked5(object sender, RoutedEventArgs e)
        {
            string message = "Please enter a message here.";

            Label_HelpLabel.Content = message;
        }
    }
}
