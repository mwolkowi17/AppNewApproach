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

namespace AppEduNewApproach
{
    /// <summary>
    /// Logika interakcji dla klasy FilmAFull.xaml
    /// </summary>
    public partial class FilmAFull : Page
    {
        public System.Windows.WindowStyle WindowStyle { get; set; }
        public System.Windows.WindowState WindowState { get; set; }

        public FilmAFull()
        {
            InitializeComponent();
            this.WindowStyle = WindowStyle.None;
            this.WindowState = WindowState.Maximized;
            ControlPanel.Visibility = Visibility.Hidden;
            // Film jeden = new Film(1, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\Dopalacze1_Wplyw_WERSJA2popr2-Ramsar_3000.mp4", "jedynka");
            //Video1.Source = new Uri(jeden.FilmAdress);
            Video1.Play();
            //Video1.Stop();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
            Video1.MouseDown += new MouseButtonEventHandler(video1_MouseMove);
        }
        private void buttonFilm_Click(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            this.NavigationService.Navigate(mainMenu);
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (Video1.Source != null)
            {
                if (Video1.NaturalDuration.HasTimeSpan)
                    lblStatus.Content = String.Format("{0} / {1}", Video1.Position.ToString(@"mm\:ss"), Video1.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));
            }
            else
                lblStatus.Content = "No file selected...";
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            Video1.Play();
            ControlPanel.Visibility = Visibility.Hidden;

        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            Video1.Pause();


        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            Video1.Stop();
        }

        private void btnLeave_Click(object sender, RoutedEventArgs e)
        {
            FilmA filmA = new FilmA();
            this.NavigationService.Navigate(filmA);
            //System.Windows.Application.Current.Shutdown();

        }



        private void Element_MediaOpened(object sender, EventArgs e)
        {
            timelineSlider.Maximum = Video1.NaturalDuration.TimeSpan.TotalMilliseconds;
        }

        private void Element_MediaEnded(object sender, EventArgs e)
        {
            Video1.Stop();
        }

        private void SeekToMediaPosition(object sender, RoutedPropertyChangedEventArgs<double> args)
        {
            int SliderValue = (int)timelineSlider.Value;

            // Overloaded constructor takes the arguments days, hours, minutes, seconds, milliseconds.
            // Create a TimeSpan with miliseconds equal to the slider value.
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, SliderValue);
            Video1.Position = ts;
        }

        private void buttonFilm_MouseEnter(object sender, MouseEventArgs e)
        {
            //PlanszaTypA ikonaC = new PlanszaTypA(1, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\D1_ikona3b.png", "Ikona3");
            //Klik.ImageSource = new ImageSourceConverter().ConvertFromString(ZbiorDanych.IkonyProgramu[7].IkoAdress) as ImageSource;
        }
        private void buttonFilm_MouseLeave(object sender, MouseEventArgs e)
        {
            //PlanszaTypA ikonaC = new PlanszaTypA(1, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\D1_ikona3.png", "Ikona3");
            //Klik.ImageSource = new ImageSourceConverter().ConvertFromString(ZbiorDanych.IkonyProgramu[3].IkoAdress) as ImageSource;
        }

        private void video1_MouseMove(object sender, MouseEventArgs e)
        {

            ControlPanel.Visibility = Visibility.Visible;
        }

        private void hide_control_panel(object sender, EventArgs e)
        {
            ControlPanel.Visibility = Visibility.Hidden;
        }

        private void video1_control_visilble(object sender, RoutedEventArgs e)
        {
            ControlPanel.Visibility = Visibility.Visible;
        }
    }
}
