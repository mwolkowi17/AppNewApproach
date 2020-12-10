using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AAppEduNewApproach;
using AppEduNewApproach.Models;

namespace AppEduNewApproach
{
    public class ZbiorDanych
    {
        //statyczne źródło danych do którego dodawane są adresy/linki do katalogu images gdzie przechowywane są media
        //każda lista odpowiada typowi planszy/części prezentacji (oprócz listy ikon oczywiście)
        public static List<PlanszaTypB> PlanszePodsumowojace { get; set; }
        public static List<IkonaApp> IkonyProgramu { get; set; }
        public static List<PlanszaTypA>PlanszePoczatkowe { get; set; }
        public static List<PlanszaTypC>PlanszePomoc { get; set; }
        public static List<QuizA>QuizzyPlanszeA { get; set; }

        static ZbiorDanych()
        {
            PlanszePodsumowojace = new List<PlanszaTypB>();
            PlanszePodsumowojace.Add(new PlanszaTypB(1, @"Images/pytanie1.jpg", "nowe"));
            PlanszePodsumowojace.Add(new PlanszaTypB(2, @"Images/pytanie2.jpg", "nowe2"));
            PlanszePodsumowojace.Add(new PlanszaTypB(3, @"Images/pytanie3.jpg", "nowe3"));
            PlanszePodsumowojace.Add(new PlanszaTypB(4, @"Images/pytanie4.jpg", "nowe4"));
            PlanszePodsumowojace.Add(new PlanszaTypB(5, @"Images/pytanie5.jpg", "nowe5"));
            PlanszePodsumowojace.Add(new PlanszaTypB(6, @"Images/pytanie6.jpg", "nowe6"));
            PlanszePodsumowojace.Add(new PlanszaTypB(7, @"Images/pytanie7.jpg", "nowe7"));

            IkonyProgramu = new List<IkonaApp>();

            IkonyProgramu.Add(new IkonaApp(1, @"Images/D1_ikona1_wersja2.png", "Ikona1"));
            IkonyProgramu.Add(new IkonaApp(2, @"Images/D1_ikona2.png", "Ikona2"));
            IkonyProgramu.Add(new IkonaApp(3, @"Images/D1_ikona3.png", "Ikona3"));
            IkonyProgramu.Add(new IkonaApp(3, @"Images/trojkat_dalej.png", "strzalka_dalej"));
            IkonyProgramu.Add(new IkonaApp(1, @"Images/D1_ikona1_wersja2b.png", "Ikona4"));
            IkonyProgramu.Add(new IkonaApp(2, @"Images/D1_ikona2b.png", "Ikona5"));
            IkonyProgramu.Add(new IkonaApp(3, @"Images/D1_ikona3b.png", "Ikona6"));
            IkonyProgramu.Add(new IkonaApp(3, @"Images/trojkat_dalej2.png", "strzalka_dalej"));
            IkonyProgramu.Add(new IkonaApp(4, @"Images/menu_text1.png", "menu_text"));
            IkonyProgramu.Add(new IkonaApp(5, @"Images/exit_text2.png", "exit_text"));
            IkonyProgramu.Add(new IkonaApp(6, @"Images/exit_text2_mouse.png", "exit_text_mouse"));
            IkonyProgramu.Add(new IkonaApp(7, @"Images/menu_text1_mouse.png", "menu_text_mouse"));

            PlanszePoczatkowe = new List<PlanszaTypA>();

            PlanszePoczatkowe.Add(new PlanszaTypA(1, @"Images/grzyby_app.jpg", "nowe1"));
            PlanszePoczatkowe.Add(new PlanszaTypA(2, @"Images/grzyby_app2.jpg", "nowe2"));
            PlanszePoczatkowe.Add(new PlanszaTypA(3, @"Images/grzyby_app3.jpg", "nowe3"));
            PlanszePoczatkowe.Add(new PlanszaTypA(4, @"Images/grzyby_app4.jpg", "nowe4"));
            PlanszePoczatkowe.Add(new PlanszaTypA(5, @"Images/grzyby_app5.jpg", "nowe5"));
            PlanszePoczatkowe.Add(new PlanszaTypA(6, @"Images/grzyby_app6.jpg", "nowe6"));

            PlanszePomoc = new List<PlanszaTypC>();

            PlanszePomoc.Add(new PlanszaTypC(1, @"Images/pierwsza_pomoc1_2x.jpg", "nowe1"));
            PlanszePomoc.Add(new PlanszaTypC(2, @"Images/pierwsza_pomoc2_2x.jpg", "nowe2"));
            PlanszePomoc.Add(new PlanszaTypC(3, @"Images/pierwsza_pomoc3A_2x.jpg", "nowe3"));
            PlanszePomoc.Add(new PlanszaTypC(4, @"Images/pierwsza_pomoc3B_2x.jpg", "nowe4"));
            PlanszePomoc.Add(new PlanszaTypC(5, @"Images/pierwsza_pomoc4A_2x.jpg", "nowe5"));
            PlanszePomoc.Add(new PlanszaTypC(6, @"Images/pierwsza_pomoc5A_2x.jpg", "nowe6"));
            PlanszePomoc.Add(new PlanszaTypC(7, @"Images/pierwsza_pomoc5B_2x.jpg", "nowe7"));
            PlanszePomoc.Add(new PlanszaTypC(8, @"Images/pierwsza_pomoc6A_2x.jpg", "nowe8"));
            PlanszePomoc.Add(new PlanszaTypC(9, @"Images/pierwsza_pomoc6B_2x.jpg", "nowe9"));
            PlanszePomoc.Add(new PlanszaTypC(10, @"Images/pierwsza_pomoc6C_2x.jpg", "nowe10"));
            PlanszePomoc.Add(new PlanszaTypC(11, @"Images/pierwsza_pomoc7_2x.jpg", "nowe11"));
            PlanszePomoc.Add(new PlanszaTypC(12, @"Images/pierwsza_pomoc8_2x.jpg", "nowe12"));

            QuizzyPlanszeA = new List<QuizA>();

            QuizzyPlanszeA.Add(new QuizA(1, @"Images/grzyby_app_quizz1.jpg", "nowy1", 2));
            QuizzyPlanszeA.Add(new QuizA(2, @"Images/grzyby_app_quizz2.jpg", "nowy2", 2));
        }
    }
}
