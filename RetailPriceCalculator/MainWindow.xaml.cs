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
        string _units;

        public MainWindow()
        {
            InitializeComponent();
            InitializeWindowElements();
        }

        private void InitializeWindowElements()
        {
            if (IsLoaded)
            {
                _units = "US $";
                UpdateUnits();
            }
        }

        private void UpdateUnits()
        {
            string currency = ComboBox_Currency.SelectionBoxItem as string;

            switch (currency)
            {
                case "U.S. Dollars":
                    _units = "US $";
                    break;
                case "Canadian Dollars":
                    _units = "CND $";
                    break;
                case "Pesos":
                    _units = "Mex $";
                    break;
                case "Euros":
                    _units = "E";
                    break;
                default:
                    break;
            }
        }

        private void Exit_Button_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {            
            double totalCost = double.Parse(TextBox_InventoryCost.Text) + double.Parse(TextBox_AdditionalCost.Text);           
            double unitsPer = double.Parse(TextBox_UnitsPerCase.Text);
            double retailMarkup;
            double retailPerUnit;

            UpdateUnits();

            retailMarkup = totalCost * (double.Parse(TextBox_Markup.Text) * .01);
            retailPerUnit = (totalCost + retailMarkup) / unitsPer;

            TextBox_RetailPrice.Text = _units.ToString() + " "+ retailPerUnit.ToString();

            SolutionWindow solutionWindow = new SolutionWindow(retailPerUnit, _units);

            solutionWindow.ShowDialog();
        }

        private void Help_Button_Click(object sender, RoutedEventArgs e)
        {
            HelpWindow helpWindow = new HelpWindow();

            helpWindow.ShowDialog();
        }

    }
}
