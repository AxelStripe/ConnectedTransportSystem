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
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        private string _username;

        public MainMenu(string username)
        {
            InitializeComponent();

            //display username on the menu header
            _username = username;       
            mnuUser.Header = _username;
            SetMenuIcon();
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

        private void btnPlan_Click(object sender, RoutedEventArgs e)
        {
            //use constructors to transfer data like username and selected times and etc.
            JourneyPlanner planner = new JourneyPlanner(_username);
            planner.Show();
            this.Close();
        }

        private void mnuLogout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
