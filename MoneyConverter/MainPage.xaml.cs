using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MoneyConverter
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

        }
        //Singapore Dollar
        private void SingDollar_Click(object sender, RoutedEventArgs e)
        {

            double intRinggit = Convert.ToDouble(rmInput.Text);

            double result = intRinggit / 2.57458;

            convertOutput.Text = result.ToString("SGD 0.00");

        }
        //Australia Dollar
        private void AusDollar_Click(object sender, RoutedEventArgs e)
        {
            double intRinggit = Convert.ToDouble(rmInput.Text);

            double result = intRinggit / 2.95185;

            convertOutput.Text = result.ToString("AUD 0.00");

        }
        //Indonesia Rupiah
        private void IndoRp_Click(object sender, RoutedEventArgs e)
        {
            double intRinggit = Convert.ToDouble(rmInput.Text);

            double result = intRinggit / 0.000273392;

            convertOutput.Text = result.ToString("Rp 0.00");

        }
        //Thailand Baht
        private void ThaiBaht_Click(object sender, RoutedEventArgs e)
        {
            double intRinggit = Convert.ToDouble(rmInput.Text);

            double result = intRinggit / 0.100586;

            convertOutput.Text = result.ToString("THB 0.00");

        }
        //China RenMingBi
        private void ChiRmb_Click(object sender, RoutedEventArgs e)
        {
            double intRinggit = Convert.ToDouble(rmInput.Text);

            double result = intRinggit / 0.530525;

            convertOutput.Text = result.ToString("RMB 0.00");

        }
        //United Kingdom Pound
        private void UkPound_Click(object sender, RoutedEventArgs e)
        {
            double intRinggit = Convert.ToDouble(rmInput.Text);

            double result = intRinggit / 5.27012;

            convertOutput.Text = result.ToString("GBP 0.00");

        }
        //United States USD
        private void UsUsd_Click(object sender, RoutedEventArgs e)
        {
            double intRinggit = Convert.ToDouble(rmInput.Text);

            double result = intRinggit / 3.23248;

            convertOutput.Text = result.ToString("USD 0.00");
        }
        //Europe EUR
        private void EuroDollar_Click(object sender, RoutedEventArgs e)
        {
            double intRinggit = Convert.ToDouble(rmInput.Text);

            double result = intRinggit / 4.39846;

            convertOutput.Text = result.ToString("EUR 0.00");

        }

        private void rmInput_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            bool isGoodData;    // flag to make the flow clearer.
            TextBox theTextBox = (TextBox)sender;  // the sender is a textbox

            if (e.Key >= Windows.System.VirtualKey.Number0 && e.Key <= Windows.System.VirtualKey.Number9)  // allow digits
                isGoodData = true;
            else if (e.Key == Windows.System.VirtualKey.Tab)
                isGoodData = true;
            else if (e.Key >= Windows.System.VirtualKey.NumberPad0 && e.Key <= Windows.System.VirtualKey.NumberPad9)  // allow digits
                isGoodData = true;
            else if (e.Key == Windows.System.VirtualKey.Decimal || (int)e.Key == 190)   // character is a decimal point, 190 is the keyboard period code
            // which is not in the VirtualKey enumeration
            {
                if (theTextBox.Text.Contains("."))   // search for a current point
                    isGoodData = false;    // only 1 decimal point allowed
                else
                    isGoodData = true;     // this is the only one.
            }
            else if (e.Key == Windows.System.VirtualKey.Back)  // allow backspace
                isGoodData = true;
            else
                isGoodData = false;   // everything else is bad
            if (!isGoodData)          // mark bad data as handled
                e.Handled = true;
        }
    }
}
