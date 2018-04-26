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
            if(SignUpUser(txtUsername.Text, txtPassword.Text))
            {
                MessageBox.Show("Welcome, " + txtUsername.Text);
                ReturnToLogin();
            }
            else
            {
                MessageBox.Show("Failed to Sign-Up, Username already exists!");
            }
        }

        bool SignUpUser(string username, string password)
        {
            //attempt to add a new user
            TransportUser newUser = new TransportUser(username, password);

            return _data.AddUser(newUser);
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
            if (txtUsername.Text.Length > 0 && txtPassword.Text.Length > 0)
                btnSignUp.IsEnabled = true;
            else
                btnSignUp.IsEnabled = false;
        }
    }
}
