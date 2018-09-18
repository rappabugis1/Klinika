using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemKlinika
{
    public class Racun
    {
        public struct Usluga {
            private string naziv;
            private int cijena;

            public Usluga(string naziv, int cijena) : this()
            {
                Naziv = naziv;
                Cijena = cijena;
            }

            public string Naziv { get => naziv; set => naziv = value; }
            public int Cijena { get => cijena; set => cijena = value; }
        };

        private int suma;
        private List<Usluga> usluge;

        public int Suma { get => suma; set => suma = value; }
        public List<Usluga> Usluge { get => usluge; set => usluge = value; }

        public Racun()
        {
            Suma = 0;
            Usluge = new List<Usluga>();
        }    
    }
}
