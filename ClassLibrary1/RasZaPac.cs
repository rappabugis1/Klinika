using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raspored
{
    public class RasZaPac : IRaspored
    {
        //broj je pacijentov redni broj
        private List<RTermin> tabela;

        public RasZaPac() { Tabela = new List<RTermin>(); }
        public RasZaPac(List<RTermin> tabela) { Tabela = tabela; }

        public List<RTermin> Tabela { get => tabela; set => tabela = value; }

        public void ZakaziTermin(RTermin termin)
        {
            tabela.Add(termin);
            tabela.Sort((s1, s2) => s1.Broj.CompareTo(s2.Broj));
        }

        public RTermin DajSljedeci()
        {
            return tabela.ElementAt(0);
        }

    }
}
