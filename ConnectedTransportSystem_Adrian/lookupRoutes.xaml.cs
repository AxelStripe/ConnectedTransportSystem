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
    /// Interaction logic for lookupRoutes.xaml
    /// </summary>
    public partial class lookupRoutes : Window
    {
        private TransportData _data;

        public lookupRoutes(TransportData data)
        {
            InitializeComponent();
            _data = data;
            mnuUser.Header = _data.GetLoggedInUser().GetUsername();
            lstRoutes.Items.Add(_data.GetJourney());
            EnableConfirm();
        }

        private void lstRoutes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            EnableConfirm();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            //return to journey planner
            journeyPlanner planner = new journeyPlanner(_data);
            planner.Show();
            this.Close();
        }

        private void logOut_Click(object sender, RoutedEventArgs e)
        {
            //log out and go back to log in screen
            _data.LogOutUser();
            MainWindow loginScreen = new MainWindow(_data);
            loginScreen.Show();
            this.Close();
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            //go to payment selector
            choosePaym paym = new choosePaym(_data);
            paym.Show();
            this.Close();
        }

        void EnableConfirm()
        {
            if (lstRoutes.SelectedIndex >= 0)
            {
                btnConfirm.Visibility = Visibility.Visible;
                imgConfirm.Visibility = Visibility.Hidden;
            }
            else
            {
                btnConfirm.Visibility = Visibility.Hidden;
                imgConfirm.Visibility = Visibility.Visible;
            }
                
        }

        private void mnuChangePw_Click(object sender, RoutedEventArgs e)
        {
            resetPass reset = new resetPass(_data, 2);
            reset.Show();
            this.Close();
        }
    }
}
