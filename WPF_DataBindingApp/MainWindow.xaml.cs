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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : NavigationWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Hide();
                          
        }

        public void OpenFile()
        {
            Stream myStream = null;
            OpenFileDialog opfile = new OpenFileDialog();

            opfile.InitialDirectory = "c:\\";
            opfile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            opfile.FilterIndex = 2;
            opfile.RestoreDirectory = true;


            if (opfile.ShowDialog() == DialogResult.Value)
            {
                try
                {
                    if ((myStream = opfile.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Insert code to read the stream here.
                            System.IO.StreamReader sr = new System.IO.StreamReader(myStream);
                            MessageBox.Show(sr.ReadToEnd());
                            sr.Close();
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
               
            }
           

        }
    }
}
