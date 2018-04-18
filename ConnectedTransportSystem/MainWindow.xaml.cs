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

namespace ConnectedTransportSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            EnableLogIn();
        }

        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            MainMenu mainMenu = new MainMenu(username);
            mainMenu.Show();
            this.Close();
        }

        private void txtUsername_TextChanged(object sender, TextChangedEventArgs e)
        {
            EnableLogIn();
        }

        private void txtPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            EnableLogIn();
        }

        void EnableLogIn()
        {
            if (txtUsername.Text.Length > 0 && txtPassword.Text.Length > 0)
                btnLogin.IsEnabled = true;
            else
                btnLogin.IsEnabled = false;
        }
    }
}
