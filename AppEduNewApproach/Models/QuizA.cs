using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEduNewApproach.Models
{
   public class QuizA
    {
        public int QuizAId { get; set; }
        public string QuizAAdress { get; set; }
        public string QuizzAName { get; set; }
        public int QuizzAButton { get; set; }
        public string QuizzAnswer { get; set; }
        // mechanim sprawdzania jeśli button się zgadza wyświetla planszę wynik i dodaje punkty

        public QuizA(int id, string adress, string name, int button)
        {
            QuizAId = id;
            QuizAAdress = adress;
            QuizzAName = name;
            QuizzAButton = button;
          
        }

        public QuizA(int id, string adress, string name, int button, string answer)
        {
            QuizAId = id;
            QuizAAdress = adress;
            QuizzAName = name;
            QuizzAButton = button;
            QuizzAnswer = answer;

        }
    }
}
