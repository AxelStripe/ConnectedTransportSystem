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
    /// Interaction logic for JourneyPlanner.xaml
    /// </summary>
    public partial class JourneyPlanner : Window
    {
        private string _username;
        private List<string> stations;

        public JourneyPlanner(string username)
        {
            InitializeComponent();

            //display username on the menu header
            _username = username;
            mnuUser.Header = _username;

            //set control colours
            //ChangeControlColour(cboDestination);
            //ChangeControlColour(cboStartPoint);
            ChangeControlColour(txtArriveTime);
            ChangeControlColour(txtStartTime);

            //Disable Search Button
            EnableSearch();

            //init stations list
            InitList();

            //Set user menu icon
            SetMenuIcon();

        }

        void InitList()
        {
            //init stations list and add stations
            stations = new List<string>();

            stations.Add("Belfast");
            stations.Add("Omagh");
            stations.Add("Derry");
            stations.Add("Coleraine");

            foreach(string s in stations)
            {
                cboDestination.Items.Add(s);
                cboStartPoint.Items.Add(s);
            }
        }

        void SetMenuIcon()
        {
            mnuUser.Icon = new System.Windows.Controls.Image
            {
                Source = new BitmapImage(new Uri("Images/Users-icon.png", UriKind.Relative))
            };

            mnuLogout.Icon = new System.Windows.Controls.Image
            {
                Source = new BitmapImage(new Uri("Images/log-out.png", UriKind.Relative))
            };
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            //use constructors to transfer data like username and selected times and etc.
            MainMenu mainMenu = new MainMenu(_username);
            mainMenu.Show();
            this.Close();
        }

        private void mnuLogout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void txtStartTime_TextChanged(object sender, TextChangedEventArgs e)
        {
            //set control colour
            ChangeControlColour(txtStartTime);

            //Enable Search button if text is in the field
            EnableSearch();
        }

        private void txtArriveTime_TextChanged(object sender, TextChangedEventArgs e)
        {
            //set control colour
            ChangeControlColour(txtArriveTime);

            //Enable Search button if text is in the field
            EnableSearch();
        }

        private void cboStartPoint_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //set control colour
            //ChangeControlColour(cboStartPoint);

            //Enable Search button if text is in the field
            EnableSearch();
        }

        private void cboDestination_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //set control colour
            //ChangeControlColour(cboDestination);

            //Enable Search button if text is in the field
            EnableSearch();
        }

        //void ChangeControlColour(ComboBox cbo)
        //{
        //    if (cbo.SelectedIndex >= 0)
        //        cbo.BorderBrush = Brushes.Gray;
        //    else
        //        cbo.BorderBrush = Brushes.Red;
                
        //}

        void ChangeControlColour(TextBox txt)
        {
            if (txt.Text.Length > 0)
                txt.Background = Brushes.Transparent;
            else
                txt.Background = Brushes.Red;

        }

        void EnableSearch()
        {
            if (txtStartTime.Text.Length > 0 && txtArriveTime.Text.Length > 0 && cboStartPoint.SelectedIndex >= 0 && cboDestination.SelectedIndex >= 0)
            {
                btnSearch.IsEnabled = true;
            }
            else
            {
                btnSearch.IsEnabled = false;
            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            LookUpRoutes lookUp = new LookUpRoutes(_username,
                cboStartPoint.SelectedItem.ToString(),
                txtStartTime.Text,
                cboDestination.SelectedItem.ToString(),
                txtArriveTime.Text);

            lookUp.Show();
            this.Close();
        }
    }
}
