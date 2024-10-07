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
    /// Interaction logic for ViewClaimsPage.xaml
    /// </summary>
    public partial class ViewClaimsPage : Page
    {
        public ViewClaimsPage()
        {
            InitializeComponent();
            LoadClaims();
        }

        private void LoadClaims()
        {
            // Logic to load and display claims in ClaimsList
        }
    }
}
