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

namespace ST10039248_PROG6212
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void NavigateToSubmitClaim(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new SubmitClaimPage());
        }

        private void NavigateToViewClaims(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ViewClaimsPage());
        }

        private void NavigateToApproveClaims(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ApproveClaimsPage());
        }
    }
}
