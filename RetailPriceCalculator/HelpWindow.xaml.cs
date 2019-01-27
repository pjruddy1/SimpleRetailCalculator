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
    /// HelpWindow Responses from users choice
    /// </summary>
    public partial class HelpWindow : Window
    {
        public HelpWindow()
        {
            InitializeComponent();
        }

        private void IsChecked1(object sender, RoutedEventArgs e)
        {
            Label_HelpLabel.Text = string.Format("The cost of inventory is the full amount of cost of the item(s). This{0}" +
                                                " text box should be filled with a real number. If you recieved a message{0}" +
                                                "instructing to enter a correct amount, double check the number you entered.", Environment.NewLine);           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void IsChecked2(object sender, RoutedEventArgs e)
        {
            Label_HelpLabel.Text = string.Format("Additional costs are all the extra costs associated with receiving, selling{0}" +
                                                "and holding the inventory. This text box should be filled with a real number.{0}" +
                                                "If you recieved a message instructing to enter a correct amount, double{0}" +
                                                "check the number you entered.", Environment.NewLine);            
        }

        private void Ischecked3(object sender, RoutedEventArgs e)
        {
            Label_HelpLabel.Text = string.Format("Number of units is the number of units of inventory associated with the{0}" +
                                                "cost of inventory. This text box should be filled with a real number. If you{0}" +
                                                "recieved a message instructing to enter a correct amount, double check{0}" +
                                                "the number you entered.", Environment.NewLine);
        }

        private void IsChecked4(object sender, RoutedEventArgs e)
        {
            Label_HelpLabel.Text = string.Format("Percent mark-up is the percent of profit that you would like to add to{0}" +
                                                "the retail price of your inventory. This value is multiplied by the total{0}" +
                                                "cost of inventory or the cost of inventory plus additional cost of inventory.{0}" +
                                            "This text box should be filled with a real number. If you recieved a message{0}" +
                                            "instructing to enter a correct amount, double check the number you entered.", Environment.NewLine);            
        }

        private void IsChecked5(object sender, RoutedEventArgs e)
        {
            Label_HelpLabel.Text = string.Format("The Calculated price per unit is the retail pirce that you would like{0}" +
                                                "to sell your inventory. Retail Price = (total cost of inventory plus total{0}" +
                                                "(cost of inventory multiplied by the percent mark-up)) divided by the number{0}" +
                                                "of units.  You do not enter any values here.", Environment.NewLine);
        }

        private void RadioButton_SolutionWindow_Checked(object sender, RoutedEventArgs e)
        {
            Label_HelpLabel.Text = string.Format("The Solution Window will pop up when correct values have been entered{0}" +
                                                " and the calculate button has been pressed. In the solution window you can{0}" +
                                                " convert your current currency to another by selecting a different currency{0}" +
                                            "and then pressing the convert currency button.", Environment.NewLine);           
        }

        private void RadioButton_ConvertCurrency_Checked(object sender, RoutedEventArgs e)
        {
            //string message =  "The Convert Currency button allows you to convert the currency that you   ";

            Label_HelpLabel.Text = string.Format("The convert currency button allows you to convert the currency that{0}" +
                                                "you originally calculated the retail price in to another currency.{0}" +
                                                "After you have selcted the currency that you would like to convert{0}" +
                                                " to press the convert currency button.", Environment.NewLine);
        }

        private void RadioButton_ExitButtons_Checked(object sender, RoutedEventArgs e)
        {
            Label_HelpLabel.Text = string.Format("To exit out of any of the windows at any point in time just press{0}" +
                                            "the exit button.{0}", Environment.NewLine);
        }
    }
}
