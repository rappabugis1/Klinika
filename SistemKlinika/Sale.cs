using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raspored;


namespace SistemKlinika
{
    public class Sale
    {
        private string naziv;
        private bool zauzetost, prisutnostDok;
        private RasZaSalu termini;
        private OsRadDok doktor;
        private int cijenaUsluge, brPosjeta;

        public Sale(string naziv, int cijena)
        {
            Naziv = naziv;
            Doktor = doktor;
            Zauzetost = false;
            prisutnostDok = true;
            Termini = new RasZaSalu();
            CijenaUsluge = cijena;
            BrPosjeta = 0;
            Doktor = null;
        }

        public string Naziv { get => naziv; private set => naziv = value; }
        public bool Zauzetost { get => zauzetost; set => zauzetost = value; }
        public bool PrisutnostDok { get => prisutnostDok; set => prisutnostDok = value; }
        public OsRadDok Doktor { get => doktor; set => doktor = value; }
        public int CijenaUsluge { get => cijenaUsluge; set => cijenaUsluge = value; }
        public int BrPosjeta { get => brPosjeta; set => brPosjeta = value; }
        public RasZaSalu Termini { get => termini; set => termini = value; }
    }
}
