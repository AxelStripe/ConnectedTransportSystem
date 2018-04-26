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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TransportData _data;

        public MainWindow()
        {
            InitializeComponent();
            _data = new TransportData();
        }

        public MainWindow(TransportData data)
        {
            InitializeComponent();
            _data = data;
        }

        private void btnLogIn_Click(object sender, RoutedEventArgs e)
        {
            bool authorisation = _data.AuthoriseUser(txtUsername.Text, txtPassword.Text);

            if (authorisation)
            {
                mainMenu main = new mainMenu(_data);
                main.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Authorisation Failed.");
            
        }

        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            Page1 createAccount = new Page1(_data);
            createAccount.Show();
            this.Hide();
        }

        private void txtPassword_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
