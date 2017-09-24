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

namespace WPF_DataBindingApp
{
    /// <summary>
    /// Interaction logic for WrapPanelPage.xaml
    /// </summary>
    public partial class WrapPanelPage : Page
    {
        public WrapPanelPage()
        {
            InitializeComponent();
        }

        private void ToDockPanelPage_Click(object sender, RoutedEventArgs e)
        {
            DockPanelPage dck = new DockPanelPage();
            this.NavigationService.Navigate(dck);
        }
    }
}
