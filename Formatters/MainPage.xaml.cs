using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

namespace Formatters
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            //Get Date time in the format we need
            var dateTimeFormatter = new Windows.Globalization.DateTimeFormatting.DateTimeFormatter("month day dayofweek year");
            dateLbl.Text = dateTimeFormatter.Format(DateTime.Now);
            //Get currency, get the current user one
            var userCurrency = Windows.System.UserProfile.GlobalizationPreferences.Currencies;
            var currencyFormatter = new Windows.Globalization.NumberFormatting.CurrencyFormatter(userCurrency[0]);
            currencyLbl.Text=currencyFormatter.Format(10.57);
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }
}
