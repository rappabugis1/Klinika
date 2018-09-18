using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemKlinika
{
    public abstract  class Osoba
    {
        private DateTime datumRodjenja;
        private string ime;
        private string prezime;
        private string spol;
        private string jmbg;
        private string adresa;
        private string username;
        private StringBuilder password;

        public DateTime DatumRodjenja { get => datumRodjenja; private set => datumRodjenja = value; }
        public string Ime { get => ime; private set => ime = value; }
        public string Prezime { get => prezime; private set => prezime = value; }
        public string Spol { get => spol; private set => spol = value; }
        public string Jmbg { get => jmbg; private set => jmbg = value; }
        public string Adresa { get => adresa; private set => adresa = value; }
        public string Username { get => username; set => username = value; }
        public StringBuilder Password { get => password; set => password = value; }

        public Osoba(string ime, string prezime, string spol, string jmbg, string adresa, DateTime datumRodjenja, string user, StringBuilder pass)
        {
            DatumRodjenja = datumRodjenja;
            Ime = ime;
            Prezime = prezime;
            Spol = spol;
            Jmbg = jmbg;
            Adresa = adresa;
            Username = user;
            Password = pass;
        }

    }
}
