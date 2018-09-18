using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemKlinika
{
    public class OsobaRad : Osoba
    {
        private int plata;
        private string pozicija;
        public OsobaRad(string ime, string pr, string sp, string jmbg, string adr, DateTime dR, string user, StringBuilder pass, string poz, int plata) : base(ime, pr, sp, jmbg, adr, dR, user, pass)
        {
            Plata = plata;
            Pozicija = poz;
        }

        public int Plata { get => plata; set => plata = value; }
        public string Pozicija { get => pozicija; set => pozicija = value; }

        public virtual int PrikaziPlatu()
        {
            return Plata;
        }
    }
}
