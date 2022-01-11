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
using System.Windows.Threading;

namespace Projekt2_Verseny_JakabLaszlo_11B
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer idozito;
        int idoSzamlalo = new int();
        Random rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();
            idozito = new DispatcherTimer();
            idozito.Interval = TimeSpan.FromSeconds(1);
            idozito.Tick += new EventHandler(IdozitoFeladata);

           
        }

        private SolidColorBrush[] szinek = new SolidColorBrush[3]
        {
             Brushes.Green, Brushes.Red, Brushes.Gray
        };


        private void IdozitoFeladata(object sender, EventArgs e)
        {
            int vapor = rnd.Next(1, 3);
            int supreme = rnd.Next(1, 3);
            int nexus = rnd.Next(1, 3);

            ++idoSzamlalo;
            koriVapor.Margin = new Thickness(koriVapor.Margin.Left * vapor , 70, 0, 0);
            koriSupreme.Margin = new Thickness(koriSupreme.Margin.Left * supreme, 215, 0, 0);
            koriNexus.Margin = new Thickness(koriNexus.Margin.Left * nexus, 355, 0, 0);

            if (koriVapor.Margin.Left >= vegeVonal.Margin.Left + 420)
            {
                koriVapor.Margin = new Thickness(vegeVonal.Margin.Left + 420, 70, 0, 0);
                
            }

            if (koriSupreme.Margin.Left >= vegeVonal.Margin.Left + 420)
            {
                koriSupreme.Margin = new Thickness(vegeVonal.Margin.Left + 420, 215, 0, 0);
            }

            if (koriNexus.Margin.Left >= vegeVonal.Margin.Left + 420)
            {
                koriNexus.Margin = new Thickness(vegeVonal.Margin.Left + 420, 355, 0, 0);
            }
            
            
            if (koriVapor.Margin.Left + 420 >= vegeVonal.Margin.Left + 420 && koriNexus.Margin.Left >= vegeVonal.Margin.Left + 420 && koriSupreme.Margin.Left >= vegeVonal.Margin.Left + 420)
            {
                ujfutamGomb.IsEnabled = true;
                
            }

            if (koriVapor.Margin.Left  >= vegeVonal.Margin.Left + 420)
            {
                
                
                eredmenyek.Content = "Az első korcsolya győzőtt" + " 3p";
                eredmenyek.FontSize = 20;


            }
            if (koriSupreme.Margin.Left >= vegeVonal.Margin.Left + 420)
            {
                eredmenyek.Content = "Az második korcsolya győzőtt" + " 3p";
                eredmenyek.FontSize = 20;
            }
            if (koriNexus.Margin.Left  >= vegeVonal.Margin.Left + 420)
            {
                eredmenyek.Content = "A harmadik korcsolya győzőtt" + " 3p";
                eredmenyek.FontSize = 20;

            }
           
        }

        private void startGomb_Click(object sender, RoutedEventArgs e)
        {
            idozito.Start();
            startGomb.IsEnabled = false;
            ujfutamGomb.IsEnabled = false;
          
        }

        private void ujfutamGomb_Click(object sender, RoutedEventArgs e)
        {
            
            idozito.Stop();
            ujfutamGomb.IsEnabled = true;
            koriVapor.Margin = new Thickness( 32, 70, 0, 0);
            koriSupreme.Margin = new Thickness( 32, 215, 0, 0);
            koriNexus.Margin = new Thickness( 32, 355, 0, 0);
            eredmenyek.Content = "";
            

           
            startGomb.IsEnabled = true;
        }

        private void ujbajnoksagGomb_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("");
        }
    }
  
}
