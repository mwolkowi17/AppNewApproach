using AppEduNewApproach.Models;
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
    /// Logika interakcji dla klasy QuizzesA.xaml
    /// </summary>
    public partial class QuizzesA : Page
    {
        public QuizA planszatestowa;
        public int n;
        public QuizzesA()
        {
            InitializeComponent();
            n = 0;
            MetodyPomocnicze nowa = new MetodyPomocnicze();
            planszatestowa = nowa.nowyQuizPlansza(n, ZbiorDanych.QuizzyPlanszeA);
            quizzysTypA.Source= new ImageSourceConverter().ConvertFromString(planszatestowa.QuizAAdress) as ImageSource;
            buttonFilm.Visibility = Visibility.Hidden;
            quizzanswer.Content = planszatestowa.QuizzAnswer;
            quizzanswer.Visibility = Visibility.Hidden;
        }

        private void Button_Forward(object sender, RoutedEventArgs e)
        {
            n++;
            MetodyPomocnicze nowa = new MetodyPomocnicze();
            planszatestowa = nowa.nowyQuizPlansza(n, ZbiorDanych.QuizzyPlanszeA);
            quizzysTypA.Source = new ImageSourceConverter().ConvertFromString(planszatestowa.QuizAAdress) as ImageSource;
            quizzanswer.Content = planszatestowa.QuizzAnswer;
            buttonFilm.Visibility = Visibility.Hidden;
            Button1.Visibility = Visibility.Visible;
            Button2.Visibility = Visibility.Visible;
            Button3.Visibility = Visibility.Visible;
            Button4.Visibility = Visibility.Visible;
            quizzanswer.Visibility = Visibility.Hidden;
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            if (planszatestowa.QuizzAButton == 1)
            {
                quizzysTypA.Source = new ImageSourceConverter().ConvertFromString(@"Images/grzyby_app5_good.jpg") as ImageSource;
                Button1.Visibility = Visibility.Hidden;
                Button2.Visibility = Visibility.Hidden;
                Button3.Visibility = Visibility.Hidden;
                Button4.Visibility = Visibility.Hidden;
                buttonFilm.Visibility = Visibility.Visible;
                quizzanswer.Visibility = Visibility.Visible;
            }
            else
            {
                quizzysTypA.Source = new ImageSourceConverter().ConvertFromString(@"Images/grzyby_app5_bad.jpg") as ImageSource;
                Button1.Visibility = Visibility.Hidden;
                Button2.Visibility = Visibility.Hidden;
                Button3.Visibility = Visibility.Hidden;
                Button4.Visibility = Visibility.Hidden;
                buttonFilm.Visibility = Visibility.Visible;
                quizzanswer.Visibility = Visibility.Visible;
            }
           
        }
    }
}
