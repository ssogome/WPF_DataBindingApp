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
    /// Interaction logic for OtherTesting.xaml
    /// </summary>
    public partial class OtherTesting : Page
    {
        ListBox lbox = new ListBox();

        public OtherTesting()
        {
            InitializeComponent();

            CreateControl();
        }    
        
        private void CreateControl()
        {
            
            StackPanel pnlMain = new StackPanel();
            pnlMain.Name = "MainPnl";
            pnlMain.Background = Brushes.Transparent;

            Button btn = new Button();
            btn.FontWeight = FontWeights.Bold;
            btn.Width = 200;

            WrapPanel pnl = new WrapPanel();

            TextBlock txt = new TextBlock();
            txt.Text = "Multi";
            txt.Foreground = Brushes.Blue;
            pnl.Children.Add(txt);

            txt = new TextBlock();
            txt.Text = "Button";
            txt.Width = 200;
            pnl.Children.Add(txt);

            btn.Content = pnl;
            pnlMain.Children.Add(btn);
            pnlMain.UpdateLayout();

            Grid gd = new Grid();
            gd.Background = Brushes.Azure;
            pnl = new WrapPanel();
          
            for(var i=0; i < 15; i++)
            {
                txt = new TextBlock();
                txt.Text = "Multi"+i;
                txt.Width = 150;
                txt.Foreground = Brushes.Blue;
                pnl.Children.Add(txt);
            }

            gd.Children.Add(pnl);
            pnlMain.Children.Add(gd);
            pnlMain.UpdateLayout();

            

            gd = new Grid();
            gd.Background = Brushes.Red;
            gd.Width = 100;
            gd.Height = 50;
            
            gd.MouseUp += new MouseButtonEventHandler(Gd_MouseUp);
            gd.MouseDown += new MouseButtonEventHandler(Gd_MouseUp);          

            pnlMain.Children.Add(gd);
            pnlMain.UpdateLayout();

            btn = new Button();
            btn.Background = Brushes.Green;
            btn.Content = "Test Me";
            btn.Click += Btn_Click;

            pnlMain.Children.Add(btn);

            //ListBox lbox = new ListBox();
            lbox.Background = Brushes.Red;
            pnlMain.Children.Add(lbox);

            btn = new Button();
            btn.Background = Brushes.Green;
            btn.Content = "Go To Next Page for More";
            btn.Click += GoToNextExperiment;

            pnlMain.Children.Add(btn);

            TextBlock tb = new TextBlock();
            tb.TextWrapping = TextWrapping.Wrap;
            tb.Margin = new Thickness(10);
            tb.Inlines.Add("An example on");
            tb.Inlines.Add(new Run("the text block control") { FontWeight = FontWeights.Bold });
            tb.Inlines.Add("using");
            tb.Inlines.Add(new Run("inline ") { FontStyle = FontStyles.Italic });
            tb.Inlines.Add(new Run(" text formatting ") { Background = Brushes.Beige });
            tb.Inlines.Add("from ");
            tb.Inlines.Add(new Run("Code Behind ") { TextDecorations = TextDecorations.Underline });
            tb.Inlines.Add(".");

            pnlMain.Children.Add(tb);

            this.Content = pnlMain;

        }

        private void GoToNextExperiment(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
            TextBlockExperimentPage newpage = new TextBlockExperimentPage();
            this.NavigationService.Navigate(newpage);
        }

         private void Btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("It is working!!!!");
            lbox.Items.Add(Application.Current.FindResource("strApp").ToString());
        }

        private void Gd_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("You clicked me at " + e.GetPosition(this).ToString());
            string s = null;
            try
            {
                s.Trim();
            }
            catch(Exception ex)
            {
                MessageBox.Show("A handled exception just occurred: " + ex.Message, "Exception Sample.", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            s.Trim();
        }
    }
}
