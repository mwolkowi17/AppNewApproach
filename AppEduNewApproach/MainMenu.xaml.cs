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
    /// Logika interakcji dla klasy MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        
        
        public MainMenu()
        {
            InitializeComponent();
            
        }

        private void ButtonAClick(object sender, RoutedEventArgs e)
        {
            
            PlanszeA planszaA = new PlanszeA(Dane.DataContext);
            
            this.NavigationService.Navigate(planszaA);
        }

        private void ButtonCClick(object sender, RoutedEventArgs e)
        {
            QuizzesA quizzesA = new QuizzesA();
            this.NavigationService.Navigate(quizzesA);
        }

        private void ButtonBClick(object sender, RoutedEventArgs e)
        {
            FilmA filmA = new FilmA();
            this.NavigationService.Navigate(filmA);
        }

        private void ExitApp(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
