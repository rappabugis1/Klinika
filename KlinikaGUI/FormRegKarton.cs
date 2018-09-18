using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemKlinika;

namespace KlinikaGUI
{
    public partial class FormRegKarton : Form
    {
        Pacijent pac;
        public FormRegKarton(Pacijent pac)
        {
            InitializeComponent();
            pac.Karton= new Karton(pac.Ime, pac.Prezime, pac.Spol, pac.Jmbg, pac.Adresa, pac.DatumRodjenja, pac.Username, pac.Password);
            this.pac = pac;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string bol in TrenBol.Lines)
                pac.Karton.BolestiSad.Add(bol);
            foreach (string bol in PrBol.Lines)
                pac.Karton.BolestiPrije.Add(bol);
            foreach (string bol in TrenAl.Lines)
                pac.Karton.AlergijeSad.Add(bol);
            foreach (string bol in PrAl.Lines)
                pac.Karton.AlergijePrije.Add(bol);
            pac.Karton.BrPosjeta = pac.BrPosjeta;
            MessageBox.Show("Karton datog pacijenta je uspostavljen!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
