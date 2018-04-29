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
    /// Interaction logic for journeyPlanner.xaml
    /// </summary>
    public partial class journeyPlanner : Window
    {
        private TransportData _data;
        public journeyPlanner(TransportData data)
        {
            InitializeComponent();
            _data = data;
            mnuUser.Header = _data.GetLoggedInUser().GetUsername();
            EnableSearch();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            //return to main menu
            mainMenu main = new mainMenu(_data);
            main.Show();
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

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            //look up routes
            _data.SetJourney(cboStart.Text, txtStart.Text, cboEnd.Text, txtEnd.Text);
            lookupRoutes lookup = new lookupRoutes(_data);
            lookup.Show();
            this.Close();
        }

        void EnableSearch()
        {
            if (txtStart.Text.Length > 0)
                imgStartTime.Visibility = Visibility.Hidden;
            else
                imgStartTime.Visibility = Visibility.Visible;

            if (txtEnd.Text.Length > 0)
                imgEndTime.Visibility = Visibility.Hidden;
            else
                imgEndTime.Visibility = Visibility.Visible;

            if (cboStart.SelectedIndex >= 0)
                imgStartPoint.Visibility = Visibility.Hidden;
            else
                imgStartPoint.Visibility = Visibility.Visible;

            if (cboEnd.SelectedIndex >= 0)
                imgEndPoint.Visibility = Visibility.Hidden;
            else
                imgEndPoint.Visibility = Visibility.Visible;

            if (cboStart.SelectedIndex >= 0 
                && cboEnd.SelectedIndex >=0 
                && txtStart.Text.Length > 0 
                && txtEnd.Text.Length > 0)
            {
                btnSearch.Visibility = Visibility.Visible;
                imgSearch.Visibility = Visibility.Hidden;
            }
            else
            {
                btnSearch.Visibility = Visibility.Hidden;
                imgSearch.Visibility = Visibility.Visible;
            }
        }

        private void txtStart_TextChanged(object sender, TextChangedEventArgs e)
        {
            EnableSearch();
        }

        private void txtEnd_TextChanged(object sender, TextChangedEventArgs e)
        {
            EnableSearch();
        }

        private void cboStart_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            EnableSearch();
        }

        private void cboEnd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            EnableSearch();
        }

        private void mnuChangePw_Click(object sender, RoutedEventArgs e)
        {
            resetPass reset = new resetPass(_data, 1);
            reset.Show();
            this.Close();
        }
    }
}
