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
            message = "The cost of inventory is the full amount of cost of the item(s). This text box should be filled with a real number." +
                " If you recieved a message instructing to enter a correct amount, double check the number you entered.";

            Label_HelpLabel.Text = message;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void IsChecked2(object sender, RoutedEventArgs e)
        {
            string message;

            message = "Additional costs are all the extra costs associated with receiving, selling and holding the inventory. " +
                "This text box should be filled with a real number. If you recieved a message instructing to enter a correct amount," +
                "double check the number you entered.";

            Label_HelpLabel.Text = message;
        }

        private void Ischecked3(object sender, RoutedEventArgs e)
        {
            string message = "Number of units is the number of units of inventory associated with the cost of inventory.  " +
                "This text box should be filled with a real number. If you recieved a message instructing to enter a correct amount," +
                "double check the number you entered.";

            Label_HelpLabel.Text = message;
        }

        private void IsChecked4(object sender, RoutedEventArgs e)
        {
            string message = "Percent mark-up is the percent of profit that you would like to add to the retail price of your" +
                "inventory.  This value is multiplied by the total cost of inventory or the cost of inventory plus additional cost" +
                "of inventory. This text box should be filled with a real number. If you recieved a message instructing to enter a correct amount," +
                "double check the number you entered.";

            Label_HelpLabel.Text = message;
        }

        private void IsChecked5(object sender, RoutedEventArgs e)
        {
            string message = "The Calculated price per unit is the retail pirce that you would like to sell your inventory. It is " +
                "the (total cost of inventory plus total (cost of inventory multiplied by the percent mark-up)) divided by the number" +
                " of units.  You do not enter any values here. ";

            Label_HelpLabel.Text = message;
        }

        private void RadioButton_SolutionWindow_Checked(object sender, RoutedEventArgs e)
        {
            string message = "The Solution Window will pop up when correct values have been entered and the calculate button has been" +
                "pressed. In the solution window you can convert your current currency to another by selecting a different currency and" +
                "then pressing the convert currency button.";

            Label_HelpLabel.Text = message;
        }

        private void RadioButton_ConvertCurrency_Checked(object sender, RoutedEventArgs e)
        {
            //string message = "The Convert Currency button allows you to convert the currency that you originally calculated the " +
            //    "retail price in to another currency.  After you have selcted the currency that you would like to convert to press the " +
            //    "convert currency button.";

            //Label_HelpLabel.Text = message;
            //TextBlock.Inlines.Add(new Run("The Convert Currency button allows you to convert the currency that you originally calculated"));

        }

        private void RadioButton_ExitButtons_Checked(object sender, RoutedEventArgs e)
        {
            string message = "To exit out of any of the windows at any point in time just press the exit button";

            Label_HelpLabel.Text = message;
        }//TextBlock.Inlines.Add(new Run("First"));
        //TextBlock.Inlines.Add(new LineBreak());
        //TextBlock.Inlines.Add(new Run("Second"));
    }
}
