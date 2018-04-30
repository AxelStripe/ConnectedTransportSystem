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
    /// Interaction logic for payDetails.xaml
    /// </summary>
    public partial class payDetails : Window
    {
        private TransportData _data;
        public payDetails(TransportData data)
        {
            InitializeComponent();
            _data = data;
            EnableConfirm();
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
            resetPass reset = new resetPass(_data, 5);
            reset.Show();
            this.Close();
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            //trnasaction complete
            Page2 transactionComplete = new Page2(_data);
            transactionComplete.Show();
            this.Close();
        }

        private void cboType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            EnableConfirm();
        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {
            EnableConfirm();
        }

        private void txtCardNo_TextChanged(object sender, TextChangedEventArgs e)
        {
            EnableConfirm();
        }

        private void txtExpDate_TextChanged(object sender, TextChangedEventArgs e)
        {
            EnableConfirm();
        }

        private void txtCSV_TextChanged(object sender, TextChangedEventArgs e)
        {
            EnableConfirm();
        }

        void EnableConfirm()
        {
            if (txtCardNo.Text.Length > 0)
                imgCardNo.Visibility = Visibility.Hidden;
            else
                imgCardNo.Visibility = Visibility.Visible;

            if (txtCSV.Text.Length > 0)
                imgCSV.Visibility = Visibility.Hidden;
            else
                imgCSV.Visibility = Visibility.Visible;

            if (txtExpDate.Text.Length > 0)
                imgExpDate.Visibility = Visibility.Hidden;
            else
                imgExpDate.Visibility = Visibility.Visible;

            if (txtName.Text.Length > 0)
                imgName.Visibility = Visibility.Hidden;
            else
                imgName.Visibility = Visibility.Visible;

            if (cboType.SelectedIndex >= 0)
                imgType.Visibility = Visibility.Hidden;
            else
                imgType.Visibility = Visibility.Visible;

            if (txtCardNo.Text.Length > 0 &&
                txtCSV.Text.Length > 0 &&
                txtExpDate.Text.Length > 0 &&
                txtName.Text.Length > 0 &&
                cboType.SelectedIndex >= 0)
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

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            //back to choose payment
            choosePaym choose = new choosePaym(_data);
            choose.Show();
            this.Close();
        }
    }
}
