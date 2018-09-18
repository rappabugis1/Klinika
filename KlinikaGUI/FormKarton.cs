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
    public partial class FormKarton : Form
    {
        Karton karton;

        public FormKarton(Karton karton)
        {
            InitializeComponent();

            this.karton = karton;
            this.label13.Text = karton.Ime;
            this.label14.Text = karton.Prezime;
            this.label15.Text = karton.Jmbg;
            this.label16.Text = karton.Adresa;
            this.label17.Text = Convert.ToString(karton.DatumRodjenja);
            this.label18.Text = karton.Spol;
            this.label1.Text = Convert.ToString(karton.BrPosjeta);

            foreach (string bol in karton.BolestiSad)
                this.listTrBol.Items.Add(bol);
            foreach (string bol in karton.BolestiPrije)
                this.listPrBol.Items.Add(bol);
            foreach (string al in karton.AlergijeSad)
                this.listTrAler.Items.Add(al);
            foreach (string al in karton.AlergijePrije)
                this.listPrAler.Items.Add(al);

            foreach (Karton.Pregled pregled in karton.Pregledi)
                this.listBoxPregledi.Items.Add(pregled);
            this.listBoxPregledi.DisplayMember = "DatumPropisa";

            this.listBoxPregledi.SelectedIndexChanged += prikaziPregled;
        
        }

        private void prikaziPregled (Object sender, EventArgs e)
        {
            Karton.Pregled pregled = (Karton.Pregled)this.listBoxPregledi.SelectedItem;
            this.datumvar.Text = Convert.ToString(pregled.DatumPregleda);
            this.richTextRe.Text = pregled.RezPregleda;
            this.richTextMis.Text = pregled.MisljenjeDoktora;

            if (pregled.Terapija != null)
            {
                this.InforNazivter.Text = pregled.Terapija.NazivTer;
                this.InfoTrajanje.Text = Convert.ToString(pregled.Terapija.Trajanje);
                this.InfoDavaoc.Text = pregled.Terapija.DavaocTerapije;
                this.InfoDatumprop.Text = Convert.ToString(pregled.Terapija.DatumPropisa);
                this.richTextBoxkomentar.Text = pregled.Terapija.Komentar;
            }
            else
            {
                this.InforNazivter.Text = "x";
                this.InfoTrajanje.Text = "x";
                this.InfoDavaoc.Text = "x";
                this.InfoDatumprop.Text = "x";
                this.richTextBoxkomentar.Text = "";
            }
        }
    }
}
