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

namespace AppEduNewApproach
{
    /// <summary>
    /// Logika interakcji dla klasy PlanszeA.xaml
    /// </summary>
    public partial class PlanszeA : Page
    {
        public int n;
        public PlanszeA()
        {
            InitializeComponent();
            n = 2;
        }

        public PlanszeA(object data) :this()
        {
            this.DataContext = data;
        }

        private void ButtonForward(object sender, RoutedEventArgs e)
        {

            obrazekTypA.Source = new ImageSourceConverter().ConvertFromString($"Images/grzyby_app{n}.jpg") as ImageSource;
            n++;
            if (n > 6)
            {
                MainMenu mainMenu = new MainMenu();
                this.NavigationService.Navigate(mainMenu);
            }
            //PlanszeA1 planszeA1 = new PlanszeA1();
            //this.NavigationService.Navigate(planszeA1);
        }
    }
}
