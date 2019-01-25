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
        private enum Units { US, CND, MEX, EURO };
        Units _newUnits;
        double baseValue;
        public ImageLocation loc { get; set; }

        public SolutionWindow(double retailPerUnit, string _units)
        {
            bool validResponse1;
            baseValue = DisplayGetBaseValue(retailPerUnit);
            validResponse1 = Enum.TryParse(_units, out _newUnits);
            InitializeComponent();
            InitializeWindowElements();

            TextBox_SolutionPrice.Text = _units + " " + retailPerUnit.ToString("C2");
        }

        private double DisplayGetBaseValue(double retailPerUnit)
        {
            double baseValue = 0;

            switch (_newUnits)
            {
                case Units.US:
                    baseValue = retailPerUnit;
                    break;
                case Units.CND:
                    baseValue = retailPerUnit * .7510;
                    break;
                case Units.MEX:
                    baseValue = retailPerUnit * .05265;
                    break;
                case Units.EURO:
                    baseValue = retailPerUnit * 1.132;
                    break;
                default:
                    break;
            }

            return baseValue;
        }

        private void InitializeWindowElements()
        {
            if (IsLoaded)
            {
                UpdateUnits();
            }
            
        }

        private void UpdateUnits()
        {
            ImageLocation loc = new ImageLocation();
            switch (_newUnits)
            {
                case Units.US:
                    ComboBox_NewCurrency.SelectedItem = ComboBoxItem_USD.IsEnabled;
                    loc.ImageName = "/RetialPriceCalculator;component/Images/CND_cash.jpg";
                    break;
                case Units.CND:
                    ComboBox_NewCurrency.SelectedItem = ComboBoxItem_CND.IsEnabled;
                    loc.ImageName = "/RetialPriceCalculator;component/Images/CND_cash.jpg";
                    
                    break;
                case Units.MEX:
                    ComboBox_NewCurrency.SelectedItem = ComboBoxItem_MXC.IsEnabled;
                    loc.ImageName = "/RetialPriceCalculator;component/Images/MEX_cash.jpg";
                    break;
                case Units.EURO:
                    ComboBox_NewCurrency.SelectedItem = ComboBoxItem_Euro.IsEnabled;
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
            double newRetailPerUnit = UpdateCurrency();
            TextBox_SolutionPrice.Text = _newUnits.ToString() + " " + newRetailPerUnit.ToString("C2");
        }

        private double UpdateCurrency()
        {
            double newRetailPerUnit = 0;
            bool validResponse = Enum.TryParse(ComboBox_NewCurrency.SelectionBoxItem.ToString(), out _newUnits);
            ImageLocation loc = new ImageLocation();
            if (validResponse)
            {
                switch (_newUnits)
                {
                    case Units.US:
                        newRetailPerUnit = baseValue;
                        loc.ImageName = "/RetialPriceCalculator;component/Images/cash.jpg";
                        break;
                    case Units.CND:
                        newRetailPerUnit = baseValue * 1.331;
                        loc.ImageName = "/RetialPriceCalculator;component/Images/CND_cash.jpg";
                        break;
                    case Units.MEX:
                        newRetailPerUnit = baseValue * 18.98;
                        loc.ImageName = "/RetialPriceCalculator;component/Images/MEX_cash.jpg";
                        break;
                    case Units.EURO:
                        newRetailPerUnit = baseValue * .8832;
                        loc.ImageName = "/RetialPriceCalculator;component/Images/euro.png";
                        break;
                    default:
                        break;
                }
            }
            return newRetailPerUnit;
            
        }
    }
}
