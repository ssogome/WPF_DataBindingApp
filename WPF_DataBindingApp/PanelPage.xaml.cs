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
    /// Interaction logic for PanelPage.xaml
    /// </summary>
    public partial class PanelPage : Page
    {
        public PanelPage()
        {
            InitializeComponent();
        }

        private void ToWrapPanel_Click(object sender, RoutedEventArgs e)
        {
            WrapPanelPage wrap = new WrapPanelPage();
            this.NavigationService.Navigate(wrap);
        }
    }
}
