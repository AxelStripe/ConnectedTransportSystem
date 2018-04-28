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
    /// Interaction logic for mainMenu.xaml
    /// </summary>
    public partial class mainMenu : Window
    {
        private TransportData _data;

        public mainMenu(TransportData data)
        {
            InitializeComponent();
            _data = data;
            mnuUser.Header = _data.GetLoggedInUser().GetUsername();
        }

        private void logOut_Click(object sender, RoutedEventArgs e)
        {
            //log user out and return to login menu
            _data.LogOutUser();
            MainWindow loginWindow = new MainWindow(_data);
            loginWindow.Show();
            this.Close();
        }

        private void btnPlanJourney_Click(object sender, RoutedEventArgs e)
        {
            //go to plan journey window
            journeyPlanner planner = new journeyPlanner(_data);
            planner.Show();
            this.Close();
        }

        private void mnuChangePw_Click(object sender, RoutedEventArgs e)
        {
            resetPass reset = new resetPass(_data, 0);
            reset.Show();
            this.Close();
        }
    }
}
