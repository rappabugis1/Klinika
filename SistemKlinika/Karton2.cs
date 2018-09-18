using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemKlinika
{
    public sealed partial class Karton :Osoba
    {
        public class Terapija
        {
            private string davaocTerapije;
            private DateTime datumPropisa;
            private string nazivTer;
            private int trajanje;
            string komentar;

            public Terapija() { }

            public Terapija(string nazivTer, int trajanje, string davaocTerapije, string koomentar)
            {
                NazivTer = nazivTer;
                Trajanje = trajanje;
                DavaocTerapije = davaocTerapije;
                DatumPropisa = DateTime.Now;
                Komentar = koomentar;
            }

            public string NazivTer { get => nazivTer; set => nazivTer = value; }
            public int Trajanje { get => trajanje; set => trajanje = value; }
            public string DavaocTerapije { get => davaocTerapije; set => davaocTerapije = value; }
            public DateTime DatumPropisa { get => datumPropisa; set => datumPropisa = value; }
            public string Komentar { get => komentar; set => komentar = value; }
        };

        public class Pregled
        {
            string misljenjeDoktora, rezPregleda;
            Terapija terapija;
            DateTime datumPregleda;

            public Pregled() { terapija = null; }
            public Pregled(string misljenjeDoktora, string rezPregleda)
            {
                MisljenjeDoktora = misljenjeDoktora;
                RezPregleda = rezPregleda;
                terapija = null;
                DatumPregleda = DateTime.Now;
            }

            public string MisljenjeDoktora { get => misljenjeDoktora; set => misljenjeDoktora = value; }
            public string RezPregleda { get => rezPregleda; set => rezPregleda = value; }
            public DateTime DatumPregleda { get => datumPregleda; set => datumPregleda = value; }
            public Terapija Terapija { get => terapija; set => terapija = value; }
        };


    }
}
