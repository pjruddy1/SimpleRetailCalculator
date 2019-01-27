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

namespace RetailPriceCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private enum Units { US, CND, MEX, EURO };

        Units _units;

        public MainWindow()
        {
            InitializeComponent();
            InitializeWindowElements();
        }

        private void InitializeWindowElements()
        {
            if (IsLoaded)
            {
                _units = Units.US;
                UpdateUnits();
            }
        }
        //
        //Set currency units
        //
        private void UpdateUnits()
        {
            if ((bool)ComboBoxItem_USD.IsSelected)
            {
                _units = Units.US;
            }
            else if ((bool)ComboBoxItem_CD.IsSelected)
            {
                _units = Units.CND;
            }
            else if ((bool)ComboBoxItem_Pesos.IsSelected)
            {
                _units = Units.MEX;
            }
            else if ((bool)ComboBoxItem_Euros.IsSelected)
            {
                _units = Units.EURO;
            }            
        }

        private void Exit_Button_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
        //
        // calculations for calculate button
        // validation of values also included
        //
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double retailMarkup = 0;
            double retailPerUnit = 0;
            double markUpAmount = 0;
            UpdateUnits();

            if (ValidInputs(out string userFeedback))
            {
                
                retailMarkup = (Convert.ToDouble(TextBox_Markup.Text) * .01);

                markUpAmount = retailMarkup *
                     (Convert.ToDouble(TextBox_InventoryCost.Text) +
                     Convert.ToDouble(TextBox_AdditionalCost.Text));
                    

                retailPerUnit = (markUpAmount + Convert.ToDouble(TextBox_InventoryCost.Text) +
                                Convert.ToDouble(TextBox_AdditionalCost.Text)) /
                                Convert.ToDouble(TextBox_UnitsPerCase.Text);

                TextBox_RetailPrice.Text = _units.ToString() + " " + retailPerUnit.ToString("C2");

                SolutionWindow solutionWindow = new SolutionWindow(retailPerUnit, _units.ToString());

                solutionWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show(userFeedback);
            }

            
        }

        /// <summary>
        /// This Code is from John Velis CIT195 NorthwesternMichiganCollege
        /// validate all inputs and generate a user feedback message if necessary 
        /// </summary>
        /// <param name="userFeedback">user feedback message</param>
        /// <returns>valid inputs status</returns>
        private bool ValidInputs(out string userFeedback)
        {
            bool validInputs = true;
            userFeedback = "";
            //
            // set bool value and build out the user feedback message
            //
            if (!double.TryParse(TextBox_InventoryCost.Text, out double invenToryCost ))
            {
                validInputs = false;
                userFeedback += "The value entered for Inventory Cost is not a valid number." + Environment.NewLine;
            }
            if (!double.TryParse(TextBox_AdditionalCost.Text, out double additionalCost))
            {
                validInputs = false;
                userFeedback += "The value entered for Additional Cost is not a valid number." + Environment.NewLine;
            }
            if (!double.TryParse(TextBox_Markup.Text, out double markUp))
            {
                validInputs = false;
                userFeedback += "The value entered for Percent Mark-up is not a valid number." + Environment.NewLine;
            }
            if (!double.TryParse(TextBox_UnitsPerCase.Text, out double unitsPer))
            {
                validInputs = false;
                userFeedback += "The value entered for Units Per Case is not a valid number." + Environment.NewLine;
            }

            return validInputs;
        }

        private void Help_Button_Click(object sender, RoutedEventArgs e)
        {
            HelpWindow helpWindow = new HelpWindow();

            helpWindow.ShowDialog();
        }

    }
}
