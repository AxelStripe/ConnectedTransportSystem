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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Window
    {
        private TransportData _data;

        public Page1(TransportData data)
        {
            InitializeComponent();
            _data = data;
            EnableSignUp();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            ReturnToLogin();
        }

        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            if(SignUpUser(txtUsername.Text, txtPassword.Text, txtEmail.Text))
            {
                MessageBox.Show("Welcome, " + txtUsername.Text, "Connect Transport", MessageBoxButton.OK, MessageBoxImage.Information);
                ReturnToLogin();
            }
            else
            {
                MessageBox.Show("Failed to Sign-Up, Username already exists!", "Connect Transport", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        bool SignUpUser(string username, string password, string email)
        {
            //attempt to add a new user
            TransportUser newUser = new TransportUser(username, password, email);

            return _data.AddUser(newUser);
        }

        private void txtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            EnableSignUp();
        }

        private void txtUsername_TextChanged(object sender, TextChangedEventArgs e)
        {
            EnableSignUp();
        }

        private void txtPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            EnableSignUp();
        }


        void ReturnToLogin()
        {
            //go back to login menu
            MainWindow main = new MainWindow(_data);
            main.Show();
            this.Hide();
        }

        void EnableSignUp()
        {
            if (txtEmail.Text.Length > 0)
                imgEmail.Visibility = Visibility.Hidden;
            else
                imgEmail.Visibility = Visibility.Visible;

            if (txtUsername.Text.Length > 0)
                imgUsername.Visibility = Visibility.Hidden;
            else
                imgUsername.Visibility = Visibility.Visible;

            if (txtPassword.Text.Length > 0)
                imgPassword.Visibility = Visibility.Hidden;
            else
                imgPassword.Visibility = Visibility.Visible;

            if (txtUsername.Text.Length > 0 && txtPassword.Text.Length > 0 && txtEmail.Text.Length > 0)
            {
                btnSignUp.Visibility = Visibility.Visible;
                imgSignUp.Visibility = Visibility.Hidden;
            }
            else
            {
                btnSignUp.Visibility = Visibility.Hidden;
                imgSignUp.Visibility = Visibility.Visible;
            }
        }
    }
}
