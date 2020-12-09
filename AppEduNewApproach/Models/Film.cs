using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEduNewApproach
{
    public class Film
    {
        public int FilmId { get; set; }
        public string FilmAdress { get; set; }
        public string FilmName { get; set; }

        public Film(int id, string adress, string name)
        {
            FilmId = id;
            FilmAdress = adress;
            FilmName = name;
        }

        public override string ToString()
        {
            return FilmId + " " + FilmAdress + " " + FilmName;
        }
    }
}
