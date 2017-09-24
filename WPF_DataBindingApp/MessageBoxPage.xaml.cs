using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for MessageBoxPage.xaml
    /// </summary>
    public partial class MessageBoxPage : Page
    {
        public MessageBoxPage()
        {
            InitializeComponent();           
        }


        private void ExitCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void ExitCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void DisplayMsg_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello world!", "MsgBox with Title");
        }

        private void MsgWithXtraBtn_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("This MessageBox has extra options.\n\nHello, world?", "My App", MessageBoxButton.YesNoCancel);

            MessageBoxResult result = MessageBox.Show("This MessageBox has extra options.\n\nHello, world?", "My App", MessageBoxButton.YesNoCancel);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    MessageBox.Show("You clicked \"Yes\". \n Hello to you too!", "My App");
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("You clicked \"No\". \n Oh well, too bad!", "My App");
                    break;
                case MessageBoxResult.Cancel:
                    MessageBox.Show("You clicked \"Cancel\". \n Nevermind then...", "My App");
                    break;
            }
        }

        private void MsgWithIcon_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello, world!", "My App", MessageBoxButton.OK, MessageBoxImage.Information);
            MessageBox.Show("Hello, world!", "My App", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            MessageBox.Show("Hello, world!", "My App", MessageBoxButton.OK, MessageBoxImage.Error);
            MessageBox.Show("Hello, world!", "My App", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            MessageBox.Show("Hello, world!", "My App", MessageBoxButton.OK, MessageBoxImage.Hand);
            MessageBox.Show("Hello, world!", "My App", MessageBoxButton.OK, MessageBoxImage.None);
            MessageBox.Show("Hello, world!", "My App", MessageBoxButton.OK, MessageBoxImage.Question);
            MessageBox.Show("Hello, world!", "My App", MessageBoxButton.OK, MessageBoxImage.Stop);
            MessageBox.Show("Hello, world!", "My App", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            // openFileDialog.Filter = "Image files (*.png;*.jpeg)|*.png;*.jpeg|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
                txtEditor.Text = File.ReadAllText(openFileDialog.FileName);
        }

        private void btnOpenMultiFiles_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (openFileDialog.ShowDialog() == true)
            {
                foreach (string filename in openFileDialog.FileNames)
                    lbFiles.Items.Add(System.IO.Path.GetFileName(filename));
            }
        }

        private void btnSaveFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, savetxtEditor.Text);
        }

        private void GoToCustomWindow_Click(object sender, RoutedEventArgs e)
        {
            //CustomInputWindow wd = new CustomInputWindow("Your question", "Your answer");
            //this.NavigationService.Navigate(wd);
            MessageBox.Show("Take a break!!!");
            Application.Current.Shutdown();
        }
    }
}
