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
    /// Interaction logic for ApproveClaimsPage.xaml
    /// </summary>
    public partial class ApproveClaimsPage : Page
    {
        public ApproveClaimsPage()
        {
            InitializeComponent();
            LoadPendingClaims();
        }

        private void LoadPendingClaims()
        {
            // Logic to load pending claims
        }

        private void ApproveClaim_Click(object sender, RoutedEventArgs e)
        {
            // Logic to approve selected claim
        }

        private void DenyClaim_Click(object sender, RoutedEventArgs e)
        {
            // Logic to deny selected claim
        }
    }
}
