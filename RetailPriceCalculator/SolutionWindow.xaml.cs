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
using System.IO;

namespace RetailPriceCalculator
{
    /// <summary>
    /// Interaction logic for SolutionWindow.xaml
    /// </summary>
    public partial class SolutionWindow : Window
    {
        double baseValue;
        ImageLocation loc = new ImageLocation();
        string newCurrency;

        public SolutionWindow(double retailPerUnit, string _units)
        {
            InitializeComponent();
            InitializeWindowElements(_units);
            baseValue = DisplayGetBaseValue(_units, retailPerUnit);
            TextBox_SolutionPrice.Text = _units + " " + retailPerUnit;

        }

        private double DisplayGetBaseValue(string _units, double retailPerUnit)
        {
            double baseValue = 0;

            switch (_units)
            {
                case "U.S. $":
                    baseValue = retailPerUnit;
                    break;
                case "CND $":
                    baseValue = retailPerUnit * .7510;
                    break;
                case "MEX $":
                    baseValue = retailPerUnit * .05265;
                    break;
                case "E":
                    baseValue = retailPerUnit * 1.132;
                    break;
                default:
                    break;
            }
            return baseValue;
        }

        private void InitializeWindowElements(string _units)
        {
            if (IsLoaded)
            {
                UpdateUnits(_units);
            }
            
        }

        private void UpdateUnits(string _units)
        {
            switch (_units)
            {
                case "U.S. $":
                    ComboBox_NewCurrency.SelectedItem = ComboBoxItem_USD;
                    loc.ImageName = "/RetialPriceCalculator;component/Images/cash.jpg";
                    break;
                case "CND $":
                    ComboBox_NewCurrency.SelectedItem = ComboBoxItem_CND;
                    loc.ImageName = "/RetialPriceCalculator;component/Images/CND_cash.jpg";
                    break;
                case "MEX $":
                    ComboBox_NewCurrency.SelectedItem = ComboBoxItem_MXC;
                    loc.ImageName = "/RetialPriceCalculator;component/Images/MEX_cash.jpg";
                    break;
                case "E":
                    ComboBox_NewCurrency.SelectedItem = ComboBoxItem_Euro;
                    loc.ImageName = "/RetialPriceCalculator;component/Images/euro.png";
                    break;
                default:
                    break;
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double newRetailPerUnit = DisplayUpdateValue();
            newCurrency = UpdateCurrency();
            TextBox_SolutionPrice.Text = newCurrency + " " + newRetailPerUnit;

        }

        private string UpdateCurrency()
        {
            newCurrency = ComboBox_NewCurrency.SelectionBoxItem as string;
            switch (newCurrency)
            {
                case "U.S. $":
                    loc.ImageName = "/RetialPriceCalculator;component/Images/cash.jpg";
                    break;
                case "CND $":
                    loc.ImageName = "/RetialPriceCalculator;component/Images/CND_cash.jpg";
                    break;
                case "MEX $":
                    loc.ImageName = "/RetialPriceCalculator;component/Images/MEX_cash.jpg";
                    break;
                case "E":
                    loc.ImageName = "/RetialPriceCalculator;component/Images/euro.png";
                    break;
                default:
                    break;
            }
            return newCurrency;
        }

        private double DisplayUpdateValue()
        {
            double newRetailPerUnit = 0;
            newCurrency = ComboBox_NewCurrency.SelectionBoxItem as string;
            switch (newCurrency)
            {
                case "U.S. $":
                    newRetailPerUnit = baseValue;
                    loc.ImageName = "/RetialPriceCalculator;component/Images/cash.jpg";
                    break;
                case "CND $":
                    newRetailPerUnit = baseValue * 1.331;
                    loc.ImageName = "/RetialPriceCalculator;component/Images/CND_cash.jpg";
                    break;
                case "MEX $":
                    newRetailPerUnit = baseValue * 18.98;
                    loc.ImageName = "/RetialPriceCalculator;component/Images/MEX_cash.jpg";
                    break;
                case "E":
                    newRetailPerUnit = baseValue * .8832;
                    loc.ImageName = "/RetialPriceCalculator;component/Images/euro.png";
                    break;
                default:
                    break;
            }
            return newRetailPerUnit;
        }
    }
}
