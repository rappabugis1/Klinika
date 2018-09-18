using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemKlinika
{
    public sealed class Klinika
    {
        List<Pacijent> pacijenti;
        List<OsobaRad> osoblje;
        List<Sale> sale;

        public List<Pacijent> Pacijenti { get => pacijenti; set => pacijenti = value; }
        public List<OsobaRad> Osoblje { get => osoblje; set => osoblje = value; }
        
        public List<Sale> Sale { get => sale; set => sale = value; }

        private StringBuilder MD(string password)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(password);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder test = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                test.Append(hash[i].ToString("X2"));
            }

            return test;
        }

        public Klinika()
        {
            Pacijenti = new List<Pacijent>();
            Osoblje = new List<OsobaRad>();
            Sale = new List<Sale>();

            Pacijenti.Add(new Pacijent(true, "Mahmut", "Saburli", "Musko", "1234567891234", "Ilidza", DateTime.Now, "Mah", MD("1234"), null));

            Osoblje.Add(new OsRadDok("Mahmut", "Saburli", "Musko", "1234567891234","Ilidza",DateTime.Now, "Mahnu", MD("1234"), "Doktor", 1000, false, "Kardiolog"));
            Osoblje.Add(new OsRadDok("Ferhat", "Cokoric", "Musko", "2134567891234", "Sarajevo", DateTime.Now, "Ferhat", MD("1234"), "Doktor", 1000, false, "Ortoped"));
            Osoblje.Add(new OsRadDok("Suljo", "Findic", "Musko", "1934567891234", "Mars", DateTime.Now, "Suljo", MD("1234"), "Doktor", 1000, false, "Ortorinolog"));
            Osoblje.Add(new OsRadDok("Ajla", "Spahic", "Zensko", "9234567891234", "Grad", DateTime.Now, "Ajla", MD("1234"), "Doktor", 1000, false, "Kozne bolesti"));
            Osoblje.Add(new OsRadDok("Sulejman", "Velicanstveni", "Musko", "0234567891234", "Kuci", DateTime.Now, "Sulejman", MD("1234"), "Doktor", 1000, false, "Opca medicina"));
            Osoblje.Add(new OsRadMedTeh("Huja", "Velika", "Musko", "0234567801234", "Prekoputa", DateTime.Now, "Huja", MD("1234"), "Med teh", 500, false));

            Sale.Add(new Sale("Ortopedija", 30));
            Sale.Add(new Sale("Porodica medicina", 10));
            Sale.Add(new Sale("Usno", 10));
            Sale.Add(new SaleSpec("Ultrazvuk", 40, "Rengen", false));
            Sale.Add(new SaleSpec("Sonarna pretraga", 15, "Sonar", false));
            Sale.Add(new Sale("Disaone bolesti", 25));

        }
    }
}
