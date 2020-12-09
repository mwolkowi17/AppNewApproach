using AAppEduNewApproach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppEduNewApproach
{
    public class MetodyPomocnicze
        //cała logika wyświetlania plansz, strzałki na stronach uruchamiają metody wyświetlające plansze
        //metody te odpalane są w odpowiednich klasach w codebehind w AppDopWer1
        //tytuły metod odpowiadają typowi plansz odnosząc się do danych zawartych w klasie Zbiór Danych
    {
        public int Robocza { get; set; }
        public int IloscWKolekcji { get; set; }

        public MetodyPomocnicze()
        {

            IloscWKolekcji = ZbiorDanych.PlanszePodsumowojace.Count;
        }

        public PlanszaTypB PokazKolejna() // tu genralnie potrzebny jest parametr. I w dodatku chyba nie działa.
        {


            PlanszaTypB PlanszaPrezentacja = ZbiorDanych.PlanszePodsumowojace[Robocza];
            Robocza++;
            return PlanszaPrezentacja;
        }

        public PlanszaTypB PlanszaDalejB(int x, List<PlanszaTypB> kolekcja)
        {
            PlanszaTypB wynik;
            if (x < (kolekcja.Count - 1))
            {
                wynik = kolekcja[x + 1];
                //x++;

            }
            else
            {
                wynik = kolekcja[kolekcja.Count - 1];
            }
            return wynik;
        }

        public PlanszaTypA PlanszaDalejA(int x, List<PlanszaTypA> kolekcja)
        {
            PlanszaTypA wynik;
            if (x < (kolekcja.Count - 1))
            {
                wynik = kolekcja[x + 1];
                //x++;

            }
            else
            {
                wynik = kolekcja[kolekcja.Count - 1];
            }
            return wynik;
        }

        public PlanszaTypC PlanszaDalejC(int x, List<PlanszaTypC> kolekcja)
        {
            PlanszaTypC wynik;
            if (x < (kolekcja.Count - 1))
            {
                wynik = kolekcja[x + 1];
                //x++;

            }
            else
            {
                wynik = kolekcja[kolekcja.Count - 1];
            }
            return wynik;
        }
    }
}
