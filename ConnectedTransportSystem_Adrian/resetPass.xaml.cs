﻿using System;
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
    /// Interaction logic for resetPass.xaml
    /// </summary>
    public partial class resetPass : Window
    {
        TransportData _data;
        public resetPass(TransportData data)
        {
            InitializeComponent();
            _data = data;
            EnableSubmit();

        }

        private void txtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            EnableSubmit();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (_data.ValidateEmail(txtEmail.Text))
                MessageBox.Show("E-Mail address confirmed, we will send an Email with instructions on how to reset your password."); //email matches
            else
                MessageBox.Show("E-Mail address invalid, please re-enter your E-Mail address.");
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            //return to previous window
        }

        void EnableSubmit()
        {
            if(txtEmail.Text.Length > 0)
            {
                txtEmail.Background = null;
                btnSubmit.Visibility = Visibility.Visible;
                imgSubmit.Visibility = Visibility.Hidden;
            }
            else
            {
                txtEmail.Background = Brushes.Red;
                btnSubmit.Visibility = Visibility.Hidden;
                imgSubmit.Visibility = Visibility.Visible;
            }
        }
    }
}
