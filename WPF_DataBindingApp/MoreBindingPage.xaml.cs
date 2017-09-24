using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using WPF_DataBindingApp.Model;

namespace WPF_DataBindingApp
{
    /// <summary>
    /// Interaction logic for MoreBindingPage.xaml
    /// </summary>
    public partial class MoreBindingPage : Page
    {
        //private List<User> users = new List<User>();
        private ObservableCollection<User> users = new ObservableCollection<User>();

        public MoreBindingPage()
        {
            InitializeComponent();
            this.DataContext = this;

            users.Add(new User() { Name = "John Dee" });
            users.Add(new User() { Name = "Jane Dee" });

            lbUsers.ItemsSource = users;
        }

        private void BtnUpdateSource_Click(object sender, RoutedEventArgs e)
        {
            BindingExpression binding = txtPageTitle.GetBindingExpression(TextBox.TextProperty);
            binding.UpdateSource();
        }

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            users.Add(new User() { Name = "New User" });
        }

        private void btnDeleteUser_Click(object sender, RoutedEventArgs e)
        {
            if(lbUsers.SelectedItem != null)
            {
                users.Remove(lbUsers.SelectedItem as User);
            }
        }

        private void btnChangedUser_Click(object sender, RoutedEventArgs e)
        {
            if(lbUsers.SelectedItem != null)
            {
                (lbUsers.SelectedItem as User).Name = "Random Name";
            }
        }

        private void ToCommandPage_Click(object sender, RoutedEventArgs e)
        {
            UsingCommandPage cmdpage = new UsingCommandPage();
            this.NavigationService.Navigate(cmdpage);
        }
    }
}
