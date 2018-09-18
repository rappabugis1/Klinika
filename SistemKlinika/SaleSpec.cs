using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raspored;

namespace SistemKlinika
{
    public class SaleSpec : Sale
    {
        private string masina;
        private OsRadMedTeh tehnicar;
        private bool kvarMas;

        public SaleSpec(string naziv, int c, string masina, bool kvarMas) : base(naziv, c)
        {
            Masina = masina;
            Tehnicar = null;
            KvarMas = false;
        }

        public string Masina { get => masina; set => masina = value; }
        public OsRadMedTeh Tehnicar { get => tehnicar; set => tehnicar = value; }
        public bool KvarMas { get => kvarMas; set => kvarMas = value; }
    }
}
