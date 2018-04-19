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
using System.Windows.Shapes;

namespace ConnectedTransportSystem
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();

            ChangeControlColour(txtAddress);
            ChangeControlColour(txtEmail);
            ChangeControlColour(txtFirstName);
            ChangeControlColour(txtLastName);
            ChangeControlColour(txtPassword);
            ChangeControlColour(txtPostcode);
            ChangeControlColour(txtUsername);
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            //go back to the main window
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        void ChangeControlColour(TextBox txt)
        {
            if (txt.Text.Length > 0)
                txt.Background = Brushes.White;
            else
                txt.Background = Brushes.Red;

        }

        private void txtUsername_TextChanged(object sender, TextChangedEventArgs e)
        {
            ChangeControlColour(txtUsername);
        }

        private void txtPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            ChangeControlColour(txtPassword);
        }

        private void txtFirstName_TextChanged(object sender, TextChangedEventArgs e)
        {
            ChangeControlColour(txtFirstName);
        }

        private void txtLastName_TextChanged(object sender, TextChangedEventArgs e)
        {
            ChangeControlColour(txtLastName);
        }

        private void txtAddress_TextChanged(object sender, TextChangedEventArgs e)
        {
            ChangeControlColour(txtAddress);
        }

        private void txtPostcode_TextChanged(object sender, TextChangedEventArgs e)
        {
            ChangeControlColour(txtPostcode);
        }

        private void txtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            ChangeControlColour(txtEmail);
        }
    }
}
