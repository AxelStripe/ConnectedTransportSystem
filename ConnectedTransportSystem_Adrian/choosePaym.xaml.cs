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

namespace ConnectedTransportSystem_Adrian
{
    /// <summary>
    /// Interaction logic for choosePaym.xaml
    /// </summary>
    public partial class choosePaym : Window
    {
        private TransportData _data;
        public choosePaym(TransportData data)
        {
            InitializeComponent();
            _data = data;
            mnuUser.Header = _data.GetLoggedInUser().GetUsername();
        }

        private void logOut_Click(object sender, RoutedEventArgs e)
        {
            //log out and go back to log in screen
            _data.LogOutUser();
            MainWindow loginScreen = new MainWindow(_data);
            loginScreen.Show();
            this.Close();
        }

        private void mnuChangePw_Click(object sender, RoutedEventArgs e)
        {
            resetPass reset = new resetPass(_data, 3);
            reset.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            //return to look up routes
            lookupRoutes lookup = new lookupRoutes(_data);
            lookup.Show();
            this.Close();
        }

        private void btnCash_Click(object sender, RoutedEventArgs e)
        {
            //choose cash
            cashPaym cash = new cashPaym(_data);
            cash.Show();
            this.Close();
        }

        private void btnCard_Click(object sender, RoutedEventArgs e)
        {
            //choose card
            payDetails card = new payDetails(_data);
            card.Show();
            this.Close();
        }

        private void btnPayPal_Click(object sender, RoutedEventArgs e)
        {
            //choose paypal
            MessageBox.Show("Processing PayPal Payment");
            Page2 complete = new Page2(_data);
            complete.Show();
            this.Close();
        }
    }
}
