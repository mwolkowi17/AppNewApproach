using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEduNewApproach
{
    public class IkonaApp
    {
        public int IkoId { get; set; }
        public string IkoAdress { get; set; }
        public string IkoName { get; set; }

        public IkonaApp(int id, string adress, string name)
        {
            IkoId = id;
            IkoAdress = adress;
            IkoName = name;
        }

        public IkonaApp(string adress)
        {
            IkoAdress = adress;
        }

        public override string ToString()
        {
            return IkoId + " " + IkoAdress;

        }
    }
}
