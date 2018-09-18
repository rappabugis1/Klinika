using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemKlinika
{
    public class OsRadMedTeh : OsobaRad
    {
        private bool zauzetost;

        public  OsRadMedTeh(string ime, string pr, string sp, string jmbg, string adr, DateTime dR, string user, StringBuilder pass, string poz, int plata, bool zauzet) : base (ime, pr,sp,jmbg, adr, dR, user, pass, poz, plata)
        {
            Zauzetost = zauzet;
        }

        public bool Zauzetost { get => zauzetost; set => zauzetost = value; }
  
    }
}
