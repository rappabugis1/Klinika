using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemKlinika
{
    public class OsRadDok : OsRadMedTeh
    {
        private int brPreg;
        private string specijalizacija;

        public OsRadDok(string ime, string pr, string sp, string jmbg, string adr, DateTime dR, string user, StringBuilder pass, string poz, int plata, bool zauzet=false,string spec= null, int br =0) : base (ime,pr,sp,jmbg,adr,dR, user, pass, poz,plata,zauzet)
        {
            BrPreg = br;
            Zauzetost = zauzet;
            Specijalizacija = spec;
        }

        public int BrPreg { get => brPreg; set => brPreg = value; }
        public string Specijalizacija { get => specijalizacija; set => specijalizacija = value; }

        public override int PrikaziPlatu()
        {
            return Plata + brPreg*2;
        }
    }
}
