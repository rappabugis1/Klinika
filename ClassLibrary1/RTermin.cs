using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raspored
{
    public class RTermin
    {
        private string ime;
        private int broj;
        string svrha;
        string sifraKartona;

        public RTermin(string ime, int broj, string sifra, string svrha)
        {
            Ime = ime;
            Broj = broj;
            Svrha = svrha;
            SifraKartona = sifra;
        }

        public string Ime { get => ime; private set => ime = value; }
        public int Broj { get => broj; private set => broj = value; }
        public string Svrha { get => svrha; set => svrha = value; }
        public string SifraKartona { get => sifraKartona; set => sifraKartona = value; }
    }
}
