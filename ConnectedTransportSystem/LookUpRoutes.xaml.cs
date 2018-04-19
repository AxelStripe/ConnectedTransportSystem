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
    /// Interaction logic for LookUpRoutes.xaml
    /// </summary>
    public partial class LookUpRoutes : Window
    {
        private string _username;
        private List<string> routes;

        public LookUpRoutes(string username, string begin, string startTime, string end, string endTime)
        {
            InitializeComponent();

            _username = username;

            mnuUser.Header = _username;

            SetMenuIcon();

            LoadRoutes(begin, startTime, end, endTime);
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

        void LoadRoutes(string begin, string startTime, string end, string endTime)
        {
            routes = new List<string>();

            routes.Add("Start: " + begin + " " + startTime + " Destination: " + end + " " + endTime);

            foreach(string r in routes)
            {
                lstRoutes.Items.Add(r);
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            JourneyPlanner journeyPlanner = new JourneyPlanner(_username);
            journeyPlanner.Show();
            this.Hide();
        }

        private void mnuLogout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
