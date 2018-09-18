using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemKlinika
{
    public sealed partial class Karton : Osoba
    {
        DateTime vrijemeSmrti, vrijemeAbdukcije;
        int  brPosjeta;
        string uzrokSmrti;
        List<Pregled> pregledi;
        List<String> bolestiSad, bolestiPrije, alergijeSad, alergijePrije;
        DateTime datumPravljenja;
        string sifra;

        public DateTime VrijemeSmrti { get => vrijemeSmrti; set => vrijemeSmrti = value; }
        public DateTime VrijemeAbdukcije { get => vrijemeAbdukcije; set => vrijemeAbdukcije = value; }
        public string UzrokSmrti { get => uzrokSmrti; set => uzrokSmrti = value; }
        public List<Pregled> Pregledi { get => pregledi; set => pregledi = value; }
        public int BrPosjeta { get => brPosjeta;  set => brPosjeta = value; }
        public List<string> BolestiSad { get => bolestiSad; set => bolestiSad = value; }
        public List<string> BolestiPrije { get => bolestiPrije; set => bolestiPrije = value; }
        public List<string> AlergijeSad { get => alergijeSad; set => alergijeSad = value; }
        public List<string> AlergijePrije { get => alergijePrije; set => alergijePrije = value; }
        public DateTime DatumPravljenja { get => datumPravljenja; set => datumPravljenja = value; }
        public string Sifra { get => sifra; set => sifra = value; }

        public Karton(string ime, string pr, string sp, string jmbg, string adr, DateTime dR, string user, StringBuilder pass) : base(ime,pr, sp, jmbg, adr, dR,user, pass)
        {
            BrPosjeta = 0;
            Pregledi = new List<Pregled>();
            BolestiPrije = new List<string>();
            BolestiSad = new List<string>();
            AlergijePrije = new List<string>();
            AlergijeSad = new List<string>();
            DatumPravljenja = DateTime.Now;
            Random rnd = new Random(Convert.ToInt32(jmbg.Substring(0,7))/2);
            Sifra = Convert.ToString(rnd.Next(1, (int)(Convert.ToInt32(jmbg.Substring(0, 7))/2)));
        }

        public void HitniSlucaj(string protokol, string razlog, bool preminuo=false, DateTime vrijemeSmrti= new DateTime(), string uzrokSmrti="", DateTime vrijemeAbdukcije= new DateTime())
        {
            Pregledi.Add(new Pregled(razlog, protokol));
            if (preminuo)
            {
                VrijemeSmrti = vrijemeSmrti;
                UzrokSmrti = uzrokSmrti;
                VrijemeAbdukcije = vrijemeAbdukcije;
            }
        }

    }
}
