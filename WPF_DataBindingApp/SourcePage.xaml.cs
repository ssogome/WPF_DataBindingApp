using System.Windows;
using System.Windows.Controls;

namespace WPF_DataBindingApp
{
    /// <summary>
    /// Interaction logic for SourcePage.xaml
    /// </summary>
    public partial class SourcePage : Page
    {
        public SourcePage()
        {
            InitializeComponent();
        }

        private void NextPageBtn_Click(object sender, RoutedEventArgs e)
        {
            // View Expense Report
            BindingPage bindingPage = new BindingPage();
            this.NavigationService.Navigate(bindingPage);

        }
       
    }
}
