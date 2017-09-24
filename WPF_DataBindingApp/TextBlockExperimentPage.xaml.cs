using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace WPF_DataBindingApp
{
    /// <summary>
    /// Interaction logic for TextBlockExperimentPage.xaml
    /// </summary>
    public partial class TextBlockExperimentPage : Page
    {
        public TextBlockExperimentPage()
        {
            InitializeComponent();
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(e.Uri.AbsoluteUri);
        }

        private void TextBoxSelectionHasChanged(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            txtStatus.Text = "Selection starts at character #" + textBox.SelectionStart + Environment.NewLine;
            txtStatus.Text += "Selection is " + textBox.SelectionLength + " character(s) long" + Environment.NewLine;
            txtStatus.Text += "Selected text: '" + textBox.SelectedText + "'";
        }

        private void ToPanelPageBtn_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
            PanelPage panelpage = new PanelPage();
            this.NavigationService.Navigate(panelpage);
        }
    }
}
