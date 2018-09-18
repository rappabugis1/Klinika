using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raspored;

namespace SistemKlinika

{
    public class Pacijent :Osoba
    {
        Karton karton;
        private RasZaPac raspored;
        private DateTime vrijemePrijema;
        private bool stanje;
        private Racun racun;
        Image slika;
        string ImeiPrezime;
        int brPosjeta;

        public Pacijent(bool stanje, string ime, string pr, string sp, string jmbg, string adr, DateTime dR, string user, StringBuilder pass, Image slika) : base(ime, pr, sp, jmbg, adr, dR, user, pass)
        {
            VrijemePrijema = DateTime.Now;
            Stanje = stanje;
            Racun = new Racun();
            Raspored = new RasZaPac();
            Slika = slika;
            Karton = null;
            ImeiPrezime1 = ime + " " + pr;
            BrPosjeta = 1;
        }

        void DodajRas(RasZaPac raspored)
        {
            Raspored = raspored;
        }

        public DateTime VrijemePrijema { get => vrijemePrijema; private set => vrijemePrijema = value; }
        public bool Stanje { get => stanje; set => stanje = value; }
        public RasZaPac Raspored { get => raspored; set => raspored = value; }
        public Racun Racun { get => racun; set => racun = value; }
        public Image Slika { get => slika; set => slika = value; }
        public Karton Karton { get => karton; set => karton = value; }
        public string ImeiPrezime1 { get => ImeiPrezime; set => ImeiPrezime = value; }
        public int BrPosjeta { get => brPosjeta; set => brPosjeta = value; }
    }
}
