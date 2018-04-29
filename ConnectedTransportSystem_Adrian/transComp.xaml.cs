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
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Window
    {
        private TransportData _data;

        public Page2(TransportData data)
        {
            InitializeComponent();
            _data = data;
        }

        private void btnYesPrint_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Printing tickets...", "Connect Transport", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnNoPrint_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thank you for your transaction!", "Connect Transport", MessageBoxButton.OK, MessageBoxImage.Information);

            mainMenu main = new mainMenu(_data);
            main.Show();
            this.Close();
        }

        private void btnYesNew_Click(object sender, RoutedEventArgs e)
        {
            journeyPlanner planner = new journeyPlanner(_data);
            planner.Show();
            this.Close();
        }

        private void btnNoNew_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thank you for your transaction!", "Connect Transport", MessageBoxButton.OK, MessageBoxImage.Information);

            mainMenu main = new mainMenu(_data);
            main.Show();
            this.Close();
        }

        private void logOut_Click(object sender, RoutedEventArgs e)
        {
            //log user out and return to login menu
            _data.LogOutUser();
            MainWindow loginWindow = new MainWindow(_data);
            loginWindow.Show();
            this.Close();
        }

        private void mnuChangePw_Click(object sender, RoutedEventArgs e)
        {
            resetPass reset = new resetPass(_data, 6);
            reset.Show();
            this.Close();
        }
    }
}
