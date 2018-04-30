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
    /// Interaction logic for cashPaym.xaml
    /// </summary>
    public partial class cashPaym : Window
    {
        private TransportData _data;

        public cashPaym(TransportData data)
        {
            InitializeComponent();
            _data = data;
            mnuUser.Header = _data.GetLoggedInUser().GetUsername();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            //go back to choose payment
            choosePaym paym = new choosePaym(_data);
            paym.Show();
            this.Close();

        }

        private void mnuChangePw_Click(object sender, RoutedEventArgs e)
        {
            resetPass reset = new resetPass(_data, 4);
            reset.Show();
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

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            //trnasaction complete
            Page2 transactionComplete = new Page2(_data);
            transactionComplete.Show();
            this.Close();

        }
    }
}
