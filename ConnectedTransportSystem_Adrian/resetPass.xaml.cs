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
        private TransportData _data;
        private int _previous;

        public resetPass(TransportData data, int previous)
        {
            InitializeComponent();
            _data = data;
            _previous = previous;
            EnableSubmit();
        }

        private void txtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            EnableSubmit();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (_data.ValidateEmail(txtEmail.Text))
                MessageBox.Show("E-Mail address confirmed, we will send an Email with instructions on how to reset your password.", "Connect Transport", MessageBoxButton.OK, MessageBoxImage.Information); //email matches
            else
                MessageBox.Show("E-Mail address invalid, please re-enter your E-Mail address.", "Connect Transport", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            //return to previous window

            /*
             * 0 = Main Menu
             * 1 = Journey planner
             * 2 = look up routes
             * 3 = choose payment
             * 4 = cash payment
             * 5 = card payment
             * 6 = transaction complete
             * */
            switch (_previous)
            {
                case 0:
                    //main menu
                    mainMenu main = new mainMenu(_data);
                    main.Show();
                    this.Close();
                    break;
                case 1:
                    //journey planner
                    journeyPlanner planner = new journeyPlanner(_data);
                    planner.Show();
                    this.Close();
                    break;
                case 2:
                    //look up routes
                    lookupRoutes lookup = new lookupRoutes(_data);
                    lookup.Show();
                    this.Close();
                    break;
                case 3:
                    //choose payment
                    choosePaym paym = new choosePaym(_data);
                    paym.Show();
                    this.Close();
                    break;
                case 4:
                    //cash payment
                    cashPaym cash = new cashPaym(_data);
                    cash.Show();
                    this.Close();
                    break;
                case 5:
                    //cash payment
                    payDetails card = new payDetails(_data);
                    card.Show();
                    this.Close();
                    break;
                case 6:
                    //transaction complete
                    Page2 complete = new Page2(_data);
                    complete.Show();
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        void EnableSubmit()
        {
            if(txtEmail.Text.Length > 0)
            {
                imgEmail.Visibility = Visibility.Hidden;
                btnSubmit.Visibility = Visibility.Visible;
                imgSubmit.Visibility = Visibility.Hidden;
            }
            else
            {
                imgEmail.Visibility = Visibility.Visible;
                btnSubmit.Visibility = Visibility.Hidden;
                imgSubmit.Visibility = Visibility.Visible;
            }
        }

        private void logOut_Click(object sender, RoutedEventArgs e)
        {
            //log user out and return to login menu
            _data.LogOutUser();
            MainWindow loginWindow = new MainWindow(_data);
            loginWindow.Show();
            this.Close();
        }
    }
}
